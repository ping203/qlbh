using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        Boolean myDoiMK, myDoiTen, mySave;

        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void hanghoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taikhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            this.taikhoanTableAdapter.Fill(this.qLBHDataSet.taikhoan);
            txtTaiKhoan.Text = Common.User;
            txtTenNhanVien.Text = Common.TenNhanVien;
            XuLyConTro(true);
            gbxTaiKhoan.Enabled = false;
            txtTenNhanVien.ReadOnly = true;
            txtMatKhauMoi.ReadOnly = true;
            txtXacNhan.ReadOnly = true;
        }

        private void XuLyConTro(bool b)
        {
            btnDoiMK.Enabled = btnDoiTenNV.Enabled = b;
            btnLuuMK.Enabled = btnNhapLai.Enabled = !b;
        }

        private void btnLuuMK_Click(object sender, EventArgs e)
        {
            if (myDoiMK == true)
            {
                if (RecordCheckInputDoiMK() == true)
                {
                    taikhoanTableAdapter.UpdateMatKhau(txtMatKhauMoi.Text.Trim(), Common.UserId);
                    Common.MatKhau = txtMatKhauMoi.Text.Trim();
                    gbxTaiKhoan.Enabled = false;
                    XuLyConTro(true);
                    MessageBox.Show("Mật khẩu đã đổi thành công!!!");
                    ClearForNew();
                }
            }
            else if (myDoiTen == true)
            {
                if (RecordCheckInputDoiTen() == true)
                {
                    taikhoanTableAdapter.UpdateTenNhanVien(txtTenNhanVien.Text.Trim(), Common.UserId);
                    Common.TenNhanVien = txtTenNhanVien.Text.Trim();
                    gbxTaiKhoan.Enabled = false;
                    XuLyConTro(true);
                    MessageBox.Show("Nhân viên đã đổi thành công!!!");
                    ClearForNew();
                }           
            }
        }

        private Boolean RecordCheckInputDoiTen()
        {
            string infor = "";
            mySave = true;
            if (txtMatKhauCu.Text == "")
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Vui lòng nhập mật khẩu" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Text = "";
                txtTenNhanVien.Text = Common.TenNhanVien;
                mySave = false;
            }
            else if (txtMatKhauCu.Text != Common.MatKhau)
            {
                infor += "Lỗi xác nhận" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Mật khẩu không đúng" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Text = "";
                txtTenNhanVien.Text = Common.TenNhanVien;
                mySave = false;
            }
            else if (txtTenNhanVien.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Tên nhân viên không được bỏ trống" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Text = "";
                txtTenNhanVien.Text = Common.TenNhanVien;
                mySave = false;
            }
            return mySave;
        }

        private Boolean RecordCheckInputDoiMK()
        {
            string infor = "";
            mySave = true;
            if (txtMatKhauCu.Text == "")
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Vui lòng nhập mật khẩu" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Text = txtMatKhauMoi.Text = txtXacNhan.Text = "";
                mySave = false;
            }
            else if (txtMatKhauCu.Text != Common.MatKhau)
            {
                infor += "Lỗi xác nhận" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Mật khẩu không đúng" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Text = txtMatKhauMoi.Text = txtXacNhan.Text = "";
                mySave = false;
            }
            else if (txtMatKhauMoi.Text == "" || txtMatKhauMoi.Text.Length < 5  || txtMatKhauMoi.Text.Length > 15)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Mật khẩu phải có độ dài từ 5 đến 15 ký tự" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Text = txtMatKhauMoi.Text = txtXacNhan.Text = "";
                mySave = false;
            }
            else if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                infor += "Lỗi xác nhận" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Xác nhận lại mật khẩu không đúng" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Text = txtMatKhauMoi.Text = txtXacNhan.Text = "";
                mySave = false;
            }
            return mySave;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Select();
            XuLyConTro(false);
            gbxTaiKhoan.Enabled = true;
            txtTenNhanVien.ReadOnly = true;
            txtMatKhauMoi.ReadOnly = false;
            txtXacNhan.ReadOnly = false;
            myDoiMK = true;
            myDoiTen = false;
        }

        private void btnDoiTenNV_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Select();
            XuLyConTro(false);
            gbxTaiKhoan.Enabled = true;
            txtTenNhanVien.ReadOnly = false;
            txtMatKhauMoi.ReadOnly = true;
            txtXacNhan.ReadOnly = true;
            myDoiMK = false;
            myDoiTen = true;
        }

        private void txtMauKhauCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                btnNhapLai.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (myDoiTen == true)
                {
                    txtTenNhanVien.Select();
                }
                else
                    txtMatKhauMoi.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                if (myDoiTen == true)
                {
                    txtTenNhanVien.Select();
                }
                else
                    txtMatKhauMoi.Select();
            }
        }

        private void txtTenNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtMatKhauCu.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                btnLuuMK.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnLuuMK.Select();
            }
        }

        private void txtMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtMatKhauCu.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtXacNhan.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtXacNhan.Select();
            }
        }

        private void txtXacNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtMatKhauMoi.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                btnLuuMK.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnLuuMK.Select();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            ClearForNew();
        }

        private void ClearForNew()
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtXacNhan.Text = "";
            txtTenNhanVien.Text = Common.TenNhanVien;
        }

    }
}
