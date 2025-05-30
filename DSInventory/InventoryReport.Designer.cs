namespace DSInventory
{
    partial class InventoryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReport));
            this.totalItemsTXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTXT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outOfStockTXT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backBTN = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalItemsTXT
            // 
            this.totalItemsTXT.AutoSize = true;
            this.totalItemsTXT.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsTXT.ForeColor = System.Drawing.Color.White;
            this.totalItemsTXT.Location = new System.Drawing.Point(109, 113);
            this.totalItemsTXT.Name = "totalItemsTXT";
            this.totalItemsTXT.Size = new System.Drawing.Size(28, 28);
            this.totalItemsTXT.TabIndex = 20;
            this.totalItemsTXT.Text = "0";
            this.totalItemsTXT.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "TOTAL ITEMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryTXT
            // 
            this.categoryTXT.AutoSize = true;
            this.categoryTXT.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTXT.ForeColor = System.Drawing.Color.White;
            this.categoryTXT.Location = new System.Drawing.Point(103, 113);
            this.categoryTXT.Name = "categoryTXT";
            this.categoryTXT.Size = new System.Drawing.Size(28, 28);
            this.categoryTXT.TabIndex = 20;
            this.categoryTXT.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "CATEGORIES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.categoryTXT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(311, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 184);
            this.panel2.TabIndex = 21;
            // 
            // outOfStockTXT
            // 
            this.outOfStockTXT.AutoSize = true;
            this.outOfStockTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outOfStockTXT.ForeColor = System.Drawing.Color.White;
            this.outOfStockTXT.Location = new System.Drawing.Point(111, 115);
            this.outOfStockTXT.Name = "outOfStockTXT";
            this.outOfStockTXT.Size = new System.Drawing.Size(26, 25);
            this.outOfStockTXT.TabIndex = 20;
            this.outOfStockTXT.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "OUT OF STOCK";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(1311, 197);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(391, 41);
            this.searchTB.TabIndex = 24;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(1490, 261);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(212, 59);
            this.searchBTN.TabIndex = 25;
            this.searchBTN.Text = "SEARCH";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 574);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 442);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::DSInventory.Properties.Resources.inventoryList;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(686, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 258);
            this.panel4.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(311, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 340);
            this.panel5.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totalItemsTXT);
            this.panel1.Location = new System.Drawing.Point(873, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 184);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.outOfStockTXT);
            this.panel3.Location = new System.Drawing.Point(1443, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 184);
            this.panel3.TabIndex = 23;
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Green;
            this.backBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.White;
            this.backBTN.Location = new System.Drawing.Point(1694, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(196, 79);
            this.backBTN.TabIndex = 31;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::DSInventory.Properties.Resources.searchLogo1;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(1218, 176);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(87, 87);
            this.panel6.TabIndex = 32;
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1902, 1175);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalItemsTXT;
        private System.Windows.Forms.Label categoryTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label outOfStockTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Panel panel6;
    }
}