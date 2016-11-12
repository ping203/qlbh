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
    public partial class FormNhapKho : Form
    {
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int myIdPhieuNhap;
        int myIdNhaCC = 0;
        string myTrangThai = "-";

        public FormNhapKho()
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
            // TODO: This line of code loads data into the 'qLBHDataSet.phieunhaphangct' table. You can move, or remove it, as needed.
            this.phieunhaphangctTableAdapter.Fill(this.qLBHDataSet.phieunhaphangct);
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportNhapKho' table. You can move, or remove it, as needed.
            this.nhacungcapTableAdapter.Fill(this.qLBHDataSet.nhacungcap);
            this.dataTableReportNhapKhoTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportNhapKho,
                                                                            Convert.ToDateTime(dtpTuNgay.Value),
                                                                            Convert.ToDateTime(dtpDenNgay.Value),
                                                                            "");
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportTonKho' table. You can move, or remove it, as needed.
            gbxNhapKho.Visible = false;
            TinhTongTien();
            txtSearchTenNhaCC.Select();
            SearchXuatKho();
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

        private void txtSearchTenNhaCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTenNhaCC.Text.Trim().Length == 0)
                {
                    nhacungcapDataGridView.Visible = false;
                    SearchXuatKho();
                }
                else
                {
                    nhacungcapDataGridView.Visible = true;
                    nhacungcapDataGridView.DataSource = nhacungcapBindingSource;
                    this.nhacungcapTableAdapter.FillBySearch(this.qLBHDataSet.nhacungcap, "%" + txtSearchTenNhaCC.Text + "%");
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
                    nhacungcapDataGridView.Left = groupBoxLeftPosion + txtSearchTenNhaCC.Left + txtSearchTenNhaCC.Text.Trim().Length * 55 / 10 + 20;
                    nhacungcapDataGridView.Top = groupBoxTopPosion + txtSearchTenNhaCC.Top + 30;
                }
            }
            catch
            {

            }
        }

        private void SearchXuatKho()
        {
            this.dataTableReportNhapKhoTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportNhapKho,
                                                                    Convert.ToDateTime(dtpTuNgay.Value),
                                                                    Convert.ToDateTime(dtpDenNgay.Value),
                                                                    "%" + txtSearchTenNhaCC.Text + "%");
            TinhTongTien();
        }

        private void btnInTonKho_Click(object sender, EventArgs e)
        {
            //PrintInvoice();
        }

        private void txtSearchTenNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                //btnInTonKho.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (nhacungcapDataGridView.Visible == true)
                {
                    myTextBox = txtSearchTenNhaCC;
                    nhacungcapDataGridView.Select();
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
            this.nhacungcapDataGridView.Visible = false;
        }

        private void txtSearchTenNhaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (nhacungcapDataGridView.Visible == true && nhacungcapDataGridView.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtSearchTenNhaCC.Text.ToString().Trim().Length > 0)
                    {
                        txtSearchTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
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

        private void nhacungcapDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nhacungcapDataGridView.CurrentRow != null)
            {
                txtSearchTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
                dataGridView_hide();
                //
                SearchXuatKho();
            }
        }

        private void nhacungcapDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (nhacungcapDataGridView.CurrentRow != null)
                {
                    txtSearchTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
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
            if (nhapkhoDataGridView.RowCount > 0)
            {
                gbxNhapKho.Visible = true;
                nhapkhoDataGridView.Enabled = false;
                myIdPhieuNhap = Convert.ToInt32(nhapkhoDataGridView.CurrentRow.Cells["idphieunhaphang"].Value);
                dtpNgayLap.Value = Convert.ToDateTime(nhapkhoDataGridView.CurrentRow.Cells["NgayNhap"].Value);
                txtSoHieu.Text = Convert.ToString(nhapkhoDataGridView.CurrentRow.Cells["SoHieu"].Value);
                //
                myIdNhaCC = Convert.ToInt32(nhapkhoDataGridView.CurrentRow.Cells["IdNhaCC"].Value);
                txtTenNhaCC.Text = Convert.ToString(nhapkhoDataGridView.CurrentRow.Cells["TenNhaCC"].Value);
                txtDiaChi.Text = Convert.ToString(nhapkhoDataGridView.CurrentRow.Cells["DiaChiNhaCC"].Value);
                txtSDT.Text = Convert.ToString(nhapkhoDataGridView.CurrentRow.Cells["SDTNhaCC"].Value);
                txtPhaiTra.Text = Convert.ToString(nhapkhoDataGridView.CurrentRow.Cells["PhaiTra"].Value);
                txtPhaiTra.Text = string.Format("{0:n0}", Double.Parse(txtPhaiTra.Text));
                //
                txtTongTien.Text = Convert.ToString(nhapkhoDataGridView.CurrentRow.Cells["TongTien"].Value);
                txtTongTien.Text = string.Format("{0:n0}", Double.Parse(txtTongTien.Text));
                //
                txtVBC.Text = Convert.ToString(nhapkhoDataGridView.CurrentRow.Cells["VBC"].Value);
                txtUser.Text = Convert.ToString(nhapkhoDataGridView.CurrentRow.Cells["User"].Value);
                //
                this.phieunhaphangctTableAdapter.FillBySearch(this.qLBHDataSet.phieunhaphangct, myIdPhieuNhap);
            }
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            lableB_NgayHT.Text = "Ngày " + Convert.ToString(dtpNgayLap.Value.Day + 100).Substring(1, 2) + " tháng " + Convert.ToString(dtpNgayLap.Value.Month + 100).Substring(1, 2) + " năm " + Convert.ToString(dtpNgayLap.Value.Year);
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            gbxNhapKho.Visible = false;
            nhapkhoDataGridView.Enabled = true;
            SearchXuatKho(); 
        }

        private void TinhTongTien()
        {
            if (nhapkhoDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < nhapkhoDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(nhapkhoDataGridView.Rows[i].Cells["TongTien"].Value);
                }
                txtTongSoTien.Text = ST.ToString();
                txtTongSoTien.Text = string.Format("{0:n0}", double.Parse(txtTongSoTien.Text));
            }
            else txtTongSoTien.Text = "0";
        }

    }
}
