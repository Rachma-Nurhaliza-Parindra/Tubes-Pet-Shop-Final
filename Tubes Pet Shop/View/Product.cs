using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes_Pet_Shop.Controller;
using Tubes_Pet_Shop.Model;

namespace Tubes_Pet_Shop.View
{
    public partial class Product : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Product m_product = new M_Product();
        M_barang barang = new M_barang();
        string no;

        public void Tampil()
        {
            //Query DB
            //DataProduct.DataSource = koneksi.ShowData("SELECT *FROM t_product");
            DataProduct.DataSource = koneksi.ShowData("SELECT " + " no, t_product.id, name, price, qty, total " +
                "FROM t_product JOIN t_masterbarang ON t_masterbarang.id = t_product.id");

            //Mengubah Nama Kolom Tabel
            DataProduct.Columns[0].HeaderText = "NO";
            DataProduct.Columns[1].HeaderText = "Code Barang";
            DataProduct.Columns[2].HeaderText = "Nama Barang";
            DataProduct.Columns[3].HeaderText = "Harga Barang";
            DataProduct.Columns[4].HeaderText = "Qty";
            DataProduct.Columns[5].HeaderText = "Total";
        }
        public Product()
        {
            InitializeComponent();
        }
        public void GetDataBrg()
        {
            //ambil data ID Barang dari table (t_masterbarang) untuk mengisi data pada combobox ID Barang
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_masterbarang");
            while (reader.Read())
            {
                cbCodeBarang.Items.Add(reader.GetString("id"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
            GetDataBrg();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbCodeBarang.SelectedIndex == -1 || tbNamaBarang.Text == "" || tbHargaBarang.Text == "" || tbQty.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                product produk= new product();
                m_product.Id = cbCodeBarang.Text;
                barang.Name = tbNamaBarang.Text;
                barang.Price = tbHargaBarang.Text;
                m_product.Qty = tbQty.Text;
                m_product.Total = tbTotal.Text;

                produk.Insert(m_product);
                cbCodeBarang.SelectedIndex = -1;
                tbNamaBarang.Text = "";
                tbHargaBarang.Text = "";
                tbQty.Text = "";
                tbTotal.Text = "";

                Tampil();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbCodeBarang.SelectedIndex == -1 || tbNamaBarang.Text == "" || tbHargaBarang.Text == "" || tbQty.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                product produk = new product();
                m_product.Id = cbCodeBarang.Text;
                barang.Name = tbNamaBarang.Text;
                barang.Price = tbHargaBarang.Text;
                m_product.Qty = tbQty.Text;
                m_product.Total = tbTotal.Text;

                produk.Update (m_product, no);
                cbCodeBarang.SelectedIndex = -1;
                tbNamaBarang.Text = "";
                tbHargaBarang.Text = "";
                tbQty.Text = "";
                tbTotal.Text = "";

                Tampil();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                product produk = new product();
                produk.Delete(no);
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbCodeBarang.SelectedIndex = -1;
            tbNamaBarang.Text = "";
            tbHargaBarang.Text = "";
            tbQty.Text = "";
            tbTotal.Text = "";

            Tampil();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            //DataProduct.DataSource = koneksi.ShowData("SELECT * FROM t_product WHERE name LIKE '%' '" + tbSearch.Text + "' '%' OR nama LIKE '%' '" + tbSearch.Text + "' '%'");
        }

        public void GetNamaBrg()
        {
            //ambil data Nama Barang ketika combobox ID Barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT name FROM t_masterbarang " + "WHERE id = '" + cbCodeBarang.Text + "'");
            while (reader.Read())
            {
                tbNamaBarang.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetHargaBrg()
        {
            //ambil data Harga Barang ketikan combobox ID Barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT price FROM t_masterbarang " + "WHERE id = '" + cbCodeBarang.Text + "'");
            while (reader.Read())
            {
                tbHargaBarang.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void DataProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            no = DataProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbCodeBarang.Text = DataProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbNamaBarang.Text = DataProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHargaBarang.Text = DataProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbQty.Text = DataProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTotal.Text = DataProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //tbTotal.Text = (float.Parse(cbCodeBarang.Text) * float.Parse(tbQty.Text)).ToString();
                tbTotal.Text = (float.Parse(tbHargaBarang.Text) * float.Parse(tbQty.Text)).ToString();
            }
            catch
            {

            }
        }

        private void cbCodeBarang_TextChanged(object sender, EventArgs e)
        {
            GetNamaBrg();
            GetHargaBrg();
        }
        private void ExportExcel(DataGridView dataGrid, string searchData)
        {
            string Output = "";
            string Headers = "";

            //Export Title 
            for (int j = 0; j < dataGrid.ColumnCount; j++)
            {
                Headers = Headers.ToString() + Convert.ToString(dataGrid.Columns[j].HeaderText) + "\t";
            }
            Output += Headers + ",\r\n";

            //Export Data
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                string Line = "";
                for (int j = 0; j < dataGrid.Rows[i].Cells.Count; j++)
                {
                    Line = Line.ToString() + Convert.ToString(dataGrid.Rows[i].Cells[j].Value) + "\t";
                }
                Output += Line + "\r\n";
            }
            Encoding encoding = Encoding.GetEncoding(1254);
            //array dengan tipe byte
            byte[] ouputs = encoding.GetBytes(Output);
            FileStream file = new FileStream(searchData, FileMode.Create);
            BinaryWriter binary = new BinaryWriter(file);

            binary.Write(ouputs, 0, Output.Length);
            binary.Flush();
            binary.Close();
            file.Close();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Document (*.xls)|*.xls";
            save.FileName = "Report Product.xls";

            if (save.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(DataProduct, save.FileName);
            }
        }
    }
}
