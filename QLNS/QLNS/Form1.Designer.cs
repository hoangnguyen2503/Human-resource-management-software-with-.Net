namespace QLNS
{
    partial class Form1
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
            this.TblCongKhoiDieuHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new QLNS.DataSet2();
            this.rvPhong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.TblCongKhoiDieuHanhTableAdapter = new QLNS.DataSet2TableAdapters.TblCongKhoiDieuHanhTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiDieuHanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblCongKhoiDieuHanhBindingSource
            // 
            this.TblCongKhoiDieuHanhBindingSource.DataMember = "TblCongKhoiDieuHanh";
            this.TblCongKhoiDieuHanhBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvPhong
            // 
            this.rvPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblCongKhoiDieuHanhBindingSource;
            this.rvPhong.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPhong.LocalReport.ReportEmbeddedResource = "QLNS.Report5.rdlc";
            this.rvPhong.Location = new System.Drawing.Point(0, 71);
            this.rvPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rvPhong.Name = "rvPhong";
            this.rvPhong.ServerReport.BearerToken = null;
            this.rvPhong.Size = new System.Drawing.Size(1107, 640);
            this.rvPhong.TabIndex = 0;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(100, 13);
            this.txtTenphong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(148, 26);
            this.txtTenphong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên phòng";
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(305, 9);
            this.btTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(112, 35);
            this.btTimkiem.TabIndex = 3;
            this.btTimkiem.Text = "Tìm Kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            // 
            // TblCongKhoiDieuHanhTableAdapter
            // 
            this.TblCongKhoiDieuHanhTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenphong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 63);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rvPhong);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiDieuHanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPhong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource TblCongKhoiDieuHanhBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.TblCongKhoiDieuHanhTableAdapter TblCongKhoiDieuHanhTableAdapter;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Panel panel1;
    }
}