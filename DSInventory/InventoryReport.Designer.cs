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
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalItemsTXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTXT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.outOfStockTXT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.judul = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.totalItemsTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(112, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // totalItemsTXT
            // 
            this.totalItemsTXT.AutoSize = true;
            this.totalItemsTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsTXT.ForeColor = System.Drawing.Color.Black;
            this.totalItemsTXT.Location = new System.Drawing.Point(86, 55);
            this.totalItemsTXT.Name = "totalItemsTXT";
            this.totalItemsTXT.Size = new System.Drawing.Size(26, 25);
            this.totalItemsTXT.TabIndex = 20;
            this.totalItemsTXT.Text = "0";
            this.totalItemsTXT.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryTXT
            // 
            this.categoryTXT.AutoSize = true;
            this.categoryTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTXT.ForeColor = System.Drawing.Color.Black;
            this.categoryTXT.Location = new System.Drawing.Point(86, 55);
            this.categoryTXT.Name = "categoryTXT";
            this.categoryTXT.Size = new System.Drawing.Size(26, 25);
            this.categoryTXT.TabIndex = 20;
            this.categoryTXT.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Categories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.categoryTXT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(532, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.panel3.Controls.Add(this.outOfStockTXT);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(955, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 22;
            // 
            // outOfStockTXT
            // 
            this.outOfStockTXT.AutoSize = true;
            this.outOfStockTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outOfStockTXT.ForeColor = System.Drawing.Color.Black;
            this.outOfStockTXT.Location = new System.Drawing.Point(86, 55);
            this.outOfStockTXT.Name = "outOfStockTXT";
            this.outOfStockTXT.Size = new System.Drawing.Size(26, 25);
            this.outOfStockTXT.TabIndex = 20;
            this.outOfStockTXT.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Out Of Stock";
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.ForeColor = System.Drawing.Color.Black;
            this.judul.Location = new System.Drawing.Point(105, 174);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(279, 40);
            this.judul.TabIndex = 23;
            this.judul.Text = "Inventory List";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(112, 217);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(247, 41);
            this.searchTB.TabIndex = 24;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.searchBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(381, 209);
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
            this.dataGridView1.Location = new System.Drawing.Point(112, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 292);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // logoutBTN
            // 
            this.logoutBTN.BackColor = System.Drawing.Color.Red;
            this.logoutBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.ForeColor = System.Drawing.Color.White;
            this.logoutBTN.Location = new System.Drawing.Point(936, 174);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(131, 49);
            this.logoutBTN.TabIndex = 27;
            this.logoutBTN.Text = "LOGOUT";
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalItemsTXT;
        private System.Windows.Forms.Label categoryTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label outOfStockTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logoutBTN;
    }
}