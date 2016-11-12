namespace QLBH
{
    partial class FormKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.khachhangDataGridView = new System.Windows.Forms.DataGridView();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.gbxKhachHang = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDauKy = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSearchKhachHang = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.khachhangTableAdapter = new QLBH.QLBHDataSetTableAdapters.khachhangTableAdapter();
            this.phieuxuathangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuxuathangTableAdapter = new QLBH.QLBHDataSetTableAdapters.phieuxuathangTableAdapter();
            this.idkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DauKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhaiThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenHangLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.gbxKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenHangLabel
            // 
            tenHangLabel.AutoSize = true;
            tenHangLabel.Location = new System.Drawing.Point(44, 44);
            tenHangLabel.Name = "tenHangLabel";
            tenHangLabel.Size = new System.Drawing.Size(807, 19);
            tenHangLabel.TabIndex = 0;
            tenHangLabel.Text = "Tên Khách Hàng:  ................................................................" +
    "................................................................................" +
    "...........................";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(101, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(750, 19);
            label2.TabIndex = 2;
            label2.Text = "Địa Chỉ:  ......................................................................." +
    "................................................................................" +
    "....................";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(59, 122);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(419, 19);
            label3.TabIndex = 4;
            label3.Text = "Số Điện Thoại:  ................................................................." +
    ".............";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(487, 122);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(364, 19);
            label4.TabIndex = 6;
            label4.Text = "Đầu kỳ:  ........................................................................" +
    "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(97, 161);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(754, 19);
            label5.TabIndex = 8;
            label5.Text = "Ghi Chú:  ......................................................................." +
    "................................................................................" +
    "....................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // khachhangDataGridView
            // 
            this.khachhangDataGridView.AllowUserToAddRows = false;
            this.khachhangDataGridView.AllowUserToDeleteRows = false;
            this.khachhangDataGridView.AutoGenerateColumns = false;
            this.khachhangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachhangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachhangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkhachhang,
            this.TenKhachHang,
            this.DiaChi,
            this.SoDienThoai,
            this.DauKy,
            this.PhaiThu,
            this.GhiChu});
            this.khachhangDataGridView.DataSource = this.khachhangBindingSource;
            this.khachhangDataGridView.Location = new System.Drawing.Point(12, 61);
            this.khachhangDataGridView.Name = "khachhangDataGridView";
            this.khachhangDataGridView.ReadOnly = true;
            this.khachhangDataGridView.RowHeadersVisible = false;
            this.khachhangDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.khachhangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachhangDataGridView.Size = new System.Drawing.Size(988, 319);
            this.khachhangDataGridView.TabIndex = 2;
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "khachhang";
            this.khachhangBindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxKhachHang
            // 
            this.gbxKhachHang.BackColor = System.Drawing.Color.White;
            this.gbxKhachHang.Controls.Add(this.txtGhiChu);
            this.gbxKhachHang.Controls.Add(label5);
            this.gbxKhachHang.Controls.Add(this.txtDauKy);
            this.gbxKhachHang.Controls.Add(label4);
            this.gbxKhachHang.Controls.Add(this.txtSDT);
            this.gbxKhachHang.Controls.Add(label3);
            this.gbxKhachHang.Controls.Add(this.txtDiaChi);
            this.gbxKhachHang.Controls.Add(label2);
            this.gbxKhachHang.Controls.Add(this.txtTenKhachHang);
            this.gbxKhachHang.Controls.Add(tenHangLabel);
            this.gbxKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKhachHang.Location = new System.Drawing.Point(48, 392);
            this.gbxKhachHang.Name = "gbxKhachHang";
            this.gbxKhachHang.Size = new System.Drawing.Size(913, 214);
            this.gbxKhachHang.TabIndex = 3;
            this.gbxKhachHang.TabStop = false;
            this.gbxKhachHang.Text = "Thông tin khách hàng:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhiChu.Location = new System.Drawing.Point(165, 155);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(677, 19);
            this.txtGhiChu.TabIndex = 9;
            this.txtGhiChu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGhiChu_KeyDown);
            // 
            // txtDauKy
            // 
            this.txtDauKy.BackColor = System.Drawing.Color.White;
            this.txtDauKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDauKy.Location = new System.Drawing.Point(549, 116);
            this.txtDauKy.Name = "txtDauKy";
            this.txtDauKy.Size = new System.Drawing.Size(249, 19);
            this.txtDauKy.TabIndex = 7;
            this.txtDauKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDauKy.TextChanged += new System.EventHandler(this.txtDauKy_TextChanged);
            this.txtDauKy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDauKy_KeyDown);
            this.txtDauKy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoNumber);
            this.txtDauKy.Leave += new System.EventHandler(this.txtDauKy_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Location = new System.Drawing.Point(165, 116);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(310, 19);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSDT_KeyDown);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoNumberSDT);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Location = new System.Drawing.Point(165, 77);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(677, 19);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi_KeyDown);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.Color.White;
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKhachHang.Location = new System.Drawing.Point(165, 38);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(677, 19);
            this.txtTenKhachHang.TabIndex = 1;
            this.txtTenKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenKhachHang_KeyDown);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(213, 617);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 46);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(341, 617);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 46);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(469, 617);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 46);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.Location = new System.Drawing.Point(725, 617);
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
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(597, 617);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 46);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSearchKhachHang
            // 
            this.txtSearchKhachHang.Location = new System.Drawing.Point(12, 32);
            this.txtSearchKhachHang.Name = "txtSearchKhachHang";
            this.txtSearchKhachHang.Size = new System.Drawing.Size(256, 23);
            this.txtSearchKhachHang.TabIndex = 19;
            this.txtSearchKhachHang.TextChanged += new System.EventHandler(this.txtSearchKhachHang_TextChanged);
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
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuxuathangBindingSource
            // 
            this.phieuxuathangBindingSource.DataMember = "phieuxuathang";
            this.phieuxuathangBindingSource.DataSource = this.qLBHDataSet;
            // 
            // phieuxuathangTableAdapter
            // 
            this.phieuxuathangTableAdapter.ClearBeforeFill = true;
            // 
            // idkhachhang
            // 
            this.idkhachhang.DataPropertyName = "idkhachhang";
            this.idkhachhang.HeaderText = "idkhachhang";
            this.idkhachhang.Name = "idkhachhang";
            this.idkhachhang.ReadOnly = true;
            this.idkhachhang.Visible = false;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.FillWeight = 190F;
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 150F;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SoDienThoai.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoDienThoai.FillWeight = 70F;
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // DauKy
            // 
            this.DauKy.DataPropertyName = "DauKy";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            dataGridViewCellStyle2.NullValue = "0";
            this.DauKy.DefaultCellStyle = dataGridViewCellStyle2;
            this.DauKy.FillWeight = 70F;
            this.DauKy.HeaderText = "Đầu Kỳ";
            this.DauKy.Name = "DauKy";
            this.DauKy.ReadOnly = true;
            this.DauKy.Visible = false;
            // 
            // PhaiThu
            // 
            this.PhaiThu.DataPropertyName = "PhaiThu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "###,###,###,##0";
            dataGridViewCellStyle3.NullValue = "0";
            this.PhaiThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhaiThu.FillWeight = 70F;
            this.PhaiThu.HeaderText = "Còn Phải Thu";
            this.PhaiThu.Name = "PhaiThu";
            this.PhaiThu.ReadOnly = true;
            this.PhaiThu.Visible = false;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.FillWeight = 50F;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtSearchKhachHang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbxKhachHang);
            this.Controls.Add(this.khachhangDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachhangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.gbxKhachHang.ResumeLayout(false);
            this.gbxKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView khachhangDataGridView;
        private System.Windows.Forms.GroupBox gbxKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSearchKhachHang;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private QLBHDataSetTableAdapters.khachhangTableAdapter khachhangTableAdapter;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDauKy;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.BindingSource phieuxuathangBindingSource;
        private QLBHDataSetTableAdapters.phieuxuathangTableAdapter phieuxuathangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DauKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhaiThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}