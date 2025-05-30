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
            StyleDataGridView();
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
