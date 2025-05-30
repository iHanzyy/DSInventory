namespace DSInventory
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            this.logoutBTN = new System.Windows.Forms.Button();
            this.transactionReportBTN = new System.Windows.Forms.Button();
            this.inventoryReportBTN = new System.Windows.Forms.Button();
            this.pendingTransactionsBTN = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoDS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBTN
            // 
            this.logoutBTN.BackColor = System.Drawing.Color.Red;
            this.logoutBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.ForeColor = System.Drawing.Color.White;
            this.logoutBTN.Location = new System.Drawing.Point(1694, 12);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(196, 79);
            this.logoutBTN.TabIndex = 11;
            this.logoutBTN.Text = "LOGOUT";
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // transactionReportBTN
            // 
            this.transactionReportBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.transactionReportBTN.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionReportBTN.ForeColor = System.Drawing.Color.White;
            this.transactionReportBTN.Location = new System.Drawing.Point(828, 822);
            this.transactionReportBTN.Name = "transactionReportBTN";
            this.transactionReportBTN.Size = new System.Drawing.Size(293, 130);
            this.transactionReportBTN.TabIndex = 10;
            this.transactionReportBTN.Text = "TRANSACTION REPORT";
            this.transactionReportBTN.UseVisualStyleBackColor = false;
            this.transactionReportBTN.Click += new System.EventHandler(this.transactionReportBTN_Click);
            // 
            // inventoryReportBTN
            // 
            this.inventoryReportBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.inventoryReportBTN.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryReportBTN.ForeColor = System.Drawing.Color.White;
            this.inventoryReportBTN.Location = new System.Drawing.Point(1279, 548);
            this.inventoryReportBTN.Name = "inventoryReportBTN";
            this.inventoryReportBTN.Size = new System.Drawing.Size(293, 120);
            this.inventoryReportBTN.TabIndex = 8;
            this.inventoryReportBTN.Text = "INVENTORY REPORT";
            this.inventoryReportBTN.UseVisualStyleBackColor = false;
            this.inventoryReportBTN.Click += new System.EventHandler(this.manageItemsBTN_Click);
            // 
            // pendingTransactionsBTN
            // 
            this.pendingTransactionsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pendingTransactionsBTN.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingTransactionsBTN.ForeColor = System.Drawing.Color.White;
            this.pendingTransactionsBTN.Location = new System.Drawing.Point(413, 548);
            this.pendingTransactionsBTN.Name = "pendingTransactionsBTN";
            this.pendingTransactionsBTN.Size = new System.Drawing.Size(293, 120);
            this.pendingTransactionsBTN.TabIndex = 6;
            this.pendingTransactionsBTN.Text = "PENDING TRANSACTIONS";
            this.pendingTransactionsBTN.UseVisualStyleBackColor = false;
            this.pendingTransactionsBTN.Click += new System.EventHandler(this.pendingTransactionsBTN_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::DSInventory.Properties.Resources.managerDashboard;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Location = new System.Drawing.Point(917, 103);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(628, 330);
            this.guna2Panel1.TabIndex = 13;
            // 
            // logoDS
            // 
            this.logoDS.Image = global::DSInventory.Properties.Resources.logoStruggle1;
            this.logoDS.Location = new System.Drawing.Point(413, 24);
            this.logoDS.Name = "logoDS";
            this.logoDS.Size = new System.Drawing.Size(436, 449);
            this.logoDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDS.TabIndex = 12;
            this.logoDS.TabStop = false;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1902, 1175);
            this.Controls.Add(this.inventoryReportBTN);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.logoDS);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.transactionReportBTN);
            this.Controls.Add(this.pendingTransactionsBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Button transactionReportBTN;
        private System.Windows.Forms.Button inventoryReportBTN;
        private System.Windows.Forms.Button pendingTransactionsBTN;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox logoDS;
    }
}