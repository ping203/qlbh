namespace QLBH
{
    partial class FormCTHHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.txtTienXuat = new System.Windows.Forms.TextBox();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbKhoHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSLKho = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbGiaTriKho = new System.Windows.Forms.Label();
            this.ctxuathanghoaDataGridView = new System.Windows.Forms.DataGridView();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHieuXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonKhoDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableReportCTHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new QLBH.DataSetReport();
            this.reportViewerCTXuatHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnInChiTietXuat = new System.Windows.Forms.Button();
            this.txtTienNhap = new System.Windows.Forms.TextBox();
            this.dataTableReportCTHangHoaTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportCTHangHoaTableAdapter();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctxuathanghoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportCTHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(701, 656);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(299, 16);
            label6.TabIndex = 2017;
            label6.Text = "Tiền Xuất:  ........................................................";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(391, 656);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(302, 16);
            label7.TabIndex = 2036;
            label7.Text = "Tiền Nhập:  ........................................................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT HÀNG HÓA";
            // 
            // lableB_NgayHT
            // 
            this.lableB_NgayHT.BackColor = System.Drawing.Color.White;
            this.lableB_NgayHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lableB_NgayHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableB_NgayHT.ForeColor = System.Drawing.Color.Indigo;
            this.lableB_NgayHT.Location = new System.Drawing.Point(546, 104);
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
            this.dtpTuNgay.Location = new System.Drawing.Point(584, 101);
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
            this.textBox1.Location = new System.Drawing.Point(712, 104);
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
            this.dtpDenNgay.Location = new System.Drawing.Point(755, 101);
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
            // txtTienXuat
            // 
            this.txtTienXuat.BackColor = System.Drawing.Color.White;
            this.txtTienXuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienXuat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienXuat.ForeColor = System.Drawing.Color.Red;
            this.txtTienXuat.Location = new System.Drawing.Point(780, 642);
            this.txtTienXuat.Name = "txtTienXuat";
            this.txtTienXuat.ReadOnly = true;
            this.txtTienXuat.Size = new System.Drawing.Size(216, 25);
            this.txtTienXuat.TabIndex = 2018;
            this.txtTienXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.ForeColor = System.Drawing.Color.Blue;
            this.lbMaHang.Location = new System.Drawing.Point(87, 59);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(20, 16);
            this.lbMaHang.TabIndex = 2019;
            this.lbMaHang.Text = "...";
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.ForeColor = System.Drawing.Color.Blue;
            this.lbTenHang.Location = new System.Drawing.Point(87, 82);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(20, 16);
            this.lbTenHang.TabIndex = 2020;
            this.lbTenHang.Text = "...";
            // 
            // lbKhoHang
            // 
            this.lbKhoHang.AutoSize = true;
            this.lbKhoHang.ForeColor = System.Drawing.Color.Blue;
            this.lbKhoHang.Location = new System.Drawing.Point(87, 105);
            this.lbKhoHang.Name = "lbKhoHang";
            this.lbKhoHang.Size = new System.Drawing.Size(20, 16);
            this.lbKhoHang.TabIndex = 2021;
            this.lbKhoHang.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2024;
            this.label2.Text = "Kho Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2023;
            this.label3.Text = "Tên Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 2022;
            this.label4.Text = "Mã Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(543, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 2026;
            this.label5.Text = "Số Lượng Kho:";
            // 
            // lbSLKho
            // 
            this.lbSLKho.AutoSize = true;
            this.lbSLKho.ForeColor = System.Drawing.Color.Blue;
            this.lbSLKho.Location = new System.Drawing.Point(639, 55);
            this.lbSLKho.Name = "lbSLKho";
            this.lbSLKho.Size = new System.Drawing.Size(20, 16);
            this.lbSLKho.TabIndex = 2025;
            this.lbSLKho.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(533, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 2028;
            this.label8.Text = "Giá Trị Tồn Kho:";
            // 
            // lbGiaTriKho
            // 
            this.lbGiaTriKho.AutoSize = true;
            this.lbGiaTriKho.ForeColor = System.Drawing.Color.Blue;
            this.lbGiaTriKho.Location = new System.Drawing.Point(639, 78);
            this.lbGiaTriKho.Name = "lbGiaTriKho";
            this.lbGiaTriKho.Size = new System.Drawing.Size(20, 16);
            this.lbGiaTriKho.TabIndex = 2027;
            this.lbGiaTriKho.Text = "...";
            // 
            // ctxuathanghoaDataGridView
            // 
            this.ctxuathanghoaDataGridView.AllowUserToAddRows = false;
            this.ctxuathanghoaDataGridView.AllowUserToDeleteRows = false;
            this.ctxuathanghoaDataGridView.AutoGenerateColumns = false;
            this.ctxuathanghoaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctxuathanghoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctxuathanghoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayNhapDataGridViewTextBoxColumn,
            this.soHieuDataGridViewTextBoxColumn,
            this.soHieuXuatDataGridViewTextBoxColumn,
            this.tenNhaCCDataGridViewTextBoxColumn,
            this.SoLuongNhap,
            this.SoLuongXuat,
            this.tonKhoDKDataGridViewTextBoxColumn,
            this.idHangHoaDataGridViewTextBoxColumn});
            this.ctxuathanghoaDataGridView.DataSource = this.dataTableReportCTHangHoaBindingSource;
            this.ctxuathanghoaDataGridView.Location = new System.Drawing.Point(8, 135);
            this.ctxuathanghoaDataGridView.Name = "ctxuathanghoaDataGridView";
            this.ctxuathanghoaDataGridView.ReadOnly = true;
            this.ctxuathanghoaDataGridView.RowHeadersVisible = false;
            this.ctxuathanghoaDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ctxuathanghoaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctxuathanghoaDataGridView.Size = new System.Drawing.Size(988, 501);
            this.ctxuathanghoaDataGridView.TabIndex = 2031;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayNhapDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayNhapDataGridViewTextBoxColumn.FillWeight = 80F;
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày Lập";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            this.ngayNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soHieuDataGridViewTextBoxColumn
            // 
            this.soHieuDataGridViewTextBoxColumn.DataPropertyName = "SoHieu";
            this.soHieuDataGridViewTextBoxColumn.FillWeight = 80F;
            this.soHieuDataGridViewTextBoxColumn.HeaderText = "Số Hiệu Nhập";
            this.soHieuDataGridViewTextBoxColumn.Name = "soHieuDataGridViewTextBoxColumn";
            this.soHieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soHieuXuatDataGridViewTextBoxColumn
            // 
            this.soHieuXuatDataGridViewTextBoxColumn.DataPropertyName = "SoHieuXuat";
            this.soHieuXuatDataGridViewTextBoxColumn.FillWeight = 80F;
            this.soHieuXuatDataGridViewTextBoxColumn.HeaderText = "Số Hiệu Xuất";
            this.soHieuXuatDataGridViewTextBoxColumn.Name = "soHieuXuatDataGridViewTextBoxColumn";
            this.soHieuXuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhaCCDataGridViewTextBoxColumn
            // 
            this.tenNhaCCDataGridViewTextBoxColumn.DataPropertyName = "TenNhaCC";
            this.tenNhaCCDataGridViewTextBoxColumn.FillWeight = 220F;
            this.tenNhaCCDataGridViewTextBoxColumn.HeaderText = "Diễn Giải";
            this.tenNhaCCDataGridViewTextBoxColumn.Name = "tenNhaCCDataGridViewTextBoxColumn";
            this.tenNhaCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            dataGridViewCellStyle2.NullValue = "0";
            this.SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoLuongNhap.FillWeight = 80F;
            this.SoLuongNhap.HeaderText = "SL Nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuongXuat";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "###,###,###,##0";
            dataGridViewCellStyle3.NullValue = "0";
            this.SoLuongXuat.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoLuongXuat.FillWeight = 80F;
            this.SoLuongXuat.HeaderText = "SL Xuất";
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.ReadOnly = true;
            // 
            // tonKhoDKDataGridViewTextBoxColumn
            // 
            this.tonKhoDKDataGridViewTextBoxColumn.DataPropertyName = "TonKhoDK";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "###,###,###,##0";
            dataGridViewCellStyle4.NullValue = "0";
            this.tonKhoDKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tonKhoDKDataGridViewTextBoxColumn.FillWeight = 80F;
            this.tonKhoDKDataGridViewTextBoxColumn.HeaderText = "Tồn Đầu Kỳ";
            this.tonKhoDKDataGridViewTextBoxColumn.Name = "tonKhoDKDataGridViewTextBoxColumn";
            this.tonKhoDKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idHangHoaDataGridViewTextBoxColumn
            // 
            this.idHangHoaDataGridViewTextBoxColumn.DataPropertyName = "IdHangHoa";
            this.idHangHoaDataGridViewTextBoxColumn.HeaderText = "IdHangHoa";
            this.idHangHoaDataGridViewTextBoxColumn.Name = "idHangHoaDataGridViewTextBoxColumn";
            this.idHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHangHoaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTableReportCTHangHoaBindingSource
            // 
            this.dataTableReportCTHangHoaBindingSource.DataMember = "DataTableReportCTHangHoa";
            this.dataTableReportCTHangHoaBindingSource.DataSource = this.dataSetReport;
            // 
            // dataSetReport
            // 
            this.dataSetReport.DataSetName = "DataSetReport";
            this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerCTXuatHang
            // 
            reportDataSource1.Name = "DataSetCTHangHoa";
            reportDataSource1.Value = this.dataTableReportCTHangHoaBindingSource;
            this.reportViewerCTXuatHang.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCTXuatHang.LocalReport.ReportEmbeddedResource = "QLBH.ReportCTHangHoa.rdlc";
            this.reportViewerCTXuatHang.Location = new System.Drawing.Point(8, 9);
            this.reportViewerCTXuatHang.Name = "reportViewerCTXuatHang";
            this.reportViewerCTXuatHang.Size = new System.Drawing.Size(360, 28);
            this.reportViewerCTXuatHang.TabIndex = 2034;
            // 
            // btnInChiTietXuat
            // 
            this.btnInChiTietXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnInChiTietXuat.Location = new System.Drawing.Point(888, 96);
            this.btnInChiTietXuat.Name = "btnInChiTietXuat";
            this.btnInChiTietXuat.Size = new System.Drawing.Size(108, 33);
            this.btnInChiTietXuat.TabIndex = 2035;
            this.btnInChiTietXuat.Text = "In Chi Tiết";
            this.btnInChiTietXuat.UseVisualStyleBackColor = true;
            this.btnInChiTietXuat.Click += new System.EventHandler(this.btnInChiTietXuat_Click);
            // 
            // txtTienNhap
            // 
            this.txtTienNhap.BackColor = System.Drawing.Color.White;
            this.txtTienNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienNhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNhap.ForeColor = System.Drawing.Color.Red;
            this.txtTienNhap.Location = new System.Drawing.Point(470, 642);
            this.txtTienNhap.Name = "txtTienNhap";
            this.txtTienNhap.ReadOnly = true;
            this.txtTienNhap.Size = new System.Drawing.Size(216, 25);
            this.txtTienNhap.TabIndex = 2037;
            this.txtTienNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataTableReportCTHangHoaTableAdapter
            // 
            this.dataTableReportCTHangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // FormCTHHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtTienNhap);
            this.Controls.Add(label7);
            this.Controls.Add(this.btnInChiTietXuat);
            this.Controls.Add(this.reportViewerCTXuatHang);
            this.Controls.Add(this.ctxuathanghoaDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbGiaTriKho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSLKho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbKhoHang);
            this.Controls.Add(this.lbTenHang);
            this.Controls.Add(this.lbMaHang);
            this.Controls.Add(this.txtTienXuat);
            this.Controls.Add(label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lableB_NgayHT);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormCTHHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctxuathanghoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportCTHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
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
        private System.Windows.Forms.TextBox txtTienXuat;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbKhoHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSLKho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbGiaTriKho;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.DataGridView ctxuathanghoaDataGridView;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCTXuatHang;
        private System.Windows.Forms.Button btnInChiTietXuat;
        private System.Windows.Forms.TextBox txtTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienXuat;
        private System.Windows.Forms.BindingSource dataTableReportCTHangHoaBindingSource;
        private DataSetReportTableAdapters.DataTableReportCTHangHoaTableAdapter dataTableReportCTHangHoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonKhoDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHangHoaDataGridViewTextBoxColumn;
    }
}