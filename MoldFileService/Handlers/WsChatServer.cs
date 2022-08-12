using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using NetCoreServer;
using System.Net.WebSockets;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common;
using WebSocketDemo.Core.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using System.IO;
using Dao.CommandDao.Implementation;
using System.Linq;
using System.Text.RegularExpressions;
 

namespace MoldFileService
{
    class FileSession : WsSession
    {
        public List<Guid> GuidLoop { get; set; }


        /// <summary>
        /// 
        /// </summary>
        private string RootempFile_PATH { get; set; }

        /// <summary>
        /// D:\\soft\\nginx-1.20.1\\data\\static\\tiles\\Nprojectmodel\\
        /// </summary>
        private string NginxTile_Path { get; set; }

        /// <summary>
        /// D://projects//engine_be_new//src//database2//project
        /// </summary>
        private string NodeSever_PATH { get; set; } 

        private IConfiguration Configuration { get; set; }
        public FileSession(WsServer server) : base(server)
        {
            RootempFile_PATH = Config.Configuration.GetSection("RootempFile").Get<string>();
            NginxTile_Path = Config.Configuration.GetSection("NginxTilePath").Get<string>();
            NodeSever_PATH = Config.Configuration.GetSection("NodeSever").Get<string>();
        }

        public MoldFileInfo Finfo { get; set; }

        public List<FileInfo> filess { get; set; } =new List<FileInfo>();

        public int st=0;


       

        public override void OnWsConnected(HttpRequest request)
        {
            var response = this.Response;
            Console.WriteLine($"File WebSocket session with Id {Id} connected!");
            // Send invite message
            string message = "Hello from WebSocket! Please send a message or '!' to disconnect the client!";

            sc_message respond = new sc_message
            {
                message = message,
                code = response.Status,
            };
            string serverMsg = JsonConvert.SerializeObject(respond);
            SendTextAsync(serverMsg);

            //CompressHelper.Decompress("D://tempRarMOdel/共生架构.rar", "D://tempRarMOdel/");
            //CompressHelper.Decompress("D://202207/共生架构.7z", "D://202207/");



            //var Dirnfo = new DirectoryInfo("D://tempRarMOdel/attt");
            //var fILE = Dirnfo.GetFiles().OrderBy(X=>   int.Parse(X.Name.Replace(".part", "")) ).ToList();

            //var Dirnfo2 = new DirectoryInfo("D://tempRarMOdel/a7f143b3fb9952f3b17a15b86673280bedfa27e6874bce7d793074dcea669d63");
            //var fILE2 = Dirnfo2.GetFiles().OrderBy(X => int.Parse(X.Name.Replace(".part", ""))).ToList();
            //try
            //{
            //    for(var i=0;i< fILE.Count(); i++)
            //    {
            //        FileInfo af = fILE[i];
            //        var bf = fILE2[i];
            //        var a = af.GetHashCode();
            //        var b = bf.GetHashCode();

            //        var fs1 = af.OpenRead();
            //        byte[] buffur = new byte[fs1.Length];
            //        fs1.Read(buffur, 0, (int)fs1.Length);
            //        var hash1= Hash256.SHA256Encryptbytes(buffur);

            //        var fs2 = bf.Open(FileMode.Open, FileAccess.Read);
            //        byte[] buffur2 = new byte[fs2.Length];
            //        fs2.Read(buffur2, 0, (int)fs2.Length);
            //        var hash2 = Hash256.SHA256Encryptbytes(buffur2);

            //        if (hash1!= hash2)
            //        {

            //            Console.WriteLine($"    {af.Name}    ,  {hash1},{hash2}  ");
            //        }
            //    }
            //    //CombinFile(fILE, "D:/tempRarMOdel/attt/a.rar");
            //}
            //catch(Exception ex)
            //{
            //    var msg=ex.Message;
            //}
            
        }

