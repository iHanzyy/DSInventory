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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;");

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoDS_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void judul_Click(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;
            string role = roleCB.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username dan Password harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cek Admin 
                if (username == "admin" && password == "admin123" && role == "ADMIN")
                {
                    AdminDashboard adminForm = new AdminDashboard();
                    adminForm.Show();
                    this.Hide(); // Hide LoginForm
                    return;
                }

                // Cek Role
                string query = "SELECT COUNT(*) FROM [users] WHERE username = @username AND password = @password AND role = @role";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0 && role == "MANAGER")
                    {
                        // Login berhasil, beralih ke manager
                        ManagerDashboard managerForm = new ManagerDashboard();
                        managerForm.Show();
                        this.Hide();
                        return;
                    } else if (count > 0 && role == "STAFF GUDANG")
                    {
                        // Login berhasil, beralih ke staff gudang
                        StaffGudangDashboard staffGudangForm = new StaffGudangDashboard();
                        staffGudangForm.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengakses database:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
