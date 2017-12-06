using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace V5_WinControls.DataGrid
{
    public partial class cCopyDataGridView : DataGridView 
    {

        private bool _ctrlDown = false;
        private bool _shiftDown = false;

        public cCopyDataGridView()
        {
            InitializeComponent();
        }

        public cCopyDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_KEYDOWN = 0x0100;
            const int WM_KEYUP = 0x0101;
            const int WM_PASTE = 0x0302;

            const int WM_CONTEXTMENU = 0x007b;
            const int WM_CHAR = 0x0102;      
            const int WM_CUT = 0x0300;       
            const int WM_COPY = 0x0301;      
            const int WM_CLEAR = 0x0303;     
            const int WM_UNDO = 0x0304; 

            bool handledMessage = false;

            switch (m.Msg)
            {
                case WM_KEYDOWN:
                    if ((int)m.WParam == (int)Keys.ControlKey)
                    {
                        _ctrlDown = true;
                        break;
                    }

                    if ((int)m.WParam == (int)Keys.ShiftKey)
                    {
                        _shiftDown = true;
                        break;
                    }

                    if (_ctrlDown && ((int)m.WParam == (int)Keys.V))
                    {
                        if (e_PasteTask != null)
                        {
                            e_PasteTask(this, new PasteTaskEventArgs());
                        }
                    }
                    else if (_ctrlDown && ((int)m.WParam == (int)Keys.C))
                    {
                        if (e_CopyTask != null)
                        {
                            e_CopyTask(this, new CopyTaskEventArgs());
                        }
                    }
                   
                    _ctrlDown = false;
                    _shiftDown = false;
                    break;

                case WM_KEYUP:
                    if ((int)m.WParam == (int)Keys.ControlKey)
                    {
                        _ctrlDown = false;
                    }
                    else if ((int)m.WParam == (int)Keys.ShiftKey)
                    {
                        _shiftDown = false;
                    }
                    break;

                case WM_COPY :
                    if (e_CopyTask != null)
                        e_CopyTask(this, new CopyTaskEventArgs());
                    break;

                case WM_PASTE:
                    if (e_PasteTask != null)
                        e_PasteTask(this, new PasteTaskEventArgs());
                    break;
            }

            if (handledMessage)
            {
                m.Result = new IntPtr(0);
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private event EventHandler<CopyTaskEventArgs> e_CopyTask;
        public event EventHandler<CopyTaskEventArgs> CopyTask
        {
            add { e_CopyTask += value; }
            remove { e_CopyTask -= value; }
        }

        private event EventHandler<PasteTaskEventArgs> e_PasteTask;
        public event EventHandler<PasteTaskEventArgs> PasteTask
        {
            add { e_PasteTask += value; }
            remove { e_PasteTask -= value; }
        }

    }

    public class CopyTaskEventArgs : EventArgs
    {
        public CopyTaskEventArgs()
        {

        }
    }

    public class PasteTaskEventArgs : EventArgs
    {
        public PasteTaskEventArgs()
        {

        }
    }
}
