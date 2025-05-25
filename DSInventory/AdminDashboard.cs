using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSInventory
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void manageUsersBTN_Click(object sender, EventArgs e)
        {
            AdminManageUsers adminManageUsersForm = new AdminManageUsers();
            adminManageUsersForm.Show();
            this.Hide();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
            return;
        }

        private void manageItemsBTN_Click(object sender, EventArgs e)
        {
            AdminManageItems adminManageItemsForm = new AdminManageItems();
            adminManageItemsForm.Show();
            this.Hide();
            return;
        }

        private void inventoryReportBTN_Click(object sender, EventArgs e)
        {
            InventoryReport inventoryReportForm = new InventoryReport();
            inventoryReportForm.Show();
            this.Hide(); 
            return;

        }

        private void transactionReportBTN_Click(object sender, EventArgs e)
        {
            TransactionReport transactionReportForm = new TransactionReport();
            transactionReportForm.Show();
            this.Hide();
            return;
        }
    }
}
