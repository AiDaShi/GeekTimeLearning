using Microsoft.Extensions.Configuration;
using System;

namespace ConfigurationEnvironmentVariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();

            #region 前缀过滤
            builder.AddEnvironmentVariables("XIAO_");
            var configurationRoot = builder.Build();
            Console.WriteLine($"key1:{configurationRoot["key1"]}");
            #endregion
        }
    }
}
