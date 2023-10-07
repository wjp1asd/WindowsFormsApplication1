using AutoWindowsSize;
using Emgu.CV;
using Emgu.CV.Structure;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class JiaoYan : Form
    {
        TestRecord t = new TestRecord();
        Wucha wucha = new Wucha();
        DateTime currentTime = DateTime.Now;

        string url;
        private string serialPortName;
        byte[] first = new byte[] { 0x02, 0x00, 0x00, 0x04, 0x06 };
        //#02 01 00 05 01 07 数字输入DI 读取
        byte[] io = new byte[] { 0x02, 0x01, 0x00, 0x05, 0x01, 0x07 };
        //锁紧螺母 初始电位器的码值 t1,当前码值t2，弹簧 电位器的码值  t3, t4;
        string t1 = "", t2 = "", t3 = "", t4 = " ";
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
        bool correct4 = false;
        Score sc = new Score();
        pressure p = new pressure();
        datahelp datahelp = new datahelp();
        // Di 端口的一些设备 切换阀 DI0 工具检测DI1 阀帽红外 后续需要拓展

        bool qiehuastate = false;
        bool gongjustate = true;
        bool famaostate = true;
        bool xieyastate = true;

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
        float cxfm, ylxz, xyfkq, xygb, zdyltz, sjlmsj, azfm, dkxyf4, gbxyf4, dkxyf1, gbxyf1, dkxyf2, gbxyf2, dkxyf3, gbxyf3, bycs = 0;
        private void InitScore()
        {
            //初次前,泄压阀关闭，压力表选择
            xygb = sc.getScore("lx-xyfgb");
            log1.updatelog("离线=校验前，泄压阀开启不得分", "lx-xyfgb", 0, datahelp.QId);
            ylxz = sc.getScore("lx-ylbxz");

            //初次 拆卸阀帽，整定压力调整，泄压阀开启
            cxfm = sc.getScore("lx-cxfm");
            zdyltz = sc.getScore("lx-zdyltz");
            xyfkq = sc.getScore("lx-xyfkq");
            //第一次 锁紧螺母 打开泄压阀，关闭泄压阀
            sjlmsj = sc.getScore("lx-sjlm-1");
            log1.updatelog("离线=锁紧螺母不得分", "lx-sjlm-1", 0, datahelp.QId);
            dkxyf1 = sc.getScore("lx-xyfkq-1");
            gbxyf1 = sc.getScore("lx-xyfgb-1");

            //第二次 安装阀帽 打开泄压阀，关闭泄压阀
            azfm = sc.getScore("lx-azfm-2");
            log1.updatelog("离线=第二次，未安装阀帽不得分", "lx-azfm-2", 0, datahelp.QId);
            dkxyf2 = sc.getScore("lx-xyfkq-2");
            gbxyf2 = sc.getScore("lx-xyfgb-2");
            //第三次 打开泄压阀，关闭泄压阀 
            dkxyf3 = sc.getScore("lx-xyfkq-3");
            gbxyf3 = sc.getScore("lx-xyfgb-3");
            //打开泄压阀 关闭泄压阀 保压测试
            dkxyf4 = sc.getScore("lx-xyfkq-4");
            gbxyf4 = sc.getScore("lx-xyfgb-4");
            bycs = sc.getScore("lx-ylbqhf");
            log1.updatelog("离线实操结束未复位不得分", "lx-ylbqhf", 0, datahelp.QId);
            this.label7.Text = "校验前压力选择得分：" + ylxz + "校验前泄压阀关闭得分：" + xygb
                + "初次拆卸阀帽得分：" + cxfm + "初次整定压力调整得分：" + zdyltz + "初次泄压阀开启得分：" + xyfkq

                + "第一次锁紧螺母得分：" + sjlmsj + "第一次打开泄压阀得分：" + dkxyf1 + "第一次关闭泄压阀" + gbxyf1 +
              "第二次安装阀帽得分：" + azfm +
                "2次打开泄压阀得分：" + dkxyf2 + "2关闭泄压阀" + gbxyf2
               + "3次打开泄压阀得分：" + dkxyf3 + "3关闭泄压阀" + gbxyf3
                 + "4次打开泄压阀得分：" + dkxyf4 + "4关关闭泄压阀" + gbxyf4
              + "复位得分" + bycs;
            // MessageBox.Show(this.label7.Text);
            //初次之前
            g.updateGrade(0, "gbxyf", datahelp.QId);
            g.updateGrade(0, "ylxz", datahelp.QId);
            //初次

            g.updateGrade(0, "csfm", datahelp.QId);
            g.updateGrade(0, "dkxyf", datahelp.QId);
            g.updateGrade(0, "zdyltz", datahelp.QId);

            //1次
            g.updateGrade(0, "sjlmsj", datahelp.QId);
            g.updateGrade(0, "azfm", datahelp.QId);

            g.updateGrade(0, "dkxyf1", datahelp.QId);
            g.updateGrade(0, "gbxyf1", datahelp.QId);
            //2次
            g.updateGrade(0, "dkxyf2", datahelp.QId);
            g.updateGrade(0, "gbxyf2", datahelp.QId);
            //3次
            g.updateGrade(0, "dkxyf3", datahelp.QId);
            g.updateGrade(0, "gbxyf3", datahelp.QId);
            //4次
            g.updateGrade(0, "dkxyf4", datahelp.QId);
            g.updateGrade(0, "gbxyf4", datahelp.QId);
            //复位
            g.updateGrade(0, "bycs", datahelp.QId);

        }
        private void showlight()
        {
            if (famaostate == true) { uiLight1.OnColor = Color.Green; } else { uiLight1.OnColor = Color.Red; }
            if (gongjustate == true) { uiLight2.OnColor = Color.Green; } else { uiLight2.OnColor = Color.Red; }
            if (xieyastate == true) { uiLight3.OnColor = Color.Green; } else { uiLight3.OnColor = Color.Red; }

            switch (liangcheng)
            {
                case 0:
                    uiLight4.OnColor = Color.Red;
                    uiLight5.OnColor = Color.Red;
                    uiLight6.OnColor = Color.Red;
                    break;
                case 1:
                    uiLight4.OnColor = Color.Green;
                    uiLight5.OnColor = Color.Red;
                    uiLight6.OnColor = Color.Red;
                    break;
                case 2:
                    uiLight4.OnColor = Color.Red;
                    uiLight5.OnColor = Color.Green;
                    uiLight6.OnColor = Color.Red;
                    break;
                case 3:
                    uiLight4.OnColor = Color.Red;
                    uiLight5.OnColor = Color.Red;
                    uiLight6.OnColor = Color.Green;
                    break;
            }
        }

        Grade g = new Grade();
        Log log1 = new Log();
        private void fenxi()
        {

            if (DIS[7 - qiehuanfa1] + "" == "0")
            {
                // 
                if (debug == 1)
                {
                    dishow("1.6Mpa量程选择");
                }
                liangcheng = 1;
                qiehuastate = true;
                // 压力表选择得分
                if (step == -1||step==0)
                {
                    //初次校验，选择压力表 得分
                    log1.updatelog("离线=校验前，选择压力表得分", "lx-ylbxz", ylxz, datahelp.QId);
                    g.updateGrade(ylxz, "ylxz", datahelp.QId);
                }
                else
                {
                    log1.updatelog("离线=非校验前，选择压力表不得分", "lx-ylbxz", 0, datahelp.QId);

                }

            }
            else
            {
                if (debug == 1)
                {
                    dishow("1.6Mpa量程关闭");
                }
                // 
                qiehuastate = false;
                // richTextBox1.Text += "切换阀关闭";
            }


            if (DIS[7 - qiehuanfa2] + "" == "0")
            {

                if (debug == 1)
                {
                    dishow("4Mpa量程选择");

                }//   
                log1.updatelog("离线=非校验前，选择压力表错误不得分", "lx-ylbxz", 0, datahelp.QId);
                liangcheng = 2;
                qiehuastate = true;
            }
            else
            {
                //  dishow("4Mpa量程关闭");
                qiehuastate = false;
                // richTextBox1.Text += "切换阀关闭";
            }


            if (DIS[7 - qiehuanfa3] + "" == "0")
            {
                //  dishow("25Mpa量程选择");
                if (debug == 1)
                {
                    dishow("25Mpa量程选择");

                }//
                log1.updatelog("离线=非校验前，选择压力表错误不得分", "lx-ylbxz", 0, datahelp.QId);
                liangcheng = 3;
                qiehuastate = true;
            }
            else
            {
                //  dishow("25Mpa量程关闭");
                qiehuastate = false;
                // richTextBox1.Text += "切换阀关闭";
            }


            if (DIS[7 - famao] + "" == "0")
            {
                famaostate = true;

                //  dishow("阀帽存在");


                if (chuchi == 1 )
                {
                    if (debug == 1)
                    {
                        ff.ShowInfoTip("第二次校验，安装阀帽得分");
                    }
                    //   
                    //chaixiefamao();
                    log1.updatelog("离线=第二次，安装阀帽得分" + azfm, "lx-azfm-2", azfm, datahelp.QId);
                    g.updateGrade(azfm, "azfm", datahelp.QId);
                }
            }
            else
            {
                //   dishow("阀帽拆卸");
                famaostate = false;
                chuchi = 1;
                //richTextBox1.Text += "阀帽拆卸";
                //开始拍照
                if (step == 0)
                {
                    if (debug == 1)
                    {
                        ff.ShowInfoTip("离线=初次拆阀帽得分");
                    }
                    //     
                    chaixiefamao();
                    log1.updatelog("离线=初次拆阀帽得分" + cxfm, "lx-cxfm", cxfm, datahelp.QId);
                    g.updateGrade(cxfm, "csfm", datahelp.QId);
                }

            }


            if (DIS[7 - gongju] + "" == "0")
            {
                //   dishow("工具归位");
                gongjustate = true;

                // richTextBox1.Text += "工具归位";

            }
            else
            {
                gongjustate = false;
                //   dishow("工具离开");
                // richTextBox1.Text += "工具离开";
            }


            if (DIS[7 - xieya] + "" == "0")
            {
                // 
                xieyastate = true;
                if (step == 0)
                {
                    if (debug == 1)
                    {
                        dishow("卸压阀打开");

                    }
                    log1.updatelog("离线=初次卸压阀打开得分" + xyfkq, "lx-xyfkq", xyfkq, datahelp.QId);
                    g.updateGrade(xyfkq, "dkxyf", datahelp.QId);
                }

                if (step == 1)
                {
                    if (debug == 1)
                    {
                        dishow("离线=第一次卸压阀打开得分" + dkxyf1);

                    }
                    log1.updatelog("离线=第一次卸压阀打开得分" + dkxyf1, "lx-xyfkq-1", dkxyf1, datahelp.QId);
                    g.updateGrade(dkxyf1, "dkxyf1", datahelp.QId);
                }
                if (step == 2)
                {
                    if (debug == 1)
                    {
                        dishow("离线=第二次卸压阀打开得分" + dkxyf2);

                    }
                    log1.updatelog("离线=第二次卸压阀打开得分" + dkxyf2, "lx-xyfkq-2", dkxyf2, datahelp.QId);
                    g.updateGrade(dkxyf2, "dkxyf2", datahelp.QId);
                }

                if (step == 3)
                {
                    if (debug == 1)
                    {
                        dishow("离线=第三次卸压阀打开得分" + dkxyf3);

                    }
                    log1.updatelog("离线=第三次卸压阀打开得分" + dkxyf3, "lx-xyfkq-3", dkxyf3, datahelp.QId);
                    g.updateGrade(dkxyf3, "dkxyf3", datahelp.QId);
                }
                if (step == 4)
                {
                    if (debug == 1)
                    {
                        dishow("离线=保压测试卸压阀打开得分" + dkxyf4);

                    }
                    log1.updatelog("离线=保压测试卸压阀打开得分" + dkxyf4, "lx-xyfkq-4", dkxyf4, datahelp.QId);
                    g.updateGrade(dkxyf4, "dkxyf4", datahelp.QId);
                }
                // MessageBox.Show(a.ToString());
                if (a < 117500)
                {

                    byte[] d3 = new byte[] {
                0xFF,0x01,0x00,
                0x0A,0x00,0xFF,
                0x02, 0x00, 0xC4,
                0x09};
                    try
                    {
                        serialPort1.Write(d3, 0, d3.Length);

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                //richTextBox2.Text += "卸压阀打开";

            }
            else
            {
                xieyastate = false;
                if (step == -1)
                {

                    if (debug == 1)
                    {

                        dishow("离线=校验前，卸压阀关闭");
                        MessageBox.Show("离线=校验前，卸压阀关闭");
                    }
                    log1.updatelog("离线=校验前，卸压阀关闭得分" + xygb, "lx-xyfgb", xygb, datahelp.QId);
                    g.updateGrade(xygb, "gbxyf", datahelp.QId);
                }
                // 第一次
                if (step == 1)
                {

                    if (debug == 1)
                    {

                        dishow("离线=第一次，卸压阀关闭");
                        MessageBox.Show("离线=第一次，卸压阀关闭");

                    }
                    log1.updatelog("离线=第一次，卸压阀关闭得分" + gbxyf1, "lx-xyfgb-1", gbxyf1, datahelp.QId);
                    g.updateGrade(gbxyf1, "gbxyf1", datahelp.QId);
                }

                if (step == 2)
                {

                    if (debug == 1)
                    {

                        dishow("离线=第二次，卸压阀关闭");
                        MessageBox.Show("离线=第二次，卸压阀关闭");
                    }
                    log1.updatelog("离线=第二次，卸压阀关闭得分" + gbxyf2, "lx-xyfgb-2", gbxyf2, datahelp.QId);
                    g.updateGrade(gbxyf2, "gbxyf2", datahelp.QId);
                }

                if (step == 3)
                {

                    if (debug == 1)
                    {

                        dishow("离线=第三次，卸压阀关闭");

                    }
                    log1.updatelog("离线=第三次，卸压阀关闭得分" + gbxyf3, "lx-xyfgb-3", gbxyf3, datahelp.QId);
                    g.updateGrade(xygb, "gbxyf3", datahelp.QId);
                }

                if (step == 4)
                {

                    if (debug == 1)
                    {

                        dishow("离线=密封性能测试，卸压阀关闭");

                    }
                    log1.updatelog("离线=密封性能测试，卸压阀关闭得分" + gbxyf4, "lx-xyfgb-4", gbxyf4, datahelp.QId);
                    g.updateGrade(gbxyf4, "gbxyf4", datahelp.QId);
                }
                //  
                //   richTextBox2.Text += "卸压阀关闭";
                if (liangcheng > 0)
                {
                    guanbixieyafa();


                }
                else
                {
                    //    dishow("未选择量程，算分异常");
                }

            }
            showlight();
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
            if (Math.Abs(current) < 117500)
            {
                //  ff.ShowInfoTip("初次测试" + "校验阀打开");
                // 


                if (DIS[7 - xieya] + "" == "0" && ta > 0)
                    ta = 60;

            }
            else
            {

                //  ff.ShowInfoTip("初次测试" + "校验阀关闭");
            }
            // this.label1.Text = "泄压阀关闭，请打开校验阀";
        }

        private void chaixiefamao()
        {
            // 10秒后拍照
            //ff.ShowInfoTip("量程归0判断30秒");
            if (current > 117500 && lxpic != 1)
            {

                shot();

            }

        }
        pressure ap = new pressure();
        List<pressure> pp = new List<pressure>();

        public JiaoYan(string wuchaid)
        {
            InitializeComponent();
            //this.change();

            datahelp.Initc();
            wucha = wucha.GetOne(wuchaid);
            this.timer1.Stop();
            //获取压力码值
            pp = p.getAll();
            //

            t = t.getRecord(datahelp.QId);

            foreach (var p in pp)
            {
                if (double.Parse(t.Lxyl) == p.f0)
                {
                    double x = p.f1;

                    ap = p;
                    //舵机码值=初次设置码值 比如整定1.0 初次1.2

                    foreach (var p1 in pp)
                    {
                        if (p.f1 == p1.f0)
                        {
                            // 初次
                            maz = p1.maz;
                            maz90 = p1.maz90;



                        }


                    }



                }

            }
            // MessageBox.Show("初次码值："+maz+"保压码值："+maz90);
            // 需要获取算分标准
            InitScore();
            showMsg();
            // 开启一个线程录像
            //  Task t1 = new Task(backCamera); 
            //t1.Start();
        }

        private void shot()
        {
            // step = 1;
            string loc1 = ConfigurationManager.AppSettings["loc"];
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);


            string loc = System.Windows.Forms.Application.StartupPath + "\\Images\\"; ;
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);
            CvInvoke.Imwrite(loc + url +  t.Ksname.Trim()  + "-shot.png", mat);
            Bitmap bt = new Bitmap(loc + url + t.Ksname.Trim()  + "-shot.png");

            bt.Save(loc1 + url + t.Ksname.Trim()  + "-shot.png", System.Drawing.Imaging.ImageFormat.Bmp);
            string mm = loc1 + url + t.Ksname.Trim() + "-shot.png";
            g.updatepath(mm, "lxpic", datahelp.QId);
            lxpic = 1;
            //    MessageBox.Show("拍照成功");
        }
        // DI 输入的集合

        private void shot1()
        {
            // step = 1;
            string loc1 = ConfigurationManager.AppSettings["loc"];
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);


            string loc = System.Windows.Forms.Application.StartupPath + "\\Images\\"; ;
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);
            CvInvoke.Imwrite(loc + url + t.Ksname.Trim() + "离线-azshot.png", mat);
            Bitmap bt = new Bitmap(loc + url + t.Ksname.Trim() + "离线-azshot.png");

            bt.Save(loc1 + url + t.Ksname.Trim() + "离线-azshot.png", System.Drawing.Imaging.ImageFormat.Bmp);
            string mm = loc1 + url + t.Ksname.Trim() + "离线-azshot.png";
            // g.updatepath(mm, "lxpic", datahelp.QId);
            g.updatepath(mm, "lxpic1", datahelp.QId);
            //MessageBox.Show("拍照成功");
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
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        List<goal> goals = new List<goal>();


        private void JiaoYan_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;

            topheader.CopyTo(td1, 0);
            content.CopyTo(td1, topheader.Length);
            // this.ControlBox=false;
            byte a = CalcLRC(td1);
            td1[12] = (byte)a;
            //获得算分标准
            goal g = new goal();
            goals = g.getall();

            System.Windows.Forms.Application.Idle += Application_Idle;

            string timestamp = currentTime.ToString("yyyyMMddHHmmss");
            url = "\\考试照片\\" + timestamp;
            this.button2.Enabled = false;
            this.button1.Enabled = false;
            // this.button2.BackColor=System.Drawing.ColorTranslator.FromHtml("grey");
            this.timer3.Stop();
            this.timer2.Stop();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;

            string x = ConfigurationManager.AppSettings["debug"];
            if (int.Parse(x) == 1)
            {
                debug = 1;
                label1.Visible = true;
                label3.Visible = true;
                label7.Visible = true;
                richTextBox1.Visible = true;
                richTextBox2.Visible = true;
                richTextBox3.Visible = true;
                uiLedLabel4.Visible = true;
            }

        }
        int debug = 1;
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


                }

            }




        }
        Thread readAI;

        private void ReadAI()
        {
            //ff.ShowInfoTip(BitConverter.ToString(td1));

            while (true && serialPort2.IsOpen && last == false)
            {
                try
                {
                    serialPort2.Write(td1, 0, td1.Length);
                    Thread.Sleep(500);
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // DI
            this.plcinit();
            v = new Emgu.CV.VideoCapture(0);
            if (serialPort2.IsOpen)
            {
                readDI = new Thread(ReadAI);
                readDI.Start();
                // AI0
                this.button3.Enabled = false;
                this.button3.Text = "正在校验";
                this.button1.Enabled = true;
                this.button1.Text = "未开始";
                this.step = -1;
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
            //   Process.GetCurrentProcess()?.Kill();
            last = true;
            if (v != null)
            {
                v.Stop(); // 停止视频捕获
                v.Dispose(); // 释放资源

            }
            if (serialPort2 != null && serialPort2.IsOpen)
            {
                serialPort2.Close();
                serialPort2.Dispose();
                serialPort1.Close();
                serialPort1.Dispose();
                readDI.Abort();
            }

            // Process.GetCurrentProcess()?.Kill();
            this.timer1.Dispose();
            this.timer2.Dispose();
            datahelp.CurrentStep1 = 3;
            OFF of = new OFF(datahelp.QId);
            of.Show();
            this.Close();

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
                        qiehuanfa1 = int.Parse(reader["pin"].ToString().Trim().Substring(2, 1));
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

            //  ff.ShowInfoTip(qiehuanfa1+ qiehuanfa2+qiehuanfa3+famao+fangzhen1+fangzhen2+xieya+gongju+jiaoyanfa+"");

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

            //ff.ShowInfoTip(BitConverter.ToString(d1));
            try
            {
                serialPort1.Write(d1, 0, d1.Length);
            }
            catch (Exception)
            {

                throw;
            }

            // Thread.Sleep(1000);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        int limit = 240;
        string DIS0;
        string DIS = "1111001";

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



                t1 = ShowBy(ttt1, 1);

                t2 = ShowBy(ttt2, 2);
                t3 = ShowBy(ttt3, 3);
                // t4 =ShowBy(ttt2, 2);
                // DI解析

                if (DIS.Length == 8)
                {
                    DIS0 = a;
                    //di状态分析
                    fenxi();


                    //if (DIS0 == a)
                    //{

                    //    //    ff.ShowInfoTip("无操作" + limit);
                    //    limit--;
                    //    if (limit == 0)
                    //    {

                    //        MessageBox.Show("超过2分钟时间未操作，考试结束，请点击右下角退出");

                    //        ////g.updateGrade(0, "mfzjcl", datahelp.QId);
                    //        ////g.updateGrade(0, "csfm1", datahelp.QId);
                    //        ////g.updateGrade(0, "wxxz1", datahelp.QId);
                    //        ////g.updateGrade(0, "jyjg1", datahelp.QId);
                    //        ////g.updateGrade(0, "azfm1", datahelp.QId);



                    //        string str = "";
                    //        if (last == false)
                    //        {


                    //            if (qiehuastate == true)
                    //            {
                    //                str += "压力表没有归位，";
                    //            }
                    //            if (gongjustate == false)
                    //            {
                    //                str += "扳手没有归位，";
                    //            }
                    //            if (famaostate == false)
                    //            {
                    //                str += "阀帽没有归位，";
                    //            }

                    //            if (xieyastate == false)
                    //            {
                    //                str += "泄压阀关闭，";
                    //            }


                    //        }
                    //        last = true;
                    //        // MessageBox.Show(DIS);
                    //        if (DIS == "11111001" || DIS == "01111001" || DIS == "11111000" || DIS == "01111000")
                    //        {





                    //        }
                    //        else { MessageBox.Show("请完成复位再退出:" + str); }

                    //    }



                    //}



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
                        voldetla1("锁紧螺母：", sb1, t1);

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
            int a1 = Convert.ToInt32(sb1.ToString(), 16);

            int b = Convert.ToInt32(t1.ToString(), 16);

            Action tongdao = () =>
            {
                //  richTextBox3.Clear();
                richTextBox3.AppendText(v + sb1.ToString());
                richTextBox3.AppendText(v + "当前电压差：" + (sjdwq - a1));
                richTextBox3.AppendText(v + "当前电位器码值（电压值）：" + a1);
                richTextBox3.AppendText(v + "上次电位器码值码值：" + sjdwq);
                if (step==0||step==1) {
                    ff.ShowInfoTip("-"+a1+"-"+sjdwq+"-"+ap.f0+"-"+ap.f1);
                    if ((a1 - sjdwq) > 0)
                    {
                       // 当前 电压 -上次电压 1.1MPa 1.3Mpa 23730 0 1.1 1.3

                        richTextBox2.AppendText(v + "正在锁紧");
                        if (famaostate==false && ap.f0 < ap.f1)
                        {
                            if (xieyastate == false)
                            {
                                MessageBox.Show("严重错误：未泄压，当前考试不得分");
                                this.InitScore();
                            }

                            // 整定压力 大于 初次压力
                            if (debug == 1)
                            {

                                MessageBox.Show("第一次测试：校验阀关闭，泄压阀打开，量程表归 0 阀帽打开，整定压力 小于 初次压力 当前应该放松 得分");

                            }
                            g.updateGrade(sjlmsj, "sjlmsj", datahelp.QId);
                            log1.updatelog("离线=第一次测试：整定小于初次，锁紧螺母锁紧不得分" , "lx-sjlm-1", 0, datahelp.QId);
                        }
                        else {
                            g.updateGrade(0, "sjlmsj", datahelp.QId);
                            log1.updatelog("离线=第一次测试：整定大于初次，锁紧螺母锁紧得分"+sjlmsj, "lx-sjlm-1", sjlmsj, datahelp.QId);
                        }
                    }
                    else 
                    {

                        richTextBox2.AppendText(v + "正在放松");
                        if (famaostate==false && ap.f0 > ap.f1)
                        {

                            if (xieyastate == false)
                            {
                                MessageBox.Show("严重错误：未泄压，当前考试不得分");
                                this.InitScore();
                            }
                            // 整定压力 小于于 初次压力
                            g.updateGrade(sjlmsj, "sjlmsj", datahelp.QId);

                            if (debug == 1)
                            {

                                MessageBox.Show("初次测试：校验阀关闭，泄压阀打开，量程表归 0 阀帽打开，整定压力 大于 初次压力 当前应该锁紧 得分");
                            }
                                                     g.updateGrade(sjlmsj, "sjlmsj", datahelp.QId);
                            log1.updatelog("离线=第一次测试：整定大于初次，锁紧螺母放松不得分", "lx-sjlm-1", 0, datahelp.QId);
                        }
                        else
                        {
                            g.updateGrade(0, "sjlmsj", datahelp.QId);
                            log1.updatelog("离线=第一次测试：整定小于初次，锁紧螺母放松得分"+ sjlmsj, "lx-sjlm-1",sjlmsj, datahelp.QId);
                        }
                    }
                }
              
            };
            this.Invoke(tongdao);
        }
        private void voldetla2(string v, string sb1, string t1)
        {
            int a2 = Convert.ToInt32(sb1.ToString(), 16);

            int b = Convert.ToInt32(t1.ToString(), 16);

            Action tongdao = () =>
            {
                //  richTextBox3.Clear();
                richTextBox3.AppendText(v + sb1.ToString());
                richTextBox3.AppendText(v + "当前电压差：" + (tydwq - a2));
                richTextBox3.AppendText(v + "当前电位器码值（电压值）：" + a2);
                richTextBox3.AppendText(v + "上次电位器码值码值：" + tydwq);

                if ((a2 - tydwq) > 0)
                {
                    richTextBox2.AppendText(v + "正在锁紧");
                }
                else if ((a2 - tydwq) < 0)
                {
                    richTextBox2.AppendText(v + "正在放松");
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
            current = a;
            int b = Convert.ToInt32(t8.ToString(), 16);
            dwqcha = dwq - a;
            Action tongdao = () =>
            {
                // richTextBox3.Clear();
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

            if (Math.Abs(a) < 117500 && last == false && step >= 0)
            {


                // 开启一个1分值计时
                //    MessageBox.Show(a+""+xieyastate+liangcheng);
                if (xieyastate == false && liangcheng > 0)
                {

                    int k = Math.Abs(a - b) / interval;
                    //   MessageBox.Show("变化速度：" + );
                    SendServo1(a, 0, k);



                    if (step == 0)
                    {
              
                        if (ta > 0)
                        {
                            // 方向判分
                            if (famaostate == false)
                            {
                                correct2 = true;

                               // MessageBox.Show("666");
                            }

                        }
                        if (ta > 0 && step == 0)
                        {
                            correct3 = true;


                            if (debug == 1)
                            {
                                ff.ShowSuccessTip("离线=初次：整定调整 得分" + zdyltz);

                            }
                            g.updateGrade(zdyltz, "zdyltz", datahelp.QId);
                            log1.updatelog("离线=初次：整定调整得分" + zdyltz, "lx-zdyltz", zdyltz, datahelp.QId);
                        }

                    }

                    if (step == 4 && ta2 > 0)
                    {

                        correct4 = true;

                        if (debug == 1)
                        {
                            ff.ShowSuccessTip("密封测试：保压 得分");
                        }


                        g.updateGrade(bycs, "bycs", datahelp.QId);



                    }
                }
                // 初次算分





            }
            else
            {







            }
        }
        int czmaz;


        private void SendServo1(int a, int pos, int speed)
        {
            byte nn = 0x05;
            // ff.ShowInfoTip("舵机"+maz);
            if (speed <= 2 && speed > 0)
            {

                nn = 0x01;
            }
            if (speed <= 5 && speed > 2)
            {
                nn = 0x03;
            }
            if (speed <= 8 && speed > 5)
            {
                nn = 0x05;
            }
            if (speed <= 10 && speed > 8)
            {
                nn = 0x08;

            }
            if (speed >= 10)
            {
                nn = 0x0A;

            }
            //舵机驱动

            byte[] d3 = new byte[] {
                0xFF,0x01,0x00,
                nn,0x00,0xFF,
                0x02, 0x00, 0xC4,
                0x09};

            //高八度低八度取值
            //d3[3] = (byte)(maz & 0x00ff);
            //d3[4] = (byte)((maz >> 8) & 0xff);
            //目标码值（离线压力设置-初次测试压力）
            d3[9] = (byte)((maz >> 8) & 0xff);
            d3[8] = (byte)(maz & 0x00ff);
            try
            {
                serialPort1.Write(d3, 0, d3.Length);
            }
            catch (Exception)
            {

                throw;
            }
            // MessageBox.Show(BitConverter.ToString(d3));


            if (dwq - a > 100)
            {

                maz += 1;

            }
            Thread.Sleep(1000);
            if (a < 117500)
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

        //码值初始值(范围500-2500)，时间最大值(压力变化，舵机表越走越快)
        int maz = 1111;
        int maz90 = 0;
        int smin = 1000;
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

            step++;
            switch (step)
            {
                case -1:
                    this.button1.Text = "测试未开始";
                    //   ff.ShowInfoTip("请完成复位再退出" + str);
                    ff.ShowInfoTip("测试未开始");
                    break;

                case 0:
                    this.button1.Text = "初次测试";
                    ff.ShowInfoTip("初次测试");
                    break;

                case 1:
                    this.button1.Text = "第一次测试";

                    maz = ap.maz;
                    maz90 = ap.maz90;
                    ta = 60;
                    this.timer2.ReStart();
                    ff.ShowInfoTip("第一次测试" + "请在一分钟内正确操作");
                    break;
                case 2:
                    this.button1.Text = "第二次测试";

                    ta = 60;
                    this.timer2.ReStart();
                    ff.ShowInfoTip("第二次测试" + "请在一分钟内正确操作");
                    break;
                case 3:
                    this.button1.Text = "第三次测试";

                    ta = 60;
                    this.timer2.ReStart();
                    ff.ShowInfoTip("第三次测试" + "请在一分钟内正确操作");

                    break;
                case 4:
                    this.button1.Text = "密封性能测试";


                    ff.ShowInfoTip("密封性能测试" + "保压测试开始，倒计时3分钟");
                    this.timer2.Stop();
                    maz = maz90;
                    this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml("gray");
                    this.button1.Enabled = false;
                    ta2 = 180;
                    this.button2.Enabled = true;
                    this.timer3.ReStart();
                    break;
            }
            //MessageBox.Show(this.button1.Text.ToString());
            // 开启1分钟判分倒计时  保压测试显示3分钟 实际30秒走完

            ta = 60;



        }
        // 最后判分 点击结束校验
        bool last = false;
        private void button2_Click(object sender, EventArgs e)

        {
            string str = "";

            datahelp.CurrentStep1 = 3;
            if (last == false)
            {
                if (famaostate == true)
                {

                    Thread a = new Thread(shot1);
                    a.Start();

                }
                else
                {
                    ff.ShowErrorTip("阀帽未归位不得分");

                }



            }
            last = true;

            if (DIS == "11111001" || DIS == "01111001" || DIS == "11111000" || DIS == "01111000")
            {
                log1.updatelog("复位得分" + bycs, "lx-ylbqhf", bycs, datahelp.QId);
                Action x = () =>
                {
                    this.Close();
                    OFF of = new OFF(datahelp.QId);
                    of.Show();
                };
                this.Invoke(x);



            }
            else
            {
                log1.updatelog("未复位不得分" , "lx-ylbqhf", 0, datahelp.QId);
                if (qiehuastate == true)
                {
                    str += "压力表没有归位，";
                }
                if (gongjustate == false)
                {
                    str += "扳手没有归位，";
                }
                if (famaostate == false)
                {
                    str += "阀帽没有归位，";
                }

                if (xieyastate == false)
                {
                    str += "泄压阀关闭，";
                }

                ff.ShowInfoDialog("请完成复位再退出" + str);
                //  MessageBox.Show("请完成复位再退出"+str);

                Action x = () =>
                {
                    this.Close();
                    OFF of = new OFF(datahelp.QId);
                    of.Show();
                };
                this.Invoke(x);
            }


        }
        Thread c;
        private void csd()
        {
            if (v != null)
            {
                v.Stop(); // 停止视频捕获
                v.Dispose(); // 释放资源

            }
            if (serialPort2 != null && serialPort2.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort2.Close();
                }
                finally
                {

                    serialPort2.Dispose();
                    serialPort1.Dispose();
                    readDI.Abort();
                }

            }
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
                serialPort1.Close();
                serialPort1.Dispose();
                readDI.Abort();
            }

            // Process.GetCurrentProcess()?.Kill();
            this.timer1.Dispose();
            this.timer2.Dispose();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

            string loc = System.Windows.Forms.Application.StartupPath + "\\Images\\"; ;
            //   CvInvoke.Imwrite(loc + url + "shot.png", mat);
            CvInvoke.Imwrite(loc + url + t.Qrcode + "-shot.png", mat);
            // MessageBox.Show("本地拍照成功");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (ta2 > 0)
            {
                ta2--;
                int min = ta2 / 60;
                int sec = ta2 % 60;
                this.label10.Text = string.Format("{0:00}:{1:00}", min, sec);
            }
            else
            {
                this.timer3.Stop();
                ff.ShowInfoTip("判分时间到了");

            }
        }

        Thread readDI;

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        byte[] dio = new byte[] { 0x02, 0x20, 0x00, 0x0C, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x2E };
        int a = 0;


        private void ReadDI()
        {
            // AI 接口
            while (true && last == false)
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
        int ta2 = 180;
        private int chuchi;
        private int lxpic;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ta > 0)
            {
                ta--;
                int min = ta / 60;
                int sec = ta % 60;
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

