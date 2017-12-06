using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlDatabase.Core;

namespace V5_DataPublish._Class {
    public class Common {

        private static string baseDir = AppDomain.CurrentDomain.BaseDirectory + "System\\DB\\";

        public enum Option {
            add = 1,
            edit = 2,
            del = 3
        }
        /// <summary>
        /// 数据库链接字符串
        /// </summary>
        public static string DbString = "System\\V5.DataPublish.db3";
        public static string SettingsFile = "System\\V5.DataPublish.Settings.ini";
        public static string V5DataPublish = "System\\V5.DataPublish.ini";

        /// <summary>
        /// 更新 添加
        /// </summary>
        public static bool Update<TSource>(TSource t) {
            using (XDatabase db = XDatabase.Open(baseDir)) {
                db.Store(t);
                return true;
            }
            return false;
        }
        /// <summary>
        /// 数据获取
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static List<TSource> GetList<TSource>(Func<TSource, bool> predicate) {
            List<TSource> list = new List<TSource>();
            using (XDatabase db = XDatabase.Open(baseDir)) {
                var query = db.Query<TSource>();
                if (query != null) {
                    list = query.Where<TSource>(predicate).ToList();
                }
            }
            return list;
        }

        public static bool Delete<TSource>(TSource t) {
            using (XDatabase db = XDatabase.Open(baseDir)) {
                var query = db.Query<TSource>();
                if (query != null) {
                    db.Delete(t);
                    return true;
                }
            }
            return false;
        }

        public static bool Delete<TSource>(Func<TSource, bool> predicate) {
            using (XDatabase db = XDatabase.Open(baseDir)) {
                var query = db.Query<TSource>();
                if (query != null) {
                    var model = query.Where<TSource>(predicate).SingleOrDefault();
                    db.Delete(model);
                    return true;
                }
            }
            return false;
        }
    }
}
