using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;
using V5_DataPublish._Class;
using ScrapySharp.Extensions;
using V5_Utility.Core;
using V5_WinLibs.Core;

namespace V5_DataPublish.Forms.Desk {
    public partial class frmAutoCreateArticle : V5_DataPublish.BaseForm {
        public frmAutoCreateArticle() {
            InitializeComponent();

            this.dataGridView_List.Dock = DockStyle.Fill;
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            List.Clear();
            string keyword = this.txtContentKeyWord.Text;
            string keywordEncode = HttpUtility.UrlEncode(keyword, Encoding.GetEncoding("utf-8"));
            var i = 1;

            var http = new HttpHelper4();
            var httpResult = http.GetHtml(new HttpItem() {
                URL = "http://wenda.so.com/search/?ie=utf-8&q=" + keywordEncode + "&src=360chrome_search&pn=0"
            });
            var httpHtml = httpResult.Html;

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(httpHtml);
            var node = doc.DocumentNode;
            var css = node.CssSelect(".item");

            foreach (var c in css) {
                if (c != null) {
                    var url = c.CssSelect(".qa-i-hd a").ToArray()[0].Attributes["href"].Value;
                    var title = c.CssSelect(".qa-i-hd a").ToArray()[0].InnerText;
                    var summary = c.CssSelect(".qa-i-bd").ToArray()[0].InnerText;
  
                    List.Add(new ContentHelper() {
                        Url = "http://wenda.so.com" + url,
                        Title = title,
                        Summary = summary
                    });
                }
            }

            this.Bind_DataList();
        }

        List<ContentHelper> List = new List<ContentHelper>();


        private void Bind_DataList() {
            this.dataGridView_List.DataSource = List;
        }

        public class ContentHelper {
            public string Url { get; set; }
            public string Title { get; set; }
            public string Summary { get; set; }
        }

        private void btnSubmitInsert_Click(object sender, EventArgs e) {
            if (Get_DataViewListSelectedItem() != string.Empty) {

            }
            else {

            }
        }


        private string Get_DataViewListSelectedItem() {
            return string.Empty;
        }
    }
}
