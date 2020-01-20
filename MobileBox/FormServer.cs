using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
