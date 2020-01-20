using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Properties;

namespace MobileBox
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private readonly FormImage _fromimage = new FormImage();
        private readonly FormRemote _formremote = new FormRemote();
        private readonly FormServer _formserver = new FormServer();
        public Form1()
        {
        
            InitializeComponent();

            dS垂直线1.Location = new Point(0, 81);
            dS垂直线1.线条颜色 = Color.DeepSkyBlue;
            metroPanel1.Controls.Clear();

            metroPanel1.Controls.Add(_formremote);
            _formremote.Show();

        }


        private void RemoteButton_Click(object sender, EventArgs e)
        {
            dS垂直线1.Location = new Point(0, 81);
            dS垂直线1.线条颜色 = Color.DeepSkyBlue;
            metroPanel1.Controls.Clear();

            metroPanel1.Controls.Add(_formremote);
            _formremote.Show();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {

            dS垂直线1.Location = new Point(0, 130);
            dS垂直线1.线条颜色 = Color.Gold;
            metroPanel1.Controls.Clear();

            metroPanel1.Controls.Add(_fromimage);
            _fromimage.Show();
            _fromimage.Activate();
        }

        private void serveButton_Click(object sender, EventArgs e)
        {
            dS垂直线1.Location = new Point(0, 175);
            dS垂直线1.线条颜色 = Color.MediumPurple;
            metroPanel1.Controls.Clear();

            metroPanel1.Controls.Add(_formserver);
            _formserver.Show();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }

        private void imageButton_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }

        private void RemoteButton_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }

        private void serveButton_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }
    }
    }
