using MacroParametersTool.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroParametersTool
{
    public class Storage : SQLiteStorageBase
    {
        public override string ConnectionString
        {
            get
            {
                return "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "MacroParametersTool.db";
            }
        }

        #region "MacroParameters"
        private bool MacroParameters_Exist(string id)
        {
            bool r = false;
            SQLiteCommand comm = new SQLiteCommand();
            comm.Sql.Append("SELECT Count(*) as Count FROM [MPT_MacroParameters] WHERE ([Id] = @Id)");
            comm.AddParameter("@Id", DbType.String, id);
            if (Convert.ToInt32(ExecuteScalar(comm)) > 0) { r = true; }
            return r;
        }
        public bool MacroParameters_Delete(string id)
        {
            bool r = false;
            if (MacroParameters_Exist(id) == true)
            {
                SQLiteCommand comm = new SQLiteCommand();
                comm.Sql.Append("DELETE FROM [MPT_MacroParameters] WHERE ([Id] = @Id)");
                comm.AddParameter("@Id", DbType.String, id);
                ExecuteNonQuery(comm);
                r = true;
            }
            return r;
        }
        public bool MacroParameters_Clear()
        {
            bool r = false;
            SQLiteCommand comm = new SQLiteCommand();
            comm.Sql.Append("DELETE FROM [MPT_MacroParameters]");
            ExecuteNonQuery(comm);
            r = true;
            return r;
        }

        public bool MacroParameters_Edit(MacroParameter data)
        {
            bool r = false;
            if (MacroParameters_Exist(data.Id) == true)
            {
                SQLiteCommand comm = new SQLiteCommand();
                comm.Sql.Append(@"UPDATE [MPT_MacroParameters] SET [Description] = @Description WHERE ([Id] = @Id)");
                comm.AddParameter("@Id", DbType.String, data.Id);
                comm.AddParameter("@Description", DbType.String, data.Description);
                ExecuteNonQuery(comm);
                r = true;
            }
            return r;
        }
        public bool MacroParameters_Insert(MacroParameter data)
        {
            bool r = false;
            if (MacroParameters_Exist(data.Id) == false)
            {
                SQLiteCommand comm = new SQLiteCommand();
                comm.Sql.Append(@"INSERT INTO [MPT_MacroParameters] (
                                                                                              [Id] 
                                                                                            , [Kind] 
                                                                                            , [Number] 
                                                                                            , [FileName] 
                                                                                            , [Directory] 
                                                                                            , [Description] 
                                                                                            , [ImportMark] 
                                                                                            , [Line] 
                                                                                    ) VALUES ( 
                                                                                              @Id 
                                                                                            , @Kind 
                                                                                            , @Number 
                                                                                            , @FileName 
                                                                                            , @Directory 
                                                                                            , @Description 
                                                                                            , @ImportMark 
                                                                                            , @Line 
                                                                                     )"
                                    );
                comm.AddParameter("@Id", DbType.String, data.Id);
                comm.AddParameter("@Kind", DbType.String, data.Kind);
                comm.AddParameter("@Number", DbType.Int32, data.Number);
                comm.AddParameter("@Line", DbType.Int32, data.Line);
                comm.AddParameter("@FileName", DbType.String, data.FileName);
                comm.AddParameter("@Directory", DbType.String, data.Directory);
                comm.AddParameter("@Description", DbType.String, data.Description);
                comm.AddParameter("@ImportMark", DbType.String, data.ImportMark);
                ExecuteNonQuery(comm);
                r = true;
            }
            return r;
        }
        public SearchResult<MacroParameter> MacroParameters_Search(string id, string kind, string keyword, Paging paging)
        {
            SearchResult<MacroParameter> r = new SearchResult<MacroParameter>(paging);
            SQLiteCommand comm = new SQLiteCommand();
            if (id != "")
            {
                if (comm.TempSql.Length == 0) { comm.TempSql.Append(" WHERE "); } else { comm.TempSql.Append(" AND "); }
                comm.TempSql.Append("([Id] = @Id)");
                comm.AddParameter("@Id", DbType.String, id);
            }
            if (kind != "")
            {
                if (comm.TempSql.Length == 0) { comm.TempSql.Append(" WHERE "); } else { comm.TempSql.Append(" AND "); }
                comm.TempSql.Append("([Kind] = @Kind)");
                comm.AddParameter("@Kind", DbType.String, kind);
            }
            if (keyword != "")
            {
                if (comm.TempSql.Length == 0) { comm.TempSql.Append(" WHERE "); } else { comm.TempSql.Append(" AND "); }
                comm.TempSql.Append(GetLikeCommandString("NumberText,FileName,Directory,Description,ImportMark", keyword));
            }
            comm.Sql.Append("SELECT Count(*) as Count FROM [MPT_MacroParameters_VIEW]" + comm.TempSql.ToString());
            r.Paging.RowsCount = Convert.ToInt32(ExecuteScalar(comm));

            comm.Sql.Length = 0;
            comm.Sql.Append("SELECT [Id], [Kind], [Number], [Line], [FileName], [Directory], [Description], [ImportMark] FROM [MPT_MacroParameters_VIEW]");
            comm.Sql.Append(comm.TempSql.ToString());
            comm.Sql.Append(" ORDER BY [Kind], [Number], [Line]");
            MacroParameter item;
            foreach (DataRow row in ExecuteQuery(comm, r.Paging.StartRowIndex, r.Paging.EndRowIndex).Rows)
            {
                item = new MacroParameter();
                ImportDataByDataRow(item, row);
                r.Data.Add(item);
            }
            return r;
        }
        public SearchResult<MacroParameterItem> MacroParameters_SearchItems( string kind,   Paging paging)
        {
            SearchResult<MacroParameterItem> r = new SearchResult<MacroParameterItem>(paging);
            SQLiteCommand comm = new SQLiteCommand();
            if (kind != "")
            {
                if (comm.TempSql.Length == 0) { comm.TempSql.Append(" WHERE "); } else { comm.TempSql.Append(" AND "); }
                comm.TempSql.Append("([Kind] = @Kind)");
                comm.AddParameter("@Kind", DbType.String, kind);
            }
            comm.Sql.Append("SELECT Count(*) as Count FROM [MPT_MacroParameterItems_VIEW]" + comm.TempSql.ToString());
            r.Paging.RowsCount = Convert.ToInt32(ExecuteScalar(comm));

            comm.Sql.Length = 0;
            comm.Sql.Append("SELECT [Kind], [Number] FROM [MPT_MacroParameterItems_VIEW]");
            comm.Sql.Append(comm.TempSql.ToString());
            comm.Sql.Append(" ORDER BY [Kind], [Number]");
            MacroParameterItem item = null;
            foreach (DataRow row in ExecuteQuery(comm, r.Paging.StartRowIndex, r.Paging.EndRowIndex).Rows)
            {
                item = new MacroParameterItem();
                ImportDataByDataRow(item, row);
                r.Data.Add(item);
            }
            return r;
        }

        #endregion

    }
}
