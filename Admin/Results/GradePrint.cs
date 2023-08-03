using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Admin.Results
{

    public partial class GradePrint : Form
    {
        public GradePrint(string qid)
        {
            datahelp.QId = qid;
            //  MessageBox.Show(qid);
            InitializeComponent();
        }
        private void printDocument_PrintA4Page(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("黑体", 20, System.Drawing.FontStyle.Bold);//标题字体           
            Font fntTxt = new Font("宋体", 10, System.Drawing.FontStyle.Regular);//正文文字         
            Font fntTxt1 = new Font("宋体", 8, System.Drawing.FontStyle.Regular);//正文文字           
            System.Drawing.Brush brush = new SolidBrush(System.Drawing.Color.Black);//画刷           
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black);           //线条颜色         
            try
            {
                e.Graphics.DrawString("成绩单汇总", titleFont, brush, new System.Drawing.Point(this.Width / 2 - 200, 0));
                //   Point[] points111 = { new Point(20, 38), new Point(this.Width, 38) };
                // e.Graphics.DrawLines(pen, points111);

                e.Graphics.DrawString("考生：" + a11.Text, fntTxt, brush, new System.Drawing.Point(80, 46));
                e.Graphics.DrawString("身份证：" + a12.Text, fntTxt, brush, new System.Drawing.Point(80, 66));
                e.Graphics.DrawString("考试码：" + a13.Text, fntTxt, brush, new System.Drawing.Point(80, 86));
                e.Graphics.DrawString("离线答题结果：" + a14.Text, fntTxt, brush, new System.Drawing.Point(80, 106));
                e.Graphics.DrawString("得分：" + a15.Text, fntTxt, brush, new System.Drawing.Point(80, 126));
                e.Graphics.DrawString("在线答题结果：" + a16.Text, fntTxt, brush, new System.Drawing.Point(80, 146));
                e.Graphics.DrawString("得分：" + a17.Text, fntTxt, brush, new System.Drawing.Point(80, 166));
                e.Graphics.DrawString("校验答题结果：" + a18.Text, fntTxt, brush, new System.Drawing.Point(80, 186));
                e.Graphics.DrawString("得分：" + a19.Text, fntTxt, brush, new System.Drawing.Point(80, 206));
                e.Graphics.DrawString("型号答题结果：" + a20.Text, fntTxt, brush, new System.Drawing.Point(80, 226));
                e.Graphics.DrawString("得分：" + a21.Text, fntTxt, brush, new System.Drawing.Point(80, 246));
                e.Graphics.DrawString("零配件答题结果：" + a22.Text, fntTxt, brush, new System.Drawing.Point(80, 266));
                e.Graphics.DrawString("得分：" + a23.Text, fntTxt, brush, new System.Drawing.Point(80, 286));
                e.Graphics.DrawString("研磨膏答题结果：" + a24.Text, fntTxt, brush, new System.Drawing.Point(80, 306));
                e.Graphics.DrawString("得分：" + a25.Text, fntTxt, brush, new System.Drawing.Point(80, 326));

                e.Graphics.DrawString("离线拍照：", fntTxt, brush, new System.Drawing.Point(80, 366));
                e.Graphics.DrawImage(new Bitmap(a1.lxpic), new System.Drawing.Point(80, 396));

                e.Graphics.DrawString("离线拍照：", fntTxt, brush, new System.Drawing.Point(80, 836));
                e.Graphics.DrawImage(new Bitmap(a1.lxpic1), new System.Drawing.Point(80, 866));

           
                e.Graphics.DrawString("在线拍照：", fntTxt, brush, new System.Drawing.Point(80, 1306));
                e.Graphics.DrawImage(new Bitmap(a1.zxpic), new System.Drawing.Point(80, 1336));

                e.Graphics.DrawString("在线拍照：", fntTxt, brush, new System.Drawing.Point(80, 1776));
                e.Graphics.DrawImage(new Bitmap(a1.zxpic1), new System.Drawing.Point(80, 1806));

                e.Graphics.DrawString("研磨方法：", fntTxt, brush, new System.Drawing.Point(80, 2246));
                e.Graphics.DrawImage(new Bitmap(a1.mxpic), new System.Drawing.Point(80, 2276));

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // printDocument1.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument_PrintA4Page);

            //pd.DefaultPageSettings.PrinterSettings.PrinterName = "ZDesigner GX430t";       //打印机名称
            //pd.DefaultPageSettings.Landscape = true;  //设置横向打印，不设置默认是纵向的
            pd.PrintController = new System.Drawing.Printing.StandardPrintController();
            pd.Print();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Grade a1 = new Grade();
        private void GradePrint_Load(object sender, EventArgs e)
        {

            a1.getOne(datahelp.QId);
            // MessageBox.Show(datahelp.QId);
            InitUi();
        }

        private void InitUi()
        {

            a11.Text = a1.name;
            a12.Text = a1.idcard;
            a13.Text = a1.testid;
            a14.Text = a1.lxcorrect.Replace("1", "√").Replace("0", "×");
            a15.Text = a1.score1.ToString().Replace("-1", "未考试");
            a16.Text = a1.zxcorrect.Replace("1", "√").Replace("0", "×");
            a17.Text = a1.score2.ToString().Replace("-1", "未考试");
            a18.Text = a1.jycorrect.Replace("1", "√").Replace("0", "×");
            a19.Text = a1.score3.ToString().Replace("-1", "未考试");
            a20.Text = a1.xhcorrect.Replace("1", "√").Replace("0", "×");
            a21.Text = a1.score4.ToString().Replace("-1", "未考试");
            a22.Text = a1.lpjcorrect.Replace("1", "√").Replace("0", "×");
            a23.Text = a1.score5.ToString().Replace("-1", "未考试");
            a24.Text = a1.ymgcorrect.Replace("1", "√").Replace("0", "×");
            a25.Text = a1.score6.ToString().Replace("-1", "未考试");
            this.pictureBox1.ImageLocation = a1.lxpic;
            this.pictureBox2.ImageLocation = a1.lxpic1;
            this.pictureBox3.ImageLocation = a1.zxpic;
            this.pictureBox4.ImageLocation = a1.zxpic1;
            this.pictureBox5.ImageLocation = a1.mxpic;
           

            // 离线前
            label33.Text = a1.xygb.ToString().Replace("-1", "未考试");
            label9.Text = a1.csfm.ToString().Replace("-1", "未考试");
            label34.Text = a1.wxxz.ToString().Replace("-1", "未考试");
            label35.Text = a1.zdyltz.ToString().Replace("-1", "未考试");

            // 离线中
            label23.Text = a1.sjlmsj.ToString().Replace("-1", "未考试");
            label21.Text = a1.azfm.ToString().Replace("-1", "未考试");
            label25.Text = a1.bycs.ToString().Replace("-1", "未考试");

            // 离线后
            label45.Text = a1.dkxyf.ToString().Replace("-1", "未考试");
            label44.Text = a1.gbylbqh.ToString().Replace("-1", "未考试");
            // 填写记录
            label51.Text = a1.yqzdyl.ToString().Replace("-1", "未考试");
            label50.Text = a1.gctj.ToString().Replace("-1", "未考试");
            label52.Text = a1.yldj.ToString().Replace("-1", "未考试");
            label53.Text = a1.dycyl.ToString().Replace("-1", "未考试");
            label61.Text = a1.decyl.ToString().Replace("-1", "未考试");
            label60.Text = a1.dscyl.ToString().Replace("-1", "未考试");
            label62.Text = a1.mfsyyl.ToString().Replace("-1", "未考试");
            label63.Text = a1.jyjl.ToString().Replace("-1", "未考试");
           

            // 在线
            label70.Text = a1.azfm1.ToString().Replace("-1", "未考试");
            label77.Text = a1.mfzjcl.ToString().Replace("-1", "未考试");
            label71.Text = a1.wxxz1.ToString().Replace("-1", "未考试");
            label72.Text = a1.cxfm1.ToString().Replace("-1", "未考试");
            label74.Text = a1.jyjg1.ToString().Replace("-1", "未考试");
            calctotal();
           
        }

        private void calctotal()
        {
            float a = 0;
            a = a1.score1 + a1.score2 + a1.score3 + a1.score4 + a1.score5 + a1.score6 +
               a1.xygb + a1.csfm + a1.wxxz + a1.zdyltz +
               a1.sjlmsj + a1.azfm + a1.bycs + a1.gbylbqh + a1.dkxyf +
               a1.yqzdyl + a1.gctj + a1.yldj + a1.dycyl + a1.decyl + a1.dscyl + a1.mfsyyl + a1.mfsyyl + a1.jyjl +
               a1.azfm1 + a1.mfzjcl + a1.wxxz1 + a1.cxfm1 + a1.jyjg1;
            MessageBox.Show("总分"+a);
            a1.updateGrade(a,"path",datahelp.QId);
           // this.label37.Text += a1.score1 + a1.score2 + a1.score3 + a1.score4 + a1.score5 + a1.score6;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
