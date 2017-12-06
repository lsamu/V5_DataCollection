
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Caching;
namespace V5_WinLibs.Core {
    /// <summary>
    /// 全局缓存类
    /// </summary>
    /// <example><code>
    /// 使用示例：
    /// 实例化： CacheManage cache=CacheManage.Instance;
    /// 添加：   cache.Add("123",new MDataTable);
    /// 判断：   if(cache.Contains("123"))
    ///          {
    /// 获取：       MDataTable table=cache.Get("123") as MDataTable;
    ///          }
    /// </code></example>
    public class CacheManageHelper {
        private readonly System.Web.HttpContext H = new System.Web.HttpContext(new System.Web.HttpRequest("Null.File", "http://cyq1162.cnblogs.com", String.Empty), new System.Web.HttpResponse(null));
        private System.Web.Caching.Cache theCache = null;
        private Dictionary<string, CacheDependencyInfo> cacheState = new Dictionary<string, CacheDependencyInfo>();
        private CacheManageHelper() {
            theCache = H.Cache;
        }
        /// <summary>
        /// 获和缓存总数
        /// </summary>
        public int Count {
            get {
                return theCache == null ? 0 : theCache.Count;
            }
        }
        /// <summary>
        /// 返回唯一实例
        /// </summary>
        public static CacheManageHelper Instance {
            get {
                return Shell.instance;
            }
        }

        class Shell {
            internal static readonly CacheManageHelper instance = new CacheManageHelper();
        }

        /// <summary>
        /// 获得一个Cache对象
        /// </summary>
        /// <param name="key">标识</param>
        /// <returns></returns>
        public object Get(string key) {
            if (Contains(key)) {
                return theCache[key];
            }
            return null;
        }
        /// <summary>
        /// 是否存在缓存
        /// </summary>
        /// <param name="key">标识</param>
        /// <returns></returns>
        public bool Contains(string key) {
            return theCache != null && theCache[key] != null;
        }
        /// <summary>
        /// 添加一个Cache对象
        /// </summary>
        /// <param name="key">标识</param>
        /// <param name="value">对象值</param>
        public void Add(string key, object value) {
            Add(key, value, null);
        }
        public void Add(string key, object value, string filePath) {
            if (!Contains(key)) {
                Add(key, value, filePath, 0);
            }
        }
        public void Add(string key, object value, string filePath, int cacheTimeMinutes) {
            if (!Contains(key)) {
                Insert(key, value, filePath, cacheTimeMinutes);
            }
        }
        /// <summary>
        /// 相对底层Cache添加方法,添加一个Cache请用Add方法
        /// </summary>
        /// <param name="key">标识</param>
        /// <param name="value">对象值</param>
        /// <param name="filePath">文件依赖路径</param>
        private void Insert(string key, object value, string filePath, int cacheTimeMinutes) {
            CacheDependency theCacheDependency = null;
            if (!string.IsNullOrEmpty(filePath)) {
                theCacheDependency = new CacheDependency(filePath);
            }
            int cacheTime = cacheTimeMinutes;
            if (cacheTimeMinutes == 0) {
                cacheTime = 1000;
            }
            theCache.Insert(key, value, theCacheDependency, DateTime.Now.AddMinutes(cacheTime == 0 ? 20 : cacheTime), TimeSpan.Zero, CacheItemPriority.Default, null);
            if (cacheState.ContainsKey(key)) {
                cacheState.Remove(key);
            }
            CacheDependencyInfo info = new CacheDependencyInfo(theCacheDependency);
            cacheState.Add(key, info);
        }

        /// <summary>
        /// 删除一个Cache对象
        /// </summary>
        /// <param name="key">标识</param>
        public void Remove(string key) {
            if (Contains(key)) {
                theCache.Remove(key);
                cacheState.Remove(key);
            }
        }

        /// <summary>
        /// 用户手动设置缓存对象已更改
        /// </summary>
        /// <param name="key"></param>
        /// <param name="change"></param>
        public void SetChange(string key, bool change) {
            if (cacheState.ContainsKey(key) && Contains(key)) {
                CacheDependencyInfo info = cacheState[key];
                if (info != null) {
                    info.UserSetChange(change);
                }
            }
        }
        /// <summary>
        /// 获取缓存对象是否已更改
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool GetHasChanged(string key) {
            if (cacheState.ContainsKey(key) && Contains(key)) {
                CacheDependencyInfo info = cacheState[key];
                if (info != null) {
                    return info.IsChanged ? false : info.UserChange;
                }
            }
            return false;
        }
    }
    /// <summary>
    /// 缓存依赖信息
    /// </summary>
    internal class CacheDependencyInfo {
        public CacheDependencyInfo(CacheDependency dependency) {
            if (dependency != null) {
                FileDependency = dependency;
                CacheChangeTime = FileDependency.UtcLastModified;
            }
        }
        /// <summary>
        /// 系统文件依赖是否发生改变
        /// </summary>
        public bool IsChanged {
            get {
                if (FileDependency != null && (FileDependency.HasChanged || CacheChangeTime != FileDependency.UtcLastModified)) {
                    CacheChangeTime = FileDependency.UtcLastModified;
                    return true;
                }
                return false;
            }
        }
        CacheDependency FileDependency = null;
        public bool UserChange = false;
        DateTime CacheChangeTime = DateTime.MinValue;
        public void UserSetChange(bool change) {
            UserChange = IsChanged ? false : change;
        }
    }
}
