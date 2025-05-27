namespace DSInventory
{
    partial class StaffGudangViewItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffGudangViewItems));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.judul = new System.Windows.Forms.Label();
            this.reduceStockBTN = new System.Windows.Forms.Button();
            this.addStockBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 292);
            this.dataGridView1.TabIndex = 13;
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.searchBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(898, 177);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(212, 59);
            this.searchBTN.TabIndex = 12;
            this.searchBTN.Text = "SEARCH";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(863, 130);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(247, 41);
            this.searchTB.TabIndex = 11;
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.ForeColor = System.Drawing.Color.Black;
            this.judul.Location = new System.Drawing.Point(152, 130);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(185, 40);
            this.judul.TabIndex = 10;
            this.judul.Text = "Item List";
            // 
            // reduceStockBTN
            // 
            this.reduceStockBTN.BackColor = System.Drawing.Color.Red;
            this.reduceStockBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduceStockBTN.ForeColor = System.Drawing.Color.White;
            this.reduceStockBTN.Location = new System.Drawing.Point(898, 572);
            this.reduceStockBTN.Name = "reduceStockBTN";
            this.reduceStockBTN.Size = new System.Drawing.Size(212, 59);
            this.reduceStockBTN.TabIndex = 25;
            this.reduceStockBTN.Text = "REDUCE STOCK";
            this.reduceStockBTN.UseVisualStyleBackColor = false;
            this.reduceStockBTN.Click += new System.EventHandler(this.reduceStockBTN_Click);
            // 
            // addStockBTN
            // 
            this.addStockBTN.BackColor = System.Drawing.Color.Green;
            this.addStockBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockBTN.ForeColor = System.Drawing.Color.White;
            this.addStockBTN.Location = new System.Drawing.Point(168, 572);
            this.addStockBTN.Name = "addStockBTN";
            this.addStockBTN.Size = new System.Drawing.Size(212, 59);
            this.addStockBTN.TabIndex = 24;
            this.addStockBTN.Text = "ADD STOCK";
            this.addStockBTN.UseVisualStyleBackColor = false;
            this.addStockBTN.Click += new System.EventHandler(this.addStockBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Green;
            this.backBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.White;
            this.backBTN.Location = new System.Drawing.Point(504, 65);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(131, 49);
            this.backBTN.TabIndex = 28;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // StaffGudangViewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.reduceStockBTN);
            this.Controls.Add(this.addStockBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.judul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffGudangViewItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffGudangViewItems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Button reduceStockBTN;
        private System.Windows.Forms.Button addStockBTN;
        private System.Windows.Forms.Button backBTN;
    }
}