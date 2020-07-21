using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using OptionsDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class OrderServiceExtensions
    {
        public static IServiceCollection AddOrderService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddOptions<OrderServiceOptions>().Configure(options =>
            {
                configuration.Bind(options);
            }).Services.AddSingleton<IValidateOptions<OrderServiceOptions>, OrderServiceValidateOptions>();

            services.AddSingleton<IOrderService, OrderService>();
            return services;
        }
    }
}
