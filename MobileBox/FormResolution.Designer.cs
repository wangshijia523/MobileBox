namespace MobileBox
{
    partial class FormResolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResolution));
            DSControls.DS按钮.进度条 进度条1 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像1 = new DSControls.DS按钮.自定义状态图像();
            DSControls.DS按钮.进度条 进度条2 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像2 = new DSControls.DS按钮.自定义状态图像();
            DSControls.DS按钮.进度条 进度条3 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像3 = new DSControls.DS按钮.自定义状态图像();
            this.dS圆形指示灯1 = new DSControls.DS圆形指示灯();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.inputText = new MetroFramework.Controls.MetroTextBox();
            this.outText = new MetroFramework.Controls.MetroTextBox();
            this.dS标签2 = new DSControls.DS标签();
            this.dS标签1 = new DSControls.DS标签();
            this.dS数字框1 = new DSControls.DS数字框();
            this.shrinkBtton = new DSControls.DS按钮();
            this.batchButton = new DSControls.DS按钮();
            this.magnifyButton = new DSControls.DS按钮();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dS标签3 = new DSControls.DS标签();
            ((System.ComponentModel.ISupportInitialize)(this.dS数字框1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS圆形指示灯1
            // 
            this.dS圆形指示灯1.BackColor = System.Drawing.Color.Transparent;
            this.dS圆形指示灯1.ForeColor = System.Drawing.Color.White;
            this.dS圆形指示灯1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dS圆形指示灯1.Location = new System.Drawing.Point(447, 167);
            this.dS圆形指示灯1.Name = "dS圆形指示灯1";
            this.dS圆形指示灯1.Size = new System.Drawing.Size(52, 52);
            this.dS圆形指示灯1.TabIndex = 0;
            this.dS圆形指示灯1.呼吸效果 = false;
            this.dS圆形指示灯1.指示灯颜色 = System.Drawing.Color.Red;
            this.dS圆形指示灯1.指示状态 = DSControls.DS圆形指示灯.状态.OFF;
            this.dS圆形指示灯1.边框粗细 = DSControls.DS圆形指示灯.边框线条.默认;
            this.dS圆形指示灯1.边框颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dS圆形指示灯1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(308, 222);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(191, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "当灯亮起时表示正在工作状态";
            this.metroLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // inputText
            // 
            this.inputText.AllowDrop = true;
            // 
            // 
            // 
            this.inputText.CustomButton.Image = null;
            this.inputText.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.inputText.CustomButton.Name = "";
            this.inputText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputText.CustomButton.TabIndex = 1;
            this.inputText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputText.CustomButton.UseSelectable = true;
            this.inputText.CustomButton.Visible = false;
            this.inputText.Lines = new string[0];
            this.inputText.Location = new System.Drawing.Point(100, 81);
            this.inputText.MaxLength = 32767;
            this.inputText.Name = "inputText";
            this.inputText.PasswordChar = '\0';
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputText.SelectedText = "";
            this.inputText.SelectionLength = 0;
            this.inputText.SelectionStart = 0;
            this.inputText.ShortcutsEnabled = true;
            this.inputText.Size = new System.Drawing.Size(325, 23);
            this.inputText.TabIndex = 7;
            this.inputText.UseSelectable = true;
            this.inputText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inputText.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputText_DragDrop);
            this.inputText.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputText_DragEnter);
            this.inputText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // outText
            // 
            this.outText.AllowDrop = true;
            // 
            // 
            // 
            this.outText.CustomButton.Image = null;
            this.outText.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.outText.CustomButton.Name = "";
            this.outText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.outText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.outText.CustomButton.TabIndex = 1;
            this.outText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.outText.CustomButton.UseSelectable = true;
            this.outText.CustomButton.Visible = false;
            this.outText.Lines = new string[0];
            this.outText.Location = new System.Drawing.Point(100, 110);
            this.outText.MaxLength = 32767;
            this.outText.Name = "outText";
            this.outText.PasswordChar = '\0';
            this.outText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outText.SelectedText = "";
            this.outText.SelectionLength = 0;
            this.outText.SelectionStart = 0;
            this.outText.ShortcutsEnabled = true;
            this.outText.Size = new System.Drawing.Size(325, 23);
            this.outText.TabIndex = 8;
            this.outText.UseSelectable = true;
            this.outText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.outText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.outText.DragDrop += new System.Windows.Forms.DragEventHandler(this.outText_DragDrop);
            this.outText.DragEnter += new System.Windows.Forms.DragEventHandler(this.outText_DragEnter);
            this.outText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // dS标签2
            // 
            this.dS标签2.BackColor = System.Drawing.Color.Transparent;
            this.dS标签2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dS标签2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dS标签2.Location = new System.Drawing.Point(7, 107);
            this.dS标签2.Name = "dS标签2";
            this.dS标签2.Size = new System.Drawing.Size(102, 24);
            this.dS标签2.TabIndex = 5;
            this.dS标签2.Text = "目标文件夹:";
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
            this.dS标签2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // dS标签1
            // 
            this.dS标签1.BackColor = System.Drawing.Color.Transparent;
            this.dS标签1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dS标签1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dS标签1.Location = new System.Drawing.Point(22, 81);
            this.dS标签1.Name = "dS标签1";
            this.dS标签1.Size = new System.Drawing.Size(87, 24);
            this.dS标签1.TabIndex = 4;
            this.dS标签1.Text = "源文件夹:";
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
            this.dS标签1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // dS数字框1
            // 
            this.dS数字框1.DecimalPlaces = 1;
            this.dS数字框1.Location = new System.Drawing.Point(100, 139);
            this.dS数字框1.Name = "dS数字框1";
            this.dS数字框1.Size = new System.Drawing.Size(120, 21);
            this.dS数字框1.TabIndex = 12;
            this.dS数字框1.箭头色 = System.Drawing.Color.DodgerBlue;
            this.dS数字框1.箭头高亮色 = System.Drawing.Color.White;
            this.dS数字框1.边框色 = System.Drawing.Color.DodgerBlue;
            // 
            // shrinkBtton
            // 
            this.shrinkBtton.BackColor = System.Drawing.Color.Transparent;
            this.shrinkBtton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shrinkBtton.BackgroundImage")));
            this.shrinkBtton.Cursor = System.Windows.Forms.Cursors.Default;
            this.shrinkBtton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.shrinkBtton.ForeColor = System.Drawing.Color.White;
            this.shrinkBtton.Location = new System.Drawing.Point(168, 176);
            this.shrinkBtton.Margin = new System.Windows.Forms.Padding(1);
            this.shrinkBtton.Name = "shrinkBtton";
            this.shrinkBtton.Size = new System.Drawing.Size(85, 25);
            this.shrinkBtton.TabIndex = 11;
            this.shrinkBtton.Text = "缩小";
            this.shrinkBtton.光泽 = true;
            this.shrinkBtton.图像 = global::MobileBox.Properties.Resources.down_arrow_32px_1236472_easyicon_net;
            this.shrinkBtton.圆角角度 = 8;
            this.shrinkBtton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条1.指示进度 = 0F;
            进度条1.进度条宽度 = 5;
            进度条1.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.shrinkBtton.指示进度条 = 进度条1;
            this.shrinkBtton.文字描边 = System.Drawing.SystemColors.ActiveCaptionText;
            this.shrinkBtton.文本 = "缩小";
            this.shrinkBtton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.shrinkBtton.文本水平偏移 = 0;
            this.shrinkBtton.渐变 = true;
            this.shrinkBtton.禁用时灰度显示 = true;
            this.shrinkBtton.禁用时透明度 = 0.3F;
            this.shrinkBtton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.shrinkBtton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像1.按下 = null;
            自定义状态图像1.禁用 = null;
            自定义状态图像1.高亮 = null;
            自定义状态图像1.默认 = null;
            this.shrinkBtton.自定义图像 = 自定义状态图像1;
            this.shrinkBtton.贴图 = null;
            this.shrinkBtton.贴图切割边距.上 = 0;
            this.shrinkBtton.贴图切割边距.下 = 0;
            this.shrinkBtton.贴图切割边距.右 = 0;
            this.shrinkBtton.贴图切割边距.左 = 0;
            this.shrinkBtton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.shrinkBtton.边框颜色 = System.Drawing.SystemColors.WindowText;
            this.shrinkBtton.选定 = false;
            this.shrinkBtton.选定模式 = false;
            this.shrinkBtton.选定颜色 = System.Drawing.Color.SteelBlue;
            this.shrinkBtton.透明区域不引发鼠标事件 = true;
            this.shrinkBtton.透明度 = 1F;
            this.shrinkBtton.附加内容字体 = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shrinkBtton.附加说明 = "";
            this.shrinkBtton.附加说明使用彩色引擎 = false;
            this.shrinkBtton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.shrinkBtton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.shrinkBtton.附加说明颜色 = System.Drawing.Color.Gray;
            this.shrinkBtton.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.shrinkBtton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.shrinkBtton_ButtonClick);
            this.shrinkBtton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // batchButton
            // 
            this.batchButton.BackColor = System.Drawing.Color.Transparent;
            this.batchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("batchButton.BackgroundImage")));
            this.batchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.batchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.batchButton.ForeColor = System.Drawing.Color.White;
            this.batchButton.Location = new System.Drawing.Point(323, 176);
            this.batchButton.Margin = new System.Windows.Forms.Padding(1);
            this.batchButton.Name = "batchButton";
            this.batchButton.Size = new System.Drawing.Size(102, 25);
            this.batchButton.TabIndex = 10;
            this.batchButton.Text = "批量放大";
            this.batchButton.光泽 = true;
            this.batchButton.图像 = global::MobileBox.Properties.Resources.up_arrow_32px_1236473_easyicon_net;
            this.batchButton.圆角角度 = 8;
            this.batchButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条2.指示进度 = 0F;
            进度条2.进度条宽度 = 5;
            进度条2.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.batchButton.指示进度条 = 进度条2;
            this.batchButton.文字描边 = System.Drawing.SystemColors.ActiveCaptionText;
            this.batchButton.文本 = "批量放大";
            this.batchButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.batchButton.文本水平偏移 = 0;
            this.batchButton.渐变 = true;
            this.batchButton.禁用时灰度显示 = true;
            this.batchButton.禁用时透明度 = 0.3F;
            this.batchButton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.batchButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像2.按下 = null;
            自定义状态图像2.禁用 = null;
            自定义状态图像2.高亮 = null;
            自定义状态图像2.默认 = null;
            this.batchButton.自定义图像 = 自定义状态图像2;
            this.batchButton.贴图 = null;
            this.batchButton.贴图切割边距.上 = 0;
            this.batchButton.贴图切割边距.下 = 0;
            this.batchButton.贴图切割边距.右 = 0;
            this.batchButton.贴图切割边距.左 = 0;
            this.batchButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.batchButton.边框颜色 = System.Drawing.SystemColors.WindowText;
            this.batchButton.选定 = true;
            this.batchButton.选定模式 = true;
            this.batchButton.选定颜色 = System.Drawing.Color.SteelBlue;
            this.batchButton.透明区域不引发鼠标事件 = true;
            this.batchButton.透明度 = 1F;
            this.batchButton.附加内容字体 = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.batchButton.附加说明 = "";
            this.batchButton.附加说明使用彩色引擎 = false;
            this.batchButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.batchButton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.batchButton.附加说明颜色 = System.Drawing.Color.Gray;
            this.batchButton.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.batchButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.batchButton_ButtonClick);
            this.batchButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // magnifyButton
            // 
            this.magnifyButton.BackColor = System.Drawing.Color.Transparent;
            this.magnifyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("magnifyButton.BackgroundImage")));
            this.magnifyButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.magnifyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.magnifyButton.ForeColor = System.Drawing.Color.White;
            this.magnifyButton.Location = new System.Drawing.Point(55, 176);
            this.magnifyButton.Margin = new System.Windows.Forms.Padding(1);
            this.magnifyButton.Name = "magnifyButton";
            this.magnifyButton.Size = new System.Drawing.Size(83, 25);
            this.magnifyButton.TabIndex = 9;
            this.magnifyButton.Text = "放大";
            this.magnifyButton.光泽 = true;
            this.magnifyButton.图像 = global::MobileBox.Properties.Resources.up_arrow_32px_1236474_easyicon_net;
            this.magnifyButton.圆角角度 = 8;
            this.magnifyButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条3.指示进度 = 0F;
            进度条3.进度条宽度 = 5;
            进度条3.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.magnifyButton.指示进度条 = 进度条3;
            this.magnifyButton.文字描边 = System.Drawing.SystemColors.ActiveCaptionText;
            this.magnifyButton.文本 = "放大";
            this.magnifyButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.magnifyButton.文本水平偏移 = 0;
            this.magnifyButton.渐变 = true;
            this.magnifyButton.禁用时灰度显示 = true;
            this.magnifyButton.禁用时透明度 = 0.3F;
            this.magnifyButton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.magnifyButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像3.按下 = null;
            自定义状态图像3.禁用 = null;
            自定义状态图像3.高亮 = null;
            自定义状态图像3.默认 = null;
            this.magnifyButton.自定义图像 = 自定义状态图像3;
            this.magnifyButton.贴图 = null;
            this.magnifyButton.贴图切割边距.上 = 0;
            this.magnifyButton.贴图切割边距.下 = 0;
            this.magnifyButton.贴图切割边距.右 = 0;
            this.magnifyButton.贴图切割边距.左 = 0;
            this.magnifyButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.magnifyButton.边框颜色 = System.Drawing.SystemColors.WindowText;
            this.magnifyButton.选定 = false;
            this.magnifyButton.选定模式 = false;
            this.magnifyButton.选定颜色 = System.Drawing.Color.SteelBlue;
            this.magnifyButton.透明区域不引发鼠标事件 = true;
            this.magnifyButton.透明度 = 1F;
            this.magnifyButton.附加内容字体 = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.magnifyButton.附加说明 = "";
            this.magnifyButton.附加说明使用彩色引擎 = false;
            this.magnifyButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.magnifyButton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.magnifyButton.附加说明颜色 = System.Drawing.Color.Gray;
            this.magnifyButton.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.magnifyButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.magnifyButton_ButtonClick);
            this.magnifyButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobileBox.Properties.Resources.resolution_53_462304409673px_1218196_easyicon_net;
            this.pictureBox1.Location = new System.Drawing.Point(155, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            // 
            // dS标签3
            // 
            this.dS标签3.BackColor = System.Drawing.Color.Transparent;
            this.dS标签3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dS标签3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dS标签3.Location = new System.Drawing.Point(51, 136);
            this.dS标签3.Name = "dS标签3";
            this.dS标签3.Size = new System.Drawing.Size(87, 24);
            this.dS标签3.TabIndex = 13;
            this.dS标签3.Text = "倍率:";
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
            // FormResolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.dS数字框1);
            this.Controls.Add(this.shrinkBtton);
            this.Controls.Add(this.batchButton);
            this.Controls.Add(this.magnifyButton);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.dS标签2);
            this.Controls.Add(this.dS标签1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dS圆形指示灯1);
            this.Controls.Add(this.dS标签3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 250);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "FormResolution";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "                        FormResolution";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.outText_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.outText_DragEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shrinkBtton_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dS数字框1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSControls.DS圆形指示灯 dS圆形指示灯1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox inputText;
        private MetroFramework.Controls.MetroTextBox outText;
        private DSControls.DS标签 dS标签2;
        private DSControls.DS标签 dS标签1;
        private DSControls.DS按钮 magnifyButton;
        private DSControls.DS按钮 batchButton;
        private DSControls.DS按钮 shrinkBtton;
        private DSControls.DS数字框 dS数字框1;
        private DSControls.DS标签 dS标签3;
    }
}