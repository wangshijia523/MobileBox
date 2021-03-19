using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSControls;
using System.Management;

namespace MobileBox
{
    public partial class FormSwitch : MetroFramework.Forms.MetroForm
    {
        public FormSwitch()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void examineButton_Click(object sender, EventArgs e)
        {
            var task = new Task(Examine);
            task.Start();
        }

        private void Examine()
        {
            SetEnbled(false);
            foreach (DS复选框 ip in IpPanel.Panel.Controls)
            {
                if (ip.Checked)
                {
                    foreach (DS复选框 course in coursePanel.Panel.Controls)
                    {
                        if (course.Checked)
                        {
                            ShowMsg($"{ip.Text}残余：" + Wmi.SelectProcess(ip.Text, "blacknull", "ndqatest2021.*+", course.Text));
                        }
                    }
                }
            }
            SetEnbled(true);
        }


        private void killButton_Click(object sender, EventArgs e)
        {
            var task = new Task(Kill);
            task.Start();
        }

        private void Kill()
        {
            SetEnbled(false);
            foreach (DS复选框 ip in IpPanel.Panel.Controls)
            {
                if (ip.Checked)
                {
                    var co = new ConnectionOptions();
                    var machineName = ip.Text; // 连接的目标机的IP地址或者机器名
                    co.Username = "blacknull";         // 连接需要的用户名
                    co.Password = "ndqatest2021.*+";      // 连接需要的密码
                    var scope = new ManagementScope("\\\\" + machineName + "\\root\\cimv2", co);
                    scope.Options.Impersonation = ImpersonationLevel.Impersonate;
                    scope.Options.EnablePrivileges = true;
                    scope.Connect();

                    foreach (DS复选框 course in coursePanel.Panel.Controls)
                    {
                        if (course.Checked)
                        {
                            ShowMsg($"{ip.Text}关闭：" + Wmi.CloseProcess(course.Text, scope));
                            System.Threading.Thread.Sleep(200);
                            //ShowMsg($"{ip.Text}关闭：" + Wmi.CloseProcess(course.Text, "blacknull", "ndqatest2021.*+", course.Text));
                        }
                    }
                }
            }
            SetEnbled(true);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var task = new Task(Open);
            task.Start();
        }

        private void Open()
        {
            SetEnbled(false);
            foreach (DS复选框 ip in IpPanel.Panel.Controls)
            {
                if (ip.Checked)
                {
                    if (ip.Text == "192.168.255.131")
                    {
                        ShowMsg($"{ip.Text}开启：" + Wmi.OpenProcess(ip.Text, "blacknull", "ndqatest2021.*+",
                            $@"D:\developer\平台控制器\{comboHQ.Text}"));
                        System.Threading.Thread.Sleep(3000);
                    }
                    ShowMsg($"{ip.Text}开启：" + Wmi.OpenProcess(ip.Text, "blacknull", "ndqatest2021.*+",
                        $@"D:\developer\平台控制器\{comboBranch.Text}"));
                    System.Threading.Thread.Sleep(1000);
                }

               
            }

            SetEnbled(true);
        }

        private void logTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }

        private delegate void Textbdelegate(string str);

        private void ShowMsg(string msg)
        {
            if (logTextBox.InvokeRequired)
            {
                Textbdelegate dt = ShowMsg;
                logTextBox.Invoke(dt, msg );
            }
            else
            {
                logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + ":    " + msg + "\r\n");
            }
        }

        private delegate void Enableddelegate(bool result);

        private void SetEnbled(bool result)
        {
            if (openButton.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                openButton.Invoke(en, result);
            }
            else
            {
                openButton.Enabled = result;
            }
            if (killButton.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                killButton.Invoke(en, result);
            }
            else
            {
                killButton.Enabled = result;
            }
            if (examineButton.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                examineButton.Invoke(en, result);
            }
            else
            {
                examineButton.Enabled = result;
            }
            if (IpPanel.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                IpPanel.Invoke(en, result);
            }
            else
            {
                IpPanel.Enabled = result;
            }
            if (coursePanel.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                coursePanel.Invoke(en, result);
            }
            else
            {
                coursePanel.Enabled = result;
            }
        }
    }
}
