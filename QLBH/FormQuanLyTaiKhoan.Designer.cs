namespace QLBH
{
    partial class FormQuanLyTaiKhoan
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
            System.Windows.Forms.Label maHangLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.label1 = new System.Windows.Forms.Label();
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.gbxTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnDoiTenNV = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnLuuMK = new System.Windows.Forms.Button();
            this.taikhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.idTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taikhoanTableAdapter = new QLBH.QLBHDataSetTableAdapters.taikhoanTableAdapter();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.btnDoiMK = new System.Windows.Forms.Button();
            maHangLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.gbxTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maHangLabel
            // 
            maHangLabel.AutoSize = true;
            maHangLabel.Location = new System.Drawing.Point(76, 46);
            maHangLabel.Name = "maHangLabel";
            maHangLabel.Size = new System.Drawing.Size(332, 19);
            maHangLabel.TabIndex = 2;
            maHangLabel.Text = "Tài khoản:  ...............................................................";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(78, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(330, 19);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:  ...............................................................";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(356, 19);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu mới:  ...............................................................";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(62, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(346, 19);
            label4.TabIndex = 8;
            label4.Text = "Xác nhận lại:  ...............................................................";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(53, 118);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(355, 19);
            label5.TabIndex = 10;
            label5.Text = "Tên nhân viên:  ...............................................................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(102, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxTaiKhoan
            // 
            this.gbxTaiKhoan.BackColor = System.Drawing.Color.White;
            this.gbxTaiKhoan.Controls.Add(this.txtTenNhanVien);
            this.gbxTaiKhoan.Controls.Add(label5);
            this.gbxTaiKhoan.Controls.Add(this.txtXacNhan);
            this.gbxTaiKhoan.Controls.Add(label4);
            this.gbxTaiKhoan.Controls.Add(this.txtMatKhauMoi);
            this.gbxTaiKhoan.Controls.Add(label3);
            this.gbxTaiKhoan.Controls.Add(this.txtMatKhauCu);
            this.gbxTaiKhoan.Controls.Add(label2);
            this.gbxTaiKhoan.Controls.Add(this.txtTaiKhoan);
            this.gbxTaiKhoan.Controls.Add(maHangLabel);
            this.gbxTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTaiKhoan.Location = new System.Drawing.Point(44, 76);
            this.gbxTaiKhoan.Name = "gbxTaiKhoan";
            this.gbxTaiKhoan.Size = new System.Drawing.Size(460, 236);
            this.gbxTaiKhoan.TabIndex = 3;
            this.gbxTaiKhoan.TabStop = false;
            this.gbxTaiKhoan.Text = "Thông tin tài khoản:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BackColor = System.Drawing.Color.White;
            this.txtTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNhanVien.Location = new System.Drawing.Point(156, 112);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(247, 19);
            this.txtTenNhanVien.TabIndex = 11;
            this.txtTenNhanVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNhanVien_KeyDown);
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.BackColor = System.Drawing.Color.White;
            this.txtXacNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXacNhan.Location = new System.Drawing.Point(156, 184);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '*';
            this.txtXacNhan.Size = new System.Drawing.Size(247, 19);
            this.txtXacNhan.TabIndex = 9;
            this.txtXacNhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXacNhan_KeyDown);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.White;
            this.txtMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(156, 148);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(247, 19);
            this.txtMatKhauMoi.TabIndex = 7;
            this.txtMatKhauMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauMoi_KeyDown);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BackColor = System.Drawing.Color.White;
            this.txtMatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhauCu.Location = new System.Drawing.Point(156, 76);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(247, 19);
            this.txtMatKhauCu.TabIndex = 5;
            this.txtMatKhauCu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMauKhauCu_KeyDown);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Location = new System.Drawing.Point(156, 40);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(247, 19);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // btnDoiTenNV
            // 
            this.btnDoiTenNV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDoiTenNV.Location = new System.Drawing.Point(531, 152);
            this.btnDoiTenNV.Name = "btnDoiTenNV";
            this.btnDoiTenNV.Size = new System.Drawing.Size(90, 46);
            this.btnDoiTenNV.TabIndex = 14;
            this.btnDoiTenNV.Text = "Đổi Tên Nhân Viên";
            this.btnDoiTenNV.UseVisualStyleBackColor = true;
            this.btnDoiTenNV.Click += new System.EventHandler(this.btnDoiTenNV_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.Color.Red;
            this.btnNhapLai.Location = new System.Drawing.Point(531, 266);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(90, 46);
            this.btnNhapLai.TabIndex = 17;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnLuuMK
            // 
            this.btnLuuMK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuuMK.Location = new System.Drawing.Point(531, 211);
            this.btnLuuMK.Name = "btnLuuMK";
            this.btnLuuMK.Size = new System.Drawing.Size(90, 46);
            this.btnLuuMK.TabIndex = 18;
            this.btnLuuMK.Text = "Lưu";
            this.btnLuuMK.UseVisualStyleBackColor = true;
            this.btnLuuMK.Click += new System.EventHandler(this.btnLuuMK_Click);
            // 
            // taikhoanDataGridView
            // 
            this.taikhoanDataGridView.AllowUserToAddRows = false;
            this.taikhoanDataGridView.AllowUserToDeleteRows = false;
            this.taikhoanDataGridView.AutoGenerateColumns = false;
            this.taikhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taikhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTaiKhoan,
            this.TenTaiKhoan,
            this.MatKhau,
            this.GhiChu,
            this.TenNhanVien});
            this.taikhoanDataGridView.DataSource = this.taikhoanBindingSource;
            this.taikhoanDataGridView.Location = new System.Drawing.Point(533, 13);
            this.taikhoanDataGridView.Name = "taikhoanDataGridView";
            this.taikhoanDataGridView.ReadOnly = true;
            this.taikhoanDataGridView.RowHeadersVisible = false;
            this.taikhoanDataGridView.Size = new System.Drawing.Size(69, 74);
            this.taikhoanDataGridView.TabIndex = 19;
            this.taikhoanDataGridView.Visible = false;
            // 
            // idTaiKhoan
            // 
            this.idTaiKhoan.DataPropertyName = "idTaiKhoan";
            this.idTaiKhoan.HeaderText = "idTaiKhoan";
            this.idTaiKhoan.Name = "idTaiKhoan";
            this.idTaiKhoan.ReadOnly = true;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "TenTaiKhoan";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "TenNhanVien";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // taikhoanBindingSource
            // 
            this.taikhoanBindingSource.DataMember = "taikhoan";
            this.taikhoanBindingSource.DataSource = this.qLBHDataSet;
            // 
            // taikhoanTableAdapter
            // 
            this.taikhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.taikhoanTableAdapter = this.taikhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLBH.QLBHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDoiMK.Location = new System.Drawing.Point(531, 100);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(90, 46);
            this.btnDoiMK.TabIndex = 20;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // FormQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(640, 332);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.taikhoanDataGridView);
            this.Controls.Add(this.btnLuuMK);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnDoiTenNV);
            this.Controls.Add(this.gbxTaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.gbxTaiKhoan.ResumeLayout(false);
            this.gbxTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.GroupBox gbxTaiKhoan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnDoiTenNV;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnLuuMK;
        private System.Windows.Forms.DataGridView taikhoanDataGridView;
        private System.Windows.Forms.BindingSource taikhoanBindingSource;
        private QLBHDataSetTableAdapters.taikhoanTableAdapter taikhoanTableAdapter;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Button btnDoiMK;
    }
}