using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Data.OleDb;
using System.Data.OracleClient;

namespace V5_WinLibs.DBUtility {
    /// <summary>
    /// 数据库类型
    /// </summary>
    public enum DataBaseType {
        /// <summary>
        /// OleDb数据
        /// </summary>
        OleDb,
        /// <summary>
        /// SqlServer
        /// </summary>
        SqlServer,
        /// <summary>
        /// Oracle
        /// </summary>
        Oracle,
        /// <summary>
        /// SQLite
        /// </summary>
        SQLite,
        /// <summary>
        /// SQLiteMono
        /// </summary>
        SQLiteMono,
        /// <summary>
        /// MySql
        /// </summary>
        MySql,
        /// <summary>
        /// 未知
        /// </summary>
        None
    }

    public class DbHelperDapper {
        /// <summary>
        /// SqlServer:server=.;uid=sa;pwd=sa;database=xxx;
        /// MySql:Database=xxx;Data Source=.;User Id=root;Password=root;charset=gbk;
        /// SQLite:Data Source=D:\\a.db
        /// </summary>
        public static string connectionString = string.Empty; 
        public static DataBaseType dbType = DataBaseType.SqlServer;

        private static IDbDataAdapter myAda;
        public static IDbConnection GetDbConnection(DataBaseType m_dbType, string dbLink) {
            IDbConnection conn = null;
            dbType = m_dbType;
            try {
                switch (dbType) {
                    case DataBaseType.SqlServer:
                        conn = new SqlConnection(dbLink);
                        myAda = new SqlDataAdapter();
                        break;
                    case DataBaseType.MySql:
                        conn = new MySqlConnection(dbLink);
                        myAda = new MySqlDataAdapter();
                        break;
                    case DataBaseType.SQLite:
                        conn = new SQLiteConnection(dbLink);
                        myAda = new SQLiteDataAdapter();
                        break;
                    case DataBaseType.OleDb:
                        conn = new OleDbConnection(dbLink);
                        myAda = new OleDbDataAdapter();
                        break;
                    case DataBaseType.Oracle:
                        conn = new OracleConnection(dbLink);
                        myAda = new OracleDataAdapter();
                        break;
                }
                conn.Open();
            }
            catch (Exception ex) {
                return null;
            }
            return conn;
        }

        #region 执行sql
        /// <summary>
        /// 执行sql语句 返回影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int Execute(string sql, object param = null) {
            int a = 0;
            using (var conn = GetDbConnection(dbType, connectionString)) {
                a = conn.Execute(sql, param);
                conn.Close();
            }
            return a;
        }

        /// <summary>
        /// 执行sql语句返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, object param = null) {
            object o = new object();
            using (var conn = GetDbConnection(dbType, connectionString)) {
                o = conn.ExecuteScalar(sql, param);
                conn.Close();
            }
            return o;
        }
        /// <summary>
        /// 执行sql语句返回数据集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static IEnumerable<T> Query<T>(string sql, object param = null) {
            IEnumerable<T> dd = null;
            using (var conn = GetDbConnection(dbType, connectionString)) {
                dd = conn.Query<T>(sql, param);
                conn.Close();
            }
            return dd;
        }

        public static DataSet Query(string sql, object param = null) {
            using (var conn = GetDbConnection(dbType, connectionString)) {
                var ds = new DataSet();
                IDbCommand commond = conn.CreateCommand();
                commond.CommandText = sql;
                myAda.SelectCommand = commond;
                myAda.Fill(ds);
                conn.Close();
                return ds;
            }

        }
        #endregion

        #region 存储过程
        /// <summary>
        /// 返回影响的行数
        /// </summary>
        /// <param name="storedProcName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int RunProcedure(string storedProcName, object param = null) {
            int a = 0;
            using (var conn = GetDbConnection(dbType, connectionString)) {
                a = conn.Execute(storedProcName, param, null, null, CommandType.StoredProcedure);
                conn.Close();
            }
            return a;
        }
        /// <summary>
        /// 返回结果集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static IEnumerable<T> RunProcedure<T>(string storedProcName, object param = null) {
            IEnumerable<T> dd = null;
            using (var conn = GetDbConnection(dbType, connectionString)) {
                dd = conn.Query<T>(storedProcName, param, null, true, null, CommandType.StoredProcedure);
                conn.Close();
            }
            return dd;
        }

        #endregion


    }
}
