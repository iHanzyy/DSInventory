namespace DSInventory
{
    partial class AdminManageItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageItems));
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.addItemBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteItemBTN = new System.Windows.Forms.Button();
            this.editItemBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemCodeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryTB = new System.Windows.Forms.TextBox();
            this.backBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(1490, 261);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(212, 59);
            this.searchBTN.TabIndex = 8;
            this.searchBTN.Text = "SEARCH";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(1311, 197);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(391, 41);
            this.searchTB.TabIndex = 7;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // addItemBTN
            // 
            this.addItemBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addItemBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBTN.ForeColor = System.Drawing.Color.White;
            this.addItemBTN.Location = new System.Drawing.Point(1475, 834);
            this.addItemBTN.Name = "addItemBTN";
            this.addItemBTN.Size = new System.Drawing.Size(212, 59);
            this.addItemBTN.TabIndex = 5;
            this.addItemBTN.Text = "ADD NEW ITEM";
            this.addItemBTN.UseVisualStyleBackColor = false;
            this.addItemBTN.Click += new System.EventHandler(this.addItemBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 442);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // deleteItemBTN
            // 
            this.deleteItemBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteItemBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemBTN.ForeColor = System.Drawing.Color.White;
            this.deleteItemBTN.Location = new System.Drawing.Point(1475, 990);
            this.deleteItemBTN.Name = "deleteItemBTN";
            this.deleteItemBTN.Size = new System.Drawing.Size(212, 59);
            this.deleteItemBTN.TabIndex = 20;
            this.deleteItemBTN.Text = "DELETE ITEM";
            this.deleteItemBTN.UseVisualStyleBackColor = false;
            this.deleteItemBTN.Click += new System.EventHandler(this.deleteItemBTN_Click);
            // 
            // editItemBTN
            // 
            this.editItemBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editItemBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemBTN.ForeColor = System.Drawing.Color.White;
            this.editItemBTN.Location = new System.Drawing.Point(1475, 910);
            this.editItemBTN.Name = "editItemBTN";
            this.editItemBTN.Size = new System.Drawing.Size(212, 59);
            this.editItemBTN.TabIndex = 19;
            this.editItemBTN.Text = "EDIT ITEM";
            this.editItemBTN.UseVisualStyleBackColor = false;
            this.editItemBTN.Click += new System.EventHandler(this.editItemBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(818, 834);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Item Code";
            // 
            // itemCodeTB
            // 
            this.itemCodeTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCodeTB.Location = new System.Drawing.Point(823, 862);
            this.itemCodeTB.Multiline = true;
            this.itemCodeTB.Name = "itemCodeTB";
            this.itemCodeTB.Size = new System.Drawing.Size(247, 41);
            this.itemCodeTB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(818, 944);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantity";
            // 
            // quantityTB
            // 
            this.quantityTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTB.Location = new System.Drawing.Point(823, 977);
            this.quantityTB.Multiline = true;
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(247, 41);
            this.quantityTB.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1127, 834);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item Name";
            // 
            // itemNameTB
            // 
            this.itemNameTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTB.Location = new System.Drawing.Point(1132, 862);
            this.itemNameTB.Multiline = true;
            this.itemNameTB.Name = "itemNameTB";
            this.itemNameTB.Size = new System.Drawing.Size(247, 41);
            this.itemNameTB.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1127, 944);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Category";
            // 
            // categoryTB
            // 
            this.categoryTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTB.Location = new System.Drawing.Point(1132, 972);
            this.categoryTB.Multiline = true;
            this.categoryTB.Name = "categoryTB";
            this.categoryTB.Size = new System.Drawing.Size(247, 41);
            this.categoryTB.TabIndex = 25;
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Green;
            this.backBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.White;
            this.backBTN.Location = new System.Drawing.Point(1694, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(196, 79);
            this.backBTN.TabIndex = 27;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DSInventory.Properties.Resources.itemlist1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(686, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 258);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(311, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 340);
            this.panel2.TabIndex = 29;
            // 
            // AdminManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1902, 1175);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.deleteItemBTN);
            this.Controls.Add(this.editItemBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemCodeTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.addItemBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminManageItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManageItems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button addItemBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteItemBTN;
        private System.Windows.Forms.Button editItemBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemCodeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categoryTB;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}