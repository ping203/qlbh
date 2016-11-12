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
    public partial class FormPhieuChi : Form
    {
        int group = 0;
        int myCount;
        int groupBoxLeftPosion = 0;
        int groupBoxTopPosion = 0;
        Control myTextBox;
        int myId;
        int myIdNhaCC = 0;
        int myIdtam = 0;
        decimal myPhaiTra;
        decimal tamtinh;
        Boolean myAdd, myEdit, myDelete, mySave;

        public FormPhieuChi()
        {
            InitializeComponent();
            this.MdiParent = FormMenu.ActiveForm;
        }

        private Form GetOpenedForm(string formName)
        {
            Form form = null;
            Form[] forms = FormMenu.ActiveForm.MdiChildren;//this.MdiChildren;

            foreach (Form f in forms)
            {
                if (f.Name == formName)
                {
                    form = f;
                    break;
                }
            }
            return form;
        }

        private void CloseOpenedForm(string formName)
        {
            Form[] forms = FormMenu.ActiveForm.MdiChildren;

            foreach (Form myForm in forms)
            {
                if (myForm.Name == formName)
                {
                    myForm.Close();
                }
            }
        }

        private void phieuchiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuchiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);
        }

        private void FormPhieuChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.phimtat' table. You can move, or remove it, as needed.
            this.phimtatTableAdapter.Fill(this.qLBHDataSet.phimtat);
            // TODO: This line of code loads data into the 'qLBHDataSet.nhacungcap' table. You can move, or remove it, as needed.
            this.nhacungcapTableAdapter.Fill(this.qLBHDataSet.nhacungcap);
            // TODO: This line of code loads data into the 'qLBHDataSet.phieuchi' table. You can move, or remove it, as needed.
            this.phieuchiTableAdapter.Fill(this.qLBHDataSet.phieuchi);
            reportViewerPhieuChi.Visible = false;
            gbxPhieuChi.Enabled = false;
            dataGridView_hide();
            XuLyConTro(true);
        }

        private void XuLyConTro(bool b)
        {
            btnThem.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = !b;
        }

        private void dataGridView_hide()
        {
            this.nhacungcapDataGridView.Visible = false;
            this.phimtatDataGridView.Visible = false;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            try
            {
                int centerF = this.Width / 2;
                gbxPhieuChi.Left = centerF - (gbxPhieuChi.Width / 2);
                gbxPhieuChi.Top = this.Top + 40;
                groupBoxLeftPosion = gbxPhieuChi.Left;
                groupBoxTopPosion = gbxPhieuChi.Top;
            }
            catch
            {
            }
        }

        #region Nhóm Button Click
        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                reportViewerPhieuChi.Visible = false;
                Form form = GetOpenedForm("FormSuaPhieuChi");
                if (form != null)
                    form.Activate();
                else
                {
                    form = new FormSuaPhieuChi();
                    form.Show();

                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbxPhieuChi.Enabled = true;
            txtTenNhaCC.Select();
            XuLyConTro(false);
            dataGridView_hide();
            ClearForNewRecord();
            int sh = (int)phieuchiTableAdapter.FillBySearchIdSoHieu();
            sh = sh + 100000001;
            string a = sh.ToString();
            txtSoHieu.Text = "PC-" + a.Substring(2);
            reportViewerPhieuChi.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (RecordCheckInput() == true)
            {
                {
                    phieuchiTableAdapter.InsertPhieuChi(
                                                        txtSoHieu.Text,
                                                        dtpNgayLap.Value,
                                                        myIdNhaCC,
                                                        txtTenNhaCC.Text,
                                                        txtDiaChi.Text,
                                                        txtSDT.Text,
                                                        txtLyDo.Text,
                                                        Convert.ToDecimal(txtSoTien.Text),
                                                        txtVBC.Text,
                                                        txtUser.Text,
                                                        "User",
                                                        txtGhiChu.Text
                                                        );
                    myId = (int)phieuchiTableAdapter.FillBySearchIdSoHieu();
                    nhacungcapTableAdapter.UpdatePhaiTraNhaCC(
                                                        myPhaiTra - Convert.ToDecimal(txtSoTien.Text),
                                                        myIdNhaCC
                                                        );
                }
                //
                {
                    string infor = "";
                    infor += "Bạn có muốn tiếp tục?" + "\n";
                    infor += "\n";
                    infor += "\n";
                    if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ClearForNewRecord();
                        txtTenNhaCC.Select();
                    }
                    else
                    {
                        gbxPhieuChi.Enabled = false;
                        XuLyConTro(true);
                    }
                }
                this.phieuchiTableAdapter.Fill(this.qLBHDataSet.phieuchi);
                PrintInvoice();
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            phieuchiBindingSource.CancelEdit();
            ClearForNewRecord();
            gbxPhieuChi.Enabled = false;
            dataGridView_hide();
            XuLyConTro(true);
        }

        private void btnNhaCCMoi_Click(object sender, EventArgs e)
        {
            FormNhaCungCap kh = new FormNhaCungCap();
            kh.Show();
        }
        #endregion

        #region Nhóm tham số
        private void ClearForNewRecord()
        {
            myId = 0;
            dtpNgayLap.Value = DateTime.Now;
            txtSoHieu.Text = "";
            myIdNhaCC = 0;
            txtTenNhaCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            myPhaiTra = 0;
            txtLyDo.Text = "";
            txtSoTien.Text = "0";
            txtVBC.Text = "";
            txtGhiChu.Text = "";
            txtUser.Text = Common.TenNhanVien;
            tamtinh = 0;
        }

        private Boolean RecordCheckInput()
        {
            string infor = "";
            mySave = true;
            if (txtTenNhaCC.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0
                || txtLyDo.Text.Length == 0 || txtSoHieu.Text.Length == 0)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa chưa được nhập" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (txtTenNhaCC.Text.Length > 300 || txtDiaChi.Text.Length > 300 || txtSDT.Text.Length > 30 || txtLyDo.Text.Length > 300
                || txtGhiChu.Text.Length > 300 || txtSoHieu.Text.Length > 10)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Một vài thông tin hàng hóa đã vượt quá số lượng ký tự quy định" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (Convert.ToInt32(myIdNhaCC) < 1)
            {
                infor += "Lỗi nhập liệu" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Thông tin nhà cung cấp không tồn tại" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            return mySave;
        }
        
        private void PrintInvoice()
        {
            this.DataTableReportPhieuChiTableAdapter.FillBy(this.DataSetReport.DataTableReportPhieuChi, myId);
            this.reportViewerPhieuChi.RefreshReport();
            //reportViewerPhieuChi.RenderingComplete += new RenderingCompleteEventHandler(PrintRV);
            reportViewerPhieuChi.Visible = true;
        }

        private void PrintRV(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewerPhieuChi.PrintDialog();
                reportViewerPhieuChi.Clear();
                reportViewerPhieuChi.LocalReport.ReleaseSandboxAppDomain();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        #region Nhóm AutoNumber
        private void AutoNumber(object sender, KeyPressEventArgs e)
        {
            int mykey = (int)e.KeyChar;
            if (!(char.IsNumber(e.KeyChar) || mykey == 44 || mykey == 46))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void AutoNumberSDT(object sender, KeyPressEventArgs e)
        {
            int mykey = (int)e.KeyChar;
            if (!(char.IsNumber(e.KeyChar) || mykey == 44 || mykey == 46 || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ' '))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void AutoNumberMST(object sender, KeyPressEventArgs e)
        {
            int mykey = (int)e.KeyChar;
            if (!(char.IsNumber(e.KeyChar) || mykey == 44 || mykey == 46 || e.KeyChar == '-'))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        #endregion

        #region Nhóm KeyDown
        private void txtTenNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                dtpNgayLap.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (nhacungcapDataGridView.Visible == true)
                {
                    myTextBox = txtTenNhaCC;
                    nhacungcapDataGridView.Select();
                    SendKeys.Send("{DOWN}");
                }
                else
                    txtDiaChi.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtDiaChi.Select();
            }
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtTenNhaCC.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtSDT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtSDT.Select();
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtDiaChi.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtLyDo.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtLyDo.Select();
            }
        }

        private void txtLyDo_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSDT.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (phimtatDataGridView.Visible == true)
                {
                    myTextBox = txtLyDo;
                    phimtatDataGridView.Select();
                }
                else
                    txtSoTien.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtSoTien.Select();
            }
        }

        private void txtSoTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtLyDo.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                txtGhiChu.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                txtGhiChu.Select();
            }
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                txtSoTien.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                btnLuu.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnLuu.Select();
            }
        }
        #endregion

        #region Nhóm tìm kiếm nhà cung cấp
        private void txtTenNhaCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNhaCC.Text.Trim().Length == 0)
                {
                    nhacungcapDataGridView.Visible = false;
                }
                else
                {
                    nhacungcapDataGridView.Visible = true;
                    nhacungcapDataGridView.DataSource = nhacungcapBindingSource;
                    this.nhacungcapTableAdapter.FillBySearch(this.qLBHDataSet.nhacungcap, "%" + txtTenNhaCC.Text + "%");
                    nhacungcapDataGridView.Width = 375;
                    myCount = nhacungcapDataGridView.RowCount;
                    if (myCount >= 5)
                    {
                        nhacungcapDataGridView.Height = 90;
                    }
                    else
                    {
                        nhacungcapDataGridView.Height = myCount * 23;
                    }
                    nhacungcapDataGridView.Left = groupBoxLeftPosion + txtTenNhaCC.Left + txtTenNhaCC.Text.Trim().Length * 55 / 10 + 20;
                    nhacungcapDataGridView.Top = groupBoxTopPosion + txtTenNhaCC.Top + 30;
                }
            }
            catch
            {

            }
        }

        private void txtTenNhaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (nhacungcapDataGridView.Visible == true && nhacungcapDataGridView.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && txtTenNhaCC.Text.ToString().Trim().Length > 0)
                    {
                        txtTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
                        myIdNhaCC = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["idnhacungcap1"].Value);
                        txtDiaChi.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                        txtSDT.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                        myPhaiTra = Convert.ToDecimal(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                        dataGridView_hide();
                        txtLyDo.Select();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtLyDo.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void dgwNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nhacungcapDataGridView.CurrentRow != null)
            {
                txtTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
                myIdNhaCC = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["idnhacungcap1"].Value);
                txtDiaChi.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                txtSDT.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                myPhaiTra = Convert.ToDecimal(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                MessageBox.Show("b");
                dataGridView_hide();
                txtLyDo.Select();
            }
        }

        private void dgvNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (nhacungcapDataGridView.CurrentRow != null)
                {
                    txtTenNhaCC.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["TenNhaCC1"].Value);
                    myIdNhaCC = Convert.ToInt32(nhacungcapDataGridView.CurrentRow.Cells["idnhacungcap1"].Value);
                    txtDiaChi.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["DiaChi1"].Value);
                    txtSDT.Text = Convert.ToString(nhacungcapDataGridView.CurrentRow.Cells["SoDienThoai1"].Value);
                    myPhaiTra = Convert.ToDecimal(nhacungcapDataGridView.CurrentRow.Cells["PhaiTra1"].Value);
                    MessageBox.Show("c");
                    dataGridView_hide();
                    txtLyDo.Select();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }
        #endregion

        #region Nhóm tìm phím tắt
        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtLyDo.Text.Trim().Length == 0)
                {
                    phimtatDataGridView.Visible = false;
                }
                else
                {
                    //object[] Myvar = { txtLyDo.Text.Trim(), "PhieuThu" };
                    phimtatDataGridView.Visible = true;
                    phimtatDataGridView.DataSource = phimtatBindingSource;
                    this.phimtatTableAdapter.FillBySearch(this.qLBHDataSet.phimtat, "%" + txtLyDo.Text + "%", "PhieuChi");
                    phimtatDataGridView.Width = 375;
                    myCount = phimtatDataGridView.RowCount;
                    if (myCount >= 5)
                    {
                        phimtatDataGridView.Height = 92;
                    }
                    else
                    {
                        phimtatDataGridView.Height = myCount * 23;
                    }
                    phimtatDataGridView.Left = groupBoxLeftPosion + txtLyDo.Left + txtLyDo.Text.Trim().Length * 55 / 10 + 20;
                    phimtatDataGridView.Top = groupBoxTopPosion + txtLyDo.Top + 30;
                }
            }
            catch
            {

            }
        }

        private void txtLyDo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
                if (phimtatDataGridView.Visible == true)
                {
                    if (e.KeyChar == 13 && phimtatDataGridView.CurrentRow != null)// && dgvWpersonName.Visible == true)
                    {
                        this.txtLyDo.Text = Convert.ToString(phimtatDataGridView.CurrentRow.Cells["Name"].Value);
                        phimtatDataGridView.Visible = false;
                    }
                    if (e.KeyChar == 13 && phimtatDataGridView.CurrentRow == null && txtLyDo.Text.Trim().Length > 0)
                    {
                        string infor = "";
                        infor += "Bạn muốn lưu : " + txtLyDo.Text.Trim() + "\n";
                        infor += "vào hệ thống để sử dụng cho lần sau?" + "\n";
                        infor += "\n";
                        infor += "\n";
                        infor += "napa500.com";

                        if (MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            phimtatTableAdapter.InsertPhimTat(txtLyDo.Text, "PhieuChi");
                        }
                        else
                        {
                            txtSoTien.Select();
                        }

                    }
                }
                else if (e.KeyChar == 13)
                {
                    txtSoTien.Select();
                }
            }
            catch
            {

            }
        }

        private void phimtatDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (phimtatDataGridView.CurrentRow != null)
            {
                this.txtLyDo.Text = Convert.ToString(phimtatDataGridView.CurrentRow.Cells["Name"].Value);
                dataGridView_hide();
                txtSoTien.Select();
            }
        }

        private void phimtatDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (phimtatDataGridView.CurrentRow != null)
                {
                    this.txtLyDo.Text = Convert.ToString(phimtatDataGridView.CurrentRow.Cells["Name"].Value);
                    dataGridView_hide();
                    txtSoTien.Select();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }
        #endregion

        private void DateTimePickerB_NgayLap_ValueChanged(object sender, EventArgs e)
        {
            lableB_NgayHT.Text = "Ngày " + Convert.ToString(dtpNgayLap.Value.Day + 100).Substring(1, 2) + " tháng " + Convert.ToString(dtpNgayLap.Value.Month + 100).Substring(1, 2) + " năm " + Convert.ToString(dtpNgayLap.Value.Year);
            txtTenNhaCC.Select();
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoTien.Text.Length != 0)
                {
                    double st = double.Parse(txtSoTien.Text.Replace(",", ""));
                    txtSoTien.Text = st.ToString("###,###,###,##0");
                    txtSoTien.Select(txtSoTien.TextLength, 0);
                }
                //
                txtVBC.Text = Common.So_chu(Convert.ToDouble(txtSoTien.Text));
            }
            catch { }
        }

        private void txtSoTien_Leave(object sender, EventArgs e)
        {
            if (this.txtSoTien.Text.Trim().Length != 0)
                txtSoTien.Text = string.Format("{0:n0}", Double.Parse(txtSoTien.Text));
            else txtSoTien.Text = "0";

        }
        
    }
}
