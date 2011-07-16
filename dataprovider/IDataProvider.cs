using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Util
{
    public interface IDataProvider
    {
        void OpenConnection(string connectionString);
        void ExecuteNonQuery(string commandText);
        DataTable GetSchema(string tableName);
        DataTable GetDataTable(string query);
    }
}
