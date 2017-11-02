using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataCollection.Forms.Publish;

namespace V5_Model {
    /// <summary>
    /// 采集任务实体类
    /// </summary>
    [Serializable]
    public class ModelTask {

        /// <summary>
        /// 任务标签
        /// </summary>
        public List<ModelTaskLabel> ListTaskLabel { set; get; }
        /// <summary>
        /// 任务发布模块
        /// </summary>
        public List<ModelWebPublishModule> ListModelWebPublishModule { set; get; }

        #region Model
        private int _id=0;
        private int? _taskclassid = 0;
        private string _taskname = string.Empty;
        private int? _isspiderurl = 0;
        private int? _isspidercontent = 0;
        private int? _ispublishcontent = 0;
        private string _pageencode = string.Empty;
        private int? _collectiontype = 0;
        private string _collectioncontent = string.Empty;
        private string _linkurlmustincludestr = string.Empty;
        private string _linkurlnomustincludestr = string.Empty;
        private string _linkurlcutareastart = string.Empty;
        private string _linkurlcutareaend = string.Empty;
        private string _testviewurl = string.Empty;
        private int? _iswebonlinepublish1 = 0;
        private int? _issavelocal2 = 0;
        private string _savefileformat2 = string.Empty;
        private string _savedirectory2 = string.Empty;
        private string _savehtmltemplate2 = string.Empty;
        private int? _saveiscreateindex2 = 0;
        private int? _issavedatabase3 = 0;
        private int? _savedatatype3 = 0;
        private string _savedataurl3 = string.Empty;
        private string _savedatasql3 = string.Empty;
        private int? _issavesql4 = 0;
        private string _savesqlcontent4 = string.Empty;
        private string _savesqldirectory4 = string.Empty;
        private string _guid = string.Empty;
        private string _pluginspiderurl = string.Empty;
        private string _pluginspidercontent = string.Empty;
        private string _pluginsavecontent = string.Empty;
        private string _pluginpublishcontent = string.Empty;
        private int? _status = 0;
        private int? _collectioncontentthreadcount = 0;
        private int? _collectioncontentsteptime = 0;
        private int? _publishcontentthreadcount = 0;
        private int? _publishcontentsteptimemin = 0;
        private int? _publishcontentsteptimemax = 0;
        private string _demolisturl = string.Empty;
        private int? _isplan = 0;
        private string _planformat = string.Empty;
        private int? _issource = 0;
        private string _sourcetext = string.Empty;
        private int? _collectionurlsteptime = 0;
        private DateTime? _createtime = DateTime.Now;
        private DateTime? _updatetime = DateTime.Now;
        private int? _ishandgeturl = 0;
        private string _handcollectionurlregex=string.Empty;
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
        public int? TaskClassID {
            set { _taskclassid = value; }
            get { return _taskclassid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TaskName {
            set { _taskname = value; }
            get { return _taskname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsSpiderUrl {
            set { _isspiderurl = value; }
            get { return _isspiderurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsSpiderContent {
            set { _isspidercontent = value; }
            get { return _isspidercontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsPublishContent {
            set { _ispublishcontent = value; }
            get { return _ispublishcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageEncode {
            set { _pageencode = value; }
            get { return _pageencode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CollectionType {
            set { _collectiontype = value; }
            get { return _collectiontype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CollectionContent {
            set { _collectioncontent = value; }
            get { return _collectioncontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkUrlMustIncludeStr {
            set { _linkurlmustincludestr = value; }
            get { return _linkurlmustincludestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkUrlNoMustIncludeStr {
            set { _linkurlnomustincludestr = value; }
            get { return _linkurlnomustincludestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkUrlCutAreaStart {
            set { _linkurlcutareastart = value; }
            get { return _linkurlcutareastart; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkUrlCutAreaEnd {
            set { _linkurlcutareaend = value; }
            get { return _linkurlcutareaend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TestViewUrl {
            set { _testviewurl = value; }
            get { return _testviewurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsWebOnlinePublish1 {
            set { _iswebonlinepublish1 = value; }
            get { return _iswebonlinepublish1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsSaveLocal2 {
            set { _issavelocal2 = value; }
            get { return _issavelocal2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaveFileFormat2 {
            set { _savefileformat2 = value; }
            get { return _savefileformat2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaveDirectory2 {
            set { _savedirectory2 = value; }
            get { return _savedirectory2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaveHtmlTemplate2 {
            set { _savehtmltemplate2 = value; }
            get { return _savehtmltemplate2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? SaveIsCreateIndex2 {
            set { _saveiscreateindex2 = value; }
            get { return _saveiscreateindex2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsSaveDataBase3 {
            set { _issavedatabase3 = value; }
            get { return _issavedatabase3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? SaveDataType3 {
            set { _savedatatype3 = value; }
            get { return _savedatatype3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaveDataUrl3 {
            set { _savedataurl3 = value; }
            get { return _savedataurl3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaveDataSQL3 {
            set { _savedatasql3 = value; }
            get { return _savedatasql3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsSaveSQL4 {
            set { _issavesql4 = value; }
            get { return _issavesql4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaveSQLContent4 {
            set { _savesqlcontent4 = value; }
            get { return _savesqlcontent4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaveSQLDirectory4 {
            set { _savesqldirectory4 = value; }
            get { return _savesqldirectory4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Guid {
            set { _guid = value; }
            get { return _guid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PluginSpiderUrl {
            set { _pluginspiderurl = value; }
            get { return _pluginspiderurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PluginSpiderContent {
            set { _pluginspidercontent = value; }
            get { return _pluginspidercontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PluginSaveContent {
            set { _pluginsavecontent = value; }
            get { return _pluginsavecontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PluginPublishContent {
            set { _pluginpublishcontent = value; }
            get { return _pluginpublishcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Status {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CollectionContentThreadCount {
            set { _collectioncontentthreadcount = value; }
            get { return _collectioncontentthreadcount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CollectionContentStepTime {
            set { _collectioncontentsteptime = value; }
            get { return _collectioncontentsteptime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PublishContentThreadCount {
            set { _publishcontentthreadcount = value; }
            get { return _publishcontentthreadcount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PublishContentStepTimeMin {
            set { _publishcontentsteptimemin = value; }
            get { return _publishcontentsteptimemin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PublishContentStepTimeMax {
            set { _publishcontentsteptimemax = value; }
            get { return _publishcontentsteptimemax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DemoListUrl {
            set { _demolisturl = value; }
            get { return _demolisturl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsPlan {
            set { _isplan = value; }
            get { return _isplan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PlanFormat {
            set { _planformat = value; }
            get { return _planformat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsSource {
            set { _issource = value; }
            get { return _issource; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SourceText {
            set { _sourcetext = value; }
            get { return _sourcetext; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CollectionUrlStepTime {
            set { _collectionurlsteptime = value; }
            get { return _collectionurlsteptime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateTime {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsHandGetUrl {
            set { _ishandgeturl = value; }
            get { return _ishandgeturl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HandCollectionUrlRegex {
            set { _handcollectionurlregex = value; }
            get { return _handcollectionurlregex; }
        }
        #endregion Model

    }
}
