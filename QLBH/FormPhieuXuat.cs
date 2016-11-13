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
    public partial class FormPhieuXuat : Form
    {
        int group = 0;
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int myIdPhieuXuat;
        int myIdPhieuThu = 0;
        int myIdKhachHang = 0;
        int myIdHangHoa = 0;
        int myIdNhomHang = 0;
        int myHuy = 0;
        decimal myPhaiThu;
        decimal myTonKho;
        decimal ttien = 0;
        decimal sl = 0;
        decimal dgia = 0;
        decimal mySoLuongNo = 0;
        string myNo = "-";
        string myTra= "-";
        string myTru = "-";
        string myTrangThai = "-";
        Boolean myAdd, myEdit, myDelete, mySave;

        public FormPhieuXuat()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private Form GetOpenedForm(string formName)
        {
            Form form = null;
            Form[] forms = FormMenu.ActiveForm.MdiChildren;//this.MdiChildren;

            foreach (Form f in forms)
            {
                if (f.Name == formName)
                {
                    form = f;
                    break;
                }
            }
            return form;
        }

        private void CloseOpenedForm(string formName)
        {
            Form[] forms = FormMenu.ActiveForm.MdiChildren;

            foreach (Form myForm in forms)
            {
                if (myForm.Name == formName)
                {
                    myForm.Close();
                }
            }
        }

        private void phieuchiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuxuathangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormPhieuChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.DataTableReportPhieuXuat' table. You can move, or remove it, as needed.
            this.DataTableReportPhieuXuatTableAdapter.Fill(this.DataSetReport.DataTableReportPhieuXuat);
           // TODO: This line of code loads data into the 'qLBHDataSet.phieuxuathang' table. You can move, or remove it, as needed.
            this.phieuxuathangTableAdapter.Fill(this.qLBHDataSet.phieuxuathang);
            // TODO: This line of code loads data into the 'qLBHDataSet.khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qLBHDataSet.khachhang);
            // TODO: This line of code loads data into the 'qLBHDataSet.hanghoa' table. You can move, or remove it, as needed.
            this.hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
            reportViewerPhieuXuat.Visible = false;
            gbxPhieuXuat.Enabled = false;
            dataGridView_hide();
            XuLyConTro(true);
            gbxPhieuXuatCT.Visible = false;
            ctphieuxuatDataGridView.Visible = true;
            this.reportViewerPhieuXuat.RefreshReport();
        }

        private void XuLyConTro(bool b)
        {
            btnThem.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = !b;
        }

        private void dataGridView_hide()
        {
            this.khachhangDataGridView.Visible = false;
            this.hanghoaDataGridView.Visible = false;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            try
            {
                int centerF = this.Width / 2;
                gbxPhieuXuat.Left = centerF - (gbxPhieuXuat.Width / 2);
                gbxPhieuXuat.Top = this.Top + 40;
                groupBoxLeftPosion = gbxPhieuXuat.Left;
                groupBoxTopPosion = gbxPhieuXuat.Top;
            }
            catch
            {
            }
        }

        #region AutoNumber
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

        #region Button Click Phiếu Nhập
        private void btnThem_Click(object sender, EventArgs e)
        {
            reportViewerPhieuXuat.Visible = false;
            gbxPhieuXuat.Enabled = true;
            XuLyConTro(false);
            dataGridView_hide();
            ClearForNewRecord();
            //
            int sh = (int)phieuxuathangTableAdapter.FillBySearchIdMax();
            sh = sh + 100000001;
            string a = sh.ToString();
            txtSoHieu.Text = "PXK-" + a.Substring(2);
            //
            txtTenKhachHang.Select();
            myAdd = true;
            //
            //this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, 0);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (RecordCheckInput() == true && RecordCheckInputThemCT() == true)
            {
                if (txtThanhToan.Text != "0")
                {
                    LuuPhieuThu();
                }
                LuuPhieuNhap();
                PrintInvoice();
                //
                {
                    /*string infor = "";
                    infor += "Bạn có muốn tiếp tục?" + "\n";
                    infor += "\n";
                    infor += "\n";
                    if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ClearForNewRecord();
                        int sh = (int)phieuxuathangTableAdapter.FillBySearchIdMax();
                        sh = sh + 100000001;
                        string a = sh.ToString();
                        txtSoHieu.Text = "PXK-" + a.Substring(2);
                        txtTenKhachHang.Select();
                    }
                    else*/
                    {
                        gbxPhieuXuat.Enabled = false;
                        XuLyConTro(true);
                    }
                }
                this.phieuxuathangTableAdapter.Fill(this.qLBHDataSet.phieuxuathang);
                this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, 0);
            }
        }

        private void PrintInvoice()
        {
            this.DataTableReportPhieuXuatTableAdapter.FillBy(this.DataSetReport.DataTableReportPhieuXuat, myIdPhieuXuat);
            this.reportViewerPhieuXuat.RefreshReport();
            //reportViewerPhieuXuat.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerPhieuXuat.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerPhieuXuat.PrintDialog();
                reportViewerPhieuXuat.Clear();
                reportViewerPhieuXuat.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (myHuy == 0)
            {
                phieuxuathangBindingSource.CancelEdit();
                //
                ClearForNewRecord();
                gbxPhieuXuat.Enabled = false;
                dataGridView_hide();
                XuLyConTro(true);
                this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, 0);
            }
            else
            {
                this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, myIdPhieuXuat);
                if (ctphieuxuatDataGridView.RowCount == 0)
                {
                    phieuxuathangTableAdapter.DeletePhieuXuat(myIdPhieuXuat);
                    //
                    ClearForNewRecord();
                    gbxPhieuXuat.Enabled = false;
                    dataGridView_hide();
                    XuLyConTro(true);
                    this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, 0);
                }
                else
                {
                    string infor = "";
                    infor += "Bạn có muốn hủy phiếu xuất này?" + "\n";
                    infor += "\n";
                    infor += "\n";
                    if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, myIdPhieuXuat);
                        // Tính lại tiền phải trả Nhà Cung Cấp
                        this.khachhangTableAdapter.FillBySearchId(this.qLBHDataSet.khachhang, myIdKhachHang);
                        myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                        //
                        //phieuxuathangBindingSource.RemoveCurrent();
                        //
                        khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                                                    myPhaiThu - Convert.ToDecimal(txtTongTien.Text),
                                                                    myIdKhachHang
                                                                    );
                        // Tính lại tồn kho hàng hóa
                        for (int i = 0; i < ctphieuxuatDataGridView.RowCount; i++)
                        {
                            myIdHangHoa = Convert.ToInt32(ctphieuxuatDataGridView.Rows[i].Cells["IdHangHoa1"].Value);
                            this.hanghoaTableAdapter.FillBySearchId(this.qLBHDataSet.hanghoa, myIdHangHoa);
                            myTonKho = Convert.ToDecimal(hanghoaDataGridView.CurrentRow.Cells["TonKho"].Value);
                            decimal soluong = Convert.ToDecimal(ctphieuxuatDataGridView.Rows[i].Cells["SoLuong1"].Value);
                            string no = ctphieuxuatDataGridView.Rows[i].Cells["No1"].Value.ToString();
                            string tra = ctphieuxuatDataGridView.Rows[i].Cells["Tra1"].Value.ToString();
                            string tru = ctphieuxuatDataGridView.Rows[i].Cells["Tru1"].Value.ToString();
                            //
                            if (tra == "Trả" || tru == "Trừ")
                            {
                                DateTime ngay = Convert.ToDateTime(ctphieuxuatDataGridView.Rows[i].Cells["GhiGhu1"].Value);
                                int IdCTPX = (int)nohangTableAdapter.FillBySearchIdCTPhieuXuat(ngay, myIdKhachHang, myIdHangHoa);
                                phieuxuathangctTableAdapter.UpdateSoLuongNo(soluong,
                                                                            IdCTPX);
                            }
                            if (no != "Nợ" && tru != "Trừ")
                            {
                                hanghoaTableAdapter.UpdateTonKhoHangHoa(
                                                                           myTonKho + soluong,
                                                                            myIdHangHoa
                                                                            );
                            }
                            hanghoaTableAdapter.Update(qLBHDataSet.hanghoa);
                        }
                        phieuxuathangctTableAdapter.DeleteCTPhieuXuat(myIdPhieuXuat);
                        phieuxuathangctTableAdapter.Update(qLBHDataSet.phieuxuathangct);
                        this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, 0);
                        //
                        phieuxuathangTableAdapter.DeletePhieuXuat(myIdPhieuXuat);
                        //
                        ClearForNewRecord();
                        gbxPhieuXuat.Enabled = false;
                        dataGridView_hide();
                        XuLyConTro(true);
                        this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, 0);
                    }
                }
            }
        }
        #endregion

        #region Button Click Chi Tiết Phiếu Nhập
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (RecordCheckInputThemCT() == true)
            {
                // Tạo phiếu nhập hàng mới
                if (myAdd == true)
                {
                    phieuxuathangTableAdapter.InsertPhieuXuat(dtpNgayLap.Value,
                                                                txtSoHieu.Text,
                                                                myIdKhachHang,
                                                                txtTenKhachHang.Text,
                                                                txtDiaChi.Text,
                                                                txtSDT.Text,
                                                                Convert.ToDecimal(txtPhaiThu.Text),                                                                
                                                                Convert.ToDecimal(txtTienHang.Text),                                                                
                                                                Convert.ToDecimal(txtGiamGia.Text),
                                                                Convert.ToDecimal(txtTongTien.Text),
                                                                txtVBC.Text,
                                                                txtUser.Text,
                                                                myTrangThai,
                                                                Convert.ToDecimal(txtThanhToan.Text),
                                                                myIdPhieuThu
                                                                );
                    myIdPhieuXuat = (int)phieuxuathangTableAdapter.FillBySearchIdMax();
                    txtTenKhachHang.ReadOnly = true;
                }
                //
                HienGroupBoxCT(true);
                btnThem.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
                //
                ClearForNewRecordCT();
                txtMaHang.Select();
                //
                myHuy = 1;
                //this.phieuxuathangTableAdapter.Fill(this.qLBHDataSet.phieuxuathang);
            }
        }

        private void HienGroupBoxCT(bool b)
        {
            gbxPhieuXuatCT.Visible = b;
            dataGridViewShow.Visible = b;
            ctphieuxuatDataGridView.Visible = !b;
            //
            btnXoaCT.Enabled = !b;
            btnThemCT.Enabled = !b;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string infor = "";
            infor += "Bạn có muốn xóa chi tiết này?" + "\n";
            infor += "\n";
            infor += "\n";
            if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ctphieuxuatDataGridView.RowCount > 0)
                {
                    myIdHangHoa = Convert.ToInt32(ctphieuxuatDataGridView.CurrentRow.Cells["IdHangHoa1"].Value);
                    this.hanghoaTableAdapter.FillBySearchId(this.qLBHDataSet.hanghoa, myIdHangHoa);
                    myTonKho = Convert.ToDecimal(hanghoaDataGridView.CurrentRow.Cells["TonKho"].Value);
                    decimal soluong = Convert.ToDecimal(ctphieuxuatDataGridView.CurrentRow.Cells["SoLuong1"].Value);
                    decimal thanhtien = Convert.ToDecimal(ctphieuxuatDataGridView.CurrentRow.Cells["ThanhTien1"].Value);
                    decimal chietkhau = Convert.ToDecimal(ctphieuxuatDataGridView.CurrentRow.Cells["ChietKhau1"].Value);
                    string no = ctphieuxuatDataGridView.CurrentRow.Cells["No1"].Value.ToString();
                    string tra = ctphieuxuatDataGridView.CurrentRow.Cells["Tra1"].Value.ToString();
                    string tru = ctphieuxuatDataGridView.CurrentRow.Cells["Tru1"].Value.ToString();
                    //
                    if (tra == "Trả" || tru == "Trừ")
                    {
                        DateTime ngay = Convert.ToDateTime(ctphieuxuatDataGridView.CurrentRow.Cells["GhiGhu1"].Value);
                        int IdCTPX = (int)nohangTableAdapter.FillBySearchIdCTPhieuXuat(ngay, myIdKhachHang, myIdHangHoa);
                        phieuxuathangctTableAdapter.UpdateSoLuongNo(soluong,
                                                                    IdCTPX);
                    }
                    //
                    phieuxuathangctBindingSource.RemoveCurrent();
                    phieuxuathangctTableAdapter.Update(qLBHDataSet.phieuxuathangct);
                    // Cập nhật kho hàng
                    if (no != "Nợ" && tru != "Trừ")
                    {
                        hanghoaTableAdapter.UpdateTonKhoHangHoa(
                                                                   myTonKho + soluong,
                                                                    myIdHangHoa
                                                                    );
                        hanghoaTableAdapter.Update(qLBHDataSet.hanghoa);
                    }
                    // Cập nhật phải trả nhà cung cấp
                    this.khachhangTableAdapter.FillBySearchId(this.qLBHDataSet.khachhang, myIdKhachHang);
                    myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                    khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                                    myPhaiThu - thanhtien + chietkhau,
                                                    myIdKhachHang
                                                    );
                    //
                    TinhTongTien();
                    //
                    LuuPhieuNhap();
                }
            }
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (RecordCheckInputCT() == true)
            {
                if(ckbNo.Checked == true)
                {
                    myNo = "Nợ";
                    mySoLuongNo = Convert.ToDecimal(txtSoLuong.Text);
                }
                phieuxuathangctTableAdapter.InsertCTPhieuXuat( myIdPhieuXuat,
                                                               myIdHangHoa,
                                                               txtMaHang.Text,
                                                               txtTenHang.Text,
                                                               txtDVT.Text,
                                                               txtKhoHang.Text,
                                                               myIdNhomHang,
                                                               txtNhomHang.Text,
                                                               Convert.ToDecimal(txtTonKho.Text),
                                                               Convert.ToDecimal(txtSoLuong.Text),
                                                               Convert.ToDecimal(txtDonGia.Text),
                                                               Convert.ToDecimal(ttien),
                                                               Convert.ToDecimal(txtPhanTram.Text),
                                                               Convert.ToDecimal(txtChietKhau.Text),
                                                               myNo,
                                                               "-",
                                                               "-",
                                                               txtGhiChu.Text,
                                                               mySoLuongNo
                                                               );
                // Cập nhật tồn kho
                if (ckbNo.Checked == false)
                {
                    hanghoaTableAdapter.UpdateTonKhoHangHoa(Convert.ToDecimal(txtTonKho.Text) - Convert.ToDecimal(txtSoLuong.Text),
                                                            myIdHangHoa);
                }
                // Cập nhật đơn giá
                hanghoaTableAdapter.UpdateGiaXuatHangHoa(Convert.ToDecimal(txtDonGia.Text),
                                                            myIdHangHoa);
                //
                this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, myIdPhieuXuat);
                this.hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
                // Cập nhật phải thu khách hàng
                this.khachhangTableAdapter.FillBySearchId(this.qLBHDataSet.khachhang, myIdKhachHang);
                myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                                myPhaiThu + Convert.ToDecimal(txtThanhTien.Text) - Convert.ToDecimal(txtChietKhau.Text),
                                                myIdKhachHang
                                                );
                //
                string infor = "";
                infor += "Bạn có muốn thêm hàng hóa?" + "\n";
                infor += "\n";
                infor += "\n";
                if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ClearForNewRecordCT();
                    txtMaHang.Select();
                }
                else
                {
                    HienGroupBoxCT(false);
                    XuLyConTro(false);
                    txtThanhToan.Select();
                }
                TinhTongTien();
                //
                LuuPhieuNhap();
                //
                myAdd = false;
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            HienGroupBoxCT(false);
            XuLyConTro(false);
            btnLuu.Select();
            this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, myIdPhieuXuat);
            TinhTongTien();
            myAdd = false;
            txtThanhToan.Select();
        }
        #endregion

        #region KeyDown Phiếu Nhập
        private void txtSoHieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                dtpNgayLap.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtTenKhachHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtTenKhachHang.Select();
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
                txtPhaiThu.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtPhaiThu.Select();
            }
        }
        #endregion

        #region KeyDown Chi Tiết Phiếu Nhập
        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtMaHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtDonGia.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtDonGia.Select();
            }
        }

        private void txtDonGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSoLuong.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtThanhTien.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtThanhTien.Select();
            }
        }

        private void txtThanhTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtDonGia.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtPhanTram.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtPhanTram.Select();
            }
        }

        private void txtPhanTram_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtThanhTien.Select();
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

        private void txtChietKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtPhanTram.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                btnLuuCT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnLuuCT.Select();
            }
        }
        #endregion

        #region Leave Chi Tiết Phiếu Nhập
        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (this.txtSoLuong.Text.Trim().Length != 0)
            {
                if (Convert.ToDecimal(string.Format("{0}", Double.Parse("0" + txtSoLuong.Text))) <= Convert.ToDecimal(string.Format("{0}", Double.Parse("0" + txtTonKho.Text))))
                {
                    txtSoLuong.Text = string.Format("{0:n0}", Double.Parse("0" + txtSoLuong.Text));
                }
                else
                {
                    string infor = "";
                    infor += "Số lượng trong kho không đủ" + "\n";
                    infor += "Bạn có muốn ghi nợ?" + "\n";
                    infor += "\n";
                    infor += "\n";
                    if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ckbNo.Checked = true;
                    }
                    else
                    {
                        ckbNo.Checked = false;
                        txtSoLuong.Select();
                    }
                }
            }
            else txtSoLuong.Text = "0";
            //txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            txtPhanTram.Text = "0";
            txtChietKhau.Text = "0"; 
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            txtSoLuong.Text = string.Format("{0}", Double.Parse("0" + txtSoLuong.Text));
            txtDonGia.Text = string.Format("{0}", Double.Parse("0" + txtDonGia.Text));
            sl = Convert.ToDecimal(string.Format("{0}", Double.Parse("0" + txtSoLuong.Text)));
            dgia = Convert.ToDecimal(string.Format("{0}", Double.Parse("0" + txtDonGia.Text)));
            ttien = sl * dgia;
            txtThanhTien.Text = ttien.ToString();
            if (this.txtDonGia.Text.Trim().Length != 0)
                txtDonGia.Text = string.Format("{0:n0}", Double.Parse("0" + txtDonGia.Text));
            else txtDonGia.Text = "0";
            if (this.txtThanhTien.Text.Trim().Length != 0)
                txtThanhTien.Text = string.Format("{0:n0}", Double.Parse("0" + txtThanhTien.Text));
            else txtThanhTien.Text = "0";
            txtPhanTram.Text = "0";
            txtChietKhau.Text = "0"; 
        }

        private void txtThanhTien_Leave(object sender, EventArgs e)
        {
            txtSoLuong.Text = string.Format("{0}", Double.Parse("0" + txtSoLuong.Text));
            txtThanhTien.Text = string.Format("{0}", Double.Parse("0" + txtThanhTien.Text));
            sl = Convert.ToDecimal(string.Format("{0}", Double.Parse("0" + txtSoLuong.Text)));
            ttien = Convert.ToDecimal(string.Format("{0}", Double.Parse("0" + txtThanhTien.Text)));
            if (sl != 0)
            {
                dgia = ttien / sl;
            }
            txtDonGia.Text = dgia.ToString();
            if (this.txtDonGia.Text.Trim().Length != 0)
                txtDonGia.Text = string.Format("{0:n0}", Double.Parse("0" + txtDonGia.Text));
            else txtDonGia.Text = "0";
            if (this.txtThanhTien.Text.Trim().Length != 0)
                txtThanhTien.Text = string.Format("{0:n0}", Double.Parse("0" + txtThanhTien.Text));
            else txtThanhTien.Text = "0";
            txtPhanTram.Text = "0";
            txtChietKhau.Text = "0"; 
        }

        private void txtPhanTram_Leave(object sender, EventArgs e)
        {
            if (this.txtPhanTram.Text.Trim().Length != 0)
            {
                txtThanhTien.Text = string.Format("{0}", Double.Parse("0" + txtThanhTien.Text));
                decimal ck = (Convert.ToDecimal(string.Format("{0}", Double.Parse("0" + txtThanhTien.Text))) * Convert.ToDecimal(string.Format("{0}", Double.Parse("0" + txtPhanTram.Text)))) / 100;
                txtChietKhau.Text = ck.ToString();
                txtPhanTram.Text = string.Format("{0:n0}", Double.Parse("0" + txtPhanTram.Text));
                txtChietKhau.Text = string.Format("{0:n0}", Double.Parse("0" + txtChietKhau.Text));
                txtThanhTien.Text = string.Format("{0:n0}", Double.Parse("0" + txtThanhTien.Text));
            }
            else
            {
                txtPhanTram.Text = "0";
                txtChietKhau.Text = "0";
            }
        }

        private void txtChietKhau_Leave(object sender, EventArgs e)
        {
            if (this.txtChietKhau.Text.Trim().Length != 0)
            {
                txtChietKhau.Text = string.Format("{0:n0}", Double.Parse("0" + txtChietKhau.Text));
                txtPhanTram.Text = "0";
            }
            else
            {
                txtPhanTram.Text = "0";
                txtChietKhau.Text = "0";
            }
        }
        #endregion

        #region Check Input + Clear For New
        private Boolean RecordCheckInputThemCT()
        {
            string infor = "";
            mySave = true;
            if (txtTenKhachHang.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0
                || txtPhaiThu.Text.Length == 0 || txtSoHieu.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa chưa được nhập" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (txtTenKhachHang.Text.Length > 300 || txtDiaChi.Text.Length > 300 || txtSDT.Text.Length > 30 || txtSoHieu.Text.Length > 12)
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
                infor += "Thông tin nhà cung cấp không tồn tại" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            return mySave;
        }

        private Boolean RecordCheckInputCT()
        {
            string infor = "";
            mySave = true;
            if (txtTenHang.Text.Length == 0 || txtSoLuong.Text.Length == 0 || txtDonGia.Text.Length == 0
                || txtThanhTien.Text.Length == 0 || txtPhanTram.Text.Length == 0 || txtChietKhau.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa chưa được nhập" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (txtTenHang.Text.Length > 300)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa đã vượt quá số lượng ký tự quy định" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (Convert.ToInt32(myIdHangHoa) < 1)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Thông tin hàng hóa không tồn tại" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            return mySave;
        }

        private Boolean RecordCheckInput()
        {
            string infor = "";
            mySave = true;
            if (ctphieuxuatDataGridView.RowCount < 1)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Chưa có chi tiết phiếu nhập hàng" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            return mySave;
        }

        private void ClearForNewRecord()
        {
            myIdPhieuXuat = 0;
            dtpNgayLap.Value = DateTime.Now;
            txtSoHieu.Text = "";
            myIdKhachHang = 0;
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            myPhaiThu = 0;
            txtPhaiThu.Text = "";
            txtTienHang.Text = "0";
            txtGiamGia.Text = "0";
            txtThanhToan.Text = "0";
            txtCanThanhToan.Text = "0";
            txtTongTien.Text = "0";
            txtConNo.Text = "0";
            txtVBC.Text = Common.So_chu(Convert.ToDouble(txtConNo.Text));
            txtUser.Text = Common.TenNhanVien;
            txtTenKhachHang.ReadOnly = false;
        }

        private void ClearForNewRecordCT()
        {
            //myIdPhieuNhap = 0;
            myIdHangHoa = 0;
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtDVT.Text = "";
            txtKhoHang.Text = "";
            myIdNhomHang = 0;
            txtNhomHang.Text = "";
            txtTonKho.Text = "0";
            txtSoLuong.Text = "0";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            txtPhanTram.Text = "0";
            txtChietKhau.Text = "0";
            txtGhiChu.Text = "";
            ckbNo.Checked = false;
            myNo = "-";
            myTra = "-";
            myTru = "-";
            mySoLuongNo = 0;
        }
        #endregion

        #region Search Nhà Cung Cấp
        private void txtTenNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSoHieu.Select();
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

        private void txtTenNhaCC_TextChanged(object sender, EventArgs e)
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

        private void txtTenNhaCC_KeyPress(object sender, KeyPressEventArgs e)
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
                        txtPhaiThu.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                        txtPhaiThu.Text = string.Format("{0:n0}", Double.Parse(txtPhaiThu.Text));
                        dataGridView_hide();
                        btnThemCT.Select();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtPhaiThu.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void dgwNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (khachhangDataGridView.CurrentRow != null)
            {
                myIdKhachHang = Convert.ToInt32(khachhangDataGridView.CurrentRow.Cells["idkhachhang1"].Value);
                txtTenKhachHang.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["TenKhachHang1"].Value);
                txtDiaChi.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                txtSDT.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                txtPhaiThu.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                txtPhaiThu.Text = string.Format("{0:n0}", Double.Parse(txtPhaiThu.Text));
                dataGridView_hide();
                btnThemCT.Select();
            }
        }

        private void dgvNhaCC_KeyDown(object sender, KeyEventArgs e)
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
                    txtPhaiThu.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                    txtPhaiThu.Text = string.Format("{0:n0}", Double.Parse(txtPhaiThu.Text));
                    dataGridView_hide();
                    btnThemCT.Select();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }
        #endregion

        #region Seach Hàng Hóa
        private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                btnHuyCT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (hanghoaDataGridView.Visible == true)
                {
                    myTextBox = txtMaHang;
                    hanghoaDataGridView.Select();
                    SendKeys.Send("{DOWN}");
                }
                else
                    txtSoLuong.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtSoLuong.Select();
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHang.Text.Trim().Length == 0)
                {
                    hanghoaDataGridView.Visible = false;
                }
                else
                {
                    hanghoaDataGridView.Visible = true;
                    hanghoaDataGridView.DataSource = hanghoaBindingSource;
                    this.hanghoaTableAdapter.FillBySearchTenHang(this.qLBHDataSet.hanghoa, "%" + txtMaHang.Text + "%");
                    hanghoaDataGridView.Width = 405;
                    myCount = hanghoaDataGridView.RowCount;
                    if (myCount >= 5)
                    {
                        hanghoaDataGridView.Height = 90;
                    }
                    else
                    {
                        hanghoaDataGridView.Height = myCount * 23;
                    }
                    hanghoaDataGridView.Left = groupBoxLeftPosion + txtMaHang.Left + txtMaHang.Text.Trim().Length * 55 / 10 + 20;
                    hanghoaDataGridView.Top = groupBoxTopPosion + txtMaHang.Top + 30;
                }
            }
            catch
            {

            }
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (hanghoaDataGridView.Visible == true && hanghoaDataGridView.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtMaHang.Text.ToString().Trim().Length > 0)
                    {
                        myIdHangHoa = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["idHangHoa"].Value);
                        txtMaHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["MaHang"].Value);
                        txtTenHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TenHang"].Value);
                        txtDVT.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["DVT"].Value);
                        txtKhoHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["KhoHang"].Value);
                        myIdNhomHang = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["IdNhomHang"].Value);
                        txtNhomHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TenNhomHang"].Value);
                        txtTonKho.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TonKho"].Value);
                        myTonKho = Convert.ToDecimal(txtTonKho.Text);
                        txtTonKho.Text = string.Format("{0:n0}", Double.Parse(txtTonKho.Text));
                        txtDonGia.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["GiaXuat"].Value);
                        txtDonGia.Text = string.Format("{0:n0}", Double.Parse(txtDonGia.Text));
                        dataGridView_hide();
                        txtSoLuong.Select();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtSoLuong.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void hanghoaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (hanghoaDataGridView.CurrentRow != null)
            {
                myIdHangHoa = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["idHangHoa"].Value);
                txtMaHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["MaHang"].Value);
                txtTenHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TenHang"].Value);
                txtDVT.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["DVT"].Value);
                txtKhoHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["KhoHang"].Value);
                myIdNhomHang = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["IdNhomHang"].Value);
                txtNhomHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TenNhomHang"].Value);
                txtTonKho.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TonKho"].Value);
                myTonKho = Convert.ToDecimal(txtTonKho.Text);
                txtTonKho.Text = string.Format("{0:n0}", Double.Parse(txtTonKho.Text));
                txtDonGia.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["GiaXuat"].Value);
                txtDonGia.Text = string.Format("{0:n0}", Double.Parse(txtDonGia.Text));
                dataGridView_hide();
                txtSoLuong.Select();
            }
        }

        private void hanghoaDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (hanghoaDataGridView.CurrentRow != null)
                {
                    myIdHangHoa = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["idHangHoa"].Value);
                    txtMaHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["MaHang"].Value);
                    txtTenHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TenHang"].Value);
                    txtDVT.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["DVT"].Value);
                    txtKhoHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["KhoHang"].Value);
                    myIdNhomHang = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["IdNhomHang"].Value);
                    txtNhomHang.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TenNhomHang"].Value);
                    txtTonKho.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["TonKho"].Value);
                    myTonKho = Convert.ToDecimal(txtTonKho.Text);
                    txtTonKho.Text = string.Format("{0:n0}", Double.Parse(txtTonKho.Text));
                    txtDonGia.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["GiaXuat"].Value);
                    txtDonGia.Text = string.Format("{0:n0}", Double.Parse(txtDonGia.Text));
                    dataGridView_hide();
                    txtSoLuong.Select();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }
        #endregion

        private void DateTimePickerB_NgayLap_ValueChanged(object sender, EventArgs e)
        {
            lableB_NgayHT.Text = "Ngày " + Convert.ToString(dtpNgayLap.Value.Day + 100).Substring(1, 2) + " tháng " + Convert.ToString(dtpNgayLap.Value.Month + 100).Substring(1, 2) + " năm " + Convert.ToString(dtpNgayLap.Value.Year);
            txtSoHieu.Select();
        }
        
        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            txtVBC.Text = Common.So_chu(Convert.ToDouble(txtConNo.Text));
        }
        
        private void TinhTongTien()
        {
            double TH = 0;
            double GG = 0;
            double TT = 0;
            double CTT = 0;
            double CN = 0;
            for (int i = 0; i < ctphieuxuatDataGridView.RowCount; i++)
            {
                TH += Convert.ToDouble(ctphieuxuatDataGridView.Rows[i].Cells["ThanhTien1"].Value);
                GG += Convert.ToDouble(ctphieuxuatDataGridView.Rows[i].Cells["ChietKhau1"].Value);
            }
            TT = TH - GG - Convert.ToDouble(txtThanhToan.Text);
            CTT = TH - GG;
            CN = TT + Convert.ToDouble(txtPhaiThu.Text);
            //
            txtTienHang.Text = TH.ToString();
            txtTienHang.Text = string.Format("{0:n0}", double.Parse(txtTienHang.Text));
            //
            txtGiamGia.Text = GG.ToString();
            txtGiamGia.Text = string.Format("{0:n0}", double.Parse(txtGiamGia.Text));
            //
            txtThanhToan.Text = string.Format("{0:n0}", double.Parse(txtThanhToan.Text));
            //
            txtTongTien.Text = TT.ToString();
            txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
            //
            txtCanThanhToan.Text = CTT.ToString();
            txtCanThanhToan.Text = string.Format("{0:n0}", double.Parse(txtCanThanhToan.Text));
            //
            txtConNo.Text = CN.ToString();
            txtConNo.Text = string.Format("{0:n0}", double.Parse(txtConNo.Text));
        }

        private void LuuPhieuThu()
        {
            int sh = (int)phieuthuTableAdapter.FillBySearchIdSoHieu();
            sh = sh + 100000001;
            string a = sh.ToString();
            string sohieu = "PT-" + a.Substring(2);
            string lydo = "Trả tiền hàng " + lableB_NgayHT.Text;
            string vbc = Common.So_chu(Convert.ToDouble(txtConNo.Text));
            string user = Common.User;
            if (myEdit == false)
            {
                phieuthuTableAdapter.InsertPhieuThu(
                                                    sohieu,
                                                    dtpNgayLap.Value,
                                                    myIdKhachHang,
                                                    txtTenKhachHang.Text,
                                                    txtDiaChi.Text,
                                                    txtSDT.Text,
                                                    lydo,
                                                    Convert.ToDecimal(txtThanhToan.Text),
                                                    vbc,
                                                    user,
                                                    "Auto",
                                                    ""
                                                    );
                myIdPhieuThu = (int)phieuthuTableAdapter.FillBySearchIdSoHieu();
            }
        }

        private void LuuPhieuNhap()
        {
            phieuxuathangTableAdapter.UpdatePhieuXuat(      dtpNgayLap.Value,
                                                            txtSoHieu.Text,
                                                            myIdKhachHang,
                                                            txtTenKhachHang.Text,
                                                            txtDiaChi.Text,
                                                            txtSDT.Text,
                                                            Convert.ToDecimal(txtPhaiThu.Text),
                                                            Convert.ToDecimal(txtTienHang.Text),
                                                            Convert.ToDecimal(txtGiamGia.Text),
                                                            Convert.ToDecimal(txtTongTien.Text),
                                                            txtVBC.Text,
                                                            txtUser.Text,
                                                            myTrangThai,
                                                            Convert.ToDecimal(txtThanhToan.Text),
                                                            myIdPhieuThu,
                                                            myIdPhieuXuat
                                                            );
            // Cập nhật phải trả nhà cung cấp
            this.khachhangTableAdapter.FillBySearchId(this.qLBHDataSet.khachhang, myIdKhachHang);
            myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
            khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                            myPhaiThu - Convert.ToDecimal(txtThanhToan.Text),
                                            myIdKhachHang
                                            );
        }

        private void txtThanhToan_Leave(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                btnThemCT.Select();
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

        private void btnNoCT_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                FormNoHang nohang = new FormNoHang(myIdKhachHang, myIdPhieuXuat);
                nohang.ShowDialog();
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnKhachHangMoi_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.Show();
        }

        private void btnHangHoaMoi_Click(object sender, EventArgs e)
        {
            FormHangHoa hh = new FormHangHoa();
            hh.Show();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length != 0)
            {
                double sl = double.Parse(txtSoLuong.Text.Replace(",", ""));
                txtSoLuong.Text = sl.ToString("###,###,###,##0");
                txtSoLuong.Select(txtSoLuong.TextLength, 0);
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text.Length != 0)
            {
                double dg = double.Parse(txtDonGia.Text.Replace(",", ""));
                txtDonGia.Text = dg.ToString("###,###,###,##0");
                txtDonGia.Select(txtDonGia.TextLength, 0);
            }
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (txtThanhTien.Text.Length != 0)
            {
                double tt = double.Parse(txtThanhTien.Text.Replace(",", ""));
                txtThanhTien.Text = tt.ToString("###,###,###,##0");
                txtThanhTien.Select(txtThanhTien.TextLength, 0);
            }
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (txtThanhToan.Text.Length != 0)
            {
                double tt = double.Parse(txtThanhToan.Text.Replace(",", ""));
                txtThanhToan.Text = tt.ToString("###,###,###,##0");
                txtThanhToan.Select(txtThanhToan.TextLength, 0);
            }
        }

        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                reportViewerPhieuXuat.Visible = false;
                Form form = GetOpenedForm("FormSuaPhieuXuat");
                if (form != null)
                    form.Activate();
                else
                {
                    form = new FormSuaPhieuXuat();
                    form.Show();

                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void ckbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNo.Checked == false)
            {
                txtSoLuong.Text = "0";
                txtSoLuong.Select();
            }
        }

        private void ẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewerPhieuXuat.Visible = false;
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtPhanTram.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                btnLuuCT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnLuuCT.Select();
            }
        }

    }
}
