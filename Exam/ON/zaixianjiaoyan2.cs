using AutoWindowsSize;
using Emgu.CV.CvEnum;
using Emgu.CV;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;
using Sunny.UI;
using System.Configuration;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using ZedGraph;

namespace WindowsFormsApplication1.Exam
{
    public partial class zaixianjiaoyan2 : Form
    {
        TestRecord t = new TestRecord();
        Wucha wucha = new Wucha();
        string url = Application.StartupPath + "\\Images\\考试照片\\" + DateTime.Now.ToString("yy-mm-dd-hh-ii-ss");
        private string serialPortName;
        byte[] first = new byte[] { 0x02, 0x00, 0x00, 0x04, 0x06 };
        //#02 01 00 05 01 07 数字输入DI 读取
        byte[] io = new byte[] { 0x02, 0x01, 0x00, 0x05, 0x01, 0x07 };
        //初始电位器的码值 t1,当前码值t2
        string t1 = "", t2 = "";
        // 整体采集，每个通道非0表示采集，为0表示不采集
        //02 11 20 0C 01 01 01 01 01 01 01 01 1F Lrc  td1 =header +content +lrc
        byte[] topheader = new byte[] { 0x02, 0x20, 0x00, 0x0C };
        byte[] content = new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01 };//全采集
        byte[] td1 = new byte[13];

        // 量程表转（转的码值参考《计算 码值、公斤值》中的码值表）
        //关闭校验阀、打开泄压阀（无先后顺序） 
        //量程表归0
        bool correct1 = false;
        bool correct2 = false;
        bool correct3 = false;


        datahelp datahelp = new datahelp();
        // Di 端口的一些设备 切换阀 DI0 工具检测DI1 阀帽红外 后续需要拓展
        int youbiaokachi = 0;
        int lianjiegan = 0;
        int faban = 0;
        int gongju = 0;
        int famao = 0;
        int siheyi = 0;
        int step = -1;
        //量程选择 1.6 4 25 
        int liangcheng = 4;
        // AO  仿真压力表 舵机 后续需要拓展

        int fangzhen1 = 0;
        int fangzhen2 = 0;
        public zaixianjiaoyan2()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
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

