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
    public partial class StaffGudangDashboard : Form
    {
        public StaffGudangDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
            return;
        }

        private void incomingItemsBTN_Click(object sender, EventArgs e)
        {
            StaffGudangIncomingItems incomingItemsForm = new StaffGudangIncomingItems();
            incomingItemsForm.Show();
            this.Hide();
            return;
        }

        private void outComingItemsBTN_Click(object sender, EventArgs e)
        {
            StaffGudangOutcomingItems outcomingItemsForm = new StaffGudangOutcomingItems();
            outcomingItemsForm.Show();
            this.Hide();
            return;
        }

        private void viewItemsBTN_Click(object sender, EventArgs e)
        {
            StaffGudangViewItems viewItemsForm = new StaffGudangViewItems();
            viewItemsForm.Show();
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
