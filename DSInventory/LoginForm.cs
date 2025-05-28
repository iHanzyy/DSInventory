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
            string username = usernameTB.Text.Trim();
            string password = passwordTB.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username dan Password harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cek jika admin hardcode
                if (username == "admin" && password == "admin123")
                {
                    AdminDashboard adminForm = new AdminDashboard();
                    adminForm.Show();
                    this.Hide();
                    return;
                }




                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_login_user", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        Session.UserId = reader.GetInt32(0);
                        Session.Username = reader.GetString(1);
                        Session.Role = reader.GetString(2);

                        string role = Session.Role;

                        if (role == "MANAGER")
                        {
                            ManagerDashboard managerForm = new ManagerDashboard();
                            managerForm.Show();
                        }
                        else if (role == "STAFF GUDANG")
                        {
                            StaffGudangDashboard staffForm = new StaffGudangDashboard();
                            staffForm.Show();
                        }
                        else if (role == "ADMIN")
                        {
                            AdminDashboard adminForm = new AdminDashboard();
                            adminForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Role tidak dikenali.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void roleCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
