// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WMI.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Wmi type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Management;

namespace MobileBox
{
    internal static class Wmi
    {
        public static string SelectProcess(string ip, string userName, string passWord, string processName)
        {
            try
            {
                var co = new ConnectionOptions();
                var machineName = ip; // 连接的目标机的IP地址或者机器名
                co.Username = userName;         // 连接需要的用户名
                co.Password = passWord;      // 连接需要的密码
                const string connectString = "SELECT * FROM Win32_Process"; // 查询字符串

                var ms = new ManagementScope("\\\\" + machineName + "\\root\\cimv2", co);
                var oq = new ObjectQuery(connectString);
                var query = new ManagementObjectSearcher(ms, oq);
                var queryCollection = query.Get();
                if (queryCollection.Cast<ManagementObject>().Any(service => service["Name"].Equals(processName)))
                {
                    return processName + "\n";
                }
            }
            catch (Exception ex)
            {
                // ignored
                return ex.ToString();
            }

            return "\n";
        }

        public static string CloseProcess(string ip, string userName, string passWord, string processName)
        {
            try
            {
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = "taskkill.exe",
                        Arguments = $" /s {ip} /f /t /im \"{processName}\" /U {userName} /P {passWord}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true

            }
                };

                // process.StartInfo.StandardOutputEncoding = Encoding.UTF8;

                // process.OutputDataReceived += (s, e) =>
                // {
                // ret += e.Data;
                // };
                // process.ErrorDataReceived += (s, e) =>
                // {
                // ret += e.Data;
                // };
                // process.BeginOutputReadLine();
                // process.BeginErrorReadLine();
                process.Start();

                var ret = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                process.Close();
                if (ret != string.Empty)
                {
                    return processName + "\n";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return "\n";
        }

        public static string OpenProcess(string ip, string userName, string passWord, string processName, string taskname)
        {
            try
            {
                var p1 = new Process
                {
                    StartInfo =
                    {
                        FileName = @"schtasks.exe",
                        Arguments = $@" /create /F /s {ip} -u {userName} -p {
                                passWord
                            } /sc ONCE /st 01:00 /tn {taskname} /tr {processName} /rl HIGHEST ",
                        UseShellExecute = false,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        StandardOutputEncoding = Encoding.UTF8,
                        StandardErrorEncoding = Encoding.UTF8,
                        CreateNoWindow = true
                    }
                };
                p1.Start();
                p1.StandardError.ReadToEnd();
                p1.StandardOutput.ReadToEnd();

                // // If there is no schedule task created for ServiceCommandService, create one
                // if (!string.IsNullOrEmpty(err) && string.IsNullOrEmpty(sop))
                // {
                // p1.StartInfo.Arguments =
                // $@" /create /F /s {ip} -u {userName} -p {
                // passWord
                // } /sc ONCE /st 01:00 /tn 01 /tr {processName} /rl HIGHEST ";
                // p1.Start();
                // err = p1.StandardError.ReadToEnd();
                // sop = p1.StandardOutput.ReadToEnd();
                // if (!sop.Contains("SUCCESS"))
                // {
                // throw new Exception($"Create schedule task failed on {ip}");
                // }
                /*                }*/

                p1.StartInfo.Arguments = $@" /run /s {ip} -u {userName} -p {passWord} /tn {taskname}";
                p1.Start();

                p1.StartInfo.Arguments = $@" /Delete /F /s {ip} -u {userName} -p {passWord} /tn {taskname}";
                p1.Start();
                p1.StandardError.ReadToEnd();
                p1.StandardOutput.ReadToEnd();

                // if (!string.IsNullOrEmpty(err) || !sop.Contains("SUCCESS"))
                // {
                // throw new Exception($"Run schedule task failed on {ip}");
                // }
                p1.WaitForExit();
                p1.Close();
                return processName + "\n";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
