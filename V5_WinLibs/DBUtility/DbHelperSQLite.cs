using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Web;
using System.Collections;

namespace V5_WinLibs.DBUtility {
    public abstract class DbHelperSQLite {
        private static string setConnectionString = string.Empty;

        public static string ConnectionString {
            get { return setConnectionString; }
            set { setConnectionString = value; }
        }

        public DbHelperSQLite() {
            setConnectionString = string.Empty;
        }
        private static string mmConnectionString() {
            return string.Format("Data Source=" + ConnectionString, AppDomain.CurrentDomain.BaseDirectory);// HttpContext.Current.Server.MapPath(connectionString);
        }

        private static string mmConnectionString(string ConnectionString) {
            return string.Format("Data Source=" + ConnectionString, AppDomain.CurrentDomain.BaseDirectory);// HttpContext.Current.Server.MapPath(connectionString);
        }

        /// <summary>
        /// 查询sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet Query(string sql) {
            SQLiteConnection conn = new SQLiteConnection(mmConnectionString());
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmd.Dispose();
            adapter.Dispose();
            conn.Close();
            conn.Dispose();
            return ds;
        }

        public static DataSet Query(string sql, string ConnectionString) {
            SQLiteConnection conn = new SQLiteConnection(mmConnectionString(ConnectionString));
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmd.Dispose();
            adapter.Dispose();
            conn.Close();
            conn.Dispose();
            return ds;
        }
        /// <summary>
        /// 执行sql语句 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteSql(string sql) {
            SQLiteConnection conn = new SQLiteConnection(mmConnectionString());
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return result;
        }

        public static int ExecuteSql(string sql, string ConnectionString) {
            SQLiteConnection conn = new SQLiteConnection(mmConnectionString(ConnectionString));
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return result;
        }
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingle(string sql) {
            SQLiteConnection conn = new SQLiteConnection(mmConnectionString());
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            object obj = cmd.ExecuteScalar();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value))) {
                return null;
            }
            else {
                return obj;
            }
        }

        public static object GetSingle(string sql, string ConnectionString) {
            SQLiteConnection conn = new SQLiteConnection(mmConnectionString(ConnectionString));
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            object obj = cmd.ExecuteScalar();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value))) {
                return null;
            }
            else {
                return obj;
            }
        }
        /// <summary>
        /// 查询值 是否存在
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static bool Exists(string strSql) {
            object obj = DbHelperSQLite.GetSingle(strSql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value))) {
                cmdresult = 0;
            }
            else {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0) {
                return false;
            }
            else {
                return true;
            }
        }

        public static bool Exists(string strSql, string ConnectionString) {
            object obj = DbHelperSQLite.GetSingle(strSql, ConnectionString);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value))) {
                cmdresult = 0;
            }
            else {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0) {
                return false;
            }
            else {
                return true;
            }
        }


        public static int GetMaxID(string FieldName, string TableName) {
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;
            object obj = DbHelperSQLite.GetSingle(strsql);
            if (obj == null) {
                return 1;
            }
            else {
                return int.Parse(obj.ToString());
            }
        }


        public static int GetMaxID(string FieldName, string TableName, string ConnectionString) {
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;
            object obj = DbHelperSQLite.GetSingle(strsql, ConnectionString);
            if (obj == null) {
                return 1;
            }
            else {
                return int.Parse(obj.ToString());
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>		
        public static int ExecuteSqlTran(List<String> SQLStringList) {
            using (SQLiteConnection connection = new SQLiteConnection(mmConnectionString())) {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = connection;
                SQLiteTransaction tx = connection.BeginTransaction();
                cmd.Transaction = tx;
                try {
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++) {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1) {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch {
                    tx.Rollback();
                    return 0;
                }
                finally {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList"></param>
        public static void ExecuteSqlTran(Hashtable SQLStringList) {
            using (SQLiteConnection conn = new SQLiteConnection(mmConnectionString())) {
                conn.Open();
                using (SQLiteTransaction trans = conn.BeginTransaction()) {
                    SQLiteCommand cmd = new SQLiteCommand();
                    try {
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList) {
                            string cmdText = myDE.Key.ToString();
                            SQLiteParameter[] cmdParms = (SQLiteParameter[])myDE.Value;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParms"></param>
        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, string cmdText, SQLiteParameter[] cmdParms) {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null) {


                foreach (SQLiteParameter parameter in cmdParms) {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null)) {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }

        /// <summary>
        /// 创建数据库文件
        /// </summary>
        /// <param name="databaseFileName"></param>
        public static void CreateDataBase(string databaseFileName) {
            SQLiteConnection.CreateFile(databaseFileName);
        }

        /// <summary>
        /// 执行压缩数据库
        /// </summary>
        /// <returns>压缩数据库</returns>
        public static void ExecuteZip() {
            using (SQLiteConnection connection = new SQLiteConnection(mmConnectionString())) {
                using (SQLiteCommand cmd = new SQLiteCommand("VACUUM", connection)) {
                    try {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SQLite.SQLiteException E) {
                        connection.Close();
                    }
                }
            }
        }
    }
}
