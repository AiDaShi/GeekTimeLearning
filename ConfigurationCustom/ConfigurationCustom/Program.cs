using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;

namespace ConfigurationCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder();
            //builder.Add(new MyConfigurationSource());
            //var configRoot = builder.Build();
            //Console.WriteLine($"lastTime:{configRoot["lastTime"]}");
            //Console.ReadKey();


            var builder = new ConfigurationBuilder();
            builder.AddMyConfiguration();

            var configRoot = builder.Build();

            ChangeToken.OnChange(() => configRoot.GetReloadToken(), () => {
                Console.WriteLine($"lastTime:{configRoot["lastTime"]}");
            });

            Console.WriteLine($"开始了");

            Console.ReadKey();
        }
    }
}
