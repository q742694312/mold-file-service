using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketDemo.Core.Models;
using Newtonsoft.Json;
namespace WebSocketDemo.Core.Controllers
{
    public class WebSocketCoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 文件传输对象
        public static FileUploadDTO uploadDTO = new FileUploadDTO();

        // 文件列表，全部采用内存处理，可自行改为数据存储
        public static Dictionary<int, FileUploadDTO> fileDatas = new Dictionary<int, FileUploadDTO>();

        public sc_message info { get; set; }

        /// <summary>
        /// 下载文件WebSocket
        /// </summary>
        /// <param name="fileUploadDTO">传入的文件模型</param>
        public async Task DownLoad(FileUploadDTO fileUploadDTO)
        {
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                if (fileUploadDTO != null && fileUploadDTO.FileSize > 0)
                {
                    uploadDTO = fileUploadDTO;
                    uploadDTO.FileID = fileDatas.Count();
                    fileDatas.Add(fileDatas.Count(), uploadDTO);
                }
                using WebSocket webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                await DownLoadHandle(HttpContext, webSocket);
            }
            else
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }

        }

        public async Task UpLoad()
        {
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                WebSocket webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                HttpContext hx = HttpContext;
                var buffer = new byte[5*1024*1024];
                WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                while (!result.CloseStatus.HasValue)
                {
                    if (result.MessageType== WebSocketMessageType.Text)
                    {
                        //var str_temp = Encoding.UTF8.GetString(buffer).TrimEnd('\0');
                        var str_temp = Encoding.UTF8.GetString(buffer, 0, result.Count);

                        sc_message dt = JsonConvert.DeserializeObject<sc_message>(str_temp);
                        dt.code = hx.Response.StatusCode;

                        info= dt;

                        var serverMsg = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dt));
                        //向客户端发送消息
                        await webSocket.SendAsync(new ArraySegment<byte>(serverMsg, 0, serverMsg.Length), result.MessageType, result.EndOfMessage, CancellationToken.None);
                    }
                }
                //关闭释放与客户端连接
                await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
 
            }
            else
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }

 
        public void CombinFile(FileInfo[] strFile, string strPath)
        {
            FileStream AddStream = null;
            //以合并后的文件名称和打开方式来创建、初始化FileStream文件流
            AddStream = new FileStream(strPath, FileMode.Append);
            //以FileStream文件流来初始化BinaryWriter书写器，此用以合并分割的文件
            BinaryWriter AddWriter = new BinaryWriter(AddStream);
            FileStream TempStream = null;
            BinaryReader TempReader = null;
            //循环合并小文件，并生成合并文件
            for (int i = 0; i < strFile.Length; i++)
            {
                //以小文件所对应的文件名称和打开模式来初始化FileStream文件流，起读取分割作用
                TempStream = new FileStream(strFile[i].ToString(), FileMode.Open);
                TempReader = new BinaryReader(TempStream);
                //读取分割文件中的数据，并生成合并后文件
                AddWriter.Write(TempReader.ReadBytes((int)TempStream.Length));
                //关闭BinaryReader文件阅读器
                TempReader.Close();
                //关闭FileStream文件流
                TempStream.Close();
            }
            //关闭BinaryWriter文件书写器
            AddWriter.Close();
            //关闭FileStream文件流
            AddStream.Close();
        }
        /// <summary>
        /// 获取文件列表WebSocket
        /// </summary>
        public async Task GetAllFile()
        {
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                using WebSocket webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                await FileTableHandle(HttpContext, webSocket);
            }
            else
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="socketContext">WebSocket上下文</param>
        /// <returns></returns>
        public async Task DownLoadHandle(HttpContext socketContext, WebSocket webSocket)
        {
            CancellationToken cancellation = new CancellationToken();
            while (webSocket.State == WebSocketState.Open)
            {
                byte[] bufferInit = new byte[1024];

                ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[uploadDTO.FileSize]);
                if (uploadDTO.FileSize < 1024)
                {
                    buffer = new ArraySegment<byte>(bufferInit);
                }

                // 等待接收
                WebSocketReceiveResult result = await webSocket.ReceiveAsync(buffer, cancellation);

                // 可以得到客户端发送过来的数据；
                string userMessage = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);

                if (userMessage.Contains("DownLoad"))
                {
                    int.TryParse(userMessage.Split('-')[1], out int downFileID);
                    if (webSocket.State == WebSocketState.Open)
                    {
                        ArraySegment<byte> sendBuf = GetFileByteBySavePath(downFileID);
                        await webSocket.SendAsync(sendBuf, WebSocketMessageType.Binary, true, cancellation);
                    }
                }
                else if (!string.IsNullOrEmpty(userMessage))
                {
                    //存储文件
                    SaveFile(buffer.Array, uploadDTO);
                }
                await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
                // 刷新Table
                var trStr = InitFileTable();
                ArraySegment<byte> sendTableBuf = new ArraySegment<byte>(Encoding.UTF8.GetBytes(trStr));
                if (webSocket.State == WebSocketState.Open)
                {
                    await webSocket.SendAsync(sendTableBuf, WebSocketMessageType.Text, true, cancellation);
                }
            }

        }


        /// <summary>
        /// 文件列表WebSock
        /// </summary>
        /// <param name="socketContext">WebSocket上下文</param>
        /// <returns></returns>
        public async Task FileTableHandle(HttpContext socketContext, WebSocket webSocket)
        {
            CancellationToken cancellation = new CancellationToken();
            while (webSocket.State == WebSocketState.Open)
            {
                byte[] bufferInit = new byte[1024];

                ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[uploadDTO.FileSize]);
                if (uploadDTO.FileSize < 1024)
                {
                    buffer = new ArraySegment<byte>(bufferInit);
                }
                // 等待接收
                WebSocketReceiveResult result = await webSocket.ReceiveAsync(buffer, cancellation);
                // 可以得到客户端发送过来的数据；
                string userMessage = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
                if (userMessage.Equals("Init"))
                {
                    var trStr = InitFileTable();
                    ArraySegment<byte> sendTableBuf = new ArraySegment<byte>(Encoding.UTF8.GetBytes(trStr));
                    await webSocket.SendAsync(sendTableBuf, WebSocketMessageType.Text, true, cancellation);
                }
            }
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="br"></param>
        /// <param name="uploadModel"></param>
        /// <returns></returns>
        public bool SaveFile(byte[] br, FileUploadDTO uploadModel)
        {
            string filePath = "D://";   //文件路径
            filePath = Path.Combine(filePath, uploadModel.FileName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            try
            {
                FileStream fstream = System.IO.File.Create(filePath, br.Length);
                fstream.Write(br, 0, br.Length);   //二进制转换成文件
                fstream.Close();
                uploadDTO.FileSavePath = filePath;
                return true;
            }
            catch (Exception ex)
            {
                //抛出异常信息
                return false;
            }
        }

        


        /// <summary> 
        /// 根据文件路径获取文件二进制数据.
        /// </summary>
        /// <param name="downFileID"></param>
        /// <returns></returns>
        public ArraySegment<byte> GetFileByteBySavePath(int downFileID)
        {
            if (fileDatas.TryGetValue(downFileID, out FileUploadDTO fileModel))
            {
                fileDatas[downFileID].DownLoadCount++;
            }
            _ = new byte[fileModel.FileSize];
            try
            {
                FileStream fileStream = new FileStream(fileModel.FileSavePath, FileMode.Open, FileAccess.Read);
                BinaryReader r = new BinaryReader(fileStream);
                r.BaseStream.Seek(0, SeekOrigin.Begin);    //将文件指针设置到文件开
                byte[] pReadByte = r.ReadBytes((int)r.BaseStream.Length);
                if (fileStream != null)
                    fileStream.Close();
                ArraySegment<byte> pReadByteB = new ArraySegment<byte>(pReadByte);
                return pReadByteB;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ArraySegment<byte> pReadByteC = new ArraySegment<byte>(new byte[0]);
                return pReadByteC;
            }
        }

        /// <summary>
        /// 初始化表格拼接
        /// </summary>
        /// <returns></returns>
        public string InitFileTable()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in fileDatas)
            {
                stringBuilder.Append($"<tr><td>{item.Value.FileID }</td>");
                stringBuilder.Append($"<td>{item.Value.FileName }</td>");
                stringBuilder.Append($"<td>{item.Value.UserName }</td>");
                stringBuilder.Append($"<td>{item.Value.LastModified }</td>");
                stringBuilder.Append($"<td>{item.Value.DownLoadCount }</td>");
                stringBuilder.Append($"<td>{item.Value.FileType }</td>");
                stringBuilder.Append($"<td onclick='downLoadFileTd(\"{item.Value.FileID}-{item.Value.FileName}\")'>下载</td></tr>");
            }
            return stringBuilder.ToString();
        }
    }
}
