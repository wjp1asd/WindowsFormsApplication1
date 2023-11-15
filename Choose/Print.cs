using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{




    public partial class Print : Form
    {
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultLCID")]
        public static extern int GetSystemDefaultLCID();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetInit", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetInit();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetUsbportauto", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetUsbportauto();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetClean", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetClean();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetClose", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetClose();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetAlignment", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetAlignment(int iAlignment);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetAlignmentLeftRight", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetAlignmentLeftRight(int iAlignment);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetBold", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetBold(int iBold);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetCommandmode", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetCommandmode(int iMode);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetLinespace", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetLinespace(int iLinespace);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetPrintport", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetPrintport(StringBuilder strPort, int iBaudrate);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintString", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintString(StringBuilder strData, int iImme);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintFeedline", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintFeedline(int iLine);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintSelfcheck", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintSelfcheck();

        [DllImport("Msprintsdk.dll", EntryPoint = "GetStatus", CharSet = CharSet.Ansi)]
        public static extern unsafe int GetStatus();

        [DllImport("Msprintsdk.dll", EntryPoint = "GetStatusspecial", CharSet = CharSet.Ansi)]
        public static extern unsafe int GetStatusspecial();

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintCutpaper", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintCutpaper(int iMode);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetSizetext", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetSizetext(int iHeight, int iWidth);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetSizechinese", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetSizechinese(int iHeight, int iWidth, int iUnderline, int iChinesetype);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetItalic", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetItalic(int iItalic);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintDiskbmpfile", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintDiskbmpfile(StringBuilder strData);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintDiskimgfile", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintDiskimgfile(StringBuilder strData);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintQrcode", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintQrcode(StringBuilder strData, int iLmargin, int iMside, int iRound);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintRemainQR", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintRemainQR();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetLeftmargin", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetLeftmargin(int iLmargin);

        [DllImport("Msprintsdk.dll", EntryPoint = "GetProductinformation", CharSet = CharSet.Ansi)]
        public static extern unsafe int GetProductinformation(int Fstype, byte[] FIDdata, int iFidlen);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintTransmit", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintTransmit(byte[] strCmd, int iLength);

        [DllImport("Msprintsdk.dll", EntryPoint = "GetTransmit", CharSet = CharSet.Ansi)]
        public static extern unsafe int GetTransmit(byte[] strCmd, int iLength, byte[] bRecv, int iRelen);


        [DllImport("Msprintsdk.dll", EntryPoint = "PrintFeedDot", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintFeedDot(int Lnumber);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintChargeRow", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintChargeRow();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetSpacechar", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetSpacechar(int iSpace);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetSizechar", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetSizechar(int iHeight, int iWidth, int iUnderline, int iAsciitype);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetRotate", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetRotate(int iRotate);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetDirection", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetDirection(int iDirection);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetWhitemodel", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetWhitemodel(int iWhite);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetUnderline", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetUnderline(int underline);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintNextHT", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintNextHT();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetHTseat", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetHTseat(byte[] bHTseat, int iLength);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetCodepage", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetCodepage(int country, int CPnumber);

        [DllImport("Msprintsdk.dll", EntryPoint = "Print1Dbar", CharSet = CharSet.Ansi)]
        public static extern unsafe int Print1Dbar(int iWidth, int iHeight, int iHrisize, int iHriseat, int iCodetype, StringBuilder strData);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetPagemode", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetPagemode(int iMode, int Xrange, int Yrange);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetPagestartposition", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetPagestartposition(int Xdot, int Ydot);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetPagedirection", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetPagedirection(int iDirection);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintPagedata", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintPagedata();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetReadZKmode", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetReadZKmode(int mode);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetNvbmp", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetNvbmp(int iNums, StringBuilder strPath);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintNvbmp", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintNvbmp(int iNvindex, int iMode);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetPrintIDorName", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetPrintIDorName(StringBuilder strIDorNAME);

        [DllImport("Msprintsdk.dll", EntryPoint = "GetPrintIDorName", CharSet = CharSet.Ansi)]
        public static extern unsafe int GetPrintIDorName(StringBuilder strIDorNAME);


        [DllImport("Msprintsdk.dll", EntryPoint = "PrintMarkcutpaper", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintMarkcutpaper(int iMode);

        [DllImport("Msprintsdk.dll", EntryPoint = "SetTraceLog", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetTraceLog(int iLog);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintPdf417", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintPdf417(int iDotwidth, int iDotheight, int iDatarows, int iDatacolumns, StringBuilder strData);

        //旋转模式
        [DllImport("Msprintsdk.dll", EntryPoint = "SetRotation_Intomode", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetRotation_Intomode();

        [DllImport("Msprintsdk.dll", EntryPoint = "SetRotation_Leftspace", CharSet = CharSet.Ansi)]
        public static extern unsafe int SetRotation_Leftspace(int iLeftspace);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintRotation_Sendcode", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintRotation_Sendcode(int leftspace, int iWidth, int iHeight, int iCodetype, StringBuilder strData);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintRotation_Sendtext", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintRotation_Sendtext(StringBuilder strData, int iImme);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintRotation_Changeline", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintRotation_Changeline();

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintRotation_Data", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintRotation_Data();


        [DllImport("Msprintsdk.dll", EntryPoint = "PrintPDF_CCCB", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintPDF_CCCB(StringBuilder strData);

        [DllImport("Msprintsdk.dll", EntryPoint = "PrintDataMatrix", CharSet = CharSet.Ansi)]
        public static extern unsafe int PrintDataMatrix(StringBuilder strData, int iSize);


        StringBuilder m_sbData = new StringBuilder();
        TestRecord t = new TestRecord();

        public Print(string qrcode)
        {
            // 查询信息


            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from TestRecord where qrcode='" + qrcode + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                t.Queque = reader["queue"].ToString();

                t.Ksdate = reader["ksdate"].ToString();

                t.Ksname = reader["ksname"].ToString();

                t.KsId = reader["ksId"].ToString();

                t.Lxyl = reader["lxyl"].ToString();

                t.Lxlx = reader["lxlx"].ToString();
                t.Zxyl = reader["zxyl"].ToString();

                t.Zxlx = reader["zxlx"].ToString();



                t.Adfxh = reader["aqfxh"].ToString();

                t.Qrcode = reader["qrcode"].ToString();
            }
            con.Close();
            InitializeComponent();
            InitConfig();
            this.queue.Text = t.Queque.Trim();
            this.kstime.Text = t.Ksdate.Trim();
            this.ksname.Text = t.Ksname.Trim();
            this.ksId.Text = t.KsId.Trim();
            this.lxyl.Text = "要求整定压力:" + t.Lxyl.ToString().Trim() + "Mpa";
            this.lxlx.Text = "使用设备类型:" + t.Lxlx.ToString().Trim();
            this.zxyl.Text = "要求整定压力:" + t.Zxyl.ToString().Trim() + "Mpa";
            this.zxlx.Text = "使用设备类型:" + t.Zxlx.ToString().Trim();
            this.aqfxh.Text = "安全阀型号:" + t.Adfxh.ToString().Trim();
        }
        public int r = 1;
        private void InitConfig()
        {
            datahelp a = new datahelp();
            a.Initc();
            //获取打印机端口号
            if (File.Exists("Msprintsdk.dll"))
            {
                // ff.ShowInfoTip("打印模块加载成功");

            }


            r = SetUsbportauto();
            //  ff.ShowInfoTip(r.ToString());

            if (r == 0)
            {
                r = SetInit();
                SetClean();
                SetReadZKmode(0);
            }
            else
            {
                ff.ShowErrorNotifier("打印机失败");

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {




            SetClean();
            PrintCutpaper(0);
            SetAlignment(1);
            PrintString(new StringBuilder("***安全阀模拟考试系统****"), 1);
            PrintChargeRow();
            PrintChargeRow();
            SetSpacechar(5);
            SetLinespace(50);
            SetAlignment(0);
            PrintString(new StringBuilder("考 生：" + t.Ksname.Trim() + " " + "排队号：" + t.Queque.Trim()), 1);

            PrintChargeRow();
            PrintString(new StringBuilder("考试日期："), 1);
            PrintChargeRow();
            PrintString(new StringBuilder(t.Ksdate.Trim()), 1);
            PrintChargeRow();
            PrintString(new StringBuilder("身份证号："), 1);
            PrintChargeRow();
            PrintString(new StringBuilder(t.KsId.Trim()), 1);
            PrintString(new StringBuilder(), 1);
            PrintChargeRow();
            SetAlignment(0);
            PrintString(new StringBuilder("1、离线校验"), 1);
            PrintChargeRow();
            PrintString(new StringBuilder("要求整定压力:" + t.Lxyl.Trim() + "Mpa"), 1);
            PrintChargeRow();
            PrintString(new StringBuilder("使用设备类型:" + t.Lxlx.Trim()), 1);
            PrintChargeRow();
            SetAlignment(0);
            PrintString(new StringBuilder("2、在线校验"), 1);
            PrintChargeRow();
            PrintString(new StringBuilder("要求整定压力:" + t.Zxyl.Trim() + "Mpa"), 1);
            PrintChargeRow();
            PrintString(new StringBuilder("使用设备类型:" + t.Zxlx.Trim()), 1);
            PrintChargeRow();

            SetAlignment(0);
            PrintString(new StringBuilder("3 密封面研磨"), 1);
            PrintChargeRow();
            PrintString(new StringBuilder("安全阀型号:" + t.Adfxh.Trim()), 1);
            PrintChargeRow();
            SetSpacechar(2);
            PrintChargeRow();
            PrintQrcode(new StringBuilder(t.Qrcode), 8, 2, 0);
            PrintChargeRow();
            PrintChargeRow();
            PrintChargeRow();
            PrintChargeRow();
            PrintChargeRow();
            PrintChargeRow();
            PrintCutpaper(0);

            ff.ShowInfoTip("打印完成");

            Thread.Sleep(2000);
            this.Close();
            //ff.backlogin();
            // 生成考试成绩单
        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {


            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }
        Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.label2, this);
            ff.fullsreen(this.button3, this);
            ff.fullsreen(this.button7, this);
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
        private void Choose_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }
        private void Print_Load(object sender, EventArgs e)
        {

            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
            //  this.change();
            //   ff.same(this);
        }

        private void uiLight1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ff.backlogin();
            this.Close();
        }

        private void ksId_Click(object sender, EventArgs e)
        {

        }

        private void kstime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
