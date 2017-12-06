using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace V5_DataCollection._Class.WebPublishModule {
    /// <summary>
    /// 网站发布模块
    /// </summary>
    public class cWebPublishModule {
        private ModelWebPublishModule model = new ModelWebPublishModule();
        private string _LoginCookies = string.Empty;
        /// <summary>
        /// Cookies
        /// </summary>
        public string LoginCookies {
            get { return _LoginCookies; }
            set { _LoginCookies = value; }
        }

        public cWebPublishModule(ModelWebPublishModule _model) {
            model = _model;
        }

        ~cWebPublishModule() {
            model = null;
        }
        /// <summary>
        /// 获取最基本的Cookies
        /// </summary>
        public void GetBaseCookie(string url) {
            try {
                Uri myUri = new Uri(url);
                WebRequest webRequest = WebRequest.Create(myUri);
                WebResponse webResponse = webRequest.GetResponse();
                LoginCookies = webResponse.Headers["Set-Cookie"];
            }
            catch (Exception) {

            }
        }
        /// <summary>
        /// 验证码窗口
        /// </summary>
        public void LoginVerCodeWindow() {

        }
        /// <summary>
        /// 登录网站
        /// </summary>
        public void LoginCMS() {

        }
        /// <summary>
        /// 分类列表
        /// </summary>
        public void GetClassList() {
        }
        /// <summary>
        /// 发送内容
        /// </summary>
        public void GetView() {

        }
    }
}
