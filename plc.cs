using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class plc : Form
    {
        private string serialPortName;
        byte[] first = new byte[] { 0x02, 0x00, 0x00, 0x04, 0x06 };
//#02 01 00 05 01 07
        byte[] io = new byte[] { 0x02, 0x01, 0x00, 0x05,0x01, 0x07 };
        string t1, t2, t3, t4, t5, t6, t7, t8;
        // 采集，8个通道，每个通道非0表示采集，为0表示不采集
        //02 11 00 0C 01 01 01 01 01 01 01 01 1F
        byte[] td1 = new byte[] { 0x02, 0x11, 0x00,0x0C, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,0x01, 0x1F };
        byte[] td = new byte[] { 0x02, 0x11, 0x00, 0x0C, 0x01,0x1F };
        Thread t;
        public plc()
        {
            InitializeComponent();
            t1 = "0x00"; t2 = "0x00"; t3= "0x00"; t4 = "0x00"; t5 = "0x00"; t6 = "0x00"; t7 = "0x00";
            t8 = "0x00";
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "打开串口")
            {//如果按钮显示的是打开
                try
                {//防止意外错误
                    serialPort2.PortName = comboBox1.Text;//获取comboBox1要打开的串口号
                    serialPortName = comboBox1.Text;
                    serialPort2.BaudRate = int.Parse(comboBox2.Text);//获取comboBox2选择的波特率
                    serialPort2.DataBits = int.Parse(comboBox4.Text);//设置数据位
                    /*设置停止位*/
                    if (comboBox3.Text == "1") { serialPort2.StopBits = StopBits.One; }
                    else if (comboBox3.Text == "1.5") { serialPort2.StopBits = StopBits.OnePointFive; }
                    else if (comboBox3.Text == "2") { serialPort2.StopBits = StopBits.Two; }
                    /*设置奇偶校验*/
                    if (comboBox5.Text == "无") { serialPort2.Parity = Parity.None; }
                    else if (comboBox5.Text == "奇校验") { serialPort2.Parity = Parity.Odd; }
                    else if (comboBox5.Text == "偶校验") { serialPort2.Parity = Parity.Even; }

                    serialPort2.Open();//打开串口
                    button1.Text = "关闭串口";//按钮显示关闭串口
                    MessageBox.Show("连接串口成功");
                    serialPort2.WriteLine("02 00 00 04 06");
                }
                catch (Exception err)
                {
                    MessageBox.Show("打开失败" + err.ToString(), "提示!");//对话框显示打开失败
                }
            }
            else
            {//要关闭串口
                try
                {//防止意外错误
                    serialPort2.Close();//关闭串口
                }
                catch (Exception) { }
                button1.Text = "打开串口";//按钮显示打开
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0219)
            {//设备改变
                if (m.WParam.ToInt32() == 0x8004)
                {//usb串口拔出
                    string[] ports = System.IO.Ports.SerialPort.GetPortNames();//重新获取串口
                    comboBox1.Items.Clear();//清除comboBox里面的数据
                    comboBox1.Items.AddRange(ports);//给comboBox1添加数据
                    if (button1.Text == "关闭串口")
                    {//用户打开过串口
                        if (!serialPort2.IsOpen)
                        {//用户打开的串口被关闭:说明热插拔是用户打开的串口
                            button1.Text = "打开串口";
                            serialPort2.Dispose();//释放掉原先的串口资源
                            comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;//显示获取的第一个串口号
                        }
                        else
                        {
                            comboBox1.Text = serialPortName;//显示用户打开的那个串口号
                        }
                    }
                    else
                    {//用户没有打开过串口
                        comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;//显示获取的第一个串口号
                    }
                }
                else if (m.WParam.ToInt32() == 0x8000)
                {//usb串口连接上
                    string[] ports = System.IO.Ports.SerialPort.GetPortNames();//重新获取串口
                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(ports);
                    if (button1.Text == "关闭串口")
                    {//用户打开过一个串口
                        comboBox1.Text = serialPortName;//显示用户打开的那个串口号
                    }
                    else
                    {
                        comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;//显示获取的第一个串口号
                    }
                }
            }
            base.WndProc(ref m);
        }
       
        string  a1, a2, a3, a4, a5, a6, a7,a8;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
       Thread.Sleep(500);
       int len = serialPort2.BytesToRead;//获取可以读取的字节数
       byte[] buff = new byte[len];//创建缓存数据数组
       serialPort2.Read(buff, 0, len);//把数据读取到buff数组

          

       //aio 模拟读取
       if (buff.Length == 37) {

                //通道1-8
               
        byte[] tt1 = buff.Skip(4).Take(4).ToArray();
                 t1=  ShowBy(tt1,1);
        byte[] tt2 = buff.Skip(8).Take(4).ToArray();
                t2 = ShowBy(tt2,2);
        byte[] tt3 = buff.Skip(12).Take(4).ToArray();
                t3 = ShowBy(tt3,3);
        byte[] tt4 = buff.Skip(16).Take(4).ToArray();
               t4 = ShowBy(tt4,4);
        byte[] tt5 = buff.Skip(20).Take(4).ToArray();
              t5 = ShowBy(tt5,5);
        byte[] tt6 = buff.Skip(24).Take(4).ToArray();
                t6 = ShowBy(tt6,6);
          byte[] tt7 = buff.Skip(28).Take(4).ToArray();
               t7 = ShowBy(tt7,7);
       byte[] tt8 = buff.Skip(32).Take(4).ToArray();
               t8 = ShowBy(tt8,8);
         }
        }
       
        private  string ShowBy(byte[] buff,int num)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            string hexstring = string.Empty;
            for (int i = 0; i < buff.Length; i++)
            {
                sb.AppendFormat("{0:x2}" + " ", buff[i]);
                if (i > 1) {

                    sb1.AppendFormat("{0:x2}", buff[i]);
                }
               
            }
            textBox1.AppendText("通道"+num+"信息：" );
            switch (num) { 
            
            case 1:
                    voldetla(sb1,t1);
                    break;
                case 2:
                  //  voldetla(sb1, t2);
                    break;
                case 3:
                  //  voldetla(sb1, t3);
                    break;
                case 4:
                  //  voldetla(sb1, t4);
                    break;
                case 5:
                  //  voldetla(sb1, t5);
                    break;
                case 6:
                  //  voldetla(sb1, t6);
                    break;
                case 7:
                   // voldetla(sb1, t7);
                    break;
                case 8:
                   // voldetla(sb1, t8);
                    break;
             
            }
           
            //textBox1.AppendText("长度：" + buff.Length);
            hexstring = sb1.ToString();


            return hexstring;

        }

        private void voldetla(StringBuilder sb1, string t8)
        {
            int a = Convert.ToInt32(sb1.ToString(), 16);
            int b= Convert.ToInt32(t8.ToString(), 16);

            textBox1.AppendText("当前通道：" + sb1.ToString());
            textBox1.AppendText("当前电压值：" + a);
            textBox1.AppendText("上次电压差：" + b);
            textBox1.AppendText("当前电压差：" + (a-b));
            textBox1.AppendText("变化速度：" +Math.Abs(a-b)/interval);
            SendServo(Math.Abs(a - b) / interval,b);
        }

        private void SendServo(int a,int pos)
        {
            byte[] d1 = new byte[] { 0x02, 0x45, 0x00, 0x1C, 
                
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,

                 0x5B
            };
            serialPort2.Write(d1, 0, d1.Length);
            Thread.Sleep(1000);
            byte[] d2 = new byte[] { 0x02, 0x45, 0x00, 0x1C,

               0x01, 0x05, 0xDC,
               0x01, 0x05, 0xDC,
               0x01, 0x05, 0xDC,
               0x01, 0x05, 0xDC,
               0x01, 0x05, 0xDC,
               0x01, 0x05, 0xDC,
               0x01, 0x05, 0xDC,
               0x01, 0x05, 0xDC,

                 0x5B
            };
            serialPort2.Write(d2, 0, d2.Length);
            Thread.Sleep(1000);
            byte[] d3 = new byte[] { 0x02, 0x45, 0x00, 0x1C,

                0x01, 0x09, 0xC4,
                0x01, 0x09, 0xC4,
                0x01, 0x09, 0xC4,
                0x01, 0x09, 0xC4,
               0x01, 0x09, 0xC4,
                0x01, 0x09, 0xC4,
                0x01, 0x09, 0xC4,
                0x01, 0x09, 0xC4,

                 0x5B
            };
            serialPort2.Write(d3, 0, d3.Length);
            Thread.Sleep(1000);


            //  string[] s3 = new string[s1.Length + s2.Length];
            // Array.Copy(s1, 0, s3, 0, s1.Length);
            //  Array.Copy(s2, 0, s3, s1.Length, s2.Length);

            // serialPort2.Write(s, 0, s.Length);

            //  C_APDU: //写PWM: 待续;Data:1Bytes Speed + 2Bytes Pos =24Bytes，Speed：1-20；Pos：500--2500us对应0x01F4--0x09C4
            //    02 45 00 1C 01 01 F4 01 01 F4 01 01 F4 01 01 F4 01 01 F4 01 01 F4 01 01 F4 01 01 F4 5B
            //舵机中位置
            //02 45 00 1C 01 05 DC 01 05 DC 01 05 DC 01 05 DC 01 05 DC 01 05 DC 01 05 DC 01 05 DC 5B
            //舵机正量程
            //02 45 00 1C 01 09 C4 01 09 C4 01 09 C4 01 09 C4 01 09 C4 01 09 C4 01 09 C4 01 09 C4 5B
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//清除接收对话框显示的数据
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("连接串口成功");

            byte[] s = new byte[] {0x02,0x00,0x00,0x04,0x06 };


            serialPort2.Write(s,0,s.Length);
            String Str = textBox2.Text.ToString();//获取发送文本框里面的数据
            try
            {
                if (Str.Length > 0)
                {

                    serialPort2.Write(Str);//串口发送数据

                }
            }
            catch (Exception) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();//清除发送文本框里面的内容
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void plc_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();//获取电脑上可用串口号
            comboBox1.Items.AddRange(ports);//给comboBox1添加数据
            comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;//如果里面有数据,显示第0个

            comboBox2.Text = "115200";/*默认波特率:115200*/
            comboBox3.Text = "1";/*默认停止位:1*/
            comboBox4.Text = "8";/*默认数据位:8*/
            comboBox5.Text = "无";/*默认奇偶校验位:无*/
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            serialPort2.Write(first, 0, first.Length);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

      //      serialPort2.Write(td1, 0, td1.Length);
          //   t = new Thread(Write2);
          //    t.Start();
        }
        int interval =500;
        private void Write2()
        {

            while (true) {
                serialPort2.Write(td1, 0, td1.Length);
                
                System.Threading.Thread.Sleep(interval);
               
                int len = serialPort2.BytesToRead;//获取可以读取的字节数
                byte[] buff = new byte[len];//创建缓存数据数组
                serialPort2.Read(buff, 0, len);//把数据读取到buff数组


               
                //aio 模拟读取
                if (buff.Length == 37)
                {

                    //通道1-8

                    byte[] tt1 = buff.Skip(4).Take(4).ToArray();
                    ShowBy(tt1, 1);
                    //byte[] tt2 = buff.Skip(8).Take(4).ToArray();
                    //ShowBy(tt2, 2);
                    //byte[] tt3 = buff.Skip(12).Take(4).ToArray();
                    //ShowBy(tt3, 3);
                    //byte[] tt4 = buff.Skip(16).Take(4).ToArray();
                    //ShowBy(tt4, 4);
                    //byte[] tt5 = buff.Skip(20).Take(4).ToArray();
                    //ShowBy(tt5, 5);
                    //byte[] tt6 = buff.Skip(24).Take(4).ToArray();
                    //ShowBy(tt6, 6);
                    //byte[] tt7 = buff.Skip(28).Take(4).ToArray();
                    //ShowBy(tt7, 7);
                    //byte[] tt8 = buff.Skip(32).Take(4).ToArray();
                    //ShowBy(tt8, 8);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort2.Write(td1, 0, td1.Length);
        }
    }

  
}
