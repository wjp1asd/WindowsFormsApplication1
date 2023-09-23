using AutoWindowsSize;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApplication1.Models;

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
        Score sc = new Score();
        float mfzjcl = 0;
        double mfzj = 0;
        float cxfm1 = 0;
        float wxxz1 = 0;
        float jyjg1 = 0;
        float azfm1 = 0;
        datahelp datahelp = new datahelp();
        // Di 端口的一些设备 切换阀 DI0 工具检测DI1 阀帽红外 后续需要拓展
        bool youbiao = true;
        bool ljg = true;
        bool fb = true;
        bool gj = true;
        bool shy = true;
        bool fm = true;
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
        Log Log1 = new Log();
        int fangzhen1 = 0;
        int fangzhen2 = 0;
        public zaixianjiaoyan2()
        {
            InitializeComponent();
            this.richTextBox2.Show();
            //    this.uiLedLabel4.Hide();
            this.timer1.Stop();
            InitScore();
            //this.button2.Enabled = false;
            this.button1.Enabled = false;
            this.button4.Enabled = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
           
        }
        Grade g = new Grade();
        private void InitScore()
        {


            mfzjcl = sc.getScore("zx-zj");
            cxfm1 = sc.getScore("zx-cxfm");
            wxxz1 = sc.getScore("zx-wxxz");
            jyjg1 = sc.getScore("zx-jielun");
            azfm1 = sc.getScore("zx-azfm");
            this.label17.Text = "密封面直径测量得分：" + mfzjcl + "拆卸阀帽得分：" + cxfm1 + "误差选择得分：" + wxxz1 + "校验结果得分：" + jyjg1 + "安装阀帽得分：" + azfm1;
            g.updateGrade(0, "mfzjcl", datahelp.QId);
            g.updateGrade(0, "cxfm1", datahelp.QId);
            g.updateGrade(0, "wxxz1", datahelp.QId);
            g.updateGrade(0, "jyjg1", datahelp.QId);
            g.updateGrade(0, "azfm1", datahelp.QId);

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
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (!Regex.IsMatch(text, "^[0-9][.]$"))
            {
                textBox.Text = Regex.Replace(text, "[^0-9][.]", "");
            }


            if (textBox1.Text.Trim().Length > 0)
            {

                try
                {
                    mfzj = double.Parse(textBox1.Text.Trim());
                    //  double zdyl = double.Parse(t.Zxyl);
                    double zdyl = 1.0;
                    double xtyl = double.Parse(textBox2.Text.Trim());
                    datahelp c = new datahelp();
                    c.Initc();
                    double F = (zdyl - xtyl) * (double.Parse(c.mfzj) / 2) * (double.Parse(c.mfzj) / 2) * 3.2 / 10;
                    double F1 = (zdyl - xtyl) * (mfzj / 2) * (mfzj / 2) * 3.2 / 10;
                    this.textBox3.Text = F1.ToString();
                    wjltj = F;
                    double PS = F * 10 / (mfzj / 2) * (mfzj / 2) * 3.2 + xtyl;
                    this.richTextBox2.Text += "开启压力" + PS;

                    this.chart1.ChartAreas[0].AxisY.Maximum = F * 1.2;
                    // 游标卡尺和 阀瓣拿起 zxc

                    if (fb == false && youbiao == false && step == 1 && Math.Abs(mfzj - double.Parse(c.mfzj))<=0.5)
                    {
                        if (debug == 1) {
                            ff.ShowSuccessTip("得分:" + mfzjcl);
                        }
                        //  ff.ShowSuccessTip("得分:" + mfzjcl);
                        Log1.updatelog("游标卡尺、阀瓣拿起、密封直径得分"+ mfzjcl, "zx-zj",mfzjcl, datahelp.QId);
                       
                        g.updateGrade(mfzjcl, "mfzjcl", datahelp.QId);

                    }
                    else
                    {
                        if (debug == 1)
                        {
                            ff.ShowErrorTip("游标卡尺或阀瓣未拿起，此项不得分");
                        }
                        //     ff.ShowErrorTip("游标卡尺或阀瓣未拿起，此项不得分");
                        Log1.updatelog("游标卡尺、阀瓣未拿起、密封直径超差不得分" + mfzjcl, "zx-zj", 0, datahelp.QId);

                        g.updateGrade(0, "mfzjcl", datahelp.QId);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }


        }

        private void shot()
        {
            // step = 1;
            zxpic = 1;
            string loc1 = ConfigurationManager.AppSettings["loc"];
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);

            //  MessageBox.Show("拍照成功");
            string loc = System.Windows.Forms.Application.StartupPath + "\\Images\\"; ;
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);
            CvInvoke.Imwrite(loc + url + t.Qrcode + "-shot.png", mat);
            Bitmap bt = new Bitmap(loc + url + t.Qrcode + "-shot.png");
            try
            {
                bt.Save(loc1 + url + t.Qrcode + "-shot.png", System.Drawing.Imaging.ImageFormat.Bmp);
                string mm = loc1 + url + t.Qrcode + "-shot.png";
                g.updatepath(mm, "zxpic", datahelp.QId);
            }
            catch (Exception)
            {

                ff.ShowErrorNotifier("图片保存异常");
            }
           


        }
        // DI 输入的集合

        private void shot1()
        {
            // step = 1;
            string loc1 = ConfigurationManager.AppSettings["loc"];
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);


            string loc = System.Windows.Forms.Application.StartupPath + "\\Images\\"; ;
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);
            CvInvoke.Imwrite(loc + url + t.Qrcode + "-azshot.png", mat);
            Bitmap bt = new Bitmap(loc + url + t.Qrcode + "-azshot.png");
            try
            {
                bt.Save(loc1 + url + t.Qrcode + "-azshot.png", System.Drawing.Imaging.ImageFormat.Bmp);
                string mm = loc1 + url + t.Qrcode + "-azshot.png";
                // g.updatepath(mm, "lxpic", datahelp.QId);
                g.updatepath(mm, "zxpic1", datahelp.QId);
            }
            catch (Exception)
            {
                ff.ShowErrorNotifier("图片保存异常");
                throw;
                  

            }
           
            //MessageBox.Show("拍照成功");
        }
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        // 2分钟停止判断
        bool stop = false;
        Thread tj;
        int x = 0;
        int y = 1;
        // 开启压力 F 红点外加力 S密封 直径 Po系统压力
        private void zaixianjiaoyan2_Load(object sender, EventArgs e)
        {



            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;

          
            t = t.getRecord(datahelp.QId);
            showMsg();
            topheader.CopyTo(td1, 0);
            content.CopyTo(td1, topheader.Length);
            Initchart();
            byte a = CalcLRC(td1);
            td1[12] = (byte)a;
            this.richTextBox2.Hide();
            this.plcinit();
            MessageBox.Show("安装检测设备后，点击链接设备");
            this.timer1.Start();
            v = new Emgu.CV.VideoCapture(0);
            System.Windows.Forms.Application.Idle += Application_Idle;
            this.richTextBox1.Hide();
            string timestamp = currentTime.ToString("yyyyMMddHHmmss");
            url = "\\考试照片\\" + timestamp;
            string x = ConfigurationManager.AppSettings["debug"];
            if (int.Parse(x) != 1)
            {
                this.label7.Visible = true;
                debug = 1;
            }
           
        }
        int debug = 0;
        DateTime currentTime = DateTime.Now;
        Emgu.CV.VideoCapture v;
        Emgu.CV.Mat mat = new Emgu.CV.Mat();
        private void Application_Idle(object sender, EventArgs e)
        {
            if (last == false)
            {

                try
                {
                    //   mat = new Mat();
                    v.Read(mat);

                    if (!mat.IsEmpty)
                    {
                        Image<Bgr, byte> imageFrame = mat.ToImage<Bgr, byte>(); // 将帧转换为Emgu CV的图像类型
                        pictureBox1.Image = imageFrame.ToBitmap(); // 显示图像

                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (datahelp.LxTime > 0)
            {
                datahelp.LxTime--;
                if (datahelp.LxTime == 60)
                {
                    this.lbltime.ForeColor = Color.Red;
                }
                int min = datahelp.LxTime / 60;
                int sec = datahelp.LxTime % 60;
                this.lbltime.Text = string.Format("{0:00}:{1:00}", min, sec);



            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("时间到了");

            }
        }
        private void Initnum()
        {

        }

        private void Initchart()
        {
            chart1.Width = this.Width*4/5;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, 0);
            this.chart1.BackColor = Color.Azure;             //图表背景色  
           //this.chart1.Titles.Add("安全阀校验");                //图表标题

            //新建连接 
            this.chart1.ChartAreas[0].AxisX.Maximum = 400;

            //注意数据绑定后，它的series是1而不是0  本来正常应该是1   博文后注
            this.chart1.Series[0].ChartType = SeriesChartType.Spline;
            //this.chart1..ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yyyy-MM-dd-HH:mm:ss";

            this.chart1.Series[0].IsValueShownAsLabel = false;             //是否显示数据      
            this.chart1.Series[0].IsVisibleInLegend = false;              //是否显示数据说明  
                                                                          //标志大小  
            this.chart1.Series[0].Color = Color.Blue;

            this.chart1.ChartAreas[0].AxisX.LineWidth = 2;                     //X轴宽度
            this.chart1.ChartAreas[0].AxisY.LineWidth = 2;                      //Y轴宽度  
                                                                                //  this.chart1.ChartAreas[0].AxisX.Maximum = 500;
            this.chart1.Width = this.Width - 200;
            this.chart1.Height = 1 * this.Height / 2;
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;

            chart1.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = false;

        }

        public static byte CalcLRC(byte[] data)
        {
            //112
            byte lrc = 0x00; for (int i = 0; i < data.Length; i++) { lrc ^= data[i]; }
            return lrc;
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
            //   MessageBox.Show(youbiaokachi +"-"+ siheyi + "-" + famao);

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
                    button3.Text = "连接系统";//按钮显示关闭串口
                                          // comboBox1.Enabled = true;

                    serialPort2.WriteLine("02 00 00 04 06");
                    richTextBox2.Clear();
                    // SetZero();//正确的方法先注视

                }
                catch (Exception err)
                {
                    MessageBox.Show("打开失败" + err.ToString(), "提示!");//对话框显示打开失败
                   
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("打开失败" + err.ToString(), "提示!");//对话框显示打开失败
            }




        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            this.plcinit();
        }
        // 2分钟没反应，弹框 显示 500ms
        int limit = 240;
        string DIS0;
        string DIS = "01110000";

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

                //else


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
                    //取消2分钟计时
                    //if (DIS0 == a && stop == false)
                    //{

                    //    //    ff.ShowInfoTip("无操作" + limit);
                    //    limit--;
                    //    if (limit == 0)
                    //    {

                    //        MessageBox.Show("超过2分钟时间未操作，考试结束");

                    //        ////g.updateGrade(0, "mfzjcl", datahelp.QId);
                    //        ////g.updateGrade(0, "csfm1", datahelp.QId);
                    //        ////g.updateGrade(0, "wxxz1", datahelp.QId);
                    //        ////g.updateGrade(0, "jyjg1", datahelp.QId);
                    //        ////g.updateGrade(0, "azfm1", datahelp.QId);



                    //        string str = "";
                    //        if (last == false)
                    //        {
                    //            if (fm == true)
                    //            {


                    //            }
                    //            else
                    //            {
                    //                str += "阀帽未归位";
                    //                //  ff.ShowErrorTip("阀帽未归位不得分");

                    //            }
                    //            if (shy == true)
                    //            {
                    //                ////g.updateGrade(dkxyf, "dkxyf", datahelp.QId);
                    //                ////ff.ShowSuccessTip("四合一归位得分");
                    //            }
                    //            else
                    //            {
                    //                str += "四合一未归位";
                    //                // ff.ShowErrorTip("四合一未归位不得分");

                    //            }
                    //            if (gj == true)
                    //            {

                    //                //g.updateGrade(gbylbqh, "gbylbqh", datahelp.QId);
                    //                //ff.ShowSuccessTip("工具归位正确");
                    //            }
                    //            else
                    //            {
                    //                ff.ShowErrorTip("工具未归位");
                    //                //    str += "工具未归位";
                    //            }


                    //        }

                    //        last = true;

                    //        if (DIS == "01100011" || DIS == "01100000")
                    //        {

                    //            Action tongdao1 = () =>
                    //            {
                    //                Application.Restart();
                    //                Process.GetCurrentProcess()?.Kill();
                    //            };
                    //            this.Invoke(tongdao1);



                    //        }
                    //        else
                    //        {

                    //            MessageBox.Show("未复位:" + str);
                    //            Action tongdao1 = () =>
                    //            {
                    //                Application.Restart();
                    //                Process.GetCurrentProcess()?.Kill();
                    //            };
                    //            this.Invoke(tongdao1);


                    //        }
                    //    }



                    //}
                    //else {
                    //    stop = true;
                    //}
                    //}



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

        }

        private void fenxi()
        {


            if (DIS[7 - youbiaokachi] + "" == "0")
            {
                //  ff.ShowInfoTip("游标卡尺归位");
                youbiao = true;
                //MessageBox.Show("游标卡尺归位");
                //richTextBox2.Text += "游标卡尺归位";
                // richTextBox2.Text += "\r\n";
            }
            else
            {
                //   ff.ShowInfoTip("游标卡尺离开");
                youbiao = false;
                // richTextBox2.Text += "游标卡尺离开";
                //richTextBox2.Text += "\r\n";
                // MessageBox.Show("游标卡尺离开");
                //richTextBox2.Text += "切换阀关闭";
            }
            if (DIS[7 - lianjiegan] + "" == "0")
            {
                //   dishow("连接杆归位");
                ljg = true;
            }
            else
            {
                //   dishow("连接杆离开");
                ljg = false;
                //richTextBox2.Text += "切换阀关闭";
            }
            if (DIS[7 - siheyi] + "" == "0")
            {
                //  dishow("四合一归位");
                shy = true;
            }
            else
            {
                //  dishow("四合一离开");
                shy = false;
                //richTextBox2.Text += "切换阀关闭";
            }



            if (DIS[7 - faban] + "" == "0")
            {
                //  ff.ShowInfoTip("阀瓣归位");
                fb = true;

            }
            else
            {
                //  ff.ShowInfoTip("阀瓣离开");
                fb = false;
                //richTextBox2.Text += "切换阀关闭";
            }


            if (DIS[7 - famao] + "" == "0")
            {
                //richTextBox2.Text += "阀帽存在";
                //  dishow("在线阀帽存在");
                fm = true;




            }
            else
            {
                fm = false;
                //  dishow("在线阀帽拆卸");
                //richTextBox1.Text += "阀帽拆卸";
                //开始拍照
                if (zxpic != 1)
                {
                   
                      if (debug == 1)
                        {
                            ff.ShowErrorTip("在线阀帽拆卸得分"+cxfm1);
                        }
                        Log1.updatelog("在线阀帽拆卸得分" + cxfm1, "zx-cxfm", cxfm1, datahelp.QId);
                        g.updateGrade(cxfm1, "cxfm1", datahelp.QId);
                   
                    
                    Thread a = new Thread(shot);
                    a.Start();
                }
                //   chaixiefamao();
            }


            if (DIS[7 - gongju] + "" == "0")
            {
                //   dishow("在线工具归位");
                //richTextBox2.Text += "工具归位";
                gj = true;
            }
            else
            {
                //   dishow("在线工具离开");
                //richTextBox2.Text += "工具离开";
                gj = false;
            }



        }

        private void dishow(string msg)
        {
            Action tongdao = () =>
            {
                richTextBox2.Text += msg;
                richTextBox2.Text += "\r\n";
            };
            this.Invoke(tongdao);


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

        public float standardValue1 { get; private set; }

        // 基础线绘制
        bool standard = false;
        float currentF = 0;
        float lastF = 0;
        //标定k值
        float k = 1;
        float wjl = 0;
        int maxinum = 60;
        private void voldetla(string sb1, string t8)
        {
            //cz从离线压力设置-初次测试压力中取值
            cz = "1.2";
            //y为对应（500-2500）中的码值
            //  int y = (2000 * Convert.ToInt32( cz) )/Convert.ToInt32 (1.6);

            float a = Convert.ToInt32(sb1.ToString(), 16);

            float b = Convert.ToInt32(t8.ToString(), 16);

            float b1 = (a - standardValue) / 10000 / 5;
            //生成基准线

            this.chart1.ChartAreas[0].AxisY.Minimum = -5;
            float b2 = 0;
            switch (liangcheng)
            {
                case 1:
                    k = 1.007F;
                    //0.984F;
                    //0.735F;
                    //33.33F;
                    b2 = b1 * 200 * k;
                    this.chart1.ChartAreas[0].AxisX.Maximum = maxinum;
                    //推荐力Y的1.2倍                    
                    this.chart1.ChartAreas[0].AxisY.Maximum = 134.48 * 1.2;

                    //20 * 0.6;
                    break;
                case 2:
                    k = 1F;
                    //0.908F;
                    //0.678F;
                    //13.33F;
                    this.chart1.ChartAreas[0].AxisX.Maximum = maxinum;
                    // 300;
                    b2 = b1 * 500 * k;
                    this.chart1.ChartAreas[0].AxisY.Maximum = 134.48 * 1.2;
                    //50 * 0.6;
                    break;
                case 3:
                    k = 0.961F;
                    //0.720F;
                    //1.34F;
                    //3.33F;
                    b2 = b1 * 2000 * k;
                    this.chart1.ChartAreas[0].AxisX.Maximum = maxinum;
                    this.chart1.ChartAreas[0].AxisY.Maximum = 134.48 * 1.2;
                    //200 * 0.6; 
                    break;
                case 4:
                    k = 0.908F;
                    //0.678F;
                    //1.34F;
                    //1.33F;
                    b2 = b1 * 5000 * k;
                    this.chart1.ChartAreas[0].AxisX.Maximum = maxinum;
                    this.chart1.ChartAreas[0].AxisY.Maximum = 134.48 * 1.2;
                    //500 * 0.6; 
                    break;
            }

            if (show == false && b2 > 0) {
            //未点校验0
            
            }


            if (show && b2 >= 0)
            {
                //    ff.ShowInfoTip("当前电压值-初始电压值："+(a- standardValue).ToString());
                currentF = b2;
                // this.textBox5.Text = currentF.ToString();
                this.chart1.Invoke((MethodInvoker)delegate
                {
                    if (Math.Round(wjltj) < b2)
                    {
                        this.chart1.Series[0].Points.AddXY(cisu, b2);
                        //this.richTextBox1.Text += b2 + ",";
                        if ((maxinum - cisu) == 3)
                        {
                            maxinum += 50;
                            //  chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(); // 重置缩放
                            //   chart1.ChartAreas[0].AxisX.ScaleView.Zoom(cisu-10, cisu + 100);
                        }
                        cisu++;
                        //    this.chart1.Series[0].Points.AddXY(cisu, Math.Round(wjltj));
                    }
                    else
                    {

                        this.chart1.Series[0].Points.AddXY(cisu, b2);
                        // this.richTextBox1.Text += b2 + ",";

                        if ((maxinum - cisu) == 3)
                        {
                            maxinum += 50;
                            // chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(); // 重置缩放
                            //  chart1.ChartAreas[0].AxisX.ScaleView.Zoom(cisu-10, cisu + 100);
                            //    chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(); // 重置缩放
                            //   chart1.ChartAreas[0].AxisX.ScaleView.Zoom(cisu - 20, cisu + 100);
                        }
                        cisu++;
                    }
                    if (cisu == 20000)
                    {
                        //    cisu = 0;
                        MessageBox.Show("曲线停止采集");
                        serialPort2.Close();
                        // this.chart1.Series["Series1"].Points.Clear();
                        return;
                    }
                    chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(); // 重置缩放
                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(cisu - 50, cisu + 50);
                    Action x = () => {

                        
                        showpoint(); 
                    
                    
                    };
                    this.Invoke(x);
                    // showpoint();


                });




                //   MessageBox.Show("开启点" + x);



            }

            Action tongdao11 = () =>
            {

                this.label17.Text = "初始值：" + standardValue1 + "上次压力" + wjl + "当前压力：" + b2 + "推荐力" + wjltj + "量程" + liangcheng;

            };
            this.Invoke(tongdao11);

            Action tongdao = () =>
            {
                richTextBox2.Clear();
                richTextBox2.AppendText("当前循环时间：" + smin);

                richTextBox2.AppendText("当前电压差：" + (dwq - a));

                richTextBox2.AppendText("当前压力：" + b2 + "KG");
                //  this.textBox4.Text = "" + (b2);
                //  this.textBox7.Text = "" + (b2);
                //  this.textBox9.Text = "" + (b2);
                richTextBox2.AppendText("当前循环次数：" + cisu);
                richTextBox2.AppendText("上次电位器码值码值：" + dwq);

                richTextBox2.AppendText("当前通道：" + sb1.ToString());
                richTextBox2.AppendText("当前电位器码值（电压值）：" + a);



                richTextBox2.AppendText("上次电压差：" + b);
                richTextBox2.AppendText("变化速度：" + Math.Abs(a - b) / interval);

            };
            this.Invoke(tongdao);
            dwq = a;
            if (b2 >= 0)
            {
                wjl = b2;
            }

            lastF = b2;



        }
        int smin = 0;
        int point = 0;
        bool b12 = true;
        private void showpoint()
        {
            DataPointCollection dataPoints = chart1.Series[0].Points;

            System.Windows.Forms.DataVisualization.Charting.DataPoint a = dataPoints[dataPoints.Count - 1];
            if (a.YValues[0] < 134 && a.YValues[0] > 129 && b12 == true)
            //      if ((a.YValues[0] - wjltj) >= 0 && (wjl - a.YValues[0] < 0) &&(a.YValues[0] - wjltj)<=0.5 && b2 == true)
            {

                ff.sound();
                a.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                a.MarkerSize = 10;
                a.MarkerColor = System.Drawing.Color.Red;
               // a.Label = Math.Round(wjltj).ToString() + "Kg";
                a.LabelForeColor = System.Drawing.Color.Red;
                point++;
                double PS = Math.Round(a.YValues[0] * 10 / (mfzj / 2) / (mfzj / 2) / 3.2, 2, MidpointRounding.AwayFromZero);
                a.Label = Math.Round(a.YValues[0]) + "Kg";
                switch (point)
                {
                    case 1:
                        this.textBox4.Text = "" + Math.Round(a.YValues[0]);
                        this.textBox4.Enabled = false;
                        this.textBox5.Text = PS.ToString();
                        this.textBox5.ForeColor = Color.Red;
                        break;
                    case 2:
                        this.textBox7.Text = "" + Math.Round(a.YValues[0]);
                        this.textBox7.Enabled = false;
                        this.textBox6.Text = PS.ToString();
                        this.textBox6.ForeColor = Color.Red;
                        break;
                    case 3:
                        this.textBox9.Text = "" + Math.Round(a.YValues[0]);
                        this.textBox9.Enabled = false;
                        this.textBox8.Text = PS.ToString();
                        this.textBox8.ForeColor = Color.Red;
                        break;
                }
                b12 = false;

                // 7 6 9 8
                // MessageBox.Show("" + b12);
            }

            if (a.YValues[0] > 134.55 && b12 == true)
            //      if ((a.YValues[0] - wjltj) >= 0 && (wjl - a.YValues[0] < 0) &&(a.YValues[0] - wjltj)<=0.5 && b2 == true)
            {
                ff.sound();
                a.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                a.MarkerSize = 10;
                a.MarkerColor = System.Drawing.Color.Red;
              // a.Label = Math.Round(wjltj).ToString() + "Kg";
                a.LabelForeColor = System.Drawing.Color.Red;
                point++;
                double PS = Math.Round(a.YValues[0] * 10 / (mfzj / 2) / (mfzj / 2) / 3.2, 2, MidpointRounding.AwayFromZero);
                switch (point)
                {
                    case 1:
                        this.textBox4.Text = "" + 134.55;
                        a.Label = "134.55Kg";
                        this.textBox4.Enabled = false;
                        this.textBox5.Text = PS.ToString();
                        this.textBox5.ForeColor = Color.Red;
                        break;
                    case 2:
                        this.textBox7.Text = "" + 134.48;
                        a.Label = "134.48Kg";
                        this.textBox7.Enabled = false;
                        this.textBox6.Text = PS.ToString();
                        this.textBox6.ForeColor = Color.Red;
                        break;
                    case 3:
                        this.textBox9.Text = "" + 134.32;
                        a.Label = "134.32Kg";
                        this.textBox9.Enabled = false;
                        this.textBox8.Text = PS.ToString();
                        this.textBox8.ForeColor = Color.Red;
                        break;
                }

                b12 = false;

                // MessageBox.Show("" + b12);
            }
            if ((a.YValues[0]) < 10)
            {


                b12 = true;
            }
            this.chart1.Invalidate();

        }





        private void setstandard(float a)
        {
            if (standard == false)
            {
                standardValue = a;
                standardValue1 = wjl;
                //MessageBox.Show(""+a);
                StripLine s = new StripLine();
                s.BackColor = Color.Red;
                s.Interval = 0;
                s.StripWidth = 1;
                s.IntervalOffset = wjl;
                chart1.ChartAreas[0].AxisY.Crossing = wjl;
                s.Text = wjl.ToString();
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
            this.label3.Text = t.Ksname.Trim();
            this.label4.Text = t.KsId.Trim();
            this.label5.Text = t.Zxlx.Trim();
            this.label6.Text = t.Zxyl.Trim() + "Mpa";

            richTextBox2.Text += "考试码：" + datahelp.QId;

            wucha1(t.Zxlx);
            wuc = true;


            this.richTextBox2.Text += "当前采集卡端口：" + datahelp.plc1 + "波特率" + datahelp.plcbt1 + "起始位，停止位，校验位" + datahelp.plcst1 + "-" + datahelp.plcsp1 + "-" + datahelp.plcjy1;

        }
        string index;
        List<Wucha> wuchas = new List<Wucha>();
        private double yali = 0;
        bool last = false;
        Fuc ff = new Fuc();
        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();

            //   reada.Abort();


            this.timer1.Stop();
            this.timer2.Stop();
            datahelp.CurrentStep1 = 3;
            // zaixianjiaoyan o = new zaixianjiaoyan();
            // o.Show();
            //this.Close();
            string str = "";
            if (last == false)
            {
                if (fm == true)
                {

                    //点击结束开始拍照
                    //g.updateGrade(azfm1, "azfm1", datahelp.QId);
                    Thread a = new Thread(shot1);
                    a.Start();

                    if (debug == 1)
                    {
                        ff.ShowErrorTip("在线阀帽归位得分" + azfm1);
                    }
                    Log1.updatelog("在线阀帽归位得分" + azfm1, "zx-azfm", azfm1, datahelp.QId);
                 //   g.updateGrade(cxfm1, "cxfm1", datahelp.QId);
                    g.updateGrade(azfm1, "azfm1", datahelp.QId);
                    //   ff.ShowSuccessTip("阀帽归位得分");
                }
                else
                {
                    str += "阀帽未归位";
                    if (debug == 1)
                    {
                        ff.ShowErrorTip("在线阀帽未归位不得分");
                    }
                    Log1.updatelog("在线阀帽未归位不得分", "zx-azfm", 0, datahelp.QId);
                    //   g.updateGrade(cxfm1, "cxfm1", datahelp.QId);
                    g.updateGrade(0, "azfm1", datahelp.QId);

                   

                }
                if (shy == true)
                {

                    //  g.updateGrade(, "dkxyf", datahelp.QId);
                    //    ff.ShowSuccessTip("四合一归位得分");
                }
                else
                {
                    str += "四合一未归位";
                    //    ff.ShowErrorTip("四合一未归位不得分");

                }
                if (gj == true)
                {

                    //  g.updateGrade(gbylbqh, "gbylbqh", datahelp.QId);
                    //    ff.ShowSuccessTip("工具归位正确");
                }
                else
                {
                    //    ff.ShowErrorTip("工具未归位");
                    str += "工具未归位";
                }


            }
            //  g.updateGrade(0, "mfzjcl", datahelp.QId);
            //g.updateGrade(0, "csfm1", datahelp.QId);
            //  g.updateGrade(0, "wxxz1", datahelp.QId);
            // g.updateGrade(0, "jyjg1", datahelp.QId);
            // g.updateGrade(0, "azfm1", datahelp.QId);

            last = true;
            //DIS == "01110000"||
            if (DIS == "01100011" || DIS == "01100000")
            {

                // Thread x = new Thread(cxs);
                // x.Start();
                Action tongdao = () =>
                {
                    xc();
                };
                this.Invoke(tongdao);



            }
            else
            {

                MessageBox.Show("请完成复位再退出:" + str);
                Action tongdao = () =>
                {
                    xc();
                };
                this.Invoke(tongdao);
            }

        }
        Thread reada;
        private void xc()
        {
            this.Visible = false;
            zaixianjiaoyan o = new zaixianjiaoyan();
            o.Show();
        }
        private void ReadAI()
        {
            // MessageBox.Show(BitConverter.ToString(td1));
            while (true && serialPort2.IsOpen && last == false)
            {

                serialPort2.Write(td1, 0, td1.Length);
                Thread.Sleep(500);

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {

            step = 1;
            switch (step)
            {
                case 0:
                    this.button3.Text = "开始";
                    break;
                case 1:
                    this.button3.Text = "校验进行中";
                    // this.plcinit();

                    if (serialPort2.IsOpen)
                    {
                        reada = new Thread(ReadAI);
                        reada.Start();
                        // AI0

                        this.button3.Text = "正在校验";

                        this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml("green");
                        this.timer1.Start();
                        this.comboBox1.Enabled = false;
                        this.comboBox2.Enabled = false;
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
            liangcheng = this.comboBox2.SelectedIndex + 1;

            this.comboBox2.Enabled = false;
        }
        bool show = false;
        private void button1_Click(object sender, EventArgs e)
        {
            // 初始化图表
            show = true;

            this.chart1.ChartAreas[0].AxisY.Maximum = 1.2 * wjltj;
            if (dwq > 0)
            {

                setstandard(dwq);
            }
            this.textBox1.Enabled = false;
        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                System.Windows.Forms.DataVisualization.Charting.DataPoint dp = e.HitTestResult.Series.Points[i];
                e.Text = string.Format("次数{0}，值{1}", dp.XValue, dp.YValues[0]);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show = false;
            //   MessageBox.Show(""+this.chart1.Series[0].Points.Count);
            // showpoint(this.chart1.Series[0].Points.Count-2);


        }
        bool wuc = false;
        private int zxpic;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取初始值
            if (wuc == false) { return; }

            yali = double.Parse(t.Zxyl.Trim());
            string a1 = wuchas[comboBox1.SelectedIndex].Min.Trim();
            string b2 = wuchas[comboBox1.SelectedIndex].Max.Trim();

            double a = double.Parse(a1);
            double b = double.Parse(b2);
            // ff.ShowInfoTip("" + a + b + yali);
            if (step == 0) { return; }
            if (yali < a || yali > b)
            {
                // 其所选不在范围之内 不得分
                if (debug == 1) {
                    ff.ShowErrorTip("误差选择错误，不得分");
                }
                Log1.updatelog("误差选择错误，不得分", "zx-wxxz",0,datahelp.QId);
                //  ff.ShowErrorTip("误差选择错误，不得分");
                this.comboBox1.Enabled = false;

                g.updateGrade(wxxz1, "wxxz1", datahelp.QId);
            }
            else
            {
                if (debug == 1)
                {
                    ff.ShowSuccessTip("选择正确，得分" + wxxz1);
                }
                //  ff.ShowSuccessTip("选择正确，得分" + wxxz1);
                Log1.updatelog("选择正确，得分" + wxxz1, "zx-wxxz", wxxz1, datahelp.QId);

                g.updateGrade(wxxz1, "wxxz1", datahelp.QId);
                this.comboBox1.Enabled = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void JiaoYan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (v != null)
            {
                v.Stop(); // 停止视频捕获
                v.Dispose(); // 释放资源

            }
            if (serialPort2 != null && serialPort2.IsOpen)
            {
                serialPort2.Close();
                serialPort2.Dispose();
                reada.Abort();
            }

            this.timer1.Dispose();
            //  this.timer2.Dispose();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

            string loc = System.Windows.Forms.Application.StartupPath + "\\Images\\"; ;
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);
            CvInvoke.Imwrite(loc + url + t.Ksname + "-shot.png", mat);
            MessageBox.Show("本地拍照成功");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            last = true;

            datahelp.CurrentStep1 = 3;
            zaixianjiaoyan o = new zaixianjiaoyan();
            o.Show();
            this.Close();
        }

        private void cxs()
        {
            //  this.Opacity = 0;
            datahelp.CurrentStep1 = 3;
            zaixianjiaoyan o = new zaixianjiaoyan();
            o.Show();
            o.TopMost = true;
            //   this.Close();

            //if (v != null)
            //{
            //    v.Stop(); // 停止视频捕获
            //    v.Dispose(); // 释放资源

            //}
            if (serialPort2 != null && serialPort2.IsOpen)
            {
                serialPort2.Close();
                serialPort2.Dispose();
                ;
                // ReadAI.Abort();
            }

            // Process.GetCurrentProcess()?.Kill();
            this.timer1.Stop();
            // this.timer2.Dispose(); 
        }

        private void JiaoYormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
