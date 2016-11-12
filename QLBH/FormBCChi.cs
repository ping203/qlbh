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
    public partial class FormBCChi : Form
    {
        public FormBCChi()
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
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
            this.dataTableReportBCChiTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportBCChi,
                                                                                        dtpTuNgay.Text,
                                                                                        dtpDenNgay.Text,
                                                                                        Convert.ToDateTime(dtpTuNgay.Value),
                                                                                        Convert.ToDateTime(dtpDenNgay.Value));
            TinhTongTien();
            reportViewerBCChi.Visible = false;
        }

        private void btnInTonKho_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            this.dataTableReportBCChiTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportBCChi, 
                                                                                            dtpTuNgay.Text, 
                                                                                            dtpDenNgay.Text, 
                                                                                            Convert.ToDateTime(dtpTuNgay.Value),
                                                                                            Convert.ToDateTime(dtpDenNgay.Value));
            this.reportViewerBCChi.RefreshReport();
            reportViewerBCChi.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerBCChi.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerBCChi.PrintDialog();
                reportViewerBCChi.Clear();
                reportViewerBCChi.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportBCChiTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportBCChi,
                                                                                            dtpTuNgay.Text,
                                                                                            dtpDenNgay.Text,
                                                                                            Convert.ToDateTime(dtpTuNgay.Value),
                                                                                            Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportBCChiTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportBCChi,
                                                                                            dtpTuNgay.Text,
                                                                                            dtpDenNgay.Text,
                                                                                            Convert.ToDateTime(dtpTuNgay.Value),
                                                                                            Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            if (bcchiDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < bcchiDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(bcchiDataGridView.Rows[i].Cells["SoTienChi"].Value);
                }
                txtTongTien.Text = ST.ToString();
                txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
            }
            else txtTongTien.Text = "0";
        }
    }
}
