using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace QLBH
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            try
            {
                BackupData();
                MessageBox.Show("Đã backup cơ sở dữ liệu");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Backup Database");
                return;
            }
        }

        private static void BackupData()
        {
            IniFile ini = new IniFile("C:\\test.ini");

            MySqlConnectionStringBuilder msb = new MySqlConnectionStringBuilder();
            msb.Server = ini.IniReadValue("default", "host");
            msb.Port = 3306;
            msb.UserID = ini.IniReadValue("default", "user");
            msb.Password = ini.IniReadValue("default", "pass");
            msb.Database = ini.IniReadValue("default", "db");
            string sqlBackup = "D:\\baokhoa\\backup\\backupQLBHTinDung.sql";
            using (MySqlConnection cnn = new MySqlConnection(msb.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = cnn;
                        cnn.Open();
                        mb.ExportToFile(sqlBackup);
                        cnn.Close();
                    }
                }
            }
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

        private void CloseAllOpenForm()
        {
            CloseOpenedForm("FormHangHoa");
            CloseOpenedForm("FormKhachHang");
            CloseOpenedForm("FormNhaCungCap");
            CloseOpenedForm("FormPhieuChi");
            CloseOpenedForm("FormSuaPhieuChi");
            CloseOpenedForm("FormPhieuNhap");
            CloseOpenedForm("FormSuaPhieuNhap");
            CloseOpenedForm("FormPhieuThu");
            CloseOpenedForm("FormSuaPhieuThu");
            CloseOpenedForm("FormPhieuXuat");
            CloseOpenedForm("FormSuaPhieuXuat");
            CloseOpenedForm("FormNoHang");
            CloseOpenedForm("FormTonKho");
            CloseOpenedForm("FormNhapKho");
            CloseOpenedForm("FormXuatKho");
            CloseOpenedForm("FormNoHang");
            CloseOpenedForm("FormQuanLyNoHang");
            CloseOpenedForm("FormQuanLyTaiKhoan");
            CloseOpenedForm("FormBCChi");
            CloseOpenedForm("FormBCThu");
            CloseOpenedForm("FormPhaiThu");
            CloseOpenedForm("FormPhaiTra");
            CloseOpenedForm("FormBCBanHang");
            CloseOpenedForm("FormDoanhThu");
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormKhachHang");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormKhachHang();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormNhaCungCap");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormNhaCungCap();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void phiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormPhieuChi");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormPhieuChi();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormPhieuThu");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormPhieuThu();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void nhậpHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormPhieuNhap");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormPhieuNhap();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void xuấtHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormPhieuXuat");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormPhieuXuat();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void quảnLýNợHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormQuanLyNoHang");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormQuanLyNoHang();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CloseAllOpenForm();
                Form form = GetOpenedForm("FormQuanLyTaiKhoan");
                if (form != null)
                    form.Activate();
                else
                {
                    form = new FormQuanLyTaiKhoan();
                    form.Show();

                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }      

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormHangHoa");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormHangHoa();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CloseAllOpenForm();
                Form form = GetOpenedForm("FormTonKho");
                if (form != null)
                    form.Activate();
                else
                {
                    form = new FormTonKho();
                    form.Show();

                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormNhapKho");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormNhapKho();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId != 3)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormXuatKho");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormXuatKho();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void báoCáoChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId == 1)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormBCChi");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormBCChi();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void báoCáoThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId == 1)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormBCThu");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormBCThu();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void nợPhảiThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId == 1)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormPhaiThu");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormPhaiThu();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void nợPhảiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId == 1)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormPhaiTra");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormPhaiTra();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void báoCáoBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId == 1)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormBCBanHang");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormBCBanHang();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void báoCáoLợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Common.UserId == 1)
                {
                    CloseAllOpenForm();
                    Form form = GetOpenedForm("FormDoanhThu");
                    if (form != null)
                        form.Activate();
                    else
                    {
                        form = new FormDoanhThu();
                        form.Show();

                    }
                }
                else MessageBox.Show("Bạn không có quyền truy cập !!!");
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
