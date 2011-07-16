using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace Util
{
    public class OleDbDataProvider : IDataProvider
    {
        private OleDbConnection _connection;
        private int _commandTimeOut;
        private const string DB_SCHEMA_DATA_TYPE = "DATA_TYPE";
        int CommandTimeOut
        {
            get { return _commandTimeOut; }
            set { _commandTimeOut = value; }
        }
        public void OpenConnection(string connectionString)
        {
            _connection = new OleDbConnection(connectionString);
            _connection.Open();
        }
        public void ExecuteNonQuery(string commandText)
        {
            using (OleDbCommand command = new OleDbCommand())
            {
                command.CommandTimeout = _commandTimeOut;
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
        }
        public DataTable GetSchema(string tableName)
        {
            DataTable retSchema =  _connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                new object[] { null, 
								 null, 
								 tableName, 
								 null });
            if (retSchema.Rows.Count == 0)
                throw new ScriptGenException("Table not found <" + tableName + ">");
            if (retSchema.Columns[DB_SCHEMA_DATA_TYPE] == null)
                throw new ScriptGenException("Column <" + DB_SCHEMA_DATA_TYPE + "> not found on table <" + retSchema.TableName + ">");
            return retSchema;         
        }
        public DataTable GetDataTable(string query)
        {
            DataSet dSet = new DataSet();
            using (OleDbDataAdapter adaptor = new OleDbDataAdapter(query, _connection))
            {
                adaptor.Fill(dSet);
            }
            return dSet.Tables[0];
        }
        ~OleDbDataProvider()
        {
            if (_connection.State == ConnectionState.Open)
            {
                //_connection.Close();
              //  _connection.Dispose();
            }
        }
      
    }
}
