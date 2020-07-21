using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsDemo.Services
{
    public interface IOrderService
    {
        int ShowMaxOrderCount();
    }
    public class OrderService : IOrderService
    {
        IOptionsMonitor<OrderServiceOptions> _orderServiceOptions;

        public OrderService(IOptionsMonitor<OrderServiceOptions> orderServiceOptions)
        {
            
            _orderServiceOptions = orderServiceOptions;

            //添加监听
            orderServiceOptions.OnChange((a) =>
            {
                Console.WriteLine($"The value is Change：{a.MaxOrderCount}");
            });
        }

        public int ShowMaxOrderCount()
        {
            return _orderServiceOptions.CurrentValue.MaxOrderCount;
        }
    }
    public class OrderServiceOptions
    {
        [Range(1,20)]
        public int MaxOrderCount { get; set; } = 100;
    }

    public class OrderServiceValidateOptions : IValidateOptions<OrderServiceOptions>
    {
        public ValidateOptionsResult Validate(string name, OrderServiceOptions options)
        {
            if (options.MaxOrderCount > 100)
            {
                return ValidateOptionsResult.Fail("MaxOrderCount 不能大于100");
            }
            else
            {
                return ValidateOptionsResult.Success;
            }
        }
    }
}
