using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace MacroParametersTool.Data
{
    /// <summary>
    /// SQLite指令類別
    /// </summary>
    public class SQLiteCommand
    {
        private List<SqliteParameter> _parameters = null;
        /// <summary>
        /// 建構函式
        /// </summary>
        public SQLiteCommand() : base()
        {
            _sql = new StringBuilder();
            _tempSql = new StringBuilder();
            _parameters = new List<SqliteParameter>();
        }

        private StringBuilder _sql = null;
        /// <summary>
        /// SQL
        /// </summary>
        public StringBuilder Sql
        {
            get { return _sql; }
        }

        private StringBuilder _tempSql = null;
        /// <summary>
        /// 臨時SQL
        /// </summary>
        public StringBuilder TempSql
        {
            get { return _tempSql; }
        }

        /// <summary>
        /// 新增參數
        /// </summary>
        /// <param name="name">名稱</param>
        /// <param name="dataType">資料型別</param>
        /// <param name="value">值</param>
        public void AddParameter(string name, DbType dataType, object value)
        {
            switch (dataType)
            {
                case DbType.DateTime:
                    DateTime dateTime = (DateTime)value;
                    switch (dateTime.Kind)
                    {
                        case DateTimeKind.Unspecified:
                            dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
                            break;
                        case DateTimeKind.Utc:
                            dateTime = dateTime.ToLocalTime();
                            break;
                    }
                    _parameters.Add(new SqliteParameter(name, dataType) { Value = dateTime });
                    break;
                default:
                    _parameters.Add(new SqliteParameter(name, dataType) { Value = value });
                    break;
            }
        }
        /// <summary>
        /// 清除參數
        /// </summary>
        public void ClearParameters()
        {
            _parameters.Clear();
        }
        /// <summary>
        /// 參數
        /// </summary>
        /// <returns></returns>
        public SqliteParameter[] GetParameters()
        {
            return _parameters.ToArray();
        }
    }
}
