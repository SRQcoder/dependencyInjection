using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace DiDemo.SmallClient
{
    public static class IServiceCollectionExtenstion
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IWriteSimpleDataService, WriteSimpleDataService>();
            return services;
        }
    }
}
