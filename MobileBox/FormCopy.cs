using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSControls;

namespace MobileBox
{
    public partial class FormCopy : MetroFramework.Forms.MetroForm
    {
        public FormCopy()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void FormCopy_Load(object sender, EventArgs e)
        {
            projectComboBox.SelectedIndex = 0;
        }

        private static string TimeStamp()
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

        private string _oldBase = string.Empty;
        private void projectComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (projectComboBox.Text)
            {
                case "简体魔域  my":
                    QuickSwitch.开关状态 = DS开关.状态.ON;
                    useSwitch.开关状态 = DS开关.状态.ON;
                    restSwitch.开关状态 = DS开关.状态.ON;
                    NewBaseTextBox.Text = $@"pcmy_autotest{TimeStamp()}";
                    _oldBase = @"my";
                    break;

                case "先锋魔域  xf":
                    QuickSwitch.开关状态 = DS开关.状态.ON;
                    useSwitch.开关状态 = DS开关.状态.ON;
                    restSwitch.开关状态 = DS开关.状态.ON;
                    NewBaseTextBox.Text = $@"pcmy_autotestxf{TimeStamp()}";
                    _oldBase = @"xfmy";
                    break;


                case "魔域互通 my":
                    QuickSwitch.开关状态 = DS开关.状态.ON;
                    useSwitch.开关状态 = DS开关.状态.ON;
                    restSwitch.开关状态 = DS开关.状态.ON;
                    NewBaseTextBox.Text = $@"myht_autotest{TimeStamp()}";
                    _oldBase = @"my";
                    break;


                case "手机魔域  init_ndsdk":
                    QuickSwitch.开关状态 = DS开关.状态.OFF;
                    useSwitch.开关状态 = DS开关.状态.OFF;
                    restSwitch.开关状态 = DS开关.状态.ON;
                    NewBaseTextBox.Text = $@"sjmy_again{TimeStamp()}";
                    _oldBase = @"sjmy_autotest_init_ndsdk";
                    break;

                case "西山居魔域  init_xsj":
                    QuickSwitch.开关状态 = DS开关.状态.OFF;
                    useSwitch.开关状态 = DS开关.状态.OFF;
                    restSwitch.开关状态 = DS开关.状态.ON;
                    NewBaseTextBox.Text = $@"sjmy_again{TimeStamp()}";
                    _oldBase = @"sjmy_autotest_init_xsj";
                    break;

                case "简体征服 cnzf":
                    QuickSwitch.开关状态 = DS开关.状态.OFF;
                    useSwitch.开关状态 = DS开关.状态.OFF;
                    restSwitch.开关状态 = DS开关.状态.OFF;
                    NewBaseTextBox.Text = @"简体征服暂停使用";
                    _oldBase = @"cnzf";
                    break;

            }
        }

