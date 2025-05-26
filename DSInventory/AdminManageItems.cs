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

namespace DSInventory
{
    public partial class AdminManageItems : Form
    {
        public AdminManageItems()
        {
            InitializeComponent(); dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Agar Full Size
            showDisplay();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void showDisplay()
        {
            SqlCommand cmd = new SqlCommand("select * from items", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void search(string searchValue)
        {
            string query = "SELECT * FROM items WHERE CONCAT(itemCode, itemName, quantity, category) LIKE @search";
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

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text;
            search(searchValue);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // pastikan klik bukan header atau area kosong
            {
                DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
                itemCodeTB.Text = dr.Cells[0].Value?.ToString() ?? "";
                itemNameTB.Text = dr.Cells[1].Value?.ToString() ?? "";
                quantityTB.Text = dr.Cells[2].Value?.ToString() ?? "";
                categoryTB.Text = dr.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void addItemBTN_Click(object sender, EventArgs e)
        {
            string itemCode = itemCodeTB.Text;
            string itemName = itemNameTB.Text;
            string quantity = quantityTB.Text;
            string category = categoryTB.Text;

            if (true)
            {
                SqlCommand cmd = new SqlCommand($"insert into items(itemCode, itemName, quantity, category) values" +
                    $"('{itemCode}', '{itemName}', '{quantity}','{category}')", conn);
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

        private void editItemBTN_Click(object sender, EventArgs e)
        {
            string itemCode = itemCodeTB.Text;
            string itemName = itemNameTB.Text;
            string quantity = quantityTB.Text;
            string category = categoryTB.Text;

            if (true)
            {
                SqlCommand cmd = new SqlCommand($"update items set itemCode='{itemCode}', itemName='{itemName}', quantity='{quantity}', category='{category}' where itemCode = '{itemCode}'", conn);
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

        private void deleteItemBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("YAKIN INGIN MENGHAPUS DATA INI?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string itemCode = itemCodeTB.Text;
                SqlCommand cmd = new SqlCommand($"delete from items where itemCode='{itemCode}'", conn);
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

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboardForm = new AdminDashboard();
            adminDashboardForm.Show();
            this.Hide();
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
