using Microsoft.Win32;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication1.Scan;

namespace WindowsFormsApplication1
{
    static class Program
    {
        static Program()
        {
            //  Dll.RegistDLL();
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Initc();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Offline_Questions());
            // Application.Run(new Offline_JiaoYan());
            //Application.Run(new Import(1));
            // Application.Run(new plc());
            // Application.Run(new Offline());
            // Application.Run(new StudentSet());
            //   Application.Run(new Settings1());
            //  Application.Run(new Print("mXjjwVcvXizfGcnbOF9CKw=="));
            //    Application.Run(new ResultSet());
            string x = ConfigurationManager.AppSettings["machine"];
            if (int.Parse(x) < 2)
            {
                Application.Run(new form1());
            }
            else
            {
                Application.Run(new ScanLogin());
            }

            // Application.Run(new zaixianjiaoyan2());
            // Application.Run(new Exam1());
            // Application.Run(new MFYM("EmcaBvClo9bJ6NkgbLWqRg=="));
            //  Application.Run(new ScanLogin());
            // Application.Run(new SubjectForm());
        }
        static void AddStartupEntry(string appName, string appPath)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                // 添加开机启动项
                key.SetValue(appName, appPath);
            }
        }

        static void RemoveStartupEntry(string appName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                // 删除开机启动项
                key.DeleteValue(appName, false);
            }
        }
        private static void Initc()
        {
            string sPath = Application.StartupPath + "\\Images\\身份证照片\\";
            string sPath1 = Application.StartupPath + "\\Images\\题库照片\\";
            string sPath2 = Application.StartupPath + "\\Images\\研磨照片\\";
            string sPath3 = Application.StartupPath + "\\Images\\考试照片\\";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
            else
            {
                //  ff.ShowInfoTip("123");
            }
            if (!Directory.Exists(sPath1))
            {
                Directory.CreateDirectory(sPath1);
            }
            if (!Directory.Exists(sPath2))
            {
                Directory.CreateDirectory(sPath2);
            }
            if (!Directory.Exists(sPath3))
            {
                Directory.CreateDirectory(sPath3);
            }
        }
    }
}
