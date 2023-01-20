using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes_Pet_Shop.View;
using Tubes_Pet_Shop.Controller;
using Tubes_Pet_Shop.Model;

namespace Tubes_Pet_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product prdct = new Product();
            prdct.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnUser_DoubleClick(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void btnMasterBarang_Click(object sender, EventArgs e)
        {
            MasterBarang master = new MasterBarang();
            master.ShowDialog();
        }
    }
}
