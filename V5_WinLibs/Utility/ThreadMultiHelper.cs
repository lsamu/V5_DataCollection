using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace V5_WinLibs.Utility {
    /// <summary>
    /// 多线程封装
    /// </summary>
    public class ThreadMultiHelper {
        #region 变量

        public delegate void DelegateComplete();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskindex">任务索引</param>
        /// <param name="threadindex">线程索引</param>
        public delegate void DelegateWork(int taskindex, int threadindex);
        /// <summary>
        /// 任务完成委托
        /// </summary>
        public event DelegateComplete CompleteEvent;
        /// <summary>
        /// 任务运行中委托
        /// </summary>
        public event DelegateWork WorkMethod;

        private Thread[] _threads;
        private bool[] _threadState;
        private int _taskCount = 0;//任务个数
        private int _taskindex = 0;//任务索引
        private int _threadCount = 5;//默认线程数

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="taskcount">任务个数</param>
        public ThreadMultiHelper(int taskcount) {
            _taskCount = taskcount;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="taskcount">任务个数</param>
        /// <param name="threadCount">线程个数</param>
        public ThreadMultiHelper(int taskcount, int threadCount) {
            _taskCount = taskcount;
            _threadCount = threadCount;
        }

        #region 获取任务
        /// <summary>
        /// 获取任务
        /// </summary>
        /// <returns></returns>
        private int GetTask() {
            lock (this) {
                if (_taskindex < _taskCount) {
                    _taskindex++;
                    return _taskindex;
                }
                else {
                    return 0;
                }
            }
        }
        #endregion

        #region Start

        /// <summary>
        /// 启动任务
        /// </summary>
        public void Start() {
            _taskindex = 0;
            int num = _taskCount < _threadCount ? _taskCount : _threadCount;
            _threadState = new bool[num];
            _threads = new Thread[num];

            for (int n = 0; n < num; n++) {
                _threadState[n] = false;
                _threads[n] = new Thread(new ParameterizedThreadStart(Work));
                _threads[n].Start(n);
            }
        }

        /// <summary>
        /// 结束线程
        /// </summary>
        public void Stop() {
            for (int i = 0; i < _threads.Length; i++) {
                _threads[i].Abort();
            }
        }
        #endregion

        #region Work
        /// <summary>
        /// 任务运行
        /// </summary>
        /// <param name="arg"></param>
        private void Work(object arg) {
            //提取任务并执行
            int threadindex = int.Parse(arg.ToString());
            int taskindex = GetTask();

            while (taskindex != 0 && WorkMethod != null) {
                WorkMethod(taskindex, threadindex + 1);
                taskindex = GetTask();
            }
            //所有的任务执行完毕
            _threadState[threadindex] = true;

            //处理并发 如果有两个线程同时完成只允许一个触发complete事件
            lock (this) {
                for (int i = 0; i < _threadState.Length; i++) {
                    if (_threadState[i] == false) {
                        return;
                    }
                }
                //如果全部完成
                if (CompleteEvent != null) {
                    CompleteEvent();
                }

                //触发complete事件后 重置线程状态
                //为了下个同时完成的线程不能通过上面的判断
                for (int j = 0; j < _threadState.Length; j++) {
                    _threadState[j] = false;
                }
            }

        }

        #endregion
    }
}
