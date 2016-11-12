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
    public partial class FormSuaPhieuNhap : Form
    {
        int group = 0;
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int myIdPhieuNhap;
        int myIdNhaCC = 0;
        int myIdHangHoa = 0;
        int myIdNhomHang = 0;
        int myHuy = 0;
        decimal myPhaiTra;
        decimal myTonKho;
        decimal tamtinh;
        decimal ttien = 0;
        decimal sl = 0;
        decimal dgia = 0;
        Boolean mySave;

        public FormSuaPhieuNhap()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void phieuchiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieunhaphangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormPhieuChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.DataTableReportPhieuNhap' table. You can move, or remove it, as needed.
            this.DataTableReportPhieuNhapTableAdapter.Fill(this.DataSetReport.DataTableReportPhieuNhap);
            // TODO: This line of code loads data into the 'qLBHDataSet.hanghoa' table. You can move, or remove it, as needed.
            this.hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
            // TODO: This line of code loads data into the 'qLBHDataSet.phieunhaphangct' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLBHDataSet.phieunhaphang' table. You can move, or remove it, as needed.
            this.phieunhaphangTableAdapter.Fill(this.qLBHDataSet.phieunhaphang);
            // TODO: This line of code loads data into the 'qLBHDataSet.nhacungcap' table. You can move, or remove it, as needed.
            this.nhacungcapTableAdapter.Fill(this.qLBHDataSet.nhacungcap);
            // TODO: This line of code loads data into the 'qLBHDataSet.phieuchi' table. You can move, or remove it, as needed.
            dataGridView_hide();
            XuLyConTro(true);
            HienGroupBox(false);
            gbxPhieuNhapCT.Visible = false;
            gbxPhieuNhap.Visible = false;
            ctphieunhapDataGridView.Visible = true;
        }

        private void XuLyConTro(bool b)
        {
            btnXemPhieu.Enabled = btnXoa.Enabled = btnSua.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = !b;
        }

        private void HienGroupBox(bool b)
        {
            gbxPhieuNhap.Visible = b;
            phieunhapDataGridView.Visible = txtSearchPhieuNhap.Visible = !b;
        }

        private void ReadOnlyTextBox(bool b)
        {
            dtpNgayLap.Visible = !b;
            txtUser.ReadOnly = b;
            //
            btnThemCT.Enabled = btnXoaCT.Enabled = b;
            ctphieunhapDataGridView.ReadOnly = !b;
            //
            btnThemCT.Enabled = btnXoaCT.Enabled = !b;
            //
            btnXemPhieu.Enabled = btnSua.Enabled = btnXoa.Enabled = !b;
            btnHuy.Enabled = b;
        }

        private void dataGridView_hide()
        {
            this.nhacungcapDataGridView.Visible = false;
            this.hanghoaDataGridView.Visible = false;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            try
            {
                int centerF = this.Width / 2;
                gbxPhieuNhap.Left = centerF - (gbxPhieuNhap.Width / 2);
                gbxPhieuNhap.Top = this.Top + 40;
                groupBoxLeftPosion = gbxPhieuNhap.Left;
                groupBoxTopPosion = gbxPhieuNhap.Top;
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
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            XuLyConTro(false);
            CopyData();
            btnThemCT.Select();
        }

        private void CopyData()
        {
            HienGroupBox(true);
            //
            myIdPhieuNhap = Convert.ToInt32(phieunhapDataGridView.CurrentRow.Cells["idphieunhaphang"].Value);
            dtpNgayLap.Value = Convert.ToDateTime(phieunhapDataGridView.CurrentRow.Cells["NgayNhap"].Value);
            txtSoHieu.Text = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["SoHieu"].Value);
            //
            myIdNhaCC = Convert.ToInt32(phieunhapDataGridView.CurrentRow.Cells["IdNhaCC"].Value);
            txtTenNhaCC.Text = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["TenNhaCC"].Value);
            txtDiaChi.Text = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["DiaChiNhaCC"].Value);
            txtSDT.Text = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["SDTNhaCC"].Value);
            txtPhaiTra.Text = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["PhaiTra"].Value);
            txtPhaiTra.Text = string.Format("{0:n0}", Double.Parse(txtPhaiTra.Text));
            //
            this.nhacungcapTableAdapter.FillBySearchId(this.qLBHDataSet.nhacungcap, myIdNhaCC);
            myPhaiTra = Convert.ToDecimal(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
            //
            txtTongTien.Text = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["TongTien"].Value);
            tamtinh = myPhaiTra - Convert.ToDecimal(txtTongTien.Text);
            txtTongTien.Text = string.Format("{0:n0}", Double.Parse(txtTongTien.Text));
            //
            txtVBC.Text = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["VBC"].Value);
            txtUser.Text = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["User"].Value);
            //
            this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, myIdPhieuNhap);
            //
            dataGridView_hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CopyData();
            string infor = "";
            infor += "Bạn có muốn xóa phiếu nhập này?" + "\n";
            infor += "\n";
            infor += "\n";
            if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                myIdPhieuNhap = Convert.ToInt32(phieunhapDataGridView.CurrentRow.Cells["idphieunhaphang"].Value);
                this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, myIdPhieuNhap);
                // Tính lại tiền phải trả Nhà Cung Cấp
                myIdNhaCC = Convert.ToInt32(phieunhapDataGridView.CurrentRow.Cells["IdNhaCC"].Value);
                this.nhacungcapTableAdapter.FillBySearchId(this.qLBHDataSet.nhacungcap, myIdNhaCC);
                myPhaiTra = Convert.ToDecimal(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                string sotien = Convert.ToString(phieunhapDataGridView.CurrentRow.Cells["TongTien"].Value);
                tamtinh = myPhaiTra - Convert.ToDecimal(sotien);
                //
                nhacungcapTableAdapter.UpdatePhaiTraNhaCC(
                                                           tamtinh,
                                                            myIdNhaCC
                                                            );
                // Xóa phiếu nhập hàng
                phieunhaphangBindingSource.RemoveCurrent();
                phieunhaphangTableAdapter.Update(qLBHDataSet.phieunhaphang);                
                // Tính lại tồn kho hàng hóa
                for (int i = 0; i < ctphieunhapDataGridView.RowCount; i++)
                {
                    myIdHangHoa = Convert.ToInt32(ctphieunhapDataGridView.Rows[i].Cells["IdHangHoa1"].Value);
                    this.hanghoaTableAdapter.FillBySearchId(this.qLBHDataSet.hanghoa, myIdHangHoa);
                    myTonKho = Convert.ToDecimal(hanghoaDataGridView.CurrentRow.Cells["TonKho"].Value);
                    decimal soluong = Convert.ToDecimal(ctphieunhapDataGridView.Rows[i].Cells["SoLuong1"].Value);
                    hanghoaTableAdapter.UpdateTonKhoHangHoa(
                                                               myTonKho - soluong,
                                                                myIdHangHoa
                                                                );
                    hanghoaTableAdapter.Update(qLBHDataSet.hanghoa);
                }
                phieunhaphangctTableAdapter.DeleteCTPhieuNhap(myIdPhieuNhap);
                phieunhaphangctTableAdapter.Update(qLBHDataSet.phieunhaphangct);
                this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, 0);
            }
            //
            {
                HienGroupBox(false);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (RecordCheckInput() == true && RecordCheckInputThemCT() == true)
            {
                LuuPhieuNhap();
                PrintInvoice();
                //
                {
                    HienGroupBox(false);
                    XuLyConTro(true);
                }
                this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, 0);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, myIdPhieuNhap);
            if (myHuy == 0)
            {
                phieunhaphangBindingSource.CancelEdit();
            }
            else
            {
                if (ctphieunhapDataGridView.RowCount == 0)
                {
                    phieunhaphangTableAdapter.DeletePhieuNhap(myIdPhieuNhap);
                }
                else
                {
                    MessageBox.Show("Phiếu nhập hàng đã tồn tại, không thể hủy bỏ !!!");
                }
            }
            ClearForNewRecord();
            dataGridView_hide(); 
            XuLyConTro(true);
            HienGroupBox(false);
            ReadOnlyTextBox(false);
            this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, 0);
        }
        #endregion

        #region Button Click Chi Tiết Phiếu Nhập
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (RecordCheckInputThemCT() == true)
            {
                HienGroupBoxCT(true);                
                ClearForNewRecordCT();

                btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
                txtMaHang.Select();
                this.phieunhaphangTableAdapter.Fill(this.qLBHDataSet.phieunhaphang);
            }
        }

        private void HienGroupBoxCT(Boolean b)
        {
            gbxPhieuNhapCT.Visible = b;
            dataGridViewShow.Visible = b;
            ctphieunhapDataGridView.Visible = !b;
            //
            btnXoaCT.Enabled = !b;
            btnThemCT.Enabled = !b;
            //
        }


        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string infor = "";
            infor += "Bạn có muốn xóa chi tiết này?" + "\n";
            infor += "\n";
            infor += "\n";
            if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ctphieunhapDataGridView.RowCount > 0)
                {
                    myIdHangHoa = Convert.ToInt32(ctphieunhapDataGridView.CurrentRow.Cells["IdHangHoa1"].Value);
                    this.hanghoaTableAdapter.FillBySearchId(this.qLBHDataSet.hanghoa, myIdHangHoa);
                    myTonKho = Convert.ToDecimal(hanghoaDataGridView.CurrentRow.Cells["TonKho"].Value);
                    decimal soluong = Convert.ToDecimal(ctphieunhapDataGridView.CurrentRow.Cells["SoLuong1"].Value);
                    decimal thanhtien = Convert.ToDecimal(ctphieunhapDataGridView.CurrentRow.Cells["ThanhTien1"].Value);
                    //
                    phieunhaphangctBindingSource.RemoveCurrent();
                    phieunhaphangctTableAdapter.Update(qLBHDataSet.phieunhaphangct);
                    // Cập nhật tồn kho
                    hanghoaTableAdapter.UpdateTonKhoHangHoa(
                                                               myTonKho - soluong,
                                                                myIdHangHoa
                                                                );
                    hanghoaTableAdapter.Update(qLBHDataSet.hanghoa);
                    // Cập nhật phải trả nhà cung cấp
                    this.nhacungcapTableAdapter.FillBySearchId(this.qLBHDataSet.nhacungcap, myIdNhaCC);
                    myPhaiTra = Convert.ToDecimal(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                    nhacungcapTableAdapter.UpdatePhaiTraNhaCC(
                                                        myPhaiTra - thanhtien,
                                                        myIdNhaCC
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
                phieunhaphangctTableAdapter.InsertCTPhieuNhap(myIdPhieuNhap,
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
                                                               Convert.ToDecimal(txtThanhTien.Text)
                                                               );
                // Cập nhật tồn kho
                hanghoaTableAdapter.UpdateTonKhoHangHoa(Convert.ToDecimal(txtSoLuong.Text) + Convert.ToDecimal(txtTonKho.Text),
                                                           myIdHangHoa);
                // Cập nhật đơn giá
                hanghoaTableAdapter.UpdateGiaNhapHangHoa(Convert.ToDecimal(txtDonGia.Text),
                                                        myIdHangHoa);
                //
                this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, myIdPhieuNhap);
                this.hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
                // Cập nhật phải trả nhà cung cấp              
                this.nhacungcapTableAdapter.FillBySearchId(this.qLBHDataSet.nhacungcap, myIdNhaCC);
                myPhaiTra = Convert.ToDecimal(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                nhacungcapTableAdapter.UpdatePhaiTraNhaCC(
                                                    myPhaiTra + Convert.ToDecimal(txtThanhTien.Text),
                                                    myIdNhaCC
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
                    btnLuu.Select();
                }
                TinhTongTien();
                //
                LuuPhieuNhap();
                //
                myHuy = 1;
                this.phieunhaphangTableAdapter.Fill(this.qLBHDataSet.phieunhaphang);
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            HienGroupBoxCT(false); 
            XuLyConTro(false);
            btnLuu.Select();
            this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, myIdPhieuNhap);
            TinhTongTien();
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
                txtTenNhaCC.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtTenNhaCC.Select();
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
                txtPhaiTra.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtPhaiTra.Select();
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
                txtSoLuong.Text = string.Format("{0:n0}", Double.Parse("0" + txtSoLuong.Text));
            else txtSoLuong.Text = "0";
            //txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
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
        }
        #endregion

        #region Check Input + Clear For New
        private Boolean RecordCheckInputThemCT()
        {
            string infor = "";
            mySave = true;
            if (txtTenNhaCC.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0
                || txtPhaiTra.Text.Length == 0 || txtSoHieu.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa chưa được nhập" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (txtTenNhaCC.Text.Length > 300 || txtDiaChi.Text.Length > 300 || txtSDT.Text.Length > 30 || txtSoHieu.Text.Length > 12)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa đã vượt quá số lượng ký tự quy định" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (Convert.ToInt32(myIdNhaCC) < 1)
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
                || txtThanhTien.Text.Length == 0)
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
            this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, myIdPhieuNhap);
            if (ctphieunhapDataGridView.RowCount < 0)
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
            myIdPhieuNhap = 0;
            dtpNgayLap.Value = DateTime.Now;
            txtSoHieu.Text = "";
            myIdNhaCC = 0;
            txtTenNhaCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            myPhaiTra = 0;
            txtPhaiTra.Text = "";
            txtTongTien.Text = "0";
            txtVBC.Text = Common.So_chu(Convert.ToDouble(txtTongTien.Text));
            txtUser.Text = Common.TenNhanVien;
            tamtinh = 0;
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
                if (nhacungcapDataGridView.Visible == true)
                {
                    myTextBox = txtTenNhaCC;
                    nhacungcapDataGridView.Select();
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
                if (txtTenNhaCC.Text.Trim().Length == 0)
                {
                    nhacungcapDataGridView.Visible = false;
                }
                else
                {
                    nhacungcapDataGridView.Visible = true;
                    nhacungcapDataGridView.DataSource = nhacungcapBindingSource;
                    this.nhacungcapTableAdapter.FillBySearch(this.qLBHDataSet.nhacungcap, "%" + txtTenNhaCC.Text + "%");
                    nhacungcapDataGridView.Width = 375;
                    myCount = nhacungcapDataGridView.RowCount;
                    if (myCount >= 5)
                    {
                        nhacungcapDataGridView.Height = 90;
                    }
                    else
                    {
                        nhacungcapDataGridView.Height = myCount * 23;
                    }
                    nhacungcapDataGridView.Left = groupBoxLeftPosion + txtTenNhaCC.Left + txtTenNhaCC.Text.Trim().Length * 55 / 10 + 20;
                    nhacungcapDataGridView.Top = groupBoxTopPosion + txtTenNhaCC.Top + 30;
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
                if (nhacungcapDataGridView.Visible == true && nhacungcapDataGridView.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtTenNhaCC.Text.ToString().Trim().Length > 0)
                    {
                        myIdNhaCC = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["idnhacungcap1"].Value);
                        txtTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
                        txtDiaChi.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                        txtSDT.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                        txtPhaiTra.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                        txtPhaiTra.Text = string.Format("{0:n0}", Double.Parse(txtPhaiTra.Text));
                        dataGridView_hide();
                        btnThemCT.Select();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtPhaiTra.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void dgwNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nhacungcapDataGridView.CurrentRow != null)
            {
                myIdNhaCC = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["idnhacungcap1"].Value);
                txtTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
                txtDiaChi.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                txtSDT.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                txtPhaiTra.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                txtPhaiTra.Text = string.Format("{0:n0}", Double.Parse(txtPhaiTra.Text));
                dataGridView_hide();
                btnThemCT.Select();
            }
        }

        private void dgvNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (nhacungcapDataGridView.CurrentRow != null)
                {
                    myIdNhaCC = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["idnhacungcap1"].Value);
                    txtTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
                    txtDiaChi.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                    txtSDT.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                    txtPhaiTra.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                    txtPhaiTra.Text = string.Format("{0:n0}", Double.Parse(txtPhaiTra.Text));
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
                        txtDonGia.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["GiaNhap"].Value);
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
               // MessageBox.Show(Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["idHangHoa"].Value).ToString());
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
                txtDonGia.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["GiaNhap"].Value);
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
                    txtDonGia.Text = Convert.ToString(hanghoaDataGridView.CurrentRow.Cells["GiaNhap"].Value);
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

        private void txtSearchPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            this.phieunhaphangTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphang, "%" + txtSearchPhieuNhap.Text + "%");
        }
        
        private void DateTimePickerB_NgayLap_ValueChanged(object sender, EventArgs e)
        {
            lableB_NgayHT.Text = "Ngày " + Convert.ToString(dtpNgayLap.Value.Day + 100).Substring(1, 2) + " tháng " + Convert.ToString(dtpNgayLap.Value.Month + 100).Substring(1, 2) + " năm " + Convert.ToString(dtpNgayLap.Value.Year);
            txtSoHieu.Select();
        }
        
        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtVBC.Text = Common.So_chu(Convert.ToDouble(txtTongTien.Text));
            }
            catch { }
        }
        
        private void TinhTongTien()
        {
            double ST = 0;
            for (int i = 0; i < ctphieunhapDataGridView.RowCount; i++)
            {
                ST += Convert.ToDouble("0" + ctphieunhapDataGridView.Rows[i].Cells["ThanhTien1"].Value);
            }
            txtTongTien.Text = ST.ToString();
            txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
        }

        private void LuuPhieuNhap()
        {
            phieunhaphangTableAdapter.UpdatePhieuNhap(dtpNgayLap.Value,
                                                            txtSoHieu.Text,
                                                            myIdNhaCC,
                                                            txtTenNhaCC.Text,
                                                            txtDiaChi.Text,
                                                            txtSDT.Text,
                                                            Convert.ToDecimal(txtPhaiTra.Text),
                                                            Convert.ToDecimal(txtTongTien.Text),
                                                            txtVBC.Text,
                                                            txtUser.Text,
                                                            myIdPhieuNhap
                                                            );
            this.phieunhaphangTableAdapter.Fill(this.qLBHDataSet.phieunhaphang);
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length != 0)
            {
                double sl = double.Parse(txtSoLuong.Text.Replace(",", ""));
                txtSoLuong.Text = sl.ToString("###,###,###,##0");
                txtSoLuong.Select(txtSoLuong.TextLength, 0);
            }
        }

        private void btnNhaCCMoi_Click(object sender, EventArgs e)
        {
            FormNhaCungCap ncc = new FormNhaCungCap();
            ncc.Show();
        }

        private void btnHangHoaMoi_Click(object sender, EventArgs e)
        {
            FormHangHoa hh = new FormHangHoa();
            hh.Show();
        }

        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            CopyData();
            ReadOnlyTextBox(true);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintInvoice()
        {
            this.DataTableReportPhieuNhapTableAdapter.FillBy(this.DataSetReport.DataTableReportPhieuNhap, myIdPhieuNhap);
            this.reportViewerPhieuNhap.RefreshReport();
            //reportViewerPhieuXuat.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerPhieuNhap.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerPhieuNhap.PrintDialog();
                reportViewerPhieuNhap.Clear();
                reportViewerPhieuNhap.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }

        private void ẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewerPhieuNhap.Visible = false;
        }
    }
}
