namespace Quản_Lý_Nhà_Trọ
{
    partial class RpHopDong
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
            this.HOPDONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLNHATRODataSet = new Quản_Lý_Nhà_Trọ.QLNHATRODataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOPDONGTableAdapter = new Quản_Lý_Nhà_Trọ.QLNHATRODataSetTableAdapters.HOPDONGTableAdapter();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HOPDONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNHATRODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HOPDONGBindingSource
            // 
            this.HOPDONGBindingSource.DataMember = "HOPDONG";
            this.HOPDONGBindingSource.DataSource = this.QLNHATRODataSet;
            // 
            // QLNHATRODataSet
            // 
            this.QLNHATRODataSet.DataSetName = "QLNHATRODataSet";
            this.QLNHATRODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOPDONGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quản_Lý_Nhà_Trọ.RpHopDong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // HOPDONGTableAdapter
            // 
            this.HOPDONGTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(91, 6);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Hợp Đồng :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RpHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RpHopDong";
            this.Text = "RpHopDong";
            this.Load += new System.EventHandler(this.RpHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOPDONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNHATRODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOPDONGBindingSource;
        private QLNHATRODataSet QLNHATRODataSet;
        private QLNHATRODataSetTableAdapters.HOPDONGTableAdapter HOPDONGTableAdapter;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}