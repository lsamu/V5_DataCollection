using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPlugins.Model {
    /// <summary>
    /// 发布模块实体类
    /// </summary>
    [Serializable]
    public class ModelPublishModuleItem {
        #region Base
        string _PublishModuleName = string.Empty;
        /// <summary>
        /// 模块名称
        /// </summary>
        public string PublishModuleName {
            get { return _PublishModuleName; }
            set { _PublishModuleName = value; }
        }
        string _PageEncode = string.Empty;
        /// <summary>
        /// 页面编码
        /// </summary>
        public string PageEncode {
            get { return _PageEncode; }
            set { _PageEncode = value; }
        }
        string _ModuleReadMe = string.Empty;
        /// <summary>
        /// 模块说明
        /// </summary>
        public string ModuleReadMe {
            get { return _ModuleReadMe; }
            set { _ModuleReadMe = value; }
        }
        #endregion

        #region 登陆
        string _LoginUrl = string.Empty;
        /// <summary>
        /// 登陆地址
        /// </summary>
        public string LoginUrl {
            get { return _LoginUrl; }
            set { _LoginUrl = value; }
        }
        string _LoginChkrl = string.Empty;
        /// <summary>
        /// 登陆验证地址
        /// </summary>
        public string LoginChkrl {
            get { return _LoginChkrl; }
            set { _LoginChkrl = value; }
        }
        string _LoginRefUrl = string.Empty;
        /// <summary>
        /// 登陆来源地址
        /// </summary>
        public string LoginRefUrl {
            get { return _LoginRefUrl; }
            set { _LoginRefUrl = value; }
        }
        string _LoginVerCodeUrl = string.Empty;
        /// <summary>
        /// 登陆验证码地址
        /// </summary>
        public string LoginVerCodeUrl {
            get { return _LoginVerCodeUrl; }
            set { _LoginVerCodeUrl = value; }
        }
        string _LoginPostData = string.Empty;
        /// <summary>
        /// 登陆Post数据
        /// </summary>
        public string LoginPostData {
            get { return _LoginPostData; }
            set { _LoginPostData = value; }
        }
        string _LoginErrorResult = string.Empty;
        /// <summary>
        /// 登陆错误值
        /// </summary>
        public string LoginErrorResult {
            get { return _LoginErrorResult; }
            set { _LoginErrorResult = value; }
        }
        string _LoginSuccessResult = string.Empty;
        /// <summary>
        /// 登陆成功值
        /// </summary>
        public string LoginSuccessResult {
            get { return _LoginSuccessResult; }
            set { _LoginSuccessResult = value; }
        }
        #endregion

        #region 分类列表
        string _ListUrl = string.Empty;
        /// <summary>
        /// 列表地址
        /// </summary>
        public string ListUrl {
            get { return _ListUrl; }
            set { _ListUrl = value; }
        }
        string _ListRefUrl = string.Empty;
        /// <summary>
        /// 列表来源
        /// </summary>
        public string ListRefUrl {
            get { return _ListRefUrl; }
            set { _ListRefUrl = value; }
        }
        string _ListStartCut = string.Empty;
        /// <summary>
        /// 列表截取开始
        /// </summary>
        public string ListStartCut {
            get { return _ListStartCut; }
            set { _ListStartCut = value; }
        }
        string _ListEndCut = string.Empty;
        /// <summary>
        /// 列表截取结束
        /// </summary>
        public string ListEndCut {
            get { return _ListEndCut; }
            set { _ListEndCut = value; }
        }
        string _ListClassIDNameRegex = string.Empty;
        /// <summary>
        /// 分类ID和名称表达式
        /// </summary>
        public string ListClassIDNameRegex {
            get { return _ListClassIDNameRegex; }
            set { _ListClassIDNameRegex = value; }
        }
        string _ListCreateUrl = string.Empty;
        /// <summary>
        /// 分类创建地址
        /// </summary>
        public string ListCreateUrl {
            get { return _ListCreateUrl; }
            set { _ListCreateUrl = value; }
        }
        string _ListCreateRefUrl = string.Empty;
        /// <summary>
        /// 分类创建地址来源
        /// </summary>
        public string ListCreateRefUrl {
            get { return _ListCreateRefUrl; }
            set { _ListCreateRefUrl = value; }
        }
        string _ListCreatePostData = string.Empty;
        /// <summary>
        /// 分类创建Post数据
        /// </summary>
        public string ListCreatePostData {
            get { return _ListCreatePostData; }
            set { _ListCreatePostData = value; }
        }
        string _ListCreateSuccess = string.Empty;
        /// <summary>
        /// 创建成功标示
        /// </summary>
        public string ListCreateSuccess {
            get { return _ListCreateSuccess; }
            set { _ListCreateSuccess = value; }
        }
        string _ListCreateError = string.Empty;
        /// <summary>
        /// 创建失败标示
        /// </summary>
        public string ListCreateError {
            get { return _ListCreateError; }
            set { _ListCreateError = value; }
        }
        #endregion

        #region 发布内容
        string _ContentUrl = string.Empty;
        /// <summary>
        /// 发布内容地址
        /// </summary>
        public string ContentUrl {
            get { return _ContentUrl; }
            set { _ContentUrl = value; }
        }
        string _ContentRefUrl = string.Empty;
        /// <summary>
        /// 发布内容来源
        /// </summary>
        public string ContentRefUrl {
            get { return _ContentRefUrl; }
            set { _ContentRefUrl = value; }
        }
        string _ContentPostData = string.Empty;
        /// <summary>
        /// 发布内容Post参数
        /// </summary>
        public string ContentPostData {
            get { return _ContentPostData; }
            set { _ContentPostData = value; }
        }
        string _ContentErrorResult = string.Empty;
        /// <summary>
        /// 发布内容结果错误标示
        /// </summary>
        public string ContentErrorResult {
            get { return _ContentErrorResult; }
            set { _ContentErrorResult = value; }
        }
        string _ContentSuccessResult = string.Empty;
        /// <summary>
        /// 发布内容结果成功标示
        /// </summary>
        public string ContentSuccessResult {
            get { return _ContentSuccessResult; }
            set { _ContentSuccessResult = value; }
        }
        #endregion

        #region 上传
        string _UploadUrl = string.Empty;
        /// <summary>
        /// 上传地址
        /// </summary>
        public string UploadUrl {
            get { return _UploadUrl; }
            set { _UploadUrl = value; }
        }
        string _UploadRefUrl = string.Empty;
        /// <summary>
        /// 上传地址来源
        /// </summary>
        public string UploadRefUrl {
            get { return _UploadRefUrl; }
            set { _UploadRefUrl = value; }
        }
        string _UploadPostData = string.Empty;
        /// <summary>
        /// 上传地址Post参数
        /// </summary>
        public string UploadPostData {
            get { return _UploadPostData; }
            set { _UploadPostData = value; }
        }
        #endregion

        #region 随机值
        List<ModelRandom> _ListRandomModel = new List<ModelRandom>();
        /// <summary>
        /// 随机值
        /// </summary>
        public List<ModelRandom> ListRandomModel {
            get { return _ListRandomModel; }
            set { _ListRandomModel = value; }
        }
        #endregion

        #region 静态
        List<ModelCreateHtml> _ListCreateHtmlModel = new List<ModelCreateHtml>();
        /// <summary>
        /// 生成静态
        /// </summary>
        public List<ModelCreateHtml> ListCreateHtmlModel {
            get { return _ListCreateHtmlModel; }
            set { _ListCreateHtmlModel = value; }
        }
        #endregion

    }
}