        private void ScriptTextBox_DragDrop(object sender, DragEventArgs e)
        {

            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                if (Path.GetExtension(file) == ".sql")
                {
                    // 判断文件类型，只接受.sql文件
                    ScriptTextBox.Text = file;
                }
                else
                {
                    MessageBox.Show(@"只接受.sql文件", @"警告");
                }
            }
        }

        private void ScriptTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (NewBaseTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"请先选择游戏项目");
                return;
            }
            var task = new Task(Start);
            task.Start();
        }

        private void Start()
        {
            ShowMsg(RemoteConnect.ConnectState(@"\\192.168.45.11", "administrator", "www.91.com."));
            ShowMsg(RemoteConnect.ConnectState(@"\\192.168.64.105", "administrator", "www.91.com."));
            ShowMsg(RemoteConnect.ConnectState(@"\\192.168.9.179", "qadwnew", "qadwnew123."));
            ShowMsg("开始执行复制操作，留意下方进度条");

            if (Commb(projectComboBox) == "简体征服 cnzf")
            {
                //暂时移除支持
            }
            else
            {
                SetEnbled( false);


                var remote = @"\\192.168.9.179\data\" + _oldBase;
                var aimPath = @"\\192.168.9.179\data\" + NewBaseTextBox.Text;

                if (Commb(projectComboBox) == "简体魔域  my" || Commb(projectComboBox) == "魔域互通 my" || Commb(projectComboBox) == "先锋魔域  xf")
                {
                    remote = @"\\192.168.9.179\data\" + _oldBase + "_bak";
                }

                if (!Directory.Exists(remote))
                {
                    ShowMsg("初始库不存在179目录中,请检查");

                }
                else if (Directory.Exists(aimPath))
                {
                    ShowMsg("自动生成的数据库名称已存在,请选择项目重新生成");
                }

                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    aimPath += Path.DirectorySeparatorChar;
                }

                Directory.CreateDirectory(aimPath);
                var fileList = Directory.GetFiles(remote);

                var max = fileList.Length;
                var i = 0;
                max = max / 100 + 1;
                foreach (var file in fileList)
                {
                    File.Copy(file, aimPath + Path.GetFileName(file), true);
                    ShowMsg($"{file}复制完成。");
                    dS进度条1.当前值 = i/max;
                    i += 1;
                }

                dS进度条1.当前值 = 100;
                ShowMsg($"{NewBaseTextBox.Text}复制完成");
                ShowMsg("等待刷库");

                const string quickPath206My = @"\\192.168.45.11\developer\pc\xmlconfig\mynfkuaice.sql";
                const string userPath206My = @"\\192.168.45.11\developer\pc\xmlconfig\userinfo.sql";
                const string dataPath206My = @"\\192.168.45.11\developer\pc\xmlconfig\updateSql_pcmy.sql";
                const string quickPath206Xf = @"\\192.168.45.11\developer\xf\xmlconfig\mynfkuaice.sql";
                const string userPath206Xf = @"\\192.168.45.11\developer\xf\xmlconfig\userinfo.sql";
                const string dataPath206Xf = @"\\192.168.45.11\developer\xf\xmlconfig\updateSql_pcxf.sql";
                const string dataPath31Sj = @"\\192.168.64.105\developer\sjmy\main\updateSql_sjmy.sql";
                const string dataPath31Xsj = @"\\192.168.64.105\developer\xsjmy\main\updateSql_xsjmy.sql";
                const string quickPath206Zf = @"\\192.168.45.11\developer\zf\main\mynfkuaice.sql";
                const string userPath206Zf = @"\\192.168.45.11\developer\zf\main\userinfo.sql";
                const string dataPath206Zf = @"\\192.168.45.11\developer\zf\main\updateSql_pczf.sql";
                const string myhtQuick = @"\\192.168.64.105\developer\myht\main\mynfkuaice.sql";
                const string myhtUser = @"\\192.168.64.105\developer\myht\main\userinfo.sql";
                const string myhtData = @"\\192.168.64.105\developer\myht\main\updateSql_myht.sql";

                switch (Commb(projectComboBox))
                {

                    case "简体魔域  my":
                        if (QuickSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, userPath206My);
                            dS进度条1.当前值 = 20;
                        }
                        if (useSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, quickPath206My);
                            dS进度条1.当前值 = 40;
                        }
                        if (ScriptTextBox.Text != string.Empty)
                        {
                            IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
                            dS进度条1.当前值 = 60;
                        }
                        if (restSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, dataPath206My);
                            dS进度条1.当前值 = 100;
                        }
                        break;

                    case "先锋魔域  xf":
                        if (QuickSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, userPath206Xf);
                            dS进度条1.当前值 = 20;
                        }
                        if (useSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, quickPath206Xf);
                            dS进度条1.当前值 = 40;
                        }
                        if (ScriptTextBox.Text != string.Empty)
                        {
                            IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
                            dS进度条1.当前值 = 60;
                        }
                        if (restSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, dataPath206Xf);
                            dS进度条1.当前值 = 100;
                        }
                        break;

                    case "魔域互通 my":
                        if (QuickSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, myhtUser);
                            dS进度条1.当前值 = 20;
                        }
                        if (useSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, myhtQuick);
                            dS进度条1.当前值 = 40;
                        }
                        if (ScriptTextBox.Text != string.Empty)
                        {
                            IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
                            dS进度条1.当前值 = 60;
                        }
                        if (restSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, myhtData);
                            dS进度条1.当前值 = 100;
                        }
                        break;


                    case "手机魔域  init_ndsdk":

                        if (ScriptTextBox.Text != string.Empty)
                        {
                            IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
                            dS进度条1.当前值 = 50;
                        }
                        if (restSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, dataPath31Sj);
                            dS进度条1.当前值 = 100;
                        }
                        break;

                    case "西山居魔域  init_xsj":
                        if (ScriptTextBox.Text != string.Empty)
                        {
                            IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
                            dS进度条1.当前值 = 50;
                        }
                        if (restSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, dataPath31Xsj);
                            dS进度条1.当前值 = 100;
                        }

                        break;

                    case "简体征服 cnzf":
                        if (QuickSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, quickPath206Zf, "zf");
                            dS进度条1.当前值 = 20;
                        }
                        if (useSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, userPath206Zf, "zf");
                            dS进度条1.当前值 = 40;
                        }
                        if (ScriptTextBox.Text != string.Empty)
                        {
                            IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text, "zf");
                            dS进度条1.当前值 = 60;
                        }
                        if (restSwitch.开关状态 == DS开关.状态.ON)
                        {
                            IntoSql(NewBaseTextBox.Text, dataPath206Zf, "zf");
                            dS进度条1.当前值 = 100;
                        }
                        break;

                }
                SetEnbled(true);
                ShowMsg("已完成！复制库名进行使用！！！");

            }
        }

        private delegate void Enableddelegate(bool result);

        private void SetEnbled(bool result)
        {
            if (NewBaseTextBox.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                NewBaseTextBox.Invoke(en, result);
            }
            else
            {
                NewBaseTextBox.Enabled = result;
            }

            if (projectComboBox.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                projectComboBox.Invoke(en, result);
            }
            else
            {
                projectComboBox.Enabled = result;
            }

            if (QuickSwitch.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                QuickSwitch.Invoke(en, result);
            }
            else
            {
                QuickSwitch.Enabled = result;
            }

            if (useSwitch.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                useSwitch.Invoke(en, result);
            }
            else
            {
                useSwitch.Enabled = result;
            }


            if (restSwitch.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                restSwitch.Invoke(en, result);
            }
            else
            {
                restSwitch.Enabled = result;
            }

            if (ScriptTextBox.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                ScriptTextBox.Invoke(en, result);
            }
            else
            {
                ScriptTextBox.Enabled = result;
            }

            if (startButton.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                startButton.Invoke(en, result);
            }
            else
            {
                startButton.Enabled = result;
            }

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

        private delegate string Commbdelegate(ComboBox cb);

        /// <summary>
        /// 跨线程读取控件ComboBox的值，并返回
        /// </summary>
        /// <param name="cb">控件名称</param>
        /// <returns></returns>
        private string Commb(ComboBox cb)
        {
            if (!cb.InvokeRequired) return cb.Text;
            Commbdelegate dt = Commb;
            var ia = cb.BeginInvoke(dt, cb);
            return (string)cb.EndInvoke(ia);  // 这里需要利用EndInvoke来获取返回值
        }

        private void IntoSql(string dataName, string sqlPath, string channel = "my")
        {
            string strIp;
            string strUserName;
            string strPassWord;
            string strPort;

            if (channel == "my")
            {
                strIp = "192.168.9.179";
                strUserName = "wjq";
                strPassWord = "wjq";
                strPort = "3306";
            }
            else
            {
                strIp = "192.168.9.8";
                strUserName = "root";
                strPassWord = "tqqa991969";
                strPort = "3306";
            }

            var strMysqlFilePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Tools\\mysql.exe";

            var tempstr = ScriptBrush(sqlPath, strMysqlFilePath, strIp, strUserName, strPassWord, strPort, dataName);

            ShowMsg(tempstr == string.Empty ? $"成功:{sqlPath}刷入" : $"刷库失败: {sqlPath} {tempstr}");
        }

        private static string ScriptBrush(string strScirptFilePah, string strMysqlFilePath, string strIP, string strUserName, string strPassWord, string strPort, string strDataBaseName)
        {
            if (!File.Exists(strScirptFilePah))
                return "刷库文件不存在！";
            try
            {
                //strDataBaseName = "\"" + strDataBaseName + "\"";
                strScirptFilePah = "\"" + strScirptFilePah + "\"";
                strMysqlFilePath = "\"" + strMysqlFilePath + "\"";
                var str = strMysqlFilePath + " -h" + strIP + " -u" + strUserName + " -p" + strPassWord + " -P" + strPort + " " + "-D" + strDataBaseName + " --default-character-set=utf8" + "<" + strScirptFilePah;
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    }
                };
                process.Start();
                process.StandardInput.WriteLine(str);
                process.StandardInput.WriteLine("exit");
                while (!process.HasExited)
                    process.WaitForExit(100);
                var end = process.StandardError.ReadToEnd();
                process.StandardError.Close();
                return end;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void FormCopy_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }
    }

}
