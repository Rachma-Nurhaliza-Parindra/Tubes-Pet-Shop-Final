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
using Tubes_Pet_Shop.Model;

namespace Tubes_Pet_Shop.View
{
    public partial class MasterBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang barang = new M_barang();
        string id;

        public void Tampil()
        {
            //QueryDB
            DataBarang.DataSource = koneksi.ShowData("select * from t_masterbarang");

            //Mengubah Nama Kolom Table
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Type";
            DataBarang.Columns[3].HeaderText = "Category";
            DataBarang.Columns[4].HeaderText = "Price";
        }

        public MasterBarang()
        {
            InitializeComponent();
        }

        private void MasterBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbType.Text == "" || cbCategory.SelectedIndex == -1 || tbPrice.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                masterBarang masterbrg = new masterBarang();
                barang.Name = tbName.Text;
                barang.Type = tbType.Text;
                barang.Category = cbCategory.Text;
                barang.Price = tbPrice.Text;

                masterbrg.Insert(barang);

                tbName.Text = "";
                tbType.Text = "";
                cbCategory.SelectedIndex = -1;
                tbPrice.Text = "";


                Tampil();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbType.Text == "" || cbCategory.SelectedIndex == -1 || tbPrice.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                masterBarang masterbrg = new masterBarang();
                barang.Name = tbName.Text;
                barang.Type = tbType.Text;
                barang.Category = cbCategory.Text;
                barang.Price = tbPrice.Text;

                masterbrg.Update(barang, id);

                tbName.Text = "";
                tbType.Text = "";
                cbCategory.SelectedIndex = -1;
                tbPrice.Text = "";


                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbType.Text = "";
            cbCategory.SelectedIndex = -1;
            tbPrice.Text = "";


            Tampil();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                masterBarang masterbrg = new masterBarang();
                masterbrg.Delete(id);
                Tampil();
            }
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbName.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbType.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbCategory.Text = DataBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbPrice.Text = DataBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_masterbarang WHERE id" +
                
        }
    }
}
