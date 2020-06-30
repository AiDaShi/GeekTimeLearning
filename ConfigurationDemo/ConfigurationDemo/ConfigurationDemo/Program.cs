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
            var config = new Config() { 
                Key1="config Key1",
                Key5=false,
                Key6=1000
            };
            configurationRoot.GetSection("OrderService")
                .Bind(config,binderOptions=> { binderOptions.BindNonPublicProperties = true; });
            Console.WriteLine($"Key1:{config.Key1}");
            Console.WriteLine($"Key5:{config.Key5}");
            Console.WriteLine($"Key6:{config.Key6}");
            Console.ReadKey();
        }
        class Config
        {
            public string Key1 { get; set; }
            public bool Key5 { get; set; }
            public int Key6 { get; set; }

        }
    }
}
