using AutoWindowsSize;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MFYM : Form
    {
        public MFYM(String qrcode)
        {
            InitializeComponent();

            InitUI();

        }
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            // this.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color4);
            this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.label2.Text = "密封面动作研磨";



        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {


            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }


        bool G_MouseFlag=true;
        Pen pen = new Pen(Color.Black);
        Point lastPoint;

        private void MFYM_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
         
            this.SizeChanged += groupBox1_Resize;

            Graphics graphics = this.CreateGraphics();
            Rectangle gle = new Rectangle(20, 20, 200, 200);
            graphics.DrawEllipse(pen, gle);
        }
        
        private void _018_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("触发");
            Graphics graphics = this.CreateGraphics();
            if (lastPoint.Equals(Point.Empty))//判断绘图开始点是否为空
            {
                lastPoint = new Point(e.X, e.Y);//记录鼠标当前位置
            }
            if (G_MouseFlag)//开始绘图
            {
                Point currentPoint = new Point(e.X, e.Y);//获取鼠标当前位置
                graphics.DrawLine(pen, currentPoint, lastPoint);//绘图
            }
            lastPoint = new Point(e.X, e.Y);//记录鼠标当前位置
        }

        private void _018_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("触发1");
            G_MouseFlag = true;//开始绘图标识设置为true
        }

        private void _018_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("触发2");
            G_MouseFlag = false;//开始绘图标识设置为false
        }
        //画圆
        private void button1_Click(object sender, EventArgs e)
        {

            Graphics graphics = this.CreateGraphics();
            Rectangle gle = new Rectangle(this.uiLine1.Location.X, this.uiLine1.Location.Y, 500, 500);

            graphics.DrawRectangle(pen, gle);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Graphics graphics = this.CreateGraphics();
            Rectangle gle = new Rectangle(this.uiLine1.Location.X, this.uiLine1.Location.Y, 500, 500);
            graphics.DrawRectangle(pen, gle);
            graphics.Clear(Color.White);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 生成图片
            Bitmap bt = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bt);
            g.CopyFromScreen(new Point(this.Left, this.Top), new Point(0, 0), this.Size);
            bt.MakeTransparent();
            string connectionString = Application.StartupPath + "\\Images\\研磨照片\\1.bmp";
            //   string connectionString = Application.StartupPath + "\\研磨图片\\1.bmp";

            bt.Save(connectionString, System.Drawing.Imaging.ImageFormat.Bmp);

            if (File.Exists(connectionString))
            {
                // File.Copy(connectionString, Application.StartupPath+ "\\密封面图片\\1.bmp");
                MessageBox.Show("截图成功！");
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
