using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiWithWebsocket.SocketsManager
{
    /// <summary>
    /// 保存 WebSocket 的类，该类用于保存所有 WebSocket。
    /// </summary>
    public class SocketsManager
    {
        private readonly ConcurrentDictionary<string, WebSocket> _connections = new ConcurrentDictionary<string, WebSocket>();

        /// <summary>
        /// 获取所有 sockets 的字典集合
        /// </summary>
        /// <returns></returns>
        public ConcurrentDictionary<string, WebSocket> GetAllConnections()
        {
            return _connections;
        }

        /// <summary>
        ///     获取指定 id 的 socket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public WebSocket GetSocketById(string id)
        {
            return _connections.FirstOrDefault(x => x.Key == id).Value;
        }

        /// <summary>
        /// 根据 socket 获取其 id
        /// </summary>
        /// <param name="socket"></param>
        /// <returns></returns>
        public string GetId(WebSocket socket)
        {
            return _connections.FirstOrDefault(x => x.Value == socket).Key;
        }

        /// <summary>
        /// 删除指定 id 的 socket，并关闭该链接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveSocketAsync(string id)
        {
            _connections.TryRemove(id, out var socket);

            await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "socket connection closed", CancellationToken.None);
        }

        /// <summary>
        /// 添加一个 socket
        /// </summary>
        /// <param name="socket"></param>
        public void AddSocket(WebSocket socket)
        {
            _connections.TryAdd(CreateId(), socket);
        }

        /// <summary>
        /// 创建 id
        /// </summary>
        /// <returns></returns>
        private string CreateId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
