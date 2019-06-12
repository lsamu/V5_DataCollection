using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using V5_DataCollection._Class.DAL;
using V5_DataCollection._Class.Publish;
using V5_Model;
using V5_WinLibs;
using V5_WinLibs.Core;

namespace V5_DataCollection._Class.Gather
{

    /// <summary>
    /// 任务类型
    /// </summary>
    public enum EnumTaskType {
        /// <summary>
        /// 列表
        /// </summary>
        List,
        /// <summary>
        /// 详细
        /// </summary>
        View,
        /// <summary>
        /// 发布
        /// </summary>
        Publish,
        /// <summary>
        /// 完成
        /// </summary>
        Over
    }

    /// <summary>
    /// 采集管理
    /// </summary>
    public class SpiderHelper {

        #region 访问器变量
        /// <summary>
        /// 是否停止
        /// </summary>
        public bool Stopped { get; set; } = true;
        /// <summary>
        /// 任务索引
        /// </summary>
        public int TaskIndex { get; set; }
        private ModelTask _modelTask = new ModelTask();
        /// <summary>
        /// 任务模型
        /// </summary>
        public ModelTask modelTask {
            get { return _modelTask; }
            set { _modelTask = value; }
        }
        #endregion

        #region 委托变量
        /// <summary>
        /// 采集过程中
        /// </summary>
        public GatherEventHandler.GatherWorkHandler GatherWorkDelegate;
        /// <summary>
        /// 采集完成
        /// </summary>
        public GatherEventHandler.GatherComplateHandler GatherComplateDelegate;
        /// <summary>
        /// 采集进度条
        /// </summary>
        public MainEventHandler.OutPutTaskProgressBarHandler OutPutTaskProgressBarDelegate;
        #endregion

        #region 私有变量
        private GatherEvents.GatherLinkEvents gatherEv = new GatherEvents.GatherLinkEvents();
        private Queue<ModelLinkUrl> _listLinkUrl = new Queue<ModelLinkUrl>();
        private cGatherFunction _gatherWork = new cGatherFunction();

        #endregion

        private void MessageOut(string strMsg) {
            if (GatherWorkDelegate != null) {
                gatherEv.Message = strMsg;
                GatherWorkDelegate(this, gatherEv);
            }
        }

        public delegate void OutTaskStatus(EnumTaskType type);
        public event OutTaskStatus OutTaskStatusHandler;

        #region 入口

        public void Stop() {
            this.Stopped = true;
        }

        public void Start() {

            if (!this.Stopped || modelTask == null) {
                return;
            }

            this.Stopped = false;

            OutTaskStatusHandler = (EnumTaskType type) => {
                switch (type) {
                    case EnumTaskType.List:
                        StartList();
                        break;
                    case EnumTaskType.View:
                        StartView();
                        break;
                    case EnumTaskType.Publish:
                        StartPublish();
                        break;
                    case EnumTaskType.Over:
                        StartOver();
                        break;
                }
            };

            OutTaskStatusHandler?.Invoke(EnumTaskType.List);
        }
        #endregion

        #region 列表
        private void StartList() {

            _listLinkUrl.Clear();

            MessageOut($"[{modelTask.TaskName}]开始采集数据！请稍候...");
           
            var task = new TaskFactory().StartNew(() => {
                //加载为采集的列表
                if (modelTask.IsSpiderUrl == 1) {
                    var spiderList = new SpiderListHelper();
                    spiderList.Model = modelTask;
                    spiderList.OutTreeNodeHandler += (string url, string title, string cover, int nodeIndex) => {
                        var m = new ModelLinkUrl() {
                            Url = url,
                            Title = title,
                            Cover = cover
                        };
                        bool addFlag = true;
                        foreach (var item in _listLinkUrl.ToArray()) {
                            if (item.Url == url) {
                                addFlag = false;
                                break;
                            }
                        }
                        if (addFlag) {
                            string msg = url + "==" + HtmlHelper.Instance.ParseTags(title);
                            if (!DALContentHelper.ChkExistSpiderResult(modelTask.TaskName, url)) {
                                _listLinkUrl.Enqueue(m);
                            }
                            else {
                                msg += "采集地址存在!不需要采集!";
                            }
                            MessageOut(msg);
                        }
                    };
                    spiderList.OutMessageHandler += (string msg) => {
                        MessageOut(msg);
                    };
                    spiderList.AnalyzeAllList();

                    MessageOut("分析获取网页个数为" + _listLinkUrl.Count + "个！");
                    MessageOut("采集网站列表完成!");
                }
                else {
                    MessageOut("采集列表关闭,不需要采集!");
                }
                OutTaskStatusHandler?.Invoke(EnumTaskType.View);
            });

        }
        #endregion

        #region 详细
        private void StartView() {
            var taskList = new TaskFactory().StartNew(() => {
                if (modelTask.IsSpiderContent == 1 && _listLinkUrl.Count > 0) {

                    MessageOut($"开始采集列表地址详细内容!采集间隔{modelTask.CollectionContentStepTime}毫秒");

                    var spiderViewHelper = new SpiderViewHelper();
                    spiderViewHelper.Model = modelTask;
                    spiderViewHelper.OutViewUrlContentHandler += (string content) => {
                        MessageOut(content);
                    };

                    var ProressNum = 0;
                    var TaskCount = _listLinkUrl.Count;

                    while (true) {
                        if (_listLinkUrl.Count == 0) {
                            break;
                        }
                        var mlink = _listLinkUrl.Dequeue();
                        try {
                            #region 进度条

                            ProressNum++;
                            MainEvents.OutPutTaskProgressBarEventArgs ea = new MainEvents.OutPutTaskProgressBarEventArgs();
                            ea.ProgressNum = ProressNum;
                            ea.RecordNum = TaskCount;
                            ea.TaskIndex = TaskIndex;
                            OutPutTaskProgressBarDelegate?.Invoke(this, ea);

                            #endregion
                            spiderViewHelper.SpiderContent(mlink.Url, modelTask.ListTaskLabel);
                            Thread.Sleep(modelTask.CollectionContentStepTime.Value);
                        }
                        catch (Exception ex) {
                            LoggerHelper.Write(V5_WinLibs.LogLevel.Error, ex);
                        }
                    }

                    MessageOut("采集网站Url内容完成！");
                }
                else {
                    MessageOut("采集网站内容选项关闭!或者采集列表的地址为0!不需要采集!");
                }

                OutTaskStatusHandler?.Invoke(EnumTaskType.Publish);
            });
        }
        #endregion

        #region 发布
        private void StartPublish() {
            var taskView = new TaskFactory().StartNew(() => {

                if (modelTask.IsPublishContent!=null&&modelTask.IsPublishContent.Value == 1) {

                    var publich = new PublishContentHelper();
                    publich.Model = modelTask;
                    publich.PublishCompalteDelegate = GatherWorkDelegate;

                    MessageOut("正在开始发布数据!");
                    publich.PublishCompalteDelegate = (object sender, GatherEvents.GatherLinkEvents e) => {
                        MessageOut(e.Message);
                        GatherComplateDelegate?.Invoke(modelTask);
                        this.Stop();
                    };
                    publich.Start();
                }
                else {
                    GatherComplateDelegate(modelTask);
                    MessageOut("发布数据没有开启!不需要发布数据!");
                }

                OutTaskStatusHandler?.Invoke(EnumTaskType.Over);
            });
        }
        #endregion

        #region 完成
        private void StartOver() {
            MessageOut($"[{modelTask.TaskName}] 采集数据完毕!");
            this.Stop();
        }
        #endregion
    }
}
