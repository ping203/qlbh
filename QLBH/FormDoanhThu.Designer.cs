namespace QLBH
{
    partial class FormDoanhThu
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetReport = new QLBH.DataSetReport();
            this.label1 = new System.Windows.Forms.Label();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.txtTienChi = new System.Windows.Forms.TextBox();
            this.ctxuathanghoaDataGridView = new System.Windows.Forms.DataGridView();
            this.ngayChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHieuThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHieuChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDoChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableReportDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerCTXuatHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.dataTableReportDoanhThuTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportDoanhThuTableAdapter();
            this.txtLoiNhuan = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctxuathanghoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportDoanhThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(460, 646);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(256, 16);
            label6.TabIndex = 2017;
            label6.Text = "Tổng Chi:  ..............................................";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(179, 646);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(260, 16);
            label7.TabIndex = 2036;
            label7.Text = "Tổng Thu:  ..............................................";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(741, 646);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(262, 16);
            label2.TabIndex = 2038;
            label2.Text = "Lợi Nhuận:  ..............................................";
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
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO LỢI NHUẬN";
            // 
            // lableB_NgayHT
            // 
            this.lableB_NgayHT.BackColor = System.Drawing.Color.White;
            this.lableB_NgayHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lableB_NgayHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableB_NgayHT.ForeColor = System.Drawing.Color.Indigo;
            this.lableB_NgayHT.Location = new System.Drawing.Point(370, 61);
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
            this.dtpTuNgay.Location = new System.Drawing.Point(408, 58);
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
            this.textBox1.Location = new System.Drawing.Point(536, 61);
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
            this.dtpDenNgay.Location = new System.Drawing.Point(579, 58);
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
            // txtTienChi
            // 
            this.txtTienChi.BackColor = System.Drawing.Color.White;
            this.txtTienChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienChi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienChi.ForeColor = System.Drawing.Color.Red;
            this.txtTienChi.Location = new System.Drawing.Point(540, 632);
            this.txtTienChi.Name = "txtTienChi";
            this.txtTienChi.ReadOnly = true;
            this.txtTienChi.Size = new System.Drawing.Size(169, 25);
            this.txtTienChi.TabIndex = 2018;
            this.txtTienChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctxuathanghoaDataGridView
            // 
            this.ctxuathanghoaDataGridView.AllowUserToAddRows = false;
            this.ctxuathanghoaDataGridView.AllowUserToDeleteRows = false;
            this.ctxuathanghoaDataGridView.AutoGenerateColumns = false;
            this.ctxuathanghoaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctxuathanghoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctxuathanghoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayChiDataGridViewTextBoxColumn,
            this.soHieuThuDataGridViewTextBoxColumn,
            this.soHieuChiDataGridViewTextBoxColumn,
            this.tenNhaCCDataGridViewTextBoxColumn,
            this.SoTienThu,
            this.SoTienChi,
            this.lyDoChiDataGridViewTextBoxColumn});
            this.ctxuathanghoaDataGridView.DataSource = this.dataTableReportDoanhThuBindingSource;
            this.ctxuathanghoaDataGridView.Location = new System.Drawing.Point(8, 94);
            this.ctxuathanghoaDataGridView.Name = "ctxuathanghoaDataGridView";
            this.ctxuathanghoaDataGridView.ReadOnly = true;
            this.ctxuathanghoaDataGridView.RowHeadersVisible = false;
            this.ctxuathanghoaDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ctxuathanghoaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctxuathanghoaDataGridView.Size = new System.Drawing.Size(988, 531);
            this.ctxuathanghoaDataGridView.TabIndex = 2031;
            // 
            // ngayChiDataGridViewTextBoxColumn
            // 
            this.ngayChiDataGridViewTextBoxColumn.DataPropertyName = "NgayChi";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayChiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayChiDataGridViewTextBoxColumn.FillWeight = 70F;
            this.ngayChiDataGridViewTextBoxColumn.HeaderText = "Ngày Lập";
            this.ngayChiDataGridViewTextBoxColumn.Name = "ngayChiDataGridViewTextBoxColumn";
            this.ngayChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soHieuThuDataGridViewTextBoxColumn
            // 
            this.soHieuThuDataGridViewTextBoxColumn.DataPropertyName = "SoHieuThu";
            this.soHieuThuDataGridViewTextBoxColumn.FillWeight = 80F;
            this.soHieuThuDataGridViewTextBoxColumn.HeaderText = "Số Hiệu Thu";
            this.soHieuThuDataGridViewTextBoxColumn.Name = "soHieuThuDataGridViewTextBoxColumn";
            this.soHieuThuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soHieuChiDataGridViewTextBoxColumn
            // 
            this.soHieuChiDataGridViewTextBoxColumn.DataPropertyName = "SoHieuChi";
            this.soHieuChiDataGridViewTextBoxColumn.FillWeight = 80F;
            this.soHieuChiDataGridViewTextBoxColumn.HeaderText = "Số Hiệu Chi";
            this.soHieuChiDataGridViewTextBoxColumn.Name = "soHieuChiDataGridViewTextBoxColumn";
            this.soHieuChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhaCCDataGridViewTextBoxColumn
            // 
            this.tenNhaCCDataGridViewTextBoxColumn.DataPropertyName = "TenNhaCC";
            this.tenNhaCCDataGridViewTextBoxColumn.FillWeight = 190F;
            this.tenNhaCCDataGridViewTextBoxColumn.HeaderText = "Diễn Giải";
            this.tenNhaCCDataGridViewTextBoxColumn.Name = "tenNhaCCDataGridViewTextBoxColumn";
            this.tenNhaCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SoTienThu
            // 
            this.SoTienThu.DataPropertyName = "SoTienThu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            dataGridViewCellStyle2.NullValue = "0";
            this.SoTienThu.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoTienThu.FillWeight = 80F;
            this.SoTienThu.HeaderText = "Số Tiền Thu";
            this.SoTienThu.Name = "SoTienThu";
            this.SoTienThu.ReadOnly = true;
            // 
            // SoTienChi
            // 
            this.SoTienChi.DataPropertyName = "SoTienChi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "###,###,###,##0";
            dataGridViewCellStyle3.NullValue = "0";
            this.SoTienChi.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoTienChi.FillWeight = 80F;
            this.SoTienChi.HeaderText = "Số Tiền Chi";
            this.SoTienChi.Name = "SoTienChi";
            this.SoTienChi.ReadOnly = true;
            // 
            // lyDoChiDataGridViewTextBoxColumn
            // 
            this.lyDoChiDataGridViewTextBoxColumn.DataPropertyName = "LyDoChi";
            this.lyDoChiDataGridViewTextBoxColumn.FillWeight = 120F;
            this.lyDoChiDataGridViewTextBoxColumn.HeaderText = "Lý Do";
            this.lyDoChiDataGridViewTextBoxColumn.Name = "lyDoChiDataGridViewTextBoxColumn";
            this.lyDoChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTableReportDoanhThuBindingSource
            // 
            this.dataTableReportDoanhThuBindingSource.DataMember = "DataTableReportDoanhThu";
            this.dataTableReportDoanhThuBindingSource.DataSource = this.dataSetReport;
            // 
            // reportViewerCTXuatHang
            // 
            reportDataSource1.Name = "DataSetDoanhThu";
            reportDataSource1.Value = this.dataTableReportDoanhThuBindingSource;
            this.reportViewerCTXuatHang.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCTXuatHang.LocalReport.ReportEmbeddedResource = "QLBH.ReportDoanhThu.rdlc";
            this.reportViewerCTXuatHang.Location = new System.Drawing.Point(8, 9);
            this.reportViewerCTXuatHang.Name = "reportViewerCTXuatHang";
            this.reportViewerCTXuatHang.Size = new System.Drawing.Size(360, 28);
            this.reportViewerCTXuatHang.TabIndex = 2034;
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.ForeColor = System.Drawing.Color.Blue;
            this.btnInBaoCao.Location = new System.Drawing.Point(888, 55);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(108, 33);
            this.btnInBaoCao.TabIndex = 2035;
            this.btnInBaoCao.Text = "In Báo Cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInChiTietXuat_Click);
            // 
            // txtTienThu
            // 
            this.txtTienThu.BackColor = System.Drawing.Color.White;
            this.txtTienThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienThu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThu.ForeColor = System.Drawing.Color.Red;
            this.txtTienThu.Location = new System.Drawing.Point(260, 632);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.ReadOnly = true;
            this.txtTienThu.Size = new System.Drawing.Size(172, 25);
            this.txtTienThu.TabIndex = 2037;
            this.txtTienThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataTableReportDoanhThuTableAdapter
            // 
            this.dataTableReportDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.BackColor = System.Drawing.Color.White;
            this.txtLoiNhuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoiNhuan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoiNhuan.ForeColor = System.Drawing.Color.Red;
            this.txtLoiNhuan.Location = new System.Drawing.Point(827, 632);
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.ReadOnly = true;
            this.txtLoiNhuan.Size = new System.Drawing.Size(169, 25);
            this.txtLoiNhuan.TabIndex = 2039;
            this.txtLoiNhuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtLoiNhuan);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtTienThu);
            this.Controls.Add(label7);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.reportViewerCTXuatHang);
            this.Controls.Add(this.ctxuathanghoaDataGridView);
            this.Controls.Add(this.txtTienChi);
            this.Controls.Add(label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lableB_NgayHT);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctxuathanghoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportDoanhThuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lableB_NgayHT;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.TextBox txtTienChi;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.DataGridView ctxuathanghoaDataGridView;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCTXuatHang;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.TextBox txtTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienXuat;
        private System.Windows.Forms.BindingSource dataTableReportDoanhThuBindingSource;
        private DataSetReportTableAdapters.DataTableReportDoanhThuTableAdapter dataTableReportDoanhThuTableAdapter;
        private System.Windows.Forms.TextBox txtLoiNhuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDoChiDataGridViewTextBoxColumn;
    }
}