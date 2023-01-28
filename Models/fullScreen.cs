using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class fullScreen {

        //控件大小随窗体变化
        private float X;//定义当前窗体的宽度
        private float Y;//定义当前窗体的高度
                        //添加窗体事件Load（加载窗体时）

        public fullScreen(Form f ) {
            X = f.Width;//赋值初始窗体宽度
            Y = f.Height;//赋值初始窗体高度
           
        }
      
        //添加窗体事件Resize（调整控件大小时）
        public void setSize(Form f)
        {
            float newX = f.Width / X;//获取当前宽度与初始宽度的比例
            float newY = f.Height / Y;//获取当前高度与初始高度的比例
            setControls(newX, newY, f);
            Trace.WriteLine("初始宽度：" + X);
            Trace.WriteLine("初始高度：" + Y);
            Trace.WriteLine("宽度：" + f.Width);
            Trace.WriteLine("高度：" + f.Height);
           
            //this.Text = "窗体宽：" + this.Width.ToString() + " 窗体高：" + this.Height.ToString();//窗体标题栏
        }
        //自定义方法setTag（获取控件的width、height、left、top、字体大小等信息的值）
        public void setTag(Control cons)
        {//遍历窗体中的控件
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                Trace.WriteLine("控件："+con.Tag);
                if (con.Controls.Count > 0)
               {
                  setTag(con);
                }
            }
        }
        //自定义方法setControls（根据窗体大小调整控件大小）
        public void setControls(float newX, float newY, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组
               
                float a = Convert.ToSingle(mytag[0]) * newX;//根据窗体缩放比例确定控件的值，宽度//89*300
                con.Width = (int)(a);//宽度

                a = Convert.ToSingle(mytag[1]) * newY;//根据窗体缩放比例确定控件的值，高度//12*300
                con.Height = (int)(a);//高度

                a = Convert.ToSingle(mytag[2]) * newX- Convert.ToSingle(mytag[0]) * newX;//根据窗体缩放比例确定控件的值，左边距离//
                con.Left = (int)(a);//左边距离

                a = Convert.ToSingle(mytag[3]) * newY- Convert.ToSingle(mytag[1]) * newY;//根据窗体缩放比例确定控件的值，上边缘距离
                con.Top = (int)(a);//上边缘距离
                
                Single currentSize = Convert.ToSingle(mytag[4]) * newY;//根据窗体缩放比例确定控件的值，字体大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);//字体大小

                Trace.WriteLine(con.Name+"控件变形left：" + con.Left);
            }
           
        }

    }



}
