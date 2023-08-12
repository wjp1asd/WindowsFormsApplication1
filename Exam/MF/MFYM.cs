using AutoWindowsSize;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam.MF;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class MFYM : Form
    {
        public MFYM(String qrcode)
        {
            InitializeComponent();

            InitUI();

        }
        bool draw = false;
        float score = 0;
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
        Grade g1 = new Grade();

        Graphics back;
        TestRecord t = new TestRecord();
        Score sc = new Score();
        private void MFYM_Load(object sender, EventArgs e)
        {
         
            // awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");

            this.uiLine1.Hide();
            this.uiLine2.Hide();
            InitScore();

            t = t.getRecord(datahelp.QId);
            this.label3.Text = "考生：" + t.Ksname;
            this.label4.Text = "身份证：" + t.KsId;
            // back.new Rectangle(this.uiLine1.Location.X, this.uiLine1.Location.Y, 500, 500);
        }
        private void InitScore()
        {
            score = sc.getScore("ymff");

            this.label6.Text = "研磨得分：" + score;
        }
        private void initBound()
        {
            Graphics graphics = this.CreateGraphics();
            Rectangle gle = new Rectangle(this.uiLine1.Location.X + 50, this.uiLine1.Location.Y + 10, this.Size.Width - 100, this.Size.Height - 225);
            Pen a = new Pen(Color.Red);


            Point p = this.PointToScreen(new Point(this.uiLine1.Location.X + 50, this.uiLine1.Location.Y + 10));
            graphics.DrawRectangle(pen, gle);

            this.Cursor = new Cursor(this.Cursor.Handle);
            Cursor.Position = new Point(this.Size.Width / 2, this.Size.Height / 2);
          //  Cursor.Clip = new Rectangle(p.X, p.Y, this.Size.Width - 100, this.Size.Height - 400);
           // MessageBox.Show("点击开始研磨");
            //MessageBox.Show(p.X+"-"+ p.Y + "-" + (this.Size.Width - 100) + "-" + (this.Size.Height - 400));
            //调用鼠标移动方法
            SetMouseSpeed( (uint)System.Windows.Forms.SystemInformation.MouseSpeed);
        }

        bool G_MouseFlag;
        Pen pen = new Pen(Color.Red);
        Point lastPoint;
        int screenWidthInPixels = Screen.PrimaryScreen.Bounds.Width;
        int screenHeightInPixels = Screen.PrimaryScreen.Bounds.Height;
        //声明给鼠标赋速度
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(UInt32 uiaction,UInt32 uiparam, UInt32 pvparam, UInt32 fwinini);
        //速度的判定条件，并赋值
        public static void SetMouseSpeed(UInt32 speed)
        {
            uint mouseSpeed = speed;
            if(mouseSpeed>1)
            {
                mouseSpeed = 1;
            }
            SystemParametersInfo(0X0071,0,mouseSpeed,0);

        }
        
        private void _018_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.Location;
            //获取系统鼠标移动的速度
         int s=   System.Windows.Forms.SystemInformation.MouseSpeed;
          
            // 获取屏幕中心坐标
            int centerX = screenWidthInPixels / 2;
            int centerY = screenHeightInPixels / 2;
            // 设置轨迹缩小的缩放比例（*100 是为了*出不为0）
            float scale1 = 0.7f*100;
            float scale2 = 0.7f*100;
            // 计算鼠标位置与屏幕中心的距离
            int deltaX = mousePosition.X  - centerX;
            int deltaY = mousePosition.Y  - centerY;
            // 根据缩放比例缩小坐标（去除上面* 100 的影响）
            int scaledX = centerX + (int)(deltaX * scale1 / 100);
            int scaledY = centerY + (int)(deltaY  * scale2 / 100);

            // 缩小后的坐标
            Point scaledMousePosition = new Point(scaledX, scaledY);
            if (draw == false)
            {
                return;
            }
            Graphics graphics = this.CreateGraphics();
            if (lastPoint.Equals(Point.Empty))//判断绘图开始点是否为空
            {
                //lastPoint = new Point(e.X, e.Y);//记录鼠标当前位置
                lastPoint = scaledMousePosition;//记录鼠标当前位置
            }
            if (G_MouseFlag)//开始绘图
            {
                graphics.DrawEllipse(Pens.Red, scaledMousePosition.X, scaledMousePosition.Y, 5, 5);
                // graphics.DrawEllipse(Pens.Red, e.X, e.Y, 5, 5);
                // Point currentPoint = new Point((int)scaledX, (int)scaledY);;//获取鼠标当前位置
                //  graphics.DrawLine(pen, scaledMousePosition, lastPoint);//绘图
                // ff.ShowInfoTip("X:Y" + currentPoint.X + "" + currentPoint.Y);
                //MessageBox.Show(scaledMousePosition.ToString()+ screenWidthInPixels+":"+screenHeightInPixels);
            }
            lastPoint = scaledMousePosition;//记录鼠标当前位置


        }
      
        private void _018_MouseDown(object sender, MouseEventArgs e)
        {
            G_MouseFlag = true;//开始绘图标识设置为true
        }

        private void _018_MouseUp(object sender, MouseEventArgs e)
        {
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
        private Fuc ff = new Fuc();
        private void button3_Click(object sender, EventArgs e)
        {
           
            //显示光标
            System.Windows.Forms.Cursor.Show();
            //结束鼠标速度的限制
            SystemParametersInfo(0X0071, 0, 7, 0);
           


            // 生成图片
            Bitmap bt = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bt);
            g.CopyFromScreen(new Point(this.Left, this.Top), new Point(0, 0), this.Size);
            bt.MakeTransparent();
            //本地保存
            string loc = ConfigurationManager.AppSettings["loc"];
            string connectionString = Application.StartupPath + "\\Images\\研磨照片\\" + t.Qrcode + t.Ksname + ".bmp";
            //   string connectionString = Application.StartupPath + "\\研磨图片\\1.bmp";
            string connectionString1 = loc + "\\研磨照片\\" + t.Qrcode + t.Ksname + ".bmp";
            bt.Save(connectionString, System.Drawing.Imaging.ImageFormat.Bmp);

            //try
            //{
            //    bt.Save(connectionString1, System.Drawing.Imaging.ImageFormat.Bmp);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            if (File.Exists(connectionString))
            {
                g1.updatepath(connectionString1, "mfpic", datahelp.QId);
                // g1.updateGrade()
                ff.ShowSuccessTip("得分" + score);
                // File.Copy(connectionString, Application.StartupPath+ "\\密封面图片\\1.bmp");
                // ff.ShowInfoTip("截图成功！");

            }
            datahelp.CurrentStep = 5;
            this.Close();
            MF1 mF = new MF1();
            mF.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void MFYM_KeyDown(object sender, KeyEventArgs e)

        {

            if (e.KeyCode == Keys.Escape)
            {
                ff.ShowInfoTip("ESC");
                Screen[] ss = Screen.AllScreens;
                this.Cursor = new Cursor(this.Cursor.Handle);
                Cursor.Clip = ss[0].Bounds;

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
            //光标隐藏
            System.Windows.Forms.Cursor.Hide();
            initBound();
            this.draw = true;
            button3.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
