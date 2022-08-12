using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebApiWithWebsocket.SocketsManager;

namespace WebApiWithWebsocket.Extensions
{
    /// <summary>
    /// 注入扩展，直接在 Startup.cs 中写也无不可，但这是好习惯，将每个注入内容单独写到文件。
    /// </summary>
    public static class SocketsExtension
    {
        public static IServiceCollection AddWebSocketManager(this IServiceCollection services)
        {
            services.AddTransient<SocketsManager.SocketsManager>();

            var exportedTypes = Assembly.GetEntryAssembly()?.ExportedTypes;

            if (exportedTypes == null) return services;

            foreach (var type in exportedTypes)
                if (type.GetTypeInfo().BaseType == typeof(SocketsHandler))
                    services.AddSingleton(type);

            return services;
        }

        public static IApplicationBuilder MapSockets(this IApplicationBuilder app, PathString path, SocketsHandler socket)
        {
            return app.Map(path, x => x.UseMiddleware<SocketsMiddleware>(socket));
        }
    }
}
