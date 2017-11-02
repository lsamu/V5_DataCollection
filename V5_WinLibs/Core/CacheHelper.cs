using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Collections;

namespace V5_Utility.Core {
    /// <summary>
    /// 缓存操作类
    /// </summary>
    public class CacheHelper {
        private static readonly CacheHelper m_Instance = new CacheHelper();
        /// <summary>
        /// 
        /// </summary>
        public static CacheHelper Instance {
            get { return m_Instance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public CacheHelper() {

        }
        /// <summary>
        /// 获取当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <returns></returns>
        public object GetCache(string CacheKey) {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            return objCache[CacheKey];
        }

        /// <summary>
        /// 设置当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <param name="objObject"></param>
        public void SetCache(string CacheKey, object objObject) {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, objObject);
        }

        /// <summary>
        /// 设置当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <param name="objObject"></param>
        /// <param name="Timeout"></param>
        public void SetCache(string CacheKey, object objObject, TimeSpan Timeout) {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, objObject, null, DateTime.MaxValue, Timeout, System.Web.Caching.CacheItemPriority.NotRemovable, null);
        }

        /// <summary>
        /// 设置当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <param name="objObject"></param>
        /// <param name="absoluteExpiration"></param>
        /// <param name="slidingExpiration"></param>
        public void SetCache(string CacheKey, object objObject, DateTime absoluteExpiration, TimeSpan slidingExpiration) {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, objObject, null, absoluteExpiration, slidingExpiration);
        }

        /// <summary>
        /// 移除当前应用程序所有的的缓存值
        /// </summary>
        public void RemoveAllCache() {
            System.Web.Caching.Cache _cache = HttpRuntime.Cache;
            IDictionaryEnumerator CacheEnum = _cache.GetEnumerator();
            ArrayList al = new ArrayList();
            while (CacheEnum.MoveNext()) {
                al.Add(CacheEnum.Key);
            }
            foreach (string key in al) {
                _cache.Remove(key);
            }
        }


        /// <summary>
        /// 移除当前应用程序中指定的缓存值
        /// </summary>
        /// <param name="CacheKey"></param>
        public void RemoveCache(string CacheKey) {
            System.Web.Caching.Cache _cache = HttpRuntime.Cache;
            _cache.Remove(CacheKey);
        }

        /// <summary>
        /// 获取所有的缓存项
        /// </summary>
        /// <returns></returns>
        public ArrayList GetAllCacheItems() {
            System.Web.Caching.Cache _cache = HttpRuntime.Cache;
            IDictionaryEnumerator CacheEnum = _cache.GetEnumerator();
            ArrayList al = new ArrayList();
            while (CacheEnum.MoveNext()) {
                al.Add(CacheEnum.Key);
            }
            return al;
        }

        /// <summary>
        /// 检查缓存是否存在
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <returns></returns>
        public bool Contains(string CacheKey) {
            System.Web.Caching.Cache _cache = HttpRuntime.Cache;
            if (_cache.Get(CacheKey) != null) {
                return true;
            }
            return false;
        }
    }
}
