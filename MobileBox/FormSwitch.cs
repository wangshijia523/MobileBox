using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSControls;

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
                            ShowMsg($"{ip.Text}残余：" + Wmi.SelectProcess(ip.Text, "administrator", "www.91.com.", course.Text));
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
                    foreach (DS复选框 course in coursePanel.Panel.Controls)
                    {
                        if (course.Checked)
                        {
                            ShowMsg($"{ip.Text}关闭：" + Wmi.CloseProcess(ip.Text, "administrator", "www.91.com.", course.Text));
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
                    if (ip.Text == "192.168.64.105")
                    {
                        ShowMsg($"{ip.Text}开启：" + Wmi.OpenProcess(ip.Text, "administrator", "www.91.com.",
                            $@"D:\developer\平台控制器\{comboHQ.Text}", "03"));
                    }
                    ShowMsg($"{ip.Text}开启：" + Wmi.OpenProcess(ip.Text, "administrator", "www.91.com.",
                        $@"D:\developer\平台控制器\{comboBranch.Text}", "02"));
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
                logTextBox.Invoke(dt, msg + "\t\n");
            }
            else
            {
                logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + ":    " + msg + "\t\n");
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
