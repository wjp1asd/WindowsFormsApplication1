﻿using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Questions;

namespace WindowsFormsApplication1.Admin.Questions.jiaoyangongyi
{
    public partial class JiaoYan : Form
    {

        Fuc c = new Fuc();
        public JiaoYan()
        {
            InitializeComponent();
            InitUI();
            c.same(this);

        }
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color4);
            this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);



            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //   ff.ShowInfoTip(a.color1);


            c.button(this.button1);

            c.button(this.button7);



        }


        private void button1_Click(object sender, EventArgs e)
        {
            questions a = new questions("3");
            a.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuestionSet s = new QuestionSet();
            s.Show();
            this.Close();
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
        private void JiaoYan_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.SizeChanged += groupBox1_Resize;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}
