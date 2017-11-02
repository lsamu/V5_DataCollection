using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text.RegularExpressions;
using V5_WinControls._Class.V5RichTextBox;

namespace V5_WinControls
{
    /// <summary>
    /// RichTextBoxEx is derived from RichTextBox and supports XP Visual Styles.
    /// </summary>
    public class V5RichTextBox : RichTextBox
    {
        /// <summary>
        /// Contains the size of the visual style borders
        /// </summary>
        NativeMethods.RECT borderRect;

        ContextMenu cm1 = new ContextMenu();
        public V5RichTextBox()
            : base()
        {
            MenuItem miUndo = new MenuItem();
            miUndo.Name = "Undo";
            miUndo.Click += new EventHandler(Undo_Click);
            miUndo.Text = "³·Ïú";
            cm1.MenuItems.Add(miUndo);

            MenuItem miLine = new MenuItem();
            miLine.Name = "Line";
            miLine.Text = "-";
            cm1.MenuItems.Add(miLine);

            MenuItem miCopy = new MenuItem();
            miCopy.Name = "Copy";
            miCopy.Click += new EventHandler(miCopy_Click);
            miCopy.Text = "¸´ÖÆ";
            cm1.MenuItems.Add(miCopy);

            MenuItem miPaste = new MenuItem();
            miPaste.Name = "Paste";
            miPaste.Click += new EventHandler(Paste_Click);
            miPaste.Text = "Õ³Ìù";
            cm1.MenuItems.Add(miPaste);

            MenuItem miCut = new MenuItem();
            miCut.Name = "Cut";
            miCut.Click += new EventHandler(Cut_Click);
            miCut.Text = "¼ôÇÐ";
            cm1.MenuItems.Add(miCut);

            MenuItem miDel = new MenuItem();
            miDel.Name = "Del";
            miDel.Click += new EventHandler(Del_Click);
            miDel.Text = "É¾³ý";
            cm1.MenuItems.Add(miDel);

            miLine = new MenuItem();
            miLine.Name = "Line";
            miLine.Text = "-";
            cm1.MenuItems.Add(miLine);

            MenuItem miSelectAll = new MenuItem();
            miSelectAll.Name = "SelectAll";
            miSelectAll.Click += new EventHandler(SelectAll_Click);
            miSelectAll.Text = "È«Ñ¡";
            cm1.MenuItems.Add(miSelectAll);


            this.ContextMenu = cm1;

            LoadColor();
        }

        #region
        void miCopy_Click(object sender, EventArgs e)
        {
            this.ContextMenu.SourceControl.Select();
            V5RichTextBox rtb = (V5RichTextBox)this.ContextMenu.SourceControl;
            rtb.Copy();
        }
        void Paste_Click(object sender, EventArgs e)
        {
            this.ContextMenu.SourceControl.Select();
            V5RichTextBox rtb = (V5RichTextBox)this.ContextMenu.SourceControl;
            rtb.Paste();
        }
        void Cut_Click(object sender, EventArgs e)
        {
            this.ContextMenu.SourceControl.Select();
            V5RichTextBox rtb = (V5RichTextBox)this.ContextMenu.SourceControl;
            rtb.Cut();
        }
        void Del_Click(object sender, EventArgs e)
        {
            this.ContextMenu.SourceControl.Select();
            V5RichTextBox rtb = (V5RichTextBox)this.ContextMenu.SourceControl;
            rtb.Text = "";
        }
        void SelectAll_Click(object sender, EventArgs e)
        {
            this.ContextMenu.SourceControl.Select();
            V5RichTextBox rtb = (V5RichTextBox)this.ContextMenu.SourceControl;
            rtb.SelectAll();
        }
        void Undo_Click(object sender, EventArgs e)
        {
            this.ContextMenu.SourceControl.Select();
            V5RichTextBox rtb = (V5RichTextBox)this.ContextMenu.SourceControl;
            rtb.Undo();
        }
        #endregion
        private void LoadColor()
        {
            ShangSe(@"(¡¾(.*?)¡¿£º|[(*)])", this, Color.Green);
            ShangSe(@"(¡¾(.*?)¡¿)", this, Color.Green);
            ShangSe(@"(\[(.*?)\])", this, Color.Green);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            LoadColor();
            base.OnTextChanged(e);
        }

