namespace QLBH
{
    partial class FormBCChi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.Label label6;
            this.dataTableReportBCChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new QLBH.DataSetReport();
            this.label1 = new System.Windows.Forms.Label();
            this.bcchiDataGridView = new System.Windows.Forms.DataGridView();
            this.NgayChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphieuchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.btnInBCChi = new System.Windows.Forms.Button();
            this.reportViewerBCChi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableReportBCChiTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportBCChiTableAdapter();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportBCChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcchiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableReportBCChiBindingSource
            // 
            this.dataTableReportBCChiBindingSource.DataMember = "DataTableReportBCChi";
            this.dataTableReportBCChiBindingSource.DataSource = this.dataSetReport;
            // 
            // dataSetReport
            // 
            this.dataSetReport.DataSetName = "DataSetReport";
            this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO CHI";
            // 
            // bcchiDataGridView
            // 
            this.bcchiDataGridView.AllowUserToAddRows = false;
            this.bcchiDataGridView.AllowUserToDeleteRows = false;
            this.bcchiDataGridView.AutoGenerateColumns = false;
            this.bcchiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bcchiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcchiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayChi,
            this.SoHieu,
            this.TenNhaCC,
            this.LyDoChi,
            this.SoTienChi,
            this.GhiChu,
            this.idphieuchi,
            this.IdNhaCC,
            this.DiaChiNhaCC,
            this.SDTNhaCC,
            this.VBC,
            this.User,
            this.TrangThai});
            this.bcchiDataGridView.DataSource = this.dataTableReportBCChiBindingSource;
            this.bcchiDataGridView.Location = new System.Drawing.Point(4, 91);
            this.bcchiDataGridView.Name = "bcchiDataGridView";
            this.bcchiDataGridView.ReadOnly = true;
            this.bcchiDataGridView.RowHeadersVisible = false;
            this.bcchiDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bcchiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bcchiDataGridView.Size = new System.Drawing.Size(996, 545);
            this.bcchiDataGridView.TabIndex = 2;
            // 
            // NgayChi
            // 
            this.NgayChi.DataPropertyName = "NgayChi";
            this.NgayChi.FillWeight = 60F;
            this.NgayChi.HeaderText = "Ngày Chi";
            this.NgayChi.Name = "NgayChi";
            this.NgayChi.ReadOnly = true;
            // 
            // SoHieu
            // 
            this.SoHieu.DataPropertyName = "SoHieu";
            this.SoHieu.FillWeight = 60F;
            this.SoHieu.HeaderText = "Số Hiệu";
            this.SoHieu.Name = "SoHieu";
            this.SoHieu.ReadOnly = true;
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.DataPropertyName = "TenNhaCC";
            this.TenNhaCC.FillWeight = 170F;
            this.TenNhaCC.HeaderText = "Nhà Cung Cấp";
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.ReadOnly = true;
            // 
            // LyDoChi
            // 
            this.LyDoChi.DataPropertyName = "LyDoChi";
            this.LyDoChi.FillWeight = 170F;
            this.LyDoChi.HeaderText = "Lý Do Chi";
            this.LyDoChi.Name = "LyDoChi";
            this.LyDoChi.ReadOnly = true;
            // 
            // SoTienChi
            // 
            this.SoTienChi.DataPropertyName = "SoTienChi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "###,###,###,##0";
            dataGridViewCellStyle3.NullValue = "0";
            this.SoTienChi.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoTienChi.FillWeight = 70F;
            this.SoTienChi.HeaderText = "Số Tiền Chi";
            this.SoTienChi.Name = "SoTienChi";
            this.SoTienChi.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.FillWeight = 70F;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // idphieuchi
            // 
            this.idphieuchi.DataPropertyName = "idphieuchi";
            this.idphieuchi.HeaderText = "idphieuchi";
            this.idphieuchi.Name = "idphieuchi";
            this.idphieuchi.ReadOnly = true;
            this.idphieuchi.Visible = false;
            // 
            // IdNhaCC
            // 
            this.IdNhaCC.DataPropertyName = "IdNhaCC";
            this.IdNhaCC.HeaderText = "IdNhaCC";
            this.IdNhaCC.Name = "IdNhaCC";
            this.IdNhaCC.ReadOnly = true;
            this.IdNhaCC.Visible = false;
            // 
            // DiaChiNhaCC
            // 
            this.DiaChiNhaCC.DataPropertyName = "DiaChiNhaCC";
            this.DiaChiNhaCC.HeaderText = "DiaChiNhaCC";
            this.DiaChiNhaCC.Name = "DiaChiNhaCC";
            this.DiaChiNhaCC.ReadOnly = true;
            this.DiaChiNhaCC.Visible = false;
            // 
            // SDTNhaCC
            // 
            this.SDTNhaCC.DataPropertyName = "SDTNhaCC";
            this.SDTNhaCC.HeaderText = "SDTNhaCC";
            this.SDTNhaCC.Name = "SDTNhaCC";
            this.SDTNhaCC.ReadOnly = true;
            this.SDTNhaCC.Visible = false;
            // 
            // VBC
            // 
            this.VBC.DataPropertyName = "VBC";
            this.VBC.HeaderText = "VBC";
            this.VBC.Name = "VBC";
            this.VBC.ReadOnly = true;
            this.VBC.Visible = false;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Visible = false;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // lableB_NgayHT
            // 
            this.lableB_NgayHT.BackColor = System.Drawing.Color.White;
            this.lableB_NgayHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lableB_NgayHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableB_NgayHT.ForeColor = System.Drawing.Color.Indigo;
            this.lableB_NgayHT.Location = new System.Drawing.Point(348, 61);
            this.lableB_NgayHT.Name = "lableB_NgayHT";
            this.lableB_NgayHT.ReadOnly = true;
            this.lableB_NgayHT.Size = new System.Drawing.Size(32, 19);
            this.lableB_NgayHT.TabIndex = 2003;
            this.lableB_NgayHT.TabStop = false;
            this.lableB_NgayHT.Text = "Từ: ";
            this.lableB_NgayHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(386, 58);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(95, 23);
            this.dtpTuNgay.TabIndex = 2004;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Indigo;
            this.textBox1.Location = new System.Drawing.Point(514, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(37, 19);
            this.textBox1.TabIndex = 2005;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Đến: ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(557, 58);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(95, 23);
            this.dtpDenNgay.TabIndex = 2006;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.hanghoaTableAdapter = null;
            this.tableAdapterManager.khachhangTableAdapter = null;
            this.tableAdapterManager.nhacungcapTableAdapter = null;
            this.tableAdapterManager.nhomhangTableAdapter = null;
            this.tableAdapterManager.phieuchiTableAdapter = null;
            this.tableAdapterManager.phieunhaphangctTableAdapter = null;
            this.tableAdapterManager.phieunhaphangTableAdapter = null;
            this.tableAdapterManager.phieuthuTableAdapter = null;
            this.tableAdapterManager.phieuxuathangctTableAdapter = null;
            this.tableAdapterManager.phieuxuathangTableAdapter = null;
            this.tableAdapterManager.phimtatTableAdapter = null;
            this.tableAdapterManager.taikhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBH.QLBHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnInBCChi
            // 
            this.btnInBCChi.ForeColor = System.Drawing.Color.Blue;
            this.btnInBCChi.Location = new System.Drawing.Point(890, 52);
            this.btnInBCChi.Name = "btnInBCChi";
            this.btnInBCChi.Size = new System.Drawing.Size(108, 33);
            this.btnInBCChi.TabIndex = 2007;
            this.btnInBCChi.Text = "In Báo Cáo Chi";
            this.btnInBCChi.UseVisualStyleBackColor = true;
            this.btnInBCChi.Click += new System.EventHandler(this.btnInTonKho_Click);
            // 
            // reportViewerBCChi
            // 
            reportDataSource3.Name = "DataSetBCChi";
            reportDataSource3.Value = this.dataTableReportBCChiBindingSource;
            this.reportViewerBCChi.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerBCChi.LocalReport.ReportEmbeddedResource = "QLBH.ReportBCChi.rdlc";
            this.reportViewerBCChi.Location = new System.Drawing.Point(12, 9);
            this.reportViewerBCChi.Name = "reportViewerBCChi";
            this.reportViewerBCChi.Size = new System.Drawing.Size(360, 29);
            this.reportViewerBCChi.TabIndex = 2008;
            // 
            // dataTableReportBCChiTableAdapter
            // 
            this.dataTableReportBCChiTableAdapter.ClearBeforeFill = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(778, 641);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(216, 25);
            this.txtTongTien.TabIndex = 2016;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(699, 655);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(302, 16);
            label6.TabIndex = 2015;
            label6.Text = "Tổng Tiền:  ........................................................";
            // 
            // FormBCChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(label6);
            this.Controls.Add(this.reportViewerBCChi);
            this.Controls.Add(this.btnInBCChi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lableB_NgayHT);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.bcchiDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormBCChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportBCChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcchiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bcchiDataGridView;
        private System.Windows.Forms.TextBox lableB_NgayHT;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.Button btnInBCChi;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBCChi;
        private System.Windows.Forms.BindingSource dataTableReportBCChiBindingSource;
        private DataSetReportTableAdapters.DataTableReportBCChiTableAdapter dataTableReportBCChiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}