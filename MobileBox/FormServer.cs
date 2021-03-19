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

        private FormAccount _formreaccount;

		private void accountButton_ButtonClick(object Sender)
		{
			if (_formreaccount == null || _formreaccount.IsDisposed)
			{
				_formreaccount = new FormAccount();
				_formreaccount.Show();
			}
			else
			{
				_formreaccount.WindowState = FormWindowState.Normal;
				//_formresolution.Activate();//之前已打开，则给予焦点，置顶。
			}
		}
	}
}
