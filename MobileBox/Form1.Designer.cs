namespace MobileBox
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dS垂直线1 = new DSControls.DS垂直线();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RemoteButton = new System.Windows.Forms.Button();
            this.imageButton = new System.Windows.Forms.Button();
            this.serveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS垂直线1
            // 
            this.dS垂直线1.Location = new System.Drawing.Point(0, 83);
            this.dS垂直线1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dS垂直线1.MaximumSize = new System.Drawing.Size(10, 29);
            this.dS垂直线1.MinimumSize = new System.Drawing.Size(10, 29);
            this.dS垂直线1.Name = "dS垂直线1";
            this.dS垂直线1.Size = new System.Drawing.Size(10, 29);
            this.dS垂直线1.TabIndex = 7;
            this.dS垂直线1.线条宽度 = 10;
            this.dS垂直线1.线条颜色 = System.Drawing.Color.Gold;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Location = new System.Drawing.Point(154, 61);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(535, 307);
            this.metroPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MobileBox.Properties.Resources.slider_tool_32px_1211522_easyicon_net;
            this.pictureBox1.Location = new System.Drawing.Point(287, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // RemoteButton
            // 
            this.RemoteButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoteButton.FlatAppearance.BorderSize = 0;
            this.RemoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RemoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoteButton.Image = global::MobileBox.Properties.Resources.Teamviewer_32px_1194695_easyicon_net;
            this.RemoteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoteButton.Location = new System.Drawing.Point(18, 76);
            this.RemoteButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RemoteButton.Name = "RemoteButton";
            this.RemoteButton.Size = new System.Drawing.Size(130, 38);
            this.RemoteButton.TabIndex = 2;
            this.RemoteButton.Text = "远程操作";
            this.RemoteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoteButton.UseVisualStyleBackColor = false;
            this.RemoteButton.Click += new System.EventHandler(this.RemoteButton_Click);
            this.RemoteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoteButton_MouseMove);
            // 
            // imageButton
            // 
            this.imageButton.BackColor = System.Drawing.Color.Transparent;
            this.imageButton.FlatAppearance.BorderSize = 0;
            this.imageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imageButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imageButton.Image = global::MobileBox.Properties.Resources.Instagram_31_652173913043px_1138816_easyicon_net;
            this.imageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imageButton.Location = new System.Drawing.Point(18, 124);
            this.imageButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(130, 38);
            this.imageButton.TabIndex = 0;
            this.imageButton.Text = "  图片操作";
            this.imageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imageButton.UseVisualStyleBackColor = false;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            this.imageButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageButton_MouseMove);
            // 
            // serveButton
            // 
            this.serveButton.BackColor = System.Drawing.Color.Transparent;
            this.serveButton.FlatAppearance.BorderSize = 0;
            this.serveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serveButton.Image = global::MobileBox.Properties.Resources.spider_web_32_414910858995px_1237284_easyicon_net;
            this.serveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serveButton.Location = new System.Drawing.Point(18, 172);
            this.serveButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.serveButton.Name = "serveButton";
            this.serveButton.Size = new System.Drawing.Size(130, 38);
            this.serveButton.TabIndex = 4;
            this.serveButton.Text = "游服操作";
            this.serveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serveButton.UseVisualStyleBackColor = false;
            this.serveButton.Click += new System.EventHandler(this.serveButton_Click);
            this.serveButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.serveButton_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.dS垂直线1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RemoteButton);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.serveButton);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(33, 110, 33, 36);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "                                              MobileBox";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button RemoteButton;
        private System.Windows.Forms.Button serveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DSControls.DS垂直线 dS垂直线1;
        private System.Windows.Forms.Panel metroPanel1;
    }
}

