using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataCollection._Class.WebPublishModule
{
    /// <summary>
    /// 发布模块
    /// </summary>
    [Serializable]
    public class ModelWebPublishModule
    {
        string _ModuleName = string.Empty;
        string _DemoSiteUrl = string.Empty;
        string _PageEncode = string.Empty;
        //
        string _LoginUrl = string.Empty;
        string _LoginRefUrl = string.Empty;
        string _LoginVerCodeUrl = string.Empty;
        string _LoginPostData = string.Empty;
        string _LoginErrorResult = string.Empty;
        string _LoginSuccessResult = string.Empty;
        //
        string _ListUrl = string.Empty;
        string _ListRefUrl = string.Empty;
        string _ListStartCut = string.Empty;
        string _ListEndCut = string.Empty;
        string _ListClassIDRegex = string.Empty;
        //
        string _ViewUrl = string.Empty;
        string _ViewRefUrl = string.Empty;
        string _ViewPostData = string.Empty;
        string _ViewErrorResult = string.Empty;
        string _ViewSuccessResult = string.Empty;
        //
        string _ModuleReadMe = string.Empty;
        //
        /// <summary>
        /// 模块名称
        /// </summary>
        public string ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
        }
        /// <summary>
        /// 测试站点
        /// </summary>
        public string DemoSiteUrl
        {
            get { return _DemoSiteUrl; }
            set { _DemoSiteUrl = value; }
        }
        /// <summary>
        /// 页面编码
        /// </summary>
        public string PageEncode
        {
            get { return _PageEncode; }
            set { _PageEncode = value; }
        }
        /// <summary>
        /// 登录地址
        /// </summary>
        public string LoginUrl
        {
            get { return _LoginUrl; }
            set { _LoginUrl = value; }
        }
        /// <summary>
        /// 登录来源地址
        /// </summary>
        public string LoginRefUrl
        {
            get { return _LoginRefUrl; }
            set { _LoginRefUrl = value; }
        }
        /// <summary>
        /// 验证码地址
        /// </summary>
        public string LoginVerCodeUrl
        {
            get { return _LoginVerCodeUrl; }
            set { _LoginVerCodeUrl = value; }
        }
        /// <summary>
        /// 登录Post数据
        /// </summary>
        public string LoginPostData
        {
            get { return _LoginPostData; }
            set { _LoginPostData = value; }
        }
        /// <summary>
        /// 登录错误
        /// </summary>
        public string LoginErrorResult
        {
            get { return _LoginErrorResult; }
            set { _LoginErrorResult = value; }
        }
        /// <summary>
        /// 登录成功
        /// </summary>
        public string LoginSuccessResult
        {
            get { return _LoginSuccessResult; }
            set { _LoginSuccessResult = value; }
        }
        /// <summary>
        /// 列表地址
        /// </summary>
        public string ListUrl
        {
            get { return _ListUrl; }
            set { _ListUrl = value; }
        }
        /// <summary>
        /// 列表来源
        /// </summary>
        public string ListRefUrl
        {
            get { return _ListRefUrl; }
            set { _ListRefUrl = value; }
        }
        /// <summary>
        /// 列表开始截取字符
        /// </summary>
        public string ListStartCut
        {
            get { return _ListStartCut; }
            set { _ListStartCut = value; }
        }
        /// <summary>
        /// 列表结束截取字符
        /// </summary>
        public string ListEndCut
        {
            get { return _ListEndCut; }
            set { _ListEndCut = value; }
        }
        /// <summary>
        /// 分类ID和分类名称
        /// </summary>
        public string ListClassIDRegex
        {
            get { return _ListClassIDRegex; }
            set { _ListClassIDRegex = value; }
        }
        /// <summary>
        /// 发布地址
        /// </summary>
        public string ViewUrl
        {
            get { return _ViewUrl; }
            set { _ViewUrl = value; }
        }
        /// <summary>
        /// 发布来源
        /// </summary>
        public string ViewRefUrl
        {
            get { return _ViewRefUrl; }
            set { _ViewRefUrl = value; }
        }
        /// <summary>
        /// 发布Post数据
        /// </summary>
        public string ViewPostData
        {
            get { return _ViewPostData; }
            set { _ViewPostData = value; }
        }
        /// <summary>
        /// 发布错误
        /// </summary>
        public string ViewErrorResult
        {
            get { return _ViewErrorResult; }
            set { _ViewErrorResult = value; }
        }
        /// <summary>
        /// 发布成功
        /// </summary>
        public string ViewSuccessResult
        {
            get { return _ViewSuccessResult; }
            set { _ViewSuccessResult = value; }
        }
        /// <summary>
        /// 模块说明
        /// </summary>
        public string ModuleReadMe
        {
            get { return _ModuleReadMe; }
            set { _ModuleReadMe = value; }
        }
    }
}
