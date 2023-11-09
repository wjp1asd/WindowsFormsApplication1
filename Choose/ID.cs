
using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;


namespace WindowsFormsApplication1
{


    public partial class ID : Form
    {
        Thread th;
        int nPort = 0;
        int nReaderPort = 0;
        string loc = Application.StartupPath + "\\Images\\身份证照片\\";
        string url = "ZP.bmp";
        string Id = "321084199510025535";
        public ID()
        {
            InitializeComponent();
            this.Change();
            // this.UpdataInfo(Id);
            ff.same(this);
        }

        private void Change()
        {
            ff.fullsreen(this.label2, this);
            this.pictureBox1.Top = this.Height / 2;
            this.button7.Anchor = AnchorStyles.Top;
            this.button7.Top = this.pictureBox1.Top + 300;
        }

        private void InitConfig()
        {
            datahelp a = new datahelp();
            a.Initc();
            //  nPort=int.Parse(a.print.ToString().Trim());
            nPort = 1001;
            this.groupBox1.Hide();
            if (nPort != 0)
            {

                this.label2.Text = "自动读取,请放身份证！";
                try
                {
                    nReaderPort = IDCardReader.InitComm((ReaderPortNum)nPort);
                    if (nReaderPort == 0)
                    {
                        byte[] tmp = new byte[64];
                        nReaderPort = IDCardReader.GetSAMID(ref tmp[0]);
                        if (nReaderPort != 0)
                        {
                            ff.ShowInfoTip("初始化失败,请选择设备");
                            return;
                        }

                        this.label2.ForeColor = Color.Green;
                        //开启请求
                        timer1.Start();
                        //  th = new Thread(AutoReadCard);
                        // th.Start();

                    }
                    else
                    {
                        ff.ShowInfoTip("初始化失败,请选择设备");
                    }
                }
                catch (Exception ex)
                {
                    ff.ShowInfoTip(ex.ToString());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          // url1 = "\\BNY-PC\\Images2\\身份证图片\\汪礼文_430423197805152510.bmp";
         //  UpdataInfo("430423197805152510");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //  awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            // this.SizeChanged += groupBox1_Resize;
            InitConfig();
            // this.groupBox1.s
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        string url1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int rest = 10;
        int authenticate = -1;
        int readContent = -1;
        private void AutoReadCard()
        {
           // ff.ShowInfoTip("q"+123);
            if(this.groupBox1.Visible==false)
            {
               // rest--;
              //  Thread.Sleep(1000);
               
                if (nReaderPort == 0)
                {
                    if (authenticate == -1)
                    {

                        authenticate = IDCardReader.Authenticate();
                    }

                    if (authenticate == 0)
                    {
                        if (readContent == -1)
                        {

                            readContent = IDCardReader.Read_Content(1);
                        }

                        
                        Action tongdao = () =>
                        {
                            this.groupBox1.Show();
                        };
                        this.Invoke(tongdao);



                        if (IDCardReader.IsFPRIDCard() == 1)
                        {

                            //外国人
                            lblAddress.Visible = false;
                            lblDept.Visible = false;//机关代码
                            label6.Visible = false;
                            label5.Text = "证件号：";
                            label7.Visible = false;
                            label2.Text = "国籍：";
                            label4.Text = "出生日期：";


                            if (readContent == 0)
                            {
                                byte[] arrTmp = new byte[100];
                                int nLen = 100;


                                //姓名
                                IDCardReader.GetFPR_ENName2(ref arrTmp[0], ref nLen);
                                string str = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                lblName.Text = str.Replace(" ", "");

                                //证件号码
                                IDCardReader.GetFPR_IDNo2(ref arrTmp[0], ref nLen);
                                lblIdCard.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //性别
                                IDCardReader.GetFPR_SEX2(ref arrTmp[0], ref nLen);
                                lblSex.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //国籍
                                IDCardReader.GetFPR_Nation2(ref arrTmp[0], ref nLen);
                                lblNation.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                IDCardReader.GetFPR_NationCode2(ref arrTmp[0], ref nLen);
                                lblNation.Text += "/" + System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //出生日期
                                IDCardReader.GetFPR_Birthday2(ref arrTmp[0], ref nLen);
                                lblBirthday.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //签发时间
                                IDCardReader.GetFPR_ValidStartDate2(ref arrTmp[0], ref nLen);
                                lblValidDate.Text = "";
                                lblValidDate.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                lblValidDate2.Text = "至  ";
                                //终止时间
                                IDCardReader.GetFPR_ValidEndDate2(ref arrTmp[0], ref nLen);
                                lblValidDate2.Text += System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //照片
                                if (System.IO.File.Exists("ZP.bmp"))
                                {

                                    try
                                    {
                                        url = loc + lblName.Text + "_" + lblIdCard.Text + ".bmp";
                                        string loc1 = ConfigurationManager.AppSettings["loc"];
                                        url1 = loc1 + "身份证照片/" + lblName.Text.Trim() + "_" + lblIdCard.Text.Trim() + new DateTime() + ".bmp";
                                        if (!File.Exists(url))
                                        {
                                            File.Copy("ZP.bmp", url);


                                        }
                                        this.pictureBox2.ImageLocation = url;

                                    }
                                    catch (Exception e)
                                    {
                                        ff.ShowInfoTip("保存图片异常" + e.ToString());
                                        throw;
                                    }



                                }
                            }
                        }
                        else if (IDCardReader.IsGATIDCard() == 1)
                        {


                            // 签证

                            label6.Visible = true;
                            label7.Visible = true;
                            label5.Text = "身份证号：";
                            label4.Text = "通行证号：";
                            label2.Text = "签次：";
                            if (readContent == 0)
                            {


                                byte[] arrTmp = new byte[100];
                                int nLen = 100;
                                //详细地址
                                IDCardReader.GetGAT_Address2(ref arrTmp[0], ref nLen);
                                lblAddress.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //性别
                                IDCardReader.GetGAT_SEX2(ref arrTmp[0], ref nLen);
                                lblSex.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //通行证号码
                                IDCardReader.GetGAT_PassportNo2(ref arrTmp[0], ref nLen);
                                lblBirthday.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //签发机关
                                IDCardReader.GetGAT_IssuingAuthority2(ref arrTmp[0], ref nLen);
                                lblDept.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //公民身份证号码
                                IDCardReader.GetGAT_IDNo2(ref arrTmp[0], ref nLen);
                                lblIdCard.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //姓名
                                IDCardReader.GetGAT_Name2(ref arrTmp[0], ref nLen);
                                lblName.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //签发次数
                                IDCardReader.GetGAT_IssuanceCount2(ref arrTmp[0], ref nLen);
                                lblNation.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                IDCardReader.GetGAT_ValidStartDate2(ref arrTmp[0], ref nLen);
                                lblValidDate.Text = "";
                                lblValidDate.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                lblValidDate2.Text = "至  ";
                                IDCardReader.GetGAT_ValidEndDate2(ref arrTmp[0], ref nLen);
                                lblValidDate2.Text += System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                //照片
                                if (System.IO.File.Exists("ZP.bmp"))
                                {
                                    try
                                    {
                                        url = loc + lblName.Text + "_" + lblIdCard.Text + ".bmp";
                                        string loc1 = ConfigurationManager.AppSettings["loc"];
                                        url1 = loc1 + "身份证照片/" + lblName.Text + "_" + lblIdCard.Text + new DateTime() + ".bmp";
                                        if (!File.Exists(url))
                                        {
                                            File.Copy("ZP.bmp", url);


                                        }
                                        this.pictureBox2.ImageLocation = url;
                                    }
                                    catch (Exception e)
                                    {
                                        ff.ShowInfoTip("保存图片异常" + e.ToString());
                                        throw;
                                    }
                                }
                            }
                        }
                        else
                        {



                            lblAddress.Visible = true;
                            lblDept.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            label5.Text = "身份证号：";

                            label4.Text = "出生日期：";

                            if (readContent == 0)
                            {

                                byte[] arrTmp = new byte[100];
                                int nLen = 100;

                                IDCardReader.GetAddress2(ref arrTmp[0], ref nLen);
                                lblAddress.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                IDCardReader.GetSex2(ref arrTmp[0], ref nLen);
                                lblSex.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                IDCardReader.GetBornDate2(ref arrTmp[0], ref nLen);
                                lblBirthday.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                IDCardReader.GetSignGov2(ref arrTmp[0], ref nLen);
                                lblDept.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                IDCardReader.GetIDNo2(ref arrTmp[0], ref nLen);
                                lblIdCard.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                IDCardReader.GetName2(ref arrTmp[0], ref nLen);
                                lblName.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                IDCardReader.GetNation2(ref arrTmp[0], ref nLen);
                                //   lblNation.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

                                IDCardReader.GetStartDate2(ref arrTmp[0], ref nLen);
                                lblValidDate.Text = "";
                                lblValidDate.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                lblValidDate2.Text = "至  ";
                                IDCardReader.GetEndDate2(ref arrTmp[0], ref nLen);
                                lblValidDate2.Text += System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);
                                //指纹信息

                                //照片
                                if (System.IO.File.Exists("ZP.bmp"))

                                {
                                    try
                                    {
                                        url = loc + lblName.Text.Trim() + "_" + lblIdCard.Text.Trim() + ".bmp";
                                        string loc1 = ConfigurationManager.AppSettings["loc"];
                                        url1 = loc1 + "身份证照片/" + lblName.Text.Trim() + "_" + lblIdCard.Text.Trim() + ".bmp";
                                        if (!File.Exists(url))
                                        {
                                            File.Copy("ZP.bmp", url);


                                        }

                                        this.pictureBox2.ImageLocation = url;
                                    }
                                    catch (Exception e)
                                    {
                                        ff.ShowInfoTip("保存图片异常" + e.ToString());
                                        throw;
                                    }
                                }
                            }
                            else
                            {
                                ff.ShowErrorTip("读卡操作失败！");
                                MessageBox.Show("警告：请联系管理员重启设备再进行抽题");
                              
                                // InitConfig();
                                // this.label2.ForeColor = Color.Red;
                                //   authenticate = IDCardReader.Authenticate();
                            }
                        }
                        //上传信息
                      
                        if (lblIdCard.Text.ToString().Length > 0)
                        {
                            this.groupBox1.Visible=true;

                            Id = lblIdCard.Text.ToString().Trim();
                            UpdataInfo(Id);
                            timer1.Stop();
                        }
                        //timer1.Stop();
                    }
                    else
                    {
                       // ff.ShowInfoTip(readContent +"请放身份证!" +authenticate);
                        

                            authenticate = IDCardReader.Authenticate();

                      //  if (readContent == -1)
                      //  {

                      //      readContent = IDCardReader.Read_Content(1);
                       // }
                        //  authenticate = IDCardReader.Authenticate();
                        //  this.label2.Text = "请放身份证!";
                        // this.label2.ForeColor = Color.Red;

                    }
                }
                else
                {
                    ff.ShowErrorTip("初始化失败!重启程序");
                    Application.Restart();
                    Process.GetCurrentProcess()?.Kill();
                }


            }




        }
        public string a, b, c, d, f;
        public Fuc ff = new Fuc();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Choose a = new Choose(Id.ToString().Trim());
            a.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timer1.Enabled) {

                this.AutoReadCard();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.timer1.Enabled)
            {

                this.timer1.Enabled = false;
            }

            this.Close();
            ff.backlogin();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ID_Shown(object sender, EventArgs e)
        {

        }

        private void ID_MouseMove(object sender, MouseEventArgs e)
        {
            //if (rest == 0)
            //{
            //    InitConfig();
            //    ff.ShowInfoTip("10s,保活");
            //    rest = 10;
            //}

        }

        private void UpdataInfo(string Id)
        {

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select id from student where idcard='" + 
                Id.ToString().Trim() + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            string path = url1;
           // MessageBox.Show(url1);

            string id = "";
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                id = reader["id"].ToString();

            }
            con.Close();
          


            if (id.Length > 0)
            {
                datahelp.StudentId = Id.ToString();
                string connectionString1 = ConfigurationManager.AppSettings["sqlc"];
                SqlConnection con1 = new SqlConnection(connectionString);
                string strcomm = "update student  set avatar = '" + path + "' where id = " + id;
              //  MessageBox.Show(url1 + "zxx" + id);
             //  MessageBox.Show(strcomm);
                SqlCommand com1 = new SqlCommand(strcomm, con1);
                con1.Open();
                int i = 0;
                SqlDataReader reader1 = com1.ExecuteReader();
                while (reader1.Read())
                {
                    i = 1;
                }
                //MessageBox.Show(""+i);


                    ff.ShowSuccessTip("更新信息成功！");


                con1.Close();
            }
            else
            {
                ff.ShowErrorDialog("系统无相关信息");
            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AutoReadCard();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible=false;
            timer1.Stop();
            ff.backlogin();
        //    Thread.Sleep(5000);
       //     timer1.Start();
        }
    }
}
