using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace V5_WinLibs.Utility {
    /// <summary>
    /// 数据推送Helper
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TaskHelper<T> {
        public delegate void OutTaskRunHandler(TaskHelper<T> obj, T model);
        public delegate void OutDataBaseRunHandler(TaskHelper<T> queue);
        /// <summary>
        /// 委托 任务运行
        /// </summary>
        public event OutTaskRunHandler OutTaskRunDelegate;
        /// <summary>
        /// 委托 数据运行
        /// </summary>
        public event OutDataBaseRunHandler OutDataBaseRunDelegate;


        public int BaseStepTime = 10;
        public int BaseBusyStepTime = 100;
        public int DbStepTime = 5;
        public int DbBusyStepTime = 300;
        /// <summary>
        /// 队列保存文件
        /// </summary>
        public string fileToXml = @"config\xml.config";
        //线程是否运行
        private bool isStop = true;
        //多线程个数
        public int ThreadBaseCount = 1;
        //
        public int ThreadDataBaseCount = 1;
        //队列最大个数
        public int MaxQueueNum = 500;

        private Thread[] ths;//多线程
        private Thread[] thsDb;//多线程
        private Queue<T> queue = new Queue<T>();

        //锁对象
        private static object lockObj = new object();

        //启动任务
        public void Start() {
            if (this.isStop) {
                this.isStop = false;
                //加载未完成的数据队列
                this.XmlToList(queue, fileToXml);

                ThreadPool.QueueUserWorkItem(StartBase);
                ThreadPool.QueueUserWorkItem(StartDataBase);
            }
        }

        public void StartBase(object oo) {
            ths = new Thread[ThreadBaseCount];
            for (int i = 0; i < ThreadBaseCount; i++) {
                ths[i] = new Thread(new ParameterizedThreadStart(RunBase));
                ths[i].Start(i);//传入object类型数据
            }
        }

        public void StartDataBase(object oo) {
            thsDb = new Thread[ThreadDataBaseCount];
            for (int i = 0; i < ThreadDataBaseCount; i++) {
                thsDb[i] = new Thread(new ParameterizedThreadStart(RunDataBase));
                thsDb[i].Start(i);//传入object类型数据
            }
        }

        //任务执行 多线程  实际处理数据
        private void RunBase(object args) {
            //do something
            int stepTime = BaseStepTime;
            while (true) {
                //while something
                if (this.isStop) {
                    break;
                }
                T model = default(T);
                lock (lockObj) {
                    if (queue.Count > 0) {
                        model = queue.Dequeue();
                        stepTime = BaseStepTime;
                    }
                    else {
                        stepTime = BaseBusyStepTime;
                    }
                }

                if (model != null) {
                    if (OutTaskRunDelegate != null) {
                        OutTaskRunDelegate(this, model);
                    }
                }

                Thread.Sleep(stepTime);
            }
        }
        //停止任务
        public void Stop() {
            this.isStop = true;
            this.UnDoneToXml(queue, fileToXml);
            return;
            if (ths != null) {
                for (int i = 0; i < ThreadBaseCount; i++) {
                    ths[i].Abort();
                }
            }

            if (thsDb != null) {
                for (int i = 0; i < ThreadDataBaseCount; i++) {
                    thsDb[i].Abort();
                }
            }
        }
        //单线程 用于取数据库数据
        private void RunDataBase(object args) {
            int stepTime = DbStepTime;
            while (true) {
                if (this.isStop) {
                    break;
                }
                if (queue.Count > MaxQueueNum) {
                    stepTime = DbBusyStepTime;
                }
                else {
                    //进入队列  先进先出
                    if (OutDataBaseRunDelegate != null) {
                        OutDataBaseRunDelegate(this);
                    }
                    stepTime = DbStepTime;
                }
                Thread.Sleep(stepTime);
            }
        }

        #region
        /// <summary>
        /// 进入队列
        /// </summary>
        /// <param name="t"></param>
        public void InsertQueue(T t) {
            lock (lockObj) 
            {
                queue.Enqueue(t);
            }
        }

        /// <summary>
        /// 获取内存个数
        /// </summary>
        /// <returns></returns>
        public int GetMemoryCount() {
            lock (lockObj) {
                return queue.Count;
            }
        }

        /// <summary>
        /// 加载存在数据队列
        /// </summary>
        /// <param name="queue"></param>
        /// <param name="xmlPath"></param>
        private void XmlToList(Queue<T> queue, string xmlPath) {
            List<T> listBuf = new List<T>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            try {
                string apppath = AppDomain.CurrentDomain.BaseDirectory;
                string fileName = apppath + xmlPath;

                if (!File.Exists(fileName)) {
                    return;
                }

                FileStream fs = new FileStream(fileName, FileMode.Open);
                listBuf = (List<T>)serializer.Deserialize(fs);
                fs.Close();
                foreach (T mt in listBuf) {
                    lock (lockObj) {
                        queue.Enqueue(mt);
                    }
                }
                listBuf.Clear();
                //清空数据
                Queue<T> queueNull = new Queue<T>();
                UnDoneToXml(queueNull, xmlPath);
            }
            catch {

            }
        }
        /// <summary>
        /// 保存未完成的数据队列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ListBuf"></param>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        private bool UnDoneToXml(Queue<T> queue, string xmlPath) {
            try {
                List<T> ListBuf = queue.ToList();
                string apppath = AppDomain.CurrentDomain.BaseDirectory;
                string fileName = apppath + xmlPath;

                var fileInfo = new FileInfo(fileName);

                if (!Directory.Exists(fileInfo.DirectoryName)) {
                    Directory.CreateDirectory(fileInfo.DirectoryName);

                }

                if (!File.Exists(fileName)) {
                    using (var sw = new StreamWriter(fileName, false, Encoding.UTF8)) {
                        sw.Write("");
                        sw.Flush();
                        sw.Close();
                    }
                }

                lock (lockObj) {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    FileStream fs = new FileStream(fileName, FileMode.Create);
                    serializer.Serialize(fs, ListBuf);
                    fs.Close();
                }
                return true;
            }
            catch {
            }
            return false;
        }
        #endregion
    }
}
