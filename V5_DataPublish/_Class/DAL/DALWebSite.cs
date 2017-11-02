using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using V5_WinLibs.DBUtility;
using V5_DataPlugins;
using V5_Model;
using V5.DataPublish._Class;

namespace V5_DAL {
    public class DALWebSite {
        public DALWebSite() {
            DbHelperSQLite.ConnectionString = Common.DbString;
        }

        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ModelWebSiteItem GetModle(int ID) {
            ModelWebSiteItem model = new ModelWebSiteItem();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ");
            strSql.Append("* ");
            strSql.Append(" from [S_WebSite] ");
            strSql.Append(" where ID=" + ID + " ");
            DataSet ds = DbHelperSQLite.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0) {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "") {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassID"].ToString() != "") {
                    model.ClassID = int.Parse(ds.Tables[0].Rows[0]["ClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["WebSiteName"] != null) {
                    model.WebSiteName = ds.Tables[0].Rows[0]["WebSiteName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["WebSiteUrl"] != null) {
                    model.WebSiteUrl = ds.Tables[0].Rows[0]["WebSiteUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["WebSiteLoginUrl"] != null) {
                    model.WebSiteLoginUrl = ds.Tables[0].Rows[0]["WebSiteLoginUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PublishName"] != null) {
                    model.PublishName = ds.Tables[0].Rows[0]["PublishName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["LoginUserName"] != null) {
                    model.LoginUserName = ds.Tables[0].Rows[0]["LoginUserName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["LoginUserPwd"] != null) {
                    model.LoginUserPwd = ds.Tables[0].Rows[0]["LoginUserPwd"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CookiesValue"] != null) {
                    model.CookiesValue = ds.Tables[0].Rows[0]["CookiesValue"].ToString();
                }
                if (ds.Tables[0].Rows[0]["IsCookie"].ToString() != "") {
                    model.IsCookie = int.Parse(ds.Tables[0].Rows[0]["IsCookie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Status"].ToString() != "") {
                    model.Status = int.Parse(ds.Tables[0].Rows[0]["Status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsLinkPic"].ToString() != "") {
                    model.IsLinkPic = int.Parse(ds.Tables[0].Rows[0]["IsLinkPic"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsLinkWord"].ToString() != "") {
                    model.IsLinkWord = int.Parse(ds.Tables[0].Rows[0]["IsLinkWord"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsLinkPdf"].ToString() != "") {
                    model.IsLinkPdf = int.Parse(ds.Tables[0].Rows[0]["IsLinkPdf"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsLinkVideo"].ToString() != "") {
                    model.IsLinkVideo = int.Parse(ds.Tables[0].Rows[0]["IsLinkVideo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsTitleFalse"].ToString() != "") {
                    model.IsTitleFalse = int.Parse(ds.Tables[0].Rows[0]["IsTitleFalse"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsContentFalse"].ToString() != "") {
                    model.IsContentFalse = int.Parse(ds.Tables[0].Rows[0]["IsContentFalse"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsAddTask"].ToString() != "") {
                    model.IsAddTask = int.Parse(ds.Tables[0].Rows[0]["IsAddTask"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AddDateTime"] != null) {
                    model.AddDateTime = ds.Tables[0].Rows[0]["AddDateTime"].ToString();
                }
                #region 2012             2 22

                if (ds.Tables[0].Rows[0]["DataSourceType"] != null) {
                    model.DataSourceType = int.Parse("0" + ds.Tables[0].Rows[0]["DataSourceType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DataType"] != null) {
                    model.DataType = ds.Tables[0].Rows[0]["DataType"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DataLinkUrl"] != null) {
                    model.DataLinkUrl = ds.Tables[0].Rows[0]["DataLinkUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DataQuerySQL"] != null) {
                    model.DataQuerySQL = ds.Tables[0].Rows[0]["DataQuerySQL"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FileSourcePath"] != null) {
                    model.FileSourcePath = ds.Tables[0].Rows[0]["FileSourcePath"].ToString();
                }
                #endregion
                return model;
            }
            return null;
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId() {

            return DbHelperSQLite.GetMaxID("ID", "S_WebSite");
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [S_WebSite] where ID=" + ID + " ");
            return DbHelperSQLite.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ModelWebSiteItem model) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [S_WebSite](");
            strSql.Append("ClassID,WebSiteName,WebSiteUrl,WebSiteLoginUrl,PublishName,LoginUserName,LoginUserPwd,CookiesValue,IsCookie,Status,IsLinkPic,IsLinkWord,IsLinkPdf,IsLinkVideo,IsTitleFalse,IsContentFalse,IsAddTask,DataSourceType,DataType,DataLinkUrl,DataQuerySQL,FileSourcePath,AddDateTime,UpdateTime");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("" + model.ClassID + ",");
            strSql.Append("'" + model.WebSiteName + "',");
            strSql.Append("'" + model.WebSiteUrl + "',");
            strSql.Append("'" + model.WebSiteLoginUrl + "',");
            strSql.Append("'" + model.PublishName + "',");
            strSql.Append("'" + model.LoginUserName + "',");
            strSql.Append("'" + model.LoginUserPwd + "',");
            strSql.Append("'" + model.CookiesValue + "',");
            strSql.Append("" + model.IsCookie + ",");
            strSql.Append("" + model.Status + ",");
            strSql.Append("" + model.IsLinkPic + ",");
            strSql.Append("" + model.IsLinkWord + ",");
            strSql.Append("" + model.IsLinkPdf + ",");
            strSql.Append("" + model.IsLinkVideo + ",");
            strSql.Append("" + model.IsTitleFalse + ",");
            strSql.Append("" + model.IsContentFalse + ",");
            strSql.Append("" + model.IsAddTask + ",");
            #region 2012 2 22
            strSql.Append("" + model.DataSourceType + ",");
            strSql.Append("'" + model.DataType + "',");
            strSql.Append("'" + model.DataLinkUrl + "',");
            strSql.Append("'" + model.DataQuerySQL + "',");
            strSql.Append("'" + model.FileSourcePath + "',");
            #endregion
            strSql.Append("'" + model.AddDateTime + "',");
            strSql.Append("'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'");
            strSql.Append(")");
            DbHelperSQLite.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ModelWebSiteItem model) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [S_WebSite] set ");
            if (model.ClassID != null) {
                strSql.Append("ClassID=" + model.ClassID + ",");
            }
            if (model.WebSiteName != null) {
                strSql.Append("WebSiteName='" + model.WebSiteName + "',");
            }
            if (model.WebSiteUrl != null) {
                strSql.Append("WebSiteUrl='" + model.WebSiteUrl + "',");
            }
            if (model.WebSiteLoginUrl != null) {
                strSql.Append("WebSiteLoginUrl='" + model.WebSiteLoginUrl + "',");
            }
            if (model.PublishName != null) {
                strSql.Append("PublishName='" + model.PublishName + "',");
            }
            if (model.LoginUserName != null) {
                strSql.Append("LoginUserName='" + model.LoginUserName + "',");
            }
            if (model.LoginUserPwd != null) {
                strSql.Append("LoginUserPwd='" + model.LoginUserPwd + "',");
            }
            if (model.CookiesValue != null) {
                strSql.Append("CookiesValue='" + model.CookiesValue + "',");
            }
            if (model.IsCookie != null) {
                strSql.Append("IsCookie=" + model.IsCookie + ",");
            }
            if (model.Status != null) {
                strSql.Append("Status=" + model.Status + ",");
            }
            if (model.IsLinkPic != null) {
                strSql.Append("IsLinkPic=" + model.IsLinkPic + ",");
            }
            if (model.IsLinkWord != null) {
                strSql.Append("IsLinkWord=" + model.IsLinkWord + ",");
            }
            if (model.IsLinkPdf != null) {
                strSql.Append("IsLinkPdf=" + model.IsLinkPdf + ",");
            }
            if (model.IsLinkVideo != null) {
                strSql.Append("IsLinkVideo=" + model.IsLinkVideo + ",");
            }
            if (model.IsTitleFalse != null) {
                strSql.Append("IsTitleFalse=" + model.IsTitleFalse + ",");
            }
            if (model.IsContentFalse != null) {
                strSql.Append("IsContentFalse=" + model.IsContentFalse + ",");
            }
            if (model.IsAddTask != null) {
                strSql.Append("IsAddTask=" + model.IsAddTask + ",");
            }
            #region
            if (model.DataSourceType != null) {
                strSql.Append("DataSourceType=" + model.DataSourceType + ",");
            }
            if (model.DataType != null) {
                strSql.Append("DataType='" + model.DataType + "',");
            }
            if (model.DataLinkUrl != null) {
                strSql.Append("DataLinkUrl='" + model.DataLinkUrl + "',");
            }
            if (model.DataQuerySQL != null) {
                strSql.Append("DataQuerySQL='" + model.DataQuerySQL + "',");
            }
            if (model.FileSourcePath != null) {
                strSql.Append("FileSourcePath='" + model.FileSourcePath + "',");
            }
            #endregion
            strSql.Append("AddDateTime='" + model.AddDateTime + "'");
            strSql.Append(" where ID=" + model.ID + " ");
            DbHelperSQLite.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [S_WebSite] ");
            strSql.Append(" where ID=" + ID + " ");
            DbHelperSQLite.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [S_WebSite] ");
            if (strWhere.Trim() != "") {

                strSql.Append(" where 1=1 " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        #endregion  Method


        #region
        public DataTable GetWebSiteTask(int StepMinuTime) {
            DataSet ds = new DataSet();
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    Select * From S_WebSite 
                    Where Status=1 
                    --And  (julianday(UpdateTime)*24*60 - julianday('now')*24*60)>{0}
                    Order by UpdateTime Asc  Limit 5 
            ", StepMinuTime);
            ds = DbHelperSQLite.Query(strSql.ToString());
            DataTable dt = ds.Tables[0].Clone();
            foreach (DataRow dr in ds.Tables[0].Rows) {
                DateTime upDateTime = Convert.ToDateTime(dr["UpDateTime"]);
                if ((DateTime.Now - upDateTime).Minutes >= StepMinuTime) {
                    dt.Rows.Add(dr.ItemArray);
                }
            }
            string IDs = string.Empty;
            foreach (DataRow dr in dt.Rows) {
                IDs += dr["ID"] + ",";
            }
            if (!string.IsNullOrEmpty(IDs)) {
                IDs = IDs.Remove(IDs.Length - 1);
                strSql = new StringBuilder();
                strSql.Append(@"
                Update S_WebSite set UpdateTime='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + @"' Where ID in(" + IDs + @") 
            ");
                DbHelperSQLite.ExecuteSql(strSql.ToString());
            }
            return dt;
        }
        #endregion
    }
}
