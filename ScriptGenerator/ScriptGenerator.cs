using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public class ScriptGenerator
    {
        private string _connectionString;
        private string _columnToExclude = String.Empty;
        IDataProvider _provider;
        private const string SCHEMA_COLUMN_NAME = "COLUMN_NAME";
        private const string SCHEMA_DATA_TYPE = "DATA_TYPE";
        private const char  DELIMITTER = ',';
        private const int BUFFERMAX = 10000;
        TextWriter _outPutFile;

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
        public string ColumnToExclude
        {
            get { return _columnToExclude; }
            set { _columnToExclude = value; }
        }
        private void Initialize()
        {
            _provider = new OleDbDataProvider();
            _provider.OpenConnection(_connectionString);
        }
        private StringBuilder GetColumnList(string tableName)
        {
            DataTable dTable = _provider.GetSchema(tableName);
            StringBuilder colList = new StringBuilder(String.Empty);
            OleDbType columnType;
            string columnName;
            foreach (DataRow row in dTable.Rows)
            {
                columnType = (OleDbType)System.Convert.ToInt16(row[SCHEMA_DATA_TYPE].ToString(), 10);
                columnName = String.Format(",{0},",row[SCHEMA_COLUMN_NAME].ToString());
                if (columnType != OleDbType.Binary && _columnToExclude.IndexOf(columnName) < 0)
                    colList.AppendFormat("{0}{1}", row[SCHEMA_COLUMN_NAME].ToString(), DELIMITTER);
            }
            return colList.Remove(colList.Length - 1, 1);
        }
        private DataTable FormAndRunQuery(string tableName,string colList, string whereClause)
        {
            string query;
            if (String.IsNullOrEmpty(whereClause))
                query = String.Format("Select {0} From {1}", colList, tableName);
            else
                query = String.Format("Select {0} From {1} Where {2}", colList, tableName, whereClause);
            return _provider.GetDataTable(query); 
        }
        private void FormInserts(DataTable dTable,string tableName, string columnList)
        {
            string preScript = String.Format("INSERT INTO {0} ({1}) VALUES ",tableName,columnList);
            string script = preScript + "({2});\n"; 
            StringBuilder returnScript = new StringBuilder(String.Empty);
            long counter = 0;
            foreach (DataRow row in dTable.Rows)
            {
                StringBuilder colValues = new StringBuilder(string.Empty);
                foreach (DataColumn col in dTable.Columns)
                {
                    if(row[col.ColumnName] == DBNull.Value)
                        colValues.AppendFormat("{0},", "NULL");
                    else
                        colValues.AppendFormat("'{0}',", row[col.ColumnName].ToString().Replace("'", "''"));
                }
                returnScript.AppendFormat(script, tableName, columnList, colValues.Remove(colValues.Length - 1, 1));
                counter++;
                if (counter == BUFFERMAX)
                {
                    _outPutFile.Write(returnScript);
                    _outPutFile.Flush();
                    returnScript.Length = 0;
                    counter = 0;
                }
                colValues = null;
            }
            if (counter % BUFFERMAX != 0)
            {
                _outPutFile.Write(returnScript);
                _outPutFile.Flush();
            }
        }
        public void GenerateInsertStatement(string tableName, string whereClause,string outputFileName)
        {
            try
            {
                Initialize();
                _outPutFile = new StreamWriter(outputFileName);
                string columnList = GetColumnList(tableName).ToString();
                DataTable dTable = FormAndRunQuery(tableName, columnList, whereClause);
                FormInserts(dTable, tableName, columnList);
                _outPutFile.Close();
                _outPutFile = null;
            }
            catch (Exception e)
            {
                if(_outPutFile != null)
                    _outPutFile.Dispose();
                throw e;
            }
        }
    }
}
