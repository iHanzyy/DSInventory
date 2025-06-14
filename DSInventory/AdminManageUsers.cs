﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DSInventory
{
    public partial class AdminManageUsers : Form
    {
        public AdminManageUsers()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Agar Full Size
            StyleDataGridView(); // Untuk Styling DataGridView
            showDisplay();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;");

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void showDisplay()
        {
            SqlCommand cmd = new SqlCommand("select * from users", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void search(string searchValue)
        {
            string query = "SELECT * FROM users WHERE CONCAT(id, username, password, fullName, role) LIKE @search";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("DATA YANG ANDA CARI TIDAK ADA!");
            }
        }

        private void StyleDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(72, 123, 237);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // pastikan klik bukan header atau area kosong
            {
                DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
                idTB.Text = dr.Cells[0].Value?.ToString() ?? "";
                usernameTB.Text = dr.Cells[1].Value?.ToString() ?? "";
                passwordTB.Text = dr.Cells[2].Value?.ToString() ?? "";
                fullNameTB.Text = dr.Cells[3].Value?.ToString() ?? "";
                roleCB.Text = dr.Cells[4].Value?.ToString() ?? "";
            }
        }

        private void addUserBTN_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;
            string fullName = fullNameTB.Text;
            string role = roleCB.Text;

            if (true)
            {
                SqlCommand cmd = new SqlCommand($"insert into users(username, password, fullName, role) values" +
                    $"('{username}', '{password}', '{fullName}','{role}')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                showDisplay();

            }
            else
            {
                MessageBox.Show("DATA TIDAK VALID!");
            }
        }

        private void editUserBTN_Click(object sender, EventArgs e)
        {
            string id = idTB.Text;
            string username = usernameTB.Text;
            string password = passwordTB.Text;
            string fullName = fullNameTB.Text;
            string role = roleCB.Text;

            if (true)
            {
                SqlCommand cmd = new SqlCommand($"update users set username='{username}', password='{password}', fullName='{fullName}', role='{role}' where id = '{id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("DATA BERHASIL DIUPDATE!");
                showDisplay();

            }
            else
            {
                MessageBox.Show("DATA GAGAL DIUPDATE!");
            }
        }

        private void deleteUserBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("YAKIN INGIN MENGHAPUS DATA INI?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string id = idTB.Text;
                SqlCommand cmd = new SqlCommand($"delete from users where id='{id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("BERHASIL HAPUS DATA!");
                showDisplay();
            }
            else
            {
                MessageBox.Show("GAGAL MENGHAPUS DATA!");
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text;
            search(searchValue);
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboardForm = new AdminDashboard();
            adminDashboardForm.Show();
            this.Hide();
            return;
        }

        private void AdminManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void roleCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fullNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
