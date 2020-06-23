using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;

namespace ConfigurationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsetting.json",optional:false,reloadOnChange:true);
            var configurationRoot = builder.Build();

            IChangeToken changeToken = configurationRoot.GetReloadToken();

            ChangeToken.OnChange(() => configurationRoot.GetReloadToken(), () => {
                Console.WriteLine($"Key1:{configurationRoot["Key1"]}");
                Console.WriteLine($"Key2:{configurationRoot["Key2"]}");
                Console.WriteLine($"Key3:{configurationRoot["Key3"]}");

            });

            Console.ReadKey();
        }
    }
}
