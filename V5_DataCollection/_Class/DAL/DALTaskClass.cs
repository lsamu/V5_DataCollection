using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataCollection._Class.Common;
using System.Data;
using V5_Model;
using V5_WinLibs.DBUtility;

namespace V5_DataCollection._Class.DAL {
    public class DALTaskClass {

        public void Insert(ModelTaskClass model) {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into S_TreeClass(");
            strSql.Append("TreeClassName,TreeClassReadMe)");
            strSql.Append(" values (");
            strSql.Append("@TreeClassName,@TreeClassReadMe)");
            DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString(), model);
        }

        public void Update(ModelTaskClass model) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update S_TreeClass set ");
            strSql.Append("TreeClassName=@TreeClassName,");
            strSql.Append("TreeClassReadMe=@TreeClassReadMe");
            strSql.Append(" where ClassID=@ClassID");
            int rowsAffected = DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString(), model);
        }

        public void Delete(int ID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from S_TreeClass ");
            strSql.Append(" where ClassID=" + ID + " ");
            DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString());
        }

        public DataSet GetList(string strWhere) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM S_TreeClass ");
            if (strWhere.Trim() != "") {
                strSql.Append(" where " + strWhere);
            }
            return DbHelper.Query(CommonHelper.SQLiteConnectionString, strSql.ToString());
        }

    }
}
