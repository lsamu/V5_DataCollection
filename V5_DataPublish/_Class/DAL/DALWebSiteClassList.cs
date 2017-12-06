using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using V5_DataPublish._Class;
using V5_WinLibs.DBUtility;

namespace V5_DAL {
    public class DALWebSiteClassList {
        string dbStr = Common.DbString;
        public DALWebSiteClassList() {
        }

        #region Model
        private int _id;
        private int? _websiteid;
        private int? _classid;
        private string _classname;
        private string _keywordlist;
        private string _adddatetime;
        /// <summary>
        /// 
        /// </summary>
        public int ID {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? WebSiteID {
            set { _websiteid = value; }
            get { return _websiteid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ClassID {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClassName {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KeywordList {
            set { _keywordlist = value; }
            get { return _keywordlist; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AddDateTime {
            set { _adddatetime = value; }
            get { return _adddatetime; }
        }
        #endregion Model


        #region  Method
        public DALWebSiteClassList GetModel(int ID) {
            DALWebSiteClassList model = new DALWebSiteClassList();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [S_WebSiteKeywords] ");
            strSql.Append(" where ID=" + ID);
            DataSet ds = DbHelper.Query(dbStr, strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0) {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "") {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["WebSiteID"] != null && ds.Tables[0].Rows[0]["WebSiteID"].ToString() != "") {
                    model.WebSiteID = int.Parse(ds.Tables[0].Rows[0]["WebSiteID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassID"] != null && ds.Tables[0].Rows[0]["ClassID"].ToString() != "") {
                    model.ClassID = int.Parse(ds.Tables[0].Rows[0]["ClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassName"] != null && ds.Tables[0].Rows[0]["ClassName"].ToString() != "") {
                    model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["KeywordList"] != null && ds.Tables[0].Rows[0]["KeywordList"].ToString() != "") {
                    model.KeywordList = ds.Tables[0].Rows[0]["KeywordList"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AddDateTime"] != null && ds.Tables[0].Rows[0]["AddDateTime"].ToString() != "") {
                    model.AddDateTime = ds.Tables[0].Rows[0]["AddDateTime"].ToString();
                }
                return model;
            }
            return null;
        }

        public void Add() {

        }


        public void Update() {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update S_WebSiteKeywords set ");
            if (this.WebSiteID != null) {
                strSql.Append("WebSiteID=" + this.WebSiteID + ",");
            }
            if (this.ClassID != null) {
                strSql.Append("ClassID=" + this.ClassID + ",");
            }
            if (this.ClassName != null) {
                strSql.Append("ClassName='" + this.ClassName + "',");
            }
            if (this.KeywordList != null) {
                strSql.Append("KeywordList='" + this.KeywordList + "',");
            }
            if (this.AddDateTime != null) {
                strSql.Append("AddDateTime='" + this.AddDateTime + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ID=" + this.ID + " ");
            int rows = DbHelper.Execute(dbStr, strSql.ToString());
        }


        public void Delete(int ID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [S_WebSiteKeywords] ");
            strSql.Append(" where ID=" + ID + " ");
            DbHelper.Execute(dbStr, strSql.ToString());
        }

        public int GetMaxId(string id, string tbName) {
            object obj = DbHelper.ExecuteScalar(dbStr, "select max(" + id + ")+1 from " + tbName);
            if (obj == null) {
                return 1;
            }
            else {
                return int.Parse(obj.ToString());
            }
        }
        #endregion

        #region
        public bool InsertClassList(string sWebSiteID,
            string ClassID, string ClassName, string keywordlist) {
            if (sWebSiteID == "0") {
                sWebSiteID = Convert.ToString("" + this.GetMaxId("ID", "S_WebSiteKeywords"));
            }
            object oCount = DbHelper.ExecuteScalar(dbStr, string.Format(@"
                    Select Count(ID) From S_WebSiteKeywords
                    Where WebSiteID={0} And ClassID={1}
            ", sWebSiteID, ClassID, ClassName));
            if (Convert.ToInt32("0" + oCount) == 0) {
                DbHelper.Execute(dbStr, string.Format("Insert into S_WebSiteKeywords (WebSiteID,ClassID,ClassName,KeywordList,AddDateTime)values({0},{1},'{2}','{3}','{4}')", sWebSiteID, ClassID, ClassName, keywordlist, DateTime.Now.ToString()));
                return true;
            }
            else {
                DbHelper.Execute(dbStr, string.Format("Update S_WebSiteKeywords Set ClassName='{2}' Where ClassID={1} And WebSiteID={0}", sWebSiteID, ClassID, ClassName));
                return true;
            }
            return false;
        }


        public DataSet GetClassList(string sWebSiteID) {
            if (sWebSiteID == "0") {
                sWebSiteID = Convert.ToString("" + this.GetMaxId("ID", "S_WebSiteKeywords"));
            }
            DataSet ds = new DataSet();
            ds = DbHelper.Query(dbStr, string.Format("Select * From S_WebSiteKeywords Where WebSiteID={0} Order by ID Asc", sWebSiteID));
            return ds;
        }

        #endregion



        #region 获取网络分类列表
        public DataTable GetClassNewWork() {
            DataTable dt = new DataTable();
            DataSet ds = DbHelper.Query(dbStr,@"
                    select * from s_websitekeywords where  websiteid in(
                        select id from S_WEBSITE  where DataSourceType = 4
                    ) order by websiteid asc
            ");
            if (dt != null) {
                dt = ds.Tables[0];
            }
            return dt;
        }
        #endregion
    }
}
