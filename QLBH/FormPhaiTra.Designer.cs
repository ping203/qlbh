namespace QLBH
{
    partial class FormPhaiTra
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableReportNoPhaiTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new QLBH.DataSetReport();
            this.label1 = new System.Windows.Forms.Label();
            this.nophaitraDataGridView = new System.Windows.Forms.DataGridView();
            this.idnhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSoThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchNhaCC = new System.Windows.Forms.TextBox();
            this.lableB_NgayHT = new System.Windows.Forms.TextBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.btnInTonKho = new System.Windows.Forms.Button();
            this.reportViewerNoPhaiTra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableReportNoPhaiTraTableAdapter = new QLBH.DataSetReportTableAdapters.DataTableReportNoPhaiTraTableAdapter();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportNoPhaiTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nophaitraDataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(13, 61);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 16);
            label4.TabIndex = 30;
            label4.Text = "Tên Nhà Cung Cấp:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(701, 656);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(302, 16);
            label6.TabIndex = 2019;
            label6.Text = "Tổng Tiền:  ........................................................";
            // 
            // dataTableReportNoPhaiTraBindingSource
            // 
            this.dataTableReportNoPhaiTraBindingSource.DataMember = "DataTableReportNoPhaiTra";
            this.dataTableReportNoPhaiTraBindingSource.DataSource = this.dataSetReport;
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
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "NỢ PHẢI TRẢ";
            // 
            // nophaitraDataGridView
            // 
            this.nophaitraDataGridView.AllowUserToAddRows = false;
            this.nophaitraDataGridView.AllowUserToDeleteRows = false;
            this.nophaitraDataGridView.AutoGenerateColumns = false;
            this.nophaitraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nophaitraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nophaitraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnhacungcap,
            this.TenNhaCC,
            this.MaSoThue,
            this.DiaChi,
            this.SoDienThoai,
            this.dauKyDataGridViewTextBoxColumn,
            this.PhaiTra,
            this.ghiChuDataGridViewTextBoxColumn});
            this.nophaitraDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.nophaitraDataGridView.DataSource = this.dataTableReportNoPhaiTraBindingSource;
            this.nophaitraDataGridView.Location = new System.Drawing.Point(4, 91);
            this.nophaitraDataGridView.MultiSelect = false;
            this.nophaitraDataGridView.Name = "nophaitraDataGridView";
            this.nophaitraDataGridView.ReadOnly = true;
            this.nophaitraDataGridView.RowHeadersVisible = false;
            this.nophaitraDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nophaitraDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nophaitraDataGridView.Size = new System.Drawing.Size(996, 545);
            this.nophaitraDataGridView.TabIndex = 2;
            // 
            // idnhacungcap
            // 
            this.idnhacungcap.DataPropertyName = "idnhacungcap";
            this.idnhacungcap.HeaderText = "idnhacungcap";
            this.idnhacungcap.Name = "idnhacungcap";
            this.idnhacungcap.ReadOnly = true;
            this.idnhacungcap.Visible = false;
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.DataPropertyName = "TenNhaCC";
            this.TenNhaCC.FillWeight = 150F;
            this.TenNhaCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.ReadOnly = true;
            // 
            // MaSoThue
            // 
            this.MaSoThue.DataPropertyName = "MaSoThue";
            this.MaSoThue.FillWeight = 70F;
            this.MaSoThue.HeaderText = "Mã Số Thuế";
            this.MaSoThue.Name = "MaSoThue";
            this.MaSoThue.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 140F;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.FillWeight = 120F;
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // dauKyDataGridViewTextBoxColumn
            // 
            this.dauKyDataGridViewTextBoxColumn.DataPropertyName = "DauKy";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "###,###,###,##0";
            dataGridViewCellStyle1.NullValue = "0";
            this.dauKyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dauKyDataGridViewTextBoxColumn.FillWeight = 70F;
            this.dauKyDataGridViewTextBoxColumn.HeaderText = "Đầu Kỳ";
            this.dauKyDataGridViewTextBoxColumn.Name = "dauKyDataGridViewTextBoxColumn";
            this.dauKyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PhaiTra
            // 
            this.PhaiTra.DataPropertyName = "PhaiTra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            dataGridViewCellStyle2.NullValue = "0";
            this.PhaiTra.DefaultCellStyle = dataGridViewCellStyle2;
            this.PhaiTra.FillWeight = 70F;
            this.PhaiTra.HeaderText = "Cuối Kỳ";
            this.PhaiTra.Name = "PhaiTra";
            this.PhaiTra.ReadOnly = true;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.FillWeight = 60F;
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtBánHàngToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(173, 26);
            // 
            // chiTiếtBánHàngToolStripMenuItem
            // 
            this.chiTiếtBánHàngToolStripMenuItem.Name = "chiTiếtBánHàngToolStripMenuItem";
            this.chiTiếtBánHàngToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.chiTiếtBánHàngToolStripMenuItem.Text = "Chi tiết nhập hàng";
            this.chiTiếtBánHàngToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtBánHàngToolStripMenuItem_Click);
            // 
            // txtSearchNhaCC
            // 
            this.txtSearchNhaCC.Location = new System.Drawing.Point(135, 58);
            this.txtSearchNhaCC.Name = "txtSearchNhaCC";
            this.txtSearchNhaCC.Size = new System.Drawing.Size(237, 23);
            this.txtSearchNhaCC.TabIndex = 25;
            this.txtSearchNhaCC.TextChanged += new System.EventHandler(this.txtSearchHangHoa_TextChanged);
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
            this.btnInTonKho.Text = "In Nợ Phải Trả";
            this.btnInTonKho.UseVisualStyleBackColor = true;
            this.btnInTonKho.Click += new System.EventHandler(this.btnInNoPhaiThu_Click);
            // 
            // reportViewerNoPhaiTra
            // 
            reportDataSource1.Name = "DataSetNoPhaiTra";
            reportDataSource1.Value = this.dataTableReportNoPhaiTraBindingSource;
            this.reportViewerNoPhaiTra.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerNoPhaiTra.LocalReport.ReportEmbeddedResource = "QLBH.ReportNoPhaiTra.rdlc";
            this.reportViewerNoPhaiTra.Location = new System.Drawing.Point(12, 9);
            this.reportViewerNoPhaiTra.Name = "reportViewerNoPhaiTra";
            this.reportViewerNoPhaiTra.Size = new System.Drawing.Size(360, 28);
            this.reportViewerNoPhaiTra.TabIndex = 2008;
            // 
            // dataTableReportNoPhaiTraTableAdapter
            // 
            this.dataTableReportNoPhaiTraTableAdapter.ClearBeforeFill = true;
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
            this.txtTongTien.TabIndex = 2020;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormPhaiTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(label6);
            this.Controls.Add(this.reportViewerNoPhaiTra);
            this.Controls.Add(this.btnInTonKho);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lableB_NgayHT);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtSearchNhaCC);
            this.Controls.Add(this.nophaitraDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormPhaiTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReportNoPhaiTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nophaitraDataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nophaitraDataGridView;
        private System.Windows.Forms.TextBox txtSearchNhaCC;
        private System.Windows.Forms.TextBox lableB_NgayHT;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.Button btnInTonKho;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNoPhaiTra;
        private System.Windows.Forms.BindingSource dataTableReportNoPhaiTraBindingSource;
        private DataSetReportTableAdapters.DataTableReportNoPhaiTraTableAdapter dataTableReportNoPhaiTraTableAdapter;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtBánHàngToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhaiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}