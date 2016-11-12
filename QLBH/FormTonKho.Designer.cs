namespace QLBH
{
    partial class FormTonKho
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTableReportTonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new QLBH.DataSetReport();
            this.label1 = new System.Windows.Forms.Label();
            this.tonkhoDataGridView = new System.Windows.Forms.DataGridView();
            this.cbxSearchKhoHang = new System.Windows.Forms.ComboBox();
            this.txtSearchHangHoa = new System.Windows.Forms.TextBox();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.btnInTonKho = new System.Windows.Forms.Button();
            this.reportViewerTonKho = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableReportTonKhoTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportTonKhoTableAdapter();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếthànghoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportTonKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(13, 61);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 16);
            label4.TabIndex = 30;
            label4.Text = "Tên Hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(278, 61);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 16);
            label3.TabIndex = 28;
            label3.Text = "Kho Hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(631, 647);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(371, 16);
            label6.TabIndex = 2013;
            label6.Text = "Tổng Giá Trị Tồn Kho:  ........................................................";
            // 
            // dataTableReportTonKhoBindingSource
            // 
            this.dataTableReportTonKhoBindingSource.DataMember = "DataTableReportTonKho";
            this.dataTableReportTonKhoBindingSource.DataSource = this.dataSetReport;
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
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TỒN KHO";
            // 
            // tonkhoDataGridView
            // 
            this.tonkhoDataGridView.AllowUserToAddRows = false;
            this.tonkhoDataGridView.AllowUserToDeleteRows = false;
            this.tonkhoDataGridView.AutoGenerateColumns = false;
            this.tonkhoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tonkhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tonkhoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHangHoa,
            this.MaHang,
            this.TenHang,
            this.TonKho,
            this.GiaNhap,
            this.GTTonKho,
            this.KhoHang,
            this.GhiChu});
            this.tonkhoDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.tonkhoDataGridView.DataSource = this.dataTableReportTonKhoBindingSource;
            this.tonkhoDataGridView.Location = new System.Drawing.Point(4, 91);
            this.tonkhoDataGridView.MultiSelect = false;
            this.tonkhoDataGridView.Name = "tonkhoDataGridView";
            this.tonkhoDataGridView.ReadOnly = true;
            this.tonkhoDataGridView.RowHeadersVisible = false;
            this.tonkhoDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tonkhoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tonkhoDataGridView.Size = new System.Drawing.Size(996, 535);
            this.tonkhoDataGridView.TabIndex = 2;
            // 
            // cbxSearchKhoHang
            // 
            this.cbxSearchKhoHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSearchKhoHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSearchKhoHang.BackColor = System.Drawing.Color.White;
            this.cbxSearchKhoHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxSearchKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSearchKhoHang.FormattingEnabled = true;
            this.cbxSearchKhoHang.Items.AddRange(new object[] {
            "Tầm Vu",
            "NTH"});
            this.cbxSearchKhoHang.Location = new System.Drawing.Point(343, 58);
            this.cbxSearchKhoHang.Name = "cbxSearchKhoHang";
            this.cbxSearchKhoHang.Size = new System.Drawing.Size(153, 23);
            this.cbxSearchKhoHang.TabIndex = 29;
            this.cbxSearchKhoHang.SelectedIndexChanged += new System.EventHandler(this.cbxSearchKhoHang_SelectedIndexChanged);
            // 
            // txtSearchHangHoa
            // 
            this.txtSearchHangHoa.Location = new System.Drawing.Point(79, 58);
            this.txtSearchHangHoa.Name = "txtSearchHangHoa";
            this.txtSearchHangHoa.Size = new System.Drawing.Size(172, 23);
            this.txtSearchHangHoa.TabIndex = 25;
            this.txtSearchHangHoa.TextChanged += new System.EventHandler(this.txtSearchHangHoa_TextChanged);
            // 
            // lableB_NgayHT
            // 
            this.lableB_NgayHT.BackColor = System.Drawing.Color.White;
            this.lableB_NgayHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lableB_NgayHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableB_NgayHT.ForeColor = System.Drawing.Color.Indigo;
            this.lableB_NgayHT.Location = new System.Drawing.Point(546, 61);
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
            this.dtpTuNgay.Location = new System.Drawing.Point(584, 58);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(95, 23);
            this.dtpTuNgay.TabIndex = 2004;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Indigo;
            this.textBox1.Location = new System.Drawing.Point(712, 61);
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
            this.dtpDenNgay.Location = new System.Drawing.Point(755, 58);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(95, 23);
            this.dtpDenNgay.TabIndex = 2006;
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
            // btnInTonKho
            // 
            this.btnInTonKho.ForeColor = System.Drawing.Color.Blue;
            this.btnInTonKho.Location = new System.Drawing.Point(890, 52);
            this.btnInTonKho.Name = "btnInTonKho";
            this.btnInTonKho.Size = new System.Drawing.Size(108, 33);
            this.btnInTonKho.TabIndex = 2007;
            this.btnInTonKho.Text = "In Tồn Kho";
            this.btnInTonKho.UseVisualStyleBackColor = true;
            this.btnInTonKho.Click += new System.EventHandler(this.btnInTonKho_Click);
            // 
            // reportViewerTonKho
            // 
            reportDataSource1.Name = "DataSetTonKho";
            reportDataSource1.Value = this.dataTableReportTonKhoBindingSource;
            this.reportViewerTonKho.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerTonKho.LocalReport.ReportEmbeddedResource = "QLBH.ReportTonKho.rdlc";
            this.reportViewerTonKho.Location = new System.Drawing.Point(12, 9);
            this.reportViewerTonKho.Name = "reportViewerTonKho";
            this.reportViewerTonKho.Size = new System.Drawing.Size(360, 28);
            this.reportViewerTonKho.TabIndex = 2008;
            // 
            // dataTableReportTonKhoTableAdapter
            // 
            this.dataTableReportTonKhoTableAdapter.ClearBeforeFill = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(772, 633);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(216, 25);
            this.txtTongTien.TabIndex = 2014;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếthànghoaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(166, 26);
            // 
            // chiTiếthànghoaToolStripMenuItem
            // 
            this.chiTiếthànghoaToolStripMenuItem.Name = "chiTiếthànghoaToolStripMenuItem";
            this.chiTiếthànghoaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.chiTiếthànghoaToolStripMenuItem.Text = "Chi tiết hàng hóa";
            this.chiTiếthànghoaToolStripMenuItem.Click += new System.EventHandler(this.chiTiếthànghoaToolStripMenuItem_Click);
            // 
            // idHangHoa
            // 
            this.idHangHoa.DataPropertyName = "idHangHoa";
            this.idHangHoa.HeaderText = "idHangHoa";
            this.idHangHoa.Name = "idHangHoa";
            this.idHangHoa.ReadOnly = true;
            this.idHangHoa.Visible = false;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.FillWeight = 80F;
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.FillWeight = 200F;
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // TonKho
            // 
            this.TonKho.DataPropertyName = "TonKho";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "###,###,###,##0";
            dataGridViewCellStyle1.NullValue = "0";
            this.TonKho.DefaultCellStyle = dataGridViewCellStyle1;
            this.TonKho.FillWeight = 60F;
            this.TonKho.HeaderText = "Số Lượng";
            this.TonKho.Name = "TonKho";
            this.TonKho.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            dataGridViewCellStyle2.NullValue = "0";
            this.GiaNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GTTonKho
            // 
            this.GTTonKho.DataPropertyName = "GTTonKho";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "###,###,###,##0";
            dataGridViewCellStyle3.NullValue = "0";
            this.GTTonKho.DefaultCellStyle = dataGridViewCellStyle3;
            this.GTTonKho.HeaderText = "Giá Trị Tồn Kho";
            this.GTTonKho.Name = "GTTonKho";
            this.GTTonKho.ReadOnly = true;
            // 
            // KhoHang
            // 
            this.KhoHang.DataPropertyName = "KhoHang";
            this.KhoHang.FillWeight = 70F;
            this.KhoHang.HeaderText = "Kho Hàng";
            this.KhoHang.Name = "KhoHang";
            this.KhoHang.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.FillWeight = 70F;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // FormTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(label6);
            this.Controls.Add(this.reportViewerTonKho);
            this.Controls.Add(this.btnInTonKho);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lableB_NgayHT);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(label4);
            this.Controls.Add(this.cbxSearchKhoHang);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtSearchHangHoa);
            this.Controls.Add(this.tonkhoDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportTonKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tonkhoDataGridView;
        private System.Windows.Forms.ComboBox cbxSearchKhoHang;
        private System.Windows.Forms.TextBox txtSearchHangHoa;
        private System.Windows.Forms.TextBox lableB_NgayHT;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.BindingSource dataTableReportTonKhoBindingSource;
        private DataSetReportTableAdapters.DataTableReportTonKhoTableAdapter dataTableReportTonKhoTableAdapter;
        private System.Windows.Forms.Button btnInTonKho;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTonKho;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem chiTiếthànghoaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}