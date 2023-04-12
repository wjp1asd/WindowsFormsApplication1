
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;


namespace WindowsFormsApplication1
{


    public partial class ID : Form
    {
        int nPort = 0;
        int nReaderPort = 0;
        string loc = Application.StartupPath + "\\Images\\身份证照片\\";
        string url = "ZP.bmp";
        string Id = "321084199510025535";
        public ID()
        {
            InitializeComponent();
            InitConfig();
           // this.UpdataInfo(Id);
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
                            MessageBox.Show("初始化失败,请选择设备");
                            return;
                        }
                       
                        this.label2.ForeColor = Color.Green;
                        //开启请求
                        this.AutoReadCard();

                    }
                    else
                    {
                        MessageBox.Show("初始化失败,请选择设备");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            ff.backlogin();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void AutoReadCard()
        {

         
            button2.Text = "开始读卡";
            if (nReaderPort == 0)
            {
                int authenticate = IDCardReader.Authenticate();
                if (authenticate == 0)
                {
                    int readContent = IDCardReader.Read_Content(1);
                    this.groupBox1.Show();

                    if (IDCardReader.IsFPRIDCard() == 1)
                    {


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
                                    if (!File.Exists(url)) {
                                        File.Copy("ZP.bmp", url);

                                        pictureBox1.ImageLocation = url;
                                    }
                                    
                                   
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show("保存图片异常"+e.ToString());
                                    throw;
                                }

                              

                            }
                        }
                    }
                    else if (IDCardReader.IsGATIDCard() == 1)
                    {




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
                                    if (!File.Exists(url))
                                    {
                                        File.Copy("ZP.bmp", url);

                                        pictureBox1.ImageLocation = url;
                                    }
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show("保存图片异常" + e.ToString());
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
                            lblNation.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(arrTmp, 0, nLen);

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
                                    url = loc + lblName.Text + "_" + lblIdCard.Text + ".bmp";
                                    if (!File.Exists(url))
                                    {
                                        File.Copy("ZP.bmp", url);

                                        pictureBox1.ImageLocation = url;
                                    }
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show("保存图片异常" + e.ToString());
                                    throw;
                                }
                            }
                        }
                        else
                        {
                            this.label2.Text = "读卡操作失败！";
                            this.label2.ForeColor = Color.Red;
                            this.button2.Text = "重新读取";
                        }
                    }
                    //上传信息
                    if (lblIdCard.Text.ToString().Length > 0) {

                        Id = lblIdCard.Text.ToString().Trim();
                        UpdataInfo(Id);
                    }
                    
                }
                else
                {
                    this.label2.Text = "请放身份证!";
                    this.label2.ForeColor = Color.Red;
                    this.button2.Text = "重新读取";
                }
            }
            else
            {
                MessageBox.Show("初始化失败！");
            }

          
        }
        public string a, b, c, d, f;
        public Fuc ff = new Fuc();
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void UpdataInfo(string Id)
        {

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select id from student where idcard='" + Id.ToString() + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            string path =url;
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
               
                string strcomm = "update student  set avatar='" + path + "' where id = " + id;
                
                con.Open();
                com = new SqlCommand(strcomm, con);
                 
              
                
                    ff.ShowSuccessTip("更新信息成功！");
                this.Close();
                Choose a = new Choose(Id.ToString().Trim());
                    a.Show();
                
                con.Close();
            }
            else
            {
                ff.ShowErrorDialog("系统无相关信息");
            }

            con.Close();

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
            this.groupBox1.Hide();
        }
    }
}
