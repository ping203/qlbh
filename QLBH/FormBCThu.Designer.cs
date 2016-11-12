namespace QLBH
{
    partial class FormBCThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.Label label6;
            this.dataTableReportBCThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new QLBH.DataSetReport();
            this.label1 = new System.Windows.Forms.Label();
            this.bcthuDataGridView = new System.Windows.Forms.DataGridView();
            this.NgayThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.btnInBCChi = new System.Windows.Forms.Button();
            this.reportViewerBCThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableReportBCThuTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportBCThuTableAdapter();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportBCThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcthuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableReportBCThuBindingSource
            // 
            this.dataTableReportBCThuBindingSource.DataMember = "DataTableReportBCThu";
            this.dataTableReportBCThuBindingSource.DataSource = this.dataSetReport;
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
            this.label1.Size = new System.Drawing.Size(288, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO THU";
            // 
            // bcthuDataGridView
            // 
            this.bcthuDataGridView.AllowUserToAddRows = false;
            this.bcthuDataGridView.AllowUserToDeleteRows = false;
            this.bcthuDataGridView.AutoGenerateColumns = false;
            this.bcthuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bcthuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcthuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayThu,
            this.SoHieu,
            this.TenKhachHang,
            this.LyDoThu,
            this.SoTienThu,
            this.GhiChu,
            this.TrangThai,
            this.idphieuthu,
            this.IdKhachHang,
            this.DiaChiKhachHang,
            this.SDTKhachHang,
            this.VBC,
            this.User});
            this.bcthuDataGridView.DataSource = this.dataTableReportBCThuBindingSource;
            this.bcthuDataGridView.Location = new System.Drawing.Point(4, 91);
            this.bcthuDataGridView.Name = "bcthuDataGridView";
            this.bcthuDataGridView.ReadOnly = true;
            this.bcthuDataGridView.RowHeadersVisible = false;
            this.bcthuDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bcthuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bcthuDataGridView.Size = new System.Drawing.Size(996, 545);
            this.bcthuDataGridView.TabIndex = 2;
            // 
            // NgayThu
            // 
            this.NgayThu.DataPropertyName = "NgayThu";
            this.NgayThu.FillWeight = 60F;
            this.NgayThu.HeaderText = "Ngày Thu";
            this.NgayThu.Name = "NgayThu";
            this.NgayThu.ReadOnly = true;
            // 
            // SoHieu
            // 
            this.SoHieu.DataPropertyName = "SoHieu";
            this.SoHieu.FillWeight = 60F;
            this.SoHieu.HeaderText = "Số Hiệu";
            this.SoHieu.Name = "SoHieu";
            this.SoHieu.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.FillWeight = 170F;
            this.TenKhachHang.HeaderText = "Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // LyDoThu
            // 
            this.LyDoThu.DataPropertyName = "LyDoThu";
            this.LyDoThu.FillWeight = 170F;
            this.LyDoThu.HeaderText = "Lý Do Thu";
            this.LyDoThu.Name = "LyDoThu";
            this.LyDoThu.ReadOnly = true;
            // 
            // SoTienThu
            // 
            this.SoTienThu.DataPropertyName = "SoTienThu";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "###,###,###,##0";
            dataGridViewCellStyle1.NullValue = "0";
            this.SoTienThu.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoTienThu.FillWeight = 70F;
            this.SoTienThu.HeaderText = "Số Tiền Thu";
            this.SoTienThu.Name = "SoTienThu";
            this.SoTienThu.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.FillWeight = 70F;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // idphieuthu
            // 
            this.idphieuthu.DataPropertyName = "idphieuthu";
            this.idphieuthu.HeaderText = "idphieuthu";
            this.idphieuthu.Name = "idphieuthu";
            this.idphieuthu.ReadOnly = true;
            this.idphieuthu.Visible = false;
            // 
            // IdKhachHang
            // 
            this.IdKhachHang.DataPropertyName = "IdKhachHang";
            this.IdKhachHang.HeaderText = "IdKhachHang";
            this.IdKhachHang.Name = "IdKhachHang";
            this.IdKhachHang.ReadOnly = true;
            this.IdKhachHang.Visible = false;
            // 
            // DiaChiKhachHang
            // 
            this.DiaChiKhachHang.DataPropertyName = "DiaChiKhachHang";
            this.DiaChiKhachHang.HeaderText = "DiaChiKhachHang";
            this.DiaChiKhachHang.Name = "DiaChiKhachHang";
            this.DiaChiKhachHang.ReadOnly = true;
            this.DiaChiKhachHang.Visible = false;
            // 
            // SDTKhachHang
            // 
            this.SDTKhachHang.DataPropertyName = "SDTKhachHang";
            this.SDTKhachHang.HeaderText = "SDTKhachHang";
            this.SDTKhachHang.Name = "SDTKhachHang";
            this.SDTKhachHang.ReadOnly = true;
            this.SDTKhachHang.Visible = false;
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
            this.btnInBCChi.Text = "In Báo Cáo Thu";
            this.btnInBCChi.UseVisualStyleBackColor = true;
            this.btnInBCChi.Click += new System.EventHandler(this.btnInTonKho_Click);
            // 
            // reportViewerBCThu
            // 
            reportDataSource1.Name = "DataSetBCThu";
            reportDataSource1.Value = this.dataTableReportBCThuBindingSource;
            this.reportViewerBCThu.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBCThu.LocalReport.ReportEmbeddedResource = "QLBH.ReportBCThu.rdlc";
            this.reportViewerBCThu.Location = new System.Drawing.Point(12, 9);
            this.reportViewerBCThu.Name = "reportViewerBCThu";
            this.reportViewerBCThu.Size = new System.Drawing.Size(360, 29);
            this.reportViewerBCThu.TabIndex = 2008;
            // 
            // dataTableReportBCThuTableAdapter
            // 
            this.dataTableReportBCThuTableAdapter.ClearBeforeFill = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(780, 642);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(216, 25);
            this.txtTongTien.TabIndex = 2018;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(701, 656);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(302, 16);
            label6.TabIndex = 2017;
            label6.Text = "Tổng Tiền:  ........................................................";
            // 
            // FormBCThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(label6);
            this.Controls.Add(this.reportViewerBCThu);
            this.Controls.Add(this.btnInBCChi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lableB_NgayHT);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.bcthuDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormBCThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportBCThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcthuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bcthuDataGridView;
        private System.Windows.Forms.TextBox lableB_NgayHT;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.Button btnInBCChi;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBCThu;
        private System.Windows.Forms.BindingSource dataTableReportBCThuBindingSource;
        private DataSetReportTableAdapters.DataTableReportBCThuTableAdapter dataTableReportBCThuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn VBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}