        public override void OnWsDisconnected()
        {
            var server = Server;
            var requestt = this.Request;
            var response = this.Response;

            //Multicast message to all connected sessions
            //((WsServer)Server).MulticastText(message);
            Console.WriteLine($"File WebSocket session with Id {Id} disconnected!");
        }


        /// <summary>
        ///  json   的 处理
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        public override void OnWsReceived(byte[] buffer, long offset, long size)
        {
            try
            {
                string message = Encoding.UTF8.GetString(buffer, (int)offset, (int)size);
                Console.WriteLine("Incoming: " + message);

                this.Finfo = JsonConvert.DeserializeObject<MoldFileInfo>(message);


                var root_path = $"{RootempFile_PATH}/{Finfo.hash}";
                var Dirnfo = new DirectoryInfo(RootempFile_PATH);

                var DirList = Dirnfo.GetDirectories().ToList();

                var ishashash = DirList.Exists(x => x.Name == Finfo.hash);
                if (ishashash)
                {
                    var hashdir = DirList.Find(x => x.Name == Finfo.hash);

                    var st = hashdir.GetFiles();
                    hashdir.Delete(true);
                }
                //SendTextAsync(serverMsg);
                //((WsServer)Server).MulticastText(serverMsg);
                // If the buffer starts with '!' the disconnect the current session
                if (message == "!")
                    Close(1000);
            }
            catch(Exception ex)
            {
                err_message dt = new err_message { code = 500, message = ex.Message };
                OnError(dt);
            }
          
        }


        /// <summary>
        /// 源码添加 
        /// 处理  byte
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        public override void OnWsReceived(byte[] buffer, long size, byte type)
        {
            try
            {
                var msglen = 75;
                if (type == NetCoreServer.WebSocket.WS_BINARY)
                {
                    var json_bf= buffer.ToList().GetRange(0, msglen);
                    var message = Encoding.UTF8.GetString(json_bf.ToArray(), (int)0, json_bf.Count());
                    var hashead=JsonConvert.DeserializeObject<HashHead>(message);
                    //Console.WriteLine($"  {message}");

                    var fbf = buffer.ToList().GetRange(msglen, buffer.Length- msglen);

                    byte[] buffur = fbf.ToArray();
                    var hash1 = Hash256.SHA256Encryptbytes(buffur);

                    if (hash1== hashead.hash)
                    {
                        SaveFile(buffur, hash1);
                        double pres = st / (double)Finfo.chunks * 100;
                        sc_message info = new sc_message { code = 200, message = pres.ToString("f2") };
                        var msg = JsonConvert.SerializeObject(info);
                        SendTextAsync(msg);
                    }
                    else
                    {
                        var rootdir = $"{RootempFile_PATH}/{Finfo.hash}/";
                        string filePath = Path.Combine(rootdir, hashead.hash + ".part");
                        filess.Add(new FileInfo(filePath));

                        Console.WriteLine($"  {hashead.hash}");
                        Console.WriteLine($" errr: {hash1}");

                        Repostmsg info = new Repostmsg { code = 203, hash = hashead.hash };
                        var msg = JsonConvert.SerializeObject(info);
                        SendTextAsync(msg);
                        //SendBinaryAsync(buffur,0, buffur.Length);
                    }
                }
                else
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, (int)size);
                    SendTextAsync(message);
                    
                    if (message == "!")
                        Close(1000);
                }

