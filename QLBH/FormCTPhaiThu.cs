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
    public partial class FormCTPhaiThu : Form
    {
        public FormCTPhaiThu(int myIdKH, string myTenKH, string myDCKH,string mySDTKH)
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
            myIdKhachHang = myIdKH;
            myTenKhachHang = myTenKH;
            myDiaChi = myDCKH;
            mySDT = mySDTKH;
        }

        int myIdKhachHang;
        string myTenKhachHang;
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
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportCTNoPhaiThu' table. You can move, or remove it, as needed.
            this.dataTableReportCTNoPhaiThuTableAdapter.Fill(this.dataSetReport.DataTableReportCTNoPhaiThu);
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportCTNoPhaiThu' table. You can move, or remove it, as needed.
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
            this.dataTableReportCTNoPhaiThuTableAdapter.FillByIdKhachHang(this.dataSetReport.DataTableReportCTNoPhaiThu,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdKhachHang,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            reportViewerCTNoPhaiThu.Visible = false;
            TinhTongTien();
            lbTenKhachHang.Text = myTenKhachHang.ToString();
            lbDiaChi.Text = myDiaChi.ToString();
            lbSDT.Text = mySDT.ToString();
        }

        private void btnInNoPhaiThu_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            this.dataTableReportCTNoPhaiThuTableAdapter.FillByIdKhachHang(this.dataSetReport.DataTableReportCTNoPhaiThu,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdKhachHang,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
            this.reportViewerCTNoPhaiThu.RefreshReport();
            reportViewerCTNoPhaiThu.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerCTNoPhaiThu.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerCTNoPhaiThu.PrintDialog();
                reportViewerCTNoPhaiThu.Clear();
                reportViewerCTNoPhaiThu.LocalReport.ReleaseSandboxAppDomain();
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
                this.dataTableReportCTNoPhaiThuTableAdapter.FillByIdKhachHang(this.dataSetReport.DataTableReportCTNoPhaiThu, 
                                                                                                                         dtpTuNgay.Text,
                                                                                                                         dtpDenNgay.Text,
                                                                                                                         myIdKhachHang,
                                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value <= dtpDenNgay.Value)
            {
                this.dataTableReportCTNoPhaiThuTableAdapter.FillByIdKhachHang(this.dataSetReport.DataTableReportCTNoPhaiThu,
                                                                                                         dtpTuNgay.Text,
                                                                                                         dtpDenNgay.Text,
                                                                                                         myIdKhachHang,
                                                                                                         Convert.ToDateTime(dtpTuNgay.Value),
                                                                                                         Convert.ToDateTime(dtpDenNgay.Value));
                TinhTongTien();
            }
        }
    }
}
