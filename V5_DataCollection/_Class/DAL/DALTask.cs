using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_Model;
using System.Data;
using V5_DataCollection._Class.Common;
using V5_WinLibs.DBUtility;

namespace V5_DataCollection._Class.DAL {
    public class DALTask {

        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId() {
            object obj = DbHelper.ExecuteScalar(CommonHelper.SQLiteConnectionString, "select max(id)+1 from S_Task");
            if (obj == null) {
                return 1;
            }
            else {
                return int.Parse(obj.ToString());
            }
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ModelTask model) {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [S_Task] (");
            strSql.Append("ID,TaskClassID,TaskName,IsSpiderUrl,IsSpiderContent,IsPublishContent,PageEncode,CollectionType,CollectionContent,LinkUrlMustIncludeStr,LinkUrlNoMustIncludeStr,LinkUrlCutAreaStart,LinkUrlCutAreaEnd,TestViewUrl,IsWebOnlinePublish1,IsSaveLocal2,SaveFileFormat2,SaveDirectory2,SaveHtmlTemplate2,SaveIsCreateIndex2,IsSaveDataBase3,SaveDataType3,SaveDataUrl3,SaveDataSQL3,IsSaveSQL4,SaveSQLContent4,SaveSQLDirectory4,Guid,PluginSpiderUrl,PluginSpiderContent,PluginSaveContent,PluginPublishContent,Status,CollectionContentThreadCount,CollectionContentStepTime,PublishContentThreadCount,PublishContentStepTimeMin,PublishContentStepTimeMax,DemoListUrl,IsPlan,PlanFormat,IsSource,SourceText,CollectionUrlStepTime,CreateTime,UpdateTime,IsHandGetUrl,HandCollectionUrlRegex)");
            strSql.Append(" values (");
            strSql.Append("@ID,@TaskClassID,@TaskName,@IsSpiderUrl,@IsSpiderContent,@IsPublishContent,@PageEncode,@CollectionType,@CollectionContent,@LinkUrlMustIncludeStr,@LinkUrlNoMustIncludeStr,@LinkUrlCutAreaStart,@LinkUrlCutAreaEnd,@TestViewUrl,@IsWebOnlinePublish1,@IsSaveLocal2,@SaveFileFormat2,@SaveDirectory2,@SaveHtmlTemplate2,@SaveIsCreateIndex2,@IsSaveDataBase3,@SaveDataType3,@SaveDataUrl3,@SaveDataSQL3,@IsSaveSQL4,@SaveSQLContent4,@SaveSQLDirectory4,@Guid,@PluginSpiderUrl,@PluginSpiderContent,@PluginSaveContent,@PluginPublishContent,@Status,@CollectionContentThreadCount,@CollectionContentStepTime,@PublishContentThreadCount,@PublishContentStepTimeMin,@PublishContentStepTimeMax,@DemoListUrl,@IsPlan,@PlanFormat,@IsSource,@SourceText,@CollectionUrlStepTime,@CreateTime,@UpdateTime,@IsHandGetUrl,@HandCollectionUrlRegex)");

            DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString(), model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ModelTask model) {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [S_Task] set ");
            strSql.Append("TaskClassID=@TaskClassID,");
            strSql.Append("TaskName=@TaskName,");
            strSql.Append("IsSpiderUrl=@IsSpiderUrl,");
            strSql.Append("IsSpiderContent=@IsSpiderContent,");
            strSql.Append("IsPublishContent=@IsPublishContent,");
            strSql.Append("PageEncode=@PageEncode,");
            strSql.Append("CollectionType=@CollectionType,");
            strSql.Append("CollectionContent=@CollectionContent,");
            strSql.Append("LinkUrlMustIncludeStr=@LinkUrlMustIncludeStr,");
            strSql.Append("LinkUrlNoMustIncludeStr=@LinkUrlNoMustIncludeStr,");
            strSql.Append("LinkUrlCutAreaStart=@LinkUrlCutAreaStart,");
            strSql.Append("LinkUrlCutAreaEnd=@LinkUrlCutAreaEnd,");
            strSql.Append("TestViewUrl=@TestViewUrl,");
            strSql.Append("IsWebOnlinePublish1=@IsWebOnlinePublish1,");
            strSql.Append("IsSaveLocal2=@IsSaveLocal2,");
            strSql.Append("SaveFileFormat2=@SaveFileFormat2,");
            strSql.Append("SaveDirectory2=@SaveDirectory2,");
            strSql.Append("SaveHtmlTemplate2=@SaveHtmlTemplate2,");
            strSql.Append("SaveIsCreateIndex2=@SaveIsCreateIndex2,");
            strSql.Append("IsSaveDataBase3=@IsSaveDataBase3,");
            strSql.Append("SaveDataType3=@SaveDataType3,");
            strSql.Append("SaveDataUrl3=@SaveDataUrl3,");
            strSql.Append("SaveDataSQL3=@SaveDataSQL3,");
            strSql.Append("IsSaveSQL4=@IsSaveSQL4,");
            strSql.Append("SaveSQLContent4=@SaveSQLContent4,");
            strSql.Append("SaveSQLDirectory4=@SaveSQLDirectory4,");
            strSql.Append("Guid=@Guid,");
            strSql.Append("PluginSpiderUrl=@PluginSpiderUrl,");
            strSql.Append("PluginSpiderContent=@PluginSpiderContent,");
            strSql.Append("PluginSaveContent=@PluginSaveContent,");
            strSql.Append("PluginPublishContent=@PluginPublishContent,");
            strSql.Append("Status=@Status,");
            strSql.Append("CollectionContentThreadCount=@CollectionContentThreadCount,");
            strSql.Append("CollectionContentStepTime=@CollectionContentStepTime,");
            strSql.Append("PublishContentThreadCount=@PublishContentThreadCount,");
            strSql.Append("PublishContentStepTimeMin=@PublishContentStepTimeMin,");
            strSql.Append("PublishContentStepTimeMax=@PublishContentStepTimeMax,");
            strSql.Append("DemoListUrl=@DemoListUrl,");
            strSql.Append("IsPlan=@IsPlan,");
            strSql.Append("PlanFormat=@PlanFormat,");
            strSql.Append("IsSource=@IsSource,");
            strSql.Append("SourceText=@SourceText,");
            strSql.Append("CollectionUrlStepTime=@CollectionUrlStepTime,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("UpdateTime=@UpdateTime,");
            strSql.Append("IsHandGetUrl=@IsHandGetUrl,");
            strSql.Append("HandCollectionUrlRegex=@HandCollectionUrlRegex");
            strSql.Append(" where ID=@ID ");

            return DbHelper.Execute(CommonHelper.SQLiteConnectionString, strSql.ToString(), model) > 0 ? true : false;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from S_Task ");
            strSql.Append(" where ID=" + ID + " ");
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
            strSql.Append("delete from S_Task ");
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
        public ModelTask GetModel(int ID) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ");
            strSql.Append(" * ");
            strSql.Append(" from S_Task ");
            strSql.Append(" where ID=" + ID + " ");
            return DbHelper.Query<ModelTask>(CommonHelper.SQLiteConnectionString, strSql.ToString()).SingleOrDefault();
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM (Select A.*,B.TreeClassName as ClassName From S_Task A Left Join S_TreeClass B On A.TaskClassId=B.ClassId) AA ");
            if (strWhere.Trim() != "") {
                strSql.Append(" where 1=1 " + strWhere);
            }
            return DbHelper.Query(CommonHelper.SQLiteConnectionString, strSql.ToString());
        }

        #endregion  Method

        /// <summary>
        /// 获取单个任务模型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ModelTask GetModelSingleTask(int id) {
            ModelTask model = this.GetModel(id);

            model.ListTaskLabel = new DALTaskLabel().GetModelByTaskID(id);

            model.ListModelWebPublishModule = new DALWebPublishModule().GetListModel(id);
            return model;
        }


        public bool CheckTaskGuid(int taskID) {
            DataSet ds = DbHelper.Query(CommonHelper.SQLiteConnectionString, "Select Guid From S_Task Where ID=" + taskID);
            DataTable dt = ds.Tables[0];
            if (dt != null && dt.Rows.Count > 0) {
                if (!string.IsNullOrEmpty(dt.Rows[0]["guid"].ToString())) {
                    return true;
                }
                return false;
            }
            return false;
        }


        public List<ModelTaskLabel> GetListTaskLabel(int id, ref string guid) {

            return new DALTaskLabel().GetModelByTaskID(id);
        }
    }
}
