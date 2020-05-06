using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetService")]
        public int GetService([FromServices]IMySingletonService singleton1,
                              [FromServices]IMySingletonService singleton2,
                              [FromServices]IMyTransientService transient1,
                              [FromServices]IMyTransientService transient2,
                              [FromServices]IMyScopedService scoped1,
                              [FromServices]IMyScopedService scoped2)
        {
            Console.WriteLine($"singleton1:{singleton1.GetHashCode()}");
            Console.WriteLine($"singleton2:{singleton2.GetHashCode()}");


            Console.WriteLine($"transient1:{transient1.GetHashCode()}");
            Console.WriteLine($"transient2:{transient2.GetHashCode()}");

            Console.WriteLine($"scoped1:{scoped1.GetHashCode()}");
            Console.WriteLine($"scoped2:{scoped2.GetHashCode()}");

            Console.WriteLine($"========GetService 请求结束=======");
            return 1;
        }

        [HttpGet("GetService2")]
        public int GetService2([FromServices]IMySingletonService singleton1,
                              [FromServices]IMySingletonService singleton2,
                              [FromServices]IMyTransientService transient1,
                              [FromServices]IMyTransientService transient2,
                              [FromServices]IMyScopedService scoped1,
                              [FromServices]IMyScopedService scoped2)
        {
            Console.WriteLine($"singleton1:{singleton1.GetHashCode()}");
            Console.WriteLine($"singleton2:{singleton2.GetHashCode()}");


            Console.WriteLine($"transient1:{transient1.GetHashCode()}");
            Console.WriteLine($"transient2:{transient2.GetHashCode()}");

            Console.WriteLine($"scoped1:{scoped1.GetHashCode()}");
            Console.WriteLine($"scoped2:{scoped2.GetHashCode()}");

            Console.WriteLine($"========GetService 2 请求结束=======");
            return 1;
        }


        /// <summary>
        /// 获取 Service
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        [HttpGet("GetServiceList")]
        public int GetServiceList([FromServices]IEnumerable<IOrderService> services)
        {
            foreach (var item in services)
            {
                Console.WriteLine($"Get Servic instances：{item.ToString()}:{item.GetHashCode()}");
            }
            return 1;
        }
    }
}