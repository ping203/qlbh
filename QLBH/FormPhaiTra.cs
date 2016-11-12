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
    public partial class FormPhaiTra : Form
    {
        public FormPhaiTra()
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
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportNoPhaiTra' table. You can move, or remove it, as needed.
            this.dataTableReportNoPhaiTraTableAdapter.Fill(this.dataSetReport.DataTableReportNoPhaiTra);
            reportViewerNoPhaiTra.Visible = false;
            txtSearchNhaCC.Select();
            TinhTongTien();
        }

        private void txtSearchHangHoa_TextChanged(object sender, EventArgs e)
        {
            this.dataTableReportNoPhaiTraTableAdapter.FillBySearchNhaCC(this.dataSetReport.DataTableReportNoPhaiTra, dtpTuNgay.Text, dtpDenNgay.Text, "%" + txtSearchNhaCC.Text + "%");
            TinhTongTien();
        }

        private void btnInNoPhaiThu_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            this.dataTableReportNoPhaiTraTableAdapter.FillBySearchNhaCC(this.dataSetReport.DataTableReportNoPhaiTra, dtpTuNgay.Text, dtpDenNgay.Text, "%" + txtSearchNhaCC.Text + "%");
            this.reportViewerNoPhaiTra.RefreshReport();
            reportViewerNoPhaiTra.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerNoPhaiTra.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerNoPhaiTra.PrintDialog();
                reportViewerNoPhaiTra.Clear();
                reportViewerNoPhaiTra.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }

        private void TinhTongTien()
        {
            if (nophaitraDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < nophaitraDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(nophaitraDataGridView.Rows[i].Cells["PhaiTra"].Value);
                }
                txtTongTien.Text = ST.ToString();
                txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
            }
            else txtTongTien.Text = "0";
        }

        private void chiTiếtBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idncc = Convert.ToInt32(nophaitraDataGridView.CurrentRow.Cells["idnhacungcap"].Value);
            string tenncc = Convert.ToString(nophaitraDataGridView.CurrentRow.Cells["TenNhaCC"].Value);
            string diachincc = Convert.ToString(nophaitraDataGridView.CurrentRow.Cells["DiaChi"].Value);
            string sdtncc = Convert.ToString(nophaitraDataGridView.CurrentRow.Cells["SoDienThoai"].Value);
            FormCTPhaiTra cttra = new FormCTPhaiTra(idncc, tenncc, diachincc, sdtncc);
            cttra.Show();
        }
    }
}
