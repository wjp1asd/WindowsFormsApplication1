using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Settings
{
    public partial class Settings1 : Form
    {
        public Settings1()
        {
            InitializeComponent();

            InitC();
        }

        public string a, b, c, d, f;
        public string a1, a2, a3, a4, a5, a6, a7, a8;
        public string a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23;

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
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
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
            AdminIndex admin = new AdminIndex();
            admin.Show();
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

                a1 = this.idtextBox2.Text = reader["idcard"].ToString();
                a2 = this.printtextBox3.Text = reader["print1"].ToString();
                a3 = this.scantextBox5.Text = reader["scan"].ToString();
                a4 = this.cameratextBox6.Text = reader["camera2"].ToString();
                a5 = this.cameratextBox7.Text = reader["camera1"].ToString();
                a6 = this.mousetextBox9.Text = reader["mouse"].ToString();
                a7 = this.link.Text = reader["link"].ToString(); ;
                a8 = this.PLCtextBox8.Text = reader["plc"].ToString();
                //   plcbt, plcjy, plcst, plcsp, DIxy, DIhw, DIB1, DIB2, DIB3, AIY1, AIy2, AIjy,MC
                a11 = this.bt.Text = reader["plcbt"].ToString();
                a19 = this.jy.Text = reader["plcjy"].ToString();

                a12 = this.start.Text = reader["plcst"].ToString();
                a13 = this.stop.Text = reader["plcsp"].ToString();

                a14 = this.xieya.Text = reader["DIxy"].ToString();
                a15 = this.hongwai.Text = reader["DIhw"].ToString();
                a16 = this.b1.Text = reader["DIB1"].ToString();
                a17 = this.b2.Text = reader["DIB2"].ToString();
                a18 = this.b3.Text = reader["DIB3"].ToString();

                a20 = this.y1.Text = reader["AIY1"].ToString();
                a21 = this.y2.Text = reader["AIY2"].ToString();
                a22 = this.jyy.Text = reader["AIjy"].ToString();
                a23 = this.dj.Text = reader["MC"].ToString();

                b11 = this.textBox1.Text = reader["lxnum"].ToString();
                b12 = this.textBox2.Text = reader["zxnum"].ToString();
                b13 = this.textBox3.Text = reader["gynum"].ToString();
                b14 = this.textBox4.Text = reader["xhnum"].ToString();
                b15 = this.textBox5.Text = reader["lpjnum"].ToString();
                b16 = this.textBox6.Text = reader["ymgnum"].ToString();

            }

            reader.Close();
            con.Close();
           // MessageBox.Show("系统配置加载成功");

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
            a1 = this.idtextBox2.Text.Trim();
            a2 = this.printtextBox3.Text.Trim();
            a3 = this.scantextBox5.Text.Trim();
            a4 = this.cameratextBox6.Text.Trim();
            a5 = this.cameratextBox7.Text.Trim();
            a6 = this.mousetextBox9.Text.Trim();
            a7 = this.link.Text.Trim();
            a8 = this.PLCtextBox8.Text.Trim();

            a11 = this.bt.Text.Trim();
            a19 = this.jy.Text.Trim();

            a12 = this.start.Text.Trim();
            a13 = this.stop.Text.Trim();

            a14 = this.xieya.Text.Trim();
            a15 = this.hongwai.Text.Trim();
            a16 = this.b1.Text.Trim();
            a17 = this.b2.Text.Trim();
            a18 = this.b3.Text.Trim();

            a20 = this.y1.Text.Trim();
            a21 = this.y2.Text.Trim();
            a22 = this.jyy.Text.Trim();
            a23 = this.dj.Text.Trim();

            b11 = this.textBox1.Text;
            b12 = this.textBox2.Text;
            b13 = this.textBox3.Text;
            b14 = this.textBox4.Text;
            b15 = this.textBox5.Text;
            b16 = this.textBox6.Text;

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);

            String str1 = "Update settings set color1='" + a + "',color2='" + b + "',color3='" + c + "',color4='" + d
                + "',color5='" + f + "',idcard='" + a1 + "',scan='" + a3 + "',camera1='" + a5
                   + "',mouse='" + a6 + "',link='" + a7 + "',plc='" + a8
                + "',camera2='" + a4 + "',print1='" + a2

                 + "',plcbt='" + a11 + "',plcjy='" + a19 + "',plcst='" + a12 + "',plcsp='" + a13
                   + "',DIxy='" + a14 + "', DIhw='" + a15 + "', DIB1='" + a16
                + "', DIB2='" + a17 + "', DIB3='" + a18 + "', AIY1='" + a20 + "', AIY2='" + a21
                + "', AIjy='" + a22 + "',MC='" + a23

                 + "', zxnum='" + b11 + "', lxnum='" + b12 + "', gynum='" + b13 + "', xhnum='" + b14
                  + "', lpjnum='" + b15 + "', ymgnum='" + b16
                + "' where id=1";


          //  MessageBox.Show(str1);
            SqlCommand com = new SqlCommand(str1, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();


            MessageBox.Show("保存成功！,退出程序后加载");
            con.Close();

            AdminIndex admin = new AdminIndex();
            admin.Show();
            this.Close();
        }

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
