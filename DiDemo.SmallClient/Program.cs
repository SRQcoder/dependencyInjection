using System;
using DiDemo.CsvFileConnector;
using Microsoft.Extensions.DependencyInjection;

namespace DiDemo.SmallClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start: Hello World!");

            var services = new ServiceCollection();
            services.AddInternalServices();
            services.AddCsvFileConnector();

            var provider = services.BuildServiceProvider();

            var writer = provider.GetService<IWriteSimpleDataService>();
            writer.write();

            Console.ReadLine();
            
        }
    }
}
