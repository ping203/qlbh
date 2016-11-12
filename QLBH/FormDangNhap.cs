using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FormDangNhap : Form
    {
        int myCount;
        Control myTextBox;
        int myIdTK = 0;
        string myTaiKhoan;
        string myMatKhauTK;
        string myTenNhanVien;
        Boolean mySave;

        public FormDangNhap()
        {
            KetNoi kn = new KetNoi();
            kn.connect();
            InitializeComponent();
        }

        private void taikhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taikhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.taikhoan' table. You can move, or remove it, as needed.
            try
            {
                this.taikhoanTableAdapter.Fill(this.qLBHDataSet.taikhoan);
                taiKhoantextBox.Select();
            }
            catch (MySqlException  ex)
            {
                //chay file cau hinh
                FormCaiDatMysql cauhinh = new FormCaiDatMysql();
                cauhinh.Show();
            }
        }

        private void dataGridView_hide()
        {
            this.taikhoanDataGridView.Visible = false;
        }

        private void dangNhapbutton_Click(object sender, EventArgs e)
        {
            //che
            IniFile ini = new IniFile("C:\\test.ini");

            MySqlConnectionStringBuilder msb = new MySqlConnectionStringBuilder();
            msb.Server = ini.IniReadValue("default", "host");
            msb.Port = 3306;
            msb.UserID = ini.IniReadValue("default", "user");
            msb.Password = ini.IniReadValue("default", "pass");
            msb.Database = ini.IniReadValue("default", "db");
            MySqlConnection cnn = new MySqlConnection(msb.ConnectionString);
            try
            {
                //cnn.Close();
                //cnn.Open();
                //this.taikhoanTableAdapter.Fill(this.qLBHDataSet.taikhoan);
                if (RecordCheckInput() == true)
                {
                    this.Hide();
                    Form menu = new FormMenu();
                    menu.Show();
                    Common.User = myTaiKhoan;
                    Common.UserId = myIdTK;
                    Common.TenNhanVien = myTenNhanVien;
                    Common.MatKhau = matKhautextBox.Text;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi kết nối !!!"+ex.Message);
            }            
        }

        private Boolean RecordCheckInput()
        {
            string infor = "";
            mySave = true;
            if (myIdTK == 0 || myTaiKhoan != taiKhoantextBox.Text)
            {
                infor += "Lỗi đăng nhập" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Tài khoản không tồn tại" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (matKhautextBox.Text == "")
            {
                infor += "Lỗi đăng nhập" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Vui lòng nhập mật khẩu" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            else if (matKhautextBox.Text.Trim() != myMatKhauTK)
            {
                infor += "Lỗi đăng nhập" + "\n";
                infor += "----------------------------------" + "\n";
                infor += "Mật khẩu không đúng" + "\n";
                infor += "\n";
                infor += "\n";
                MessageBox.Show(infor, Common.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySave = false;
            }
            return mySave;
        }

        private void huyBobutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            FormCaiDatMysql f = new FormCaiDatMysql();
            f.Show();
        }

        private void taiKhoantextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (taiKhoantextBox.Text.Trim().Length == 0)
                {
                    taikhoanDataGridView.Visible = false;
                }
                else
                {
                    taikhoanDataGridView.Visible = true;
                    taikhoanDataGridView.DataSource = taikhoanBindingSource;
                    this.taikhoanTableAdapter.FillBySearch(this.qLBHDataSet.taikhoan, "%" + taiKhoantextBox.Text + "%");
                    taikhoanDataGridView.Width = 125;
                    myCount = taikhoanDataGridView.RowCount;
                    if (myCount >= 5)
                    {
                        taikhoanDataGridView.Height = 90;
                    }
                    else
                    {
                        taikhoanDataGridView.Height = myCount * 23;
                    }
                    taikhoanDataGridView.Left = taiKhoantextBox.Left + taiKhoantextBox.Text.Trim().Length * 55 / 10 + 20;
                    taikhoanDataGridView.Top = taiKhoantextBox.Top + 30;
                }
            }
            catch
            {

            }
        }

        private void taiKhoantextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                btnKetNoi.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                if (taikhoanDataGridView.Visible == true)
                {
                    myTextBox = taiKhoantextBox;
                    taikhoanDataGridView.Select();
                    SendKeys.Send("{DOWN}");
                }
                else
                    matKhautextBox.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                matKhautextBox.Select();
            }
        }

        private void taiKhoantextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (taikhoanDataGridView.Visible == true && taikhoanDataGridView.CurrentRow != null)
                {
                    if (e.KeyChar == 13 && taiKhoantextBox.Text.ToString().Trim().Length > 0)
                    {
                        myIdTK = Convert.ToInt32(taikhoanDataGridView.CurrentRow.Cells["idTaiKhoan"].Value);
                        taiKhoantextBox.Text = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenTaiKhoan"].Value);
                        myTaiKhoan = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenTaiKhoan"].Value);
                        myMatKhauTK = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["MatKhau"].Value);
                        myTenNhanVien = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenNhanVien"].Value);
                        dataGridView_hide();
                        matKhautextBox.Select();
                    }
                }
                else if (e.KeyChar == 13)
                {
                    matKhautextBox.Select();
                }

            }
            catch
            {
                //
            }
        }

        private void taikhoanDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (taikhoanDataGridView.CurrentRow != null)
                {
                    myIdTK = Convert.ToInt32(taikhoanDataGridView.CurrentRow.Cells["idTaiKhoan"].Value);
                    taiKhoantextBox.Text = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenTaiKhoan"].Value);
                    myTaiKhoan = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenTaiKhoan"].Value);
                    myMatKhauTK = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["MatKhau"].Value);
                    myTenNhanVien = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenNhanVien"].Value);
                    dataGridView_hide();
                    matKhautextBox.Select();
                }
            }
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                myTextBox.Select();
            }
        }

        private void taikhoanDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (taikhoanDataGridView.CurrentRow != null)
            {
                myIdTK = Convert.ToInt32(taikhoanDataGridView.CurrentRow.Cells["idTaiKhoan"].Value);
                taiKhoantextBox.Text = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenTaiKhoan"].Value);
                myTaiKhoan = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenTaiKhoan"].Value);
                myMatKhauTK = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["MatKhau"].Value);
                myTenNhanVien = Convert.ToString(taikhoanDataGridView.CurrentRow.Cells["TenNhanVien"].Value);
                dataGridView_hide();
                matKhautextBox.Select();
            }
        }

        private void matKhautextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 38)
            {
                taiKhoantextBox.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 40)
            {
                dangNhapbutton.Select();
            }
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                dangNhapbutton.Select();
            }
        }

    }
}
