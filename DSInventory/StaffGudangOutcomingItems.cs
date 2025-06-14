﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DSInventory
{
    public partial class StaffGudangOutcomingItems : Form
    {
        
        public StaffGudangOutcomingItems()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSInventory;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void backToDashboardBTN_Click(object sender, EventArgs e)
        {
            StaffGudangDashboard staffGudangForm = new StaffGudangDashboard();
            staffGudangForm.Show();
            this.Hide();
            return;
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
            // validasi input
            if (selectItemBTN.SelectedValue == null || string.IsNullOrWhiteSpace(quantityBTN.Text))
            {
                MessageBox.Show("Lengkapi semua data terlebih dahulu!");
                return;
            }

            string itemCode = selectItemBTN.SelectedValue.ToString();

            // validasi angka
            if (!int.TryParse(quantityBTN.Text, out int requestedQty))
            {
                MessageBox.Show("Jumlah harus berupa angka bulat!");
                return;
            }

            // **CEK STOK SAAT INI**
            object rawStock;
            using (var checkStock = new SqlCommand(
                "SELECT quantity FROM items WHERE itemCode = @code", conn))
            {
                checkStock.Parameters.AddWithValue("@code", itemCode);
                conn.Open();
                rawStock = checkStock.ExecuteScalar();
                conn.Close();
            }

            // cek null / DBNull
            if (rawStock == null || rawStock == DBNull.Value)
            {
                MessageBox.Show("Item tidak ditemukan atau stok belum diatur.");
                return;
            }

            // unbox aman ke int (bisa dari bigint, smallint, decimal, dll.)
            int currentStock = Convert.ToInt32(rawStock);

            if (requestedQty > currentStock)
            {
                MessageBox.Show(
                    $"Stok tidak mencukupi!\n" +
                    $"Stok saat ini: {currentStock}, permintaan: {requestedQty}");
                return;
            }

            // kalau cukup, masukkan transaksi pending
            DateTime date = transactionDateDTP.Value;
            const string type = "Outcoming";
            const string status = "Pending";

            using (var cmd = new SqlCommand(
                @"INSERT INTO [transaction]
          (itemCode, quantity, type, date, status, createdBy, approvedBy)
          VALUES
          (@itemCode, @quantity, @type, @date, @status, @createdBy, NULL)",
                conn))
            {
                cmd.Parameters.AddWithValue("@itemCode", itemCode);
                cmd.Parameters.AddWithValue("@quantity", requestedQty);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@createdBy", Session.Username);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

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

        private void StaffGudangOutcomingItems_Load(object sender, EventArgs e)
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
    }
}
