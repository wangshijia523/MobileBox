using System.Diagnostics;
using System.IO;
using static System.String;

namespace MobileBox
{
    public class RunCmd
    {
        private Process proc = null;
        public RunCmd()
        {
            proc = new Process();
        }

        public string Exe(string cmd)
        {
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;

           // proc.OutputDataReceived += new DataReceivedEventHandler(sortProcess_OutputDataReceived);
            proc.Start();

            proc.StandardInput.WriteLine(cmd);
            proc.StandardInput.WriteLine("exit");

			
			while (!proc.HasExited)
				proc.WaitForExit(100);
			var end = proc.StandardError.ReadToEnd();
			var endt = proc.StandardOutput.ReadToEnd();
			proc.Close();
			return endt + end;
        }

      
        private void sortProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!IsNullOrEmpty(e.Data))
            {
                //this.BeginInvoke(new Action(() => { this.listBox1.Items.Add(e.Data); }));
            }
        }
    }
}
