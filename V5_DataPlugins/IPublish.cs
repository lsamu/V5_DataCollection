using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_DataPlugins.Model;

namespace V5_DataPlugins {
    /// <summary>
    /// 发布类型
    /// </summary>
    public enum PublishType {
        Login,
        GetClassList,
        CreateClass,
        PostData,
        UploadFile,
        CreateHtml,
        LoginOver,
        GetClassListOver,
        CreateClassOver,
        PostDataOver,
        UploadFileOver,
        CreateHtmlOver
    }
    /// <summary>
    /// 生成静态类型
    /// </summary>
    public enum CreateHtmlType {
        Index,
        ClassList,
        View
    }
    /// <summary>
    /// 发布接口
    /// </summary>
    public interface IPublish {
        /// <summary>
        /// 操作类型
        /// </summary>
        PublishType Publish_Type { set; get; }
        /// <summary>
        /// 网站编码
        /// </summary>
        string Publish_Encode { set; get; }
        /// <summary>
        /// 回发对象
        /// </summary>
        PluginEventHandler.OutPutResult Publish_OutResult { set; }
        /// <summary>
        /// WebBrowser对象
        /// </summary>
        WebBrowser Publish_WebBrowser { set; }
        /// <summary>
        /// 插件名称说明
        /// </summary>
        string Publish_Name { set; get; }
        /// <summary>
        /// 网站对象
        /// </summary>
        ModelPublishModuleItem Publish_Model { get; set; }
        /// <summary>
        /// 初始化信息
        /// </summary>
        void Publish_Init(string strSiteUrl, string strLoginDir, string strUserName, string strUserPwd, int isCookie, string strCookie);
        /// <summary>
        /// 后台登陆地址
        /// </summary>
        string Publish_GetLoginAdminUrl(string strSiteUrl, string strLoginDir);
        /// <summary>
        /// 网站后台登录
        /// </summary>
        void Publish_Login();
        /// <summary>
        /// 网站后台创建分类
        /// </summary>
        void Publish_CreateClass(string strClassName);
        /// <summary>
        /// 网站后台获取分类列表
        /// </summary>
        void Publish_GetClassList();
        /// <summary>
        /// 网站后台发布数据
        /// </summary>
        void Publish_PostData(ModelGatherItem mlistPost, ModelClassItem mClassList);
    }
}
