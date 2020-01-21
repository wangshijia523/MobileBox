using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBox
{
    public partial class FormUploa : MetroFramework.Forms.MetroForm
    {
        public FormUploa()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void FormUploa_Load(object sender, EventArgs e)
        {
            projectComboBox.SelectedIndex = 0;
            versionsComboBox.SelectedIndex = 0;
            folderComboBox.SelectedIndex = 0;
        }

        private const string Ip105 = @"\\192.168.64.105";
        private const string Ip106 = @"\\192.168.64.106";
        private const string Ip23 = @"\\192.168.64.23";
        private string _projectlPath;
        private string _versionlPath;
        private string _folderPath;
        private string _template ; // Case下模板图片

        private void projectComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            switch (projectComboBox.Text)
            {
                case "developer":
                    versionsComboBox.Items.Clear();
                    versionsComboBox.Items.Add(@"无需选择");
                    versionsComboBox.SelectedIndex = 0;
                    versionsComboBox.Enabled = false;

                    folderComboBox.Items.Clear();
                    folderComboBox.Items.Add(@"无需选择");
                    folderComboBox.SelectedIndex = 0;
                    folderComboBox.Enabled = false;
                    _projectlPath = "\\developer\\";
                    _folderPath = _projectlPath;
                    break;

                case "平台控制器":

                    versionsComboBox.Items.Clear();
                    versionsComboBox.Items.Add(@"无需选择");
                    versionsComboBox.SelectedIndex = 0;
                    versionsComboBox.Enabled = false;

                    folderComboBox.Items.Clear();
                    folderComboBox.Items.Add(@"无需选择");
                    folderComboBox.SelectedIndex = 0;
                    folderComboBox.Enabled = false;
                    _projectlPath = "\\developer\\平台控制器\\";
                    _folderPath = _projectlPath;
                    break;

                case "sjmy":
                    versionsComboBox.Enabled = true;
                    GetVersion("sjmy");
                    _projectlPath = "\\developer\\sjmy\\data\\script\\AllVersion\\";
                    _versionlPath = _projectlPath + versionsComboBox.Text;
                    _folderPath = _versionlPath + "\\" + folderComboBox.Text + "\\" + _template;
                    break;


                case "xsjmy":
                    versionsComboBox.Enabled = true;
                    GetVersion("xsjmy");
                    _projectlPath = "\\developer\\xsjmy\\data\\script\\AllVersion\\";
                    _versionlPath = _projectlPath + versionsComboBox.Text;
                    _folderPath = _versionlPath + "\\" + folderComboBox.Text + "\\" + _template;
                    break;

                case "myht":
                    versionsComboBox.Items.Clear();
                    versionsComboBox.Items.Add(@"无需选择");
                    versionsComboBox.SelectedIndex = 0;
                    versionsComboBox.Enabled = false;
                    GetFilder();
                    _projectlPath = "\\developer\\myht\\data\\script";
                    _versionlPath = _projectlPath;
                    _folderPath = _versionlPath + "\\" + folderComboBox.Text + "\\" + _template;
                    break;

            }
        }

        private void versionsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetFilder();
            _versionlPath = _projectlPath + versionsComboBox.Text;
            _folderPath = _versionlPath + "\\" + folderComboBox.Text + "\\" + _template;
        }

        private void folderComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _folderPath = _versionlPath + "\\" + folderComboBox.Text + "\\" + _template;

        }

        private void GetFilder()
        {
            folderComboBox.Items.Clear();
            folderComboBox.Enabled = true;

            folderComboBox.Items.Add(@"case");
            folderComboBox.Items.Add(@"common");
            folderComboBox.Items.Add(@"environinit");
            folderComboBox.Items.Add(@"environinit\SQL_ScriptName");
            folderComboBox.SelectedIndex = 0;
        }


        private void GetVersion(string project)
        {
            versionsComboBox.Items.Clear();
            ShowMsg(RemoteConnect.ConnectState(@"\\192.168.64.105", "administrator", "www.91.com."));
            var path = $@"{Ip105}\\developer\\{project}\\data\\script\\AllVersion";
            
            var theFolder = new DirectoryInfo(path);
            var dirinfo = theFolder.GetDirectories();
            foreach (var nextFolder in dirinfo)
            {
                if (nextFolder.Extension == ".X")
                {
                    versionsComboBox.Items.Add(nextFolder);
                }
            }

            versionsComboBox.SelectedIndex = 0;
            ShowMsg($@"{project}版本获取完成。");
            GetFilder();
        }

        private void GetTemplate()
        {
            _template = string.Empty;
            var tt = new[] {"720x1280", "1080x1920", "1440x2560"};
            var info = new DirectoryInfo(SourcetTextBox.Text);
            if (info.Parent != null)
            {
                var path = info.Name;
                foreach (var p in tt)
                {
                    if (path.IndexOf(p, StringComparison.Ordinal)!=-1)
                    {
                        _template = path;
                        _folderPath = _versionlPath + "\\" + folderComboBox.Text + "\\" + _template;
                        break;
                    }
                }
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

        private void SourcetTextBox_DragDrop(object sender, DragEventArgs e)
        {

            var path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            SourcetTextBox.Text = path;
        }

        private void SourcetTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            if (SourcetTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"源目录为空", @"警告");
                return;
            }
            GetTemplate();
            var task = new Task(Start);
            task.Start();

        }

        private void Start()
        {
            

            SetEnbled(false);
            ShowMsg(RemoteConnect.ConnectState(Ip105, "administrator", "www.91.com."));
            ShowMsg(RemoteConnect.ConnectState(Ip106, "administrator", "www.91.com."));
            ShowMsg(RemoteConnect.ConnectState(Ip23, "administrator", "www.91.com."));

            CopyFolder(SourcetTextBox.Text, $@"{Ip105}{_folderPath}");
            CopyFolder(SourcetTextBox.Text, $@"{Ip106}{_folderPath}");
            CopyFolder(SourcetTextBox.Text, $@"{Ip23}{_folderPath}");

            SetEnbled(true);
        }

        private void CopyFolder(string varFromDirectory, string varToDirectory)
        {

            try
            {
                Directory.CreateDirectory(varToDirectory);

                if (!Directory.Exists(varFromDirectory)) //不是目录的判断为单文件
                {
                    File.Copy(varFromDirectory,
                        varToDirectory +
                        varFromDirectory.Substring(varFromDirectory.LastIndexOf("\\", StringComparison.Ordinal)), true);
                    ShowMsg($"{varToDirectory}复制完成。");
                    dS进度条21.当前值 = 100;
                    return;
                }

                var directories = Directory.GetDirectories(varFromDirectory);

                if (directories.Length > 0)
                {
                    foreach (var d in directories)
                    {
                        CopyFolder(d, varToDirectory + d.Substring(d.LastIndexOf("\\", StringComparison.Ordinal)));
                    }
                }
                var files = Directory.GetFiles(varFromDirectory);
                var max = files.Length;
                var i = 0;
                max = max / 100 + 1;
                if (files.Length > 0)
                {
                    foreach (var s in files)
                    {
                        File.Copy(s, varToDirectory + s.Substring(s.LastIndexOf("\\", StringComparison.Ordinal)), true);
                        dS进度条21.当前值 = i / max;
                        i += 1;
                    }
                }
                ShowMsg($"{varToDirectory}复制完成。");
                dS进度条21.当前值 = 100;
            }
            catch (Exception e)
            {
                ShowMsg(e.ToString().Split('在')[0]);
                
            }
        }

        private delegate void Enableddelegate(bool result);

        private void SetEnbled(bool result)
        {
            if (startButton.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                startButton.Invoke(en, result);
            }
            else
            {
                startButton.Enabled = result;
            }
            if (SourcetTextBox.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                SourcetTextBox.Invoke(en, result);
            }
            else
            {
                SourcetTextBox.Enabled = result;
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
            if (versionsComboBox.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                versionsComboBox.Invoke(en, result);
            }
            else
            {
                versionsComboBox.Enabled = result;
            }
            if (folderComboBox.InvokeRequired)
            {
                Enableddelegate en = SetEnbled;
                folderComboBox.Invoke(en, result);
            }
            else
            {
                folderComboBox.Enabled = result;
            }
        }

        private void FormUploa_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }
    }
    
}
