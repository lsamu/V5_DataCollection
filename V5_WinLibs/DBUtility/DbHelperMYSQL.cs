using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace V5_WinLibs.DBUtility
{
    public abstract class DbHelperMySQL
    {
         public static string connectionString = PubConstant.ConnectionString;
         public DbHelperMySQL()
         {
         }

         #region  执行简单SQL语句

         public static int GetMaxID(string FieldName, string TableName)
         {
             string strsql = "select max(" + FieldName + ")+1 from " + TableName;
             object obj = DbHelperMySQL.GetSingle(strsql);
             if (obj == null)
             {
                 return 1;
             }
             else
             {
                 return int.Parse(obj.ToString());
             }
         }
         /// <summary>
         /// 执行SQL语句，返回影响的记录数
         /// </summary>
         /// <param name="SQLString">SQL语句</param>
         /// <returns>影响的记录数</returns>
         public static int ExecuteSql(string SQLString)
         {
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 using (MySqlCommand cmd = new MySqlCommand(SQLString, connection))
                 {
                     try
                     {
                         connection.Open();
                         int rows = cmd.ExecuteNonQuery();
                         return rows;
                     }
                     catch (MySqlException E)
                     {
                         connection.Close();
                         throw new Exception(E.Message);
                     }
                 }
             }
         }

         /// <summary>
         /// 执行多条SQL语句，实现数据库事务。
         /// </summary>
         /// <param name="SQLStringList">多条SQL语句</param>		
         public static void ExecuteSqlTran(ArrayList SQLStringList)
         {
             using (MySqlConnection conn = new MySqlConnection(connectionString))
             {
                 conn.Open();
                 MySqlCommand cmd = new MySqlCommand();
                 cmd.Connection = conn;
                 MySqlTransaction tx = conn.BeginTransaction();
                 cmd.Transaction = tx;
                 try
                 {
                     for (int n = 0; n < SQLStringList.Count; n++)
                     {
                         string strsql = SQLStringList[n].ToString();
                         if (strsql.Trim().Length > 1)
                         {
                             cmd.CommandText = strsql;
                             cmd.ExecuteNonQuery();
                         }
                     }
                     tx.Commit();
                 }
                 catch (MySqlException E)
                 {
                     tx.Rollback();
                     throw new Exception(E.Message);
                 }
             }
         }
         /// <summary>
         /// 执行多条SQL语句，实现数据库事务。
         /// </summary>
         /// <param name="SQLStringList">多条SQL语句</param>	
         public static int ExecuteSqlTran(List<String> SQLStringList)
         {
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 connection.Open();
                 MySqlCommand cmd = new MySqlCommand();
                 cmd.Connection = connection;
                 MySqlTransaction tx = connection.BeginTransaction();
                 cmd.Transaction = tx;
                 try
                 {
                     int count = 0;
                     for (int n = 0; n < SQLStringList.Count; n++)
                     {
                         string strsql = SQLStringList[n];
                         if (strsql.Trim().Length > 1)
                         {
                             cmd.CommandText = strsql;
                             count += cmd.ExecuteNonQuery();
                         }
                     }
                     tx.Commit();
                     return count;
                 }
                 catch
                 {
                     tx.Rollback();
                     return 0;
                 }
                 finally
                 {
                     cmd.Dispose();
                     connection.Close();
                 }
             }
         }
         /// <summary>
         /// 执行带一个存储过程参数的的SQL语句。
         /// </summary>
         /// <param name="SQLString">SQL语句</param>
         /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
         /// <returns>影响的记录数</returns>
         public static int ExecuteSql(string SQLString, string content)
         {
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 MySqlCommand cmd = new MySqlCommand(SQLString, connection);
                 MySqlParameter myParameter = new MySqlParameter("@content", MySqlDbType.VarChar);
                 myParameter.Value = content;
                 cmd.Parameters.Add(myParameter);
                 try
                 {
                     connection.Open();
                     int rows = cmd.ExecuteNonQuery();
                     return rows;
                 }
                 catch (MySqlException E)
                 {
                     throw new Exception(E.Message);
                 }
                 finally
                 {
                     cmd.Dispose();
                     connection.Close();
                 }
             }
         }
         /// <summary>
         /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
         /// </summary>
         /// <param name="strSQL">SQL语句</param>
         /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
         /// <returns>影响的记录数</returns>
         public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
         {
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 MySqlCommand cmd = new MySqlCommand(strSQL, connection);
                 MySqlParameter myParameter = new MySqlParameter("@fs", MySqlDbType.Binary);
                 myParameter.Value = fs;
                 cmd.Parameters.Add(myParameter);
                 try
                 {
                     connection.Open();
                     int rows = cmd.ExecuteNonQuery();
                     return rows;
                 }
                 catch (MySqlException E)
                 {
                     throw new Exception(E.Message);
                 }
                 finally
                 {
                     cmd.Dispose();
                     connection.Close();
                 }
             }
         }

         /// <summary>
         /// 执行一条计算查询结果语句，返回查询结果（object）。
         /// </summary>
         /// <param name="SQLString">计算查询结果语句</param>
         /// <returns>查询结果（object）</returns>
         public static object GetSingle(string SQLString)
         {
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 using (MySqlCommand cmd = new MySqlCommand(SQLString, connection))
                 {
                     try
                     {
                         connection.Open();
                         object obj = cmd.ExecuteScalar();
                         if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                         {
                             return null;
                         }
                         else
                         {
                             return obj;
                         }
                     }
                     catch (MySqlException e)
                     {
                         connection.Close();
                         throw new Exception(e.Message);
                     }
                 }
             }
         }
         /// <summary>
         /// 执行查询语句，返回MySqlDataReader
         /// </summary>
         /// <param name="strSQL">查询语句</param>
         /// <returns>MySqlDataReader</returns>
         public static MySqlDataReader ExecuteReader(string strSQL)
         {
             MySqlConnection connection = new MySqlConnection(connectionString);
             MySqlCommand cmd = new MySqlCommand(strSQL, connection);
             try
             {
                 connection.Open();
                 MySqlDataReader myReader = cmd.ExecuteReader();
                 return myReader;
             }
             catch (MySqlException e)
             {
                 throw new Exception(e.Message);
             }

         }
         /// <summary>
         /// 执行查询语句，返回DataSet
         /// </summary>
         /// <param name="SQLString">查询语句</param>
         /// <returns>DataSet</returns>
         public static DataSet Query(string SQLString)
         {
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 DataSet ds = new DataSet();
                 try
                 {
                     connection.Open();
                     MySqlDataAdapter command = new MySqlDataAdapter(SQLString, connection);
                     command.Fill(ds, "ds");
                 }
                 catch (MySqlException ex)
                 {
                     throw new Exception(ex.Message);
                 }
                 return ds;
             }
         }


         #endregion
    }
}
