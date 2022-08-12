using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using WebApiWithWebsocket.Handlers;
//using WebApiWithWebsocket.Extensions;
//using WebApiWithWebsocket.SocketsManager;
using Models.DBContexts;

namespace MoldFileService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;


            // Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -UseDatabaseNames -OutputDir Models

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MoldFileService", Version = "v1" });
            });
            //services.AddMvc(options => { options.EnableEndpointRouting = false; });

           

            //services.AddDbContextPool<BigDataContext>(options => options(Configuration.GetConnectionString("hi"))
            //                    );



            services.AddControllersWithViews().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MoldFileService v1"));
            }

            app.UseStaticFiles();

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //原生
            //var webSocketOptions = new WebSocketOptions()
            //{
            //    KeepAliveInterval = TimeSpan.FromSeconds(120),
            //};
            //app.UseWebSockets(webSocketOptions);
            //

            // 中间件
            //app.MapSockets("/WebSocketCore/UpLoad", serviceProvider.GetService<WebSocketMessageHandler>());
            // 中间件


            //app.UseMvc();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=WebSocketCore}/{action=Index}/{id?}");
            });
        }
    }
}