        private void CALCf(object sender, EventArgs e)
        {
            try
            {
                int mfzj = int.Parse(textBox1.Text.Trim());
                double zdyl = double.Parse(t.Zxyl);
                double xtyl = double.Parse(textBox2.Text.Trim());

                double F = (zdyl - xtyl) * (mfzj / 2) * (mfzj / 2) * 3.2/10;
                this.textBox3.Text = F.ToString();

                double PS = F * 10 / (mfzj / 2) * (mfzj / 2) * 3.2 + xtyl;
                this.richTextBox2.Text += "开启压力"+PS;
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        Thread tj;
        int x=0;
        int y=1;
        // 开启压力 F 红点外加力 S密封 直径 Po系统压力
        private void zaixianjiaoyan2_Load(object sender, EventArgs e)
        {
             
            Initchart();
          
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
            t = t.getRecord(datahelp.QId);
            showMsg();
            topheader.CopyTo(td1, 0);
            content.CopyTo(td1, topheader.Length);

            byte a = CalcLRC(td1);
            td1[12] = (byte)a;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (datahelp.LxTime > 0)
            {
                datahelp.LxTime--;
                int min = datahelp.LxTime / 60;
                int sec = datahelp.LxTime % 60;
                this.label1.Text = string.Format("{0:00}:{1:00}", min, sec);
                Control.CheckForIllegalCrossThreadCalls = false;
              //  Random a = new Random();
              //  int x = a.Next(100);
               // y++;
              
              

            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("时间到了");
                //AnswerForm frm = new AnswerForm();
                //frm.MdiParent = this.MdiParent;
                //frm.Show();
                //this.Close();
            }
        }
        private void Initnum()
        {
          
        }

        private void Initchart()
        {
          
            chart1.Series[0].Points.Clear();
            this.chart1.BackColor = Color.Azure;             //图表背景色  
            this.chart1.Titles.Add("CO2浓度");                //图表标题
            //新建连接 
          
            //注意数据绑定后，它的series是1而不是0  本来正常应该是1   博文后注
            this.chart1.Series[0].ChartType = SeriesChartType.Spline;
            //this.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yyyy-MM-dd-HH:mm:ss";
        
            this.chart1.Series[0].IsValueShownAsLabel = false;             //是否显示数据      
            this.chart1.Series[0].IsVisibleInLegend = false;              //是否显示数据说明  
            this.chart1.Series[0].MarkerStyle = MarkerStyle.Circle;        //线条上的数据点标志类型  
            this.chart1.Series[0].MarkerSize = 8;                          //标志大小  

            this.chart1.ChartAreas[0].AxisX.LineColor = Color.Blue;            //X轴颜色  
            this.chart1.ChartAreas[0].AxisY.LineColor = Color.Blue;            //Y轴颜色
            this.chart1.ChartAreas[0].AxisX.LineWidth = 2;                     //X轴宽度
            this.chart1.ChartAreas[0].AxisY.LineWidth = 2;                      //Y轴宽度  
         
        }

        public static byte CalcLRC(byte[] data)
        {
            //112
            byte lrc = 0x00; for (int i = 0; i < data.Length; i++) { lrc ^= data[i]; }
            return lrc;
        }
        Mat f1 = new Mat();
            private void button6_Click(object sender, EventArgs e)
            {
                VideoCapture v = new VideoCapture(0);
                v.SetCaptureProperty(CapProp.FrameHeight, 720);
                v.SetCaptureProperty(CapProp.FrameWidth, 1280);
                if (!v.IsOpened)
                {
                    MessageBox.Show("open video fail");
                    return;
                }

                Mat f = new Mat();
                while (true)
                {

                    v.Read(f);
                    if (f.IsEmpty)
                    {

                        MessageBox.Show("show fail");
                        break;
                    }
                    f1 = f;
                    CvInvoke.Imshow("摄像头1：", f);
                    if (CvInvoke.WaitKey(30) == 27)
                    {

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
                    MessageBox.Show("open video fail");
                    return;
                }
                Mat f = new Mat();

                while (true)
                {

                    v.Read(f);
                    if (f.IsEmpty)
                    {

                        MessageBox.Show("show fail");
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
        Fuc ff= new Fuc();  
            private void shot()
            {
             

                CvInvoke.Imwrite(url + "shot.png", f1);
                ff.ShowInfoTip("拍照成功");
            }
            // DI 输入的集合

            private void backCamera()
            {

                VideoCapture v = new VideoCapture(0);
               // v.SetCaptureProperty(CapProp.FrameHeight, 720);
                //v.SetCaptureProperty(CapProp.FrameWidth, 1280);
                if (!v.IsOpened)
                {
                    MessageBox.Show("open video fail");
                    return;
                }
                step = 0;
                Mat f = new Mat();
                while (true)
                {

                    v.Read(f);
                    if (f.IsEmpty)
                    {

                        MessageBox.Show("show fail");
                        break;
                    }
                    f1 = f;
                    CvInvoke.Imshow("摄像头1：", f);
                    if (CvInvoke.WaitKey(30) == 27)
                    {

                        break;
                    }
                }
            }

        public void plcinit()
        {
            datahelp datahelp = new datahelp();
            datahelp.Initc();
                 
            string connectionString = ConfigurationManager.AppSettings["sqlc"]; SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from biaoding";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                string name = reader["type"].ToString().Trim();
                switch (name)
                {
                    case "连接杆":
                        lianjiegan = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;

                    case "四合一":
                        siheyi = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;


                    case "游标卡尺":
                        youbiaokachi = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                  
                    case "阀瓣":
                        faban = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "在线工具":
                        gongju = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "在线阀帽":
                        famao = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "在线压力1":
                        fangzhen1 = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "在线压力2":
                        fangzhen2 = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                }

            }
            // 130012
            MessageBox.Show(youbiaokachi +"-"+ faban + "-" + famao + "-" + fangzhen1 + "-" + fangzhen2+"-" + + gongju + "");

            //采集卡初始化+舵机控制板
            try
            {
                //// Di 端口的一些设备 切换阀 DI0 工具检测DI1 阀帽红外 后续需要拓展 舵机

                ////topheader.CopyTo(td1,0);
                ////content.CopyTo(td1, topheader.Length);
                ////byte a = CalcLRC(td1);
                ////td1[13] = a;
                ////防止意外错误
                //serialPort1.PortName = datahelp.servo1.Trim();//获取comboBox1要打开的串口号

                //serialPort1.BaudRate = 9600;//获取comboBox2选择的波特率
                //serialPort1.DataBits = 8;//设置数据位
                ///*设置停止位*/
                //// if (datahelp.plcsp.Trim() == "1") { SER5.StopBits = StopBits.One; }
                ////else if (datahelp.plcsp.Trim() == "1.5") { SER5.StopBits = StopBits.OnePointFive; }
                ////else if (datahelp.plcsp.Trim() == "2") { SER5.StopBits = StopBits.Two; }
                /////*设置奇偶校验*/
                //serialPort1.Parity = Parity.None;
                //try
                //{
                //    serialPort1.Open();//打开串口
                //    button3.Text = "正在连接";//按钮显示关闭串口

                //    //  SER5.WriteLine("02 00 00 04 06");
                //   richTextBox2.Clear();
                //    SetZero1();

                //}
                //catch (Exception err)
                //{
                //    MessageBox.Show("打开失败" + err.ToString(), "提示!");//对话框显示打开失败
                //    throw;
                //}

                //防止意外错误
                serialPort2.PortName = datahelp.plc1.Trim();//获取comboBox1要打开的串口号

                serialPort2.BaudRate = int.Parse(datahelp.plcbt1.Trim());//获取comboBox2选择的波特率
                serialPort2.DataBits = int.Parse(datahelp.plcjy1.Trim());//设置数据位
                /*设置停止位*/
                if (datahelp.plcsp1.Trim() == "1") { serialPort2.StopBits = StopBits.One; }
                else if (datahelp.plcsp1.Trim() == "1.5") { serialPort2.StopBits = StopBits.OnePointFive; }
                else if (datahelp.plcsp1.Trim() == "2") { serialPort2.StopBits = StopBits.Two; }
                /*设置奇偶校验*/
                serialPort2.Parity = Parity.None;
                try
                {
                    serialPort2.Open();//打开串口
                    button3.Text = "正在连接";//按钮显示关闭串口

                    serialPort2.WriteLine("02 00 00 04 06");
                   richTextBox2.Clear();
                    // SetZero();//正确的方法先注视

                }
                catch (Exception err)
                {
                    MessageBox.Show("打开失败" + err.ToString(), "提示!");//对话框显示打开失败
                    throw;
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("打开失败" + err.ToString(), "提示!");//对话框显示打开失败
            }




        }


        private void SetZero1()
        {
            //舵机归零

            byte[] d1 = new byte[] {
                0xFF,0x01,0x00,0x0a,0x00,
                0xFF, 0x02, 0x00, 0xC4,0x09
            };

            //  MessageBox.Show(BitConverter.ToString(d1)) ;
           // serialPort1.Write(d1, 0, d1.Length);
            Thread.Sleep(1000);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            this.plcinit();
        }


        string DIS0;
        string DIS;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            int len = serialPort2.BytesToRead;//获取可以读取的字节数
            byte[] buff = new byte[len];//
            serialPort2.Read(buff, 0, len);//把数据读取到buff数组
                                           // 通讯读取
                                           //MessageBox.Show(BitConverter.ToString(buff));
            //   MessageBox.Show(len.ToString());
            //   MessageBox.Show(name);
            
            if (buff.Length == 38)
            {
                Action t = () =>
                {
                   richTextBox2.Clear();

                };
                this.Invoke(t);
                dishow(BitConverter.ToString(buff));
                //richTextBox2.Clear();
                //38位
                //MessageBox.Show(BitConverter.ToString(buff));
                // AI解析
                byte[] ttt1 = new byte[4];
                byte[] ttt2 = new byte[4];

                byte[] tt1 = buff.Skip(4).Take(1).ToArray();

                string a = Convert.ToString(tt1[0], 2).Trim();
                //int f = Convert.ToInt32(a.ToString(), 16);
                // MessageBox.Show(BitConverter.ToString(buff)+","+f);

                Console.WriteLine("Di:" + a);
                // MessageBox.Show(a);
                string b = "";
                //if (DIS0 == a)
                //{
                //    dishow("DI无变化");
                //    return;
                //}
                //else
                {

                    switch (a.Length)
                    {

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


                    DIS = b;
                    Action tongdao = () =>
                    {
                        uiLedLabel4.Text = DIS;
                    };
                    this.Invoke(tongdao);

                    if (DIS.Length == 8)
                    {
                        DIS0 = a;
                        //di状态分析
                   //     fenxi();
                    }



                }

                switch (fangzhen1)
                {
                    case 0:
                        ttt2 = buff.Skip(5).Take(4).ToArray();
                        break;

                    case 1:
                        ttt2 = buff.Skip(9).Take(4).ToArray();
                        break;
                    case 2:
                        ttt2 = buff.Skip(13).Take(4).ToArray();
                        break;
                    case 3:
                        ttt2 = buff.Skip(17).Take(4).ToArray();
                        break;
                    case 4:
                        ttt2 = buff.Skip(21).Take(4).ToArray();
                        break;
                    case 5:
                        ttt2 = buff.Skip(25).Take(4).ToArray();
                        break;
                    case 6:
                        ttt2 = buff.Skip(29).Take(4).ToArray();
                        break;
                    case 7:
                        ttt2 = buff.Skip(33).Take(4).ToArray();
                        break;



                }





                ////MessageBox.Show(BitConverter.ToString(ttt1));
                //MessageBox.Show(BitConverter.ToString(ttt2));



                t1 = "";
                t2 = ShowBy(ttt2, 2);
                // DI解析




            }
            else
            {
                //this.label3.Text=""+buff.Length;
                // ff.ShowErrorDialog("设备无反应");


            }
        }

        private void fenxi()
        {

          int a = Convert.ToInt32(t1.ToString(), 16);
           //  MessageBox.Show(sb1.ToString()+a);
         int b = Convert.ToInt32(t2.ToString(), 16);
            if (Math.Abs(a - b) == 0)
            {
                //校验阀关闭
                dishow("校验阀关闭");

            }

            if (DIS[7 - youbiaokachi] + "" == "0")
            {
                dishow("游标卡尺归位");
                liangcheng = 1;
            }
            else
            {
                dishow("游标卡尺离开");

                //richTextBox2.Text += "切换阀关闭";
            }
            if (DIS[7 - lianjiegan] + "" == "0")
            {
                dishow("连接杆归位");
                liangcheng = 3;
            }
            else
            {
                dishow("连接杆离开");

                //richTextBox2.Text += "切换阀关闭";
            }
            if (DIS[7 - siheyi] + "" == "0")
            {
                dishow("四合一归位");
                liangcheng = 3;
            }
            else
            {
                dishow("四合一离开");

                //richTextBox2.Text += "切换阀关闭";
            }



            if (DIS[7 - faban] + "" == "0")
            {
                dishow("阀瓣归位");
                liangcheng = 3;
            }
            else
            {
                dishow("阀瓣离开");

                //richTextBox2.Text += "切换阀关闭";
            }


            if (DIS[7 - famao] + "" == "0")
            {
                //richTextBox2.Text += "阀帽存在";
                dishow("在线阀帽存在");
            }
            else
            {
                dishow("在线阀帽拆卸");
                //richTextBox1.Text += "阀帽拆卸";
                //开始拍照
                chaixiefamao();
            }


            if (DIS[7 - gongju] + "" == "0")
            {
                dishow("在线工具归位");
                //richTextBox2.Text += "工具归位";

            }
            else
            {
                dishow("在线工具离开");
                //richTextBox2.Text += "工具离开";
            }


          
        }

        private void dishow(string msg)
        {
            Action tongdao = () =>
            {
               richTextBox2.Text += msg;
            };
            this.Invoke(tongdao);


        }

        private void guanbixieyafa()
        {
            // 考点
            switch (step)
            {

                case 1:
                    test1();
                    break;
                case 2:
                    test2();
                    break;
                case 3:
                    test3();
                    break;
                case 4:
                    test4();
                    break;
            }





        }

        private void test4()
        {
            //密封性能测试
            // throw new NotImplementedException();
        }

        private void test3()
        {
            //第三次测试
            //  throw new NotImplementedException();
        }

        private void test2()
        {
            //第二次测试
            //  throw new NotImplementedException();
        }

        private void test1()
        {
            //第一次测试第一次校验：
            //            开校验阀时判断 切换阀打开、泄压阀关闭
            //                             不正确  提示请检查你的操作是否正确。
            //  一分钟之内操作正确得分
            //                 正确     量程表转（转的码值参考《计算 码值、公斤值》中的码值表）
            //关闭校验阀、打开泄压阀（无先后顺序） 
            //量程表归0

            this.label1.Text = "泄压阀关闭，请打开校验阀";
        }

        private void chaixiefamao()
        {
            shot();
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

            string sb1 = BitConverter.ToString(buff).Replace("-", "");

            if (t1.Length == 0)
            {

                t1 = sb1;
            }





            Action tongdao = () =>
            {
                richTextBox2.AppendText("通道" + num + "信息：");
                richTextBox2.AppendText("" + sb1);
            };
            this.Invoke(tongdao);


            switch (num)
            {

                case 1:
                    if (sb1.Length > 0 && t1.Length > 0)
                    {
                        voldetla(sb1, t1);

                    }

                    break;
                case 2:
                    if (sb1.Length > 0 && t1.Length > 0)
                    {
                        voldetla(sb1, t1);

                    }

                    break;
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

            //richTextBox2.AppendText("长度：" + buff.Length);



            return sb1;

        }
        public static int HexToDecimal(string hex)
        {
            if (!Regex.Match(hex, "^[0-9A-F]$", RegexOptions.IgnoreCase).Success)
            {
                throw new Exception("不是十六进制数字");
            }

            var decimalValue = 0;

            var hexUp = hex.ToUpper();
            // 从最后一位到第一位循环获取每位的值，并乘以基数的n-1次方
            for (int i = hexUp.Length - 1; i >= 0; i--)
            {
                int currV = 0;
                switch (hexUp[i])
                {
                    case 'A':
                        currV = 10;
                        break;
                    case 'B':
                        currV = 11;
                        break;
                    case 'C':
                        currV = 12;
                        break;
                    case 'D':
                        currV = 13;
                        break;
                    case 'E':
                        currV = 14;
                        break;
                    case 'F':
                        currV = 15;
                        break;
                    case '0':
                        currV = 0;
                        break;
                    case '1':
                        currV = 1;
                        break;
                    case '2':
                        currV = 2;
                        break;
                    case '3':
                        currV = 3;
                        break;
                    case '4':
                        currV = 4;
                        break;
                    case '5':
                        currV = 5;
                        break;
                    case '6':
                        currV = 6;
                        break;
                    case '7':
                        currV = 7;
                        break;
                    case '8':
                        currV = 8;
                        break;
                    case '9':
                        currV = 9;
                        break;
                    default:
                        break;
                }

                for (int n = 0; n < hexUp.Length - 1 - i; n++)
                {
                    currV *= 16;
                }
                decimalValue += currV;
            }
            return decimalValue;
        }
        //上次电压值
        private int dwq;
        string cz;
        int interval = 1000;
        private void voldetla(string sb1, string t8)
        {
            //cz从离线压力设置-初次测试压力中取值
            cz = "1.2";
            //y为对应（500-2500）中的码值
            //  int y = (2000 * Convert.ToInt32( cz) )/Convert.ToInt32 (1.6);

            int a = Convert.ToInt32(sb1.ToString(), 16);
            // MessageBox.Show(sb1.ToString()+a);
            int b = Convert.ToInt32(t8.ToString(), 16);

            Action tongdao = () =>
            {
                richTextBox2.Clear();
             //   richTextBox2.AppendText("当前循环时间：" + smin);

              //  richTextBox2.AppendText("当前电压差：" + (dwq - a));


                richTextBox2.AppendText("当前舵机码值：" + maz);
                richTextBox2.AppendText("当前循环次数：" + cisu);
                richTextBox2.AppendText("上次电位器码值码值：" + dwq);

                richTextBox2.AppendText("当前通道：" + sb1.ToString());
                richTextBox2.AppendText("当前电位器码值（电压值）：" + a);
                
               float b1 = (a / 10000 / 5)*5000;
               float b2 = 0;
                switch (liangcheng)
                {
                    case 1:
                        b2 = b1 * 200;
                        richTextBox2.AppendText("当前压力：" + b1 * 200 + "KG");
                        break;
                    case 2:
                        b2 = b1 * 500;
                        richTextBox2.AppendText("当前压力：" + b1 * 500 + "KG");
                        break;
                    case 3:
                         b2 = b1 * 2000;
                        richTextBox2.AppendText("当前压力：" + b1 * 2000 + "KG");
                        break;
                    case 4:
                         b2 = b1 * 5000;
                        richTextBox2.AppendText("当前压力：" + b1 * 5000 + "KG");
                        break;
                }
                this.chart1.Series[0].Points.AddXY(cisu, b1);
               MessageBox.Show(b1.ToString());
                richTextBox2.AppendText("上次电压差：" + b);
                richTextBox2.AppendText("变化速度：" + Math.Abs(a - b) / interval);
                calyali(a);
            };
            this.Invoke(tongdao);

            if (Math.Abs(a) < 119000)
            {

                SendServo1(a, 0);
                // SendServo(a, 0);//正确的方法先注视
                //     SendServo(Math.Abs(a - b) / interval, b);

            }
            else
            {
            //    dishow("校验阀关闭");
                //if (DIS[7 - xieya] + "" == "0")
                //{
                //    dishow("卸压阀打开");
                //    //richTextBox2.Text += "卸压阀打开";
                //    if (maz <= 2500 & maz > 500)
                //    { maz += 13; }

                //    smin = 200;
                //}
                //else
                //{
                //    dishow("卸压阀关闭");
                //    // xieya  richTextBox2.Text += "卸压阀关闭";
                //    //    guanbixieyafa();
                //}
            }
        }
        int czmaz;


        private void SendServo1(int a, int pos)
        {

            Action tongdao = () =>
            {
                this.richTextBox2.Text += "舵机就位";

            };

            this.Invoke(tongdao);

            //舵机驱动

            byte[] d3 = new byte[] {
                0xFF,0x01,0x00,0x0a,0x00,
                0xFF, 0x02, 0x00, 0xC4,0x09};
            //高八度低八度取值
            d3[3] = (byte)(maz & 0x00ff);
            d3[4] = (byte)((maz >> 8) & 0xff);
            //目标码值（离线压力设置-初次测试压力）
            d3[9] = (byte)((czmaz >> 8) & 0xff);
            d3[8] = (byte)(czmaz & 0x00ff);

         //   serialPort1.Write(d3, 0, d3.Length);

            if (dwq - a > 100)
            {

                maz += 1;

            }
            Thread.Sleep(1000);
            if (a < 119000)
            { dwq = a; }
            if (maz > 1)
            {
                cisu = cisu + 1;
                maz -= 1;

            }

        }


        private void calyali(int a)
        {
            //
            int b = (a / 10000 / 5);
            this.chart1.Series[0].Points.AddXY(cisu, b);
            switch (liangcheng)
            {
                case 1:
                    richTextBox2.AppendText("当前压力：" + b * 200 + "KG");
                    break;
                case 2:
                    richTextBox2.AppendText("当前压力：" + b * 500 + "KG");
                    break;
                case 3:
                    richTextBox2.AppendText("当前压力：" + b * 2000 + "KG");
                    break;
                case 4:
                    richTextBox2.AppendText("当前压力：" + b * 5000 + "KG");
                    break;
            }
        }

        private void SetZero()
        {
            //舵机归零
            byte[] d1 = new byte[] { 0x02, 0x45, 0x00, 0x1C,
                //通道1
                0x01, 0x09, 0xC4,
                //通道2
                0x01, 0x09, 0xC4,
                //通道3
                0x01,  0x09, 0xC4,
                //通道4
                0x01,  0x09, 0xC4,
                //通道5
                0x01,  0x09, 0xC4,
                //通道6
                0x01, 0x09, 0xC4,
                //通道7
                0x01,  0x09, 0xC4,
                //通道8
                0x01,  0x09, 0xC4,

                 0x5B
            };

            //  MessageBox.Show(BitConverter.ToString(d1)) ;
            serialPort2.Write(d1, 0, d1.Length);
            Thread.Sleep(1000);
        }
        //码值初始值(范围500-2500)，时间最大值(压力变化，舵机表越走越快)
        int maz = 2500;
        int smin = 1000;
        int cisu = 0;

        private void SendServo(int a, int pos)
        {

            //MessageBox.Show(a.ToString());
            //int b = (a / 1000 / 5)*2500;
            //string b1 = b.ToString("X4");
            // MessageBox.Show(""+b);
            // MessageBox.Show(b1.ToString());
            //  int a2 = int.Parse("0x"+ b1.Substring(0, 2));
            // int a3 = int.Parse("0x" + b1.Substring(2));

            // MessageBox.Show(""+b1);
            //string    maz1 = maz.ToString("X4");
            //     // int maz1 =Convert.ToInt32( maz.ToString(),16);
            //    // byte a2;byte a3;
            // MessageBox.Show(maz.ToString());
            //    int a2 =Convert.ToInt32( maz1.ToString().Substring(0, 2));
            //    int a3 =Convert.ToInt32( maz1.ToString().Substring(2));
            //      MessageBox.Show(a2.ToString());
            //   MessageBox.Show(a3.ToString());
            //     MessageBox.Show(BitConverter.ToString(maz2));
            byte[] d3 = new byte[] {
                0x02, 0x45, 0x00, 0x1C,
                0x01, 0x01,0xf4,//(byte)a2, (byte)a3,              
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
            };
            //高八度低八度取值
            d3[6] = (byte)(maz & 0x00ff);
            d3[5] = (byte)((maz >> 8) & 0xff);

            byte o = CalcLRC(d3);

            byte[] d4 = new byte[] {
             0x02, 0x45, 0x00, 0x1C,
             0x01, d3[5],d3[6],
            //0x01, 0x05, 0xDC,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                0x01, 0x01, 0xF4,
                o
            };

            //serialPort1.Write(d4, 0, d4.Length);

            if (dwq - a > 100)
            {
                if (smin > 100)
                {
                    smin = smin - 100;
                }
            }
            Thread.Sleep(smin);
            if (a < 119000)
            { dwq = a; }
            if (maz > 500 & maz <= 2500)
            {
                cisu = cisu + 1;
                maz -= 13;
                if (maz < 500)
                { maz = 500; }
            }
            // MessageBox.Show(smin.ToString());
            // MessageBox.Show(maz.ToString());
            //MessageBox.Show(BitConverter.ToString(d4));
            //  MessageBox.Show(d4.Length.ToString());
            // 输出电压 0-5v  0-1.6Mpa

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


        private void button9_Click(object sender, EventArgs e)
        {
            // 模拟红外距离变化



        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen)
            {

                MessageBox.Show("open串口");
                return;
            }

            serialPort2.Write(first, 0, first.Length);
        }

        private void showMsg()
            {
            this.label3.Text="考生："+t.Ksname.Trim();
            this.label4.Text = "身份证：" +t.KsId.Trim();
            this.label5.Text = "设备类型：" + t.Zxlx.Trim();
            this.label6.Text = "整定压力：" + t.Zxyl.Trim();

            richTextBox2.Text += "考试码：" + datahelp.QId;

            wucha1(t.Zxlx);
         
              
           this.richTextBox2.Text += "当前采集卡端口：" + datahelp.plc1 + "波特率" + datahelp.plcbt1 + "起始位，停止位，校验位" + datahelp.plcst1 + "-" + datahelp.plcsp1 + "-" + datahelp.plcjy1;

            }
        string index;
        List<Wucha> wuchas = new List<Wucha>();
        private double yali = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Thread readAI;

        private void ReadAI()
        {
            // MessageBox.Show(BitConverter.ToString(td1));
            while (true)
            {

                serialPort2.Write(td1, 0, td1.Length);
                Thread.Sleep(500);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            step = 1;
            switch(step) {
                case 0:
                    this.button3.Text = "开始";
                    break;
                case 1:
                    this.button3.Text = "校验进行中";
                   // this.plcinit();

                    if (serialPort2.IsOpen)
                    {
                        readAI = new Thread(ReadAI);
                        readAI.Start();
                        // AI0

                        this.button3.Text = "正在校验";
                        this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml("green");
                        this.timer1.Start();

                    }
                    else
                    {

                        ff.ShowErrorDialog("错误原因：1.未连接设备 2.设备异常无正确返回");
                        return;
                    }
                    //开启一个线程 摄像头
                 //   Thread t = new Thread(backCamera);
                  //  t.Start();
                    //
                    break;
            
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            liangcheng =this.comboBox2.SelectedIndex;   
        }

        private void wucha1(string type)
        {
            Wucha w = new Wucha();
            wuchas = w.GetAll(type);
            List<string> ports = new List<string>();
            foreach (var item in wuchas)
            {
                ports.Add(item.Value1.ToString().Trim());
            }
            comboBox1.DataSource = ports;
            comboBox1.SelectedIndex = 0;
            index = wuchas[comboBox1.SelectedIndex].Id;
        }
    }
}
