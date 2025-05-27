namespace DSInventory
{
    partial class ManagerPendingTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerPendingTransactions));
            this.judul = new System.Windows.Forms.Label();
            this.rejectBTN = new System.Windows.Forms.Button();
            this.approveBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.ForeColor = System.Drawing.Color.Black;
            this.judul.Location = new System.Drawing.Point(97, 69);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(623, 40);
            this.judul.TabIndex = 7;
            this.judul.Text = "Transactions Requiring Approval";
            // 
            // rejectBTN
            // 
            this.rejectBTN.BackColor = System.Drawing.Color.Red;
            this.rejectBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectBTN.ForeColor = System.Drawing.Color.White;
            this.rejectBTN.Location = new System.Drawing.Point(892, 442);
            this.rejectBTN.Name = "rejectBTN";
            this.rejectBTN.Size = new System.Drawing.Size(212, 59);
            this.rejectBTN.TabIndex = 23;
            this.rejectBTN.Text = "REJECT";
            this.rejectBTN.UseVisualStyleBackColor = false;
            this.rejectBTN.Click += new System.EventHandler(this.rejectBTN_Click);
            // 
            // approveBTN
            // 
            this.approveBTN.BackColor = System.Drawing.Color.Green;
            this.approveBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveBTN.ForeColor = System.Drawing.Color.White;
            this.approveBTN.Location = new System.Drawing.Point(162, 442);
            this.approveBTN.Name = "approveBTN";
            this.approveBTN.Size = new System.Drawing.Size(212, 59);
            this.approveBTN.TabIndex = 22;
            this.approveBTN.Text = "APPROVE";
            this.approveBTN.UseVisualStyleBackColor = false;
            this.approveBTN.Click += new System.EventHandler(this.approveBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 292);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.backBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.White;
            this.backBTN.Location = new System.Drawing.Point(1015, 30);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(131, 49);
            this.backBTN.TabIndex = 24;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // ManagerPendingTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.rejectBTN);
            this.Controls.Add(this.approveBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.judul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerPendingTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerPendingTransactions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Button rejectBTN;
        private System.Windows.Forms.Button approveBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBTN;
    }
}