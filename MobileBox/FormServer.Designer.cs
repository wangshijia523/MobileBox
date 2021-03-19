namespace MobileBox
{
    sealed partial class FormServer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
			DSControls.DS按钮.进度条 进度条1 = new DSControls.DS按钮.进度条();
			DSControls.DS按钮.自定义状态图像 自定义状态图像1 = new DSControls.DS按钮.自定义状态图像();
			this.accountButton = new DSControls.DS按钮();
			this.SuspendLayout();
			// 
			// accountButton
			// 
			this.accountButton.BackColor = System.Drawing.Color.Transparent;
			this.accountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountButton.BackgroundImage")));
			this.accountButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.accountButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.accountButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.accountButton.ForeColor = System.Drawing.Color.Black;
			this.accountButton.Location = new System.Drawing.Point(10, 10);
			this.accountButton.Margin = new System.Windows.Forms.Padding(1);
			this.accountButton.Name = "accountButton";
			this.accountButton.Size = new System.Drawing.Size(155, 40);
			this.accountButton.TabIndex = 4;
			this.accountButton.Text = "账服清理";
			this.accountButton.光泽 = true;
			this.accountButton.图像 = global::MobileBox.Properties.Resources.删_除;
			this.accountButton.圆角角度 = 10;
			this.accountButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			进度条1.指示进度 = 0F;
			进度条1.进度条宽度 = 5;
			进度条1.进度条颜色 = System.Drawing.Color.DodgerBlue;
			this.accountButton.指示进度条 = 进度条1;
			this.accountButton.文字描边 = System.Drawing.Color.Transparent;
			this.accountButton.文本 = "账服清理";
			this.accountButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
			this.accountButton.文本水平偏移 = 0;
			this.accountButton.渐变 = true;
			this.accountButton.禁用时灰度显示 = true;
			this.accountButton.禁用时透明度 = 0.3F;
			this.accountButton.绘制边框 = DSControls.DS按钮.边框.全部;
			this.accountButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
			自定义状态图像1.按下 = null;
			自定义状态图像1.禁用 = null;
			自定义状态图像1.高亮 = null;
			自定义状态图像1.默认 = null;
			this.accountButton.自定义图像 = 自定义状态图像1;
			this.accountButton.贴图 = null;
			this.accountButton.贴图切割边距.上 = 0;
			this.accountButton.贴图切割边距.下 = 0;
			this.accountButton.贴图切割边距.右 = 0;
			this.accountButton.贴图切割边距.左 = 0;
			this.accountButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
			this.accountButton.边框颜色 = System.Drawing.Color.White;
			this.accountButton.选定 = false;
			this.accountButton.选定模式 = true;
			this.accountButton.选定颜色 = System.Drawing.SystemColors.ButtonFace;
			this.accountButton.透明区域不引发鼠标事件 = false;
			this.accountButton.透明度 = 1F;
			this.accountButton.附加内容字体 = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.accountButton.附加说明 = "清理手机魔域账服设备授权";
			this.accountButton.附加说明使用彩色引擎 = false;
			this.accountButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.accountButton.附加说明描边色 = System.Drawing.Color.Transparent;
			this.accountButton.附加说明颜色 = System.Drawing.Color.Black;
			this.accountButton.颜色 = System.Drawing.SystemColors.ControlLightLight;
			this.accountButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.accountButton_ButtonClick);
			// 
			// FormServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(685, 366);
			this.Controls.Add(this.accountButton);
			this.Name = "FormServer";
			this.Text = "FormServer";
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormServer_MouseMove);
			this.ResumeLayout(false);

        }

		#endregion

		private DSControls.DS按钮 accountButton;
	}
}