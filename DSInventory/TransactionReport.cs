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
    public partial class TransactionReport : Form
    {
        public TransactionReport()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Agar Full Size
            showDisplay();
            loadSummaryCounts();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void showDisplay()
        {
            string query = @"
SELECT 
    t.transactionCode,
    t.itemCode,
    i.itemName,
    t.quantity,
    t.type,
    t.date,
    t.status,
    cu.fullname AS createdBy,
    au.fullname AS approvedBy,
    i.category
FROM [transaction] t
LEFT JOIN items i ON t.itemCode = i.itemCode
LEFT JOIN users cu ON t.createdBy = cu.username
LEFT JOIN users au ON t.approvedBy = au.username
";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;"))
            using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void search(string searchValue)
        {
            string query = @"
        SELECT 
            t.transactionCode,
            t.itemCode,
            i.itemName,
            t.quantity,
            t.type,
            t.date,
            t.status,
            cu.fullname AS createdBy,
            au.fullname AS approvedBy,
            i.category
        FROM [transaction] t
        LEFT JOIN items i ON t.itemCode = i.itemCode
        LEFT JOIN users cu ON t.createdBy = cu.username
        LEFT JOIN users au ON t.approvedBy = au.username
        WHERE ISNULL(CAST(t.transactionCode AS VARCHAR), '') 
            + ISNULL(t.itemCode, '') 
            + ISNULL(i.itemName, '') 
            + ISNULL(t.quantity, '') 
            + ISNULL(t.type, '') 
            + ISNULL(CONVERT(VARCHAR, t.date, 120), '') 
            + ISNULL(t.status, '') 
            + ISNULL(cu.fullname, '') 
            + ISNULL(au.fullname, '') 
            + ISNULL(i.category, '') LIKE @search";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;"))
            using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
            {
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("DATA YANG ANDA CARI TIDAK ADA!");
                }
            }
        }
        private void loadSummaryCounts()
        {
            string totalQuery = "SELECT COUNT(*) FROM [transaction]";
            string incomingQuery = "SELECT COUNT(*) FROM [transaction] WHERE type = 'Incoming'";
            string outgoingQuery = "SELECT COUNT(*) FROM [transaction] WHERE type = 'Outgoing'";
            string pendingQuery = "SELECT COUNT(*) FROM [transaction] WHERE status = 'Pending'";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(totalQuery, conn))
                {
                    totalTransactionsTXT.Text = cmd.ExecuteScalar().ToString();
                }

                using (SqlCommand cmd = new SqlCommand(incomingQuery, conn))
                {
                    incomingTransactionTXT.Text = cmd.ExecuteScalar().ToString();
                }

                using (SqlCommand cmd = new SqlCommand(outgoingQuery, conn))
                {
                    outgoingTransactionTXT.Text = cmd.ExecuteScalar().ToString();
                }

                using (SqlCommand cmd = new SqlCommand(pendingQuery, conn))
                {
                    pendingApprovalTXT.Text = cmd.ExecuteScalar().ToString();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text;
            search(searchValue);
        }


        private void totalTransactionsTXT_Click(object sender, EventArgs e)
        {

        }

        private void incomingTransactionTXT_Click(object sender, EventArgs e)
        {

        }

        private void outgoingTransactionTXT_Click(object sender, EventArgs e)
        {

        }

        private void pendingApprovalTXT_Click(object sender, EventArgs e)
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
