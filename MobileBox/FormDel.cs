﻿
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

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
            var enmyY = 8;
            var pcmoreY = 8;
            var myhtY = 8;
            var sjmyY = 8;
            var pczfY = 8;

            pcmyPanel.Panel.Controls.Clear();
            xfmyPanel.Panel.Controls.Clear();
            enmyPanel.Panel.Controls.Clear();
            pcmorePanel.Panel.Controls.Clear();
            myhtPanel.Panel.Controls.Clear();
            sjmyPanel.Panel.Controls.Clear();
            pczfPanel.Panel.Controls.Clear();

            RemoteConnect.ConnectState(@"\\192.168.9.179", "qadwnew", "qadwnew123.");
            RemoteConnect.ConnectState(@"\\172.24.140.83", "qadwnew", "qadwnew123.");
            RemoteConnect.ConnectState(@"\\172.24.140.84", "root", "tqqa991969");
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
                else if (nextFile.Name.StartsWith("enmy_autotest"))
                {
                    var ds = new CheckBox
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        Location = new Point(8, enmyY),
                        AutoSize = true,
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson

                    };
                    enmyY += 20;
                    AddEnmy(ds);

                }
                else if (nextFile.Name.StartsWith("pcmore_autotest") || nextFile.Name.StartsWith("hjmy_autotest") || nextFile.Name.StartsWith("sjbmy_autotest") || nextFile.Name.StartsWith("bossmy_autotest") || nextFile.Name.StartsWith("tsfhs_autotest") || nextFile.Name.StartsWith("tsfqm_autotest") || nextFile.Name.StartsWith("myzs_autotest"))
                {
                    var ds = new CheckBox
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        Location = new Point(8, pcmoreY),
                        AutoSize = true,
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson

                    };
                    pcmoreY += 20;
                    AddPcmore(ds);

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

            }

            theFolder = new DirectoryInfo(@"\\172.24.140.83\data");

            foreach (var nextFile in theFolder.GetDirectories())
            {
                if ((nextFile.Name.StartsWith("sjmy_autotest") || nextFile.Name.StartsWith("sjmy_again")) &&
                    !nextFile.Name.Contains("init") && nextFile.Name!= "sjmy_autotest_50802")

                {
                    if (getDateTimeDiff(nextFile.LastWriteTime) > 7)
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
            }

            theFolder = new DirectoryInfo(@"\\172.24.140.84\data");

            foreach (var nextFile in theFolder.GetDirectories())
            {
                if (nextFile.Name.StartsWith("cnzfauto"))
                {
                    if (nextFile.Name.StartsWith("cnzfauto") && nextFile.Name!= "cnzfauto1601005297246") {
                        var ds = new CheckBox
                        {
                            Checked = true,
                            Text = nextFile.Name,
                            Location = new Point(8, pczfY),
                            AutoSize = true,
                            //描边颜色 = Color.Transparent,
                            ForeColor = Color.Crimson
                        };
                        pczfY += 20;
                        AddPczf(ds);
                    }
                }
            }

            SetAllEnabled(true);
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            var task = new Task(GetData);
            task.Start();

        }

        private int getDateTimeDiff(DateTime fileTime)
        {

            DateTime dt1 = Convert.ToDateTime(fileTime);
            DateTime dt2 = Convert.ToDateTime(DateTime.Now.ToString());
            TimeSpan span = dt2.Subtract(dt1);
            return span.Days;

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

        #region Enmy删除按钮
        private void EnmyDelete()
        {
            foreach (var variable in enmyPanel.Panel.Controls)
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

        private void EnmyDel()
        {
            SetAllEnabled(false);
            EnmyDelete();
            //SetAllEnabled(true);
            GetData();
        }

        private void EnmyButton_Click(object sender, EventArgs e)
        {
            var task = new Task(EnmyDel);
            task.Start();
        }


        #endregion

        #region Pcmore删除按钮
        private void PcmoreDelete()
        {
            foreach (var variable in pcmorePanel.Panel.Controls)
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

        private void PcmoreDel()
        {
            SetAllEnabled(false);
            PcmoreDelete();
            //SetAllEnabled(true);
            GetData();
        }

        private void PcmoreButton_Click(object sender, EventArgs e)
        {
            var task = new Task(PcmoreDel);
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
                            DirFile.DeleteDirectory($@"\\172.24.140.83\data\{ck.Text}");
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

        #region  Pczf删除按钮
        private void PczfDelete()
        {
            foreach (var variable in pczfPanel.Panel.Controls)
            {
                try
                {
                    if (variable is CheckBox ck)
                    {
                        if (ck.Checked)
                        {
                            DirFile.DeleteDirectory($@"\\172.24.140.84\data\{ck.Text}");
                        }
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
        private void PczfDel()
        {
            SetAllEnabled(false);
            PczfDelete();
            //SetAllEnabled(true);
            GetData();
        }
        private void PczfButton_Click(object sender, EventArgs e)
        {
            var task = new Task(PczfDel);
            task.Start();

        }
        #endregion

        private void AllDel()
        {
            SetAllEnabled(false);
            PcmyDelete();
            XfmyDelete();
            EnmyDelete();
            PcmoreDelete();
            MyhtDelete();
            SjmyDelete();
            PczfDelete();
            GetData();
        }
        private void AllButton_Click(object sender, EventArgs e)
        {
            var task = new Task(AllDel);
            task.Start();
        }



        /// <summary>
        /// 设置所有控件的Enabled,忽略最小化控件
        /// </summary>
        /// <param name="flag"></param>
        private void SetAllEnabled(bool flag)
        {
            foreach (Control control in Controls)
            {
                if (control.Text == @"r" || control.Text == @"1"||control.Text == @"0")
                {
                   continue;
                }
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
        private void AddEnmy(CheckBox name)
        {
            if (enmyPanel.InvokeRequired)
            {
                AddDelegate ad = AddEnmy;
                enmyPanel.Panel.Invoke(ad, name);
            }
            else
            {
                enmyPanel.Panel.Controls.Add(name);
            }
        }

        private void AddPcmore(CheckBox name)
        {
            if (pcmorePanel.InvokeRequired)
            {
                AddDelegate ad = AddPcmore;
                pcmorePanel.Panel.Invoke(ad, name);
            }
            else
            {
                pcmorePanel.Panel.Controls.Add(name);
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
        private void AddPczf(CheckBox name)
        {
            if (pczfPanel.InvokeRequired)
            {
                AddDelegate ad = AddPczf;
                pczfPanel.Panel.Invoke(ad, name);
            }
            else
            {
                pczfPanel.Panel.Controls.Add(name);
            }
        }

        private void AllButton_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }

    }
}
    

