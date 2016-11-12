namespace QLBH
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matKhautextBox = new System.Windows.Forms.TextBox();
            this.dangNhapbutton = new System.Windows.Forms.Button();
            this.huyBobutton = new System.Windows.Forms.Button();
            this.taikhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.labelTenNhanVien = new System.Windows.Forms.Label();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.taiKhoantextBox = new System.Windows.Forms.TextBox();
            this.taikhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.taikhoanTableAdapter = new QLBH.QLBHDataSetTableAdapters.taikhoanTableAdapter();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // matKhautextBox
            // 
            this.matKhautextBox.Location = new System.Drawing.Point(155, 76);
            this.matKhautextBox.Name = "matKhautextBox";
            this.matKhautextBox.PasswordChar = '*';
            this.matKhautextBox.Size = new System.Drawing.Size(185, 26);
            this.matKhautextBox.TabIndex = 3;
            this.matKhautextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.matKhautextBox_KeyDown);
            // 
            // dangNhapbutton
            // 
            this.dangNhapbutton.ForeColor = System.Drawing.Color.Blue;
            this.dangNhapbutton.Location = new System.Drawing.Point(128, 138);
            this.dangNhapbutton.Name = "dangNhapbutton";
            this.dangNhapbutton.Size = new System.Drawing.Size(100, 30);
            this.dangNhapbutton.TabIndex = 5;
            this.dangNhapbutton.Text = "Đăng nhập";
            this.dangNhapbutton.UseVisualStyleBackColor = true;
            this.dangNhapbutton.Click += new System.EventHandler(this.dangNhapbutton_Click);
            // 
            // huyBobutton
            // 
            this.huyBobutton.ForeColor = System.Drawing.Color.Red;
            this.huyBobutton.Location = new System.Drawing.Point(240, 138);
            this.huyBobutton.Name = "huyBobutton";
            this.huyBobutton.Size = new System.Drawing.Size(100, 30);
            this.huyBobutton.TabIndex = 6;
            this.huyBobutton.Text = "Hủy bỏ";
            this.huyBobutton.UseVisualStyleBackColor = true;
            this.huyBobutton.Click += new System.EventHandler(this.huyBobutton_Click);
            // 
            // taikhoanDataGridView
            // 
            this.taikhoanDataGridView.AllowUserToAddRows = false;
            this.taikhoanDataGridView.AllowUserToDeleteRows = false;
            this.taikhoanDataGridView.AutoGenerateColumns = false;
            this.taikhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taikhoanDataGridView.ColumnHeadersVisible = false;
            this.taikhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.MatKhau,
            this.TenNhanVien,
            this.idTaiKhoan});
            this.taikhoanDataGridView.DataSource = this.taikhoanBindingSource;
            this.taikhoanDataGridView.Location = new System.Drawing.Point(233, 9);
            this.taikhoanDataGridView.Name = "taikhoanDataGridView";
            this.taikhoanDataGridView.ReadOnly = true;
            this.taikhoanDataGridView.RowHeadersVisible = false;
            this.taikhoanDataGridView.Size = new System.Drawing.Size(107, 25);
            this.taikhoanDataGridView.TabIndex = 7;
            this.taikhoanDataGridView.Visible = false;
            this.taikhoanDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taikhoanDataGridView_CellClick);
            this.taikhoanDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taikhoanDataGridView_KeyDown);
            // 
            // labelTenNhanVien
            // 
            this.labelTenNhanVien.AutoSize = true;
            this.labelTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNhanVien.ForeColor = System.Drawing.Color.Purple;
            this.labelTenNhanVien.Location = new System.Drawing.Point(12, 9);
            this.labelTenNhanVien.Name = "labelTenNhanVien";
            this.labelTenNhanVien.Size = new System.Drawing.Size(123, 19);
            this.labelTenNhanVien.TabIndex = 8;
            this.labelTenNhanVien.Text = "Quản trị hệ thống";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnKetNoi.Location = new System.Drawing.Point(16, 138);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(100, 30);
            this.btnKetNoi.TabIndex = 9;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // taiKhoantextBox
            // 
            this.taiKhoantextBox.Location = new System.Drawing.Point(155, 46);
            this.taiKhoantextBox.Name = "taiKhoantextBox";
            this.taiKhoantextBox.Size = new System.Drawing.Size(185, 26);
            this.taiKhoantextBox.TabIndex = 10;
            this.taiKhoantextBox.TextChanged += new System.EventHandler(this.taiKhoantextBox_TextChanged);
            this.taiKhoantextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taiKhoantextBox_KeyDown);
            this.taiKhoantextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taiKhoantextBox_KeyPress);
            // 
            // taikhoanBindingSource
            // 
            this.taikhoanBindingSource.DataMember = "taikhoan";
            this.taikhoanBindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.MatKhau.Visible = false;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "TenNhanVien";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            this.TenNhanVien.Visible = false;
            // 
            // idTaiKhoan
            // 
            this.idTaiKhoan.DataPropertyName = "idTaiKhoan";
            this.idTaiKhoan.HeaderText = "idTaiKhoan";
            this.idTaiKhoan.Name = "idTaiKhoan";
            this.idTaiKhoan.ReadOnly = true;
            this.idTaiKhoan.Visible = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 188);
            this.Controls.Add(this.taiKhoantextBox);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.labelTenNhanVien);
            this.Controls.Add(this.taikhoanDataGridView);
            this.Controls.Add(this.huyBobutton);
            this.Controls.Add(this.dangNhapbutton);
            this.Controls.Add(this.matKhautextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matKhautextBox;
        private System.Windows.Forms.Button dangNhapbutton;
        private System.Windows.Forms.Button huyBobutton;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource taikhoanBindingSource;
        private QLBHDataSetTableAdapters.taikhoanTableAdapter taikhoanTableAdapter;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView taikhoanDataGridView;
        private System.Windows.Forms.Label labelTenNhanVien;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.TextBox taiKhoantextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTaiKhoan;

    }
}

