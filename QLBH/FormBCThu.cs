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
    public partial class FormBCThu : Form
    {
        public FormBCThu()
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
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportBCThu' table. You can move, or remove it, as needed.
            this.dataTableReportBCThuTableAdapter.Fill(this.dataSetReport.DataTableReportBCThu);
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
            this.dataTableReportBCThuTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportBCThu,
                                                                                        dtpTuNgay.Text,
                                                                                        dtpDenNgay.Text,
                                                                                        Convert.ToDateTime(dtpTuNgay.Value),
                                                                                        Convert.ToDateTime(dtpDenNgay.Value));
            TinhTongTien();
           reportViewerBCThu.Visible = false;
        }

        private void btnInTonKho_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            this.dataTableReportBCThuTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportBCThu, 
                                                                                            dtpTuNgay.Text, 
                                                                                            dtpDenNgay.Text, 
                                                                                            Convert.ToDateTime(dtpTuNgay.Value),
                                                                                            Convert.ToDateTime(dtpDenNgay.Value));
            this.reportViewerBCThu.RefreshReport();
            reportViewerBCThu.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerBCThu.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerBCThu.PrintDialog();
                reportViewerBCThu.Clear();
                reportViewerBCThu.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportBCThuTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportBCThu,
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
                this.dataTableReportBCThuTableAdapter.FillBySearchNgay(this.dataSetReport.DataTableReportBCThu,
                                                                                            dtpTuNgay.Text,
                                                                                            dtpDenNgay.Text,
                                                                                            Convert.ToDateTime(dtpTuNgay.Value),
                                                                                            Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            if (bcthuDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < bcthuDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(bcthuDataGridView.Rows[i].Cells["SoTienThu"].Value);
                }
                txtTongTien.Text = ST.ToString();
                txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
            }
            else txtTongTien.Text = "0";
        }
    }
}
