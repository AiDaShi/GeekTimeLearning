using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingSimpleDemo
{
    public class OrderService
    {
        ILogger<OrderService> _logger;
        public OrderService(ILogger<OrderService> logger) 
        {
            _logger = logger;
        }

        public void Show() 
        {
            //内部传递参数（可以节省一定的资源）
            _logger.LogInformation("Show Time {time}",DateTime.Now);
            //拼接字符串（都会去拼接一次）
            _logger.LogInformation($"Show Time {DateTime.Now}");
        }

    }
}
