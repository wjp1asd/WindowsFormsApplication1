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
        // 算分模块 密封面直径测量得分 拆卸阀帽得分 误差选择得分 校验结果得分
        Score sc=new Score();
        float mfzjcl = 0;
        float cxfm1  = 0;
        float wxxz1 = 0;
        float jyjg1 = 0;
        float azfm1 = 0;
        datahelp datahelp = new datahelp();
        // Di 端口的一些设备 切换阀 DI0 工具检测DI1 阀帽红外 后续需要拓展
        int youbiaokachi = 2;
        int lianjiegan = 0;
        int faban = 0;
        int gongju = 0;
        int famao = 0;
        int siheyi = 0;
        int step = -1;
        //量程选择 1.6 4 25 
        int liangcheng = 0;
        // AO  仿真压力表 舵机 后续需要拓展

        int fangzhen1 = 0;
        int fangzhen2 = 0;
        public zaixianjiaoyan2()
        {
            InitializeComponent();
            this.richTextBox2.Hide();
            this.uiLedLabel4.Hide();
            this.timer1.Stop();
            InitScore();
            //this.button2.Enabled = false;
            this.button1.Enabled = false;
            this.button4.Enabled = false;
        }

        private void InitScore()
        {
             mfzjcl =sc.getScore("mfzjcl");
             cxfm1 = sc.getScore("cxfm1");
             wxxz1 = sc.getScore("wxxz1");
             jyjg1 = sc.getScore("jyjg1") ;
             azfm1 = sc.getScore("azfm1");
            this.label17.Text = "密封面直径测量得分：" + mfzjcl + "拆卸阀帽得分：" + cxfm1 + "误差选择得分：" + wxxz1 + "校验结果得分：" + jyjg1 + "安装阀帽得分：" + azfm1;
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
        //外加力值推荐值
        double wjltj = 0;
        private void CALCf(object sender, EventArgs e)
        {
            try
            {
                double mfzj = double.Parse(textBox1.Text.Trim());
                //  double zdyl = double.Parse(t.Zxyl);
                double zdyl = 1.0;
                double xtyl = double.Parse(textBox2.Text.Trim());

                double F = (zdyl - xtyl) * (mfzj / 2) * (mfzj / 2) * 3.2/10;
               
                this.textBox3.Text = F.ToString();
                wjltj = F;
                double PS = F * 10 / (mfzj / 2) * (mfzj / 2) * 3.2 + xtyl;
                this.richTextBox2.Text += "开启压力"+PS;

                this.chart1.ChartAreas[0].AxisY.Maximum = F * 1.2;
                // 游标卡尺和 阀瓣拿起 

                if (DIS[7 - faban] + "" == "0" && DIS[7 - youbiaokachi] + "" == "0") {

                    ff.ShowSuccessTip("得分:"+mfzjcl);

                } else {

                    ff.ShowErrorTip("游标卡尺或阀瓣未拿起，此项不得分");
                
                }
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
            this.richTextBox2.Hide();
            this.plcinit();
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
            chart1.Series[0].Points.AddXY(0, 0);    
            this.chart1.BackColor = Color.Azure;             //图表背景色  
            this.chart1.Titles.Add("安全阀校验");                //图表标题
            //新建连接 
          
            //注意数据绑定后，它的series是1而不是0  本来正常应该是1   博文后注
            this.chart1.Series[0].ChartType = SeriesChartType.Spline;
            //this.chart1..ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yyyy-MM-dd-HH:mm:ss";
        
            this.chart1.Series[0].IsValueShownAsLabel = false;             //是否显示数据      
            this.chart1.Series[0].IsVisibleInLegend = false;              //是否显示数据说明  
            this.chart1.Series[0].MarkerStyle = MarkerStyle.Circle;        //线条上的数据点标志类型  
            this.chart1.Series[0].MarkerSize = 8;                          //标志大小  
            this.chart1.Series[0].Color = Color.Blue;
          
            this.chart1.ChartAreas[0].AxisX.LineWidth = 2;                     //X轴宽度
            this.chart1.ChartAreas[0].AxisY.LineWidth = 2;                      //Y轴宽度  
            this.chart1.ChartAreas[0].AxisX.Maximum = 500;
            this.chart1.Width = this.Width;
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
                  
                }

            }
            // 130012
           MessageBox.Show(youbiaokachi +"-"+ siheyi + "-" + famao);

            //采集卡初始化+舵机控制板
            try
            {
          

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
        string DIS="11111111";

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
                    fenxi();
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


            if (DIS[7 - youbiaokachi] + "" == "0")
            {
               //ff.ShowInfoTip("游标卡尺归位");
                //MessageBox.Show("游标卡尺归位");
            }
            else
            {
              //  ff.ShowInfoTip("游标卡尺离开");
               // MessageBox.Show("游标卡尺离开");
                //richTextBox2.Text += "切换阀关闭";
            }
            if (DIS[7 - lianjiegan] + "" == "0")
            {
                ff.ShowInfoTip("连接杆归位");
               
            }
            else
            {
                ff.ShowInfoTip("连接杆离开");

                //richTextBox2.Text += "切换阀关闭";
            }
            if (DIS[7 - siheyi] + "" == "0")
            {
                ff.ShowInfoTip("四合一归位");
              
            }
            else
            {
                ff.ShowInfoTip("四合一离开");

                //richTextBox2.Text += "切换阀关闭";
            }



            if (DIS[7 - faban] + "" == "0")
            {
                ff.ShowInfoTip("阀瓣归位");
              
            }
            else
            {
                ff.ShowInfoTip("阀瓣离开");

                //richTextBox2.Text += "切换阀关闭";
            }


            if (DIS[7 - famao] + "" == "0")
            {
                //richTextBox2.Text += "阀帽存在";
                ff.ShowInfoTip("在线阀帽存在");
            }
            else
            {
                ff.ShowInfoTip("在线阀帽拆卸");
                //richTextBox1.Text += "阀帽拆卸";
                //开始拍照
             //   chaixiefamao();
            }


            if (DIS[7 - gongju] + "" == "0")
            {
                ff.ShowInfoTip("在线工具归位");
                //richTextBox2.Text += "工具归位";

            }
            else
            {
                ff.ShowInfoTip("在线工具离开");
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
  
        //上次电压值
        float dwq;
        string cz;
        int interval = 200;
         float standardValue = 0;
        // 基础线绘制
        bool standard = false;
        float currentF = 0;
        float lastF = 0;
        //标定k值
        float k = 1;
        float wjl= 0;
        private void voldetla(string sb1, string t8)
        {
            //cz从离线压力设置-初次测试压力中取值
            cz = "1.2";
            //y为对应（500-2500）中的码值
            //  int y = (2000 * Convert.ToInt32( cz) )/Convert.ToInt32 (1.6);

            float a = Convert.ToInt32(sb1.ToString(), 16);
           
            float b = Convert.ToInt32(t8.ToString(), 16);

            float b1 = (a-standardValue) / 10000 / 5;
            //生成基准线
           
            
            float b2 = 0;
            switch (liangcheng)
            {
                case 1:
                   k = 1.39F;
                    //33.33F;
                    b2 = b1 * 200 * k;
                    this.chart1.ChartAreas[0].AxisX.Maximum = 500;
                    //推荐力Y的1.2倍
                    this.chart1.ChartAreas[0].AxisY.Maximum = 134.48 * 1.2;
                        //20 * 0.6;
                    break;
                case 2:
                   k = 1.34F;
                    //13.33F;
                    this.chart1.ChartAreas[0].AxisX.Maximum = 500;
                    b2 = b1 * 500 * k;
                    this.chart1.ChartAreas[0].AxisY.Maximum = 134.48 * 1.2;
                    //50 * 0.6;
                    break;
                case 3:
                    k = 1.34F;
                        //3.33F;
                    b2 = b1 * 2000 * k;
                    this.chart1.ChartAreas[0].AxisX.Maximum = 500;
                    this.chart1.ChartAreas[0].AxisY.Maximum = 134.48 * 1.2;
                    //200 * 0.6; 
                    break;
                case 4:
                   k = 1.34F;
                    //1.33F;
                    b2 = b1 * 5000*k;
                    this.chart1.ChartAreas[0].AxisX.Maximum = 500;
                    this.chart1.ChartAreas[0].AxisY.Maximum = 134.48 * 1.2; 
                    //500 * 0.6; 
                    break;
            }
            if (b2 - wjl < 0 && Math.Abs(wjl - wjltj) <= 1) {
                // 开启压力值
                Action tongdao1 = () =>
                {

                    this.textBox5.Text = b2.ToString();
                };
                this.Invoke(tongdao1);

                }
           
               
           
            if (show&&(a - standardValue)>=0) {
                //    ff.ShowInfoTip("当前电压值-初始电压值："+(a- standardValue).ToString());
                currentF = b2 - standardValue;
                this.textBox5.Text = currentF.ToString();
                this.chart1.Series[0].Points.AddXY(cisu, b2);
                showpoint(cisu);
                lastF = b2 - standardValue;
            }
         
            Action tongdao = () =>
            {
                richTextBox2.Clear();
               richTextBox2.AppendText("当前循环时间：" + smin);

                richTextBox2.AppendText("当前电压差：" + (dwq-a));

                richTextBox2.AppendText("当前压力：" +b2 + "KG");
                this.textBox4.Text =""+ (b2);
                richTextBox2.AppendText("当前循环次数：" + cisu);
                richTextBox2.AppendText("上次电位器码值码值：" + dwq);

                richTextBox2.AppendText("当前通道：" + sb1.ToString());
                richTextBox2.AppendText("当前电位器码值（电压值）：" + a);
                
        
            
                richTextBox2.AppendText("上次电压差：" + b);
                richTextBox2.AppendText("变化速度：" + Math.Abs(a - b) / interval);
             
            };
            this.Invoke(tongdao);
            dwq = a;
            wjl = b2;

        }
        int smin = 0;
        private void showpoint(int x)
        {
            this.chart1.Series[0].Points[x].MarkerColor=Color.Red;
            this.chart1.Series[0].Points[x].MarkerSize = 10;
            this.chart1.Series[0].Points[x].MarkerStyle = MarkerStyle.Star6;

        }

        private void setstandard(float a)
        {
            if (standard==false) {
                standardValue = a;
                //MessageBox.Show(""+a);
                StripLine s = new StripLine();
                s.BackColor = Color.Red;
                s.Interval = 0;
                s.StripWidth = 1;
                s.IntervalOffset = currentF;
                this.chart1.ChartAreas[0].AxisY.StripLines.Add(s);
                standard = true;
            }
        }

  
        int cisu = 0;


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
            t.Zxyl = "1.0";
            this.label3.Text="考生："+t.Ksname.Trim();
            this.label4.Text = "身份证：" +t.KsId.Trim();
            this.label5.Text = "设备类型：" + t.Zxlx.Trim();
            this.label6.Text = "整定压力：" + t.Zxyl.Trim()+"Mpa";

            richTextBox2.Text += "考试码：" + datahelp.QId;

            wucha1(t.Zxlx);
            wuc = true;


           this.richTextBox2.Text += "当前采集卡端口：" + datahelp.plc1 + "波特率" + datahelp.plcbt1 + "起始位，停止位，校验位" + datahelp.plcst1 + "-" + datahelp.plcsp1 + "-" + datahelp.plcjy1;

            }
        string index;
        List<Wucha> wuchas = new List<Wucha>();
        private double yali = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            datahelp.CurrentStep1 = 3;
            if (DIS == "11111111")
            {
                zaixianjiaoyan o = new zaixianjiaoyan();
                o.Show();
                this.Close();
                serialPort2.Close();
             
            }
            else
            {

                MessageBox.Show("请完成复位再退出");

            }
          
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
                        this.comboBox1.Enabled =false; this.comboBox2.Enabled =false;
                        this.button1.Enabled = true;
                        this.button2.Enabled = true;
                        this.button4.Enabled = true;
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
            liangcheng =this.comboBox2.SelectedIndex+1;

            this.comboBox2.Enabled = false;
        }
        bool show = false;
        private void button1_Click(object sender, EventArgs e)
        {
            // 初始化图表
            show = true;

            this.chart1.ChartAreas[0].AxisY.Maximum = 1.2 * wjltj;
            if (dwq>0) {

                setstandard(dwq);
            }
          
        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint) {
                int i = e.HitTestResult.PointIndex;
                System.Windows.Forms.DataVisualization.Charting.DataPoint dp = e.HitTestResult.Series.Points[i];
                e.Text = string.Format("次数{0}，值{1}", dp.XValue, dp.YValues[0]);
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show = false;
        }
        bool wuc = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取初始值
            if (wuc == false) { return; }

            yali = double.Parse(t.Zxyl.Trim());
            string a1 = wuchas[comboBox1.SelectedIndex].Min.Trim();
            string b2 = wuchas[comboBox1.SelectedIndex].Max.Trim();

            double a = double.Parse(a1);
            double b = double.Parse(b2);
            ff.ShowInfoTip("" + a + b + yali);
            if (step == 0) { return; }
            if (yali < a || yali > b)
            {
                // 其所选不在范围之内 不得分
                ff.ShowErrorTip("误差选择错误，不得分");
                this.comboBox1.Enabled = false;
            }
            else
            {
                ff.ShowSuccessTip("选择正确，得分" + wxxz1);
                this.comboBox1.Enabled = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
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
          
            index = wuchas[comboBox1.SelectedIndex].Id;
        }
    }
}
