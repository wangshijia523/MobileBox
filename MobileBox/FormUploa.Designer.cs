namespace MobileBox
{
    partial class FormUploa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUploa));
            this.projectComboBox = new MetroFramework.Controls.MetroComboBox();
            this.folderComboBox = new MetroFramework.Controls.MetroComboBox();
            this.versionsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.dS标签2 = new DSControls.DS标签();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.dS进度条21 = new DSControls.DS进度条2();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dS标签1 = new DSControls.DS标签();
            this.dS标签3 = new DSControls.DS标签();
            this.dS标签4 = new DSControls.DS标签();
            this.SourcetTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.ItemHeight = 23;
            this.projectComboBox.Items.AddRange(new object[] {
            "请选择游戏项目",
            "developer",
            "平台控制器",
            "sjmy",
            "xsjmy",
            "myht"});
            this.projectComboBox.Location = new System.Drawing.Point(74, 66);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(125, 29);
            this.projectComboBox.TabIndex = 1;
            this.projectComboBox.UseSelectable = true;
            this.projectComboBox.SelectionChangeCommitted += new System.EventHandler(this.projectComboBox_SelectionChangeCommitted);
            // 
            // folderComboBox
            // 
            this.folderComboBox.Enabled = false;
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.ItemHeight = 23;
            this.folderComboBox.Items.AddRange(new object[] {
            "请选择版本文件夹",
            "case",
            "common",
            "environinit"});
            this.folderComboBox.Location = new System.Drawing.Point(444, 66);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(125, 29);
            this.folderComboBox.TabIndex = 2;
            this.folderComboBox.UseSelectable = true;
            this.folderComboBox.SelectionChangeCommitted += new System.EventHandler(this.folderComboBox_SelectionChangeCommitted);
            // 
            // versionsComboBox
            // 
            this.versionsComboBox.Enabled = false;
            this.versionsComboBox.FormattingEnabled = true;
            this.versionsComboBox.ItemHeight = 23;
            this.versionsComboBox.Items.AddRange(new object[] {
            "请选择游戏版本"});
            this.versionsComboBox.Location = new System.Drawing.Point(259, 66);
            this.versionsComboBox.Name = "versionsComboBox";
            this.versionsComboBox.Size = new System.Drawing.Size(125, 29);
            this.versionsComboBox.TabIndex = 3;
            this.versionsComboBox.UseSelectable = true;
            this.versionsComboBox.SelectionChangeCommitted += new System.EventHandler(this.versionsComboBox_SelectionChangeCommitted);
            // 
            // dS标签2
            // 
            this.dS标签2.BackColor = System.Drawing.Color.Transparent;
            this.dS标签2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dS标签2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dS标签2.Location = new System.Drawing.Point(15, 106);
            this.dS标签2.Name = "dS标签2";
            this.dS标签2.Size = new System.Drawing.Size(70, 24);
            this.dS标签2.TabIndex = 15;
            this.dS标签2.Text = "源目录：";
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
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.Location = new System.Drawing.Point(15, 141);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(563, 87);
            this.logTextBox.TabIndex = 24;
            // 
            // dS进度条21
            // 
            this.dS进度条21.BackColor = System.Drawing.Color.Transparent;
            this.dS进度条21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dS进度条21.BackgroundImage")));
            this.dS进度条21.Location = new System.Drawing.Point(15, 234);
            this.dS进度条21.Name = "dS进度条21";
            this.dS进度条21.Size = new System.Drawing.Size(563, 14);
            this.dS进度条21.TabIndex = 25;
            this.dS进度条21.光泽 = false;
            this.dS进度条21.前景色 = System.Drawing.Color.Gold;
            this.dS进度条21.前景色渐变 = false;
            this.dS进度条21.呈现 = DSControls.DS进度条2.清晰度.清晰;
            this.dS进度条21.当前值 = 10;
            this.dS进度条21.最大值 = 100;
            this.dS进度条21.端样式 = DSControls.DS进度条2.首尾.圆头;
            this.dS进度条21.背景色 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dS进度条21.边线色 = System.Drawing.Color.Black;
            this.dS进度条21.间距 = 1;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Image = global::MobileBox.Properties.Resources.upload_32px_1133673_easyicon_net;
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.Location = new System.Drawing.Point(444, 102);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(134, 31);
            this.startButton.TabIndex = 21;
            this.startButton.Text = "开始上传";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobileBox.Properties.Resources.upload_48px_1204394_easyicon1;
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dS标签1
            // 
            this.dS标签1.BackColor = System.Drawing.Color.Transparent;
            this.dS标签1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dS标签1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dS标签1.Location = new System.Drawing.Point(15, 68);
            this.dS标签1.Name = "dS标签1";
            this.dS标签1.Size = new System.Drawing.Size(58, 24);
            this.dS标签1.TabIndex = 26;
            this.dS标签1.Text = "目录：";
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
            // dS标签3
            // 
            this.dS标签3.BackColor = System.Drawing.Color.Transparent;
            this.dS标签3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dS标签3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dS标签3.Location = new System.Drawing.Point(200, 68);
            this.dS标签3.Name = "dS标签3";
            this.dS标签3.Size = new System.Drawing.Size(58, 24);
            this.dS标签3.TabIndex = 27;
            this.dS标签3.Text = "版本：";
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
            // dS标签4
            // 
            this.dS标签4.BackColor = System.Drawing.Color.Transparent;
            this.dS标签4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dS标签4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dS标签4.Location = new System.Drawing.Point(385, 68);
            this.dS标签4.Name = "dS标签4";
            this.dS标签4.Size = new System.Drawing.Size(58, 24);
            this.dS标签4.TabIndex = 28;
            this.dS标签4.Text = "文件：";
            this.dS标签4.偏移 = new System.Drawing.Point(0, 5);
            this.dS标签4.处理访问键 = false;
            this.dS标签4.字体渲染模式 = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dS标签4.描边 = false;
            this.dS标签4.描边颜色 = System.Drawing.Color.Black;
            this.dS标签4.绘制到背景 = false;
            this.dS标签4.自动高度 = false;
            this.dS标签4.行间距 = 2;
            this.dS标签4.解析彩色代码 = true;
            this.dS标签4.链接下划线 = DSControls.图形图像.彩色文字图像._下划线.始终显示;
            this.dS标签4.链接下划线颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dS标签4.链接热点颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dS标签4.链接颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            // 
            // SourcetTextBox
            // 
            this.SourcetTextBox.AllowDrop = true;
            this.SourcetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourcetTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourcetTextBox.Location = new System.Drawing.Point(74, 107);
            this.SourcetTextBox.Name = "SourcetTextBox";
            this.SourcetTextBox.Size = new System.Drawing.Size(344, 24);
            this.SourcetTextBox.TabIndex = 29;
            this.SourcetTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourcetTextBox_DragDrop);
            this.SourcetTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourcetTextBox_DragEnter);
            // 
            // FormUploa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 262);
            this.Controls.Add(this.SourcetTextBox);
            this.Controls.Add(this.dS进度条21);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.dS标签2);
            this.Controls.Add(this.versionsComboBox);
            this.Controls.Add(this.folderComboBox);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dS标签1);
            this.Controls.Add(this.dS标签3);
            this.Controls.Add(this.dS标签4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUploa";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "                               FormUploa";
            this.Load += new System.EventHandler(this.FormUploa_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormUploa_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox projectComboBox;
        private MetroFramework.Controls.MetroComboBox folderComboBox;
        private MetroFramework.Controls.MetroComboBox versionsComboBox;
        private DSControls.DS标签 dS标签2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox logTextBox;
        private DSControls.DS进度条2 dS进度条21;
        private DSControls.DS标签 dS标签1;
        private DSControls.DS标签 dS标签3;
        private DSControls.DS标签 dS标签4;
        private System.Windows.Forms.TextBox SourcetTextBox;
    }
}