using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes_Pet_Shop.Controller;

namespace Tubes_Pet_Shop.View
{
    public partial class Login : Form
    {
        login cek_login = new login();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!", "Gagal");
            }
            else
            {
                string user = tbUsername.Text;
                string pass = tbPassword.Text;

                bool status = cek_login.check_login(user, pass);
                if (status)
                {
                    MessageBox.Show("Login berhasil", "Berhasil");
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Periksa kembali username dan password anda!", "Gagal");
                }
            }
        }
    }
}
