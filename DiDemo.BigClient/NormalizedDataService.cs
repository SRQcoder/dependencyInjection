using diDemo.SqlDatabaseConnector;
using DiDemo.CsvFileConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiDemo.BigClient
{
    public class NormalizedDataService : INormalizedDataService
    {
        private readonly ICsvDataService _csvDataService;
        private readonly ISqlDataService _sqlDataService;

        public NormalizedDataService(ICsvDataService csvDataService, ISqlDataService sqlDataService)
        {
            _csvDataService = csvDataService;
            _sqlDataService = sqlDataService;
        }
        public object GetNormalizedData()
        {
            return $"{_csvDataService.GetData()}\n{_sqlDataService.GetData()}";
        }
    }
}
