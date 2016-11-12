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
    public partial class FormBCBanHang : Form
    {
        Control myTextBox;
        int myCount;
        int IdNhomHang = 0;
        int IdTenHang = 0;

        public FormBCBanHang()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void hanghoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          //  this.hanghoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportBCBanHang' table. You can move, or remove it, as needed.
            this.dataTableReportBCBanHangTableAdapter.Fill(this.dataSetReport.DataTableReportBCBanHang);
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportBCBanHang' table. You can move, or remove it, as needed.
            //this.dataTableReportBCBanHangTableAdapter.Fill(this.dataSetReport.DataTableReportBCBanHang);
            // TODO: This line of code loads data into the 'qLBHDataSet.nhomhang' table. You can move, or remove it, as needed.
            this.nhomhangTableAdapter.Fill(this.qLBHDataSet.nhomhang);
            reportViewerTonKho.Visible = false;
            txtSearchNhomHang.Select();
            SearchBCBanHang();
        }

        private void btnInTonKho_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            SearchBCBanHang(); 
            this.reportViewerTonKho.RefreshReport();
            reportViewerTonKho.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerTonKho.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerTonKho.PrintDialog();
                reportViewerTonKho.Clear();
                reportViewerTonKho.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtSearchNhomHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchNhomHang.Text.Trim().Length == 0)
                {
                    dgvNhomHangSearch.Visible = false;
                    SearchBCBanHang();
                }
                else
                {
                    dgvNhomHangSearch.Visible = true;
                    dgvNhomHangSearch.DataSource = nhomhangBindingSource;
                    this.nhomhangTableAdapter.FillBySearch(this.qLBHDataSet.nhomhang, "%" + txtSearchNhomHang.Text + "%");
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
                    dgvNhomHangSearch.Left = txtSearchNhomHang.Left + txtSearchNhomHang.Text.Trim().Length * 55 / 10 + 10;
                    dgvNhomHangSearch.Top = txtSearchNhomHang.Top + 25;
                }
            }
            catch
            {

            }
        }

        private void txtSearchNhomHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                btnInBaoCao.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (dgvNhomHangSearch.Visible == true)
                {
                    myTextBox = txtSearchNhomHang;
                    dgvNhomHangSearch.Select();
                    SendKeys.Send("{DOWN}");
                }
                else
                    txtSearchTenHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtSearchTenHang.Select();
            } 
        }

        private void txtSearchNhomHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvNhomHangSearch.Visible == true && dgvNhomHangSearch.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtSearchNhomHang.Text.ToString().Trim().Length > 0)
                    {
                        txtSearchNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                        IdNhomHang = Convert.ToInt32(dgvNhomHangSearch.CurrentRow.Cells[2].Value.ToString().Trim());
                        dataGridView_hide();
                        txtSearchTenHang.Text = "";
                        txtSearchTenHang.Select();
                        SearchBCBanHang();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtSearchTenHang.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void SearchBCBanHang()
        {
            this.dataTableReportBCBanHangTableAdapter.FillBySearchNgay(dataSetReport.DataTableReportBCBanHang,
                                                                        dtpTuNgay.Text,
                                                                        dtpDenNgay.Text,
                                                                        Convert.ToDateTime(dtpTuNgay.Value),
                                                                        Convert.ToDateTime(dtpDenNgay.Value),
                                                                        "%" + txtSearchNhomHang.Text + "%",
                                                                        "%" + txtSearchTenHang.Text + "%");
            TinhTongTien();
        }

        private void dataGridView_hide()
        {
            this.dgvNhomHangSearch.Visible = false;
            this.dgvTenHangSearch.Visible = false;
        }

        private void dgvNhomHangSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhomHangSearch.CurrentRow != null)
            {
                txtSearchNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                IdNhomHang = Convert.ToInt32(dgvNhomHangSearch.CurrentRow.Cells[2].Value.ToString().Trim());
                dataGridView_hide();
                txtSearchTenHang.Text = "";
                txtSearchTenHang.Select();
                SearchBCBanHang();
            }
        }

        private void dgvNhomHangSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgvNhomHangSearch.CurrentRow != null)
                {
                    txtSearchNhomHang.Text = Convert.ToString(dgvNhomHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                    IdNhomHang = Convert.ToInt32(dgvNhomHangSearch.CurrentRow.Cells[2].Value.ToString().Trim());
                    dataGridView_hide();
                    txtSearchTenHang.Text = "";
                    txtSearchTenHang.Select();
                    SearchBCBanHang();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }

        private void txtSearchTenHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTenHang.Text.Trim().Length == 0)
                {
                    dgvTenHangSearch.Visible = false;
                    SearchBCBanHang();
                }
                else
                {
                    dgvTenHangSearch.Visible = true;
                    dgvTenHangSearch.DataSource = hanghoaBindingSource;
                    this.hanghoaTableAdapter.FillBySearchNhomTenHang(this.qLBHDataSet.hanghoa, "%" + txtSearchTenHang.Text + "%", txtSearchNhomHang.Text);
                    dgvTenHangSearch.Width = 275;
                    myCount = dgvTenHangSearch.RowCount;
                    if (myCount >= 5)
                    {
                        dgvTenHangSearch.Height = 90;
                    }
                    else
                    {
                        dgvTenHangSearch.Height = myCount * 23;
                    }
                    dgvTenHangSearch.Left = txtSearchTenHang.Left + txtSearchTenHang.Text.Trim().Length * 55 / 10 + 10;
                    dgvTenHangSearch.Top = txtSearchTenHang.Top + 25;
                }
            }
            catch
            {

            }
        }

        private void txtSearchTenHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSearchNhomHang.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (dgvTenHangSearch.Visible == true)
                {
                    myTextBox = txtSearchTenHang;
                    dgvTenHangSearch.Select();
                    SendKeys.Send("{DOWN}");
                }
                else
                    btnInBaoCao.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnInBaoCao.Select();
            } 
        }

        private void txtSearchTenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvTenHangSearch.Visible == true && dgvTenHangSearch.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtSearchTenHang.Text.ToString().Trim().Length > 0)
                    {
                        txtSearchTenHang.Text = Convert.ToString(dgvTenHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                        dataGridView_hide();
                        btnInBaoCao.Select();
                        SearchBCBanHang();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    btnInBaoCao.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void dgvTenHangSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenHangSearch.CurrentRow != null)
            {
                txtSearchTenHang.Text = Convert.ToString(dgvTenHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                dataGridView_hide();
                btnInBaoCao.Select();
                SearchBCBanHang();
            }
        }

        private void dgvTenHangSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgvTenHangSearch.CurrentRow != null)
                {
                    txtSearchTenHang.Text = Convert.ToString(dgvTenHangSearch.CurrentRow.Cells[0].Value.ToString().Trim());
                    dataGridView_hide();
                    btnInBaoCao.Select();
                    SearchBCBanHang();
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
                SearchBCBanHang();
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                SearchBCBanHang();
            }
        }

        private void TinhTongTien()
        {
            if (bcbanhangDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < bcbanhangDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(bcbanhangDataGridView.Rows[i].Cells["ThanhTien"].Value);
                }
                txtTongTien.Text = ST.ToString();
                txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
            }
            else txtTongTien.Text = "0";
        }
    }
}
