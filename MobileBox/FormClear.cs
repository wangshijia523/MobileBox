
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MobileBox
{

    public partial class FormClear : MetroFramework.Forms.MetroForm
    {
        public FormClear()
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
            var xsjmyY = 8;
            var pbzY = 8;
            var repairY = 8;

            pcmyPanel.Panel.Controls.Clear();
            xfmyPanel.Panel.Controls.Clear();
            enmyPanel.Panel.Controls.Clear();
            pcmorePanel.Panel.Controls.Clear();
            myhtPanel.Panel.Controls.Clear();
            sjmyPanel.Panel.Controls.Clear();
            pczfPanel.Panel.Controls.Clear();
            xsjmyPanel.Panel.Controls.Clear();
            pbzPanel.Panel.Controls.Clear();
            repairPanel.Panel.Controls.Clear();

            var resultLimit = 14;
            var repairLiminit = 30;

            RemoteConnect.ConnectState(@"\\192.168.255.241", "blacknull", "ndqatest2021.*+");

            var theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\pcmy");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\pcmy", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
                {
                    var ds = new CheckBox
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        Location = new Point(8, pcmyY),
                        AutoSize = true,
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson
                    };
                    pcmyY += 20;
                    AddPcmy(ds);
                }
            }

            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\enmy");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\enmy", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
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
            }

            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\PBZ");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\PBZ", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
                {
                    var ds = new CheckBox
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        Location = new Point(8, pbzY),
                        AutoSize = true,
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson
                    };
                    pbzY += 20;
                    AddPbz(ds);
                }
            }

            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\pcmore");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\pcmore", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
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
            }


            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\pcxf");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\pcxf", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
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
            }

            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\pczf");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\pczf", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
                {
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

            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\sjmy");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\sjmy", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
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

            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\xsjmy");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\xsjmy", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
                {
                    var ds = new CheckBox
                    {
                        Checked = true,
                        Text = nextFile.Name,
                        Location = new Point(8, xsjmyY),
                        AutoSize = true,
                        //描边颜色 = Color.Transparent,
                        ForeColor = Color.Crimson
                    };
                    xsjmyY += 20;
                    AddXsjmy(ds);
                }
            }

            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\myht");
            foreach (var nextFile in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\myht", nextFile.ToString());
                if (getDateTimeDiff(nextFile.LastWriteTime) > resultLimit)
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

            theFolder = new DirectoryInfo(@"\\192.168.255.241\upload\维护");
            foreach (var nextFilea in theFolder.GetDirectories())
            {
                var filePath = Path.Combine(@"\\192.168.255.241\upload\维护", nextFilea.ToString());
                var childreForlder = new DirectoryInfo(filePath);
                foreach (var nextFile in childreForlder.GetDirectories())
                {
                    if (getDateTimeDiff(nextFile.LastWriteTime) > repairLiminit)
                    {
                        var ds = new CheckBox
                        {
                            Checked = true,
                            Text = Path.Combine(nextFilea.ToString(), nextFile.Name),
                            Location = new Point(8, repairY),
                            AutoSize = true,
                            //描边颜色 = Color.Transparent,
                            ForeColor = Color.Crimson
                        };
                        repairY += 20;
                        AddRepair(ds);
                    }
                }
            }
            SetAllEnabled(true);
        }

        private int getDateTimeDiff(DateTime fileTime)
        {

            DateTime dt1 = Convert.ToDateTime(fileTime);
            DateTime dt2 = Convert.ToDateTime(DateTime.Now.ToString());
            TimeSpan span = dt2.Subtract(dt1);
            return span.Days;

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
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\pcmy\{ck.Text}");
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
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\pcxf\{ck.Text}");
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
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\enmy\{ck.Text}");
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
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\pcmore\{ck.Text}");
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
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\myht\{ck.Text}");
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
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\sjmy\{ck.Text}");
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
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\pczf\{ck.Text}");
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

        #region  Xsjmy删除按钮
        private void XsjmyDelete()
        {
            foreach (var variable in xsjmyPanel.Panel.Controls)
            {
                try
                {
                    if (variable is CheckBox ck)
                    {
                        if (ck.Checked)
                        {
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\xsjmy\{ck.Text}");
                        }
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private void XsjmyDel()
        {
            SetAllEnabled(false);
            XsjmyDelete();
            //SetAllEnabled(true);
            GetData();
        }
        private void XsjmyButton_Click(object sender, EventArgs e)
        {
            var task = new Task(XsjmyDel);
            task.Start();
        }
        #endregion

        #region  Pbz删除按钮
        private void PbzDelete()
        {
            foreach (var variable in pbzPanel.Panel.Controls)
            {
                try
                {
                    if (variable is CheckBox ck)
                    {
                        if (ck.Checked)
                        {
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\PBZ\{ck.Text}");
                        }
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
        private void PbzDel()
        {
            SetAllEnabled(false);
            PbzDelete();
            //SetAllEnabled(true);
            GetData();
        }
        private void PbzButton_Click(object sender, EventArgs e)
        {
            var task = new Task(PbzDel);
            task.Start();

        }
        #endregion

        #region  repair删除按钮
        private void RepairDelete()
        {
            foreach (var variable in repairPanel.Panel.Controls)
            {
                try
                {
                    if (variable is CheckBox ck)
                    {
                        if (ck.Checked)
                        {
                            DirFile.DeleteDirectory($@"\\192.168.255.241\upload\维护\{ck.Text}");
                            //var filePath = $@"\\192.168.255.241\upload\维护\{ck.Text}";
                        }
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
        private void RepairDel()
        {
            SetAllEnabled(false);
            RepairDelete();
            //SetAllEnabled(true);
            GetData();
        }
        private void RepairButton_Click(object sender, EventArgs e)
        {
            var task = new Task(RepairDel);
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
            XsjmyDelete();
            PbzDelete();
            RepairDelete();
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
        private void AddXsjmy(CheckBox name)
        {
            if (xsjmyPanel.InvokeRequired)
            {
                AddDelegate ad = AddXsjmy;
                xsjmyPanel.Panel.Invoke(ad, name);
            }
            else
            {
                xsjmyPanel.Panel.Controls.Add(name);
            }
        }
        private void AddPbz(CheckBox name)
        {
            if (pbzPanel.InvokeRequired)
            {
                AddDelegate ad = AddPbz;
                pbzPanel.Panel.Invoke(ad, name);
            }
            else
            {
                pbzPanel.Panel.Controls.Add(name);
            }
        }
        private void AddRepair(CheckBox name)
        {
            if (repairPanel.InvokeRequired)
            {
                AddDelegate ad = AddRepair;
                repairPanel.Panel.Invoke(ad, name);
            }
            else
            {
                repairPanel.Panel.Controls.Add(name);
            }
        }
        private void AllButton_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }

    }
}
    