        private void ShangSe(string tokens, RichTextBox rt,Color cl)
        {
            Regex rex = new Regex(tokens);
            MatchCollection mc = rex.Matches(this.Text);
            int StartCursorPosition = rt.SelectionStart;
            foreach (Match m in mc)
            {
                int startIndex = m.Index;
                int StopIndex = m.Length;
                rt.Select(startIndex, StopIndex);
                rt.SelectionColor = cl;
                rt.SelectionFont = new Font("ËÎÌå", 10);
                rt.SelectionStart = StartCursorPosition;
                rt.SelectionColor = Color.Black;
            }
            rt.Select(StartCursorPosition, 0);
        }

        public int getbunch(string p, string s) 
        {
            int cnt = 0; int M = p.Length; int N = s.Length;
            char[] ss = s.ToCharArray(), pp = p.ToCharArray();
            if (M > N) return 0;
            for (int i = 0; i < N - M + 1; i++)
            {
                int j;
                for (j = 0; j < M; j++)
                {
                    if (ss[i + j] != pp[j]) break;
                }
                if (j == p.Length)
                {
                    this.Select(i, p.Length);
                    this.SelectionColor = Color.Green;
                    Font f = this.Font;
                    this.SelectionFont = new Font("ËÎÌå", 11, FontStyle.Bold);
                    cnt++;
                }
            }
            return cnt;
        }
        /// <summary>
        /// Filter some message we need to draw the border.
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case NativeMethods.WM_NCPAINT:       
                    WmNcpaint(ref m);
                    break;
                case NativeMethods.WM_NCCALCSIZE:          
                    WmNccalcsize(ref m);
                    break;
                case NativeMethods.WM_THEMECHANGED:        
                    UpdateStyles();
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        /// <summary>
        /// Calculates the size of the window frame and client area of the RichTextBox
        /// </summary>
        void WmNccalcsize(ref Message m)
        {
            base.WndProc(ref m);

            if (!this.RenderWithVisualStyles())
                return;

            NativeMethods.NCCALCSIZE_PARAMS par = new NativeMethods.NCCALCSIZE_PARAMS();

            NativeMethods.RECT windowRect;

            if (m.WParam == IntPtr.Zero)       
            {
                windowRect = (NativeMethods.RECT)Marshal.PtrToStructure(m.LParam, typeof(NativeMethods.RECT));
            }
            else       
            {
                par = (NativeMethods.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NativeMethods.NCCALCSIZE_PARAMS));
                windowRect = par.rgrc0;
            }

            NativeMethods.RECT contentRect;

            IntPtr hDC = NativeMethods.GetWindowDC(this.Handle);

            IntPtr hTheme = NativeMethods.OpenThemeData(this.Handle, "EDIT");

            if (NativeMethods.GetThemeBackgroundContentRect(hTheme, hDC, NativeMethods.EP_EDITTEXT, NativeMethods.ETS_NORMAL
                , ref windowRect
                , out contentRect) == NativeMethods.S_OK)
            {
                contentRect.Inflate(-1, -1);

                this.borderRect = new NativeMethods.RECT(contentRect.Left - windowRect.Left
                    , contentRect.Top - windowRect.Top
                    , windowRect.Right - contentRect.Right
                    , windowRect.Bottom - contentRect.Bottom);

                if (m.WParam == IntPtr.Zero)
                {
                    Marshal.StructureToPtr(contentRect, m.LParam, false);
                }
                else
                {
                    par.rgrc0 = contentRect;
                    Marshal.StructureToPtr(par, m.LParam, false);
                }

                m.Result = new IntPtr(NativeMethods.WVR_REDRAW);
            }

