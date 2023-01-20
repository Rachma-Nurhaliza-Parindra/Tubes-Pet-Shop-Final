﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tubes_Pet_Shop.View
{
    public partial class User : Form
    {
        Koneksi koneksi = new Koneksi();
        M_UserForm m_user = new M_UserForm();
        string id;
        public void Tampil()
        {
            //Query DB
            DataUser.DataSource = koneksi.ShowData("SELECT * FROM t_user");

            //Mengubah Nama Kolom Tabel
            DataUser.Columns[0].HeaderText = "ID";
            DataUser.Columns[1].HeaderText = "Name";
            DataUser.Columns[2].HeaderText = "Address";
            DataUser.Columns[3].HeaderText = "Phone";
            DataUser.Columns[4].HeaderText = "Role";
        }
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                userForm user = new userForm();
                m_user.Name = tbName.Text;
                m_user.Address = tbAddress.Text;
                m_user.Phone = tbPhone.Text;
                m_user.Role = cbRole.Text;

                user.Insert(m_user);
                tbName.Text = "";
                tbAddress.Text = "";
                tbPhone.Text = "";
                cbRole.SelectedIndex = -1;

                Tampil();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                userForm user = new userForm();
                m_user.Name = tbName.Text;
                m_user.Address = tbAddress.Text;
                m_user.Phone = tbPhone.Text;
                m_user.Role = cbRole.Text;

                user.Update(m_user, id);
                tbName.Text = "";
                tbAddress.Text = "";
                tbPhone.Text = "";
                cbRole.SelectedIndex = -1;

                Tampil();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                userForm user = new userForm();
                user.Delete(id);
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            cbRole.SelectedIndex = -1;

            Tampil();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            //DataUser.DataSource = koneksi.ShowData("SELECT * FROM t_user WHERE name LIKE '%' '" + tbCariData.Text + "' '%' OR name LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void DataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbName.Text = DataUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbAddress.Text = DataUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPhone.Text = DataUser.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbRole.Text = DataUser.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
