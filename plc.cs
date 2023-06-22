using System;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Sunny.UI;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    //    // 离线校验问题
    //校验前准备
    //1.DI1 红外信
    //拆卸阀帽 红外传感器 输入 0或1，判断 阀帽是否拆卸 
    //2.选择压力表
    //也是红外传感器 关闭位置是不是决定使用哪个压力表，会不会被误操作使用两个。
    //假设 D1 阀帽拆卸传感器
    //        D0 校验阀(旋钮)
    //        D2 D3 D5 D6 代表仿真压力表
    //现在的外设都接全了，
    //切换阀--DI0，设置要预留几组切换阀开关；
    //工具接近开关--DI2，
    //红外距离传感器--DI1；
    //压力传感器---AI0；
    //仿真压力表舵机---PL0；
    //3.关闭泄压阀
    //DI3 泄压阀


   

    public partial class plc : Form
    {
        private string serialPortName;
        byte[] first = new byte[] { 0x02, 0x00, 0x00, 0x04, 0x06 };
        //#02 01 00 05 01 07 数字输入DI 读取
        byte[] io = new byte[] { 0x02, 0x01, 0x00, 0x05, 0x01, 0x07 };
        string t1, t2, t3, t4, t5, t6, t7, t8;
        // 采集DI，8个通道，每个通道非0表示采集，为0表示不采集
        //02 11 00 0C 01 01 01 01 01 01 01 01 1F
        byte[] td1 = new byte[] { 0x02, 0x11, 0x00, 0x0C, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x1F };
        byte[] td = new byte[] { 0x02, 0x11, 0x00, 0x0C, 0x01, 0x1F };
        // 采集AI，8个通道，每个通道非0表示采集，为0表示不采集
        //02 12 00 0C 01 01 01 01 01 01 01 01 1C
        byte[] ta1 = new byte[] { 0x02, 0x12, 0x00, 0x0C, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x1C };
        byte[] ta = new byte[] { 0x02, 0x12, 0x00, 0x0C, 0x01, 0x1C };
      

        public plc()
        {
            InitializeComponent();
            t1 = "0x00"; t2 = "0x00"; t3 = "0x00"; t4 = "0x00"; t5 = "0x00"; t6 = "0x00"; t7 = "0x00";
            t8 = "0x00";
        }


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
                    try
                    {
                        serialPort2.Open();//打开串口
                        button1.Text = "关闭串口";//按钮显示关闭串口
                       ff.ShowInfoTip("连接串口成功");
                        serialPort2.WriteLine("02 00 00 04 06");
                    }
                    catch (Exception err)
                    {
                       ff.ShowInfoTip("打开失败" + err.ToString());//对话框显示打开失败
                        throw;
                    }
                   
                   
                }
                catch (Exception err)
                {
                   ff.ShowInfoTip("打开失败" + err.ToString());//对话框显示打开失败
                }
            }
            else
            {//要关闭串口
                try
                {//防止意外错误
                   ff.ShowInfoTip("关闭串口成功");
                    serialPort2.Close();//关闭串口
                }
                catch (Exception) { }
                button1.Text = "打开串口";//按钮显示打开
            }
        }
        private Fuc ff = new Fuc();
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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Mat f1= new Mat();
        private void button6_Click(object sender, EventArgs e)
        {
            VideoCapture v = new VideoCapture(0);
            v.SetCaptureProperty(CapProp.FrameHeight, 720);
            v.SetCaptureProperty(CapProp.FrameWidth, 1280);
            if (!v.IsOpened) {
               ff.ShowInfoTip("open video fail");
                return;
            }

            Mat f = new Mat();
            while (true) {
              
                v.Read(f);
                if (f.IsEmpty) {

                   ff.ShowInfoTip("show fail");
                    break;
                }
                f1 = f;
                CvInvoke.Imshow("摄像头1：", f);
                if (CvInvoke.WaitKey(30) == 27) {

                    break;
                }
            }


        }
        private void button7_Click(object sender, EventArgs e)
        {
            VideoCapture v = new VideoCapture(1);
            v.SetCaptureProperty(CapProp.FrameHeight, 720);
            v.SetCaptureProperty(CapProp.FrameWidth, 1280);
            if (!v.IsOpened)
            {
               ff.ShowInfoTip("open video fail");
                return;
            }
            Mat f = new Mat();

            while (true)
            {

                v.Read(f);
                if (f.IsEmpty)
                {

                   ff.ShowInfoTip("show fail");
                    break;
                }
                f1 = f;
                CvInvoke.Imshow("摄像头2：", f);
                if (CvInvoke.WaitKey(30) == 27)
                {

                    break;
                }
            }
        }
        string url = "//BNY-PC/Users/BNY/Desktop/考试图片/"+DateTime.Now.ToString("yy-mm-dd-hh-ii-ss");
        private void button8_Click(object sender, EventArgs e)
        {
            CvInvoke.Imwrite(url+"shot.png",f1);
           ff.ShowInfoTip("拍照成");
        }
        // DI 输入的集合


        string DIS ;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            int len = serialPort2.BytesToRead;//获取可以读取的字节数
            byte[] buff = new byte[len];//创建缓存数据数组
            serialPort2.Read(buff, 0, len);//把数据读取到buff数组



            //aio 模拟读取
            if (buff.Length == 37)
            {

                //通道1-8
                // 校验阀旋钮DI0
                byte[] tt1 = buff.Skip(4).Take(4).ToArray();
                t1 = ShowBy(tt1, 1);
                // 选择量程的接近开关 DI1 

                byte[] tt2 = buff.Skip(8).Take(4).ToArray();
                // 阀帽拆卸红外传感器 D

                t2 = ShowBy(tt2, 2);
                byte[] tt3 = buff.Skip(12).Take(4).ToArray();
                // 选择量程的接近开关 DI1 


                t3 = ShowBy(tt3, 3);
                byte[] tt4 = buff.Skip(16).Take(4).ToArray();
                t4 = ShowBy(tt4, 4);
                byte[] tt5 = buff.Skip(20).Take(4).ToArray();
                t5 = ShowBy(tt5, 5);
                byte[] tt6 = buff.Skip(24).Take(4).ToArray();
                t6 = ShowBy(tt6, 6);
                byte[] tt7 = buff.Skip(28).Take(4).ToArray();
                t7 = ShowBy(tt7, 7);
                byte[] tt8 = buff.Skip(32).Take(4).ToArray();
                t8 = ShowBy(tt8, 8);
            }
          
            if(buff.Length==6){
                // DI 读取 10jinzhi fanhui
                byte[] tt1 = buff.Skip(4).Take(1).ToArray();
                string a = Convert.ToString(tt1[0], 2);
                textBox3.Text = "DI back:" + a;
                string b = "";
                switch (a.Length) {

                    case 1:
                        b = "0000000" + a;
                        break;
                    case 2:
                        b = "000000" + a;
                        break;
                    case 3:
                        b = "00000" + a;
                        break;
                    case 4:
                        b = "0000" + a;
                        break;
                    case 5:
                        b = "000" + a;
                        break;
                    case 6:
                        b = "00" + a;
                        break;
                    case 7:
                        b = "0" + a;
                        break;
                    case 8:
                        b = a;
                        break;
                }

                
               DIS= b;
             textBox3.Text = "DI back:"+DIS;
                if (DIS.Length == 8) {

                    fenxi();
                }
               

            }
        }
        //通道
        int qiehuanfa = 1;
        int gongju = 2;
        int hongwai = 3;
        int xieya = 8;
        private void fenxi()
        {
            //123 7
            if (DIS[8 - qiehuanfa] + "" == "0")
            {
                textBox3.Text += "切换阀打开";

                this.uiLight1.Style = Sunny.UI.UIStyle.Red;
            }
            else { 
           
            }

            if (DIS[7-hongwai] + "" == "0")
            {
              textBox3.Text += "阀帽存在";
                this.uiLight2.Style = Sunny.UI.UIStyle.Red;
            }
            if (DIS[7-(gongju)] + "" == "0")
            {
               textBox3.Text += "工具归位";
                this.uiLight3.Style = Sunny.UI.UIStyle.Red;
            }
            if (DIS[7-( xieya)] + "" == "0")
            {
                textBox3.Text += "卸压阀打开";
                this.uiLight4.Style = Sunny.UI.UIStyle.Red;
            }
        }

        static string HexString2BinString(string hexString)
        {
            try
            {
                string result = string.Empty;
                foreach (char c in hexString)
                {
                    int v = Convert.ToInt32(c.ToString(), 16);
                    int v2 = int.Parse(Convert.ToString(v, 2));
                    // 去掉格式串中的空格，即可去掉每个4位二进制数之间的空格，
                    result += string.Format("{0:d4} ", v2);
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }


        private string ShowBy(byte[] buff, int num)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            string hexstring = string.Empty;
            for (int i = 0; i < buff.Length; i++)
            {
                sb.AppendFormat("{0:x2}" + " ", buff[i]);
                if (i > 1)
                {

                    sb1.AppendFormat("{0:x2}", buff[i]);
                }

            }
            textBox1.AppendText("通道" + num + "信息：");
            switch (num)
            {

                case 1:
                    voldetla(sb1, t1);
                    break;
                //case 2:
                //    voldetla(sb1, t2);
                //    break;
                //case 3:
                //    voldetla(sb1, t3);
                //    break;
                //case 4:
                //   voldetla(sb1, t4);
                //    break;
                //case 5:
                //   voldetla(sb1, t5);
                //    break;
                //case 6:
                //    voldetla(sb1, t6);
                //    break;
                //case 7:
                //    voldetla(sb1, t7);
                //    break;
                //case 8:
                //    voldetla(sb1, t8);
                //    break;

            }

            //textBox1.AppendText("长度：" + buff.Length);
            hexstring = sb1.ToString();


            return hexstring;

        }

        private void voldetla(StringBuilder sb1, string t8)
        {
            int a = Convert.ToInt32(sb1.ToString(), 16);
            int b = Convert.ToInt32(t8.ToString(), 16);

            textBox1.AppendText("当前通道：" + sb1.ToString());
            textBox1.AppendText("当前电压值：" + a);
            textBox1.AppendText("上次电压差：" + b);
            textBox1.AppendText("当前电压差：" + (a - b));
            textBox1.AppendText("变化速度：" + Math.Abs(a - b) / interval);
            SendServo(Math.Abs(a - b) / interval, b);
        }

        private void SendServo(int a, int pos)
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
           ff.ShowInfoTip("关闭串口成功");

            serialPort2.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();//清除发送文本框里面的内容
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 模拟红外距离变化



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
            if (!serialPort2.IsOpen)
            {

               ff.ShowInfoTip("open串口");
                return;
            }

            serialPort2.Write(first, 0, first.Length);
        }
        Thread readDI;
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen) {

              ff.ShowInfoTip("open串口");
                return;
            }
           

             readDI = new Thread(ReadDI);
             readDI.Start();
        }
        int interval = 500;


        byte[] dio = new byte[] { 0x02, 0x01, 0x00, 0x05, 0x01, 0x07 };
        int a = 0;

        private void ReadDI()
        {
            
            while (true)
            {
                serialPort2.Write(dio, 0, dio.Length);

                System.Threading.Thread.Sleep(1000);
                a++;

                
            }
            textBox3.Text = "DI读取：" + a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort2.Write(td1, 0, td1.Length);
        }
    }


}
