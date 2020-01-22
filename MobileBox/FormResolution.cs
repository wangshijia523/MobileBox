using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSControls;

namespace MobileBox
{
    public partial class FormResolution : MetroFramework.Forms.MetroForm
    {
        public FormResolution()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void inputText_DragDrop(object sender, DragEventArgs e)
        {

            var path = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            inputText.Text = path;
        }

        private void inputText_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void outText_DragDrop(object sender, DragEventArgs e)
        {
            var path = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            outText.Text = path;
            Calculate();
        }

        private void outText_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void Calculate()
        {
            if (inputText.Text.EndsWith("720x1280"))
            {
                if (outText.Text.EndsWith("1080x1920"))
                {
                    dS数字框1.Text = @"1.5";

                }
                else if (outText.Text.EndsWith("1440x2560"))
                {
                    dS数字框1.Text = @"2";
                }
            }
        }

        private static Image GetFile(string path)
        {
            var stream = File.OpenRead(path);
            var fileLength = (int) stream.Length;
            var image = new byte[fileLength];
            stream.Read(image, 0, fileLength);
            var result = Image.FromStream(stream);
            stream.Close();
            return result;
        }

        private static Bitmap SizeBitmap(Image img, double size, int symbol)
        {
            var newWidth = 0;
            var newHeight = 0;
            switch (symbol)
            {
                case 0:
                {
                    newWidth = Convert.ToInt32(img.Width * size);
                    newHeight = Convert.ToInt32(img.Height * size);
                    break;
                }
                case 1:
                {
                    newWidth = Convert.ToInt32(img.Width / size);
                    newHeight = Convert.ToInt32(img.Height / size);
                    break;
                }
            }

            var s = new Size(newWidth, newHeight);
            var newBit = new Bitmap(img, s);
            return newBit;
        }


        private static void SaveImage(string path, Bitmap bit, string name, string ext)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            bit.Save(path + @"\" + name);
            bit.Dispose();
        }

        private void magnifyButton_ButtonClick(object sender)
        {
            dS圆形指示灯1.指示状态 = DS圆形指示灯.状态.ON;
            Application.DoEvents();
            if (string.IsNullOrEmpty(inputText.Text))
            {
                MessageBox.Show(@"源文件夹路径为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }
            else if (string.IsNullOrEmpty(outText.Text))
            {
                MessageBox.Show(@"目标文件夹路径为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }

            else if (Path.GetExtension(inputText.Text) == ".png") //单张图片
            {

                var info = new FileInfo(inputText.Text);
                var img = GetFile(inputText.Text);
                var bit = SizeBitmap(img, Convert.ToDouble(dS数字框1.Value), 0);
                if (Path.GetExtension(outText.Text) == ".png")
                {
                    bit.Save(outText.Text);
                }
                else
                {
                    SaveImage(outText.Text, bit, info.Name, info.Extension);
                }

                MessageBox.Show(@"保存成功", @"提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);


            }

            else
            {
                var fileStrs = Directory.GetFiles(inputText.Text);
                foreach (var s in fileStrs)
                {
                    var info = new FileInfo(s);
                    if (info.Extension != ".png") continue; //跳过后缀不是.png的文件
                    var img = GetFile(s);
                    var bit = SizeBitmap(img, Convert.ToDouble(dS数字框1.Value),
                        0);
                    SaveImage(outText.Text, bit, info.Name, info.Extension);
                }

                MessageBox.Show(@"保存成功", @"提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }

            dS圆形指示灯1.指示状态 = DS圆形指示灯.状态.OFF;
        }

        private void batchButton_ButtonClick(object Sender)
        {
            var task = new Task(Batch); //批量的时候工作量比较大，开个线程做
            task.Start();
        }

        private void Batch()
        {
            dS圆形指示灯1.指示状态 = DS圆形指示灯.状态.ON;
            if (string.IsNullOrEmpty(inputText.Text))
            {
                MessageBox.Show(@"源文件夹路径为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            else
            {
                var fileStrs = new DirectoryInfo(inputText.Text);
                foreach (var s in fileStrs.GetDirectories())
                {
                    var checksw = s.ToString();
                    if (!checksw.EndsWith("720x1280")) continue;
                    var path720 = inputText.Text + "\\" + checksw;
                    var path1080 = inputText.Text + "\\" + checksw.Split('7')[0] + "1080x1920";
                    var path1440 = inputText.Text + "\\" + checksw.Split('7')[0] + "1440x2560";

                    if (Directory.Exists(path1080) == false)
                    {
                        Directory.CreateDirectory(path1080);
                    }

                    foreach (var i in Directory.GetFiles(path720))
                    {
                        var info = new FileInfo(i);
                        if (info.Extension != ".png") continue;
                        var img = GetFile(i);
                        var bit = SizeBitmap(img, 1.5, 0);
                        SaveImage(path1080, bit, info.Name, info.Extension);
                    }

                    if (Directory.Exists(path1440) == false)
                    {
                        Directory.CreateDirectory(path1440);
                    }

                    foreach (var i in Directory.GetFiles(path720))
                    {
                        var info = new FileInfo(i);
                        if (info.Extension != ".png") continue;
                        var img = GetFile(i);
                        var bit = SizeBitmap(img, 2, 0);
                        SaveImage(path1440, bit, info.Name, info.Extension);
                    }
                }

                MessageBox.Show(@"保存成功", @"提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            dS圆形指示灯1.指示状态 = DS圆形指示灯.状态.OFF;
        }

        private void shrinkBtton_ButtonClick(object Sender)
        {
            dS圆形指示灯1.指示状态 = DS圆形指示灯.状态.ON;
            Application.DoEvents();
            if (string.IsNullOrEmpty(inputText.Text))
            {
                MessageBox.Show(@"源文件夹路径为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }
            else if (string.IsNullOrEmpty(outText.Text))
            {
                MessageBox.Show(@"目标文件夹路径为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }

            else if (Path.GetExtension(inputText.Text) == ".png")
            {
                var info = new FileInfo(inputText.Text);
                var img = GetFile(inputText.Text);
                var bit = SizeBitmap(img, Convert.ToDouble(dS数字框1.Value),1);
                if (Path.GetExtension(outText.Text) == ".png")
                {
                    bit.Save(outText.Text);
                }
                else
                {
                    SaveImage(outText.Text, bit, info.Name, info.Extension);
                }
                MessageBox.Show(@"保存成功", @"提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }
            else
            {
                var fileStrs = Directory.GetFiles(inputText.Text);
                foreach (var s in fileStrs)
                {
                    var info = new FileInfo(s);

                    if (info.Extension != ".png") continue;
                    var img = GetFile(s);
                    var bit = SizeBitmap(img, Convert.ToDouble(dS数字框1.Value),1);
                    SaveImage(outText.Text, bit, info.Name, info.Extension);
                }

                MessageBox.Show(@"保存成功", @"提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }
            dS圆形指示灯1.指示状态 = DS圆形指示灯.状态.OFF;
        }

        private void shrinkBtton_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }
    }
    
}
