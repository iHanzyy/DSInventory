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

    public partial class ManagerPendingTransactions : Form
    {
        string selectedTransactionCode = "";
        
        public ManagerPendingTransactions()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Agar Full Size
            StyleDataGridView();
            showDisplay();

        }

        private void showDisplay()
        {
            string query = "SELECT * FROM [transaction] WHERE status = 'Pending'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
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



        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedTransactionCode = row.Cells["transactionCode"].Value.ToString();
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void backBTN_Click(object sender, EventArgs e)
        {
            ManagerDashboard managerDashboardForm = new ManagerDashboard();
            managerDashboardForm.Show();
            this.Hide();
            return;
        }

        private void approveBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTransactionCode))
            {
                MessageBox.Show("Pilih transaksi terlebih dahulu.");
                return;
            }

            conn.Open();

            // Ambil detail
            SqlCommand getCmd = new SqlCommand(
                "SELECT itemCode, quantity, type FROM [transaction] WHERE transactionCode = @code",
                conn);
            getCmd.Parameters.AddWithValue("@code", selectedTransactionCode);
            string itemCode = "", type = "";
            int qty = 0;

            using (SqlDataReader r = getCmd.ExecuteReader())
            {
                if (r.Read())
                {
                    itemCode = r["itemCode"].ToString();
                    qty = Convert.ToInt32(r["quantity"]);
                    type = r["type"].ToString();
                }
                else
                {
                    MessageBox.Show("Transaksi tidak ditemukan.");
                    conn.Close();
                    return;
                }
            }

            // **Jika jenis Outcoming, cek stok sebelum approve**
            if (type.Equals("Outcoming", StringComparison.OrdinalIgnoreCase))
            {
                SqlCommand checkStock = new SqlCommand(
                    "SELECT CAST(quantity AS INT) FROM items WHERE itemCode = @code",
                    conn);
                checkStock.Parameters.AddWithValue("@code", itemCode);
                int currentStock = (int)checkStock.ExecuteScalar();

                if (currentStock < qty)
                {
                    MessageBox.Show(
                        $"Stok tidak mencukupi untuk transaksi ini.\n" +
                        $"Stok saat ini: {currentStock}, permintaan: {qty}\n" +
                        $"Proses approve dibatalkan.");
                    conn.Close();
                    return;
                }
            }

            // Update status transaksi jadi Approved
            SqlCommand updateTrans = new SqlCommand(
                @"UPDATE [transaction]
          SET status = 'Approved',
              approvedBy = @approvedBy
          WHERE transactionCode = @code",
                conn);
            updateTrans.Parameters.AddWithValue("@approvedBy", Session.Username);
            updateTrans.Parameters.AddWithValue("@code", selectedTransactionCode);
            updateTrans.ExecuteNonQuery();

            // Adjust stok
            string updItemSql = type.Equals("Incoming", StringComparison.OrdinalIgnoreCase)
                ? "UPDATE items SET quantity = CAST(quantity AS INT) + @qty WHERE itemCode = @itemCode"
                : "UPDATE items SET quantity = CAST(quantity AS INT) - @qty WHERE itemCode = @itemCode";

            SqlCommand updateItems = new SqlCommand(updItemSql, conn);
            updateItems.Parameters.AddWithValue("@qty", qty);
            updateItems.Parameters.AddWithValue("@itemCode", itemCode);
            updateItems.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Transaksi disetujui dan stok di-update.");
            showDisplay();
            selectedTransactionCode = "";
        }

        private void rejectBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTransactionCode))
            {
                MessageBox.Show("Pilih transaksi terlebih dahulu.");
                return;
            }
            SqlCommand cmd = new SqlCommand("UPDATE [transaction] SET status = 'Rejected', approvedBy = @approvedBy WHERE transactionCode = @code", conn);
            cmd.Parameters.AddWithValue("@approvedBy", Session.Username);
            cmd.Parameters.AddWithValue("@code", selectedTransactionCode);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Transaksi ditolak.");
            showDisplay();
            selectedTransactionCode = "";
        }
    }
}
