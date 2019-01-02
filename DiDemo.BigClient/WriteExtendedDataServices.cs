using System;
using System.Collections.Generic;
using System.Text;

namespace DiDemo.BigClient
{
    public class WriteExtendedDataServices : IWriteExtendedDataService
    {

        private readonly INormalizedDataService _normalizedDataService;
        public WriteExtendedDataServices(INormalizedDataService normalizedDataService)
        {
            _normalizedDataService = normalizedDataService;
        }
        public void write()
        {
            var data = _normalizedDataService.GetNormalizedData();
            Console.WriteLine(data);
        }
    }
}
