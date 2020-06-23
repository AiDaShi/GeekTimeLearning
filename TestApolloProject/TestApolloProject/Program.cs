using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Com.Ctrip.Framework.Apollo;
using Com.Ctrip.Framework.Apollo.Logging;

namespace TestApolloProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostBuilderContext,configurationBuilder)=>{
                    //注入配置
                    //把阿波罗的日志级别调整为最低
                    LogManager.UseConsoleLogging(Com.Ctrip.Framework.Apollo.Logging.LogLevel.Trace);

                    //从已加载的配置文件中读取，阿波罗的基础配置，并注入
                    configurationBuilder.AddApollo(configurationBuilder.Build().GetSection("Apollo"))
                        //注入默认配置
                        .AddDefault(Com.Ctrip.Framework.Apollo.Enums.ConfigFileFormat.Properties);

                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
