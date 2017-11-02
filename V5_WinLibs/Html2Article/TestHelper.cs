using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace V5_WinLibs.Html2Article {
    public class TestHelper {

        public void Test1() {

            var html = "";

            Html2Article.AppendMode = false;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Article article = Html2Article.GetArticle(html);
            sw.Stop();

            StringBuilder sbContent = new StringBuilder();
            sbContent.AppendLine("提取耗时：" + Environment.NewLine + sw.ElapsedMilliseconds + "毫秒");
            sbContent.AppendLine(article.PublishDate.ToString());
            sbContent.AppendLine(article.Title);
            sbContent.AppendLine(article.Content);
            sbContent.AppendLine("内容:");
            sbContent.AppendLine(UrlUtility.FixUrl("#", article.ContentWithTags));


        }
    }
}
