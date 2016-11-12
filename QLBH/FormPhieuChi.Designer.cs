namespace QLBH
{
    partial class FormPhieuChi
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
            System.Windows.Forms.Label tenHangLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTableReportPhieuChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReport = new QLBH.DataSetReport();
            this.label1 = new System.Windows.Forms.Label();
            this.phieuchiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.gbxPhieuChi = new System.Windows.Forms.GroupBox();
            this.btnNhaCCMoi = new System.Windows.Forms.Button();
            this.phimtatDataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phimtatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhacungcapDataGridView = new System.Windows.Forms.DataGridView();
            this.TenNhaCC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhaiTra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnhacungcap1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacungcapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSoHieu = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtVBC = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.phieuchiTableAdapter = new QLBH.QLBHDataSetTableAdapters.phieuchiTableAdapter();
            this.nhacungcapTableAdapter = new QLBH.QLBHDataSetTableAdapters.nhacungcapTableAdapter();
            this.phimtatTableAdapter = new QLBH.QLBHDataSetTableAdapters.phimtatTableAdapter();
            this.reportViewerPhieuChi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableReportPhieuChiTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportPhieuChiTableAdapter();
            this.btnXemPhieu = new System.Windows.Forms.Button();
            tenHangLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableReportPhieuChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuchiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.gbxPhieuChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phimtatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimtatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenHangLabel
            // 
            tenHangLabel.AutoSize = true;
            tenHangLabel.Location = new System.Drawing.Point(21, 125);
            tenHangLabel.Name = "tenHangLabel";
            tenHangLabel.Size = new System.Drawing.Size(595, 19);
            tenHangLabel.TabIndex = 0;
            tenHangLabel.Text = "Tên Nhà Cung Cấp:  .............................................................." +
    "....................................................";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(419, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 19);
            label2.TabIndex = 2003;
            label2.Text = "Số Hiệu:  ................................";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 172);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(594, 19);
            label3.TabIndex = 2005;
            label3.Text = "Địa Chỉ:  ......................................................................." +
    ".............................................................";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 219);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(591, 19);
            label4.TabIndex = 2007;
            label4.Text = "Số Điện Thoại:  ................................................................." +
    "........................................................";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 266);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(592, 19);
            label5.TabIndex = 2009;
            label5.Text = "Lý Do Chi:  ....................................................................." +
    "..........................................................";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(21, 313);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(590, 19);
            label6.TabIndex = 2011;
            label6.Text = "Số Tiền:  ......................................................................." +
    "............................................................";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(21, 360);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(590, 19);
            label7.TabIndex = 2013;
            label7.Text = "Viết Bằng Chữ:  ................................................................." +
    ".......................................................";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(21, 407);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(590, 19);
            label8.TabIndex = 2015;
            label8.Text = "Ghi Chú:  ......................................................................." +
    "...........................................................";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(440, 444);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(76, 19);
            label9.TabIndex = 2017;
            label9.Text = "Người Lập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(396, 517);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(169, 19);
            label10.TabIndex = 2019;
            label10.Text = "........................................";
            // 
            // DataTableReportPhieuChiBindingSource
            // 
            this.DataTableReportPhieuChiBindingSource.DataMember = "DataTableReportPhieuChi";
            this.DataTableReportPhieuChiBindingSource.DataSource = this.DataSetReport;
            // 
            // DataSetReport
            // 
            this.DataSetReport.DataSetName = "DataSetReport";
            this.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU CHI";
            // 
            // phieuchiBindingSource
            // 
            this.phieuchiBindingSource.DataMember = "phieuchi";
            this.phieuchiBindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxPhieuChi
            // 
            this.gbxPhieuChi.BackColor = System.Drawing.Color.White;
            this.gbxPhieuChi.Controls.Add(this.btnNhaCCMoi);
            this.gbxPhieuChi.Controls.Add(this.phimtatDataGridView);
            this.gbxPhieuChi.Controls.Add(this.nhacungcapDataGridView);
            this.gbxPhieuChi.Controls.Add(this.txtSoHieu);
            this.gbxPhieuChi.Controls.Add(this.txtGhiChu);
            this.gbxPhieuChi.Controls.Add(this.txtVBC);
            this.gbxPhieuChi.Controls.Add(this.txtSoTien);
            this.gbxPhieuChi.Controls.Add(this.txtLyDo);
            this.gbxPhieuChi.Controls.Add(this.txtSDT);
            this.gbxPhieuChi.Controls.Add(this.txtDiaChi);
            this.gbxPhieuChi.Controls.Add(this.txtTenNhaCC);
            this.gbxPhieuChi.Controls.Add(this.txtUser);
            this.gbxPhieuChi.Controls.Add(label10);
            this.gbxPhieuChi.Controls.Add(label9);
            this.gbxPhieuChi.Controls.Add(label8);
            this.gbxPhieuChi.Controls.Add(label7);
            this.gbxPhieuChi.Controls.Add(label6);
            this.gbxPhieuChi.Controls.Add(label5);
            this.gbxPhieuChi.Controls.Add(label4);
            this.gbxPhieuChi.Controls.Add(label3);
            this.gbxPhieuChi.Controls.Add(label2);
            this.gbxPhieuChi.Controls.Add(this.lableB_NgayHT);
            this.gbxPhieuChi.Controls.Add(this.dtpNgayLap);
            this.gbxPhieuChi.Controls.Add(tenHangLabel);
            this.gbxPhieuChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPhieuChi.Location = new System.Drawing.Point(205, 55);
            this.gbxPhieuChi.Name = "gbxPhieuChi";
            this.gbxPhieuChi.Size = new System.Drawing.Size(636, 563);
            this.gbxPhieuChi.TabIndex = 3;
            this.gbxPhieuChi.TabStop = false;
            // 
            // btnNhaCCMoi
            // 
            this.btnNhaCCMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCCMoi.ForeColor = System.Drawing.Color.Blue;
            this.btnNhaCCMoi.Location = new System.Drawing.Point(464, 86);
            this.btnNhaCCMoi.Name = "btnNhaCCMoi";
            this.btnNhaCCMoi.Size = new System.Drawing.Size(146, 27);
            this.btnNhaCCMoi.TabIndex = 5242;
            this.btnNhaCCMoi.Text = "Tạo Nhà Cung Cấp";
            this.btnNhaCCMoi.UseVisualStyleBackColor = true;
            this.btnNhaCCMoi.Click += new System.EventHandler(this.btnNhaCCMoi_Click);
            // 
            // phimtatDataGridView
            // 
            this.phimtatDataGridView.AllowUserToAddRows = false;
            this.phimtatDataGridView.AllowUserToDeleteRows = false;
            this.phimtatDataGridView.AllowUserToOrderColumns = true;
            this.phimtatDataGridView.AutoGenerateColumns = false;
            this.phimtatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phimtatDataGridView.ColumnHeadersVisible = false;
            this.phimtatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.loaiDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.phimtatDataGridView.DataSource = this.phimtatBindingSource;
            this.phimtatDataGridView.Location = new System.Drawing.Point(58, 25);
            this.phimtatDataGridView.Name = "phimtatDataGridView";
            this.phimtatDataGridView.ReadOnly = true;
            this.phimtatDataGridView.RowHeadersVisible = false;
            this.phimtatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phimtatDataGridView.Size = new System.Drawing.Size(36, 23);
            this.phimtatDataGridView.TabIndex = 5232;
            this.phimtatDataGridView.Visible = false;
            this.phimtatDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phimtatDataGridView_CellClick);
            this.phimtatDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phimtatDataGridView_KeyDown);
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 300F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 300;
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "Loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loai";
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            this.loaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // phimtatBindingSource
            // 
            this.phimtatBindingSource.DataMember = "phimtat";
            this.phimtatBindingSource.DataSource = this.qLBHDataSet;
            // 
            // nhacungcapDataGridView
            // 
            this.nhacungcapDataGridView.AllowUserToAddRows = false;
            this.nhacungcapDataGridView.AllowUserToDeleteRows = false;
            this.nhacungcapDataGridView.AllowUserToOrderColumns = true;
            this.nhacungcapDataGridView.AutoGenerateColumns = false;
            this.nhacungcapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhacungcapDataGridView.ColumnHeadersVisible = false;
            this.nhacungcapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhaCC1,
            this.SoDienThoai1,
            this.DiaChi1,
            this.PhaiTra1,
            this.idnhacungcap1});
            this.nhacungcapDataGridView.DataSource = this.nhacungcapBindingSource;
            this.nhacungcapDataGridView.Location = new System.Drawing.Point(16, 25);
            this.nhacungcapDataGridView.Name = "nhacungcapDataGridView";
            this.nhacungcapDataGridView.ReadOnly = true;
            this.nhacungcapDataGridView.RowHeadersVisible = false;
            this.nhacungcapDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhacungcapDataGridView.Size = new System.Drawing.Size(36, 23);
            this.nhacungcapDataGridView.TabIndex = 5229;
            this.nhacungcapDataGridView.Visible = false;
            this.nhacungcapDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwNhaCC_CellClick);
            this.nhacungcapDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvNhaCC_KeyDown);
            // 
            // TenNhaCC1
            // 
            this.TenNhaCC1.DataPropertyName = "TenNhaCC";
            this.TenNhaCC1.FillWeight = 220F;
            this.TenNhaCC1.HeaderText = "TenNhaCC";
            this.TenNhaCC1.Name = "TenNhaCC1";
            this.TenNhaCC1.ReadOnly = true;
            this.TenNhaCC1.Width = 220;
            // 
            // SoDienThoai1
            // 
            this.SoDienThoai1.DataPropertyName = "SoDienThoai";
            this.SoDienThoai1.FillWeight = 120F;
            this.SoDienThoai1.HeaderText = "SoDienThoai";
            this.SoDienThoai1.Name = "SoDienThoai1";
            this.SoDienThoai1.ReadOnly = true;
            this.SoDienThoai1.Width = 120;
            // 
            // DiaChi1
            // 
            this.DiaChi1.DataPropertyName = "DiaChi";
            this.DiaChi1.HeaderText = "DiaChi";
            this.DiaChi1.Name = "DiaChi1";
            this.DiaChi1.ReadOnly = true;
            this.DiaChi1.Visible = false;
            // 
            // PhaiTra1
            // 
            this.PhaiTra1.DataPropertyName = "PhaiTra";
            this.PhaiTra1.HeaderText = "PhaiTra";
            this.PhaiTra1.Name = "PhaiTra1";
            this.PhaiTra1.ReadOnly = true;
            this.PhaiTra1.Visible = false;
            // 
            // idnhacungcap1
            // 
            this.idnhacungcap1.DataPropertyName = "idnhacungcap";
            this.idnhacungcap1.HeaderText = "idnhacungcap";
            this.idnhacungcap1.Name = "idnhacungcap1";
            this.idnhacungcap1.ReadOnly = true;
            this.idnhacungcap1.Visible = false;
            // 
            // nhacungcapBindingSource
            // 
            this.nhacungcapBindingSource.DataMember = "nhacungcap";
            this.nhacungcapBindingSource.DataSource = this.qLBHDataSet;
            // 
            // txtSoHieu
            // 
            this.txtSoHieu.BackColor = System.Drawing.Color.White;
            this.txtSoHieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoHieu.Location = new System.Drawing.Point(484, 64);
            this.txtSoHieu.Name = "txtSoHieu";
            this.txtSoHieu.ReadOnly = true;
            this.txtSoHieu.Size = new System.Drawing.Size(127, 19);
            this.txtSoHieu.TabIndex = 2004;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhiChu.Location = new System.Drawing.Point(87, 401);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(515, 19);
            this.txtGhiChu.TabIndex = 2016;
            this.txtGhiChu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGhiChu_KeyDown);
            // 
            // txtVBC
            // 
            this.txtVBC.BackColor = System.Drawing.Color.White;
            this.txtVBC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVBC.Location = new System.Drawing.Point(126, 354);
            this.txtVBC.Name = "txtVBC";
            this.txtVBC.ReadOnly = true;
            this.txtVBC.Size = new System.Drawing.Size(484, 19);
            this.txtVBC.TabIndex = 2014;
            // 
            // txtSoTien
            // 
            this.txtSoTien.BackColor = System.Drawing.Color.White;
            this.txtSoTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTien.Location = new System.Drawing.Point(105, 307);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(257, 19);
            this.txtSoTien.TabIndex = 2012;
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            this.txtSoTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTien_KeyDown);
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoNumber);
            this.txtSoTien.Leave += new System.EventHandler(this.txtSoTien_Leave);
            // 
            // txtLyDo
            // 
            this.txtLyDo.BackColor = System.Drawing.Color.White;
            this.txtLyDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLyDo.Location = new System.Drawing.Point(103, 260);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(507, 19);
            this.txtLyDo.TabIndex = 2010;
            this.txtLyDo.TextChanged += new System.EventHandler(this.txtLyDo_TextChanged);
            this.txtLyDo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLyDo_KeyDown);
            this.txtLyDo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLyDo_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Location = new System.Drawing.Point(123, 213);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(487, 19);
            this.txtSDT.TabIndex = 2008;
            this.txtSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSDT_KeyDown);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoNumberSDT);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Location = new System.Drawing.Point(85, 166);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(525, 19);
            this.txtDiaChi.TabIndex = 2006;
            this.txtDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi_KeyDown);
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.BackColor = System.Drawing.Color.White;
            this.txtTenNhaCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNhaCC.Location = new System.Drawing.Point(158, 119);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(452, 19);
            this.txtTenNhaCC.TabIndex = 1;
            this.txtTenNhaCC.TextChanged += new System.EventHandler(this.txtTenNhaCC_TextChanged);
            this.txtTenNhaCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNhaCC_KeyDown);
            this.txtTenNhaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNhaCC_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(398, 511);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 19);
            this.txtUser.TabIndex = 2018;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lableB_NgayHT
            // 
            this.lableB_NgayHT.BackColor = System.Drawing.Color.White;
            this.lableB_NgayHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lableB_NgayHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableB_NgayHT.ForeColor = System.Drawing.Color.Indigo;
            this.lableB_NgayHT.Location = new System.Drawing.Point(202, 25);
            this.lableB_NgayHT.Name = "lableB_NgayHT";
            this.lableB_NgayHT.ReadOnly = true;
            this.lableB_NgayHT.Size = new System.Drawing.Size(197, 19);
            this.lableB_NgayHT.TabIndex = 2001;
            this.lableB_NgayHT.TabStop = false;
            this.lableB_NgayHT.Text = "Ngày ... tháng ... năm ......";
            this.lableB_NgayHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(407, 22);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(18, 26);
            this.dtpNgayLap.TabIndex = 2002;
            this.dtpNgayLap.ValueChanged += new System.EventHandler(this.DateTimePickerB_NgayLap_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(305, 624);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 46);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm Phiếu Mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(742, 624);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 46);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(646, 624);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 46);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            // phieuchiTableAdapter
            // 
            this.phieuchiTableAdapter.ClearBeforeFill = true;
            // 
            // nhacungcapTableAdapter
            // 
            this.nhacungcapTableAdapter.ClearBeforeFill = true;
            // 
            // phimtatTableAdapter
            // 
            this.phimtatTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerPhieuChi
            // 
            reportDataSource1.Name = "DataSetPhieuChi";
            reportDataSource1.Value = this.DataTableReportPhieuChiBindingSource;
            this.reportViewerPhieuChi.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPhieuChi.LocalReport.ReportEmbeddedResource = "QLBH.ReportPhieuChi.rdlc";
            this.reportViewerPhieuChi.Location = new System.Drawing.Point(12, 9);
            this.reportViewerPhieuChi.Name = "reportViewerPhieuChi";
            this.reportViewerPhieuChi.Size = new System.Drawing.Size(358, 30);
            this.reportViewerPhieuChi.TabIndex = 22;
            // 
            // DataTableReportPhieuChiTableAdapter
            // 
            this.DataTableReportPhieuChiTableAdapter.ClearBeforeFill = true;
            // 
            // btnXemPhieu
            // 
            this.btnXemPhieu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXemPhieu.Location = new System.Drawing.Point(209, 624);
            this.btnXemPhieu.Name = "btnXemPhieu";
            this.btnXemPhieu.Size = new System.Drawing.Size(90, 46);
            this.btnXemPhieu.TabIndex = 23;
            this.btnXemPhieu.Text = "Xem Phiếu";
            this.btnXemPhieu.UseVisualStyleBackColor = true;
            this.btnXemPhieu.Click += new System.EventHandler(this.btnXemPhieu_Click);
            // 
            // FormPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.btnXemPhieu);
            this.Controls.Add(this.reportViewerPhieuChi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbxPhieuChi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhieuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableReportPhieuChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuchiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.gbxPhieuChi.ResumeLayout(false);
            this.gbxPhieuChi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phimtatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimtatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbxPhieuChi;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.BindingSource phieuchiBindingSource;
        private QLBHDataSetTableAdapters.phieuchiTableAdapter phieuchiTableAdapter;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtVBC;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoHieu;
        private System.Windows.Forms.TextBox lableB_NgayHT;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.BindingSource nhacungcapBindingSource;
        private QLBHDataSetTableAdapters.nhacungcapTableAdapter nhacungcapTableAdapter;
        private System.Windows.Forms.DataGridView nhacungcapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhaiTra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnhacungcap1;
        private System.Windows.Forms.DataGridView phimtatDataGridView;
        private System.Windows.Forms.BindingSource phimtatBindingSource;
        private QLBHDataSetTableAdapters.phimtatTableAdapter phimtatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPhieuChi;
        private System.Windows.Forms.BindingSource DataTableReportPhieuChiBindingSource;
        private DataSetReport DataSetReport;
        private DataSetReportTableAdapters.DataTableReportPhieuChiTableAdapter DataTableReportPhieuChiTableAdapter;
        private System.Windows.Forms.Button btnNhaCCMoi;
        private System.Windows.Forms.Button btnXemPhieu;
    }
}