namespace QLBH
{
    partial class FormCTPhaiTra
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTableReportCTNoPhaiTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new QLBH.DataSetReport();
            this.label1 = new System.Windows.Forms.Label();
            this.ctnophaithuDataGridView = new System.Windows.Forms.DataGridView();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.btnInChiTiet = new System.Windows.Forms.Button();
            this.reportViewerCTNoPhaiTra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbTenNhaCC = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataTableReportCTNoPhaiTraTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportCTNoPhaiTraTableAdapter();
            this.idnhacungcapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaiTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphieunhaphangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphieunhaphangctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportCTNoPhaiTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnophaithuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.SuspendLayout();
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
            // dataTableReportCTNoPhaiTraBindingSource
            // 
            this.dataTableReportCTNoPhaiTraBindingSource.DataMember = "DataTableReportCTNoPhaiTra";
            this.dataTableReportCTNoPhaiTraBindingSource.DataSource = this.dataSetReport;
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
            this.label1.Size = new System.Drawing.Size(420, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT NHẬP HÀNG";
            // 
            // ctnophaithuDataGridView
            // 
            this.ctnophaithuDataGridView.AllowUserToAddRows = false;
            this.ctnophaithuDataGridView.AllowUserToDeleteRows = false;
            this.ctnophaithuDataGridView.AutoGenerateColumns = false;
            this.ctnophaithuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctnophaithuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctnophaithuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnhacungcapDataGridViewTextBoxColumn,
            this.tenNhaCCDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.dauKyDataGridViewTextBoxColumn,
            this.phaiTraDataGridViewTextBoxColumn,
            this.idphieunhaphangDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.soHieuDataGridViewTextBoxColumn,
            this.idphieunhaphangctDataGridViewTextBoxColumn,
            this.maHangDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.ThanhTien,
            this.tuNgayDataGridViewTextBoxColumn,
            this.denNgayDataGridViewTextBoxColumn});
            this.ctnophaithuDataGridView.DataSource = this.dataTableReportCTNoPhaiTraBindingSource;
            this.ctnophaithuDataGridView.Location = new System.Drawing.Point(4, 132);
            this.ctnophaithuDataGridView.Name = "ctnophaithuDataGridView";
            this.ctnophaithuDataGridView.ReadOnly = true;
            this.ctnophaithuDataGridView.RowHeadersVisible = false;
            this.ctnophaithuDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ctnophaithuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctnophaithuDataGridView.Size = new System.Drawing.Size(996, 504);
            this.ctnophaithuDataGridView.TabIndex = 2;
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
            // btnInChiTiet
            // 
            this.btnInChiTiet.ForeColor = System.Drawing.Color.Blue;
            this.btnInChiTiet.Location = new System.Drawing.Point(888, 93);
            this.btnInChiTiet.Name = "btnInChiTiet";
            this.btnInChiTiet.Size = new System.Drawing.Size(108, 33);
            this.btnInChiTiet.TabIndex = 2007;
            this.btnInChiTiet.Text = "In Chi Tiểt";
            this.btnInChiTiet.UseVisualStyleBackColor = true;
            this.btnInChiTiet.Click += new System.EventHandler(this.btnInNoPhaiThu_Click);
            // 
            // reportViewerCTNoPhaiTra
            // 
            reportDataSource1.Name = "DataSetCTPhaiTra";
            reportDataSource1.Value = this.dataTableReportCTNoPhaiTraBindingSource;
            this.reportViewerCTNoPhaiTra.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCTNoPhaiTra.LocalReport.ReportEmbeddedResource = "QLBH.ReportCTNoPhaiTra.rdlc";
            this.reportViewerCTNoPhaiTra.Location = new System.Drawing.Point(12, 9);
            this.reportViewerCTNoPhaiTra.Name = "reportViewerCTNoPhaiTra";
            this.reportViewerCTNoPhaiTra.Size = new System.Drawing.Size(360, 28);
            this.reportViewerCTNoPhaiTra.TabIndex = 2008;
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
            // lbTenNhaCC
            // 
            this.lbTenNhaCC.AutoSize = true;
            this.lbTenNhaCC.ForeColor = System.Drawing.Color.Blue;
            this.lbTenNhaCC.Location = new System.Drawing.Point(124, 59);
            this.lbTenNhaCC.Name = "lbTenNhaCC";
            this.lbTenNhaCC.Size = new System.Drawing.Size(20, 16);
            this.lbTenNhaCC.TabIndex = 2019;
            this.lbTenNhaCC.Text = "...";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.ForeColor = System.Drawing.Color.Blue;
            this.lbDiaChi.Location = new System.Drawing.Point(124, 82);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(20, 16);
            this.lbDiaChi.TabIndex = 2020;
            this.lbDiaChi.Text = "...";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.ForeColor = System.Drawing.Color.Blue;
            this.lbSDT.Location = new System.Drawing.Point(124, 105);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(20, 16);
            this.lbSDT.TabIndex = 2021;
            this.lbSDT.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2024;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(73, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2023;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 2022;
            this.label4.Text = "Tên Nhà Cung Cấp:";
            // 
            // dataTableReportCTNoPhaiTraTableAdapter
            // 
            this.dataTableReportCTNoPhaiTraTableAdapter.ClearBeforeFill = true;
            // 
            // idnhacungcapDataGridViewTextBoxColumn
            // 
            this.idnhacungcapDataGridViewTextBoxColumn.DataPropertyName = "idnhacungcap";
            this.idnhacungcapDataGridViewTextBoxColumn.HeaderText = "idnhacungcap";
            this.idnhacungcapDataGridViewTextBoxColumn.Name = "idnhacungcapDataGridViewTextBoxColumn";
            this.idnhacungcapDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnhacungcapDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenNhaCCDataGridViewTextBoxColumn
            // 
            this.tenNhaCCDataGridViewTextBoxColumn.DataPropertyName = "TenNhaCC";
            this.tenNhaCCDataGridViewTextBoxColumn.HeaderText = "TenNhaCC";
            this.tenNhaCCDataGridViewTextBoxColumn.Name = "tenNhaCCDataGridViewTextBoxColumn";
            this.tenNhaCCDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNhaCCDataGridViewTextBoxColumn.Visible = false;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Visible = false;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDienThoaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // dauKyDataGridViewTextBoxColumn
            // 
            this.dauKyDataGridViewTextBoxColumn.DataPropertyName = "DauKy";
            this.dauKyDataGridViewTextBoxColumn.HeaderText = "DauKy";
            this.dauKyDataGridViewTextBoxColumn.Name = "dauKyDataGridViewTextBoxColumn";
            this.dauKyDataGridViewTextBoxColumn.ReadOnly = true;
            this.dauKyDataGridViewTextBoxColumn.Visible = false;
            // 
            // phaiTraDataGridViewTextBoxColumn
            // 
            this.phaiTraDataGridViewTextBoxColumn.DataPropertyName = "PhaiTra";
            this.phaiTraDataGridViewTextBoxColumn.HeaderText = "PhaiTra";
            this.phaiTraDataGridViewTextBoxColumn.Name = "phaiTraDataGridViewTextBoxColumn";
            this.phaiTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.phaiTraDataGridViewTextBoxColumn.Visible = false;
            // 
            // idphieunhaphangDataGridViewTextBoxColumn
            // 
            this.idphieunhaphangDataGridViewTextBoxColumn.DataPropertyName = "idphieunhaphang";
            this.idphieunhaphangDataGridViewTextBoxColumn.HeaderText = "idphieunhaphang";
            this.idphieunhaphangDataGridViewTextBoxColumn.Name = "idphieunhaphangDataGridViewTextBoxColumn";
            this.idphieunhaphangDataGridViewTextBoxColumn.ReadOnly = true;
            this.idphieunhaphangDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayNhapDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayNhapDataGridViewTextBoxColumn.FillWeight = 70F;
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            this.ngayNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soHieuDataGridViewTextBoxColumn
            // 
            this.soHieuDataGridViewTextBoxColumn.DataPropertyName = "SoHieu";
            this.soHieuDataGridViewTextBoxColumn.FillWeight = 70F;
            this.soHieuDataGridViewTextBoxColumn.HeaderText = "Số Hiệu";
            this.soHieuDataGridViewTextBoxColumn.Name = "soHieuDataGridViewTextBoxColumn";
            this.soHieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idphieunhaphangctDataGridViewTextBoxColumn
            // 
            this.idphieunhaphangctDataGridViewTextBoxColumn.DataPropertyName = "idphieunhaphangct";
            this.idphieunhaphangctDataGridViewTextBoxColumn.HeaderText = "idphieunhaphangct";
            this.idphieunhaphangctDataGridViewTextBoxColumn.Name = "idphieunhaphangctDataGridViewTextBoxColumn";
            this.idphieunhaphangctDataGridViewTextBoxColumn.ReadOnly = true;
            this.idphieunhaphangctDataGridViewTextBoxColumn.Visible = false;
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.FillWeight = 70F;
            this.maHangDataGridViewTextBoxColumn.HeaderText = "Mã Hàng";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            this.maHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.FillWeight = 260F;
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "Tên Hàng";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            this.tenHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            dataGridViewCellStyle2.NullValue = "0";
            this.soLuongDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.soLuongDataGridViewTextBoxColumn.FillWeight = 70F;
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "###,###,###,##0";
            dataGridViewCellStyle3.NullValue = "0";
            this.donGiaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.donGiaDataGridViewTextBoxColumn.FillWeight = 70F;
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "###,###,###,##0";
            dataGridViewCellStyle4.NullValue = "0";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThanhTien.FillWeight = 70F;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // tuNgayDataGridViewTextBoxColumn
            // 
            this.tuNgayDataGridViewTextBoxColumn.DataPropertyName = "TuNgay";
            this.tuNgayDataGridViewTextBoxColumn.HeaderText = "TuNgay";
            this.tuNgayDataGridViewTextBoxColumn.Name = "tuNgayDataGridViewTextBoxColumn";
            this.tuNgayDataGridViewTextBoxColumn.ReadOnly = true;
            this.tuNgayDataGridViewTextBoxColumn.Visible = false;
            // 
            // denNgayDataGridViewTextBoxColumn
            // 
            this.denNgayDataGridViewTextBoxColumn.DataPropertyName = "DenNgay";
            this.denNgayDataGridViewTextBoxColumn.HeaderText = "DenNgay";
            this.denNgayDataGridViewTextBoxColumn.Name = "denNgayDataGridViewTextBoxColumn";
            this.denNgayDataGridViewTextBoxColumn.ReadOnly = true;
            this.denNgayDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormCTPhaiTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenNhaCC);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(label6);
            this.Controls.Add(this.reportViewerCTNoPhaiTra);
            this.Controls.Add(this.btnInChiTiet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lableB_NgayHT);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.ctnophaithuDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormCTPhaiTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportCTNoPhaiTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnophaithuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ctnophaithuDataGridView;
        private System.Windows.Forms.TextBox lableB_NgayHT;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.Button btnInChiTiet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCTNoPhaiTra;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbTenNhaCC;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource dataTableReportCTNoPhaiTraBindingSource;
        private DataSetReportTableAdapters.DataTableReportCTNoPhaiTraTableAdapter dataTableReportCTNoPhaiTraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnhacungcapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phaiTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieunhaphangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieunhaphangctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denNgayDataGridViewTextBoxColumn;
    }
}