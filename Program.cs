using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

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

            //Initc();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Offline_Questions());
            // Application.Run(new Offline_JiaoYan());
            //Application.Run(new Import(1));
            //Application.Run(new plc());
            // Application.Run(new Offline());
            // Application.Run(new StudentSet());
            //   Application.Run(new Settings1());
            //  Application.Run(new Print());
            //  Application.Run(new plc());
            Application.Run(new form1());
            // Application.Run(new Exam1());
            //Application.Run(new MFYM());
            // Application.Run(new ScanLogin());
            // Application.Run(new SubjectForm());
        }

    }
}
