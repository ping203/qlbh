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
    public partial class FormXuatKho : Form
    {
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int myIdPhieuXuat;
        int myIdKhachHang = 0;
        string myTrangThai = "-";

        public FormXuatKho()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void hanghoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          //  this.hanghoaBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLBHDataSet.phieuxuathang' table. You can move, or remove it, as needed.
            this.phieuxuathangTableAdapter.Fill(this.qLBHDataSet.phieuxuathang);
            // TODO: This line of code loads data into the 'qLBHDataSet.phieuxuathangct' table. You can move, or remove it, as needed.
            this.phieuxuathangctTableAdapter.Fill(this.qLBHDataSet.phieuxuathangct);
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportXuatKho' table. You can move, or remove it, as needed.
            this.dataTableReportXuatKhoTableAdapter.Fill(this.dataSetReport.DataTableReportXuatKho);
            // TODO: This line of code loads data into the 'qLBHDataSet.khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qLBHDataSet.khachhang);
            
            this.dataTableReportXuatKhoTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportXuatKho,
                                                                            Convert.ToDateTime(dtpTuNgay.Value),
                                                                            Convert.ToDateTime(dtpDenNgay.Value),
                                                                            txtSearchTenKhachHang.Text.Trim());
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportTonKho' table. You can move, or remove it, as needed.
            reportViewerXuatKho.Visible = false;
            gbxXuatKho.Visible = false;
            txtSearchTenKhachHang.Select();
            SearchXuatKho();
            this.reportViewerXuatKho.RefreshReport();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            try
            {
                /*int centerF = this.Width / 2;
                gbxPhieuXuat.Left = centerF - (gbxPhieuXuat.Width / 2);
                gbxPhieuXuat.Top = this.Top + 40;
                groupBoxLeftPosion = gbxPhieuXuat.Left;
                groupBoxTopPosion = gbxPhieuXuat.Top;*/
            }
            catch
            {
            }
        }

        private void txtSearchTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTenKhachHang.Text.Trim().Length == 0)
                {
                    khachhangDataGridView.Visible = false;
                    SearchXuatKho();
                }
                else
                {
                    khachhangDataGridView.Visible = true;
                    khachhangDataGridView.DataSource = khachhangBindingSource;
                    this.khachhangTableAdapter.FillBySearch(this.qLBHDataSet.khachhang, "%" + txtSearchTenKhachHang.Text + "%");
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
                    khachhangDataGridView.Left = groupBoxLeftPosion + txtSearchTenKhachHang.Left + txtSearchTenKhachHang.Text.Trim().Length * 55 / 10 + 20;
                    khachhangDataGridView.Top = groupBoxTopPosion + txtSearchTenKhachHang.Top + 30;
                }
            }
            catch
            {

            }
        }

        private void SearchXuatKho()
        {
            this.dataTableReportXuatKhoTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportXuatKho,
                                                                    Convert.ToDateTime(dtpTuNgay.Value),
                                                                    Convert.ToDateTime(dtpDenNgay.Value),
                                                                    "%" + txtSearchTenKhachHang.Text + "%");
            TinhTongTien();
        }

        private void btnInTonKho_Click(object sender, EventArgs e)
        {
            //PrintInvoice();
        }

        private void txtSearchTenKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                //btnInTonKho.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (khachhangDataGridView.Visible == true)
                {
                    myTextBox = txtSearchTenKhachHang;
                    khachhangDataGridView.Select();
                    SendKeys.Send("{DOWN}");
                }
                //else
                    //btnInTonKho.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
               // btnInTonKho.Select();
            }
        }

        private void dataGridView_hide()
        {
            this.khachhangDataGridView.Visible = false;
        }

        private void txtSearchTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (khachhangDataGridView.Visible == true && khachhangDataGridView.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtSearchTenKhachHang.Text.ToString().Trim().Length > 0)
                    {
                        txtSearchTenKhachHang.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["TenKhachHang1"].Value);
                        dataGridView_hide();
                        SearchXuatKho();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    SearchXuatKho();
                }

            }
            catch
            {
                //
            }
        }

        private void khachhangDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (khachhangDataGridView.CurrentRow != null)
            {
                txtSearchTenKhachHang.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["TenKhachHang1"].Value);
                dataGridView_hide();
                //
                SearchXuatKho();
            }
        }

        private void khachhangDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (khachhangDataGridView.CurrentRow != null)
                {
                    txtSearchTenKhachHang.Text = Convert.ToString(khachhangDataGridView.CurrentRow.Cells["TenKhachHang1"].Value);
                    dataGridView_hide();
                    //
                    SearchXuatKho();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                SearchXuatKho();
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                SearchXuatKho();
            }
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xuatkhoDataGridView.RowCount > 0)
            {
                gbxXuatKho.Visible = true;
                xuatkhoDataGridView.Enabled = false;
                myIdPhieuXuat = Convert.ToInt32(xuatkhoDataGridView.CurrentRow.Cells["idphieuxuathang"].Value);
                dtpNgayLap.Value = Convert.ToDateTime(xuatkhoDataGridView.CurrentRow.Cells["NgayXuat"].Value);
                txtSoHieu.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["SoHieu"].Value);
                //
                myIdKhachHang = Convert.ToInt32(xuatkhoDataGridView.CurrentRow.Cells["IdKhachHang"].Value);
                txtTenKhachHang.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["TenKhachHang"].Value);
                txtDiaChi.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["DiaChiKhachHang"].Value);
                txtSDT.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["SDTKhachHang"].Value);
                txtPhaiThu.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["PhaiThu"].Value);
                txtPhaiThu.Text = string.Format("{0:n0}", Double.Parse(txtPhaiThu.Text));
                //
                txtTienHang.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["TienHang"].Value);
                txtTienHang.Text = string.Format("{0:n0}", Double.Parse(txtTienHang.Text));
                //
                txtGiamGia.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["GiamGia"].Value);
                txtGiamGia.Text = string.Format("{0:n0}", Double.Parse(txtGiamGia.Text));
                //
                txtThanhToan.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["ThanhToan"].Value);
                txtThanhToan.Text = string.Format("{0:n0}", Double.Parse(txtThanhToan.Text));
                //
                txtTongTien.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["TongTien"].Value);
                txtTongTien.Text = string.Format("{0:n0}", Double.Parse(txtTongTien.Text));
                //
                decimal CTT = Convert.ToDecimal(txtTienHang.Text) - Convert.ToDecimal(txtGiamGia.Text);
                txtCanThanhToan.Text = CTT.ToString();
                txtCanThanhToan.Text = string.Format("{0:n0}", Double.Parse(txtCanThanhToan.Text));
                //
                decimal CN = Convert.ToDecimal(txtTongTien.Text) + Convert.ToDecimal(txtPhaiThu.Text);
                txtConNo.Text = CN.ToString();
                txtConNo.Text = string.Format("{0:n0}", Double.Parse(txtConNo.Text));
                //
                txtVBC.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["VBC"].Value);
                txtUser.Text = Convert.ToString(xuatkhoDataGridView.CurrentRow.Cells["User"].Value);
                //
                this.phieuxuathangctTableAdapter.FillBySearch(this.qLBHDataSet.phieuxuathangct, myIdPhieuXuat);
            }
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            lableB_NgayHT.Text = "Ngày " + Convert.ToString(dtpNgayLap.Value.Day + 100).Substring(1, 2) + " tháng " + Convert.ToString(dtpNgayLap.Value.Month + 100).Substring(1, 2) + " năm " + Convert.ToString(dtpNgayLap.Value.Year);
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            DataTableReportPhieuXuatTableAdapter.FillBy(this.dataSetReport.DataTableReportPhieuXuat, myIdPhieuXuat);
            this.reportViewerXuatKho.RefreshReport();
            //reportViewerXuatKho.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerXuatKho.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerXuatKho.PrintDialog();
                //reportViewerTonKho.Clear();
                reportViewerXuatKho.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            gbxXuatKho.Visible = false;
            xuatkhoDataGridView.Enabled = true;
            SearchXuatKho(); 
            reportViewerXuatKho.Visible = false;
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        { 
            string infor = "";
            infor += "Bạn có muốn khóa phiếu?" + "\n";
            infor += "\n";
            infor += "\n";
            if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                phieuxuathangTableAdapter.UpdateKhoaPhieu("Lock", myIdPhieuXuat);
                MessageBox.Show("Phiếu đã được khóa!!!");
                gbxXuatKho.Visible = false;
                xuatkhoDataGridView.Enabled = true;
                SearchXuatKho();
            }
            reportViewerXuatKho.Visible = false;
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            if (Common.UserId == 1)
            {
                string infor = "";
                infor += "Bạn có muốn mở khóa?" + "\n";
                infor += "\n";
                infor += "\n";
                if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    phieuxuathangTableAdapter.UpdateKhoaPhieu("-", myIdPhieuXuat);
                    MessageBox.Show("Phiếu đã được mở khóa!!!");
                    gbxXuatKho.Visible = false;
                    xuatkhoDataGridView.Enabled = true;
                    SearchXuatKho();
                }
            }
            else MessageBox.Show("Bạn không có quyền mở khóa!!!");

        }

        private void TinhTongTien()
        {
            if (xuatkhoDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < xuatkhoDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(xuatkhoDataGridView.Rows[i].Cells["TongTien"].Value);
                }
                txtTongSoTien.Text = ST.ToString();
                txtTongSoTien.Text = string.Format("{0:n0}", double.Parse(txtTongSoTien.Text));
            }
            else txtTongSoTien.Text = "0";
        }
    }
}
