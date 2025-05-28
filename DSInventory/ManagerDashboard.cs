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
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
            return;
        }

        private void manageItemsBTN_Click(object sender, EventArgs e)
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

        private void pendingTransactionsBTN_Click(object sender, EventArgs e)
        {
            ManagerPendingTransactions pendingTransactionsForm = new ManagerPendingTransactions();
            pendingTransactionsForm.Show();
            this.Hide();
            return;
        }
    }
}
