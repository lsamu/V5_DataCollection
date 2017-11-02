using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace V5_WinLibs.DBUtility {
    public class DbHelper {

        public static DataBaseType dbType = DataBaseType.SqlServer;

        private static IDbDataAdapter myAda;

        public static IDbConnection GetDbConnection(string dbLink) {
            IDbConnection conn = null;
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
                        dbLink = string.Format("Data Source=" + dbLink, AppDomain.CurrentDomain.BaseDirectory);
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

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="databaseFileName"></param>
        public static void CreateDataBase(string databaseFileName) {
            switch (dbType) {
                case DataBaseType.OleDb:
                    break;
                case DataBaseType.SqlServer:
                    break;
                case DataBaseType.Oracle:
                    break;
                case DataBaseType.SQLite:
                    SQLiteConnection.CreateFile(databaseFileName);
                    break;
                case DataBaseType.SQLiteMono:
                    break;
                case DataBaseType.MySql:
                    break;
                case DataBaseType.None:
                    break;
                default:
                    break;
            }
        }
        #region 执行sql
        /// <summary>
        /// 执行sql语句 返回影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int Execute(string dbLink, string sql, object param = null) {
            int a = 0;
            using (var conn = GetDbConnection(dbLink)) {
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
        public static object ExecuteScalar(string dbLink, string sql, object param = null) {
            object o = new object();
            using (var conn = GetDbConnection(dbLink)) {
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
        public static IEnumerable<T> Query<T>(string dbLink, string sql, object param = null) {
            IEnumerable<T> dd = null;
            using (var conn = GetDbConnection(dbLink)) {
                dd = conn.Query<T>(sql, param);
                conn.Close();
            }
            return dd;
        }

        public static DataSet Query(string dbLink, string sql, object param = null) {
            using (var conn = GetDbConnection(dbLink)) {
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
    }
}
