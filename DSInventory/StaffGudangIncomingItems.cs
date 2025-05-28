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
    public partial class StaffGudangIncomingItems : Form
    {
        public StaffGudangIncomingItems()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void StaffGudangIncomingItems_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT itemCode, itemName FROM items", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            selectItemBTN.DisplayMember = "itemName";
            selectItemBTN.ValueMember = "itemCode";
            selectItemBTN.DataSource = dt;


        }

        private void judul_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void manageUsersBTN_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void selectItemBTN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantityBTN_TextChanged(object sender, EventArgs e)
        {

        }

        private void transactionDateDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void submitTransactionBTN_Click(object sender, EventArgs e)
        {
            if (selectItemBTN.SelectedValue == null || string.IsNullOrWhiteSpace(quantityBTN.Text))
            {
                MessageBox.Show("Lengkapi semua data terlebih dahulu!");
                return;
            }
            string itemCode = selectItemBTN.SelectedValue.ToString();
            string quantity = quantityBTN.Text;
            DateTime date = transactionDateDTP.Value;
            string type = "Incoming";
            string status = "Pending";

            SqlCommand cmd = new SqlCommand("INSERT INTO [transaction] (itemCode, quantity, type, date, status, createdBy, approvedBy) " +
                "VALUES (@itemCode, @quantity, @type, @date, @status, @createdBy, NULL)", conn);

            cmd.Parameters.AddWithValue("@itemCode", itemCode);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@createdBy", Session.Username);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Transaksi berhasil dikirim. Menunggu persetujuan manager.");

            // Reset form
            quantityBTN.Text = "";
            selectItemBTN.SelectedIndex = -1;


        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            quantityBTN.Text = "";
            selectItemBTN.SelectedIndex = -1;
        }

        private void backToDashboardBTN_Click(object sender, EventArgs e)
        {
            StaffGudangDashboard staffGudangForm = new StaffGudangDashboard();
            staffGudangForm.Show();
            this.Close();
            return;
        }
    }
}
