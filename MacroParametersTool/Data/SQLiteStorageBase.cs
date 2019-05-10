using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Threading.Tasks;
using System.Reflection;

namespace MacroParametersTool.Data
{
    /// <summary>
    /// SQLite儲存體基礎類別
    /// </summary>
    public abstract class SQLiteStorageBase
    {
        /// <summary>
        /// 連結字串
        /// </summary>
        public abstract string ConnectionString { get; }

        /// <summary>
        /// 執行沒有查詢
        /// </summary>
        /// <param name="command">指令</param>
        protected void ExecuteNonQuery(SQLiteCommand command)
        {
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = command.Sql.ToString();
                    cmd.Parameters.AddRange(command.GetParameters());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 執行沒有查詢
        /// </summary>
        /// <param name="commands">指令群</param>
        /// <remarks>會在同一個交易內</remarks>
        protected void ExecuteNonQuery(List<SQLiteCommand> commands)
        {
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                SqliteCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();
                try
                {
                    foreach (SQLiteCommand command in commands)
                    {
                        cmd.CommandText = command.Sql.ToString();
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddRange(command.GetParameters());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    cmd.Dispose();
                    cmd = null;
                    throw ex;
                }
                cmd.Transaction.Commit();
                cmd.Dispose();
                cmd = null;
            }
        }

        /// <summary>
        /// 執行純量
        /// </summary>
        /// <param name="command">指令</param>
        /// <remarks>回傳純量</remarks>
        protected object ExecuteScalar(SQLiteCommand command)
        {
            object r = null;
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = command.Sql.ToString();
                    cmd.Parameters.AddRange(command.GetParameters());
                    conn.Open();
                    r = cmd.ExecuteScalar();
                }
            }
            return r;
        }

        /// <summary>
        /// 執行查詢
        /// </summary>
        /// <param name="command">指令</param>
        protected DataTable ExecuteQuery(SQLiteCommand command)
        {
            DataTable r = new System.Data.DataTable();
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = command.Sql.ToString();
                    cmd.Parameters.AddRange(command.GetParameters());
                    conn.Open();
                    using (SqliteDataReader adapter = cmd.ExecuteReader())
                    {
                        for (int columnIndex = 0; columnIndex < adapter.FieldCount; columnIndex++)
                        {
                            r.Columns.Add(adapter.GetName(columnIndex), adapter.GetFieldType(columnIndex));
                        }
                        r.Load(adapter);
                    }
                }
            }
            return r;
        }

        /// <summary>
        /// 執行查詢
        /// </summary>
        /// <param name="command">指令</param>
        /// <param name="firstRowIndex">第一筆資料次序</param>
        /// <param name="lastRowIndex">最後一筆</param>
        /// <returns></returns>
        protected DataTable ExecuteQuery(SQLiteCommand command, int firstRowIndex, int lastRowIndex)
        {
            DataTable r = new System.Data.DataTable();
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = command.Sql.ToString();
                    cmd.Parameters.AddRange(command.GetParameters());
                    conn.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();
                    r.BeginLoadData();
                    try
                    {
                        for (int columnIndex = 0; columnIndex < reader.FieldCount; columnIndex++)
                        {
                            r.Columns.Add(reader.GetName(columnIndex), reader.GetFieldType(columnIndex));
                        }
                        int rowIndex = 0;
                        object[] value = new object[reader.FieldCount];
                        while (reader.Read())
                        {
                            if (rowIndex >= firstRowIndex - 1 && rowIndex < lastRowIndex)
                            {
                                reader.GetValues(value);
                                r.LoadDataRow(value, true);
                            }
                            rowIndex = rowIndex + 1;
                        }
                    }
                    finally
                    {
                        if (reader.IsClosed == false) { reader.Close(); }
                        reader = null;
                        r.EndLoadData();
                    }
                }
            }
            return r;
        }

        /// <summary>
        /// 匯入資料由資料行
        /// </summary>
        /// <param name="instance">物件實體</param>
        /// <param name="data">資料</param>
        /// <remarks>將查詢的資料行轉成物件</remarks>
        protected void ImportDataByDataRow(object instance, DataRow data)
        {
            string typeName = "";
            object value = null;
            foreach (PropertyInfo pi in instance.GetType().GetProperties())
            {
                if (data.Table.Columns.Contains(pi.Name) == true)
                {
                    try
                    {
                        typeName = pi.PropertyType.FullName;
                        if (DBNull.Value.Equals(data[pi.Name]) == true)
                        {
                            value = null;
                        }
                        else if (typeName == typeof(String).ToString())
                        {
                            value = Convert.ToString(data[pi.Name]);
                        }
                        else if (typeName == typeof(Boolean).ToString())
                        {
                            value = Convert.ToBoolean(data[pi.Name]);
                        }
                        else if (typeName == typeof(Int32).ToString())
                        {
                            value = Convert.ToInt32(data[pi.Name]);
                        }
                        else if (typeName == typeof(Single).ToString())
                        {
                            value = Convert.ToSingle(data[pi.Name]);
                        }
                        else if (typeName == typeof(Decimal).ToString())
                        {
                            value = Convert.ToDecimal(data[pi.Name]);
                        }
                        else if (typeName == typeof(DateTime).ToString())
                        {
                            value = DateTime.SpecifyKind(Convert.ToDateTime(data[pi.Name]), DateTimeKind.Local);
                        }
                        else
                        {
                            value = data[pi.Name];
                        }
                        pi.SetValue(instance, value, null);
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// Like指令字串
        /// </summary>
        /// <param name="fieldNames">欄位名稱</param>
        /// <param name="keyword">關鍵字</param>
        /// <returns>組Link的SQL</returns>
        protected string GetLikeCommandString(string fieldNames, string keyword)
        {
            System.Text.StringBuilder r = new System.Text.StringBuilder();
            if (fieldNames != "" && keyword != "")
            {
                foreach (string fileName in fieldNames.Split(','))
                {
                    foreach (string key in keyword.Split(','))
                    {
                        if (r.Length != 0) { r.Append(" OR "); }
                        r.AppendFormat("({0} LIKE '%{1}%')", fileName.Trim(), key.Trim().Replace(" ", "%"));
                    }
                }
            }
            return "(" + r.ToString() + ")";
        }

        /// <summary>
        /// 物件從位元組
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>位元組轉物件</returns>
        public object GetObjectFromBytes(byte[] value)
        {
            object r = null;
            if (DBNull.Value.Equals(value) == false)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                r = formatter.Deserialize(ms);
            }
            return r;
        }
        /// <summary>
        /// 位元組從物件
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>物件轉位元組</returns>
        public byte[] GetBytesFromObject(object value)
        {
            System.IO.MemoryStream r = new System.IO.MemoryStream();
            if (value != null)
            {
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(r, value);
            }
            return r.GetBuffer();
        }

    }
}
