using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLBH
{
    
    class KetNoi
    {
        IniFile ini;
        public KetNoi()
        {
            ini = new IniFile("C:\\test.ini");
        }
        public void connect()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["QLBH.Properties.Settings.qlbhConnectionString"].ConnectionString = "server=" + ini.IniReadValue("default", "host") + ";user id=" + ini.IniReadValue("default", "user") + ";password=" + ini.IniReadValue("default", "pass") + ";database=" + ini.IniReadValue("default", "db") + ";persistsecurityinfo=True";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        void kiemTra()
        {
            
            
        }
    }

}
