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
            this.rejectBTN = new System.Windows.Forms.Button();
            this.approveBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backBTN = new System.Windows.Forms.Button();
            this.logoDS = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // rejectBTN
            // 
            this.rejectBTN.BackColor = System.Drawing.Color.Red;
            this.rejectBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectBTN.ForeColor = System.Drawing.Color.White;
            this.rejectBTN.Location = new System.Drawing.Point(1491, 1018);
            this.rejectBTN.Name = "rejectBTN";
            this.rejectBTN.Size = new System.Drawing.Size(196, 79);
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
            this.approveBTN.Location = new System.Drawing.Point(311, 1018);
            this.approveBTN.Name = "approveBTN";
            this.approveBTN.Size = new System.Drawing.Size(196, 79);
            this.approveBTN.TabIndex = 22;
            this.approveBTN.Text = "APPROVE";
            this.approveBTN.UseVisualStyleBackColor = false;
            this.approveBTN.Click += new System.EventHandler(this.approveBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 442);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Green;
            this.backBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.White;
            this.backBTN.Location = new System.Drawing.Point(1694, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(196, 79);
            this.backBTN.TabIndex = 24;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // logoDS
            // 
            this.logoDS.Image = global::DSInventory.Properties.Resources.logoStruggle1;
            this.logoDS.Location = new System.Drawing.Point(413, 24);
            this.logoDS.Name = "logoDS";
            this.logoDS.Size = new System.Drawing.Size(436, 449);
            this.logoDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDS.TabIndex = 25;
            this.logoDS.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::DSInventory.Properties.Resources.transactionRequiringApproval;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Location = new System.Drawing.Point(917, 103);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(628, 330);
            this.guna2Panel1.TabIndex = 26;
            // 
            // ManagerPendingTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1902, 1175);
            this.Controls.Add(this.logoDS);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.rejectBTN);
            this.Controls.Add(this.approveBTN);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerPendingTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerPendingTransactions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button rejectBTN;
        private System.Windows.Forms.Button approveBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBTN;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox logoDS;
    }
}