using System;
using System.Collections.Generic;
using System.Text;

namespace diDemo.SqlDatabaseConnector
{
    public interface ISqlDataProvider
    {
        string Fetch();
    }
}
