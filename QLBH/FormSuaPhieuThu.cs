using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLBH
{
    public partial class FormSuaPhieuThu : Form
    {
        int group = 0;
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int myId;
        int myIdKhachHang = 0;
        int myIdtam = 0;
        decimal myPhaiThu;
        decimal tamtinh;
        Boolean myAdd, myEdit, myDelete, mySave;

        public FormSuaPhieuThu()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void phieuchiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuthuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormPhieuChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.DataTableReportPhieuThu' table. You can move, or remove it, as needed.
            this.DataTableReportPhieuThuTableAdapter.Fill(this.DataSetReport.DataTableReportPhieuThu);
            // TODO: This line of code loads data into the 'DataSetReport.DataTableReportPhieuXuat' table. You can move, or remove it, as needed.
            this.phimtatTableAdapter.Fill(this.qLBHDataSet.phimtat);
            // TODO: This line of code loads data into the 'qLBHDataSet.khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qLBHDataSet.khachhang);
            // TODO: This line of code loads data into the 'qLBHDataSet.phieuthu' table. You can move, or remove it, as needed.
            this.phieuthuTableAdapter.Fill(this.qLBHDataSet.phieuthu);
            // TODO: This line of code loads data into the 'qLBHDataSet.phieuthu' table. You can move, or remove it, as needed.
            reportViewerPhieuThu.Visible = false;
            gbxPhieuThu.Visible = false;
            dataGridView_hide();
            XuLyConTro(true);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            try
            {
                int centerF = this.Width / 2;
                gbxPhieuThu.Left = centerF - (gbxPhieuThu.Width / 2);
                gbxPhieuThu.Top = this.Top + 40;
                groupBoxLeftPosion = gbxPhieuThu.Left;
                groupBoxTopPosion = gbxPhieuThu.Top;
            }
            catch
            {
            }
        }

        #region Nhóm Xử lý
        private void XuLyConTro(bool b)
        {
            btnXemPhieu.Enabled = btnXoa.Enabled = btnSua.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = !b;
        }

        private void AnGroupBox(bool b)
        {
            gbxPhieuThu.Visible = !b;
            phieuthuDataGridView.Visible = txtSearchPhieuThu.Visible = b;
        }

        private void ReadOnlyTextBox(bool b)
        {
            dtpNgayLap.Visible = !b;
            txtTenKhachHang.ReadOnly = b;
            txtDiaChi.ReadOnly = b;
            txtSDT.ReadOnly = b;
            txtLyDo.ReadOnly = b;
            txtSoTien.ReadOnly = b;
            txtSoTien.ReadOnly = b;
            txtGhiChu.ReadOnly = b;
            txtUser.ReadOnly = b;

            btnXemPhieu.Enabled = btnSua.Enabled = btnXoa.Enabled = !b;
            btnHuy.Enabled = b;
        }

        private void dataGridView_hide()
        {
            this.khachhangDataGridView.Visible = false;
            this.phimtatDataGridView.Visible = false;
        }
        #endregion

        #region Nhóm Button Click
        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            CopyData();
            ReadOnlyTextBox(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Common.UserId == 1)
            {
                CopyData();
                if (Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["TrangThai"].Value) != "Auto")
                {
                    XuLyConTro(false);
                    txtTenKhachHang.Select();
                }
                else
                {
                    MessageBox.Show("Phiếu thu này không thể chỉnh sửa !!!");
                    AnGroupBox(true);
                }
            }
            else MessageBox.Show("Bạn không có quyền sửa phiếu này !!!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CopyData();
            if (Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["TrangThai"].Value) != "Auto")
            {
                string infor = "";
                infor += "Bạn có muốn xóa phiếu thu này?" + "\n";
                infor += "\n";
                infor += "\n";
                if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Common.UserId == 1)
                    {
                        myIdKhachHang = Convert.ToInt32(phieuthuDataGridView.CurrentRow.Cells["IdKhachHang"].Value);
                        this.khachhangTableAdapter.FillBySearchId(this.qLBHDataSet.khachhang, myIdKhachHang);
                        myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                        string sotien = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["SoTienThu"].Value);
                        tamtinh = myPhaiThu + Convert.ToDecimal(sotien);
                        //
                        phieuthuTableAdapter.DeletePhieuThu(myId);
                        this.phieuthuTableAdapter.Fill(this.qLBHDataSet.phieuthu);
                        //
                        khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                                                   tamtinh,
                                                                    myIdKhachHang
                                                                    );
                    }
                    else MessageBox.Show("Bạn không có quyền xóa phiếu này !!!");
                }
               // else
                {
                    AnGroupBox(true);
                }
            }
            else
            {
                MessageBox.Show("Phiếu thu này không thể xóa !!!");
                AnGroupBox(true);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (RecordCheckInput() == true)
            {
                string sotien = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["SoTienThu"].Value);
                {
                    phieuthuTableAdapter.UpdatePhieuThu(
                                                        txtSoHieu.Text,
                                                        dtpNgayLap.Value,
                                                        myIdKhachHang,
                                                        txtTenKhachHang.Text,
                                                        txtDiaChi.Text,
                                                        txtSDT.Text,
                                                        txtLyDo.Text,
                                                        Convert.ToDecimal(txtSoTien.Text),
                                                        txtVBC.Text,
                                                        txtUser.Text,
                                                        txtGhiChu.Text,
                                                        myId);
                    if (myIdKhachHang == myIdtam)
                    {
                        khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                                            tamtinh - Convert.ToDecimal(txtSoTien.Text),
                                                            myIdKhachHang
                                                            );
                    }
                    else
                    {
                        khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                                        myPhaiThu - Convert.ToDecimal(txtSoTien.Text),
                                                        myIdKhachHang
                                                        );
                        this.khachhangTableAdapter.FillBySearchId(this.qLBHDataSet.khachhang, myIdtam);
                        myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                        tamtinh = myPhaiThu + Convert.ToDecimal(sotien);
                        khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                                            tamtinh,
                                                            myIdtam
                                                            );
                    }
                }
                //
                {
                    AnGroupBox(true);
                    XuLyConTro(true);
                }
                this.phieuthuTableAdapter.Fill(this.qLBHDataSet.phieuthu);
                PrintInvoice();
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            phieuthuBindingSource.CancelEdit();
            ClearForNewRecord();
            dataGridView_hide();
            XuLyConTro(true);
            AnGroupBox(true);
            ReadOnlyTextBox(false);
        }
        
        private void btnKhachHangMoi_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.Show();
        }
        #endregion

        #region Nhóm tham chiếu
        private void CopyData()
        {
            AnGroupBox(false); 
            reportViewerPhieuThu.Visible = false;
            myId = Convert.ToInt32(phieuthuDataGridView.CurrentRow.Cells["idphieuthu"].Value);
            dtpNgayLap.Value = Convert.ToDateTime(phieuthuDataGridView.CurrentRow.Cells["NgayThu"].Value);
            txtSoHieu.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["SoHieu"].Value);
            myIdKhachHang = Convert.ToInt32(phieuthuDataGridView.CurrentRow.Cells["IdKhachHang"].Value);
            myIdtam = myIdKhachHang;
            txtTenKhachHang.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["TenKhachHang"].Value);
            txtDiaChi.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["DiaChiKhachHang"].Value);
            txtSDT.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["SDTKhachHang"].Value);
            this.khachhangTableAdapter.FillBySearchId(this.qLBHDataSet.khachhang, myIdKhachHang);
            myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
            txtLyDo.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["LyDoThu"].Value);
            txtSoTien.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["SoTienThu"].Value);
            tamtinh = myPhaiThu + Convert.ToDecimal(string.Format("{0}", Double.Parse(txtSoTien.Text)));
            txtSoTien.Text = string.Format("{0:n0}", Double.Parse(txtSoTien.Text));
            txtVBC.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["VBC"].Value);
            txtGhiChu.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["GhiChu"].Value);
            txtUser.Text = Convert.ToString(phieuthuDataGridView.CurrentRow.Cells["User"].Value);
            dataGridView_hide();
        }

        private void ClearForNewRecord()
        {
            myId = 0;
            dtpNgayLap.Value = DateTime.Now;
            txtSoHieu.Text = "";
            myIdKhachHang = 0;
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            myPhaiThu = 0;
            txtLyDo.Text = "";
            txtSoTien.Text = "0";
            txtVBC.Text = "";
            txtGhiChu.Text = "";
            txtUser.Text = Common.TenNhanVien;
            tamtinh = 0;
        }

        private Boolean RecordCheckInput()
        {
            string infor = "";
            mySave = true;
            if (txtTenKhachHang.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0
                || txtLyDo.Text.Length == 0 || txtSoHieu.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa chưa được nhập" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (txtTenKhachHang.Text.Length > 300 || txtDiaChi.Text.Length > 300 || txtSDT.Text.Length > 30 || txtLyDo.Text.Length > 300
                || txtGhiChu.Text.Length > 300 || txtSoHieu.Text.Length > 10)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa đã vượt quá số lượng ký tự quy định" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (Convert.ToInt32(myIdKhachHang) < 1)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Thông tin khách hàng không tồn tại" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            return mySave;
        }

        private void PrintInvoice()
        {
            this.DataTableReportPhieuThuTableAdapter.FillBy(this.DataSetReport.DataTableReportPhieuThu, myId);
            this.reportViewerPhieuThu.RefreshReport();
            //reportViewerPhieuThu.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerPhieuThu.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerPhieuThu.PrintDialog();
                //reportViewerPhieuThu.Clear();
                reportViewerPhieuThu.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        #region Nhóm AutoNumber
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
        #endregion

        #region Nhóm KeyDown
        private void txtTenKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                dtpNgayLap.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (khachhangDataGridView.Visible == true)
                {
                    myTextBox = txtTenKhachHang;
                    khachhangDataGridView.Select();
                    SendKeys.Send("{DOWN}");
                }
                else
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
                txtLyDo.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtLyDo.Select();
            }
        }
        
        private void txtLyDo_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSDT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (phimtatDataGridView.Visible == true)
                {
                    myTextBox = txtLyDo;
                    phimtatDataGridView.Select();
                }
                else
                    txtSoTien.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtSoTien.Select();
            }
        }

        private void txtSoTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtLyDo.Select();
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
                txtSoTien.Select();
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

        #region Nhóm tìm kiếm khách hàng
        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKhachHang.Text.Trim().Length == 0)
                {
                    khachhangDataGridView.Visible = false;
                }
                else
                {
                    khachhangDataGridView.Visible = true;
                    khachhangDataGridView.DataSource = khachhangBindingSource;
                    this.khachhangTableAdapter.FillBySearch(this.qLBHDataSet.khachhang, "%" + txtTenKhachHang.Text + "%");
                    khachhangDataGridView.Width = 375;
                    myCount = khachhangDataGridView.RowCount;
                    if (myCount >= 5)
                    {
                        khachhangDataGridView.Height = 90;
                    }
                    else
                    {
                        khachhangDataGridView.Height = myCount * 23;
                    }
                    khachhangDataGridView.Left = groupBoxLeftPosion + txtTenKhachHang.Left + txtTenKhachHang.Text.Trim().Length * 55 / 10 + 20;
                    khachhangDataGridView.Top = groupBoxTopPosion + txtTenKhachHang.Top + 30;
                }
            }
            catch
            {

            }
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (khachhangDataGridView.Visible == true && khachhangDataGridView.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtTenKhachHang.Text.ToString().Trim().Length > 0)
                    {
                        myIdKhachHang = Convert.ToInt32(khachhangDataGridView.CurrentRow.Cells["idkhachhang1"].Value);
                        txtTenKhachHang.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["TenKhachHang1"].Value);
                        txtDiaChi.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                        txtSDT.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                        myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                        dataGridView_hide();
                        txtLyDo.Select();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtLyDo.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void dgwKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (khachhangDataGridView.CurrentRow != null)
            {
                myIdKhachHang = Convert.ToInt32(khachhangDataGridView.CurrentRow.Cells["idkhachhang1"].Value);
                txtTenKhachHang.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["TenKhachHang1"].Value);
                txtDiaChi.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                txtSDT.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                dataGridView_hide();
                txtLyDo.Select();
            }
        }

        private void dgvKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (khachhangDataGridView.CurrentRow != null)
                {
                    myIdKhachHang = Convert.ToInt32(khachhangDataGridView.CurrentRow.Cells["idkhachhang1"].Value);
                    txtTenKhachHang.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["TenKhachHang1"].Value);
                    txtDiaChi.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                    txtSDT.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                    myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                    dataGridView_hide();
                    txtLyDo.Select();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }
        #endregion

        #region Nhóm tìm phím tắt
        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtLyDo.Text.Trim().Length == 0)
                {
                    phimtatDataGridView.Visible = false;
                }
                else
                {
                    //object[] Myvar = { txtLyDo.Text.Trim(), "PhieuThu" };
                    phimtatDataGridView.Visible = true;
                    phimtatDataGridView.DataSource = phimtatBindingSource;
                    this.phimtatTableAdapter.FillBySearch(this.qLBHDataSet.phimtat, "%" + txtLyDo.Text + "%", "PhieuThu");
                    phimtatDataGridView.Width = 375;
                    myCount = phimtatDataGridView.RowCount;
                    if (myCount >= 5)
                    {
                        phimtatDataGridView.Height = 92;
                    }
                    else
                    {
                        phimtatDataGridView.Height = myCount * 23;
                    }
                    phimtatDataGridView.Left = groupBoxLeftPosion + txtLyDo.Left + txtLyDo.Text.Trim().Length * 55 / 10 + 20;
                    phimtatDataGridView.Top = groupBoxTopPosion + txtLyDo.Top + 30;
                }
            }
            catch
            {

            }
        }

        private void txtLyDo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
                if (phimtatDataGridView.Visible == true)
                {
                    if (e.KeyChar == 13 && phimtatDataGridView.CurrentRow != null)// && dgvWpersonName.Visible == true)
                    {
                        this.txtLyDo.Text = Convert.ToString(phimtatDataGridView.CurrentRow.Cells["Name"].Value);
                        phimtatDataGridView.Visible = false;
                    }
                    if (e.KeyChar == 13 && phimtatDataGridView.CurrentRow == null && txtLyDo.Text.Trim().Length > 0)
                    {
                        string infor = "";
                        infor += "Bạn muốn lưu : " + txtLyDo.Text.Trim() + "\n";
                        infor += "vào hệ thống để sử dụng cho lần sau?" + "\n";
                        infor += "\n";
                        infor += "\n";
                        infor += "napa500.com";

                        if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            phimtatTableAdapter.InsertPhimTat(txtLyDo.Text, "PhieuThu");
                        }
                        else
                        {
                            txtSoTien.Select();
                        }

                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtSoTien.Select();
                }
            }
            catch
            {

            }
        }

        private void phimtatDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (phimtatDataGridView.CurrentRow != null)
            {
                this.txtLyDo.Text = Convert.ToString(phimtatDataGridView.CurrentRow.Cells["Name"].Value);
                dataGridView_hide();
                txtSoTien.Select();
            }
        }

        private void phimtatDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (phimtatDataGridView.CurrentRow != null)
                {
                    this.txtLyDo.Text = Convert.ToString(phimtatDataGridView.CurrentRow.Cells["Name"].Value);
                    dataGridView_hide();
                    txtSoTien.Select();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }
        #endregion

        private void txtSearchPhieuThu_TextChanged(object sender, EventArgs e)
        {
            this.phieuthuTableAdapter.FillBySearch(this.qLBHDataSet.phieuthu, "%" + txtSearchPhieuThu.Text + "%");
        }

        private void txtSoTien_Leave(object sender, EventArgs e)
        {
            if (this.txtSoTien.Text.Trim().Length != 0)
                txtSoTien.Text = string.Format("{0:n0}", Double.Parse(txtSoTien.Text));
            else txtSoTien.Text = "0";

        }

        private void DateTimePickerB_NgayLap_ValueChanged(object sender, EventArgs e)
        {
            lableB_NgayHT.Text = "Ngày " + Convert.ToString(dtpNgayLap.Value.Day + 100).Substring(1, 2) + " tháng " + Convert.ToString(dtpNgayLap.Value.Month + 100).Substring(1, 2) + " năm " + Convert.ToString(dtpNgayLap.Value.Year);
            txtTenKhachHang.Select();
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoTien.Text.Length != 0)
                {
                    double st = double.Parse(txtSoTien.Text.Replace(",", ""));
                    txtSoTien.Text = st.ToString("###,###,###,##0");
                    txtSoTien.Select(txtSoTien.TextLength, 0);
                }
                //
                txtVBC.Text = Common.So_chu(Convert.ToDouble(txtSoTien.Text));
            }
            catch { }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
