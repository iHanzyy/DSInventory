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
            StyleDataGridView(); // Untuk Styling DataGridView
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
            string role = Session.Role?.ToUpper();

            Form dashboardForm = null;

            switch (role)
            {
                case "ADMIN":
                    dashboardForm = new AdminDashboard();
                    break;
                case "MANAGER":
                    dashboardForm = new ManagerDashboard();
                    break;
                case "STAFF GUDANG":
                    dashboardForm = new StaffGudangDashboard();
                    break;
                default:
                    MessageBox.Show("Role tidak dikenali. Tidak bisa kembali ke dashboard.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            dashboardForm.Show();
            this.Close(); // atau this.Hide(); jika tidak ingin ditutup sepenuhnya
        }
    }
}
