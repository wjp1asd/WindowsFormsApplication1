using AutoWindowsSize;
using System;
using System.Configuration;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
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
            //this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            //  this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

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
        DateTime currentTime = DateTime.Now;
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
            string timestamp = currentTime.ToString("yyyyMMddHHmmss");
            url = "\\研磨照片\\" + timestamp;
            // back.new Rectangle(this.uiLine1.Location.X, this.uiLine1.Location.Y, 500, 500);

            Cursor.Position = new System.Drawing.Point(screenWidthInPixels / 2, screenHeightInPixels / 2);
        }
        private void InitScore()
        {
            score = sc.getScore("mfym");

            //   this.label1.Text = "研磨得分：" + score;
        }
        private void initBound()
        {
            Graphics graphics = this.CreateGraphics();
            Rectangle gle = new Rectangle(this.uiLine1.Location.X + 50, this.uiLine1.Location.Y + 10, this.Size.Width - 100, this.Size.Height - 125);
            Pen a = new Pen(Color.Red);


            Point p = this.PointToScreen(new Point(this.uiLine1.Location.X + 50, this.uiLine1.Location.Y + 10));
            graphics.DrawRectangle(pen, gle);

            this.Cursor = new Cursor(this.Cursor.Handle);
            Cursor.Position = new Point(this.Size.Width / 2, this.Size.Height / 2);
            //  Cursor.Clip = new Rectangle(p.X, p.Y, this.Size.Width - 100, this.Size.Height - 400);
            // MessageBox.Show("点击开始研磨");
            //MessageBox.Show(p.X+"-"+ p.Y + "-" + (this.Size.Width - 100) + "-" + (this.Size.Height - 400));
            //调用鼠标移动方法
            SetMouseSpeed((uint)System.Windows.Forms.SystemInformation.MouseSpeed);
        }
        int screenWidthInPixels = Screen.PrimaryScreen.Bounds.Width;
        int screenHeightInPixels = Screen.PrimaryScreen.Bounds.Height;
        bool G_MouseFlag;
        Pen pen = new Pen(Color.Red);
        Point lastPoint;

        //声明给鼠标赋速度
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(UInt32 uiaction, UInt32 uiparam, UInt32 pvparam, UInt32 fwinini);
        //速度的判定条件，并赋值
        public static void SetMouseSpeed(UInt32 speed)
        {
            uint mouseSpeed = speed;
            if (mouseSpeed > 1)
            {
                mouseSpeed = 1;
            }
            SystemParametersInfo(0X0071, 0, mouseSpeed, 0);

        }

        private void _018_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.Location;
            //获取系统鼠标移动的速度
            int s = System.Windows.Forms.SystemInformation.MouseSpeed;

            // 获取屏幕中心坐标
            int centerX = screenWidthInPixels / 2;
            int centerY = screenHeightInPixels / 2;
            // 设置轨迹缩小的缩放比例（*100 是为了*出不为0）
            float scale1 = 0.7f * 100;
            float scale2 = 0.7f * 100;
            // 计算鼠标位置与屏幕中心的距离
            int deltaX = mousePosition.X - centerX;
            int deltaY = mousePosition.Y - centerY;
            // 根据缩放比例缩小坐标（去除上面* 100 的影响）
            int scaledX = centerX + (int)(deltaX * scale1 / 100);
            int scaledY = centerY + (int)(deltaY * scale2 / 100);

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

        // 定义屏幕的显示大小

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
            //（）
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
        Grade g = new Grade();
        private void shot1()
        {

            //显示光标
            System.Windows.Forms.Cursor.Show();
            //结束鼠标速度的限制
            SystemParametersInfo(0X0071, 0, 7, 0);

            g.updateGrade(score, "score8", datahelp.QId);
            Log log = new Log();
            log.updatelog("密封=研磨实操得分" + score, "mf-sc", score, datahelp.QId);
            try
            {
                // 生成图片
                Bitmap bt = new Bitmap(this.Width, this.Height);
                Graphics gg = Graphics.FromImage(bt);
                gg.CopyFromScreen(new Point(this.Left, this.Top), new Point(0, 0), this.Size);
                bt.MakeTransparent();

                string loc1 = ConfigurationManager.AppSettings["loc"];
                bt.Save(loc1 + url + t.Ksname.Trim() + "离线-azshot.png", System.Drawing.Imaging.ImageFormat.Bmp);
                string mm = loc1 + url + t.Ksname.Trim() + "离线-azshot.png";
                g.updatepath(mm, "mfpic", datahelp.QId);
            }
            catch (Exception)
            {
                ff.ShowErrorNotifier("保存图片异常");

            }


        }
        //MessageBox.Show(
        private Fuc ff = new Fuc();
        private string url;

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Thread x = new Thread(shot1);
                x.Start();
            }
            catch (Exception)
            {

                //  throw;
            }
            Thread.Sleep(2000);
            datahelp.CurrentStep = 5;
            this.Close();
            MF1 mF = new MF1();
            mF.Show();
            //光标显示
            System.Windows.Forms.Cursor.Show();
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
                this.draw = false;

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
    }
}
