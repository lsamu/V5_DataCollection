using System.Windows.Forms;

namespace V5_DataCollection
{
    public partial class BaseForm : Form {

        public BaseForm() {
            InitializeComponent();
        }

        public void CloseForm() {
            this.Hide();
            this.Opacity = 0;
            this.Visible = false;
            this.Close();
        }

    }
}
