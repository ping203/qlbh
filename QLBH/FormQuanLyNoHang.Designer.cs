namespace QLBH
{
    partial class FormQuanLyNoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nohangDataGridView = new System.Windows.Forms.DataGridView();
            this.nohangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnDaTra = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtSearchNoHang = new System.Windows.Forms.TextBox();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnDaTru = new System.Windows.Forms.Button();
            this.btnConNo = new System.Windows.Forms.Button();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.nohangTableAdapter = new QLBH.QLBHDataSetTableAdapters.nohangTableAdapter();
            this.phieuxuathangctBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuxuathangctTableAdapter = new QLBH.QLBHDataSetTableAdapters.phieuxuathangctTableAdapter();
            this.idphieuxuathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphieuxuathangct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nohangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nohangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangctBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NỢ HÀNG";
            // 
            // nohangDataGridView
            // 
            this.nohangDataGridView.AllowUserToAddRows = false;
            this.nohangDataGridView.AllowUserToDeleteRows = false;
            this.nohangDataGridView.AutoGenerateColumns = false;
            this.nohangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nohangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nohangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphieuxuathang,
            this.NgayXuat,
            this.SoHieu,
            this.IdKhachHang,
            this.TenKhachHang,
            this.SDTKhachHang,
            this.idphieuxuathangct,
            this.IdHangHoa,
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.SoLuongNo,
            this.No,
            this.Tra,
            this.Tru});
            this.nohangDataGridView.DataSource = this.nohangBindingSource;
            this.nohangDataGridView.Location = new System.Drawing.Point(5, 61);
            this.nohangDataGridView.Name = "nohangDataGridView";
            this.nohangDataGridView.ReadOnly = true;
            this.nohangDataGridView.RowHeadersVisible = false;
            this.nohangDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nohangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nohangDataGridView.Size = new System.Drawing.Size(997, 533);
            this.nohangDataGridView.TabIndex = 2;
            // 
            // nohangBindingSource
            // 
            this.nohangBindingSource.DataMember = "nohang";
            this.nohangBindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNo.Location = new System.Drawing.Point(283, 600);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(90, 46);
            this.btnNo.TabIndex = 14;
            this.btnNo.Text = "Nợ";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnDaTra
            // 
            this.btnDaTra.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDaTra.Location = new System.Drawing.Point(531, 600);
            this.btnDaTra.Name = "btnDaTra";
            this.btnDaTra.Size = new System.Drawing.Size(90, 46);
            this.btnDaTra.TabIndex = 15;
            this.btnDaTra.Text = "Đã Trả";
            this.btnDaTra.UseVisualStyleBackColor = true;
            this.btnDaTra.Click += new System.EventHandler(this.btnDaTra_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(779, 600);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 46);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtSearchNoHang
            // 
            this.txtSearchNoHang.Location = new System.Drawing.Point(12, 32);
            this.txtSearchNoHang.Name = "txtSearchNoHang";
            this.txtSearchNoHang.Size = new System.Drawing.Size(256, 23);
            this.txtSearchNoHang.TabIndex = 19;
            this.txtSearchNoHang.TextChanged += new System.EventHandler(this.txtSearchNoHang_TextChanged);
            // 
            // btnTatCa
            // 
            this.btnTatCa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTatCa.Location = new System.Drawing.Point(159, 600);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(90, 46);
            this.btnTatCa.TabIndex = 20;
            this.btnTatCa.Text = "Tất Cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnDaTru
            // 
            this.btnDaTru.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDaTru.Location = new System.Drawing.Point(655, 600);
            this.btnDaTru.Name = "btnDaTru";
            this.btnDaTru.Size = new System.Drawing.Size(90, 46);
            this.btnDaTru.TabIndex = 21;
            this.btnDaTru.Text = "Đã Trừ";
            this.btnDaTru.UseVisualStyleBackColor = true;
            this.btnDaTru.Click += new System.EventHandler(this.btnDaTru_Click);
            // 
            // btnConNo
            // 
            this.btnConNo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConNo.ForeColor = System.Drawing.Color.Blue;
            this.btnConNo.Location = new System.Drawing.Point(407, 600);
            this.btnConNo.Name = "btnConNo";
            this.btnConNo.Size = new System.Drawing.Size(90, 46);
            this.btnConNo.TabIndex = 22;
            this.btnConNo.Text = "Còn Nợ";
            this.btnConNo.UseVisualStyleBackColor = true;
            this.btnConNo.Click += new System.EventHandler(this.btnConNo_Click);
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
            // nohangTableAdapter
            // 
            this.nohangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuxuathangctBindingSource
            // 
            this.phieuxuathangctBindingSource.DataMember = "phieuxuathangct";
            this.phieuxuathangctBindingSource.DataSource = this.qLBHDataSet;
            // 
            // phieuxuathangctTableAdapter
            // 
            this.phieuxuathangctTableAdapter.ClearBeforeFill = true;
            // 
            // idphieuxuathang
            // 
            this.idphieuxuathang.DataPropertyName = "idphieuxuathang";
            this.idphieuxuathang.HeaderText = "idphieuxuathang";
            this.idphieuxuathang.Name = "idphieuxuathang";
            this.idphieuxuathang.ReadOnly = true;
            this.idphieuxuathang.Visible = false;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.FillWeight = 85F;
            this.NgayXuat.HeaderText = "Ngày Xuất";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            // 
            // SoHieu
            // 
            this.SoHieu.DataPropertyName = "SoHieu";
            this.SoHieu.FillWeight = 80F;
            this.SoHieu.HeaderText = "Số Hiệu";
            this.SoHieu.Name = "SoHieu";
            this.SoHieu.ReadOnly = true;
            // 
            // IdKhachHang
            // 
            this.IdKhachHang.DataPropertyName = "IdKhachHang";
            this.IdKhachHang.HeaderText = "IdKhachHang";
            this.IdKhachHang.Name = "IdKhachHang";
            this.IdKhachHang.ReadOnly = true;
            this.IdKhachHang.Visible = false;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.FillWeight = 220F;
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // SDTKhachHang
            // 
            this.SDTKhachHang.DataPropertyName = "SDTKhachHang";
            this.SDTKhachHang.FillWeight = 150F;
            this.SDTKhachHang.HeaderText = "Số Điện Thoại";
            this.SDTKhachHang.Name = "SDTKhachHang";
            this.SDTKhachHang.ReadOnly = true;
            this.SDTKhachHang.Visible = false;
            // 
            // idphieuxuathangct
            // 
            this.idphieuxuathangct.DataPropertyName = "idphieuxuathangct";
            this.idphieuxuathangct.HeaderText = "idphieuxuathangct";
            this.idphieuxuathangct.Name = "idphieuxuathangct";
            this.idphieuxuathangct.ReadOnly = true;
            this.idphieuxuathangct.Visible = false;
            // 
            // IdHangHoa
            // 
            this.IdHangHoa.DataPropertyName = "IdHangHoa";
            this.IdHangHoa.HeaderText = "IdHangHoa";
            this.IdHangHoa.Name = "IdHangHoa";
            this.IdHangHoa.ReadOnly = true;
            this.IdHangHoa.Visible = false;
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
            this.TenHang.FillWeight = 190F;
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "###,###,###,##0";
            dataGridViewCellStyle1.NullValue = "0";
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoLuong.FillWeight = 60F;
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // SoLuongNo
            // 
            this.SoLuongNo.DataPropertyName = "SoLuongNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            dataGridViewCellStyle2.NullValue = "0";
            this.SoLuongNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoLuongNo.FillWeight = 65F;
            this.SoLuongNo.HeaderText = "SL Nợ";
            this.SoLuongNo.Name = "SoLuongNo";
            this.SoLuongNo.ReadOnly = true;
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle3;
            this.No.FillWeight = 30F;
            this.No.HeaderText = "Nợ";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Tra
            // 
            this.Tra.DataPropertyName = "Tra";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tra.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tra.FillWeight = 30F;
            this.Tra.HeaderText = "Trả";
            this.Tra.Name = "Tra";
            this.Tra.ReadOnly = true;
            // 
            // Tru
            // 
            this.Tru.DataPropertyName = "Tru";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tru.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tru.FillWeight = 30F;
            this.Tru.HeaderText = "Trừ";
            this.Tru.Name = "Tru";
            this.Tru.ReadOnly = true;
            // 
            // FormQuanLyNoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.btnConNo);
            this.Controls.Add(this.btnDaTru);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.txtSearchNoHang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDaTra);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.nohangDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormQuanLyNoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nohangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nohangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangctBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nohangDataGridView;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnDaTra;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtSearchNoHang;
        private System.Windows.Forms.BindingSource nohangBindingSource;
        private QLBHDataSetTableAdapters.nohangTableAdapter nohangTableAdapter;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.BindingSource phieuxuathangctBindingSource;
        private QLBHDataSetTableAdapters.phieuxuathangctTableAdapter phieuxuathangctTableAdapter;
        private System.Windows.Forms.Button btnDaTru;
        private System.Windows.Forms.Button btnConNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuxuathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuxuathangct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tru;
    }
}