using AutoWindowsSize;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class JiaoYan : Form
    {
        TestRecord t = new TestRecord();
        Wucha wucha = new Wucha();
        string url = Application.StartupPath + "\\Images\\考试照片\\" + DateTime.Now.ToString("yy-mm-dd-hh-ii-ss");
        private string serialPortName;
        byte[] first = new byte[] { 0x02, 0x00, 0x00, 0x04, 0x06 };
        //#02 01 00 05 01 07 数字输入DI 读取
        byte[] io = new byte[] { 0x02, 0x01, 0x00, 0x05, 0x01, 0x07 };
        //锁紧螺母 初始电位器的码值 t1,当前码值t2，弹簧 电位器的码值  t3, t4;
        string t1 = "", t2 = "",t3="",t4=" ";
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
        Score sc = new Score();
        pressure p=new pressure();
        datahelp datahelp = new datahelp();
        // Di 端口的一些设备 切换阀 DI0 工具检测DI1 阀帽红外 后续需要拓展
        int qiehuanfa1 = 0;
        int qiehuanfa2 = 0;
        int qiehuanfa3 = 0;
        int gongju = 0;
        int famao = 0;
        int xieya = 0;
        int step = -1;
        //量程选择 1.6 4 25 
        int liangcheng = 0;
        // AO  仿真压力表 舵机 后续需要拓展

        int fangzhen1 = 0;
        int fangzhen2 = 1;
        int jiaoyanfa = 7;
        public static byte CalcLRC(byte[] data)
        {
            //112
            byte lrc = 0x00; for (int i = 0; i < data.Length; i++) { lrc ^= data[i]; }
            return lrc;
        }
        int cxfm,ylxz, xygb,zdyltz,sjlmsj,azfm,dkxyf,gbylbqh,bycs= 0;
        private void InitScore()
        {
            ylxz= sc.getScore("ylxz");
            cxfm = sc.getScore("cxfm");
            zdyltz = sc.getScore("zdyltz");
            sjlmsj = sc.getScore("sjlmsj");
            azfm = sc.getScore("azfm");
            dkxyf = sc.getScore("dkxyf");
            gbylbqh = sc.getScore("gbylbqh");
            bycs = sc.getScore("bycs");
            //    jyjg1 = sc.getScore("jyjg1");zdyltz,sjlmsj,azfm,dkxyf,gbylbqh,bycs           
            //    azfm1 = sc.getScore("azfm1");
              this.label7.Text = "压力选择得分：" + ylxz + "拆卸阀帽得分：" + cxfm + "整定压力调整得分：" + zdyltz + "锁紧螺母得分：" + sjlmsj 
                
                + "安装阀帽得分：" + azfm+"打开泄压阀得分："+dkxyf+"关闭压力表切换"+gbylbqh+"保压测试得分"+bycs;
            //
        }
        private void fenxi()
        {
         
            // 第一次校验：
            //开校验阀时判断 切换阀打开、泄压阀关闭
            //                 不正确  提示请检查你的操作是否正确。
            //  一分钟之内操作正确得分
            //                 正确     量程表转（转的码值参考《计算 码值、公斤值》中的码值表）
            //关闭校验阀、打开泄压阀（无先后顺序） 
            //量程表归0

            //拆阀帽时，判断量程表是否归0 。提示 判断30秒
            //第二次校验：
            //   开校验阀时判断 切换阀打开、泄压阀关闭
            //                 不正确  提示请检查你的操作是否正确。
            //  一分钟之内操作正确得分
            //                 正确     量程表转
            //关闭校验阀、打开泄压阀（无先后顺序） 
            //量程表归0
            //             判断阀帽是否打开，打开得分
            //             判断调压螺母大小值  是否得分
            //第三次校验： 
            // 开校验阀时判断 切换阀打开、泄压阀关闭
            //                 不正确  提示请检查你的操作是否正确。
            //  一分钟之内操作正确得分
            //                 正确     量程表转
            //关闭校验阀、打开泄压阀（无先后顺序） 
            //量程表归0
            //判断锁紧螺母状态，是否得分

            //密封试验压力：
            //           密封试验压力是抽题要求整定压力的90 %
            //（码值参考《计算 码值、公斤值》中的码值表）
            //           关闭泄压阀，打开切换阀，转动校验阀 保压3分钟

            //填写报告：判断阀帽时候复原，复原得分
            //量程选择
            if (DIS[7 - qiehuanfa1] + "" == "0")
            {
                dishow("1.6Mpa量程选择");
                liangcheng =1;
            }
            else
            {
                dishow("1.6Mpa量程关闭");

                // richTextBox1.Text += "切换阀关闭";
            }


            if (DIS[7 - qiehuanfa2] + "" == "0")
            {
                dishow("4Mpa量程选择");
                liangcheng = 2;
            }
            else
            {
                dishow("4Mpa量程关闭");

                // richTextBox1.Text += "切换阀关闭";
            }


            if (DIS[7 - qiehuanfa3] + "" == "0")
            {
                dishow("25Mpa量程选择");
                liangcheng = 3;
            }
            else
            {
                dishow("25Mpa量程关闭");

                // richTextBox1.Text += "切换阀关闭";
            }


            if (DIS[7 - famao] + "" == "0")
            {
                // richTextBox1.Text += "阀帽存在";
                dishow("阀帽存在");
            }
            else
            {
                dishow("阀帽拆卸");
                //richTextBox1.Text += "阀帽拆卸";
                //开始拍照
                 chaixiefamao();
            }


            if (DIS[7 - gongju] + "" == "0")
            {
                dishow("工具归位");
                // richTextBox1.Text += "工具归位";

            }
            else
            {
                dishow("工具离开");
                // richTextBox1.Text += "工具离开";
            }


            if (DIS[7 - xieya] + "" == "0")
            {
                dishow("卸压阀打开");

                if (current<119000) {

                    byte[] d3 = new byte[] {
                0xFF,0x01,0x00,
                0x0a,0x00,0xFF,
                0x02, 0x00, 0xC4,
                0x09};

                serialPort1.Write(d3, 0, d3.Length);

                }
                //richTextBox2.Text += "卸压阀打开";

            }
            else
            {
                dishow("卸压阀关闭");
                //   richTextBox2.Text += "卸压阀关闭";
                if (liangcheng > 0)
                {
                    //  开校验阀时判断  切换阀打开、泄压阀关闭
                    guanbixieyafa();

                }
                else {
                    dishow("未选择量程，算分异常");
                }
               
            }
        }

        private void dishow(string msg)
        {
            Action tongdao = () =>
            {
                richTextBox1.Text += msg;
            };
            this.Invoke(tongdao);


        }

        private void guanbixieyafa()
        {
            // 考点
            switch (step)
            {
              
                case 1:
                    //初次压力
                   test1();
                    break;
                case 2:
                    //第二次
                    test2();
                    break;
                case 3:
                    //第三次 
                    test3();
                    break;
                case 4:
                    //保压测试
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
            if (Math.Abs(current) < 119000)
            {
                ff.ShowInfoTip("初次测试" + "校验阀打开");
                // 
               

                if (DIS[7 - xieya] + "" == "0"&& ta>0  )
                ta = 60;

            }
            else {

                ff.ShowInfoTip("初次测试" + "校验阀关闭");
            }
           // this.label1.Text = "泄压阀关闭，请打开校验阀";
        }

        private void chaixiefamao()
        {
            // 10秒后拍照
            ff.ShowInfoNotifier("量程归0判断30秒");
            if (current > 119000) {
                Thread.Sleep(10000);
                shot();
            }
          
        }

List<pressure> pp=new List<pressure>();

        public JiaoYan(string wuchaid)
        {
            InitializeComponent();
            this.change();

            datahelp.Initc();
            wucha = wucha.GetOne(wuchaid);
            this.timer1.Stop();
            //获取压力码值
            pp = p.getAll();
            //
            
            t = t.getRecord(datahelp.QId);

            foreach (var p in pp)
            {
                if (double.Parse(t.Lxyl) == p.f0){
                    //舵机码值=初次设置码值 比如整定1.0 初次1.2
                    maz = p.maz;
                    maz90 = p.maz90;
                }

            }
            MessageBox.Show("初次码值："+maz+"保压码值："+maz90);
            // 需要获取算分标准
            InitScore();
            showMsg();
            // 开启一个线程录像
           //  Task t1 = new Task(backCamera); 
           //  t1.Start();
        }
        Mat f1 = new Mat();
        private void button6_Click(object sender, EventArgs e)
        {
            VideoCapture v = new VideoCapture(0);
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

        private void shot()
        {
           // step = 1;

            CvInvoke.Imwrite(url + "shot.png", f1);
            MessageBox.Show("拍照成功");
        }
        // DI 输入的集合

        private void backCamera()
        {

            VideoCapture v = new VideoCapture(0);
            v.SetCaptureProperty(CapProp.FrameHeight, 220);
            v.SetCaptureProperty(CapProp.FrameWidth, 220);
            if (!v.IsOpened)
            {
               ff.ShowInfoTip("open video fail");
                return;
            }
            step = 0;
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
                CvInvoke.Imshow("camera", f);
                if (CvInvoke.WaitKey(30) == 27)
                {

                    break;
                }
            }
        }

        private void showMsg()
        {
            richTextBox2.Text += "考试码：" + datahelp.QId;
            this.label1.Text += "当前选择压力范围：" + wucha.Area1.ToString().Trim() + "MPa";
            this.label1.Text += "当前离线整定压力：" + t.Lxyl + "Mpa";
            this.richTextBox2.Text += "当前采集卡端口：" + datahelp.plc + "波特率" + datahelp.plcbt + "起始位，停止位，校验位" + datahelp.plcst + "-" + datahelp.plcsp + "-" + datahelp.plcjy;

        }

        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.button2, this);
            ff.fullsreen(this.button3, this);


            ff.fullsreen(this.label2, this);
        }

        private void label1_Click(object sender, EventArgs e)
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

        List<goal> goals =new List<goal>();

     
        private void JiaoYan_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;

            topheader.CopyTo(td1, 0);
            content.CopyTo(td1, topheader.Length);

            byte a = CalcLRC(td1);
            td1[12] = (byte)a;
            //获得算分标准
           goal g=new goal();
           goals = g.getall();
            // 获得标定信息
            //for (int i = 0; i < goals.Count; i++)
            //{
            //   ff.ShowInfoTip(goals[i].sub+goals[i].name+goals[i].des+ goals[i].score);
            //}


        }
        Thread readAI;

        private void ReadAI()
        {
            //ff.ShowInfoTip(BitConverter.ToString(td1));
            while (true)
            {

                serialPort2.Write(td1, 0, td1.Length);
                Thread.Sleep(500);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // DI

            if (serialPort2.IsOpen)
            {
                readDI = new Thread(ReadAI);
                readDI.Start();
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (datahelp.LxTime > 0)
            {
                datahelp.LxTime--;
                int min = datahelp.LxTime / 60;
                int sec = datahelp.LxTime % 60;
                this.lbltime.Text = string.Format("{0:00}:{1:00}", min, sec);
            }
            else
            {
                this.timer1.Stop();
               ff.ShowInfoTip("时间到了");
                //AnswerForm frm = new AnswerForm();
                //frm.MdiParent = this.MdiParent;
                //frm.Show();
                //this.Close();
            }
        }

     
        public void plcinit()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from biaoding where machine='离线'";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
            
                    string name = reader["type"].ToString().Trim();
                switch (name)
                {
                    case "泄压阀":
                        xieya = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "表1":
                        qiehuanfa1 = int.Parse(reader["pin"].ToString().Trim().Substring(2,1));
                        break;
                    case "表2":
                        qiehuanfa2 = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "表3":
                        qiehuanfa3 = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "工具":
                        gongju = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "阀帽":
                        famao = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "锁紧螺母":
                        fangzhen1 = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "调压螺母":
                        fangzhen2 = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                    case "校验阀":
                        jiaoyanfa = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
                        break;
                }

            }

           ff.ShowInfoTip(qiehuanfa1+ qiehuanfa2+qiehuanfa3+famao+fangzhen1+fangzhen2+xieya+gongju+jiaoyanfa+"");

            //采集卡初始化+舵机控制板
            try
            {
                // Di 端口的一些设备 切换阀 DI0 工具检测DI1 阀帽红外 后续需要拓展 舵机
                
                //topheader.CopyTo(td1,0);
                //content.CopyTo(td1, topheader.Length);
                //byte a = CalcLRC(td1);
                //td1[13] = a;
                //防止意外错误
                serialPort1.PortName = datahelp.servo.Trim();//获取comboBox1要打开的串口号

                serialPort1.BaudRate = 9600;//获取comboBox2选择的波特率
                serialPort1.DataBits = 8;//设置数据位
                /*设置停止位*/
                // if (datahelp.plcsp.Trim() == "1") { SER5.StopBits = StopBits.One; }
                //else if (datahelp.plcsp.Trim() == "1.5") { SER5.StopBits = StopBits.OnePointFive; }
                //else if (datahelp.plcsp.Trim() == "2") { SER5.StopBits = StopBits.Two; }
                ///*设置奇偶校验*/
                serialPort1.Parity = Parity.None;
                try
                {
                    serialPort1.Open();//打开串口
                    button3.Text = "正在连接";//按钮显示关闭串口

                    //  SER5.WriteLine("02 00 00 04 06");
                    richTextBox1.Clear();
                    SetZero1();

                }
                catch (Exception err)
                {
                   ff.ShowInfoTip("打开失败" + err.ToString());//对话框显示打开失败
                    throw;
                }

                //防止意外错误
                serialPort2.PortName = datahelp.plc.Trim();//获取comboBox1要打开的串口号

                serialPort2.BaudRate = int.Parse(datahelp.plcbt.Trim());//获取comboBox2选择的波特率
                serialPort2.DataBits = int.Parse(datahelp.plcjy.Trim());//设置数据位
                /*设置停止位*/
                if (datahelp.plcsp.Trim() == "1") { serialPort2.StopBits = StopBits.One; }
                else if (datahelp.plcsp.Trim() == "1.5") { serialPort2.StopBits = StopBits.OnePointFive; }
                else if (datahelp.plcsp.Trim() == "2") { serialPort2.StopBits = StopBits.Two; }
                /*设置奇偶校验*/
                serialPort2.Parity = Parity.None;
                try
                {
                    serialPort2.Open();//打开串口
                    button3.Text = "正在连接";//按钮显示关闭串口

                    serialPort2.WriteLine("02 00 00 04 06");
                    richTextBox1.Clear();
                    // SetZero();//正确的方法先注视

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


        private void SetZero1()
        {
            //舵机归零

            byte[] d1 = new byte[] {
                0xFF,0x01,0x00,0x0a,0x00,
                0xFF, 0x02, 0x00, 0xC4,0x09
            };

            // ff.ShowInfoTip(BitConverter.ToString(d1)) ;
            serialPort1.Write(d1, 0, d1.Length);
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
                                           //ff.ShowInfoTip(BitConverter.ToString(buff));
                                           //MessageBox.Show(len);
                                           //  ff.ShowInfoTip(name);
     if (buff.Length == 38)
            {
                Action t = () =>
                {
                    richTextBox1.Clear();

                };
                this.Invoke(t);
                // richTextBox1.Clear();
                //38位
            //    MessageBox.Show(BitConverter.ToString(buff));
                // AI解析锁紧螺母 
                byte[] ttt1 = new byte[4];
                byte[] ttt2 = new byte[4];
                byte[] ttt3 = new byte[4];
                byte[] tt1 = buff.Skip(4).Take(1).ToArray();

                string a = Convert.ToString(tt1[0], 2).Trim();
                //int f = Convert.ToInt32(a.ToString(), 16);
                //ff.ShowInfoTip(BitConverter.ToString(buff)+","+f);

                Console.WriteLine("Di:" + a);
                //ff.ShowInfoTip(a);
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

                    



                }
               // 锁紧螺母
                switch (fangzhen1)
                {
                    case 0:
                        ttt1 = buff.Skip(5).Take(4).ToArray();
                        break;

                    case 1:
                        ttt1 = buff.Skip(9).Take(4).ToArray();
                        break;
                    case 2:
                        ttt1 = buff.Skip(13).Take(4).ToArray();
                        break;
                    case 3:
                        ttt1 = buff.Skip(17).Take(4).ToArray();
                        break;
                    case 4:
                        ttt1 = buff.Skip(21).Take(4).ToArray();
                        break;
                    case 5:
                        ttt1 = buff.Skip(25).Take(4).ToArray();
                        break;
                    case 6:
                        ttt1 = buff.Skip(29).Take(4).ToArray();
                        break;
                    case 7:
                        ttt1 = buff.Skip(33).Take(4).ToArray();
                        break;



                }
                // 调压螺母
                switch (fangzhen2)
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
                // 校验阀 压力
                switch (jiaoyanfa)
                {
                    case 0:
                        ttt3 = buff.Skip(5).Take(4).ToArray();
                        break;

                    case 1:
                        ttt3 = buff.Skip(9).Take(4).ToArray();
                        break;
                    case 2:
                        ttt3 = buff.Skip(13).Take(4).ToArray();
                        break;
                    case 3:
                        ttt3 = buff.Skip(17).Take(4).ToArray();
                        break;
                    case 4:
                        ttt3 = buff.Skip(21).Take(4).ToArray();
                        break;
                    case 5:
                        ttt3 = buff.Skip(25).Take(4).ToArray();
                        break;
                    case 6:
                        ttt3 = buff.Skip(29).Take(4).ToArray();
                        break;
                    case 7:
                        ttt3 = buff.Skip(33).Take(4).ToArray();
                        break;



                }



                ////MessageBox.Show(BitConverter.ToString(ttt1));
                //MessageBox.Show(BitConverter.ToString(ttt2));



                t1 = ShowBy(ttt1,1); 
                
                t2 = ShowBy(ttt2,2);
                t3 = ShowBy(ttt3, 3); 
                // t4 =ShowBy(ttt2, 2);
                // DI解析

                if (DIS.Length == 8)
                {
                    DIS0 = a;
                    //di状态分析
                    fenxi();
                }


            }
            else
            {
                //this.label3.Text=""+buff.Length;
                // ff.ShowErrorDialog("设备无反应");


            }
        }



        private string ShowBy(byte[] buff, int num)
        {

            string sb1 = BitConverter.ToString(buff).Replace("-", "");
            // 锁紧螺母
            if (t1.Length == 0)
            {

                t1 = sb1;
            }
            // 调压螺母
            if (t2.Length == 0)
            {

                t2 = sb1;
            }
            //校验阀
            if (t3.Length == 0)
            {

                t3 = sb1;
            }


            switch (num)
            {

                case 1:
                    if (sb1.Length > 0 && t1.Length > 0)
                    {
                        voldetla1("锁紧螺母：",sb1, t1);

                    }

                    break;
                case 2:
                    if (sb1.Length > 0 && t2.Length > 0)
                    {
                        voldetla2("调压螺母：", sb1, t2);

                    }

                    break;
                 case 3:
                    if (sb1.Length > 0 && t3.Length > 0)
                    {
                        voldetla(sb1, t3);
                    }
                      break;
                   

            }

            //richTextBox2.AppendText("长度：" + buff.Length);



            return sb1;

        }
        
        private void voldetla1(string v, string sb1, string t1)
        {
            int a = Convert.ToInt32(sb1.ToString(), 16);
         
            int b = Convert.ToInt32(t1.ToString(), 16);

            Action tongdao = () =>
            {
              //  richTextBox3.Clear();
                richTextBox3.AppendText(v+ sb1.ToString());
                richTextBox3.AppendText(v + "当前电压差：" + (sjdwq - a));
                richTextBox3.AppendText(v+"当前电位器码值（电压值）：" + a);
                richTextBox3.AppendText(v + "上次电位器码值码值：" + sjdwq);

                if ((a - sjdwq) > 0)
                {
                    ff.ShowInfoTip(v + "正在锁紧");
                }
                else if((a - sjdwq) < 0) {
                    ff.ShowInfoTip(v + "正在放松");
                }
            };
            this.Invoke(tongdao);
        }
        private void voldetla2(string v, string sb1, string t1)
        {
            int a = Convert.ToInt32(sb1.ToString(), 16);
          
            int b = Convert.ToInt32(t1.ToString(), 16);

            Action tongdao = () =>
            {
                //  richTextBox3.Clear();
                richTextBox3.AppendText(v + sb1.ToString());
                richTextBox3.AppendText(v + "当前电压差：" + (tydwq - a));
                richTextBox3.AppendText(v + "当前电位器码值（电压值）：" + a);
                richTextBox3.AppendText(v + "上次电位器码值码值：" + tydwq);

                if ((a - tydwq) > 0)
                {
                    ff.ShowInfoTip(v + "正在锁紧");
                }
                else if ((a - tydwq) < 0)
                {
                    ff.ShowInfoTip(v + "正在放松");
                }
            };
            this.Invoke(tongdao);
        }
        //校验阀电压值
        private int dwq;
        private int dwqcha;
        //锁紧电压值
        private int sjdwq;
        // 调压电压值
        private int tydwq;
        string cz;
        int current = 0;
        private void voldetla(string sb1, string t8)
        {
            
            int a = Convert.ToInt32(sb1.ToString(), 16);
            current =a;
            int b = Convert.ToInt32(t8.ToString(), 16);
            dwqcha = dwq - a;
            Action tongdao = () =>
            {
                richTextBox3.Clear();
                richTextBox3.AppendText("当前通道：" + sb1.ToString());
                richTextBox3.AppendText("当前循环时间：" + smin);

                richTextBox3.AppendText("当前电压差：" + (dwq - a));


                richTextBox3.AppendText("当前舵机码值：" + maz);
                richTextBox3.AppendText("当前循环次数：" + cisu);
                richTextBox3.AppendText("上次电位器码值码值：" + dwq);

  
                richTextBox3.AppendText("当前电位器码值（电压值）：" + a);
                richTextBox3.AppendText("上次电压差：" + b);
                richTextBox3.AppendText("变化速度：" + Math.Abs(a - b) / interval);
                calyali(a);
            };
            this.Invoke(tongdao);
            
            if (Math.Abs(a) < 119000)
            {
                if (ta == 60&&step==1) {
                    // 开启一个1分值计时
                    this.timer2.Enabled = true;
                    this.timer2.Start();
                    ff.ShowInfoTip("请在一分钟内正确操作");
                }
              SendServo1(a, 0);

                //SendServo(a, 0);
                //正确的方法先注视
                //     SendServo(Math.Abs(a - b) / interval, b);

            }
            else
            {


                if (DIS[7 - xieya] + "" == "0"&&step==1) {
                    ff.ShowInfoTip("第一次测试：校验阀关闭，泄压阀打开，量程表归 0 得分");

                }
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

        

     //舵机驱动

            byte[] d3 = new byte[] {
                0xFF,0x01,0x00,
                0x0a,0x00,0xFF, 
                0x02, 0x00, 0xC4,
                0x09};
            //高八度低八度取值
            d3[3] = (byte)(maz & 0x00ff);
            d3[4] = (byte)((maz >> 8) & 0xff);
            //目标码值（离线压力设置-初次测试压力）
            d3[9] = (byte)((maz >> 8) & 0xff);
            d3[8] = (byte)(maz & 0x00ff);
           
            serialPort1.Write(d3, 0, d3.Length);
          //  MessageBox.Show(BitConverter.ToString(d3));

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
            switch (liangcheng)
            {
                case 1:
                    richTextBox3.AppendText("当前压力：" + b * 1.6 + "Mpa");
                    break;
                case 2:
                    richTextBox3.AppendText("当前压力：" + b * 4 + "Mpa");
                    break;
                case 3:
                    richTextBox3.AppendText("当前压力：" + b * 25 + "Mpa");
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

            // ff.ShowInfoTip(BitConverter.ToString(d1)) ;
            serialPort2.Write(d1, 0, d1.Length);
            Thread.Sleep(1000);
        }
        //码值初始值(范围500-2500)，时间最大值(压力变化，舵机表越走越快)
        int maz = 1111;
        int maz90 = 0;
        int smin = 1000;
        int cisu = 0;

        private void SendServo(int a, int pos)
        {


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
            MessageBox.Show(BitConverter.ToString(d4));
            serialPort1.Write(d4, 0, d4.Length);

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

               ff.ShowInfoTip("open串口");
                return;
            }

            serialPort2.Write(first, 0, first.Length);
        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uiLedLabel4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (step)
            {
                case -1:
                    this.button1.Text = "测试未开始";
                    break;
                case 0:
                    this.button1.Text = "初次测试";
                    break;
                case 1:
                    this.button1.Text = "第一次测试";
                    break;
                case 2:
                    this.button1.Text = "第二次测试";
                    break;
                case 3:
                    this.button1.Text = "第三次测试";
                    break;
                case 4:
                    this.button1.Text = "密封性能测试";
                    break;
            }

            // 开启1分钟判分倒计时  保压测试显示3分钟 实际30秒走完
            this.timer2.Start();
            ta = 60;
            step++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort2.Close();
            datahelp.CurrentStep = 3;
            this.Close();
            OFF of = new OFF(datahelp.QId);
            of.Show();

        }

        Thread readDI;
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen)
            {

               ff.ShowInfoTip("open串口");
                return;
            }


            readDI = new Thread(ReadDI);
            readDI.Start();
        }
        int interval = 500;


        byte[] dio = new byte[] { 0x02, 0x20, 0x00, 0x0C, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x2E };
        int a = 0;


        private void ReadDI()
        {
            // AI 接口
            while (true)
            {
                // serialPort2.Write(dio, 0, dio.Length);

                System.Threading.Thread.Sleep(1000);
                a++;


            }
            richTextBox2.Text = "DI读取：" + a;
        }

  

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        int ta = 60;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ta > 0) { 
                ta--;
                int min = ta / 60;
                int sec = ta% 60;
                this.label4.Text = string.Format("{0:00}:{1:00}", min, sec);
            }
            else
            {
                this.timer2.Stop();
               ff.ShowInfoTip("判分时间到了");
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort2.Write(td1, 0, td1.Length);
        }
    }
}

