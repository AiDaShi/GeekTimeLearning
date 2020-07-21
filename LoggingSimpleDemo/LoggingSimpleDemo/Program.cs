using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingSimpleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //必要的包
            //从文件中读取配置
            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddCommandLine(args);
            configBuilder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var config = configBuilder.Build();

            IServiceCollection serviceCollection = new ServiceCollection();

            //用工厂模式将配置对象注册到容器管理
            serviceCollection.AddSingleton<IConfiguration>(p => config);

            serviceCollection.AddLogging(builder =>
            {
                builder.AddConfiguration(config.GetSection("Logging"));
                builder.AddConsole();
                builder.AddDebug();
            });

            IServiceProvider service = serviceCollection.BuildServiceProvider();
            
            //日志作用域
            var logger = service.GetService<ILogger<Program>>();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                using (logger.BeginScope("ScopeId:{ScopeId}", Guid.NewGuid()))
                {
                    logger.LogInformation("There are Info");
                    logger.LogError("There are Error");
                    logger.LogTrace("There are Trace");
                }
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("=====================Line=====================");
            }

            Console.ReadKey();
        }
    }
}
