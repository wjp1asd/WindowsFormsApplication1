using Sunny.UI;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1.Models
{
    public class Fuc
    {
        public IFrame Frame { get; set; }

        // fullsreen
        public void backlogin()
        {

            Application.Restart();
            Process.GetCurrentProcess()?.Kill();
        }
        public void fullsreen(System.Windows.Forms.Control c, Form f)
        {

            //
            //
            string x = ConfigurationManager.AppSettings["machine"];
            switch (x)
            {
                case "2":
                    c.Left += (c.Left + f.Width) / 2 - 50;
                    break;
                case "3":
                    c.Left += (c.Left + f.Width) / 2 + 10;
                    break;
                case "4":
                    c.Left += (c.Left + f.Width) / 2;
                    break;

                default:
                    c.Left += (c.Left + f.Width) / 2 - 50;
                    break;

            }
            // c.Left += (c.Left+ f.Width) / 2-50;


        }
        public void fullsreen1(System.Windows.Forms.Control c, Form f)
        {

            //
            //
            string x = ConfigurationManager.AppSettings["machine"];
            switch (x)
            {
                case "2":
                    c.Left += (c.Left + f.Width) / 2 - 50;
                    break;
                case "3":
                    c.Left += (c.Left + f.Width) / 2 - 50;
                    break;
                case "4":
                    c.Left += (c.Left + f.Width) / 2 - 190;
                    break;

                default:
                    c.Left += (c.Left + f.Width) / 2 - 50;
                    break;

            }
            // c.Left += (c.Left+ f.Width) / 2-50;


        }
        public void sound()
        {
            Task.Run(() =>
            {

                SoundPlayer player = new SoundPlayer();

                // 设置音频文件的路径

                player.Stream = WindowsFormsApplication1.Properties.Resources.提示音2;
                // player.SoundLocation =WindowsFormsApplication1.Properties.Resources.提示音2.ToString();

                // MessageBox.Show(WindowsFormsApplication1.Properties.Resources.提示音2.ToString());
                // 播放音频
                player.Play();

                // 等待音频播放完毕
                player.PlaySync();

                // 释放资源
                player.Dispose();
            });


        }
        public String Md5(string plaintext)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(plaintext);//将要加密的字符串转换为字节数组
            byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            var a = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串
            return a;
        }

        public Fuc() { }
        public void showloading(String t = "系统加载中......")
        {
            UIStatusFormService.ShowStatusForm(100, t, 0);
          
            for (int i = 0; i < 88; i++)
            {
                SystemEx.Delay(50);
                UIStatusFormService.SetDescription(t + "(" + i + "%)......");
                UIStatusFormService.StepIt();
            }

            UIStatusFormService.HideStatusForm();
        }

        // 判断是否有返回结果
        public string RC(string sqlsent)
        {
            string count = "";
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = string.Format(sqlsent);
            SqlCommand com1 = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com1.ExecuteReader();
            while (reader.Read())
            {
                count = reader["qrcode"].ToString();
            }
            con.Close();
            return count;
        }

        public string RC1(string sqlsent)
        {
            string count = "";
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = string.Format(sqlsent);
            SqlCommand com1 = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com1.ExecuteReader();
            while (reader.Read())
            {
                count = "123";
            }
            con.Close();
            return count;
        }
        //生成成绩单
        public int formGrade(string can, string name, string id)
        {
            int score1 = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();


            string strcomm = "insert into " + "Grade" + "([testid],[name],[idcard]) VALUES(" +

                "'" + can.ToString().Trim() + "'" + ","
            + "'" + name.ToString().Trim() + "'" + ","
            + "'" + id.ToString().Trim() + "'" + ")"
            ;


            datahelp a = new datahelp();
            SqlCommand com = new SqlCommand(strcomm, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                score1 += 1;

            }


            return score1;
        }
        public void ShowWaitForm(string desc = "系统正在处理中，请稍候...")
        {
            UIWaitFormService.ShowWaitForm(desc);
        }

        public void HideWaitForm()
        {
            UIWaitFormService.HideWaitForm();
        }

        public void SetWaitFormDescription(string desc)
        {
            UIWaitFormService.SetDescription(desc);
        }

        public void ShowSuccessDialog(string msg, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, UILocalize.SuccessTitle, showCancelButton: false, UIStyle.Green, showMask, Frame?.TopMost ?? false);
        }

        public void ShowInfoDialog(string msg, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, UILocalize.InfoTitle, showCancelButton: false, UIStyle.Gray, showMask, Frame?.TopMost ?? false);
        }

        public void ShowWarningDialog(string msg, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, UILocalize.WarningTitle, showCancelButton: false, UIStyle.Orange, showMask, Frame?.TopMost ?? false);
        }

        public void ShowErrorDialog(string msg, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, UILocalize.ErrorTitle, showCancelButton: false, UIStyle.Red, showMask, Frame?.TopMost ?? false);
        }

        public bool ShowAskDialog(string msg, bool showMask = false)
        {
            return UIMessageDialog.ShowMessageDialog(msg, UILocalize.AskTitle, showCancelButton: true, UIStyle.Blue, showMask, Frame?.TopMost ?? false);
        }

        public void ShowSuccessDialog(string title, string msg, UIStyle style = UIStyle.Green, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, title, showCancelButton: false, style, showMask, Frame?.TopMost ?? false);
        }

        public void ShowInfoDialog(string title, string msg, UIStyle style = UIStyle.Gray, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, title, showCancelButton: false, style, showMask, Frame?.TopMost ?? false);
        }

        public void ShowWarningDialog(string title, string msg, UIStyle style = UIStyle.Orange, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, title, showCancelButton: false, style, showMask, Frame?.TopMost ?? false);
        }

        public void ShowErrorDialog(string title, string msg, UIStyle style = UIStyle.Red, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, title, showCancelButton: false, style, showMask, Frame?.TopMost ?? false);
        }

        public bool ShowAskDialog(string title, string msg, UIStyle style = UIStyle.Blue, bool showMask = false)
        {
            return UIMessageDialog.ShowMessageDialog(msg, title, showCancelButton: true, style, showMask, Frame?.TopMost ?? false);
        }

        public void ShowInfoTip(string text, int delay = 1000, bool floating = true)
        {
            UIMessageTip.Show(text, null, delay, floating);
        }

        public void ShowSuccessTip(string text, int delay = 1000, bool floating = true)
        {
            UIMessageTip.ShowOk(text, delay, floating);
        }

        public void ShowWarningTip(string text, int delay = 1000, bool floating = true)
        {
            UIMessageTip.ShowWarning(text, delay, floating);
        }

        public void ShowErrorTip(string text, int delay = 1000, bool floating = true)
        {
            UIMessageTip.ShowError(text, delay, floating);
        }

        public void ShowInfoTip(Component controlOrItem, string text, int delay = 1000, bool floating = true)
        {
            UIMessageTip.Show(controlOrItem, text, null, delay, floating);
        }

        public void ShowSuccessTip(Component controlOrItem, string text, int delay = 1000, bool floating = true)
        {
            UIMessageTip.ShowOk(controlOrItem, text, delay, floating);
        }

        public void ShowErrorTip(Component controlOrItem, string text, int delay = 1000, bool floating = true)
        {
            UIMessageTip.ShowError(controlOrItem, text, delay, floating);
        }

        public void ShowWarningTip(Component controlOrItem, string text, int delay = 1000, bool floating = true)
        {
            UIMessageTip.ShowWarning(controlOrItem, text, delay, floating, false);
        }

        public void ShowInfoNotifier(string desc, bool isDialog = false, int timeout = 2000)
        {
            UINotifierHelper.ShowNotifier(desc, UINotifierType.INFO, UILocalize.InfoTitle, isDialog, timeout);
        }

        public void ShowSuccessNotifier(string desc, bool isDialog = false, int timeout = 2000)
        {
            UINotifierHelper.ShowNotifier(desc, UINotifierType.OK, UILocalize.SuccessTitle, isDialog, timeout);
        }

        public void ShowWarningNotifier(string desc, bool isDialog = false, int timeout = 2000)
        {
            UINotifierHelper.ShowNotifier(desc, UINotifierType.WARNING, UILocalize.WarningTitle, isDialog, timeout);
        }

        public void ShowErrorNotifier(string desc, bool isDialog = false, int timeout = 2000)
        {
            UINotifierHelper.ShowNotifier(desc, UINotifierType.ERROR, UILocalize.ErrorTitle, isDialog, timeout);
        }

        public void ShowInfoNotifier(string desc, EventHandler clickEvent, int timeout = 2000)
        {
            UINotifierHelper.ShowNotifier(desc, clickEvent, UINotifierType.INFO, UILocalize.InfoTitle, timeout);
        }

        public void ShowSuccessNotifier(string desc, EventHandler clickEvent, int timeout = 2000)
        {
            UINotifierHelper.ShowNotifier(desc, clickEvent, UINotifierType.OK, UILocalize.SuccessTitle, timeout);
        }

        public void ShowWarningNotifier(string desc, EventHandler clickEvent, int timeout = 2000)
        {
            UINotifierHelper.ShowNotifier(desc, clickEvent, UINotifierType.WARNING, UILocalize.WarningTitle, timeout);
        }

        public void ShowErrorNotifier(string desc, EventHandler clickEvent, int timeout = 2000)
        {
            UINotifierHelper.ShowNotifier(desc, clickEvent, UINotifierType.ERROR, UILocalize.ErrorTitle, timeout);
        }
        public void button(Button b) {

            b.Size = new System.Drawing.Size(250, 80);
            //b.Margin.Top =20;
            
        }

        public void dataview(DataGridView dg)
        {
          dg.GridColor = Color.PowderBlue;
          dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 235, 243, 255);
            dg.ColumnHeadersHeight = 32;
          dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,80,160,255);
            dg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 12F);
            dg.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 12F);
        }
        internal void same(Form f)
        {
            f.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.空白界面副本;
            f.ControlBox = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.BackgroundImageLayout = ImageLayout.Stretch;
          


        }
    }
}
