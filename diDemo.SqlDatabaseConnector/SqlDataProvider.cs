using System;
using System.Collections.Generic;
using System.Text;

namespace diDemo.SqlDatabaseConnector
{
    public class SqlDataProvider : ISqlDataProvider
    {
        public string Fetch()
        {
            return "Hello from within the Sql Data Provider";
        }
    }
}
