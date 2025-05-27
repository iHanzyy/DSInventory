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
    public partial class StaffGudangViewItems : Form
    {
        public StaffGudangViewItems()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Agar Full Size
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

        private void addStockBTN_Click(object sender, EventArgs e)
        {
            StaffGudangIncomingItems incomingItemsForm = new StaffGudangIncomingItems();
            incomingItemsForm.Show();
            this.Hide();
            return;
        }

        private void reduceStockBTN_Click(object sender, EventArgs e)
        {
            StaffGudangOutcomingItems outcomingItemsForm = new StaffGudangOutcomingItems();
            outcomingItemsForm.Show();
            this.Hide();
            return;
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text;
            search(searchValue);
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            StaffGudangDashboard staffGudangDashboardForm = new StaffGudangDashboard();
            staffGudangDashboardForm.Show();
            this.Hide();
            return;
        }
    }
}
