using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using V5_DataCollection._Class.Common;
using V5_DataCollection._Class.DAL;
using V5_DataCollection._Class.Gather;
using V5_Model;

namespace V5_DataCollection._Class.Plan {
    public class JobDetailHelper : IJob {
        DALTask dal = new DALTask();
        public void Execute(IJobExecutionContext context) {
            var k = context.JobDetail.Key;
            var j = context.JobDetail.JobDataMap.SingleOrDefault(p => p.Key == k.Name).Value as ModelTask;

            Console.WriteLine(context.JobDetail.Key.Name + "::::" + j.ID + "::::" + j.TaskName);

            var model = dal.GetModelSingleTask(j.ID);
            SpiderHelper Spider = new SpiderHelper();
            Spider.modelTask = model;
            Spider.GatherWorkDelegate = (object sender, GatherEvents.GatherLinkEvents e) => {
                CommonHelper.FormMain.OutPutWindowBox(this, new MainEvents.OutPutWindowEventArgs() {
                    Message = e.Message
                });
            };
            Console.WriteLine("采集任务开始!");
            Spider.Start();

        }
    }
}
