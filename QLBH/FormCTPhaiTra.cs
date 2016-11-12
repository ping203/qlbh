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
    public partial class FormCTPhaiTra : Form
    {
        public FormCTPhaiTra(int myIdNCC, string myTenNCC, string myDCNCC,string mySDTNCC)
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
            myIdNhaCungCap = myIdNCC;
            myTenNhaCungCap = myTenNCC;
            myDiaChi = myDCNCC;
            mySDT = mySDTNCC;
        }

        int myIdNhaCungCap;
        string myTenNhaCungCap;
        string myDiaChi;
        string mySDT;

        private void hanghoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          //  this.hanghoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportCTNoPhaiTra' table. You can move, or remove it, as needed.
            this.dataTableReportCTNoPhaiTraTableAdapter.Fill(this.dataSetReport.DataTableReportCTNoPhaiTra);
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
            this.dataTableReportCTNoPhaiTraTableAdapter.FillByIdNhaCC(this.dataSetReport.DataTableReportCTNoPhaiTra,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdNhaCungCap,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            reportViewerCTNoPhaiTra.Visible = false;
            TinhTongTien();
            lbTenNhaCC.Text = myTenNhaCungCap.ToString();
            lbDiaChi.Text = myDiaChi.ToString();
            lbSDT.Text = mySDT.ToString();
        }

        private void btnInNoPhaiThu_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            this.dataTableReportCTNoPhaiTraTableAdapter.FillByIdNhaCC(this.dataSetReport.DataTableReportCTNoPhaiTra,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdNhaCungCap,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            this.reportViewerCTNoPhaiTra.RefreshReport();
            reportViewerCTNoPhaiTra.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerCTNoPhaiTra.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerCTNoPhaiTra.PrintDialog();
                reportViewerCTNoPhaiTra.Clear();
                reportViewerCTNoPhaiTra.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {

            }
        }

        private void TinhTongTien()
        {
            if (ctnophaithuDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < ctnophaithuDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(ctnophaithuDataGridView.Rows[i].Cells["ThanhTien"].Value);
                }
                txtTongTien.Text = ST.ToString();
                txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
            }
            else txtTongTien.Text = "0";
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportCTNoPhaiTraTableAdapter.FillByIdNhaCC(this.dataSetReport.DataTableReportCTNoPhaiTra, 
                                                                                                                         dtpTuNgay.Text,
                                                                                                                         dtpDenNgay.Text,
                                                                                                                         myIdNhaCungCap,
                                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportCTNoPhaiTraTableAdapter.FillByIdNhaCC(this.dataSetReport.DataTableReportCTNoPhaiTra,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdNhaCungCap,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }
    }
}
