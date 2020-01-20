namespace MobileBox
{
    sealed partial class FormImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImage));
            DSControls.DS按钮.进度条 进度条1 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像1 = new DSControls.DS按钮.自定义状态图像();
            this.resolutionButton = new DSControls.DS按钮();
            this.SuspendLayout();
            // 
            // resolutionButton
            // 
            this.resolutionButton.BackColor = System.Drawing.Color.Transparent;
            this.resolutionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resolutionButton.BackgroundImage")));
            this.resolutionButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.resolutionButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.resolutionButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resolutionButton.ForeColor = System.Drawing.Color.Black;
            this.resolutionButton.Location = new System.Drawing.Point(10, 10);
            this.resolutionButton.Margin = new System.Windows.Forms.Padding(1);
            this.resolutionButton.Name = "resolutionButton";
            this.resolutionButton.Size = new System.Drawing.Size(155, 40);
            this.resolutionButton.TabIndex = 3;
            this.resolutionButton.Text = "分辨率转换";
            this.resolutionButton.光泽 = true;
            this.resolutionButton.图像 = global::MobileBox.Properties.Resources.resolution_53_462304409673px_1218196_easyicon_net;
            this.resolutionButton.圆角角度 = 10;
            this.resolutionButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条1.指示进度 = 0F;
            进度条1.进度条宽度 = 5;
            进度条1.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.resolutionButton.指示进度条 = 进度条1;
            this.resolutionButton.文字描边 = System.Drawing.Color.Transparent;
            this.resolutionButton.文本 = "分辨率转换";
            this.resolutionButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.resolutionButton.文本水平偏移 = 0;
            this.resolutionButton.渐变 = true;
            this.resolutionButton.禁用时灰度显示 = true;
            this.resolutionButton.禁用时透明度 = 0.3F;
            this.resolutionButton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.resolutionButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像1.按下 = null;
            自定义状态图像1.禁用 = null;
            自定义状态图像1.高亮 = null;
            自定义状态图像1.默认 = null;
            this.resolutionButton.自定义图像 = 自定义状态图像1;
            this.resolutionButton.贴图 = null;
            this.resolutionButton.贴图切割边距.上 = 0;
            this.resolutionButton.贴图切割边距.下 = 0;
            this.resolutionButton.贴图切割边距.右 = 0;
            this.resolutionButton.贴图切割边距.左 = 0;
            this.resolutionButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.resolutionButton.边框颜色 = System.Drawing.Color.White;
            this.resolutionButton.选定 = false;
            this.resolutionButton.选定模式 = true;
            this.resolutionButton.选定颜色 = System.Drawing.SystemColors.ButtonFace;
            this.resolutionButton.透明区域不引发鼠标事件 = false;
            this.resolutionButton.透明度 = 1F;
            this.resolutionButton.附加内容字体 = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionButton.附加说明 = "扩大或缩小模板图片";
            this.resolutionButton.附加说明使用彩色引擎 = false;
            this.resolutionButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.resolutionButton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.resolutionButton.附加说明颜色 = System.Drawing.Color.Black;
            this.resolutionButton.颜色 = System.Drawing.SystemColors.ControlLightLight;
            this.resolutionButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.resolutionButton_ButtonClick);
            this.resolutionButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resolutionButton_MouseMove);
            // 
            // FormImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(640, 223);
            this.Controls.Add(this.resolutionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormImage";
            this.Text = "FormImage";
            this.ResumeLayout(false);

        }

        #endregion
        private DSControls.DS按钮 resolutionButton;
    }
}