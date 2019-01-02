using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace diDemo.SqlDatabaseConnector
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddSqlDatabaseConnector(this IServiceCollection services)
        {
            services.AddTransient<ISqlDataService, SqlDataService>();
            services.AddTransient<ISqlDataProvider, SqlDataProvider>();

            return services;
        }
    }
}
