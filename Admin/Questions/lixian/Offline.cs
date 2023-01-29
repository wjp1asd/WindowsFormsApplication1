﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //    MessageBox.Show(a.color1);
            c.fullsreen(this.label2,this);
            c.fullsreen(this.button1, this);
            c.fullsreen(this.button2, this);
            c.fullsreen(this.button3, this);



        }

        private void Offline_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
            Offline_Record a = new Offline_Record();
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
