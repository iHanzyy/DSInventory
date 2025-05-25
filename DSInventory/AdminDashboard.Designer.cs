namespace DSInventory
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.manageUsersBTN = new System.Windows.Forms.Button();
            this.logoDS = new System.Windows.Forms.PictureBox();
            this.manageItemsBTN = new System.Windows.Forms.Button();
            this.inventoryReportBTN = new System.Windows.Forms.Button();
            this.transactionReportBTN = new System.Windows.Forms.Button();
            this.logoutBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // manageUsersBTN
            // 
            this.manageUsersBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.manageUsersBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersBTN.ForeColor = System.Drawing.Color.White;
            this.manageUsersBTN.Location = new System.Drawing.Point(292, 265);
            this.manageUsersBTN.Name = "manageUsersBTN";
            this.manageUsersBTN.Size = new System.Drawing.Size(196, 93);
            this.manageUsersBTN.TabIndex = 0;
            this.manageUsersBTN.Text = "MANAGE USERS";
            this.manageUsersBTN.UseVisualStyleBackColor = false;
            this.manageUsersBTN.Click += new System.EventHandler(this.manageUsersBTN_Click);
            // 
            // logoDS
            // 
            this.logoDS.Image = global::DSInventory.Properties.Resources.logoStruggle;
            this.logoDS.Location = new System.Drawing.Point(534, 12);
            this.logoDS.Name = "logoDS";
            this.logoDS.Size = new System.Drawing.Size(200, 200);
            this.logoDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDS.TabIndex = 1;
            this.logoDS.TabStop = false;
            // 
            // manageItemsBTN
            // 
            this.manageItemsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.manageItemsBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageItemsBTN.ForeColor = System.Drawing.Color.White;
            this.manageItemsBTN.Location = new System.Drawing.Point(763, 265);
            this.manageItemsBTN.Name = "manageItemsBTN";
            this.manageItemsBTN.Size = new System.Drawing.Size(196, 93);
            this.manageItemsBTN.TabIndex = 2;
            this.manageItemsBTN.Text = "MANAGE ITEMS";
            this.manageItemsBTN.UseVisualStyleBackColor = false;
            this.manageItemsBTN.Click += new System.EventHandler(this.manageItemsBTN_Click);
            // 
            // inventoryReportBTN
            // 
            this.inventoryReportBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.inventoryReportBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryReportBTN.ForeColor = System.Drawing.Color.White;
            this.inventoryReportBTN.Location = new System.Drawing.Point(292, 467);
            this.inventoryReportBTN.Name = "inventoryReportBTN";
            this.inventoryReportBTN.Size = new System.Drawing.Size(196, 93);
            this.inventoryReportBTN.TabIndex = 3;
            this.inventoryReportBTN.Text = "INVENTORY REPORT";
            this.inventoryReportBTN.UseVisualStyleBackColor = false;
            this.inventoryReportBTN.Click += new System.EventHandler(this.inventoryReportBTN_Click);
            // 
            // transactionReportBTN
            // 
            this.transactionReportBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.transactionReportBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionReportBTN.ForeColor = System.Drawing.Color.White;
            this.transactionReportBTN.Location = new System.Drawing.Point(763, 467);
            this.transactionReportBTN.Name = "transactionReportBTN";
            this.transactionReportBTN.Size = new System.Drawing.Size(196, 93);
            this.transactionReportBTN.TabIndex = 4;
            this.transactionReportBTN.Text = "TRANSACTION REPORT";
            this.transactionReportBTN.UseVisualStyleBackColor = false;
            this.transactionReportBTN.Click += new System.EventHandler(this.transactionReportBTN_Click);
            // 
            // logoutBTN
            // 
            this.logoutBTN.BackColor = System.Drawing.Color.Red;
            this.logoutBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.ForeColor = System.Drawing.Color.White;
            this.logoutBTN.Location = new System.Drawing.Point(1119, 12);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(131, 49);
            this.logoutBTN.TabIndex = 5;
            this.logoutBTN.Text = "LOGOUT";
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.transactionReportBTN);
            this.Controls.Add(this.inventoryReportBTN);
            this.Controls.Add(this.manageItemsBTN);
            this.Controls.Add(this.logoDS);
            this.Controls.Add(this.manageUsersBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageUsersBTN;
        private System.Windows.Forms.PictureBox logoDS;
        private System.Windows.Forms.Button manageItemsBTN;
        private System.Windows.Forms.Button inventoryReportBTN;
        private System.Windows.Forms.Button transactionReportBTN;
        private System.Windows.Forms.Button logoutBTN;
    }
}