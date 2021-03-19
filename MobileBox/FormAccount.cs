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
	public partial class FormAccount : MetroFramework.Forms.MetroForm
	{
		public FormAccount()
		{
			TopMost = true;
			InitializeComponent();
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{

			if (account.Text==string.Empty)
			{
				if (pcLogin.Text == string.Empty)
				{
					MessageBox.Show("请输入pc端登陆账号","错误");
					return;
				}

				//通过ndsdk查询account_id
				MySqlHelper.InitConnectStr("172.24.140.83", "wjq", "wjq", "sjmy_autotest_init_ndsdk");
				var sql = $@"select account_id from cq_user where channel_account like '%{pcLogin.Text}'";
				var acc  = MySqlHelper.GetDataSet(sql).Tables["Table1"].Rows[0].ItemArray[0];
				account.Text = acc.ToString();
			}

			MySqlHelper.InitConnectStr("172.24.140.83", "wjq", "wjq", "sjmynd_accountcenter");
			var numb = MySqlHelper.ExecuteSql($@"DELETE FROM cq_devicelist WHERE account_id = {account.Text}");
			MessageBox.Show(numb > 0 ? $"清除了{numb}条数据，再登陆游戏试试" : $"未发现数据，再登陆游戏试试，检查account是否正确", "提示");
		}
	}
}
