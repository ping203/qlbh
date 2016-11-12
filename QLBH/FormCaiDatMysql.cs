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
    public partial class FormCaiDatMysql : Form
    {
        Configuration configuration;
        IniFile ini;
        public FormCaiDatMysql()
        {
                ini = new IniFile("C:\\test.ini");
            
            InitializeComponent();
            this.textBoxDBName.Text = ini.IniReadValue("default", "db");
            this.textBoxHost.Text = ini.IniReadValue("default", "host");
            this.textBoxUser.Text = ini.IniReadValue("default", "user");
            this.textBoxPass.Text = ini.IniReadValue("default", "pass");            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ini.IniWriteValue("default", "host", this.textBoxHost.Text);
            ini.IniWriteValue("default", "user", this.textBoxUser.Text);
            ini.IniWriteValue("default", "pass", this.textBoxPass.Text);
            ini.IniWriteValue("default", "db", this.textBoxDBName.Text);
            MessageBox.Show("Đã lưu kết nối !!!");
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder msb = new MySqlConnectionStringBuilder();
            msb.Server = this.textBoxHost.Text;
            msb.Port = 3306;
            msb.UserID = this.textBoxUser.Text;
            msb.Password = this.textBoxPass.Text;
            msb.Database = this.textBoxDBName.Text;
            MySqlConnection cnn = new MySqlConnection(msb.ConnectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Kết nối thành công !!!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Kết nối thất bại !!!");
            }
        }

        private void FormCaiDatMysql_Load(object sender, EventArgs e)
        {

        }
    }
}
