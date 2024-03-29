﻿using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Questions
{
    public partial class Offline : Form
    {
        public Offline()
        {
            InitializeComponent();
            InitUI();
            c.same(this);

        }
        Fuc c = new Fuc();
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color4);
            this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);


            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //   ff.ShowInfoTip(a.color1);
            //c.fullsreen(this.label2, this);
            //c.fullsreen(this.button1, this);
            //c.fullsreen(this.button2, this);
            //c.fullsreen(this.button3, this);
            //c.fullsreen(this.button7, this);

            /*c.button(this.button1);
            c.button(this.button2);
            c.button(this.button3);
           
            c.button(this.button7);*/

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
        private void Offline_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.SizeChanged += groupBox1_Resize;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            questions oq = new questions("1");
            oq.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Offline_JiaoYan oj = new Offline_JiaoYan();
            oj.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Offline_Record a = new Offline_Record();
            Record a = new Record("1");
            a.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            QuestionSet s = new QuestionSet();
            s.Show();
            this.Close();
        }
    }
}
