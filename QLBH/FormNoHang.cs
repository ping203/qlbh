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
    public partial class FormNoHang : Form
    {
        int myIdKhachHang;
        int myIdPhieuXuat;
        int myIdCTPhieuXuat;
        Boolean mySave;
        Boolean myTra;
        Boolean myTru;
        int myIdHangHoa;
        string myMaHang;
        string myTenHang;
        string myDVT;
        string myKhoHang;
        int myIdNhomHang;
        string myNhomHang;
        decimal myTonKho;
        decimal mySoLuong;
        decimal mySoLuongNo;
        decimal myDonGia;
        decimal myThanhTien;
        decimal myPhanTram;
        decimal myChietKhau;
        decimal myPhaiThu;
        string myNo;
        string myGhiChu;

        public FormNoHang(int myIdKH, int myIdPX)
        {
            InitializeComponent();
            myIdKhachHang = myIdKH;
            myIdPhieuXuat = myIdPX;
        }

        private void hanghoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nohangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.nohang' table. You can move, or remove it, as needed.
            this.nohangTableAdapter.FillByNoKhachHang(this.qLBHDataSet.nohang, myIdKhachHang, "Nợ", 0);
            txtSoLuong.Visible = false;
            XuLyConTro(true);
        }

        private void XuLyConTro(bool b)
        {
            btnTraHang.Enabled = btnTruHang.Enabled = b;
            txtSoLuong.Visible = nohangDataGridView.ReadOnly = btnLuuHang.Enabled = btnDong.Enabled = !b;
        }

        private void AutoNumber(object sender, KeyPressEventArgs e)
        {
            int mykey = (int)e.KeyChar;
            if (!(char.IsNumber(e.KeyChar) || mykey == 44 || mykey == 46))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnTraHang_Click(object sender, EventArgs e)
        {
            myTra = true;
            myTru = false;
            XuLyConTro(false);
            //
            CopyCTPhieuXuat();
            //
            labelKho.Text = "Số lượng kho: " + myTonKho.ToString();
            txtSoLuong.Text = mySoLuongNo.ToString();
            txtSoLuong.Select();
        }

        private void btnTruHang_Click(object sender, EventArgs e)
        {
            myTra = false;
            myTru = true;
            XuLyConTro(false);
            //
            CopyCTPhieuXuat();
            //
            labelKho.Text = "Số lượng nợ: " + mySoLuongNo.ToString();
            txtSoLuong.Text = mySoLuongNo.ToString();
            txtSoLuong.Select();
        }

        private void CopyCTPhieuXuat()
        {
            myIdCTPhieuXuat = Convert.ToInt32(nohangDataGridView.CurrentRow.Cells["idphieuxuathangct"].Value); //1
            myIdHangHoa = Convert.ToInt32(nohangDataGridView.CurrentRow.Cells["IdHangHoa"].Value); //1
            myMaHang = Convert.ToString(nohangDataGridView.CurrentRow.Cells["MaHang"].Value);
            myTenHang = Convert.ToString(nohangDataGridView.CurrentRow.Cells["TenHang"].Value); //3
            myDVT = Convert.ToString(nohangDataGridView.CurrentRow.Cells["DVT"].Value);
            myKhoHang = Convert.ToString(nohangDataGridView.CurrentRow.Cells["KhoHang"].Value); //5
            myNhomHang = Convert.ToString(nohangDataGridView.CurrentRow.Cells["TenNhomHang"].Value); //7
            mySoLuong = Convert.ToDecimal(nohangDataGridView.CurrentRow.Cells["SoLuong"].Value);
            myDonGia = Convert.ToDecimal(nohangDataGridView.CurrentRow.Cells["DonGia"].Value); //9
            myThanhTien = Convert.ToDecimal(nohangDataGridView.CurrentRow.Cells["ThanhTien"].Value);
            myPhanTram = Convert.ToDecimal(nohangDataGridView.CurrentRow.Cells["PhanTram"].Value); //11
            myChietKhau = Convert.ToDecimal(nohangDataGridView.CurrentRow.Cells["ChietKhau"].Value);
            myNo = Convert.ToString(nohangDataGridView.CurrentRow.Cells["No"].Value);  //13
            DateTime VarNgay = Convert.ToDateTime(nohangDataGridView.CurrentRow.Cells["NgayXuat"].Value);
            //ngayht.Text = "Ngày " + Convert.ToString(VarNgay.Day) + " tháng " + Convert.ToString(VarNgay.Month) + " năm " + Convert.ToString(VarNgay.Year);
            myGhiChu = Convert.ToString(VarNgay.Day)+"/"+Convert.ToString(VarNgay.Month)+"/"+Convert.ToString(VarNgay.Year);
            mySoLuongNo = Convert.ToDecimal(nohangDataGridView.CurrentRow.Cells["SoLuongNo"].Value); //15
            //
            this.hanghoaTableAdapter.FillBySearchId(this.qLBHDataSet.hanghoa, myIdHangHoa);
            myTonKho = Convert.ToDecimal(hanghoaDataGridView.CurrentRow.Cells["TonKho1"].Value);
            myIdNhomHang = Convert.ToInt32(hanghoaDataGridView.CurrentRow.Cells["IdNhomHang1"].Value);
        }

        private Boolean RecordCheckInput()
        {
            string infor = "";
            mySave = true;
            if (myTra == true &&  Convert.ToDecimal(txtSoLuong.Text) > mySoLuongNo)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Số lượng trả lớn hơn số lượng nợ" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (myTra == true && Convert.ToDecimal(txtSoLuong.Text) > myTonKho)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Số lượng trả lớn hơn số lượng trong kho" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (myTru == true && Convert.ToDecimal(txtSoLuong.Text) > mySoLuongNo)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Số lượng trừ lớn hơn số lượng nợ" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            return mySave;
        }

        private void btnLuuHang_Click(object sender, EventArgs e)
        {
            if (RecordCheckInput() == true)
            {
                if (myTra == true)
                {
                    phieuxuathangctTableAdapter.InsertCTPhieuXuat(     myIdPhieuXuat,
                                                                       myIdHangHoa,
                                                                       myMaHang,
                                                                       myTenHang,
                                                                       myDVT,
                                                                       myKhoHang,
                                                                       myIdNhomHang,
                                                                       myNhomHang,
                                                                       Convert.ToDecimal(myTonKho),
                                                                       Convert.ToDecimal(txtSoLuong.Text),
                                                                       0,
                                                                       0,
                                                                       0,
                                                                       0,
                                                                       "-",
                                                                       "Trả",
                                                                       "-",
                                                                       Convert.ToString(myGhiChu),
                                                                       0
                                                                       );
                    // Cập nhật tồn kho
                    {   
                        hanghoaTableAdapter.UpdateTonKhoHangHoa(Convert.ToDecimal(myTonKho) - Convert.ToDecimal(txtSoLuong.Text),
                                                                myIdHangHoa);
                    }
                    // Cập nhật nợ
                    {
                        phieuxuathangctTableAdapter.UpdateXuLyNo(Convert.ToDecimal(mySoLuongNo) - Convert.ToDecimal(txtSoLuong.Text),
                                                                myIdCTPhieuXuat);
                    }
                }
                else if(myTru == true)
                {
                    decimal thanhtien = Convert.ToDecimal(txtSoLuong.Text) * Convert.ToDecimal(myDonGia) * -1;
                    myChietKhau = (Convert.ToDecimal(thanhtien) * Convert.ToDecimal(myPhanTram)) / 100;
                    phieuxuathangctTableAdapter.InsertCTPhieuXuat(myIdPhieuXuat,
                                                                       myIdHangHoa,
                                                                       myMaHang,
                                                                       myTenHang,
                                                                       myDVT,
                                                                       myKhoHang,
                                                                       myIdNhomHang,
                                                                       myNhomHang,
                                                                       Convert.ToDecimal(myTonKho),
                                                                       Convert.ToDecimal(txtSoLuong.Text),
                                                                       Convert.ToDecimal(myDonGia),
                                                                       Convert.ToDecimal(thanhtien),
                                                                       Convert.ToDecimal(myPhanTram),
                                                                       Convert.ToDecimal(myChietKhau),
                                                                       "-",
                                                                       "-",
                                                                       "Trừ",
                                                                       Convert.ToString(myGhiChu),
                                                                       0
                                                                       );
                    {
                        phieuxuathangctTableAdapter.UpdateXuLyNo(Convert.ToDecimal(mySoLuongNo) - Convert.ToDecimal(txtSoLuong.Text),
                                                                myIdCTPhieuXuat);
                    }
                    // Cập nhật phải trả nhà cung cấp
                    this.khachhangTableAdapter.FillBySearchId(this.qLBHDataSet.khachhang, myIdKhachHang);
                    myPhaiThu = Convert.ToDecimal(khachhangDataGridView.CurrentRow.Cells["PhaiThu1"].Value);
                    khachhangTableAdapter.UpdatePhaiThuKhachHang(
                                                    myPhaiThu + thanhtien - myChietKhau,
                                                    myIdKhachHang
                                                    );
                    //
                }
            //
            this.nohangTableAdapter.FillByNoKhachHang(this.qLBHDataSet.nohang, myIdKhachHang, "Nợ", 0);
            this.hanghoaTableAdapter.Fill(this.qLBHDataSet.hanghoa);
            myTra = false;
            myTru = false;
            XuLyConTro(true);
            labelKho.Text = "";
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (this.txtSoLuong.Text.Trim().Length == 0)
            {
                txtSoLuong.Text = "0";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
           // FormPhieuXuat frmm = new FormPhieuXuat();
           // frmm.Refresh();
        }

        
    }
}
