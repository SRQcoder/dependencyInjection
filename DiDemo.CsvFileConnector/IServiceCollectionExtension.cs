﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace DiDemo.CsvFileConnector
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCsvFileConnector(this IServiceCollection services)
        {
            services.AddTransient<ICsvDataService, CsvDataService>();
            return services;
        }
    }
}
