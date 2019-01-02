using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace DiDemo.BigClient
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IWriteExtendedDataService, WriteExtendedDataServices>();
            services.AddTransient<INormalizedDataService, NormalizedDataService>();

            return services;
        }
    }
}
