using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RRQMCore.Log;
using RRQMSocket;
using RRQMSocket.RPC.TouchRpc;

using System.Net;
using System.Net.Sockets;
using NetCoreServer;

namespace MoldFileService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var server = new UpFileServer(IPAddress.Any, 27357);
            server.Start();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://*:8888");
                    webBuilder.UseStartup<Startup>() ;
                });

    }
}