            NativeMethods.CloseThemeData(hTheme);

            NativeMethods.ReleaseDC(this.Handle, hDC);
        }

        /// <summary>
        /// The border painting is done here.
        /// </summary>
        void WmNcpaint(ref Message m)
        {
            base.WndProc(ref m);

            if (!this.RenderWithVisualStyles())
            {
                return;
            }

            /////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////

            int partId = NativeMethods.EP_EDITTEXT;

            int stateId;
            if (this.Enabled)
                if (this.ReadOnly)
                    stateId = NativeMethods.ETS_READONLY;
                else
                    stateId = NativeMethods.ETS_NORMAL;
            else
                stateId = NativeMethods.ETS_DISABLED;

            NativeMethods.RECT windowRect;
            NativeMethods.GetWindowRect(this.Handle, out windowRect);
            windowRect.Right -= windowRect.Left; windowRect.Bottom -= windowRect.Top;
            windowRect.Top = windowRect.Left = 0;

            IntPtr hDC = NativeMethods.GetWindowDC(this.Handle);

            NativeMethods.RECT clientRect = windowRect;
            clientRect.Left += this.borderRect.Left;
            clientRect.Top += this.borderRect.Top;
            clientRect.Right -= this.borderRect.Right;
            clientRect.Bottom -= this.borderRect.Bottom;
            NativeMethods.ExcludeClipRect(hDC, clientRect.Left, clientRect.Top, clientRect.Right, clientRect.Bottom);

            IntPtr hTheme = NativeMethods.OpenThemeData(this.Handle, "EDIT");

            if (NativeMethods.IsThemeBackgroundPartiallyTransparent(hTheme
                , NativeMethods.EP_EDITTEXT, NativeMethods.ETS_NORMAL) != 0)
            {
                NativeMethods.DrawThemeParentBackground(this.Handle, hDC, ref windowRect);
            }

            NativeMethods.DrawThemeBackground(hTheme, hDC, partId, stateId, ref windowRect, IntPtr.Zero);

            NativeMethods.CloseThemeData(hTheme);

            NativeMethods.ReleaseDC(this.Handle, hDC);

            m.Result = IntPtr.Zero;
        }

        /// <summary>
        /// Returns true, when visual styles are enabled in this application.
        /// </summary>
        bool VisualStylesEnabled()
        {
            Type t = typeof(Application);
            System.Reflection.PropertyInfo pi = t.GetProperty("RenderWithVisualStyles");

            if (pi == null)
            {
                OperatingSystem os = System.Environment.OSVersion;
                if (os.Platform == PlatformID.Win32NT && (((os.Version.Major == 5) && (os.Version.Minor >= 1)) || (os.Version.Major > 5)))
                {
                    NativeMethods.DLLVersionInfo version = new NativeMethods.DLLVersionInfo();
                    version.cbSize = Marshal.SizeOf(typeof(NativeMethods.DLLVersionInfo));
                    if (NativeMethods.DllGetVersion(ref version) == 0)
                    {
                        return (version.dwMajorVersion > 5) && NativeMethods.IsThemeActive() && NativeMethods.IsAppThemed();
                    }
                }

                return false;
            }
            else
            {
                bool result = (bool)pi.GetValue(null, null);
                return result;
            }
        }

        /// <summary>
        /// Return true, when this control should render with visual styles.
        /// </summary>
        /// <returns></returns>
        bool RenderWithVisualStyles()
        {
            return (this.BorderStyle == BorderStyle.Fixed3D && this.VisualStylesEnabled());
        }

        /// <summary>
        /// Update the control parameters.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;

                if (this.RenderWithVisualStyles() && (p.ExStyle & NativeMethods.WS_EX_CLIENTEDGE) == NativeMethods.WS_EX_CLIENTEDGE)
                    p.ExStyle ^= NativeMethods.WS_EX_CLIENTEDGE;

                return p;
            }
        }

    }
}
