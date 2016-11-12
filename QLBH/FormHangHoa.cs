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
    public partial class FormHangHoa : Form
    {

        int group = 0;
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int search = 0;
        int myId;
        Boolean myAdd, myEdit, myDelete, mySave;

        public FormHangHoa()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void hanghoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hanghoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            this.hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
            gbxHangHoa.Enabled = false;
            gbxNhomHang.Visible = false; 
            dataGridView_hide();
            XuLyConTro(true);
        }

        private void XuLyConTro(bool b)
        {
            btnThemHH.Enabled = btnXoaHH.Enabled = btnSuaHH.Enabled = b;
            btnLuuHH.Enabled = btnHuyHH.Enabled = !b;
        }

        private void dataGridView_hide()
        {
            this.dgvNhomHangSearch.Visible = false;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            try
            {
                int centerF = this.Width / 2;
                gbxHangHoa.Left = centerF - (gbxHangHoa.Width / 2);
                gbxHangHoa.Top = this.Top + 40;
                groupBoxLeftPosion = gbxHangHoa.Left;
                groupBoxTopPosion = gbxHangHoa.Top;
            }
            catch
            {
            }
        }

        private void btnNhomHang_Click(object sender, EventArgs e)
        {
            if (group == 0)
            {
                gbxNhomHang.Visible = true;
                group = group + 1;
                this.nhomhangTableAdapter.Fill(this.qLBHDataSet.nhomhang);
            }
            else if(group == 1)
            {
                gbxNhomHang.Visible = false;
                group = group - 1;
            }
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            gbxHangHoa.Enabled = true;
            txtMaHang.Select();
            search = 1;
            XuLyConTro(false);
            dataGridView_hide();
            hanghoaDataGridView.Enabled = false;
            myAdd = true;
            myEdit = false;
            ClearForNewRecord();
        }

        private void btnLuuHH_Click(object sender, EventArgs e)
        {
            if (RecordCheckInput() == true)
            {
                if (myAdd == true)
                {
                    hanghoaTableAdapter.InsertHangHoa(
                                                       txtTenHang.Text,
                                                       txtMaHang.Text,
                                                       txtDVT.Text,
                                                       "Tầm Vu",
                                                       Convert.ToInt32(txtIdNhomHang.Text),
                                                       txtNhomHang.Text
                                                      );
                    string mahang = txtMaHang.Text + "-NTH";
                    hanghoaTableAdapter.InsertHangHoa(
                                                       txtTenHang.Text,
                                                       mahang,
                                                       txtDVT.Text,
                                                       "NTH",
                                                       Convert.ToInt32(txtIdNhomHang.Text),
                                                       txtNhomHang.Text
                                                      );
                }
                else if (myEdit == true)
                {
                    hanghoaTableAdapter.UpdateHangHoa(
                                                    txtTenHang.Text,
                                                    txtMaHang.Text,
                                                    txtDVT.Text,
                                                    cbKhoHang.Text,
                                                    Convert.ToInt32(txtIdNhomHang.Text),
                                                    txtNhomHang.Text,
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
                        txtMaHang.Select();
                        search = 1;
                        hanghoaDataGridView.Enabled = false;
                    }
                    else
                    {
                        gbxHangHoa.Enabled = false;
                        gbxNhomHang.Visible = false;
                        hanghoaDataGridView.Enabled = true;
                        XuLyConTro(true);
                        search = 0;
                    }
                }
                else if (myEdit == true)
                {
                    gbxHangHoa.Enabled = false;
                    gbxNhomHang.Visible = false;
                    hanghoaDataGridView.Enabled = true;
                    XuLyConTro(true);
                    search = 0;
                }
                this.hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
                gbxNhomHang.Visible = false;
            }
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            gbxHangHoa.Enabled = true;
            XuLyConTro(false);
            search = 1;
            hanghoaDataGridView.Enabled = false;
            myId = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["IdHangHoa"].Value);
            txtTenHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TenHang"].Value);
            txtMaHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["MaHang"].Value);
            txtDVT.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["DVT"].Value);
            txtNhomHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["NhomHang"].Value);
            cbKhoHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["KhoHang"].Value);
            txtIdNhomHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["IdNhomHang"].Value);
            dataGridView_hide();
            myAdd = false;
            myEdit = true;
            txtMaHang.Select();
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["IdHangHoa"].Value);
            int slphieunhap = (int)phieunhaphangctTableAdapter.FillByKTIdHangHoa(id);
            int slphieuxuat = (int)phieuxuathangctTableAdapter.FillByKTHangHoa(id);
            if (slphieunhap <= 0 && slphieuxuat <= 0)
            {
                string infor = "";
                infor += "Bạn có muốn xóa hàng hóa này?" + "\n";
                infor += "\n";
                infor += "\n";
                if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    /*hanghoaBindingSource.RemoveCurrent();
                    hanghoaTableAdapter.Update(qLBHDataSet.hanghoa);*/
                    hanghoaTableAdapter.DeleteHangHoa(id);
                    hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
                }
            }
            else
                MessageBox.Show("Hàng hóa này đã tồn tại trong phiếu nhập, xuất hàng!!!");
        }

        private void BtnHuyHH_Click(object sender, EventArgs e)
        {
            hanghoaBindingSource.CancelEdit();
            ClearForNewRecord();
            gbxHangHoa.Enabled = false;
            dataGridView_hide();
            XuLyConTro(true);
            hanghoaDataGridView.Enabled = true;
            search = 0;
            gbxNhomHang.Visible = false;
            this.hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
        }

        private void tenNhomHangTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNhomHang.Text.Trim().Length == 0)
                {
                    dgvNhomHangSearch.Visible = false;
                }
                else if (search == 1)
                {
                        dgvNhomHangSearch.Visible = true;
                        dgvNhomHangSearch.DataSource = nhomhangBindingSource;
                        this.nhomhangTableAdapter.FillBySearch(this.qLBHDataSet.nhomhang, "%" + txtNhomHang.Text + "%");
                        dgvNhomHangSearch.Width = 125;
                        myCount = dgvNhomHangSearch.RowCount;
                        if (myCount >= 5)
                        {
                            dgvNhomHangSearch.Height = 90;
                        }
                        else
                        {
                            dgvNhomHangSearch.Height = myCount * 23;
                        }
                        dgvNhomHangSearch.Left = groupBoxLeftPosion + txtNhomHang.Left + txtNhomHang.Text.Trim().Length * 55 / 10 + 10;
                        dgvNhomHangSearch.Top = groupBoxTopPosion + txtNhomHang.Top + 25;
                }
            }
            catch
            {

            }
        }

        private void tenNhomHangTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtMaHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (dgvNhomHangSearch.Visible == true)
                {
                    myTextBox = txtNhomHang;
                    dgvNhomHangSearch.Select();
                    SendKeys.Send("{DOWN}");
                }
                else
                    txtTenHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtTenHang.Select();
            } 
        }

        private void dgvNhomHangSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhomHangSearch.CurrentRow != null)
            {
                txtNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                txtIdNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[2].Value.ToString().Trim());
                dataGridView_hide();
                txtTenHang.Select();
            }
        }

        private void dgvNhomHangSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgvNhomHangSearch.CurrentRow != null)
                {
                    txtNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                    txtIdNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[2].Value.ToString().Trim());
                    dataGridView_hide();
                    txtTenHang.Select();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }

        private void tenNhomHangTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvNhomHangSearch.Visible == true && dgvNhomHangSearch.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtNhomHang.Text.ToString().Trim().Length > 0)
                    {
                        txtNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                        txtIdNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[2].Value.ToString().Trim());
                        dataGridView_hide();
                        txtTenHang.Select();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtTenHang.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void tenHangTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtNhomHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtDVT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtDVT.Select();
            }
        }

        private void maHangTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSearchHangHoa.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtNhomHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtNhomHang.Select();
            }
        }

        private void dVTTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtTenHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                btnLuuHH.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnLuuHH.Select();
            }
        }

        private void khoHangComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtDVT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                btnLuuHH.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnLuuHH.Select();
            }
        }


        private void txtNhomHang_Leave(object sender, EventArgs e)
        {
            if (dgvNhomHangSearch.CurrentRow == null && txtNhomHang.Text.Trim().Length != 0)
            {
                string infor = "";
                infor += "Hệ thống kiểm tra thấy nhóm hàng này chưa tồn tại trong hệ thống> " + "\r\n";
                infor += "-------------------------------------\r\n";
                infor += "Nếu là nhóm hàng mới, Nhấn Yes để lưu lại." + "\r\n";
                infor += "Nhấn No để chọn lại khách hàng đã tồn tại." + "\r\n";
                infor += "\r\n";
                if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    nhomhangTableAdapter.InsertNhomHang(
                                                        txtNhomHang.Text
                                                        );
                    dgvNhomHangSearch.DataSource = nhomhangBindingSource;
                    this.nhomhangTableAdapter.FillBySearch(this.qLBHDataSet.nhomhang, "%" + txtNhomHang.Text + "%");
                    txtNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                    txtIdNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[2].Value.ToString().Trim());
                }
                else
                {
                    txtNhomHang.Select();
                }

            }
        }

        private void btnXoaNH_Click(object sender, EventArgs e)
        {
            if(nhomhangDataGridView.CurrentRow != null)
            {
                nhomhangTableAdapter.DeleteNhomHang(
                                                    Convert.ToInt32(nhomhangDataGridView.CurrentRow.Cells["idNH"].Value)
                                                    );
                this.nhomhangTableAdapter.Fill(this.qLBHDataSet.nhomhang);
            }
        }

        private void txtSearchHangHoa_TextChanged(object sender, EventArgs e)
        {
            this.hanghoaTableAdapter.FillBySearch(this.qLBHDataSet.hanghoa, "%" + txtSearchHangHoa.Text + "%",
                                                                            "%" + txtSearchNhomHang.Text + "%",
                                                                            "%" + cbxSearchKhoHang.Text + "%"
                
                );
        }

        private void ClearForNewRecord()
        {
            myId = 0;
            txtTenHang.Text = "";
            txtMaHang.Text = "";
            txtDVT.Text = "";
            txtNhomHang.Text = "";
            cbKhoHang.Text = "Tầm Vu";
            txtIdNhomHang.Text = "";
            txtSearchHangHoa.Text = "";
            txtSearchNhomHang.Text = "";
            cbxSearchKhoHang.Text = "";
        }

        private Boolean RecordCheckInput()
        {
            string infor = "";
            mySave = true;
            this.hanghoaTableAdapter.FillBySearchTenHang(this.qLBHDataSet.hanghoa, txtMaHang.Text.Trim());
            if (txtMaHang.Text.Length == 0 || txtNhomHang.Text.Length == 0 || txtTenHang.Text.Length == 0 
                || txtDVT.Text.Length == 0 || cbKhoHang.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa chưa được nhập" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (txtMaHang.Text.Length > 20 || txtNhomHang.Text.Length > 150 || txtTenHang.Text.Length > 350
                || txtDVT.Text.Length > 20)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa đã vượt quá số lượng ký tự quy định" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (hanghoaDataGridView.RowCount > 0)
            {
                if (myEdit != true)
                {
                    infor += "Lỗi nhập liệu" + "\n";
                    infor += "----------------------------------" + "\n";
                    infor += "Mã hàng " + txtMaHang.Text + " đã tồn tại" + "\n";
                    infor += "\n";
                    infor += "\n";
                    MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySave = false;
                }
            }
            return mySave;
        }

        private void txtSearchNhomHang_TextChanged(object sender, EventArgs e)
        {
            this.hanghoaTableAdapter.FillBySearch(this.qLBHDataSet.hanghoa, "%" + txtSearchHangHoa.Text + "%",
                                                                            "%" + txtSearchNhomHang.Text + "%",
                                                                            "%" + cbxSearchKhoHang.Text + "%"

                );
        }

        private void cbxSearchKhoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hanghoaTableAdapter.FillBySearch(this.qLBHDataSet.hanghoa, "%" + txtSearchHangHoa.Text + "%",
                                                                            "%" + txtSearchNhomHang.Text + "%",
                                                                            "%" + cbxSearchKhoHang.Text + "%"

                );
        }
    }
}
