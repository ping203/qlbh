namespace QLBH
{
    partial class FormNhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nhacungcapDataGridView = new System.Windows.Forms.DataGridView();
            this.nhacungcapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.gbxNhaCC = new System.Windows.Forms.GroupBox();
            this.txtMST = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDauKy = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSearchNhaCC = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.nhacungcapTableAdapter = new QLBH.QLBHDataSetTableAdapters.nhacungcapTableAdapter();
            this.phieunhaphangTableAdapter = new QLBH.QLBHDataSetTableAdapters.phieunhaphangTableAdapter();
            this.phieunhaphangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idnhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSoThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DauKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenHangLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.gbxNhaCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhaphangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenHangLabel
            // 
            tenHangLabel.AutoSize = true;
            tenHangLabel.Location = new System.Drawing.Point(35, 44);
            tenHangLabel.Name = "tenHangLabel";
            tenHangLabel.Size = new System.Drawing.Size(823, 19);
            tenHangLabel.TabIndex = 0;
            tenHangLabel.Text = "Tên Nhà Cung Cấp:  .............................................................." +
    "................................................................................" +
    ".............................";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(108, 81);
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
            label3.Location = new System.Drawing.Point(66, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(419, 19);
            label3.TabIndex = 4;
            label3.Text = "Số Điện Thoại:  ................................................................." +
    ".............";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(507, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(351, 19);
            label4.TabIndex = 6;
            label4.Text = "MST:  ..........................................................................." +
    "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(488, 155);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(370, 19);
            label5.TabIndex = 12;
            label5.Text = "Ghi Chú:  ......................................................................." +
    "....";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(105, 155);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(380, 19);
            label6.TabIndex = 10;
            label6.Text = "Đầu Kỳ:  ........................................................................" +
    "......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(244, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // nhacungcapDataGridView
            // 
            this.nhacungcapDataGridView.AllowUserToAddRows = false;
            this.nhacungcapDataGridView.AllowUserToDeleteRows = false;
            this.nhacungcapDataGridView.AutoGenerateColumns = false;
            this.nhacungcapDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhacungcapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhacungcapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnhacungcap,
            this.TenNhaCC,
            this.DiaChi,
            this.SoDienThoai,
            this.MaSoThue,
            this.DauKy,
            this.PhaiTra,
            this.GhiChu});
            this.nhacungcapDataGridView.DataSource = this.nhacungcapBindingSource;
            this.nhacungcapDataGridView.Location = new System.Drawing.Point(12, 63);
            this.nhacungcapDataGridView.Name = "nhacungcapDataGridView";
            this.nhacungcapDataGridView.ReadOnly = true;
            this.nhacungcapDataGridView.RowHeadersVisible = false;
            this.nhacungcapDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nhacungcapDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhacungcapDataGridView.Size = new System.Drawing.Size(989, 317);
            this.nhacungcapDataGridView.TabIndex = 2;
            // 
            // nhacungcapBindingSource
            // 
            this.nhacungcapBindingSource.DataMember = "nhacungcap";
            this.nhacungcapBindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxNhaCC
            // 
            this.gbxNhaCC.BackColor = System.Drawing.Color.White;
            this.gbxNhaCC.Controls.Add(this.txtMST);
            this.gbxNhaCC.Controls.Add(this.txtGhiChu);
            this.gbxNhaCC.Controls.Add(this.txtDauKy);
            this.gbxNhaCC.Controls.Add(this.txtSDT);
            this.gbxNhaCC.Controls.Add(this.txtDiaChi);
            this.gbxNhaCC.Controls.Add(this.txtTenNhaCC);
            this.gbxNhaCC.Controls.Add(label5);
            this.gbxNhaCC.Controls.Add(label6);
            this.gbxNhaCC.Controls.Add(label4);
            this.gbxNhaCC.Controls.Add(label3);
            this.gbxNhaCC.Controls.Add(label2);
            this.gbxNhaCC.Controls.Add(tenHangLabel);
            this.gbxNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNhaCC.Location = new System.Drawing.Point(48, 394);
            this.gbxNhaCC.Name = "gbxNhaCC";
            this.gbxNhaCC.Size = new System.Drawing.Size(913, 214);
            this.gbxNhaCC.TabIndex = 3;
            this.gbxNhaCC.TabStop = false;
            this.gbxNhaCC.Text = "Thông tin nhà cung cấp:";
            // 
            // txtMST
            // 
            this.txtMST.BackColor = System.Drawing.Color.White;
            this.txtMST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMST.Location = new System.Drawing.Point(556, 112);
            this.txtMST.Name = "txtMST";
            this.txtMST.Size = new System.Drawing.Size(293, 19);
            this.txtMST.TabIndex = 11;
            this.txtMST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMST_KeyDown);
            this.txtMST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoNumberMST);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhiChu.Location = new System.Drawing.Point(556, 149);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(293, 19);
            this.txtGhiChu.TabIndex = 9;
            this.txtGhiChu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGhiChu_KeyDown);
            // 
            // txtDauKy
            // 
            this.txtDauKy.BackColor = System.Drawing.Color.White;
            this.txtDauKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDauKy.Location = new System.Drawing.Point(170, 149);
            this.txtDauKy.Name = "txtDauKy";
            this.txtDauKy.Size = new System.Drawing.Size(261, 19);
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
            this.txtSDT.Location = new System.Drawing.Point(172, 112);
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
            this.txtDiaChi.Location = new System.Drawing.Point(172, 75);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(677, 19);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi_KeyDown);
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.BackColor = System.Drawing.Color.White;
            this.txtTenNhaCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNhaCC.Location = new System.Drawing.Point(172, 38);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(677, 19);
            this.txtTenNhaCC.TabIndex = 1;
            this.txtTenNhaCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNhaCC_KeyDown);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(196, 617);
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
            this.btnSua.Location = new System.Drawing.Point(324, 617);
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
            this.btnXoa.Location = new System.Drawing.Point(452, 617);
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
            this.btnHuy.Location = new System.Drawing.Point(708, 617);
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
            this.btnLuu.Location = new System.Drawing.Point(580, 617);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 46);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSearchNhaCC
            // 
            this.txtSearchNhaCC.Location = new System.Drawing.Point(12, 34);
            this.txtSearchNhaCC.Name = "txtSearchNhaCC";
            this.txtSearchNhaCC.Size = new System.Drawing.Size(230, 23);
            this.txtSearchNhaCC.TabIndex = 19;
            this.txtSearchNhaCC.TextChanged += new System.EventHandler(this.txtSearchKhachHang_TextChanged);
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
            // nhacungcapTableAdapter
            // 
            this.nhacungcapTableAdapter.ClearBeforeFill = true;
            // 
            // phieunhaphangTableAdapter
            // 
            this.phieunhaphangTableAdapter.ClearBeforeFill = true;
            // 
            // phieunhaphangBindingSource
            // 
            this.phieunhaphangBindingSource.DataMember = "phieunhaphang";
            this.phieunhaphangBindingSource.DataSource = this.qLBHDataSet;
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
            this.TenNhaCC.FillWeight = 180F;
            this.TenNhaCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.ReadOnly = true;
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
            // MaSoThue
            // 
            this.MaSoThue.DataPropertyName = "MaSoThue";
            this.MaSoThue.FillWeight = 70F;
            this.MaSoThue.HeaderText = "Mã Số Thuế";
            this.MaSoThue.Name = "MaSoThue";
            this.MaSoThue.ReadOnly = true;
            // 
            // DauKy
            // 
            this.DauKy.DataPropertyName = "DauKy";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "###,###,###,##0";
            this.DauKy.DefaultCellStyle = dataGridViewCellStyle2;
            this.DauKy.FillWeight = 70F;
            this.DauKy.HeaderText = "Đầu Kỳ";
            this.DauKy.Name = "DauKy";
            this.DauKy.ReadOnly = true;
            this.DauKy.Visible = false;
            // 
            // PhaiTra
            // 
            this.PhaiTra.DataPropertyName = "PhaiTra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "###,###,###,##0";
            this.PhaiTra.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhaiTra.FillWeight = 70F;
            this.PhaiTra.HeaderText = "Còn Phải Trả";
            this.PhaiTra.Name = "PhaiTra";
            this.PhaiTra.ReadOnly = true;
            this.PhaiTra.Visible = false;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.FillWeight = 50F;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtSearchNhaCC);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbxNhaCC);
            this.Controls.Add(this.nhacungcapDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.gbxNhaCC.ResumeLayout(false);
            this.gbxNhaCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhaphangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nhacungcapDataGridView;
        private System.Windows.Forms.GroupBox gbxNhaCC;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSearchNhaCC;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDauKy;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.BindingSource nhacungcapBindingSource;
        private QLBHDataSetTableAdapters.nhacungcapTableAdapter nhacungcapTableAdapter;
        private System.Windows.Forms.TextBox txtMST;
        private QLBHDataSetTableAdapters.phieunhaphangTableAdapter phieunhaphangTableAdapter;
        private System.Windows.Forms.BindingSource phieunhaphangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DauKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhaiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}