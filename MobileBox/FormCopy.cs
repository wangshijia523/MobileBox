using System;
using System.Diagnostics;
using System.IO;
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
		public static bool copyResult = false;
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

		/// <summary>
		/// 根据项目设置刷库开关
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void projectComboBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			NewBaseTextBox.Clear();

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

				case "英文魔域  enmy":
					QuickSwitch.开关状态 = DS开关.状态.ON;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"enmy_autotest{TimeStamp()}";
					_oldBase = @"enmy";
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
					QuickSwitch.开关状态 = DS开关.状态.ON;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"cnzfauto{TimeStamp()}";
					_oldBase = @"cnzf";
					break;

				case "怀旧魔域 hjmy":
					QuickSwitch.开关状态 = DS开关.状态.ON;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"hjmy_autotest{TimeStamp()}";
					_oldBase = @"hjmy";
					break;

				case "魔域时间版 sjbmy":
					QuickSwitch.开关状态 = DS开关.状态.ON;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"sjbmy_autotest{TimeStamp()}";
					_oldBase = @"sjbmy";
					break;

				case "boos版魔域 bossmy":
					QuickSwitch.开关状态 = DS开关.状态.ON;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"bossmy_autotest{TimeStamp()}";
					_oldBase = @"bossmy";
					break;

				case "幻兽特色服 tsfhs":
					QuickSwitch.开关状态 = DS开关.状态.ON;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"tsfhs_autotest{TimeStamp()}";
					_oldBase = @"tsfhs";
					break;

				case "千面特色服 tsfqm":
					QuickSwitch.开关状态 = DS开关.状态.OFF;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"tsfqm_autotest{TimeStamp()}";
					_oldBase = @"tsfqm";
					break;

				case "战士特色服 myzs":
					QuickSwitch.开关状态 = DS开关.状态.ON;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"myzs_autotest{TimeStamp()}";
					_oldBase = @"myzs";
					break;

				case "新服特色服 new":
					QuickSwitch.开关状态 = DS开关.状态.ON;
					useSwitch.开关状态 = DS开关.状态.ON;
					restSwitch.开关状态 = DS开关.状态.ON;
					NewBaseTextBox.Text = $@"new_autotest{TimeStamp()}";
					_oldBase = @"my";
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
			/*
            else if (Commb(projectComboBox) == "简体征服 cnzf")
            {
                MessageBox.Show(@"暂时移除支持", @"提示");
                return;
                //暂时移除支持
            }
			*/

			var task = new Task(Start);
			task.Start();
			Clipboard.SetDataObject(NewBaseTextBox.Text);
		}

		/// <summary>
		/// 记录拉库数据
		/// </summary>
		private void insertion()

		{

			MySqlHelper.InitConnectStr("192.168.255.242", "root", "123", "newtools");
			MySqlHelper.ExecuteSql($"INSERT INTO pulltime (`ip`, `date`, `project`) VALUES ('{Get64SegmentIp.LocalIp}', '{DateTime.Now}', '{Commb(projectComboBox)}')");


		}




		private void Start()
		{
			SetEnbled(false);

			ShowMsg(RemoteConnect.ConnectState(@"\\192.168.255.187", "blacknull", "ndqatest2021.*+"));
			ShowMsg(RemoteConnect.ConnectState(@"\\192.168.255.131", "blacknull", "ndqatest2021.*+"));
			ShowMsg(RemoteConnect.ConnectState(@"\\192.168.255.63", "blacknull", "ndqatest2021.*+"));
			//ShowMsg(RemoteConnect.ConnectState(@"\\192.168.9.179", "blacknull", "shangjia!@#123.idc1"));
			//ShowMsg(RemoteConnect.ConnectState(@"\\172.24.140.83", "blacknull", "IDC2.passwd*()"));
			//ShowMsg(RemoteConnect.ConnectState(@"\\172.24.140.84", "blacknull", "..acquiescence1"));
			ShowMsg("开始执行复制操作!");
			
			//数据库记录
			insertion();

			string remote;
			string aimPath;

			if (Commb(projectComboBox) == "简体征服 cnzf")
			{
				//ftp复制

				aimPath = $@"\\172.24.140.84\data\{NewBaseTextBox.Text}";

				if (Directory.Exists(aimPath))
				{
					ShowMsg("自动生成的数据库名称已存在,请选择项目重新生成");
					SetEnbled(true);
					return;
				}
				Directory.CreateDirectory(aimPath);
				var ftp = new FtpHelper("192.168.9.250", "/data5/cnzf", "QAyyq", "QAyyq..!!~~");

				var max = ftp.GetAllList().Length;
				var i = 0;
				max = max / 100 + 1;
				foreach (var file in ftp.GetAllList())
				{
					ftp.Download(aimPath, file);
					ShowMsg($"{file}复制完成。");
					dS进度条1.当前值 = i / max;
					i += 1;
				}
				dS进度条1.当前值 = 100;
				ShowMsg($"{NewBaseTextBox.Text}复制完成");
				ShowMsg("等待刷库");

			}
			else
			{
				bool isContains;
				dS进度条1.当前值 = 30;

				if (Commb(projectComboBox) == "手机魔域  init_ndsdk" || Commb(projectComboBox) == "西山居魔域  init_xsj")
				{

					//remote = $@"\\172.24.140.83\data\{_oldBase}";
					//aimPath = $@"\\172.24.140.83\data\{NewBaseTextBox.Text}";

					if (Xcopy(false).IndexOf("error code 0.", StringComparison.OrdinalIgnoreCase) < 0)
					{
						ShowMsg("远程命令执行失败导致复制失败！");
						SetEnbled(true);
						return;
					}

				}

				else
				{
					//使用wmic的方式复制
					//remote = $@"\\192.168.9.179\data\{_oldBase}_bak";
					//aimPath = $@"\\192.168.9.179\data\{NewBaseTextBox.Text}";

					if (Wcopy().IndexOf("ReturnValue = 0", StringComparison.OrdinalIgnoreCase) < 0)
					{
						ShowMsg("远程命令执行失败导致复制失败！");
						SetEnbled(true);
						return;
					}

					var initialDir = $@"\\192.168.9.179\data\{_oldBase}_bak";
					var endDir = $@"\\192.168.9.179\data\{NewBaseTextBox.Text}";


					var initialSize = DirSize(new DirectoryInfo(initialDir));


					for (var i = 0; i < 100; i++)
					{

						if (DirFile.IsExistDirectory(endDir))
						{

							var endSize = DirSize(new DirectoryInfo(endDir));
							ShowMsg($@"目标库大小{endSize}--初始库大小{initialSize}");
							if (initialSize == endSize)
							{
								break;
							}

							System.Threading.Thread.Sleep(2000);

							if (i > 90)
							{
								ShowMsg("复制时间超时，判断复制失败，不执行刷库");
								SetEnbled(true);
								return;
							}
						}

						System.Threading.Thread.Sleep(2000);
					}

				}






				/*
				// 共享文件形式
				if (!Directory.Exists(remote))
		        {
			        ShowMsg($"初始库不存在{remote},请检查");
                    SetEnbled(true);
                    return;

                }

		        if (Directory.Exists(aimPath))
		        {
			        ShowMsg("自动生成的数据库名称已存在,请选择项目重新生成");
			        SetEnbled(true);
			        return;
		        }
		
		        if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
		        {
			        aimPath += Path.DirectorySeparatorChar;
		        }
				///
		        Directory.CreateDirectory(aimPath);
		        var fileList = Directory.GetFiles(remote);

		        var max = fileList.Length;
		        var i = 0;
		        max = max / 100 + 1;
		        foreach (var file in fileList)
		        {
			        File.Copy(file, aimPath + Path.GetFileName(file), true);
			        ShowMsg($"{file}复制完成。");
			        dS进度条1.当前值 = i / max;
			        i += 1;
		        }
				*/
			}


			dS进度条1.当前值 = 50;
			ShowMsg($"{NewBaseTextBox.Text}复制完成");
			ShowMsg("等待刷库");

			#region sql地址 常量 

			const string quickPath206My = @"\\192.168.255.187\developer\pc\xmlconfig\mynfkuaice.sql";
			const string userPath206My = @"\\192.168.255.187\developer\pc\xmlconfig\userinfo.sql";
			const string dataPath206My = @"\\192.168.255.187\developer\pc\xmlconfig\updateSql_pcmy.sql";
			const string quickPath206Xf = @"\\192.168.255.187\developer\xf\xmlconfig\mynfkuaice.sql";
			const string userPath206Xf = @"\\192.168.255.187\developer\xf\xmlconfig\userinfo.sql";
			const string dataPath206Xf = @"\\192.168.255.187\developer\xf\xmlconfig\updateSql_pcxf.sql";
			const string quickPath206Enmy = @"\\192.168.255.187\developer\enmy\xmlconfig\mynfkuaice.sql";
			const string userPath206Enmy = @"\\192.168.255.187\developer\enmy\xmlconfig\userinfo.sql";
			const string dataPath206Enmy = @"\\192.168.255.187\developer\enmy\xmlconfig\updateSql_enmy.sql";
			const string dataPath31Sj = @"\\192.168.255.131\developer\sjmy\main\updateSql_sjmy.sql";
			const string dataPath31Xsj = @"\\192.168.255.131\developer\xsjmy\main\updateSql_xsjmy.sql";
			const string quickPath206Zf = @"\\192.168.255.187\developer\zf\xmlconfig\mynfkuaice.sql";
			const string userPath206Zf = @"\\192.168.255.187\developer\zf\xmlconfig\userinfo.sql";
			const string dataPath206Zf = @"\\192.168.255.187\developer\zf\xmlconfig\updateSql_pczf.sql";
			const string myhtQuick = @"\\192.168.255.63\developer\myht\main\mynfkuaice.sql";
			const string myhtUser = @"\\192.168.255.63\developer\myht\main\userinfo.sql";
			const string myhtData = @"\\192.168.255.63\developer\myht\main\updateSql_myht.sql";
			const string quickPath206More = @"\\192.168.255.187\developer\pcmore\xmlconfig\mynfkuaice.sql";
			const string userPath206More = @"\\192.168.255.187\developer\pcmore\xmlconfig\userinfo.sql";
			const string userPath206MoreTsfqm = @"\\192.168.255.187\developer\pcmore\xmlconfig\userinfo_tsfqm.sql";
			const string dataPath206More = @"\\192.168.255.187\developer\pcmore\xmlconfig\updateSql_pcmore.sql";

			const string dataPathTsfqm = @"\\192.168.255.187\developer\pcmore\xmlconfig\updateSql_tsfqm.sql";
			const string dataPathNew = @"\\192.168.255.187\developer\pcmore\xmlconfig\updateSql_new.sql";
			#endregion

			#region 刷库操作
			switch (Commb(projectComboBox))
			{

				case "简体魔域  my":


					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206My);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
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

					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206Xf);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
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

				case "英文魔域  enmy":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206Enmy);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206Enmy);

						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPath206Enmy);
						dS进度条1.当前值 = 100;
					}
					break;

				case "魔域互通 my":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, myhtUser);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
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
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206Zf);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206Zf);
						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPath206Zf);
						dS进度条1.当前值 = 100;
					}
					break;

				case "怀旧魔域 hjmy":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206More);

						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206More);
						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPath206More);
						dS进度条1.当前值 = 100;
					}
					break;
				case "魔域时间版 sjbmy":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206More);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206More);

						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPath206More);
						dS进度条1.当前值 = 100;
					}
					break;
				case "boos版魔域 bossmy":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206More);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206More);

						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPath206More);
						dS进度条1.当前值 = 100;
					}
					break;
				case "幻兽特色服 tsfhs":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206More);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206More);

						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPath206More);
						dS进度条1.当前值 = 100;
					}
					break;
				case "千面特色服 tsfqm":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206MoreTsfqm);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206More);

						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPathTsfqm);
						dS进度条1.当前值 = 100;
					}
					break;
				case "战士特色服 myzs":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206More);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206More);

						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPath206More);
						dS进度条1.当前值 = 100;
					}
					break;
				case "新服特色服 new":
					if (useSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, userPath206More);
						dS进度条1.当前值 = 20;
					}
					if (QuickSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, quickPath206More);

						dS进度条1.当前值 = 40;
					}
					if (ScriptTextBox.Text != string.Empty)
					{
						IntoSql(NewBaseTextBox.Text, ScriptTextBox.Text);
						dS进度条1.当前值 = 60;
					}
					if (restSwitch.开关状态 == DS开关.状态.ON)
					{
						IntoSql(NewBaseTextBox.Text, dataPathNew);
						dS进度条1.当前值 = 100;
					}
					break;



			}
			#endregion
			SetEnbled(true);
			dS进度条1.当前值 = 100;
			ShowMsg("已完成！复制库名进行使用！！！");
		}


		public static long DirSize(DirectoryInfo d)
		{

			long size = 0;
			//  所有文件大小.
			var fis = d.GetFiles();
			foreach (var fi in fis)
			{
				size += fi.Length;
			}

			//  遍历出当前目录的所有文件夹.
			var dis = d.GetDirectories();

			foreach (var di in dis)
			{
				size += DirSize(di); // 这就用到递归了，调用父方法,注意，这里并不是直接返回值，而是调用父返回来的
			}

			return size;
		}


		private string Wcopy()
		{
			var cmd = $@"wmic /node:'192.168.9.179' /password:'shangjia!@#123.idc1' /user:'blacknull' process call create 'XCOPY /Y /E /C /H /S /I F:\MYSQL40\data\{_oldBase}_bak F:\MYSQL40\data\{NewBaseTextBox.Text}'";
			
			var runCmd = new RunCmd();
			var result = runCmd.Exe(cmd);
			return result;
		}

		private string Xcopy(bool pc)
		{
			string filePath;
			string text;
			string cmd;

			if (pc)
			{
				filePath = $@"\\192.168.9.179\data\{NewBaseTextBox.Text}.bat";
				text = $@"XCOPY /Y /E /C /H /S /I F:\MYSQL40\data\{_oldBase}_bak F:\MYSQL40\data\{NewBaseTextBox.Text}";
				cmd = $@"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}Tools\\PsExec.exe \\192.168.9.179 -u blacknull -p shangjia!@#123.idc1  -i  F:\MYSQL40\data\{NewBaseTextBox.Text}.bat";
			}
			else
			{
				filePath = $@"\\172.24.140.83\data\{NewBaseTextBox.Text}.bat";
				text = $@"XCOPY /Y /E /C /H /S /I G:\mysql40\data\{_oldBase} G:\mysql40\data\{NewBaseTextBox.Text}";
				cmd = $@"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}Tools\\PsExec.exe \\172.24.140.83 -u blacknull -p IDC2.passwd*()  -i G:\mysql40\data\{NewBaseTextBox.Text}.bat";
			}

			DirFile.CreateFile(filePath);
			DirFile.WriteText(filePath, text, Encoding.Default);

			var runCmd = new RunCmd();
			var result = runCmd.Exe(cmd);
			File.Delete(filePath);

			return result;




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
				logTextBox.Invoke(dt, msg);
				//logTextBox.Invoke(dt, msg+" \t\n");
			}
			else
			{
				logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + ":    " + msg + "\r\n");
				//logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + ":    " + msg + " \t\n");
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

		private void IntoSql(string dataName, string sqlPath)
		{
			string strIp;
			string strUserName;
			string strPassWord;
			string strPort;

			if (Commb(projectComboBox) == "手机魔域  init_ndsdk" || Commb(projectComboBox) == "西山居魔域  init_xsj")
			{

				strIp = "172.24.140.83";
				strUserName = "wjq";
				strPassWord = "wjq";
				strPort = "3306";

			}
			else if (Commb(projectComboBox) == "简体征服 cnzf")
			{
				strIp = "172.24.140.84";
				strUserName = "root";
				strPassWord = "tqqa991969";
				strPort = "3306";
			}
			else
			{
				strIp = "192.168.9.179";
				strUserName = "wjq";
				strPassWord = "wjq";
				strPort = "3306";
			}

			var strMysqlFilePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Tools\\mysql.exe";

			var tempstr = ScriptBrush(sqlPath, strMysqlFilePath, strIp, strUserName, strPassWord, strPort, dataName);

			ShowMsg(tempstr == string.Empty ? $"成功:{sqlPath}刷入" : $"刷库失败: {sqlPath} {tempstr}");
		}

		private static string ScriptBrush(string strScirptFilePah, string strMysqlFilePath, string strIp, string strUserName, string strPassWord, string strPort, string strDataBaseName)
		{
			if (!File.Exists(strScirptFilePah))
				return "刷库文件不存在！";
			try
			{
				//strDataBaseName = "\"" + strDataBaseName + "\"";
				strScirptFilePah = "\"" + strScirptFilePah + "\"";
				strMysqlFilePath = "\"" + strMysqlFilePath + "\"";
				var str = strMysqlFilePath + " -h" + strIp + " -u" + strUserName + " -p" + strPassWord + " -P" + strPort + " " + "-D" + strDataBaseName + " --default-character-set=utf8" + "<" + strScirptFilePah;
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
