namespace MobileBox
{
    partial class FormCopy
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCopy));
			this.projectComboBox = new MetroFramework.Controls.MetroComboBox();
			this.QuickSwitch = new DSControls.DS开关();
			this.useSwitch = new DSControls.DS开关();
			this.restSwitch = new DSControls.DS开关();
			this.ds = new DSControls.DS标签();
			this.dS标签1 = new DSControls.DS标签();
			this.dS标签2 = new DSControls.DS标签();
			this.dS标签3 = new DSControls.DS标签();
			this.dS标签5 = new DSControls.DS标签();
			this.NewBaseTextBox = new System.Windows.Forms.TextBox();
			this.ScriptTextBox = new System.Windows.Forms.TextBox();
			this.logTextBox = new System.Windows.Forms.TextBox();
			this.dS进度条1 = new DSControls.DS进度条();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.startButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// projectComboBox
			// 
			this.projectComboBox.FormattingEnabled = true;
			this.projectComboBox.ItemHeight = 23;
			this.projectComboBox.Items.AddRange(new object[] {
            "---请选择游戏项目-----",
            "简体魔域  my",
            "先锋魔域  xf",
            "英文魔域  enmy",
            "魔域互通 my",
            "手机魔域  init_ndsdk",
            "西山居魔域  init_xsj",
            "简体征服 cnzf",
            "--------特色服------------",
            "怀旧魔域 hjmy",
            "魔域时间版 sjbmy",
            "boos版魔域 bossmy",
            "幻兽特色服 tsfhs",
            "千面特色服 tsfqm",
            "战士特色服 myzs",
            "新服特色服 new"});
			this.projectComboBox.Location = new System.Drawing.Point(32, 19);
			this.projectComboBox.Name = "projectComboBox";
			this.projectComboBox.Size = new System.Drawing.Size(167, 29);
			this.projectComboBox.TabIndex = 2;
			this.projectComboBox.UseSelectable = true;
			this.projectComboBox.SelectionChangeCommitted += new System.EventHandler(this.projectComboBox_SelectionChangeCommitted);
			// 
			// QuickSwitch
			// 
			this.QuickSwitch.BackColor = System.Drawing.Color.Transparent;
			this.QuickSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.QuickSwitch.Location = new System.Drawing.Point(310, 86);
			this.QuickSwitch.Name = "QuickSwitch";
			this.QuickSwitch.Size = new System.Drawing.Size(63, 23);
			this.QuickSwitch.TabIndex = 6;
			this.QuickSwitch.圆角 = 8;
			this.QuickSwitch.开关状态 = DSControls.DS开关.状态.OFF;
			this.QuickSwitch.渐变 = true;
			this.QuickSwitch.状态OFF文本 = "关闭";
			this.QuickSwitch.状态OFF文本颜色 = System.Drawing.Color.Black;
			this.QuickSwitch.状态ON文本 = "开启";
			this.QuickSwitch.状态ON文本颜色 = System.Drawing.Color.White;
			this.QuickSwitch.绘制到背景 = false;
			this.QuickSwitch.背景色 = System.Drawing.Color.White;
			this.QuickSwitch.边框色 = System.Drawing.Color.DarkGray;
			this.QuickSwitch.颜色OFF = System.Drawing.Color.Silver;
			this.QuickSwitch.颜色ON = System.Drawing.Color.DodgerBlue;
			this.QuickSwitch.颜色未知 = System.Drawing.Color.Silver;
			// 
			// useSwitch
			// 
			this.useSwitch.BackColor = System.Drawing.Color.Transparent;
			this.useSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.useSwitch.Location = new System.Drawing.Point(473, 86);
			this.useSwitch.Name = "useSwitch";
			this.useSwitch.Size = new System.Drawing.Size(64, 23);
			this.useSwitch.TabIndex = 7;
			this.useSwitch.圆角 = 8;
			this.useSwitch.开关状态 = DSControls.DS开关.状态.OFF;
			this.useSwitch.渐变 = true;
			this.useSwitch.状态OFF文本 = "关闭";
			this.useSwitch.状态OFF文本颜色 = System.Drawing.Color.Black;
			this.useSwitch.状态ON文本 = "开启";
			this.useSwitch.状态ON文本颜色 = System.Drawing.Color.White;
			this.useSwitch.绘制到背景 = false;
			this.useSwitch.背景色 = System.Drawing.Color.White;
			this.useSwitch.边框色 = System.Drawing.Color.DarkGray;
			this.useSwitch.颜色OFF = System.Drawing.Color.Silver;
			this.useSwitch.颜色ON = System.Drawing.Color.DodgerBlue;
			this.useSwitch.颜色未知 = System.Drawing.Color.Silver;
			// 
			// restSwitch
			// 
			this.restSwitch.BackColor = System.Drawing.Color.Transparent;
			this.restSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.restSwitch.Location = new System.Drawing.Point(628, 86);
			this.restSwitch.Name = "restSwitch";
			this.restSwitch.Size = new System.Drawing.Size(64, 23);
			this.restSwitch.TabIndex = 8;
			this.restSwitch.圆角 = 8;
			this.restSwitch.开关状态 = DSControls.DS开关.状态.OFF;
			this.restSwitch.渐变 = true;
			this.restSwitch.状态OFF文本 = "关闭";
			this.restSwitch.状态OFF文本颜色 = System.Drawing.Color.Black;
			this.restSwitch.状态ON文本 = "开启";
			this.restSwitch.状态ON文本颜色 = System.Drawing.Color.White;
			this.restSwitch.绘制到背景 = false;
			this.restSwitch.背景色 = System.Drawing.Color.White;
			this.restSwitch.边框色 = System.Drawing.Color.DarkGray;
			this.restSwitch.颜色OFF = System.Drawing.Color.Silver;
			this.restSwitch.颜色ON = System.Drawing.Color.DodgerBlue;
			this.restSwitch.颜色未知 = System.Drawing.Color.Silver;
			// 
			// ds
			// 
			this.ds.BackColor = System.Drawing.Color.Transparent;
			this.ds.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ds.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.ds.Location = new System.Drawing.Point(550, 85);
			this.ds.Name = "ds";
			this.ds.Size = new System.Drawing.Size(65, 24);
			this.ds.TabIndex = 12;
			this.ds.Text = "其他数据";
			this.ds.偏移 = new System.Drawing.Point(0, 5);
			this.ds.处理访问键 = false;
			this.ds.字体渲染模式 = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.ds.描边 = false;
			this.ds.描边颜色 = System.Drawing.Color.Black;
			this.ds.绘制到背景 = false;
			this.ds.自动高度 = false;
			this.ds.行间距 = 2;
			this.ds.解析彩色代码 = true;
			this.ds.链接下划线 = DSControls.图形图像.彩色文字图像._下划线.始终显示;
			this.ds.链接下划线颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.ds.链接热点颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.ds.链接颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			// 
			// dS标签1
			// 
			this.dS标签1.BackColor = System.Drawing.Color.Transparent;
			this.dS标签1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dS标签1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.dS标签1.Location = new System.Drawing.Point(386, 84);
			this.dS标签1.Name = "dS标签1";
			this.dS标签1.Size = new System.Drawing.Size(74, 26);
			this.dS标签1.TabIndex = 13;
			this.dS标签1.Text = "用户数据";
			this.dS标签1.偏移 = new System.Drawing.Point(0, 5);
			this.dS标签1.处理访问键 = false;
			this.dS标签1.字体渲染模式 = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.dS标签1.描边 = false;
			this.dS标签1.描边颜色 = System.Drawing.Color.Black;
			this.dS标签1.绘制到背景 = false;
			this.dS标签1.自动高度 = false;
			this.dS标签1.行间距 = 2;
			this.dS标签1.解析彩色代码 = true;
			this.dS标签1.链接下划线 = DSControls.图形图像.彩色文字图像._下划线.始终显示;
			this.dS标签1.链接下划线颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.dS标签1.链接热点颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.dS标签1.链接颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			// 
			// dS标签2
			// 
			this.dS标签2.BackColor = System.Drawing.Color.Transparent;
			this.dS标签2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dS标签2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.dS标签2.Location = new System.Drawing.Point(224, 85);
			this.dS标签2.Name = "dS标签2";
			this.dS标签2.Size = new System.Drawing.Size(73, 24);
			this.dS标签2.TabIndex = 14;
			this.dS标签2.Text = "快测脚本";
			this.dS标签2.偏移 = new System.Drawing.Point(0, 5);
			this.dS标签2.处理访问键 = false;
			this.dS标签2.字体渲染模式 = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.dS标签2.描边 = false;
			this.dS标签2.描边颜色 = System.Drawing.Color.Black;
			this.dS标签2.绘制到背景 = false;
			this.dS标签2.自动高度 = false;
			this.dS标签2.行间距 = 2;
			this.dS标签2.解析彩色代码 = true;
			this.dS标签2.链接下划线 = DSControls.图形图像.彩色文字图像._下划线.始终显示;
			this.dS标签2.链接下划线颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.dS标签2.链接热点颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.dS标签2.链接颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			// 
			// dS标签3
			// 
			this.dS标签3.BackColor = System.Drawing.Color.Transparent;
			this.dS标签3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dS标签3.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.dS标签3.Location = new System.Drawing.Point(224, 129);
			this.dS标签3.Name = "dS标签3";
			this.dS标签3.Size = new System.Drawing.Size(132, 24);
			this.dS标签3.TabIndex = 15;
			this.dS标签3.Text = "预更新脚本路径：";
			this.dS标签3.偏移 = new System.Drawing.Point(0, 5);
			this.dS标签3.处理访问键 = false;
			this.dS标签3.字体渲染模式 = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.dS标签3.描边 = false;
			this.dS标签3.描边颜色 = System.Drawing.Color.Black;
			this.dS标签3.绘制到背景 = false;
			this.dS标签3.自动高度 = false;
			this.dS标签3.行间距 = 2;
			this.dS标签3.解析彩色代码 = true;
			this.dS标签3.链接下划线 = DSControls.图形图像.彩色文字图像._下划线.始终显示;
			this.dS标签3.链接下划线颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.dS标签3.链接热点颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.dS标签3.链接颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			// 
			// dS标签5
			// 
			this.dS标签5.BackColor = System.Drawing.Color.Transparent;
			this.dS标签5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dS标签5.ForeColor = System.Drawing.Color.Blue;
			this.dS标签5.Location = new System.Drawing.Point(23, 171);
			this.dS标签5.Name = "dS标签5";
			this.dS标签5.Size = new System.Drawing.Size(169, 24);
			this.dS标签5.TabIndex = 18;
			this.dS标签5.Text = "自动生成数据库名称：";
			this.dS标签5.偏移 = new System.Drawing.Point(0, 5);
			this.dS标签5.处理访问键 = false;
			this.dS标签5.字体渲染模式 = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.dS标签5.描边 = false;
			this.dS标签5.描边颜色 = System.Drawing.Color.Black;
			this.dS标签5.绘制到背景 = false;
			this.dS标签5.自动高度 = false;
			this.dS标签5.行间距 = 2;
			this.dS标签5.解析彩色代码 = true;
			this.dS标签5.链接下划线 = DSControls.图形图像.彩色文字图像._下划线.始终显示;
			this.dS标签5.链接下划线颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.dS标签5.链接热点颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.dS标签5.链接颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			// 
			// NewBaseTextBox
			// 
			this.NewBaseTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.NewBaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NewBaseTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewBaseTextBox.Location = new System.Drawing.Point(184, 171);
			this.NewBaseTextBox.Name = "NewBaseTextBox";
			this.NewBaseTextBox.Size = new System.Drawing.Size(339, 24);
			this.NewBaseTextBox.TabIndex = 21;
			// 
			// ScriptTextBox
			// 
			this.ScriptTextBox.AllowDrop = true;
			this.ScriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ScriptTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScriptTextBox.Location = new System.Drawing.Point(348, 129);
			this.ScriptTextBox.Name = "ScriptTextBox";
			this.ScriptTextBox.Size = new System.Drawing.Size(344, 24);
			this.ScriptTextBox.TabIndex = 22;
			this.ScriptTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ScriptTextBox_DragDrop);
			this.ScriptTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ScriptTextBox_DragEnter);
			// 
			// logTextBox
			// 
			this.logTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logTextBox.Location = new System.Drawing.Point(23, 207);
			this.logTextBox.Multiline = true;
			this.logTextBox.Name = "logTextBox";
			this.logTextBox.ReadOnly = true;
			this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.logTextBox.Size = new System.Drawing.Size(669, 121);
			this.logTextBox.TabIndex = 23;
			// 
			// dS进度条1
			// 
			this.dS进度条1.BackColor = System.Drawing.Color.Transparent;
			this.dS进度条1.Cursor = System.Windows.Forms.Cursors.Default;
			this.dS进度条1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dS进度条1.Location = new System.Drawing.Point(23, 334);
			this.dS进度条1.Name = "dS进度条1";
			this.dS进度条1.Size = new System.Drawing.Size(666, 10);
			this.dS进度条1.TabIndex = 24;
			this.dS进度条1.允许手动调整进度 = false;
			this.dS进度条1.光泽强度百分比 = 1F;
			this.dS进度条1.前景颜色 = System.Drawing.Color.CornflowerBlue;
			this.dS进度条1.叠加值 = 0;
			this.dS进度条1.叠加进度颜色 = System.Drawing.Color.PowderBlue;
			this.dS进度条1.圆角 = false;
			this.dS进度条1.底层颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.dS进度条1.当前值 = 0;
			this.dS进度条1.文本描边颜色 = System.Drawing.Color.Black;
			this.dS进度条1.文本颜色 = System.Drawing.Color.White;
			this.dS进度条1.显示叠加进度 = false;
			this.dS进度条1.显示进度文本 = DSControls.DS进度条.进度显示.百分比;
			this.dS进度条1.最大值 = 100;
			this.dS进度条1.最小值 = 0;
			this.dS进度条1.绘制到背景 = false;
			this.dS进度条1.边框色 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::MobileBox.Properties.Resources.type3;
			this.pictureBox7.Location = new System.Drawing.Point(145, 65);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(72, 38);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 30;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::MobileBox.Properties.Resources.type11;
			this.pictureBox6.Location = new System.Drawing.Point(86, 66);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(46, 37);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 29;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::MobileBox.Properties.Resources.type13;
			this.pictureBox5.Location = new System.Drawing.Point(32, 63);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(48, 46);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 28;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::MobileBox.Properties.Resources.type4;
			this.pictureBox4.Location = new System.Drawing.Point(145, 108);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(63, 57);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 27;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MobileBox.Properties.Resources.type2;
			this.pictureBox3.Location = new System.Drawing.Point(82, 108);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(57, 57);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 26;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MobileBox.Properties.Resources.type1;
			this.pictureBox2.Location = new System.Drawing.Point(32, 120);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(44, 45);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 25;
			this.pictureBox2.TabStop = false;
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.Transparent;
			this.startButton.FlatAppearance.BorderSize = 0;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.startButton.Image = global::MobileBox.Properties.Resources.start_32px_1169786_easyicon_net;
			this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.startButton.Location = new System.Drawing.Point(542, 161);
			this.startButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(150, 38);
			this.startButton.TabIndex = 20;
			this.startButton.Text = "开始执行";
			this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MobileBox.Properties.Resources.copy_32px_1230182_easyicon1;
			this.pictureBox1.Location = new System.Drawing.Point(279, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 37);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// FormCopy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(714, 362);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.dS进度条1);
			this.Controls.Add(this.logTextBox);
			this.Controls.Add(this.ScriptTextBox);
			this.Controls.Add(this.NewBaseTextBox);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.dS标签5);
			this.Controls.Add(this.dS标签3);
			this.Controls.Add(this.dS标签2);
			this.Controls.Add(this.dS标签1);
			this.Controls.Add(this.ds);
			this.Controls.Add(this.restSwitch);
			this.Controls.Add(this.useSwitch);
			this.Controls.Add(this.QuickSwitch);
			this.Controls.Add(this.projectComboBox);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCopy";
			this.Text = "                                           FormCopy";
			this.Load += new System.EventHandler(this.FormCopy_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormCopy_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox projectComboBox;
        private DSControls.DS开关 restSwitch;
        private DSControls.DS开关 useSwitch;
        private DSControls.DS开关 QuickSwitch;
        private DSControls.DS标签 ds;
        private DSControls.DS标签 dS标签1;
        private DSControls.DS标签 dS标签2;
        private DSControls.DS标签 dS标签3;
        private DSControls.DS标签 dS标签5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox NewBaseTextBox;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private DSControls.DS进度条 dS进度条1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}