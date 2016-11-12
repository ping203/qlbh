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
    public partial class FormCTHangHoa : Form
    {
        public FormCTHangHoa(int myIdHH, string MaHH, string TenHH, string KhoHH, decimal SLHH, decimal GTTKHH)
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
            myIdHangHoa = myIdHH;
            myMaHangHoa = MaHH;
            myTenHangHoa = TenHH;
            myKhoHangHoa = KhoHH;
            mySLHangHoa = SLHH;
            myGiaTriHangHoa = GTTKHH;
        }

        int myIdHangHoa;
        string myTenHangHoa;
        string myMaHangHoa;
        string myKhoHangHoa;
        decimal mySLHangHoa;
        decimal myGiaTriHangHoa;

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
            this.dataTableReportCTNhapHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTNhapHang,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdHangHoa,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            this.dataTableReportCTXuatHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTXuatHang,
                                                                                                         myIdHangHoa,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            reportViewerCTNhapHang.Visible = false;
            reportViewerCTXuatHang.Visible = false;
            TinhTongTien();
            lbMaHang.Text = myMaHangHoa.ToString();
            lbTenHang.Text = myTenHangHoa.ToString();
            lbKhoHang.Text = myKhoHangHoa.ToString();
            lbSLKho.Text = mySLHangHoa.ToString();
            lbSLKho.Text = string.Format("{0:n0}", double.Parse(lbSLKho.Text));
            lbGiaTriKho.Text = myGiaTriHangHoa.ToString();
            lbGiaTriKho.Text = string.Format("{0:n0}", double.Parse(lbGiaTriKho.Text));
        }

        private void btnInNoPhaiThu_Click(object sender, EventArgs e)
        {
            PrintInvoiceNhap();
        }

        private void PrintInvoiceNhap()
        {
            this.dataTableReportCTNhapHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTNhapHang,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdHangHoa,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            this.reportViewerCTNhapHang.RefreshReport();
            reportViewerCTNhapHang.RenderingComplete += new RenderingCompleteEventHandler(PrintRVNhap);
            reportViewerCTNhapHang.Visible = true;
        }

        private void PrintRVNhap(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerCTNhapHang.PrintDialog();
                reportViewerCTNhapHang.Clear();
                reportViewerCTNhapHang.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {

            }
        }

        private void PrintInvoiceXuat()
        {
            this.dataTableReportCTXuatHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTXuatHang,
                                                                                                         myIdHangHoa,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            this.dataTableReportCTNhapHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTNhapHang,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdHangHoa,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            
            this.reportViewerCTXuatHang.RefreshReport();
            reportViewerCTXuatHang.RenderingComplete += new RenderingCompleteEventHandler(PrintRVXuat);
            reportViewerCTXuatHang.Visible = true;
        }

        private void PrintRVXuat(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerCTXuatHang.PrintDialog();
                reportViewerCTXuatHang.Clear();
                reportViewerCTXuatHang.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {

            }
        }

        private void TinhTongTien()
        {
            if (ctnhaphanghoaDataGridView.RowCount > 0)
            {
                decimal STNhap = 0;
                for (int i = 0; i < ctnhaphanghoaDataGridView.RowCount; i++)
                {
                    STNhap += Convert.ToDecimal(ctnhaphanghoaDataGridView.Rows[i].Cells["ThanhTienNhap"].Value);
                }
                txtTienNhap.Text = STNhap.ToString();
                txtTienNhap.Text = string.Format("{0:n0}", double.Parse(txtTienNhap.Text));
            }
            else
            {
                txtTienNhap.Text = "0";
            }
            if (ctxuathanghoaDataGridView.RowCount > 0)
            {
                decimal STXuat = 0;
                for (int i = 0; i < ctxuathanghoaDataGridView.RowCount; i++)
                {
                    STXuat += Convert.ToDecimal(ctxuathanghoaDataGridView.Rows[i].Cells["ThanhTienXuat"].Value);
                }
                txtTienXuat.Text = STXuat.ToString();
                txtTienXuat.Text = string.Format("{0:n0}", double.Parse(txtTienXuat.Text));
            }
            else
            {
                txtTienXuat.Text = "0";
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportCTNhapHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTNhapHang,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdHangHoa,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
                this.dataTableReportCTXuatHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTXuatHang,
                                                                                                             myIdHangHoa,
                                                                                                             Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                             Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportCTNhapHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTNhapHang,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdHangHoa,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
                this.dataTableReportCTXuatHangTableAdapter.FillByIdHangHoa(this.dataSetReport.DataTableReportCTXuatHang,
                                                                                                             myIdHangHoa,
                                                                                                             Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                             Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }

        private void btnInChiTietXuat_Click(object sender, EventArgs e)
        {
            PrintInvoiceXuat();
        }
    }
}
