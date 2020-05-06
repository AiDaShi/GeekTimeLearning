using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace StarupDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    Console.WriteLine("Configure WebHost Defaults");
                    webBuilder.UseStartup<Startup>();
                    //webBuilder.ConfigureServices(services => {
                    //    Console.WriteLine("webBuilder - Configure Services");
                    //    services.AddControllers();
                    //});
                    //webBuilder.Configure(app => {
                    //    Console.WriteLine("webBuilder - Configure");

                    //    app.UseRouting();

                    //    app.UseAuthorization();

                    //    app.UseEndpoints(endpoints =>
                    //    {
                    //        endpoints.MapControllers();
                    //    });
                    //});
                })
                .ConfigureHostConfiguration(builder =>
                {
                    Console.WriteLine("Configure Host Configuration");
                })
                .ConfigureServices(service =>
                {
                    Console.WriteLine("Configure Services");
                })
                .ConfigureAppConfiguration(builder => {
                    Console.WriteLine("Configure App Configuration");
                });
    }
}
