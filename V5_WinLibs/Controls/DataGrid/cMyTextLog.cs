using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms ;

///功能：自定义文本控件，主要用于采集任务日志的显示
namespace V5_WinControls.DataGrid
{
    class cMyTextLog : RichTextBox 
    {
        public cMyTextLog()
        {
            this.Text = "";
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                string strT = value;

                if (strT.Length > 0)
                {
                    try
                    {
                        int infoType = int.Parse(strT.Substring(0, 4));
                        strT = strT.Substring(4, strT.Length - 4);
                        base.AppendText(strT );
                        base.SelectionStart = int.MaxValue; 
                        base.ScrollToCaret();

                        
                    }
                    catch (System.Exception)
                    {
                        base.Text = value + base.Text;
                    }
                }
                
            }
        }

       
    }
}
