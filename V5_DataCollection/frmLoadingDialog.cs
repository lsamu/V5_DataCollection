using System;
using System.Drawing;
using System.Windows.Forms;

namespace V5_DataCollection
{
    public partial class frmLoadingDialog : Form {
        private static Color borderColor = Color.FromArgb(0, 0, 0);
        private static Color headerColor = Color.FromArgb(211, 219, 222);

        public frmLoadingDialog() {
            InitializeComponent();
        }

        private void SetSelfLocation() {
            if (this.OwnedForms == null || this.OwnedForms.Length == 0) return;

            Form owner = this.OwnedForms[0];
            if (owner == null) return;

            this.Location = new Point(owner.Location.X + owner.Size.Width / 3, owner.Location.Y + owner.Size.Height / 3);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor, ButtonBorderStyle.Solid);
            e.Graphics.FillRectangle(new SolidBrush(headerColor), 1, 1, this.Size.Width - 2, 26);
        }

        public int Percentage {
            set {
                this.lblPercentage.Text = value + "%";
            }
        }

        private void LoadingDialog_Load(object sender, EventArgs e) {
            SetSelfLocation();
        }
    }
}
