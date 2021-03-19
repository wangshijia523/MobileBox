namespace MobileBox
{
	partial class FormAccount
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.pcLogin = new MetroFramework.Controls.MetroTextBox();
			this.account = new MetroFramework.Controls.MetroTextBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.White;
			this.metroLabel1.Location = new System.Drawing.Point(23, 180);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(541, 57);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "注：用于手机魔域新版本测试时，项目那边开启设备授权，导致无法切换服务器的问题\r\n        登陆账号使用的是在ndsdk中模糊查找，尽量使用account_i" +
    "d\r\n";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 86);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(93, 19);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "pc登陆账号：";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 121);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(85, 19);
			this.metroLabel3.TabIndex = 2;
			this.metroLabel3.Text = "account_id：";
			// 
			// pcLogin
			// 
			// 
			// 
			// 
			this.pcLogin.CustomButton.Image = null;
			this.pcLogin.CustomButton.Location = new System.Drawing.Point(132, 1);
			this.pcLogin.CustomButton.Name = "";
			this.pcLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.pcLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.pcLogin.CustomButton.TabIndex = 1;
			this.pcLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.pcLogin.CustomButton.UseSelectable = true;
			this.pcLogin.CustomButton.Visible = false;
			this.pcLogin.Lines = new string[0];
			this.pcLogin.Location = new System.Drawing.Point(122, 86);
			this.pcLogin.MaxLength = 32767;
			this.pcLogin.Name = "pcLogin";
			this.pcLogin.PasswordChar = '\0';
			this.pcLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.pcLogin.SelectedText = "";
			this.pcLogin.SelectionLength = 0;
			this.pcLogin.SelectionStart = 0;
			this.pcLogin.ShortcutsEnabled = true;
			this.pcLogin.Size = new System.Drawing.Size(154, 23);
			this.pcLogin.TabIndex = 3;
			this.pcLogin.UseSelectable = true;
			this.pcLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.pcLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// account
			// 
			// 
			// 
			// 
			this.account.CustomButton.Image = null;
			this.account.CustomButton.Location = new System.Drawing.Point(132, 1);
			this.account.CustomButton.Name = "";
			this.account.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.account.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.account.CustomButton.TabIndex = 1;
			this.account.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.account.CustomButton.UseSelectable = true;
			this.account.CustomButton.Visible = false;
			this.account.Lines = new string[0];
			this.account.Location = new System.Drawing.Point(122, 121);
			this.account.MaxLength = 32767;
			this.account.Name = "account";
			this.account.PasswordChar = '\0';
			this.account.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.account.SelectedText = "";
			this.account.SelectionLength = 0;
			this.account.SelectionStart = 0;
			this.account.ShortcutsEnabled = true;
			this.account.Size = new System.Drawing.Size(154, 23);
			this.account.TabIndex = 4;
			this.account.UseSelectable = true;
			this.account.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.account.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(464, 121);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(75, 23);
			this.metroButton1.TabIndex = 6;
			this.metroButton1.Text = "清除";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// FormAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 248);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.account);
			this.Controls.Add(this.pcLogin);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Name = "FormAccount";
			this.Text = "                          FormAccount";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox pcLogin;
		private MetroFramework.Controls.MetroTextBox account;
		private MetroFramework.Controls.MetroButton metroButton1;
	}
}