using System;
using Microsoft.Extensions.DependencyInjection;
using DiDemo.CsvFileConnector;
using diDemo.SqlDatabaseConnector;

namespace DiDemo.BigClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start: Hello from the Big Client");

            var services = new ServiceCollection();
            services.AddInternalServices();
            services.AddCsvFileConnector();
            services.AddSqlDatabaseConnector();

            var provider = services.BuildServiceProvider();

            var writer = provider.GetService<IWriteExtendedDataService>();

            writer.write();

            Console.ReadLine();
        }
    }
}
