using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_WinControls
{
    public class V5TabControl : TabControl
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Tab | Keys.Control):
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
       
       
    }
}
