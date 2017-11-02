using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_Model;
using System.Data;
using V5_DataCollection._Class.Common;
using V5_WinLibs.DBUtility;

namespace V5_DataCollection._Class.DAL {
    public class DALWebPublishModule {

        #region  Method
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ModelWebPublishModule model) {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.TaskID != null) {
                strSql1.Append("TaskID,");
                strSql2.Append("" + model.TaskID + ",");
            }
            if (model.ModuleName != null) {
                strSql1.Append("ModuleName,");
                strSql2.Append("'" + model.ModuleName + "',");
            }
            if (model.SiteUrl != null) {
                strSql1.Append("SiteUrl,");
                strSql2.Append("'" + model.SiteUrl + "',");
            }
            if (model.IsCookiesLogin != null) {
                strSql1.Append("IsCookiesLogin,");
                strSql2.Append("" + model.IsCookiesLogin + ",");
            }
            if (model.CookiesValue != null) {
                strSql1.Append("CookiesValue,");
                strSql2.Append("'" + model.CookiesValue + "',");
            }
            if (model.ClassID != null) {
                strSql1.Append("ClassID,");
                strSql2.Append("" + model.ClassID + ",");
            }
            if (model.ClassName != null) {
                strSql1.Append("ClassName,");
                strSql2.Append("'" + model.ClassName + "',");
            }
            if (model.LoginUserName != null) {
                strSql1.Append("LoginUserName,");
                strSql2.Append("'" + model.LoginUserName + "',");
            }
            if (model.LoginUserPwd != null) {
                strSql1.Append("LoginUserPwd,");
                strSql2.Append("'" + model.LoginUserPwd + "',");
            }
            if (model.ModuleNameFile != null) {
                strSql1.Append("ModuleNameFile,");
                strSql2.Append("'" + model.ModuleNameFile + "',");
            }
            if (model.CreateTime != null) {
                strSql1.Append("CreateTime,");
                strSql2.Append("'" + model.CreateTime + "',");
            }
            strSql.Append("insert into S_WebPublishModule(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            strSql.Append(";select LAST_INSERT_ROWID()");
            object obj = DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString());
            if (obj == null) {
                return 0;
            }
            else {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ModelWebPublishModule model) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update S_WebPublishModule set ");
            if (model.TaskID != null) {
                strSql.Append("TaskID=" + model.TaskID + ",");
            }
            else {
                strSql.Append("TaskID= null ,");
            }
            if (model.ModuleName != null) {
                strSql.Append("ModuleName='" + model.ModuleName + "',");
            }
            else {
                strSql.Append("ModuleName= null ,");
            }
            if (model.SiteUrl != null) {
                strSql.Append("SiteUrl='" + model.SiteUrl + "',");
            }
            else {
                strSql.Append("SiteUrl= null ,");
            }
            if (model.IsCookiesLogin != null) {
                strSql.Append("IsCookiesLogin=" + model.IsCookiesLogin + ",");
            }
            else {
                strSql.Append("IsCookiesLogin= null ,");
            }
            if (model.CookiesValue != null) {
                strSql.Append("CookiesValue='" + model.CookiesValue + "',");
            }
            else {
                strSql.Append("CookiesValue= null ,");
            }
            if (model.ClassID != null) {
                strSql.Append("ClassID=" + model.ClassID + ",");
            }
            else {
                strSql.Append("ClassID= null ,");
            }
            if (model.ClassName != null) {
                strSql.Append("ClassName='" + model.ClassName + "',");
            }
            else {
                strSql.Append("ClassName= null ,");
            }
            if (model.LoginUserName != null) {
                strSql.Append("LoginUserName='" + model.LoginUserName + "',");
            }
            else {
                strSql.Append("LoginUserName= null ,");
            }
            if (model.LoginUserPwd != null) {
                strSql.Append("LoginUserPwd='" + model.LoginUserPwd + "',");
            }
            else {
                strSql.Append("LoginUserPwd= null ,");
            }
            if (model.ModuleNameFile != null) {
                strSql.Append("ModuleNameFile='" + model.ModuleNameFile + "',");
            }
            else {
                strSql.Append("ModuleNameFile= null ,");
            }
            if (model.CreateTime != null) {
                strSql.Append("CreateTime='" + model.CreateTime + "',");
            }
            else {
                strSql.Append("CreateTime= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ID=" + model.ID + "");
            int rowsAffected = DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString());
            if (rowsAffected > 0) {
                return true;
            }
            else {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from S_WebPublishModule ");
            strSql.Append(" where ID=" + ID + "");
            int rowsAffected = DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString());
            if (rowsAffected > 0) {
                return true;
            }
            else {
                return false;
            }
        }        
                /// 删除一条数据
                /// </summary>
        public bool DeleteList(string IDlist) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from S_WebPublishModule ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString());
            if (rows > 0) {
                return true;
            }
            else {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ModelWebPublishModule GetModel(int ID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ");
            strSql.Append(" ID,TaskID,ModuleName,SiteUrl,IsCookiesLogin,CookiesValue,ClassID,ClassName,LoginUserName,LoginUserPwd,ModuleNameFile,CreateTime ");
            strSql.Append(" from S_WebPublishModule ");
            strSql.Append(" where ID=" + ID + "");
            ModelWebPublishModule model = new ModelWebPublishModule();
            DataSet ds = DbHelper.Query(CommonHelper.SQLiteConnectionString, strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0) {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "") {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"].ToString() != "") {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ModuleName"] != null) {
                    model.ModuleName = ds.Tables[0].Rows[0]["ModuleName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SiteUrl"] != null) {
                    model.SiteUrl = ds.Tables[0].Rows[0]["SiteUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["IsCookiesLogin"].ToString() != "") {
                    model.IsCookiesLogin = int.Parse(ds.Tables[0].Rows[0]["IsCookiesLogin"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CookiesValue"] != null) {
                    model.CookiesValue = ds.Tables[0].Rows[0]["CookiesValue"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ClassID"].ToString() != "") {
                    model.ClassID = int.Parse(ds.Tables[0].Rows[0]["ClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassName"] != null) {
                    model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["LoginUserName"] != null) {
                    model.LoginUserName = ds.Tables[0].Rows[0]["LoginUserName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["LoginUserPwd"] != null) {
                    model.LoginUserPwd = ds.Tables[0].Rows[0]["LoginUserPwd"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ModuleNameFile"] != null) {
                    model.ModuleNameFile = ds.Tables[0].Rows[0]["ModuleNameFile"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null) {
                    model.CreateTime = ds.Tables[0].Rows[0]["CreateTime"].ToString();
                }
                return model;
            }
            else {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TaskID,ModuleName,SiteUrl,IsCookiesLogin,CookiesValue,ClassID,ClassName,LoginUserName,LoginUserPwd,ModuleNameFile,CreateTime ");
            strSql.Append(" FROM S_WebPublishModule ");
            if (strWhere.Trim() != "") {
                strSql.Append(" where " + strWhere);
            }
            return DbHelper.Query(CommonHelper.SQLiteConnectionString, strSql.ToString());
        }
        #endregion  Method

        public List<ModelWebPublishModule> GetListModel(int TaskID) {
            List<ModelWebPublishModule> list = new List<ModelWebPublishModule>();
            DataTable dt = this.GetList(" TaskID=" + TaskID + " ").Tables[0];
            foreach (DataRow dr in dt.Rows) {
                ModelWebPublishModule model = this.GetModel(int.Parse("0" + dr["ID"]));
                list.Add(model);
            }
            return list;
        }
    }
}
