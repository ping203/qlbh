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
    public partial class FormKhachHang : Form
    {
        int group = 0;
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int myId;
        string myPhaiThu;
        Boolean myAdd, myEdit, myDelete, mySave;

        public FormKhachHang()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void khachhangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachhangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qLBHDataSet.khachhang);
            gbxKhachHang.Enabled = false;
            dataGridView_hide();
            XuLyConTro(true);
        }

        private void XuLyConTro(bool b)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = !b;
        }

        private void dataGridView_hide()
        {
           // this.dgvNhomHangSearch.Visible = false;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            try
            {
                int centerF = this.Width / 2;
                gbxKhachHang.Left = centerF - (gbxKhachHang.Width / 2);
                gbxKhachHang.Top = this.Top + 40;
                groupBoxLeftPosion = gbxKhachHang.Left;
                groupBoxTopPosion = gbxKhachHang.Top;
            }
            catch
            {
            }
        }

        #region Nhóm Button Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            gbxKhachHang.Enabled = true;
            txtTenKhachHang.Select();
            XuLyConTro(false);
            dataGridView_hide();
            khachhangDataGridView.Enabled = false;
            myAdd = true;
            myEdit = false;
            ClearForNewRecord();
            txtDauKy.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (RecordCheckInput() == true)
            {
                if (myAdd == true)
                {
                    khachhangTableAdapter.InsertKhachHang(
                                                        txtTenKhachHang.Text,
                                                        txtDiaChi.Text,
                                                        txtSDT.Text,
                                                        Convert.ToDecimal(txtDauKy.Text),
                                                        Convert.ToDecimal(txtDauKy.Text), // Phải thu = đầu kỳ
                                                        txtGhiChu.Text
                                                      );
                }
                else if (myEdit == true)
                {
                    khachhangTableAdapter.UpdateKhachHang(
                                                        txtTenKhachHang.Text,
                                                        txtDiaChi.Text,
                                                        txtSDT.Text,
                                                        Convert.ToDecimal(txtDauKy.Text),
                                                        txtGhiChu.Text,
                                                        myId);
                }
                if (myAdd == true)
                {
                    string infor = "";
                    infor += "Bạn có muốn tiếp tục?" + "\n";
                    infor += "\n";
                    infor += "\n";
                    if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ClearForNewRecord();
                        txtTenKhachHang.Select();
                        khachhangDataGridView.Enabled = false;
                    }
                    else
                    {
                        gbxKhachHang.Enabled = false;
                        khachhangDataGridView.Enabled = true;
                        XuLyConTro(true);
                    }
                }
                else if (myEdit == true)
                {
                    gbxKhachHang.Enabled = false;
                    khachhangDataGridView.Enabled = true;
                    XuLyConTro(true);
                }
                this.khachhangTableAdapter.Fill(this.qLBHDataSet.khachhang);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gbxKhachHang.Enabled = true;
            XuLyConTro(false);
            khachhangDataGridView.Enabled = false;
            myId = Convert.ToInt32(khachhangDataGridView.CurrentRow.Cells["IdKhachHang"].Value);
            txtTenKhachHang.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["TenKhachHang"].Value);
            txtDiaChi.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["DiaChi"].Value);
            txtSDT.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["SoDienThoai"].Value);
            txtDauKy.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["DauKy"].Value);
            txtDauKy.Text = string.Format("{0:n0}", Double.Parse("0"+txtDauKy.Text));
            myPhaiThu = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["PhaiThu"].Value);
            txtGhiChu.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["GhiChu"].Value);
            dataGridView_hide();
            myAdd = false;
            myEdit = true;
            txtTenKhachHang.Select();
           // txtDauKy.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(khachhangDataGridView.CurrentRow.Cells["IdKhachHang"].Value);
            int slkhachhang = (int)phieuxuathangTableAdapter.FillByKTKhachHang(id);
            if (slkhachhang <= 0)
            {
                string infor = "";
                infor += "Bạn có muốn xóa khách hàng này?" + "\n";
                infor += "\n";
                infor += "\n";
                if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    /*khachhangBindingSource.RemoveCurrent();
                    khachhangTableAdapter.Update(qLBHDataSet.khachhang);*/
                    khachhangTableAdapter.DeleteKhachHang(id);
                    khachhangTableAdapter.Fill(this.qLBHDataSet.khachhang);
                }
            }
            else
                MessageBox.Show("Khách hàng này đã tồn tại trong phiếu xuất hàng!!!");
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            khachhangBindingSource.CancelEdit();
            ClearForNewRecord();
            gbxKhachHang.Enabled = false;
            dataGridView_hide();
            XuLyConTro(true);
            khachhangDataGridView.Enabled = true;
        }
        #endregion

        private void txtSearchKhachHang_TextChanged(object sender, EventArgs e)
        {
            this.khachhangTableAdapter.FillBySearch(this.qLBHDataSet.khachhang, "%" + txtSearchKhachHang.Text + "%");
        }

        private void ClearForNewRecord()
        {
            myId = 0;
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtDauKy.Text = "0";
            myPhaiThu = "";
            txtGhiChu.Text = "";
        }

        private Boolean RecordCheckInput()
        {
            string infor = "";
            mySave = true;
            if (txtTenKhachHang.Text.Length == 0 || txtDiaChi.Text.Length == 0
                || txtDauKy.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa chưa được nhập" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (txtSDT.Text.Length == 0)
            {
                txtSDT.Text = "-";
            }
            else if (txtTenKhachHang.Text.Length > 300 || txtDiaChi.Text.Length > 300 || txtSDT.Text.Length > 30
                || txtGhiChu.Text.Length > 300)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa đã vượt quá số lượng ký tự quy định" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            return mySave;
        }

        private void AutoNumber(object sender, KeyPressEventArgs e)
        {
            int mykey = (int)e.KeyChar;
            if (!(char.IsNumber(e.KeyChar) || mykey == 44 || mykey == 46))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void AutoNumberSDT(object sender, KeyPressEventArgs e)
        {
            int mykey = (int)e.KeyChar;
            if (!(char.IsNumber(e.KeyChar) || mykey == 44 || mykey == 46 || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ' '))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        #region Nhóm KeyDown
        private void txtTenKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSearchKhachHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtDiaChi.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtDiaChi.Select();
            }
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtTenKhachHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtSDT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtSDT.Select();
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtDiaChi.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtDauKy.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtDauKy.Select();
            }
        }

        private void txtDauKy_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSDT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtGhiChu.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtGhiChu.Select();
            }
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtDauKy.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                btnLuu.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnLuu.Select();
            }
        }
        #endregion

        private void txtDauKy_Leave(object sender, EventArgs e)
        {
            if (this.txtDauKy.Text.Trim().Length != 0)
                txtDauKy.Text = string.Format("{0:n0}", Double.Parse("0" + txtDauKy.Text));
            else txtDauKy.Text = "0";
 
        }

        private void txtDauKy_TextChanged(object sender, EventArgs e)
        {
            if (txtDauKy.Text.Length != 0)
            {
                double dk = double.Parse(txtDauKy.Text.Replace(",", ""));
                txtDauKy.Text = dk.ToString("###,###,###,##0");
                txtDauKy.Select(txtDauKy.TextLength, 0);
            }
        }

    }
}
