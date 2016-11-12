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
    public partial class FormNhaCungCap : Form
    {
        int group = 0;
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int myId;
        int myPhaiTra;
        Boolean myAdd, myEdit, myDelete, mySave;

        public FormNhaCungCap()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void nhacungcapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhacungcapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.nhacungcap' table. You can move, or remove it, as needed.
            this.nhacungcapTableAdapter.Fill(this.qLBHDataSet.nhacungcap);
            // TODO: This line of code loads data into the 'qLBHDataSet.khachhang' table. You can move, or remove it, as needed.
            gbxNhaCC.Enabled = false;
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
                gbxNhaCC.Left = centerF - (gbxNhaCC.Width / 2);
                gbxNhaCC.Top = this.Top + 40;
                groupBoxLeftPosion = gbxNhaCC.Left;
                groupBoxTopPosion = gbxNhaCC.Top;
            }
            catch
            {
            }
        }

        #region Nhóm Button Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            gbxNhaCC.Enabled = true;
            txtTenNhaCC.Select();
            XuLyConTro(false);
            dataGridView_hide();
            nhacungcapDataGridView.Enabled = false;
            myAdd = true;
            myEdit = false;
            ClearForNewRecord();
            txtDauKy.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           // if (RecordCheckInput() == true)
            {
                if (myAdd == true)
                {
                    nhacungcapTableAdapter.InsertNhaCC(
                                                        txtTenNhaCC.Text,
                                                        txtDiaChi.Text,
                                                        txtSDT.Text,
                                                        txtMST.Text,
                                                        Convert.ToDecimal(txtDauKy.Text),
                                                        Convert.ToDecimal(txtDauKy.Text),// Phải trả = Đầu Kỳ
                                                        txtGhiChu.Text
                                                      );
                }
                else if (myEdit == true)
                {
                    nhacungcapTableAdapter.UpdateNhaCC(
                                                        txtTenNhaCC.Text,
                                                        txtDiaChi.Text,
                                                        txtSDT.Text,
                                                        txtMST.Text,
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
                        txtTenNhaCC.Select();
                        nhacungcapDataGridView.Enabled = false;
                    }
                    else
                    {
                        gbxNhaCC.Enabled = false;
                        nhacungcapDataGridView.Enabled = true;
                        XuLyConTro(true);
                    }
                }
                else if (myEdit == true)
                {
                    gbxNhaCC.Enabled = false;
                    nhacungcapDataGridView.Enabled = true;
                    XuLyConTro(true);
                }
                this.nhacungcapTableAdapter.Fill(this.qLBHDataSet.nhacungcap);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gbxNhaCC.Enabled = true;
            XuLyConTro(false);
            nhacungcapDataGridView.Enabled = false;
            myId = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["IdNhaCungCap"].Value);
            txtTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC"].Value);
            txtDiaChi.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["DiaChi"].Value);
            txtSDT.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["SoDienThoai"].Value);
            txtMST.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["MaSoThue"].Value);
            txtDauKy.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["DauKy"].Value);
            txtDauKy.Text = string.Format("{0:n0}", Double.Parse(txtDauKy.Text));
            myPhaiTra = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra"].Value);
            txtGhiChu.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["GhiChu"].Value);
            dataGridView_hide();
            myAdd = false;
            myEdit = true;
            txtTenNhaCC.Select();
            //txtDauKy.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["IdNhaCungCap"].Value);
            int slnhacc = (int)phieunhaphangTableAdapter.FillByKTNhaCC(id);
            if (slnhacc <= 0)
            {
                string infor = "";
                infor += "Bạn có muốn xóa nhà cung cấp này?" + "\n";
                infor += "\n";
                infor += "\n";
                if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    /*nhacungcapBindingSource.RemoveCurrent();
                    nhacungcapTableAdapter.Update(qLBHDataSet.nhacungcap);*/
                    nhacungcapTableAdapter.DeleteNhaCC(id);
                    nhacungcapTableAdapter.Fill(this.qLBHDataSet.nhacungcap);
                }
            }
            else
                MessageBox.Show("Nhà cung cấp này đã tồn tại trong phiếu nhập hàng!!!");
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            nhacungcapBindingSource.CancelEdit();
            ClearForNewRecord();
            gbxNhaCC.Enabled = false;
            dataGridView_hide();
            XuLyConTro(true);
            nhacungcapDataGridView.Enabled = true;
        }
        #endregion

        private void txtSearchKhachHang_TextChanged(object sender, EventArgs e)
        {
            this.nhacungcapTableAdapter.FillBySearch(this.qLBHDataSet.nhacungcap, "%" + txtSearchNhaCC.Text + "%");
        }

        private void ClearForNewRecord()
        {
            myId = 0;
            txtTenNhaCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtMST.Text = "";
            txtDauKy.Text = "0";
            myPhaiTra = 0;
            txtGhiChu.Text = "";
        }

        private Boolean RecordCheckInput()
        {
            string infor = "";
            mySave = true;
            if (txtTenNhaCC.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0
                || txtDauKy.Text.Length == 0 || txtGhiChu.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa chưa được nhập" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (txtTenNhaCC.Text.Length > 300 || txtDiaChi.Text.Length > 300 || txtSDT.Text.Length > 30 || txtMST.Text.Length > 14
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

        private void AutoNumberMST(object sender, KeyPressEventArgs e)
        {
            int mykey = (int)e.KeyChar;
            if (!(char.IsNumber(e.KeyChar) || mykey == 44 || mykey == 46 || e.KeyChar == '-'))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        #region Nhóm KeyDown
        private void txtTenNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSearchNhaCC.Select();
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
                txtTenNhaCC.Select();
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
                txtMST.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtMST.Select();
            }
        }

        private void txtMST_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSDT.Select();
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
                txtMST.Select();
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
                txtDauKy.Text = string.Format("{0:n0}", Double.Parse(txtDauKy.Text));
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
