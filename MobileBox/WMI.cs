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

        public static string CloseProcess(string processName, ManagementScope scope)
        {
            try
            {
                using (var managementClass = new ManagementClass(scope, new ManagementPath("Win32_Process"), new ObjectGetOptions()))
                {
                    var inputParams = managementClass.GetMethodParameters("Create");

                    inputParams["CommandLine"] = $"taskkill /f /t /im \"{processName}\" ";

                    var outParams = managementClass.InvokeMethod("Create", inputParams, new InvokeMethodOptions());
                }

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return processName + "\n";
        }

        public static string OpenProcess(string ip, string userName, string passWord, string processName)
        {
            try
            {
                var processPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                var p1 = new Process
                {
                    StartInfo =
                    {
                        FileName =  processPath+"\\"+"Tools\\PsExec.exe",
                        Arguments = $@" \\{ip} -u {userName} -p {passWord} -i -d {processName}",
                        UseShellExecute = false,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        StandardOutputEncoding = Encoding.UTF8,
                        StandardErrorEncoding = Encoding.UTF8,
                        CreateNoWindow = true
                    }
                };
                p1.Start();
                var ret = p1.StandardOutput.ReadToEnd();
                p1.WaitForExit();
                p1.Close();
                if (ret != string.Empty)
                {
                    return processName + "\n";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return  "\n";
        }

        //public static string CloseProcess(string ip, string userName, string passWord, string processName, ManagementScope scope)
        //{
        //    try
        //    {
        //        var process = new Process
        //        {
        //            StartInfo =
        //            {
        //                FileName = "taskkill.exe",
        //                Arguments = $" /s {ip} /f /t /im \"{processName}\" /U {userName} /P {passWord}",
        //                UseShellExecute = false,
        //                RedirectStandardOutput = true,
        //                RedirectStandardError = true,
        //                CreateNoWindow = true

        //            }
        //        };

        //        // process.StartInfo.StandardOutputEncoding = Encoding.UTF8;

        //        // process.OutputDataReceived += (s, e) =>
        //        // {
        //        // ret += e.Data;
        //        // };
        //        // process.ErrorDataReceived += (s, e) =>
        //        // {
        //        // ret += e.Data;
        //        // };
        //        // process.BeginOutputReadLine();
        //        // process.BeginErrorReadLine();
        //        process.Start();

        //        var ret = process.StandardOutput.ReadToEnd();
        //        process.WaitForExit();
        //        process.Close();
        //        if (ret != string.Empty)
        //        {
        //            return processName + "\n";
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.ToString();
        //    }

        //    return "\n";
        //}
    }
}
