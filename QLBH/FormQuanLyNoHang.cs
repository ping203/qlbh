using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FormQuanLyNoHang : Form
    {
        Boolean myTatCa,myNo, myConNo, myDaTra, myDaTru;
        int myIdCTPhieuXuat;

        public FormQuanLyNoHang()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private void hanghoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nohangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.nohang' table. You can move, or remove it, as needed.
            this.nohangTableAdapter.FillByTatCaNo(this.qLBHDataSet.nohang, "Nợ" ,"%" + txtSearchNoHang.Text + "%" ,"Trả" ,"Trừ");
            myTatCa = true;
            myNo = false;
            myConNo = false;
            myDaTra = false;
            myDaTru = false;
            txtSearchNoHang.Select();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            txtSearchNoHang.Text = "";
            this.nohangTableAdapter.FillByTatCaNo(this.qLBHDataSet.nohang, "Nợ", "%" + txtSearchNoHang.Text + "%", "Trả", "Trừ");
            myTatCa = true;
            myNo = false;
            myConNo = false;
            myDaTra = false;
            myDaTru = false;
            txtSearchNoHang.Select();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            txtSearchNoHang.Text = "";
            this.nohangTableAdapter.FillBySearchNo(this.qLBHDataSet.nohang, "Nợ", "%" + txtSearchNoHang.Text + "%");
            myTatCa = false;
            myNo = true;
            myConNo = false;
            myDaTra = false;
            myDaTru = false;
            txtSearchNoHang.Select();
        }

        private void btnConNo_Click(object sender, EventArgs e)
        {
            txtSearchNoHang.Text = "";
            this.nohangTableAdapter.FillBySearchConNo(this.qLBHDataSet.nohang, "Nợ", "%" + txtSearchNoHang.Text + "%", 0);
            myTatCa = false;
            myNo = false;
            myConNo = true;
            myDaTra = false;
            myDaTru = false;
            txtSearchNoHang.Select();
        }

        private void btnDaTra_Click(object sender, EventArgs e)
        {
            txtSearchNoHang.Text = "";
            this.nohangTableAdapter.FillBySearchTra(this.qLBHDataSet.nohang, "Trả", "%" + txtSearchNoHang.Text + "%");
            myTatCa = false;
            myNo = false;
            myConNo = false;
            myDaTra = true;
            myDaTru = false;
            txtSearchNoHang.Select();
        }

        private void btnDaTru_Click(object sender, EventArgs e)
        {
            txtSearchNoHang.Text = "";
            this.nohangTableAdapter.FillBySearchTru(this.qLBHDataSet.nohang, "Trừ", "%" + txtSearchNoHang.Text + "%");
            myTatCa = false;
            myNo = false;
            myConNo = false;
            myDaTra = false;
            myDaTru = true;
            txtSearchNoHang.Select();
        }

        private void txtSearchNoHang_TextChanged(object sender, EventArgs e)
        {
            if (myTatCa == true)
            {
                this.nohangTableAdapter.FillByTatCaNo(this.qLBHDataSet.nohang, "Nợ", "%" + txtSearchNoHang.Text + "%", "Trả", "Trừ");
            }
            if (myNo == true)
            {
                this.nohangTableAdapter.FillBySearchNo(this.qLBHDataSet.nohang, "Nợ", "%" + txtSearchNoHang.Text + "%");
            }
            if (myConNo == true)
            {
                this.nohangTableAdapter.FillBySearchConNo(this.qLBHDataSet.nohang, "Nợ", "%" + txtSearchNoHang.Text + "%",0);
            }
            if (myDaTra == true)
            {
                this.nohangTableAdapter.FillBySearchTra(this.qLBHDataSet.nohang, "Trả", "%" + txtSearchNoHang.Text + "%");
            }
            if (myDaTru == true)
            {
                this.nohangTableAdapter.FillBySearchTru(this.qLBHDataSet.nohang, "Trừ", "%" + txtSearchNoHang.Text + "%");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