                if (st == Finfo.chunks)
                {
                    var hash_path = $"{RootempFile_PATH}/{Finfo.hash}";
                    var gfile_path = $"{hash_path}/{Finfo.name}";

                    CombinFile(filess, gfile_path);

                    //解压所
                    VipProjectDao dao = new VipProjectDao();
                    ProjectModelDao Promoldao = new ProjectModelDao();
                    if (Finfo.Vpid > 0)
                    {
                        var VipProject_entiy = dao.VipProject(Finfo.Vpid);
                        string copy_to = $"{NginxTile_Path}/{VipProject_entiy.ProjectName}/";
                        if (!Directory.Exists(copy_to))
                        {
                            Directory.CreateDirectory(copy_to);
                        };

                        if (Directory.Exists(copy_to))
                        {
                            sc_message info = new sc_message { code = 201, message = "开始解压缩" };
                            var msg = JsonConvert.SerializeObject(info);
                            SendTextAsync(msg);

                            Console.WriteLine($" copy_to:,{copy_to}");
                            try
                            {
                                var rarstate = CompressHelper.Decompress(gfile_path, copy_to);
                                if (rarstate)
                                {
                                    info = new sc_message { code = 201, message = "解压缩完成" };
                                    msg = JsonConvert.SerializeObject(info);
                                    SendTextAsync(msg);

                                    var Dirnfo = new DirectoryInfo(hash_path);
                                    Dirnfo.Delete(true);
                                }
                            }catch(Exception e)
                            {
                                Console.WriteLine($" {e.Message},{e.InnerException}");
                            }
                            
                        };

                        var Pmodl_entity = Promoldao.GetbyID(Finfo.ModID);
                        var pattern = @"tileset.json";
                        var result= GetFiles(copy_to, pattern,true,true);
                        var stat = result.Exists(x => Regex.IsMatch(x, pattern));
                        if (result.Count>0&& stat)
                        {
                            var str=result[0];
                            var replstring = "D:\\soft\\nginx-1.20.1\\data\\static\\";
                            var url = str.Replace(replstring, "/nginx/").Replace("\\","/");
                            Pmodl_entity.Url = url;
                            Pmodl_entity.UpdateUser = Finfo.username;
                            var State = Promoldao.UpdateProjectModel(Pmodl_entity);
                        }


                        var Sdb_pattern = @".sdb";
                        var Sdb_result = GetFiles(copy_to, Sdb_pattern, true);
                        var Sdb_stat = Sdb_result.ToList().Exists(x => Regex.IsMatch(x, Sdb_pattern));
                        if (Sdb_result.Count > 0 && Sdb_stat)
                        {
                            var cpto = $"{NodeSever_PATH}/{VipProject_entiy.Id}/{Pmodl_entity.Engineering}";
                            if (!Directory.Exists(cpto))
                            {
                                Directory.CreateDirectory(cpto);
                            };
                            foreach (var item in Sdb_result)
                            {
                                var finfo=new FileInfo(item);
                                var newname = $"{Pmodl_entity.Id}.sdb";
                                var path = $"{cpto}/{newname}";
                                finfo.CopyTo(path,true);
                            }
                        }

                        sc_message info2 = new sc_message { code = 202, message = "全部流程完成" };
                        var msg2 = JsonConvert.SerializeObject(info2);
                        SendTextAsync(msg2);
                    }
                    else
                    {
                        sc_message info2 = new sc_message { code = 500, message = "没有Vip ProjectID ,无法完成" };
                        var msg2 = JsonConvert.SerializeObject(info2);
                        SendTextAsync(msg2);
                    }

                    Close(1000);
                }

            }
            catch (Exception ex)
            {
                err_message dt = new err_message { code = 500,message= ex.Message};
                OnError(dt);
            }
        }

        private void OnError(err_message message)
        {
            var serverMsg = JsonConvert.SerializeObject(message);
            SendTextAsync(serverMsg);
            Close(1000);
        }
        protected override void OnError(SocketError error)
        {
            Console.WriteLine($"Chat WebSocket session caught an error with code {error}");
        }



        public bool SaveFile(byte[] br,  string hash1)
        {
            try
            {
                st++;
                int count = br.Length;
                var rootdir = $"{RootempFile_PATH}/{Finfo.hash}/";
                string filePath = Path.Combine(rootdir, hash1 + ".part");

                if (!Directory.Exists(rootdir))
                {
                    Directory.CreateDirectory(rootdir);
                }
                if (System.IO.File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                FileStream tempPartFile = System.IO.File.Create(filePath, br.Length);
                tempPartFile.Write(br, 0, count);   //二进制转换成文件

                var ishas = filess.Exists(x => x.Name.Contains(hash1));
                if (ishas)
                {
                    var idx= filess.FindIndex(x => x.Name.Contains(hash1));
                    filess[idx] = new FileInfo(filePath);
                }
                else
                {
                    filess.Add(new FileInfo(filePath));
                }


                tempPartFile.Close();
                return true;
            }
            catch (Exception e)
            {
                err_message dt = new err_message { code = 500,message=e.Message };
                OnError(dt);
                return false;
            }
        }


        public void CombinFile(List<FileInfo> strFile, string strPath)
        {
            //FileStream AddStream = null;
            //以合并后的文件名称和打开方式来创建、初始化FileStream文件流
            FileStream AddStream = new FileStream(strPath, FileMode.Append);
            //以FileStream文件流来初始化BinaryWriter书写器，此用以合并分割的文件
            BinaryWriter AddWriter = new BinaryWriter(AddStream);
            FileStream TempStream = null;
            BinaryReader TempReader = null;
            //循环合并小文件，并生成合并文件
            for (int i = 0; i < strFile.Count; i++)
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


        public void CombinFilebt(byte[] bt, string strPath)
        {
            //以合并后的文件名称和打开方式来创建、初始化FileStream文件流
            FileStream AddStream = new FileStream(strPath, FileMode.Append);
            //以FileStream文件流来初始化BinaryWriter书写器，此用以合并分割的文件
            MemoryStream memStream = new MemoryStream();
            BufferedStream bufStream = new BufferedStream(memStream);
            bufStream.Write(bt);

            BinaryWriter AddWriter = new BinaryWriter(AddStream);
            BinaryReader TempReader = null;

            TempReader = new BinaryReader(bufStream);
            //读取分割文件中的数据，并生成合并后文件
            AddWriter.Write(TempReader.ReadBytes((int)bufStream.Length));

            //关闭BinaryReader文件阅读器
            TempReader.Close();
          
            //关闭BinaryWriter文件书写器
            AddWriter.Close();
            //关闭FileStream文件流
            AddStream.Close();
        }


        
        public int Compare(FileSystemInfo a, FileSystemInfo b)
        {
            if (a.Attributes < b.Attributes)
                return 1;
            else if (a.Attributes == b.Attributes)
                return 0;
            else
                return -1;
        }
        private List<string> GetFiles(string dir, string regexPattern = null, bool recurse = false, bool isonecheck= false, bool throwEx = false)
        {
            List<string> lst = new List<string>();
            try
            {
                List<FileSystemInfo> Dirnfo =new DirectoryInfo(dir).GetFileSystemInfos().ToList();
                Dirnfo.Sort(Compare);

                var Dirnfo22 = new DirectoryInfo(dir).GetFiles().ToList();
                var Dirnfo2 = Directory.GetFileSystemEntries(dir);
                foreach (var item in Dirnfo)
                {
                    try
                    {
                        bool isFile = (item.Attributes & FileAttributes.Directory) != FileAttributes.Directory;
                        var sbool = Regex.IsMatch(Path.GetFileName(item.FullName), regexPattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);

                        if (isFile && (regexPattern == null || Regex.IsMatch(item.FullName, regexPattern, RegexOptions.IgnoreCase | RegexOptions.Multiline)))
                        { 
                           
                            if (isonecheck)
                            {
                                return new List<string> { item.FullName };
                            }
                            else
                            {
                                lst.Add(item.FullName);
                            }
                        }

                        //递归
                        if (recurse && !isFile) {
                            lst.AddRange(GetFiles(item.FullName, regexPattern, true)); 
                        }
                    }
                    catch { if (throwEx) { throw; } }
                }
            }
            catch { if (throwEx) { throw; } }

            return lst;
        }

    }











    class UpFileServer : WsServer
    {
        public UpFileServer(IPAddress address, int port) : base(address, port) { }

        protected override TcpSession CreateSession() { return new FileSession(this); }

        protected override void OnError(SocketError error)
        {
            Console.WriteLine($"Chat WebSocket server caught an error with code {error}");
        }
    }

}