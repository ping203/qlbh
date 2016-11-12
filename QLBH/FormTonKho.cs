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
    public partial class FormTonKho : Form
    {
        public FormTonKho()
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
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportTonKho' table. You can move, or remove it, as needed.
            //this.dataTableReportTonKhoTableAdapter.Fill(this.dataSetReport.DataTableReportTonKho);
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportTonKho' table. You can move, or remove it, as needed.
            this.dataTableReportTonKhoTableAdapter.FillBy(this.dataSetReport.DataTableReportTonKho, "%" + txtSearchHangHoa.Text + "%", "%" + cbxSearchKhoHang.Text + "%"); 
            //this.dataTableReportTonKhoTableAdapter.Fill(this.dataSetReport.DataTableReportTonKho);
            reportViewerTonKho.Visible = false;
            TinhTongTien();
            txtSearchHangHoa.Select();
        }

        private void txtSearchHangHoa_TextChanged(object sender, EventArgs e)
        {
            this.dataTableReportTonKhoTableAdapter.FillBy(this.dataSetReport.DataTableReportTonKho,  "%" + txtSearchHangHoa.Text + "%",  "%" + cbxSearchKhoHang.Text + "%");
            TinhTongTien();
        }

        private void cbxSearchKhoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataTableReportTonKhoTableAdapter.FillBy(this.dataSetReport.DataTableReportTonKho, "%" + txtSearchHangHoa.Text + "%", "%" + cbxSearchKhoHang.Text + "%");
            TinhTongTien();
        }

        private void btnInTonKho_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            //this.dataTableReportTonKhoTableAdapter.FillByReportTonKho(this.dataSetReport.DataTableReportTonKho, dtpTuNgay.Text, dtpDenNgay.Text, "", "%" + txtSearchHangHoa.Text + "%", "%" + cbxSearchKhoHang.Text + "%");
            this.dataTableReportTonKhoTableAdapter.FillByReportTonKho(this.dataSetReport.DataTableReportTonKho, dtpTuNgay.Text, dtpDenNgay.Text, "", "%" + txtSearchHangHoa.Text + "%", "%" + cbxSearchKhoHang.Text + "%");
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

        private void TinhTongTien()
        {
            if (tonkhoDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < tonkhoDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(tonkhoDataGridView.Rows[i].Cells["GTTonKho"].Value);
                }
                txtTongTien.Text = ST.ToString();
                txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
            }
            else txtTongTien.Text = "0";
        }

        private void chiTiếthànghoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idhh = Convert.ToInt32(tonkhoDataGridView.CurrentRow.Cells["idHangHoa"].Value);
            string mahh = Convert.ToString(tonkhoDataGridView.CurrentRow.Cells["MaHang"].Value);
            string tenhh = Convert.ToString(tonkhoDataGridView.CurrentRow.Cells["TenHang"].Value);
            string khohh = Convert.ToString(tonkhoDataGridView.CurrentRow.Cells["KhoHang"].Value);
            decimal slhh = Convert.ToDecimal(tonkhoDataGridView.CurrentRow.Cells["TonKho"].Value);
            decimal giatrihh = Convert.ToDecimal(tonkhoDataGridView.CurrentRow.Cells["GTTonKho"].Value);
            FormCTHHoa ctthu = new FormCTHHoa(idhh, mahh,tenhh, khohh,slhh,giatrihh);
            ctthu.Show();
        }
    }
}
