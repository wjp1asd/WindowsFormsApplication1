﻿namespace WindowsFormsApplication1.Admin.Questions.lixian
{
    partial class rr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.examonlineDataSet = new WindowsFormsApplication1.examonlineDataSet();
            this.lxjlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lxjlTableAdapter = new WindowsFormsApplication1.examonlineDataSetTableAdapters.lxjlTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.examonlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxjlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lxjlBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Admin.Questions.lixian.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 441);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // examonlineDataSet
            // 
            this.examonlineDataSet.DataSetName = "examonlineDataSet";
            this.examonlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lxjlBindingSource
            // 
            this.lxjlBindingSource.DataMember = "lxjl";
            this.lxjlBindingSource.DataSource = this.examonlineDataSet;
            // 
            // lxjlTableAdapter
            // 
            this.lxjlTableAdapter.ClearBeforeFill = true;
            // 
            // rr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rr";
            this.Text = "rr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examonlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxjlBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private examonlineDataSet examonlineDataSet;
        private System.Windows.Forms.BindingSource lxjlBindingSource;
        private examonlineDataSetTableAdapters.lxjlTableAdapter lxjlTableAdapter;
    }
}