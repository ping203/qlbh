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
    public partial class FormPhaiThu : Form
    {
        public FormPhaiThu()
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
            // TODO: This line of code loads data into the 'dataSetReport.DataTableReportNoPhaiThu' table. You can move, or remove it, as needed.
            this.dataTableReportNoPhaiThuTableAdapter.Fill(this.dataSetReport.DataTableReportNoPhaiThu);
            reportViewerNoPhaiThu.Visible = false;
            txtSearchKhachHang.Select();
            TinhTongTien();
        }

        private void txtSearchHangHoa_TextChanged(object sender, EventArgs e)
        {
            this.dataTableReportNoPhaiThuTableAdapter.FillBySearchKhachHang(this.dataSetReport.DataTableReportNoPhaiThu, dtpTuNgay.Text, dtpDenNgay.Text, "%" + txtSearchKhachHang.Text + "%");
            TinhTongTien();
        }

        private void btnInNoPhaiThu_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            this.dataTableReportNoPhaiThuTableAdapter.FillBySearchKhachHang(this.dataSetReport.DataTableReportNoPhaiThu, dtpTuNgay.Text, dtpDenNgay.Text, "%" + txtSearchKhachHang.Text + "%");
            this.reportViewerNoPhaiThu.RefreshReport();
            reportViewerNoPhaiThu.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerNoPhaiThu.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerNoPhaiThu.PrintDialog();
                reportViewerNoPhaiThu.Clear();
                reportViewerNoPhaiThu.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }

        private void TinhTongTien()
        {
            if (nophaithuDataGridView.RowCount > 0)
            {
                decimal ST = 0;
                for (int i = 0; i < nophaithuDataGridView.RowCount; i++)
                {
                    ST += Convert.ToDecimal(nophaithuDataGridView.Rows[i].Cells["PhaiThu"].Value);
                }
                txtTongTien.Text = ST.ToString();
                txtTongTien.Text = string.Format("{0:n0}", double.Parse(txtTongTien.Text));
            }
            else txtTongTien.Text = "0";
        }

        private void chiTiếtBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idkh = Convert.ToInt32(nophaithuDataGridView.CurrentRow.Cells["idkhachhang"].Value);
            string tenkh = Convert.ToString(nophaithuDataGridView.CurrentRow.Cells["TenKhachHang"].Value);
            string diachikh = Convert.ToString(nophaithuDataGridView.CurrentRow.Cells["DiaChi"].Value);
            string sdtkh = Convert.ToString(nophaithuDataGridView.CurrentRow.Cells["SoDienThoai"].Value);
            FormCTPhaiThu ctthu = new FormCTPhaiThu(idkh,tenkh,diachikh,sdtkh);
            ctthu.Show();
        }

    }
}
