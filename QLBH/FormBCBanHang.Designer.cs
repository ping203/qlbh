namespace QLBH
{
    partial class FormBCBanHang
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label6;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTableReportBCBanHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new QLBH.DataSetReport();
            this.label1 = new System.Windows.Forms.Label();
            this.bcbanhangDataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearchNhomHang = new System.Windows.Forms.TextBox();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.reportViewerTonKho = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtSearchTenHang = new System.Windows.Forms.TextBox();
            this.dgvNhomHangSearch = new System.Windows.Forms.DataGridView();
            this.tenNhomHangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienGiaiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhomHangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.dgvTenHangSearch = new System.Windows.Forms.DataGridView();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dienGiaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.nhomhangTableAdapter = new QLBH.QLBHDataSetTableAdapters.nhomhangTableAdapter();
            this.hanghoaTableAdapter = new QLBH.QLBHDataSetTableAdapters.hanghoaTableAdapter();
            this.dataTableReportBCBanHangTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportBCBanHangTableAdapter();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.ngayXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhomHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphieuxuathangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHangHoaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhomHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphieuxuathangctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportBCBanHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcbanhangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHangSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenHangSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(13, 61);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 16);
            label4.TabIndex = 30;
            label4.Text = "Nhóm Hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(256, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 16);
            label2.TabIndex = 2010;
            label2.Text = "Tên Hàng:";
            // 
            // dataTableReportBCBanHangBindingSource
            // 
            this.dataTableReportBCBanHangBindingSource.DataMember = "DataTableReportBCBanHang";
            this.dataTableReportBCBanHangBindingSource.DataSource = this.dataSetReport;
            // 
            // dataSetReport
            // 
            this.dataSetReport.DataSetName = "DataSetReport";
            this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(698, 656);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(302, 16);
            label6.TabIndex = 2019;
            label6.Text = "Tổng Tiền:  ........................................................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO BÁN HÀNG";
            // 
            // bcbanhangDataGridView
            // 
            this.bcbanhangDataGridView.AllowUserToAddRows = false;
            this.bcbanhangDataGridView.AllowUserToDeleteRows = false;
            this.bcbanhangDataGridView.AutoGenerateColumns = false;
            this.bcbanhangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bcbanhangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcbanhangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayXuatDataGridViewTextBoxColumn,
            this.soHieuDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn1,
            this.tenNhomHangDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.khoHangDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.ThanhTien,
            this.idphieuxuathangDataGridViewTextBoxColumn,
            this.idHangHoaDataGridViewTextBoxColumn1,
            this.maHangDataGridViewTextBoxColumn1,
            this.idNhomHangDataGridViewTextBoxColumn,
            this.idphieuxuathangctDataGridViewTextBoxColumn});
            this.bcbanhangDataGridView.DataSource = this.dataTableReportBCBanHangBindingSource;
            this.bcbanhangDataGridView.Location = new System.Drawing.Point(4, 91);
            this.bcbanhangDataGridView.Name = "bcbanhangDataGridView";
            this.bcbanhangDataGridView.ReadOnly = true;
            this.bcbanhangDataGridView.RowHeadersVisible = false;
            this.bcbanhangDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bcbanhangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bcbanhangDataGridView.Size = new System.Drawing.Size(996, 545);
            this.bcbanhangDataGridView.TabIndex = 2;
            // 
            // txtSearchNhomHang
            // 
            this.txtSearchNhomHang.Location = new System.Drawing.Point(92, 58);
            this.txtSearchNhomHang.Name = "txtSearchNhomHang";
            this.txtSearchNhomHang.Size = new System.Drawing.Size(150, 23);
            this.txtSearchNhomHang.TabIndex = 25;
            this.txtSearchNhomHang.TextChanged += new System.EventHandler(this.txtSearchNhomHang_TextChanged);
            this.txtSearchNhomHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchNhomHang_KeyDown);
            this.txtSearchNhomHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchNhomHang_KeyPress);
            // 
            // lableB_NgayHT
            // 
            this.lableB_NgayHT.BackColor = System.Drawing.Color.White;
            this.lableB_NgayHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lableB_NgayHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableB_NgayHT.ForeColor = System.Drawing.Color.Indigo;
            this.lableB_NgayHT.Location = new System.Drawing.Point(592, 61);
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
            this.dtpTuNgay.Location = new System.Drawing.Point(630, 58);
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
            this.textBox1.Location = new System.Drawing.Point(758, 61);
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
            this.dtpDenNgay.Location = new System.Drawing.Point(801, 58);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(95, 23);
            this.dtpDenNgay.TabIndex = 2006;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.ForeColor = System.Drawing.Color.Blue;
            this.btnInBaoCao.Location = new System.Drawing.Point(912, 52);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(86, 33);
            this.btnInBaoCao.TabIndex = 2007;
            this.btnInBaoCao.Text = "In Báo Cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInTonKho_Click);
            // 
            // reportViewerTonKho
            // 
            reportDataSource1.Name = "DataSetBCBanHang";
            reportDataSource1.Value = this.dataTableReportBCBanHangBindingSource;
            this.reportViewerTonKho.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerTonKho.LocalReport.ReportEmbeddedResource = "QLBH.ReportBCBanHang.rdlc";
            this.reportViewerTonKho.Location = new System.Drawing.Point(12, 9);
            this.reportViewerTonKho.Name = "reportViewerTonKho";
            this.reportViewerTonKho.Size = new System.Drawing.Size(357, 30);
            this.reportViewerTonKho.TabIndex = 2008;
            // 
            // txtSearchTenHang
            // 
            this.txtSearchTenHang.Location = new System.Drawing.Point(322, 58);
            this.txtSearchTenHang.Name = "txtSearchTenHang";
            this.txtSearchTenHang.Size = new System.Drawing.Size(253, 23);
            this.txtSearchTenHang.TabIndex = 2009;
            this.txtSearchTenHang.TextChanged += new System.EventHandler(this.txtSearchTenHang_TextChanged);
            this.txtSearchTenHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchTenHang_KeyDown);
            this.txtSearchTenHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchTenHang_KeyPress);
            // 
            // dgvNhomHangSearch
            // 
            this.dgvNhomHangSearch.AllowUserToAddRows = false;
            this.dgvNhomHangSearch.AllowUserToDeleteRows = false;
            this.dgvNhomHangSearch.AutoGenerateColumns = false;
            this.dgvNhomHangSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHangSearch.ColumnHeadersVisible = false;
            this.dgvNhomHangSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomHangDataGridViewTextBoxColumn1,
            this.dienGiaiDataGridViewTextBoxColumn1,
            this.idNhomHangDataGridViewTextBoxColumn1});
            this.dgvNhomHangSearch.DataSource = this.nhomhangBindingSource;
            this.dgvNhomHangSearch.Location = new System.Drawing.Point(731, 9);
            this.dgvNhomHangSearch.Name = "dgvNhomHangSearch";
            this.dgvNhomHangSearch.ReadOnly = true;
            this.dgvNhomHangSearch.RowHeadersVisible = false;
            this.dgvNhomHangSearch.Size = new System.Drawing.Size(40, 23);
            this.dgvNhomHangSearch.TabIndex = 2011;
            this.dgvNhomHangSearch.Visible = false;
            this.dgvNhomHangSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomHangSearch_CellClick);
            this.dgvNhomHangSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvNhomHangSearch_KeyDown);
            // 
            // tenNhomHangDataGridViewTextBoxColumn1
            // 
            this.tenNhomHangDataGridViewTextBoxColumn1.DataPropertyName = "TenNhomHang";
            this.tenNhomHangDataGridViewTextBoxColumn1.HeaderText = "TenNhomHang";
            this.tenNhomHangDataGridViewTextBoxColumn1.Name = "tenNhomHangDataGridViewTextBoxColumn1";
            this.tenNhomHangDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dienGiaiDataGridViewTextBoxColumn1
            // 
            this.dienGiaiDataGridViewTextBoxColumn1.DataPropertyName = "DienGiai";
            this.dienGiaiDataGridViewTextBoxColumn1.HeaderText = "DienGiai";
            this.dienGiaiDataGridViewTextBoxColumn1.Name = "dienGiaiDataGridViewTextBoxColumn1";
            this.dienGiaiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dienGiaiDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idNhomHangDataGridViewTextBoxColumn1
            // 
            this.idNhomHangDataGridViewTextBoxColumn1.DataPropertyName = "idNhomHang";
            this.idNhomHangDataGridViewTextBoxColumn1.HeaderText = "idNhomHang";
            this.idNhomHangDataGridViewTextBoxColumn1.Name = "idNhomHangDataGridViewTextBoxColumn1";
            this.idNhomHangDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idNhomHangDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nhomhangBindingSource
            // 
            this.nhomhangBindingSource.DataMember = "nhomhang";
            this.nhomhangBindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvTenHangSearch
            // 
            this.dgvTenHangSearch.AllowUserToAddRows = false;
            this.dgvTenHangSearch.AllowUserToDeleteRows = false;
            this.dgvTenHangSearch.AutoGenerateColumns = false;
            this.dgvTenHangSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenHangSearch.ColumnHeadersVisible = false;
            this.dgvTenHangSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenHangDataGridViewTextBoxColumn,
            this.maHangDataGridViewTextBoxColumn,
            this.idHangHoaDataGridViewTextBoxColumn});
            this.dgvTenHangSearch.DataSource = this.hanghoaBindingSource;
            this.dgvTenHangSearch.Location = new System.Drawing.Point(777, 9);
            this.dgvTenHangSearch.Name = "dgvTenHangSearch";
            this.dgvTenHangSearch.ReadOnly = true;
            this.dgvTenHangSearch.RowHeadersVisible = false;
            this.dgvTenHangSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTenHangSearch.Size = new System.Drawing.Size(40, 23);
            this.dgvTenHangSearch.TabIndex = 2012;
            this.dgvTenHangSearch.Visible = false;
            this.dgvTenHangSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTenHangSearch_CellClick);
            this.dgvTenHangSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTenHangSearch_KeyDown);
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            this.tenHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            this.maHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idHangHoaDataGridViewTextBoxColumn
            // 
            this.idHangHoaDataGridViewTextBoxColumn.DataPropertyName = "idHangHoa";
            this.idHangHoaDataGridViewTextBoxColumn.HeaderText = "idHangHoa";
            this.idHangHoaDataGridViewTextBoxColumn.Name = "idHangHoaDataGridViewTextBoxColumn";
            this.idHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHangHoaDataGridViewTextBoxColumn.Visible = false;
            // 
            // hanghoaBindingSource
            // 
            this.hanghoaBindingSource.DataMember = "hanghoa";
            this.hanghoaBindingSource.DataSource = this.qLBHDataSet;
            // 
            // dienGiaiDataGridViewTextBoxColumn
            // 
            this.dienGiaiDataGridViewTextBoxColumn.DataPropertyName = "DienGiai";
            this.dienGiaiDataGridViewTextBoxColumn.HeaderText = "DienGiai";
            this.dienGiaiDataGridViewTextBoxColumn.Name = "dienGiaiDataGridViewTextBoxColumn";
            this.dienGiaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dienGiaiDataGridViewTextBoxColumn.Visible = false;
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
            // nhomhangTableAdapter
            // 
            this.nhomhangTableAdapter.ClearBeforeFill = true;
            // 
            // hanghoaTableAdapter
            // 
            this.hanghoaTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableReportBCBanHangTableAdapter
            // 
            this.dataTableReportBCBanHangTableAdapter.ClearBeforeFill = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(777, 642);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(216, 25);
            this.txtTongTien.TabIndex = 2020;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ngayXuatDataGridViewTextBoxColumn
            // 
            this.ngayXuatDataGridViewTextBoxColumn.DataPropertyName = "NgayXuat";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayXuatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayXuatDataGridViewTextBoxColumn.FillWeight = 75F;
            this.ngayXuatDataGridViewTextBoxColumn.HeaderText = "Ngày Xuất";
            this.ngayXuatDataGridViewTextBoxColumn.Name = "ngayXuatDataGridViewTextBoxColumn";
            this.ngayXuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soHieuDataGridViewTextBoxColumn
            // 
            this.soHieuDataGridViewTextBoxColumn.DataPropertyName = "SoHieu";
            this.soHieuDataGridViewTextBoxColumn.FillWeight = 75F;
            this.soHieuDataGridViewTextBoxColumn.HeaderText = "Số Hiệu";
            this.soHieuDataGridViewTextBoxColumn.Name = "soHieuDataGridViewTextBoxColumn";
            this.soHieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHangDataGridViewTextBoxColumn1
            // 
            this.tenHangDataGridViewTextBoxColumn1.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn1.FillWeight = 210F;
            this.tenHangDataGridViewTextBoxColumn1.HeaderText = "Tên Hàng";
            this.tenHangDataGridViewTextBoxColumn1.Name = "tenHangDataGridViewTextBoxColumn1";
            this.tenHangDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenNhomHangDataGridViewTextBoxColumn
            // 
            this.tenNhomHangDataGridViewTextBoxColumn.DataPropertyName = "TenNhomHang";
            this.tenNhomHangDataGridViewTextBoxColumn.HeaderText = "Nhóm Hàng";
            this.tenNhomHangDataGridViewTextBoxColumn.Name = "tenNhomHangDataGridViewTextBoxColumn";
            this.tenNhomHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            dataGridViewCellStyle2.NullValue = "0";
            this.soLuongDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.soLuongDataGridViewTextBoxColumn.FillWeight = 80F;
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // khoHangDataGridViewTextBoxColumn
            // 
            this.khoHangDataGridViewTextBoxColumn.DataPropertyName = "KhoHang";
            this.khoHangDataGridViewTextBoxColumn.FillWeight = 80F;
            this.khoHangDataGridViewTextBoxColumn.HeaderText = "Kho Hàng";
            this.khoHangDataGridViewTextBoxColumn.Name = "khoHangDataGridViewTextBoxColumn";
            this.khoHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "Người Xuất";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "###,###,###,##0";
            dataGridViewCellStyle3.NullValue = "0";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThanhTien.FillWeight = 80F;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // idphieuxuathangDataGridViewTextBoxColumn
            // 
            this.idphieuxuathangDataGridViewTextBoxColumn.DataPropertyName = "idphieuxuathang";
            this.idphieuxuathangDataGridViewTextBoxColumn.HeaderText = "idphieuxuathang";
            this.idphieuxuathangDataGridViewTextBoxColumn.Name = "idphieuxuathangDataGridViewTextBoxColumn";
            this.idphieuxuathangDataGridViewTextBoxColumn.ReadOnly = true;
            this.idphieuxuathangDataGridViewTextBoxColumn.Visible = false;
            // 
            // idHangHoaDataGridViewTextBoxColumn1
            // 
            this.idHangHoaDataGridViewTextBoxColumn1.DataPropertyName = "IdHangHoa";
            this.idHangHoaDataGridViewTextBoxColumn1.HeaderText = "IdHangHoa";
            this.idHangHoaDataGridViewTextBoxColumn1.Name = "idHangHoaDataGridViewTextBoxColumn1";
            this.idHangHoaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idHangHoaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // maHangDataGridViewTextBoxColumn1
            // 
            this.maHangDataGridViewTextBoxColumn1.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn1.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn1.Name = "maHangDataGridViewTextBoxColumn1";
            this.maHangDataGridViewTextBoxColumn1.ReadOnly = true;
            this.maHangDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idNhomHangDataGridViewTextBoxColumn
            // 
            this.idNhomHangDataGridViewTextBoxColumn.DataPropertyName = "IdNhomHang";
            this.idNhomHangDataGridViewTextBoxColumn.HeaderText = "IdNhomHang";
            this.idNhomHangDataGridViewTextBoxColumn.Name = "idNhomHangDataGridViewTextBoxColumn";
            this.idNhomHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNhomHangDataGridViewTextBoxColumn.Visible = false;
            // 
            // idphieuxuathangctDataGridViewTextBoxColumn
            // 
            this.idphieuxuathangctDataGridViewTextBoxColumn.DataPropertyName = "idphieuxuathangct";
            this.idphieuxuathangctDataGridViewTextBoxColumn.HeaderText = "idphieuxuathangct";
            this.idphieuxuathangctDataGridViewTextBoxColumn.Name = "idphieuxuathangctDataGridViewTextBoxColumn";
            this.idphieuxuathangctDataGridViewTextBoxColumn.ReadOnly = true;
            this.idphieuxuathangctDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormBCBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(label6);
            this.Controls.Add(this.reportViewerTonKho);
            this.Controls.Add(this.dgvTenHangSearch);
            this.Controls.Add(this.dgvNhomHangSearch);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtSearchTenHang);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lableB_NgayHT);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtSearchNhomHang);
            this.Controls.Add(this.bcbanhangDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormBCBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportBCBanHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcbanhangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHangSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenHangSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bcbanhangDataGridView;
        private System.Windows.Forms.TextBox txtSearchNhomHang;
        private System.Windows.Forms.TextBox lableB_NgayHT;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.Button btnInBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTonKho;
        private System.Windows.Forms.TextBox txtSearchTenHang;
        private System.Windows.Forms.DataGridView dgvNhomHangSearch;
        private System.Windows.Forms.BindingSource nhomhangBindingSource;
        private QLBHDataSetTableAdapters.nhomhangTableAdapter nhomhangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienGiaiDataGridViewTextBoxColumn;
        private QLBHDataSetTableAdapters.hanghoaTableAdapter hanghoaTableAdapter;
        private System.Windows.Forms.BindingSource hanghoaBindingSource;
        private System.Windows.Forms.DataGridView dgvTenHangSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomHangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienGiaiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNhomHangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource dataTableReportBCBanHangBindingSource;
        private DataSetReportTableAdapters.DataTableReportBCBanHangTableAdapter dataTableReportBCBanHangTableAdapter;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuxuathangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHangHoaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNhomHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuxuathangctDataGridViewTextBoxColumn;
    }
}