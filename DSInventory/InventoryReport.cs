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
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Agar Full Size
            showDisplay();
            updateLabels();
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
        private void updateLabels()
        {
            try
            {
                conn.Open();

                // Total item (jumlah row)
                SqlCommand cmdTotal = new SqlCommand("SELECT COUNT(*) FROM items", conn);
                int totalItems = (int)cmdTotal.ExecuteScalar();
                totalItemsTXT.Text = totalItems.ToString();

                // Jumlah kategori unik
                SqlCommand cmdCategory = new SqlCommand("SELECT COUNT(DISTINCT category) FROM items", conn);
                int totalCategory = (int)cmdCategory.ExecuteScalar();
                categoryTXT.Text = totalCategory.ToString();

                // Jumlah item dengan quantity = 0 (out of stock)
                SqlCommand cmdOutOfStock = new SqlCommand("SELECT COUNT(*) FROM items WHERE quantity = 0", conn);
                int totalOutOfStock = (int)cmdOutOfStock.ExecuteScalar();
                outOfStockTXT.Text = totalOutOfStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update labels: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text;
            search(searchValue);
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBTN_Click(object sender, EventArgs e)
        {

        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
            return;
        }
    }
}
