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
    public sealed partial class FormImage : Form
    {
        public FormImage()
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private FormResolution _formresolution;


        private void resolutionButton_ButtonClick(object sender)
        {
            if (_formresolution == null || _formresolution.IsDisposed)
            {
                _formresolution = new FormResolution();
                _formresolution.Show();
            }
            else
            {
                _formresolution.Activate();//之前已打开，则给予焦点，置顶。
            }
        }

        private void resolutionButton_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }
    }
}
