using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSControls;

namespace MobileBox
{
    public partial class FormDel : MetroFramework.Forms.MetroForm
    {
        public FormDel()
        {
            TopMost = true;
            InitializeComponent();
        }

        /// <summary>
        /// 获取179符合条件文件夹
        /// </summary>
        private void GetData()
        {
            SetAllEnabled(false);

                        var pcmyY = 8;
            var xfmyY = 8;
            var myhtY = 8;
            var sjmyY = 8;

            pcmyPanel.Panel.Controls.Clear();
            xfmyPanel.Panel.Controls.Clear();
            myhtPanel.Panel.Controls.Clear();
            sjmyPanel.Panel.Controls.Clear();

            RemoteConnect.ConnectState(@"\\192.168.9.179", "qadwnew", "qadwnew123.");
            var theFolder = new DirectoryInfo(@"\\192.168.9.179\data");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                if (nextFile.Name.StartsWith("pcmy_autotest") && !nextFile.Name.Contains("xf")) //简体
                {
                    var ds = new CheckBox()
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        AutoSize = true,
                        Location = new Point(8, pcmyY),
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson
                    };
                    pcmyY += 20;
                    AddPcmy(ds);

                }
                else if (nextFile.Name.StartsWith("pcmy_autotest") && nextFile.Name.Contains("xf"))
                {
                    var ds = new CheckBox
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        Location = new Point(8, xfmyY),
                        AutoSize = true,
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson

                    };
                    xfmyY += 20;
                    AddXfmy(ds);

                }
                else if (nextFile.Name.StartsWith("myht_autotest") || nextFile.Name.StartsWith("myht_again"))
                {
                    var ds = new CheckBox
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        Location = new Point(8, myhtY),
                        AutoSize = true,
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson
                    };
                    myhtY += 20;
                    AddMyht(ds);

                }

                else if ((nextFile.Name.StartsWith("sjmy_autotest") || nextFile.Name.StartsWith("sjmy_again")) &&
                         !nextFile.Name.Contains("init"))

                {
                    var ds = new CheckBox
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        Location = new Point(8, sjmyY),
                        AutoSize = true,
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson
                    };
                    sjmyY += 20;
                    AddSjmy(ds);
                }
            }

            SetAllEnabled(true);
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            var task = new Task(GetData);
            task.Start();

        }

        #region pcmy删除按钮

        private void PcmyDelete()
        {
            foreach (var variable in pcmyPanel.Panel.Controls)
            {
                try
                {
                    if (variable is CheckBox ck)
                    {
                        if (ck.Checked)
                        {
                            DirFile.DeleteDirectory($@"\\192.168.9.179\data\{ck.Text}");
                        }
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private void PcmyDel()
        {
            SetAllEnabled(false);
            PcmyDelete();
            //SetAllEnabled(true);
            GetData();
        }

        private void PcmyButton_Click(object sender, EventArgs e)
        {
            var task = new Task(PcmyDel);
            task.Start();
        }

        #endregion

        #region Xfmy删除按钮

        private void XfmyDelete()
        {
            foreach (var variable in xfmyPanel.Panel.Controls)
            {
                try
                {
                    if (variable is CheckBox ck)
                    {
                        if (ck.Checked)
                        {
                            DirFile.DeleteDirectory($@"\\192.168.9.179\data\{ck.Text}");
                        }

                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private void XfmyDel()
        {
            SetAllEnabled(false);
            XfmyDelete();
            //SetAllEnabled(true);
            GetData();
        }

        private void XfmyButton_Click(object sender, EventArgs e)
        {
            var task = new Task(XfmyDel);
            task.Start();
        }


        #endregion

        #region Myht删除按钮

        private void MyhtDelete()
        {
            foreach (var variable in myhtPanel.Panel.Controls)
            {
                try
                {
                    if (variable is CheckBox ck)
                    {
                        if (ck.Checked)
                        {
                            DirFile.DeleteDirectory($@"\\192.168.9.179\data\{ck.Text}");
                        }
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
        private void MyhtDel()
        {
            SetAllEnabled(false);
            MyhtDelete();
            //SetAllEnabled(true);
            GetData();
        }
        private void MyhtButton_Click(object sender, EventArgs e)
        {
            var task = new Task(MyhtDel);
            task.Start();
        }

        #endregion

        #region Sjmy删除按钮

        private void SjmyDelete()
        {
            foreach (var variable in sjmyPanel.Panel.Controls)
            {
                try
                {
                    if (variable is CheckBox ck)
                    {
                        if (ck.Checked)
                        {
                            DirFile.DeleteDirectory($@"\\192.168.9.179\data\{ck.Text}");
                        }
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private void SjmyDel()
        {
            SetAllEnabled(false);
            SjmyDelete();
            //SetAllEnabled(true);
            GetData();
        }
        private void SjmyButton_Click(object sender, EventArgs e)
        {
            var task = new Task(SjmyDel);
            task.Start();
        }

        #endregion


        private void AllDel()
        {
            SetAllEnabled(false);
            PcmyDelete();
            XfmyDelete();
            MyhtDelete();
            SjmyDelete();
            GetData();
        }
        private void AllButton_Click(object sender, EventArgs e)
        {
            var task = new Task(AllDel);
            task.Start();
        }



        /// <summary>
        /// 设置所有控件的Enabled
        /// </summary>
        /// <param name="flag"></param>
        private void SetAllEnabled(bool flag)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = flag;
            }
        }

        private delegate void AddDelegate(CheckBox name);
        private void AddPcmy(CheckBox name)
        {
            if (pcmyPanel.InvokeRequired)
            {
                AddDelegate ad = AddPcmy;
                pcmyPanel.Panel.Invoke(ad, name);
                
            }
            else
            {
                pcmyPanel.Panel.Controls.Add(name);
            }


        }
        private void AddXfmy(CheckBox name)
        {
            if (xfmyPanel.InvokeRequired)
            {
                AddDelegate ad = AddXfmy;
                xfmyPanel.Panel.Invoke(ad, name);
            }
            else
            {
                xfmyPanel.Panel.Controls.Add(name);
            }
        }
        private void AddMyht(CheckBox name)
        {
            if (myhtPanel.InvokeRequired)
            {
                AddDelegate ad = AddMyht;
                myhtPanel.Panel.Invoke(ad, name);
            }
            else
            {
                myhtPanel.Panel.Controls.Add(name);
            }
        }
        private void AddSjmy(CheckBox name)
        {
            if (sjmyPanel.InvokeRequired)
            {
                AddDelegate ad = AddSjmy;
                sjmyPanel.Panel.Invoke(ad, name);
            }
            else
            {
                sjmyPanel.Panel.Controls.Add(name);
            }
        }


    }
}
    

