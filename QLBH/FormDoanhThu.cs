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
    public partial class FormDoanhThu : Form
    {
        public FormDoanhThu()
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
            //DateTime dn = dtpDenNgay.Value.AddHours(24);
            this.dataTableReportDoanhThuTableAdapter.FillByDoanhThu(this.dataSetReport.DataTableReportDoanhThu,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            reportViewerCTXuatHang.Visible = false;
            TinhTongTien();
        }

        private void PrintInvoiceXuat()
        {
            this.dataTableReportDoanhThuTableAdapter.FillByDoanhThu(this.dataSetReport.DataTableReportDoanhThu,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
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
            if (ctxuathanghoaDataGridView.RowCount > 0)
            {
                decimal STChi = 0;
                decimal STThu = 0;
                decimal STLoiNhuan = 0;
                for (int i = 0; i < ctxuathanghoaDataGridView.RowCount; i++)
                {
                    STChi += Convert.ToDecimal(ctxuathanghoaDataGridView.Rows[i].Cells["SoTienChi"].Value);
                    STThu += Convert.ToDecimal(ctxuathanghoaDataGridView.Rows[i].Cells["SoTienThu"].Value);
                }
                STLoiNhuan = STThu - STChi;
                txtTienChi.Text = STChi.ToString();
                txtTienChi.Text = string.Format("{0:n0}", double.Parse(txtTienChi.Text));
                txtTienThu.Text = STThu.ToString();
                txtTienThu.Text = string.Format("{0:n0}", double.Parse(txtTienThu.Text));
                txtLoiNhuan.Text = STLoiNhuan.ToString();
                txtLoiNhuan.Text = string.Format("{0:n0}", double.Parse(txtLoiNhuan.Text));
            }
            else
            {
                txtTienChi.Text = "0";
                txtTienThu.Text = "0";
                txtLoiNhuan.Text = "0";
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportDoanhThuTableAdapter.FillByDoanhThu(this.dataSetReport.DataTableReportDoanhThu,
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
                this.dataTableReportDoanhThuTableAdapter.FillByDoanhThu(this.dataSetReport.DataTableReportDoanhThu,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
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
