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
             //   e.Graphics.DrawString("离线答题结果：" + a14.Text, fntTxt, brush, new System.Drawing.Point(80, 106));
                e.Graphics.DrawString("总分得分：" + label17.Text, fntTxt, brush, new System.Drawing.Point(80, 126));
            
                e.Graphics.DrawString("离线得分：" + label7.Text, fntTxt, brush, new System.Drawing.Point(80, 166));
                e.Graphics.DrawString("在线得分：" + label11.Text, fntTxt, brush, new System.Drawing.Point(80, 186));
                e.Graphics.DrawString("密封得分：" + label15.Text, fntTxt, brush, new System.Drawing.Point(80, 206));
                e.Graphics.DrawString("型号答题结果：" + a20.Text, fntTxt, brush, new System.Drawing.Point(80, 226));
                e.Graphics.DrawString("得分：" + a21.Text, fntTxt, brush, new System.Drawing.Point(80, 246));
                e.Graphics.DrawString("零配件答题结果：" + a22.Text, fntTxt, brush, new System.Drawing.Point(80, 266));
                e.Graphics.DrawString("得分：" + a23.Text, fntTxt, brush, new System.Drawing.Point(80, 286));
                e.Graphics.DrawString("研磨膏答题结果：" + a24.Text, fntTxt, brush, new System.Drawing.Point(80, 306));
                e.Graphics.DrawString("得分：" + a25.Text, fntTxt, brush, new System.Drawing.Point(80, 326));
                Rectangle rec = new Rectangle(0,0,100,100);
                e.Graphics.DrawString("离线拍照：", fntTxt, brush, new System.Drawing.Point(80, 366));
              
                e.Graphics.DrawImage(new Bitmap(a1.lxpic), 80, 396,100,100);

                e.Graphics.DrawString("离线拍照：", fntTxt, brush, new System.Drawing.Point(80, 436));
               // e.Graphics.DrawImage(new Bitmap(a1.lxpic1), new System.Drawing.Point(80, 866));
                e.Graphics.DrawImage(new Bitmap(a1.lxpic1), 80, 596, 100, 100);

                e.Graphics.DrawString("在线拍照：", fntTxt, brush, new System.Drawing.Point(80, 606));
               // e.Graphics.DrawImage(new Bitmap(a1.zxpic), new System.Drawing.Point(80, 1336));
                e.Graphics.DrawImage(new Bitmap(a1.zxpic), 80, 796, 100, 100);
                e.Graphics.DrawString("在线拍照：", fntTxt, brush, new System.Drawing.Point(80, 876));
             //   e.Graphics.DrawImage(new Bitmap(a1.zxpic1), new System.Drawing.Point(80, 1806));
                e.Graphics.DrawImage(new Bitmap(a1.zxpic1), 80, 996, 100, 100);

                e.Graphics.DrawString("研磨方法：", fntTxt, brush, new System.Drawing.Point(80, 1046));
               // e.Graphics.DrawImage(new Bitmap(a1.mxpic), new System.Drawing.Point(80, 2276));
                e.Graphics.DrawImage(new Bitmap(a1.mxpic), 80, 1196, 100, 100);
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
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
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
            //a14.Text = a1.lxcorrect.Replace("1", "√").Replace("0", "×");
            //a15.Text = a1.score1.ToString().Replace("-1", "未考试");
            //a16.Text = a1.zxcorrect.Replace("1", "√").Replace("0", "×");
            //a17.Text = a1.score2.ToString().Replace("-1", "未考试");
            //a18.Text = a1.jycorrect.Replace("1", "√").Replace("0", "×");
            //a19.Text = a1.score3.ToString().Replace("-1", "未考试");
            a20.Text = a1.xhcorrect.Replace("1", "√").Replace("0", "×");
            a21.Text = a1.score4.ToString().Replace("-1", "未考试");
            a22.Text = a1.lpjcorrect.Replace("1", "√").Replace("0", "×");
            a23.Text = a1.score5.ToString().Replace("-1", "未考试");
            a24.Text = a1.ymgcorrect.Replace("1", "√").Replace("0", "×");
            a25.Text = a1.score6.ToString().Replace("-1", "未考试");

            label7.Text=a1.lxtotal.ToString();
            label11.Text=a1.zxtotal.ToString();
            label15.Text=a1.score8.ToString();
            label17.Text=a1.getGrade("path",datahelp.QId).ToString();
            this.pictureBox1.ImageLocation = a1.lxpic;
            this.pictureBox2.ImageLocation = a1.lxpic1;
            this.pictureBox3.ImageLocation = a1.zxpic;
            this.pictureBox4.ImageLocation = a1.zxpic1;
            this.pictureBox5.ImageLocation = a1.mxpic;
           
           // calctotal();

        }

        private void calctotal()
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            reset("score1");
        }

        private void reset(string name)
        {
            a1.updateGrade(-1, name, datahelp.QId);
            MessageBox.Show("当前考试重置成功");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reset("score2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reset("score3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset("score4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset("score5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset("score6");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LogPrint lg = new LogPrint(datahelp.QId);
            lg.Show();
        }
    }


}
