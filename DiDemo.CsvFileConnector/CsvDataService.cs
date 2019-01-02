using System;
using System.Collections.Generic;
using System.Text;

namespace DiDemo.CsvFileConnector
{
    public class CsvDataService : ICsvDataService
    {
        public string GetData()
        {
            return "Hello From CSV Data Services";
        }
    }
}
