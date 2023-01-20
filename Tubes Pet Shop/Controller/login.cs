using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Tubes_Pet_Shop.Controller
{
    internal class login
    {
        Koneksi koneksi = new Koneksi();
        public bool check_login(string user, string pass)
        {
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("Select * From t_admin Where user ='" +
                    user + "' AND pass ='" + pass + "'");
                if (reader.Read())
                {
                    koneksi.CloseConnection();
                    return true;
                }
                else
                {
                    koneksi.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal");
            }
            return false;
        }
    }
}
