using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using V5_WinLibs.DBUtility;
using V5.DataPublish._Class;

namespace V5_DAL {
    public class DALTreeClass {

        public DALTreeClass() {
            DbHelperSQLite.ConnectionString = Common.DbString;
        }

        #region Model
        private int _classid;
        private string _classname;
        private int? _parentid;
        private string _classcode;
        private string _readme;
        private string _adddatetime;
        private string _updatetime;
        /// <summary>
        /// 
        /// </summary>
        public int ClassID {
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
        public int? ParentID {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClassCode {
            set { _classcode = value; }
            get { return _classcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ReadMe {
            set { _readme = value; }
            get { return _readme; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AddDateTime {
            set { _adddatetime = value; }
            get { return _adddatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateTime {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        #endregion Model


        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ClassID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [S_TreeClass] where ClassID=" + ClassID + " ");
            return DbHelperSQLite.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add() {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [S_TreeClass](");
            strSql.Append("ClassName,ParentID,ClassCode,ReadMe,AddDateTime,UpdateTime");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + ClassName + "',");
            strSql.Append("" + ParentID + ",");
            strSql.Append("'" + ClassCode + "',");
            strSql.Append("'" + ReadMe + "',");
            strSql.Append("'" + AddDateTime + "',");
            strSql.Append("'" + UpdateTime + "'");
            strSql.Append(")");
            DbHelperSQLite.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update() {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [S_TreeClass] set ");
            strSql.Append("ClassName='" + ClassName + "',");
            strSql.Append("ParentID=" + ParentID + ",");
            strSql.Append("ClassCode='" + ClassCode + "',");
            strSql.Append("ReadMe='" + ReadMe + "',");
            strSql.Append("UpdateTime='" + UpdateTime + "'");
            strSql.Append(" where ClassID=" + ClassID + "");
            DbHelperSQLite.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ClassID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [S_TreeClass] ");
            strSql.Append(" where ClassID=" + ClassID + "");
            DbHelperSQLite.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DALTreeClass GetModel(int ClassID) {
            DALTreeClass model = new DALTreeClass();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ");
            strSql.Append("ClassID,ClassName,ParentID,ClassCode,ReadMe,AddDateTime,UpdateTime ");
            strSql.Append(" from [S_TreeClass] ");
            strSql.Append(" where ClassID=" + ClassID + "");
            DataSet ds = DbHelperSQLite.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0) {
                if (ds.Tables[0].Rows[0]["ClassID"].ToString() != "") {
                    model.ClassID = int.Parse(ds.Tables[0].Rows[0]["ClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassName"] != null) {
                    model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "") {
                    model.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassCode"] != null) {
                    model.ClassCode = ds.Tables[0].Rows[0]["ClassCode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ReadMe"] != null) {
                    model.ReadMe = ds.Tables[0].Rows[0]["ReadMe"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AddDateTime"].ToString() != "") {
                    model.AddDateTime = ds.Tables[0].Rows[0]["AddDateTime"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UpdateTime"].ToString() != "") {
                    model.UpdateTime = ds.Tables[0].Rows[0]["UpdateTime"].ToString();
                }
                return model;
            }
            return null;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [S_TreeClass] ");
            if (strWhere.Trim() != "") {

                strSql.Append(" where 1=1 " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        #endregion  Method
    }
}
