using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Settings;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Settings
{
    public partial class Settings1 : Form
    {
        public Settings1()
        {
            InitializeComponent();

            InitC();
         
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public string a, b, c, d, f;
        public string a1, a2, a3, a4, a5, a6, a7, a8, a9;
        public string a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23;

        private void button9_Click(object sender, EventArgs e)
        {
            biaoding b = new biaoding();
            b.Show();
        }

        private void start_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Settings1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();//重新获取串口
            PLCtextBox8.Items.Clear();//清除comboBox里面的数据
            PLCtextBox8.Items.AddRange(ports);//给comboBox1添加数据

            servo.Items.Clear();
            servo.Items.AddRange(ports);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0219)
            {//设备改变
                if (m.WParam.ToInt32() == 0x8004)
                {//usb串口拔出
                    string[] ports = System.IO.Ports.SerialPort.GetPortNames();//重新获取串口
                    stop.Items.Clear();//清除comboBox里面的数据
                    stop.Items.AddRange(ports);//给comboBox1添加数据

                }
                else if (m.WParam.ToInt32() == 0x8000)
                {//usb串口连接上
                    string[] ports = System.IO.Ports.SerialPort.GetPortNames();//重新获取串口
                    stop.Items.Clear();
                    stop.Items.AddRange(ports);

                }
            }
            base.WndProc(ref m);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();//重新获取串口
            stop.Items.AddRange(ports);
        }

        public string b11, b12, b13, b14, b15, b16;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {
            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }


        private void Settings1_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.SizeChanged += groupBox1_Resize;
           

            string x = ConfigurationManager.AppSettings["machine"];
            switch (x)
            {
                case "2":
                    this.groupBox2.Visible = true;
                    this.button9.Visible = true;
                    break;
                case "3":
                    this.groupBox3.Visible = true;
                    this.button9.Visible = true;
                    break;
                case "-1":
                    this.groupBox2.Visible = true;
                    this.groupBox3.Visible = true;
                    this.button9.Visible = true;
                    break;
                //case "1":
                //    this.groupBox2.Visible = true;
                //    this.groupBox3.Visible = true;
                //    this.button9.Visible = true;
                //    break;

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.InitC();
            this.Close();
        }


        private void InitC()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from settings where Id=1";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(reader["color1"].ToString());
                a = System.Drawing.ColorTranslator.ToHtml(this.button1.BackColor);
                this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(reader["color2"].ToString());
                b = System.Drawing.ColorTranslator.ToHtml(this.button2.BackColor);
                this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(reader["color3"].ToString());
                c = System.Drawing.ColorTranslator.ToHtml(this.button3.BackColor);
                this.button5.BackColor = System.Drawing.ColorTranslator.FromHtml(reader["color4"].ToString());
                d = System.Drawing.ColorTranslator.ToHtml(this.button5.BackColor);
                this.button6.BackColor = System.Drawing.ColorTranslator.FromHtml(reader["color5"].ToString());
                f = System.Drawing.ColorTranslator.ToHtml(this.button6.BackColor);
                a1 = this.plc1.Text = reader["plc1"].ToString();
                //   plcbt, plcjy, plcst, plcsp, DIxy, DIhw, DIB1, DIB2, DIB3, AIY1, AIy2, AIjy,MC
                a2 = this.bt1.Text = reader["plcbt1"].ToString();
                a3 = this.jy1.Text = reader["plcjy1"].ToString();

                a4 = this.start1.Text = reader["plcst1"].ToString();
                a5 = this.stop1.Text = reader["plcsp1"].ToString();
                a6 = this.servo1.Text = reader["servo1"].ToString();

                a7 = this.link.Text = reader["link"].ToString();

                a8 = this.PLCtextBox8.Text = reader["plc"].ToString();
                a9 = this.servo.Text = reader["servo"].ToString();
                //   plcbt, plcjy, plcst, plcsp, DIxy, DIhw, DIB1, DIB2, DIB3, AIY1, AIy2, AIjy,MC
                a11 = this.bt.Text = reader["plcbt"].ToString();
                a19 = this.jy.Text = reader["plcjy"].ToString();

                a12 = this.start.Text = reader["plcst"].ToString();
                a13 = this.stop.Text = reader["plcsp"].ToString();




                b11 = this.textBox1.Text = reader["lxnum"].ToString();
                b12 = this.textBox2.Text = reader["zxnum"].ToString();
                b13 = this.textBox3.Text = reader["gynum"].ToString();
                b14 = this.textBox4.Text = reader["xhnum"].ToString();
                b15 = this.textBox5.Text = reader["lpjnum"].ToString();
                b16 = this.textBox6.Text = reader["ymgnum"].ToString();

            }

            reader.Close();
            con.Close();
            //ff.ShowInfoTip("系统配置加载成功");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                this.button1.BackColor = colorDialog1.Color;
                a = System.Drawing.ColorTranslator.ToHtml(this.button1.BackColor);
                Trace.Write("a:" + a);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            a1 = plc1.Text.Trim();
            a2 = this.bt1.Text.Trim();
            a3 = this.jy1.Text.Trim();
            a4 = this.start1.Text.Trim();
            a5 = this.stop1.Text.Trim();
            a6 = this.servo1.Text.Trim();


            a7 = this.link.Text.Trim();
            a8 = this.PLCtextBox8.Text.Trim();
            a9 = this.servo.Text.Trim();
            a11 = this.bt.Text.Trim();
            a19 = this.jy.Text.Trim();

            a12 = this.start.Text.Trim();
            a13 = this.stop.Text.Trim();



            b11 = this.textBox1.Text;
            b12 = this.textBox2.Text;
            b13 = this.textBox3.Text;
            b14 = this.textBox4.Text;
            b15 = this.textBox5.Text;
            b16 = this.textBox6.Text;

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);

            String str1 = "Update settings set color1='" + a + "',color2='" + b + "',color3='" + c + "',color4='" + d
                + "',color5='" + f

                + "',plc1='" + a1 + "',plcbt1='" + a2 + "',plcjy1='" + a3
                + "',plcst1='" + a4 + "',plcsp1='" + a5 + "',servo1='" + a6

                + "',link='" + a7
                + "',plc='" + a8 + "',plcbt='" + a11 + "',plcjy='" + a19
                + "',plcst='" + a12 + "',plcsp='" + a13 + "',servo='" + a9
                 + "', zxnum='" + b11 + "', lxnum='" + b12 + "', gynum='" + b13 + "', xhnum='" + b14
                  + "', lpjnum='" + b15 + "', ymgnum='" + b16
                + "' where id=1";


            // ff.ShowInfoTip(str1);
            SqlCommand com = new SqlCommand(str1, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();


            ff.ShowInfoTip("保存成功！,退出程序后加载");
            con.Close();

            AdminIndex admin = new AdminIndex();
            admin.Show();
            this.Close();
        }
        private Fuc ff = new Fuc();
        private void link_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog4.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                this.button5.BackColor = colorDialog4.Color;
                d = System.Drawing.ColorTranslator.ToHtml(this.button5.BackColor);
                Trace.Write("d:" + d);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog5.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                this.button6.BackColor = colorDialog5.Color;
                f = System.Drawing.ColorTranslator.ToHtml(this.button6.BackColor);
                Trace.Write("f:" + f);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog2.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                this.button2.BackColor = colorDialog2.Color;
                b = System.Drawing.ColorTranslator.ToHtml(this.button2.BackColor);
                Trace.Write("b:" + b);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog3.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                this.button3.BackColor = colorDialog3.Color;
                c = System.Drawing.ColorTranslator.ToHtml(this.button3.BackColor);
                Trace.Write("c:" + c);
            }

        }
    }
}
