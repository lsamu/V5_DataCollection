using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataCollection._Class.Common;
using V5_WinLibs.DBUtility;

namespace V5_DataCollection._Class.DAL {

    public class DALDiyWebUrlHelper {
        /// <summary>
        /// 查询记录
        /// </summary>
        public static List<ModelDiyWebUrl> GetList(string strWhere, string orderBy, int limit) {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("Select * From S_DiyWebUrl ");
            if (strWhere.Trim() != "") {
                sbSql.Append(" where 1=1 " + strWhere);
            }
            if (orderBy.Trim() != "") {
                sbSql.Append(" Order By " + orderBy);
            }
            if (limit > 0) {
                sbSql.Append(" Limit " + limit + " ");
            }
            return DbHelper.Query<ModelDiyWebUrl>(CommonHelper.SQLiteConnectionString, sbSql.ToString(), null).ToList();
        }
        /// <summary>
        /// 插入记录
        /// </summary>
        public static int Insert(ModelDiyWebUrl model) {
            string sql = string.Format("Insert Into S_DiyWebUrl(SelfId,Name,Url,UrlEncode,UrlParams,CreateTime)Values({0},'{1}','{2}','{3}','{4}','{5}')",
                model.SelfId,
                model.Name,
                model.Url,
                model.UrlEncode,
                model.UrlParams,
                model.CreateTime);
            return DbHelper.Execute(CommonHelper.SQLiteConnectionString, sql, null);
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        public static int Update(ModelDiyWebUrl model, int Id) {
            string sql = string.Format("Update S_DiyWebUrl Set SelfId={0}, Name='{1}',Url='{2}',UrlEncode='{3}',UrlParams='{4}' Where Id={5}",
                model.SelfId,
                model.Name,
                model.Url,
                model.UrlEncode,
                model.UrlParams,
                Id
                );
            return DbHelper.Execute(CommonHelper.SQLiteConnectionString, sql, null);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        public static void Delete(int Id) {
            DbHelper.Execute(CommonHelper.SQLiteConnectionString, "Delete From S_DiyWebUrl Where Id=" + Id, null);
        }
        /// <summary>
        /// 获取最大Id
        /// </summary>
        public static void NewId() {
            DbHelper.Query<Int64>(CommonHelper.SQLiteConnectionString, "Select Max(Id)+1 From S_DiyWebUrl", null);
        }
    }

    public class ModelDiyWebUrl {
        private Int64? _id;

        public Int64? Id {
            get { return _id; }
            set { _id = value; }
        }
        private int? _SelfId;

        public int? SelfId {
            get { return _SelfId; }
            set { _SelfId = value; }
        }

        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        private string _Url;

        public string Url {
            get { return _Url; }
            set { _Url = value; }
        }

        private string _UrlEncode;

        public string UrlEncode {
            get { return _UrlEncode; }
            set { _UrlEncode = value; }
        }

        private string _UrlParams;

        public string UrlParams {
            get { return _UrlParams; }
            set { _UrlParams = value; }
        }

        private string _CreateTime;

        public string CreateTime {
            get { return _CreateTime; }
            set { _CreateTime = value; }
        }

    }
}
