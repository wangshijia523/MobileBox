using System.Windows.Forms;

namespace MobileBox
{
    public sealed partial class FormServer : Form
    {
        public FormServer()
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();

        }

        private void FormServer_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }
    }
}
