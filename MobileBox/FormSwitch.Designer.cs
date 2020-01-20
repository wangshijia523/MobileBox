namespace MobileBox
{
    partial class FormSwitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSwitch));
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.killButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.examineButton = new System.Windows.Forms.Button();
            this.coursePanel = new DSControls.DS分组容器();
            this.comboFastCopy = new DSControls.DS复选框();
            this.comboCmd = new DSControls.DS复选框();
            this.comboPythonw = new DSControls.DS复选框();
            this.comboHQ = new DSControls.DS复选框();
            this.comboAdb = new DSControls.DS复选框();
            this.comboPython = new DSControls.DS复选框();
            this.comboBranch = new DSControls.DS复选框();
            this.IpPanel = new DSControls.DS分组容器();
            this.comboIP105 = new DSControls.DS复选框();
            this.comboIP106 = new DSControls.DS复选框();
            this.comboIP23 = new DSControls.DS复选框();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coursePanel.Panel.SuspendLayout();
            this.coursePanel.SuspendLayout();
            this.IpPanel.Panel.SuspendLayout();
            this.IpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.Location = new System.Drawing.Point(13, 174);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(604, 121);
            this.logTextBox.TabIndex = 25;
            this.logTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // killButton
            // 
            this.killButton.BackColor = System.Drawing.Color.Transparent;
            this.killButton.FlatAppearance.BorderSize = 0;
            this.killButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.killButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.killButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.killButton.Image = global::MobileBox.Properties.Resources.skull_32px_1082340_easyicon_net;
            this.killButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.killButton.Location = new System.Drawing.Point(507, 138);
            this.killButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(110, 31);
            this.killButton.TabIndex = 28;
            this.killButton.Text = "结束进程";
            this.killButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.killButton.UseVisualStyleBackColor = false;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            this.killButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.Transparent;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openButton.Image = global::MobileBox.Properties.Resources.play_32px_1082335_easyicon_net;
            this.openButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.Location = new System.Drawing.Point(507, 107);
            this.openButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(110, 31);
            this.openButton.TabIndex = 27;
            this.openButton.Text = "开启进程";
            this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            this.openButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // examineButton
            // 
            this.examineButton.BackColor = System.Drawing.Color.Transparent;
            this.examineButton.FlatAppearance.BorderSize = 0;
            this.examineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.examineButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.examineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.examineButton.Image = global::MobileBox.Properties.Resources.check_32px_1082324_easyicon_net;
            this.examineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.examineButton.Location = new System.Drawing.Point(507, 76);
            this.examineButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.examineButton.Name = "examineButton";
            this.examineButton.Size = new System.Drawing.Size(110, 31);
            this.examineButton.TabIndex = 26;
            this.examineButton.Text = "残余检查";
            this.examineButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.examineButton.UseVisualStyleBackColor = false;
            this.examineButton.Click += new System.EventHandler(this.examineButton_Click);
            this.examineButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // coursePanel
            // 
            this.coursePanel.BackColor = System.Drawing.Color.Transparent;
            this.coursePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coursePanel.BackgroundImage")));
            this.coursePanel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursePanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.coursePanel.Location = new System.Drawing.Point(163, 72);
            this.coursePanel.Name = "coursePanel";
            // 
            // coursePanel.Panel1
            // 
            this.coursePanel.Panel.BackColor = System.Drawing.Color.Transparent;
            this.coursePanel.Panel.Controls.Add(this.comboFastCopy);
            this.coursePanel.Panel.Controls.Add(this.comboCmd);
            this.coursePanel.Panel.Controls.Add(this.comboPythonw);
            this.coursePanel.Panel.Controls.Add(this.comboHQ);
            this.coursePanel.Panel.Controls.Add(this.comboAdb);
            this.coursePanel.Panel.Controls.Add(this.comboPython);
            this.coursePanel.Panel.Controls.Add(this.comboBranch);
            this.coursePanel.Panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.coursePanel.Panel.Location = new System.Drawing.Point(3, 24);
            this.coursePanel.Panel.Name = "Panel1";
            this.coursePanel.Panel.Size = new System.Drawing.Size(332, 69);
            this.coursePanel.Panel.TabIndex = 1;
            this.coursePanel.Panel.边框颜色 = System.Drawing.Color.Empty;
            this.coursePanel.ShowBorder = true;
            this.coursePanel.Size = new System.Drawing.Size(338, 96);
            this.coursePanel.TabIndex = 5;
            this.coursePanel.Text = "进程列表";
            this.coursePanel.TitleBackColor = System.Drawing.Color.Silver;
            this.coursePanel.关闭确认 = false;
            this.coursePanel.可关闭 = false;
            this.coursePanel.可折叠 = false;
            this.coursePanel.右圆角 = 0F;
            this.coursePanel.填充色 = System.Drawing.Color.Transparent;
            this.coursePanel.左圆角 = 0F;
            this.coursePanel.折叠状态 = DSControls.DS分组容器.状态.展开;
            this.coursePanel.标题文字描边 = true;
            this.coursePanel.标题文字描边颜色 = System.Drawing.Color.Black;
            this.coursePanel.渐变强度百分比 = 0.1F;
            this.coursePanel.点击关闭时 = DSControls.DS分组容器.关闭操作.关闭;
            this.coursePanel.背景色透明度 = 1F;
            this.coursePanel.锚定另一个 = null;
            this.coursePanel.锚定间距 = 10;
            this.coursePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboFastCopy
            // 
            this.comboFastCopy.AutoSize = true;
            this.comboFastCopy.BackColor = System.Drawing.Color.Transparent;
            this.comboFastCopy.Checked = true;
            this.comboFastCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboFastCopy.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFastCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboFastCopy.Location = new System.Drawing.Point(4, 48);
            this.comboFastCopy.MaximumSize = new System.Drawing.Size(116, 20);
            this.comboFastCopy.MinimumSize = new System.Drawing.Size(116, 20);
            this.comboFastCopy.Name = "comboFastCopy";
            this.comboFastCopy.Size = new System.Drawing.Size(116, 20);
            this.comboFastCopy.TabIndex = 34;
            this.comboFastCopy.Text = "FastCopy.exe";
            this.comboFastCopy.勾选符号色 = System.Drawing.Color.Silver;
            this.comboFastCopy.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboFastCopy.描边颜色 = System.Drawing.Color.Transparent;
            this.comboFastCopy.文本 = "FastCopy.exe";
            this.comboFastCopy.边框色 = System.Drawing.Color.Gray;
            this.comboFastCopy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboCmd
            // 
            this.comboCmd.AutoSize = true;
            this.comboCmd.BackColor = System.Drawing.Color.Transparent;
            this.comboCmd.Checked = true;
            this.comboCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCmd.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCmd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboCmd.Location = new System.Drawing.Point(111, 26);
            this.comboCmd.MaximumSize = new System.Drawing.Size(77, 20);
            this.comboCmd.MinimumSize = new System.Drawing.Size(77, 20);
            this.comboCmd.Name = "comboCmd";
            this.comboCmd.Size = new System.Drawing.Size(77, 20);
            this.comboCmd.TabIndex = 33;
            this.comboCmd.Text = "cmd.exe";
            this.comboCmd.勾选符号色 = System.Drawing.Color.Silver;
            this.comboCmd.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboCmd.描边颜色 = System.Drawing.Color.Transparent;
            this.comboCmd.文本 = "cmd.exe";
            this.comboCmd.边框色 = System.Drawing.Color.Gray;
            this.comboCmd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboPythonw
            // 
            this.comboPythonw.AutoSize = true;
            this.comboPythonw.BackColor = System.Drawing.Color.Transparent;
            this.comboPythonw.Checked = true;
            this.comboPythonw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPythonw.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPythonw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboPythonw.Location = new System.Drawing.Point(199, 26);
            this.comboPythonw.MaximumSize = new System.Drawing.Size(108, 20);
            this.comboPythonw.MinimumSize = new System.Drawing.Size(108, 20);
            this.comboPythonw.Name = "comboPythonw";
            this.comboPythonw.Size = new System.Drawing.Size(108, 20);
            this.comboPythonw.TabIndex = 32;
            this.comboPythonw.Text = "pythonw.exe";
            this.comboPythonw.勾选符号色 = System.Drawing.Color.Silver;
            this.comboPythonw.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboPythonw.描边颜色 = System.Drawing.Color.Transparent;
            this.comboPythonw.文本 = "pythonw.exe";
            this.comboPythonw.边框色 = System.Drawing.Color.Gray;
            this.comboPythonw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboHQ
            // 
            this.comboHQ.AutoSize = true;
            this.comboHQ.BackColor = System.Drawing.Color.Transparent;
            this.comboHQ.Checked = true;
            this.comboHQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboHQ.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboHQ.Location = new System.Drawing.Point(4, 4);
            this.comboHQ.MaximumSize = new System.Drawing.Size(101, 21);
            this.comboHQ.MinimumSize = new System.Drawing.Size(101, 21);
            this.comboHQ.Name = "comboHQ";
            this.comboHQ.Size = new System.Drawing.Size(101, 21);
            this.comboHQ.TabIndex = 31;
            this.comboHQ.Text = "总控GM.exe";
            this.comboHQ.勾选符号色 = System.Drawing.Color.Silver;
            this.comboHQ.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboHQ.描边颜色 = System.Drawing.Color.Transparent;
            this.comboHQ.文本 = "总控GM.exe";
            this.comboHQ.边框色 = System.Drawing.Color.Gray;
            this.comboHQ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboAdb
            // 
            this.comboAdb.AutoSize = true;
            this.comboAdb.BackColor = System.Drawing.Color.Transparent;
            this.comboAdb.Checked = true;
            this.comboAdb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAdb.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAdb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboAdb.Location = new System.Drawing.Point(111, 4);
            this.comboAdb.MaximumSize = new System.Drawing.Size(77, 20);
            this.comboAdb.MinimumSize = new System.Drawing.Size(77, 20);
            this.comboAdb.Name = "comboAdb";
            this.comboAdb.Size = new System.Drawing.Size(77, 20);
            this.comboAdb.TabIndex = 30;
            this.comboAdb.Text = "adb.exe";
            this.comboAdb.勾选符号色 = System.Drawing.Color.Silver;
            this.comboAdb.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboAdb.描边颜色 = System.Drawing.Color.Transparent;
            this.comboAdb.文本 = "adb.exe";
            this.comboAdb.边框色 = System.Drawing.Color.Gray;
            this.comboAdb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboPython
            // 
            this.comboPython.AutoSize = true;
            this.comboPython.BackColor = System.Drawing.Color.Transparent;
            this.comboPython.Checked = true;
            this.comboPython.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPython.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPython.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboPython.Location = new System.Drawing.Point(199, 4);
            this.comboPython.MaximumSize = new System.Drawing.Size(100, 20);
            this.comboPython.MinimumSize = new System.Drawing.Size(100, 20);
            this.comboPython.Name = "comboPython";
            this.comboPython.Size = new System.Drawing.Size(100, 20);
            this.comboPython.TabIndex = 29;
            this.comboPython.Text = "python.exe";
            this.comboPython.勾选符号色 = System.Drawing.Color.Silver;
            this.comboPython.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboPython.描边颜色 = System.Drawing.Color.Transparent;
            this.comboPython.文本 = "python.exe";
            this.comboPython.边框色 = System.Drawing.Color.Gray;
            this.comboPython.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboBranch
            // 
            this.comboBranch.AutoSize = true;
            this.comboBranch.BackColor = System.Drawing.Color.Transparent;
            this.comboBranch.Checked = true;
            this.comboBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBranch.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBranch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBranch.Location = new System.Drawing.Point(4, 26);
            this.comboBranch.MaximumSize = new System.Drawing.Size(101, 21);
            this.comboBranch.MinimumSize = new System.Drawing.Size(101, 21);
            this.comboBranch.Name = "comboBranch";
            this.comboBranch.Size = new System.Drawing.Size(101, 21);
            this.comboBranch.TabIndex = 28;
            this.comboBranch.Text = "分控GM.exe";
            this.comboBranch.勾选符号色 = System.Drawing.Color.Silver;
            this.comboBranch.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboBranch.描边颜色 = System.Drawing.Color.Transparent;
            this.comboBranch.文本 = "分控GM.exe";
            this.comboBranch.边框色 = System.Drawing.Color.Gray;
            this.comboBranch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // IpPanel
            // 
            this.IpPanel.BackColor = System.Drawing.Color.Transparent;
            this.IpPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IpPanel.BackgroundImage")));
            this.IpPanel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpPanel.ForeColor = System.Drawing.Color.White;
            this.IpPanel.Location = new System.Drawing.Point(13, 72);
            this.IpPanel.Name = "IpPanel";
            // 
            // IpPanel.Panel1
            // 
            this.IpPanel.Panel.BackColor = System.Drawing.Color.Transparent;
            this.IpPanel.Panel.Controls.Add(this.comboIP105);
            this.IpPanel.Panel.Controls.Add(this.comboIP106);
            this.IpPanel.Panel.Controls.Add(this.comboIP23);
            this.IpPanel.Panel.Location = new System.Drawing.Point(3, 24);
            this.IpPanel.Panel.Name = "Panel1";
            this.IpPanel.Panel.Size = new System.Drawing.Size(145, 69);
            this.IpPanel.Panel.TabIndex = 1;
            this.IpPanel.Panel.边框颜色 = System.Drawing.Color.Empty;
            this.IpPanel.ShowBorder = true;
            this.IpPanel.Size = new System.Drawing.Size(151, 96);
            this.IpPanel.TabIndex = 4;
            this.IpPanel.Text = "IP列表";
            this.IpPanel.TitleBackColor = System.Drawing.Color.Silver;
            this.IpPanel.关闭确认 = false;
            this.IpPanel.可关闭 = false;
            this.IpPanel.可折叠 = false;
            this.IpPanel.右圆角 = 0F;
            this.IpPanel.填充色 = System.Drawing.Color.Transparent;
            this.IpPanel.左圆角 = 0F;
            this.IpPanel.折叠状态 = DSControls.DS分组容器.状态.展开;
            this.IpPanel.标题文字描边 = true;
            this.IpPanel.标题文字描边颜色 = System.Drawing.Color.Black;
            this.IpPanel.渐变强度百分比 = 0.1F;
            this.IpPanel.点击关闭时 = DSControls.DS分组容器.关闭操作.关闭;
            this.IpPanel.背景色透明度 = 1F;
            this.IpPanel.锚定另一个 = null;
            this.IpPanel.锚定间距 = 10;
            this.IpPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboIP105
            // 
            this.comboIP105.AutoSize = true;
            this.comboIP105.BackColor = System.Drawing.Color.Transparent;
            this.comboIP105.Checked = true;
            this.comboIP105.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboIP105.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIP105.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboIP105.Location = new System.Drawing.Point(7, 5);
            this.comboIP105.MaximumSize = new System.Drawing.Size(132, 20);
            this.comboIP105.MinimumSize = new System.Drawing.Size(132, 20);
            this.comboIP105.Name = "comboIP105";
            this.comboIP105.Size = new System.Drawing.Size(132, 20);
            this.comboIP105.TabIndex = 29;
            this.comboIP105.Text = "192.168.64.105";
            this.comboIP105.勾选符号色 = System.Drawing.Color.Silver;
            this.comboIP105.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboIP105.描边颜色 = System.Drawing.Color.Transparent;
            this.comboIP105.文本 = "192.168.64.105";
            this.comboIP105.边框色 = System.Drawing.Color.Gray;
            this.comboIP105.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboIP106
            // 
            this.comboIP106.AutoSize = true;
            this.comboIP106.BackColor = System.Drawing.Color.Transparent;
            this.comboIP106.Checked = true;
            this.comboIP106.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboIP106.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIP106.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboIP106.Location = new System.Drawing.Point(7, 25);
            this.comboIP106.MaximumSize = new System.Drawing.Size(132, 20);
            this.comboIP106.MinimumSize = new System.Drawing.Size(132, 20);
            this.comboIP106.Name = "comboIP106";
            this.comboIP106.Size = new System.Drawing.Size(132, 20);
            this.comboIP106.TabIndex = 28;
            this.comboIP106.Text = "192.168.64.106";
            this.comboIP106.勾选符号色 = System.Drawing.Color.Silver;
            this.comboIP106.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboIP106.描边颜色 = System.Drawing.Color.Transparent;
            this.comboIP106.文本 = "192.168.64.106";
            this.comboIP106.边框色 = System.Drawing.Color.Gray;
            this.comboIP106.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // comboIP23
            // 
            this.comboIP23.AutoSize = true;
            this.comboIP23.BackColor = System.Drawing.Color.Transparent;
            this.comboIP23.Checked = true;
            this.comboIP23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboIP23.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIP23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboIP23.Location = new System.Drawing.Point(7, 45);
            this.comboIP23.MaximumSize = new System.Drawing.Size(124, 20);
            this.comboIP23.MinimumSize = new System.Drawing.Size(124, 20);
            this.comboIP23.Name = "comboIP23";
            this.comboIP23.Size = new System.Drawing.Size(124, 20);
            this.comboIP23.TabIndex = 27;
            this.comboIP23.Text = "192.168.64.23";
            this.comboIP23.勾选符号色 = System.Drawing.Color.Silver;
            this.comboIP23.勾选符号高亮色 = System.Drawing.Color.White;
            this.comboIP23.描边颜色 = System.Drawing.Color.Transparent;
            this.comboIP23.文本 = "192.168.64.23";
            this.comboIP23.边框色 = System.Drawing.Color.Gray;
            this.comboIP23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobileBox.Properties.Resources.Settings_Switch_48px_1188508_easyicon_net;
            this.pictureBox1.Location = new System.Drawing.Point(198, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseMove);
            // 
            // FormSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 310);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.examineButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.coursePanel);
            this.Controls.Add(this.IpPanel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSwitch";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "                                  FormSwitch";
            this.coursePanel.Panel.ResumeLayout(false);
            this.coursePanel.Panel.PerformLayout();
            this.coursePanel.ResumeLayout(false);
            this.IpPanel.Panel.ResumeLayout(false);
            this.IpPanel.Panel.PerformLayout();
            this.IpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DSControls.DS分组容器 IpPanel;
        private DSControls.DS分组容器 coursePanel;
        private System.Windows.Forms.TextBox logTextBox;
        private DSControls.DS复选框 comboIP23;
        private DSControls.DS复选框 comboIP105;
        private DSControls.DS复选框 comboIP106;
        private DSControls.DS复选框 comboPythonw;
        private DSControls.DS复选框 comboHQ;
        private DSControls.DS复选框 comboAdb;
        private DSControls.DS复选框 comboPython;
        private DSControls.DS复选框 comboBranch;
        private DSControls.DS复选框 comboFastCopy;
        private DSControls.DS复选框 comboCmd;
        private System.Windows.Forms.Button examineButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button killButton;
    }
}