namespace MobileBox
{
    sealed partial class FormRemote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemote));
            DSControls.DS按钮.进度条 进度条1 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像1 = new DSControls.DS按钮.自定义状态图像();
            DSControls.DS按钮.进度条 进度条2 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像2 = new DSControls.DS按钮.自定义状态图像();
            DSControls.DS按钮.进度条 进度条3 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像3 = new DSControls.DS按钮.自定义状态图像();
            DSControls.DS按钮.进度条 进度条4 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像4 = new DSControls.DS按钮.自定义状态图像();
            DSControls.DS按钮.进度条 进度条5 = new DSControls.DS按钮.进度条();
            DSControls.DS按钮.自定义状态图像 自定义状态图像5 = new DSControls.DS按钮.自定义状态图像();
            this.ClearButton = new DSControls.DS按钮();
            this.delButton = new DSControls.DS按钮();
            this.uploaButton = new DSControls.DS按钮();
            this.switchButton = new DSControls.DS按钮();
            this.copyButton = new DSControls.DS按钮();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearButton.BackgroundImage")));
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClearButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(134, 92);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(1);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(120, 40);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "结果清理";
            this.ClearButton.光泽 = true;
            this.ClearButton.图像 = global::MobileBox.Properties.Resources.clear_48px_1128280_easyicon_net;
            this.ClearButton.圆角角度 = 10;
            this.ClearButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条1.指示进度 = 0F;
            进度条1.进度条宽度 = 5;
            进度条1.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.ClearButton.指示进度条 = 进度条1;
            this.ClearButton.文字描边 = System.Drawing.Color.Transparent;
            this.ClearButton.文本 = "结果清理";
            this.ClearButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.ClearButton.文本水平偏移 = 0;
            this.ClearButton.渐变 = true;
            this.ClearButton.禁用时灰度显示 = true;
            this.ClearButton.禁用时透明度 = 0.3F;
            this.ClearButton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.ClearButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像1.按下 = null;
            自定义状态图像1.禁用 = null;
            自定义状态图像1.高亮 = null;
            自定义状态图像1.默认 = null;
            this.ClearButton.自定义图像 = 自定义状态图像1;
            this.ClearButton.贴图 = null;
            this.ClearButton.贴图切割边距.上 = 0;
            this.ClearButton.贴图切割边距.下 = 0;
            this.ClearButton.贴图切割边距.右 = 0;
            this.ClearButton.贴图切割边距.左 = 0;
            this.ClearButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.ClearButton.边框颜色 = System.Drawing.Color.White;
            this.ClearButton.选定 = false;
            this.ClearButton.选定模式 = true;
            this.ClearButton.选定颜色 = System.Drawing.SystemColors.ButtonFace;
            this.ClearButton.透明区域不引发鼠标事件 = false;
            this.ClearButton.透明度 = 1F;
            this.ClearButton.附加内容字体 = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.附加说明 = "删除平台结果文件夹";
            this.ClearButton.附加说明使用彩色引擎 = false;
            this.ClearButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ClearButton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.ClearButton.附加说明颜色 = System.Drawing.Color.Black;
            this.ClearButton.颜色 = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.ClearButton_ButtonClick);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.Transparent;
            this.delButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delButton.BackgroundImage")));
            this.delButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.delButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delButton.ForeColor = System.Drawing.Color.Black;
            this.delButton.Location = new System.Drawing.Point(10, 92);
            this.delButton.Margin = new System.Windows.Forms.Padding(1);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(120, 40);
            this.delButton.TabIndex = 12;
            this.delButton.Text = "远程删除";
            this.delButton.光泽 = true;
            this.delButton.图像 = global::MobileBox.Properties.Resources.delete_48px_1128280_easyicon_net;
            this.delButton.圆角角度 = 10;
            this.delButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条2.指示进度 = 0F;
            进度条2.进度条宽度 = 5;
            进度条2.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.delButton.指示进度条 = 进度条2;
            this.delButton.文字描边 = System.Drawing.Color.Transparent;
            this.delButton.文本 = "远程删除";
            this.delButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.delButton.文本水平偏移 = 0;
            this.delButton.渐变 = true;
            this.delButton.禁用时灰度显示 = true;
            this.delButton.禁用时透明度 = 0.3F;
            this.delButton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.delButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像2.按下 = null;
            自定义状态图像2.禁用 = null;
            自定义状态图像2.高亮 = null;
            自定义状态图像2.默认 = null;
            this.delButton.自定义图像 = 自定义状态图像2;
            this.delButton.贴图 = null;
            this.delButton.贴图切割边距.上 = 0;
            this.delButton.贴图切割边距.下 = 0;
            this.delButton.贴图切割边距.右 = 0;
            this.delButton.贴图切割边距.左 = 0;
            this.delButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.delButton.边框颜色 = System.Drawing.Color.White;
            this.delButton.选定 = false;
            this.delButton.选定模式 = true;
            this.delButton.选定颜色 = System.Drawing.SystemColors.ButtonFace;
            this.delButton.透明区域不引发鼠标事件 = false;
            this.delButton.透明度 = 1F;
            this.delButton.附加内容字体 = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.附加说明 = "可选删除自动化数据库";
            this.delButton.附加说明使用彩色引擎 = false;
            this.delButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.delButton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.delButton.附加说明颜色 = System.Drawing.Color.Black;
            this.delButton.颜色 = System.Drawing.SystemColors.ControlLightLight;
            this.delButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.delButton_ButtonClick);
            // 
            // uploaButton
            // 
            this.uploaButton.BackColor = System.Drawing.Color.Transparent;
            this.uploaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploaButton.BackgroundImage")));
            this.uploaButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.uploaButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.uploaButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploaButton.ForeColor = System.Drawing.Color.Black;
            this.uploaButton.Location = new System.Drawing.Point(10, 50);
            this.uploaButton.Margin = new System.Windows.Forms.Padding(1);
            this.uploaButton.Name = "uploaButton";
            this.uploaButton.Size = new System.Drawing.Size(120, 40);
            this.uploaButton.TabIndex = 11;
            this.uploaButton.Text = "维护上传";
            this.uploaButton.光泽 = true;
            this.uploaButton.图像 = global::MobileBox.Properties.Resources.upload_48px_1204394_easyicon1;
            this.uploaButton.圆角角度 = 10;
            this.uploaButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条3.指示进度 = 0F;
            进度条3.进度条宽度 = 5;
            进度条3.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.uploaButton.指示进度条 = 进度条3;
            this.uploaButton.文字描边 = System.Drawing.Color.Transparent;
            this.uploaButton.文本 = "维护上传";
            this.uploaButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.uploaButton.文本水平偏移 = 0;
            this.uploaButton.渐变 = true;
            this.uploaButton.禁用时灰度显示 = true;
            this.uploaButton.禁用时透明度 = 0.3F;
            this.uploaButton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.uploaButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像3.按下 = null;
            自定义状态图像3.禁用 = null;
            自定义状态图像3.高亮 = null;
            自定义状态图像3.默认 = null;
            this.uploaButton.自定义图像 = 自定义状态图像3;
            this.uploaButton.贴图 = null;
            this.uploaButton.贴图切割边距.上 = 0;
            this.uploaButton.贴图切割边距.下 = 0;
            this.uploaButton.贴图切割边距.右 = 0;
            this.uploaButton.贴图切割边距.左 = 0;
            this.uploaButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.uploaButton.边框颜色 = System.Drawing.Color.White;
            this.uploaButton.选定 = false;
            this.uploaButton.选定模式 = true;
            this.uploaButton.选定颜色 = System.Drawing.SystemColors.ButtonFace;
            this.uploaButton.透明区域不引发鼠标事件 = false;
            this.uploaButton.透明度 = 1F;
            this.uploaButton.附加内容字体 = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploaButton.附加说明 = "仅支持手机平台项目";
            this.uploaButton.附加说明使用彩色引擎 = false;
            this.uploaButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.uploaButton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.uploaButton.附加说明颜色 = System.Drawing.Color.Black;
            this.uploaButton.颜色 = System.Drawing.SystemColors.ControlLightLight;
            this.uploaButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.uploaButton_ButtonClick);
            // 
            // switchButton
            // 
            this.switchButton.BackColor = System.Drawing.Color.Transparent;
            this.switchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchButton.BackgroundImage")));
            this.switchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.switchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.switchButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switchButton.ForeColor = System.Drawing.Color.Black;
            this.switchButton.Location = new System.Drawing.Point(134, 50);
            this.switchButton.Margin = new System.Windows.Forms.Padding(1);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(120, 40);
            this.switchButton.TabIndex = 10;
            this.switchButton.Text = "远程开关";
            this.switchButton.光泽 = true;
            this.switchButton.图像 = global::MobileBox.Properties.Resources.Settings_Switch_48px_1188508_easyicon_net;
            this.switchButton.圆角角度 = 10;
            this.switchButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条4.指示进度 = 0F;
            进度条4.进度条宽度 = 5;
            进度条4.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.switchButton.指示进度条 = 进度条4;
            this.switchButton.文字描边 = System.Drawing.Color.Transparent;
            this.switchButton.文本 = "远程开关";
            this.switchButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.switchButton.文本水平偏移 = 0;
            this.switchButton.渐变 = true;
            this.switchButton.禁用时灰度显示 = true;
            this.switchButton.禁用时透明度 = 0.3F;
            this.switchButton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.switchButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像4.按下 = null;
            自定义状态图像4.禁用 = null;
            自定义状态图像4.高亮 = null;
            自定义状态图像4.默认 = null;
            this.switchButton.自定义图像 = 自定义状态图像4;
            this.switchButton.贴图 = null;
            this.switchButton.贴图切割边距.上 = 0;
            this.switchButton.贴图切割边距.下 = 0;
            this.switchButton.贴图切割边距.右 = 0;
            this.switchButton.贴图切割边距.左 = 0;
            this.switchButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.switchButton.边框颜色 = System.Drawing.Color.White;
            this.switchButton.选定 = false;
            this.switchButton.选定模式 = true;
            this.switchButton.选定颜色 = System.Drawing.SystemColors.ButtonFace;
            this.switchButton.透明区域不引发鼠标事件 = false;
            this.switchButton.透明度 = 1F;
            this.switchButton.附加内容字体 = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton.附加说明 = "仅支持手机平台设备";
            this.switchButton.附加说明使用彩色引擎 = false;
            this.switchButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.switchButton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.switchButton.附加说明颜色 = System.Drawing.Color.Black;
            this.switchButton.颜色 = System.Drawing.SystemColors.ControlLightLight;
            this.switchButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.switchButton_ButtonClick);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Transparent;
            this.copyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyButton.BackgroundImage")));
            this.copyButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.copyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.copyButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copyButton.ForeColor = System.Drawing.Color.Black;
            this.copyButton.Location = new System.Drawing.Point(10, 10);
            this.copyButton.Margin = new System.Windows.Forms.Padding(1);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(120, 40);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "数据库复制";
            this.copyButton.光泽 = true;
            this.copyButton.图像 = global::MobileBox.Properties.Resources.MB_taskmgr_copy_48px_559890_easyicon_net;
            this.copyButton.圆角角度 = 10;
            this.copyButton.字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            进度条5.指示进度 = 0F;
            进度条5.进度条宽度 = 5;
            进度条5.进度条颜色 = System.Drawing.Color.DodgerBlue;
            this.copyButton.指示进度条 = 进度条5;
            this.copyButton.文字描边 = System.Drawing.Color.Transparent;
            this.copyButton.文本 = "数据库复制";
            this.copyButton.文本对齐 = DSControls.DS按钮.Text_Align.Left;
            this.copyButton.文本水平偏移 = 0;
            this.copyButton.渐变 = true;
            this.copyButton.禁用时灰度显示 = true;
            this.copyButton.禁用时透明度 = 0.3F;
            this.copyButton.绘制边框 = DSControls.DS按钮.边框.全部;
            this.copyButton.自动尺寸扩展 = new System.Drawing.Size(20, 20);
            自定义状态图像5.按下 = null;
            自定义状态图像5.禁用 = null;
            自定义状态图像5.高亮 = null;
            自定义状态图像5.默认 = null;
            this.copyButton.自定义图像 = 自定义状态图像5;
            this.copyButton.贴图 = null;
            this.copyButton.贴图切割边距.上 = 0;
            this.copyButton.贴图切割边距.下 = 0;
            this.copyButton.贴图切割边距.右 = 0;
            this.copyButton.贴图切割边距.左 = 0;
            this.copyButton.贴图模式 = DSControls.DS按钮._贴图模式.默认;
            this.copyButton.边框颜色 = System.Drawing.Color.White;
            this.copyButton.选定 = false;
            this.copyButton.选定模式 = true;
            this.copyButton.选定颜色 = System.Drawing.SystemColors.ButtonFace;
            this.copyButton.透明区域不引发鼠标事件 = false;
            this.copyButton.透明度 = 1F;
            this.copyButton.附加内容字体 = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.附加说明 = "支持所有版本魔域和征服项目";
            this.copyButton.附加说明使用彩色引擎 = false;
            this.copyButton.附加说明字体渲染 = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.copyButton.附加说明描边色 = System.Drawing.Color.Transparent;
            this.copyButton.附加说明颜色 = System.Drawing.Color.Black;
            this.copyButton.颜色 = System.Drawing.SystemColors.ControlLightLight;
            this.copyButton.ButtonClick += new DSControls.DS按钮.ButtonClickEventHandler(this.copyButton_ButtonClick);
            // 
            // FormRemote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 224);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.uploaButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.copyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRemote";
            this.Text = "FormRemote";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRemote_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private DSControls.DS按钮 copyButton;
        private DSControls.DS按钮 switchButton;
        private DSControls.DS按钮 uploaButton;
        private DSControls.DS按钮 delButton;
        private DSControls.DS按钮 ClearButton;
    }
}