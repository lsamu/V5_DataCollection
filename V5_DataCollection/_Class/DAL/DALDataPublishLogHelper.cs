using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataCollection._Class.Common;
using V5_WinLibs.DBUtility;

namespace V5_DataCollection._Class.DAL {
    public class DALDataPublishLogHelper {

        /// <summary>
        /// 插入记录
        /// </summary>
        public static bool Insert(ModelDataPublishLog model) {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Insert Into S_DataPublish_Log(TaskId,ResultId,desKey,CreateTime)Values({0},{1},'{2}','{3}')",
                model.TaskId,
                model.ResultId,
                model.DesKey,
                model.CreateTime
                ));
            return DbHelper.Execute(CommonHelper.SQLiteConnectionString, sb.ToString()) > 0;
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        public static bool Update(ModelDataPublishLog model) {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Update S_DataPublish_Log Set TaskId={0},ResultId={1},desKey='{2}' Where Id={3}",
                model.TaskId,
                model.ResultId,
                model.DesKey,
                model.CreateTime
                ));
            return DbHelper.Execute(CommonHelper.SQLiteConnectionString, sb.ToString()) > 0;
        }
        /// <summary>
        /// 查询记录集
        /// </summary>
        public static List<ModelDataPublishLog> GetList(string strWhere, string orderBy, int limit) {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("Select * From S_DataPublish_Log ");
            if (strWhere.Trim() != "") {
                sbSql.Append(" where 1=1 " + strWhere);
            }
            if (orderBy.Trim() != "") {
                sbSql.Append(" Order By " + orderBy);
            }
            if (limit > 0) {
                sbSql.Append(" Limit " + limit + " ");
            }
            return DbHelper.Query<ModelDataPublishLog>(CommonHelper.SQLiteConnectionString, sbSql.ToString()).ToList();
        }
        /// <summary>
        /// 判断记录是否存在
        /// </summary>
        public static bool ChkRecord(int taskId, int resultId, string md5key) {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Select * From S_DataPublish_Log Where TaskId={0} And ResultId={1} And desKey='{2}' Limit 1",
                taskId,
                resultId,
                md5key
                ));
            return DbHelper.Query<ModelDataPublishLog>(CommonHelper.SQLiteConnectionString, sb.ToString()).SingleOrDefault() != null;
        }
    }

    public class ModelDataPublishLog {
        private Int64 _Id;

        public Int64 Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _TaskId;

        public int TaskId {
            get { return _TaskId; }
            set { _TaskId = value; }
        }

        private int _ResultId;

        public int ResultId {
            get { return _ResultId; }
            set { _ResultId = value; }
        }

        private string _desKey;

        public string DesKey {
            get { return _desKey; }
            set { _desKey = value; }
        }

        private string _CreateTime;

        public string CreateTime {
            get { return _CreateTime; }
            set { _CreateTime = value; }
        }

    }
}
