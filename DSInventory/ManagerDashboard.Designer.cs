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
            this.button1 = new System.Windows.Forms.Button();
            this.transactionReportBTN = new System.Windows.Forms.Button();
            this.manageItemsBTN = new System.Windows.Forms.Button();
            this.logoDS = new System.Windows.Forms.PictureBox();
            this.manageUsersBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1119, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // transactionReportBTN
            // 
            this.transactionReportBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.transactionReportBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionReportBTN.ForeColor = System.Drawing.Color.White;
            this.transactionReportBTN.Location = new System.Drawing.Point(538, 424);
            this.transactionReportBTN.Name = "transactionReportBTN";
            this.transactionReportBTN.Size = new System.Drawing.Size(196, 93);
            this.transactionReportBTN.TabIndex = 10;
            this.transactionReportBTN.Text = "TRANSACTION REPORT";
            this.transactionReportBTN.UseVisualStyleBackColor = false;
            // 
            // manageItemsBTN
            // 
            this.manageItemsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.manageItemsBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageItemsBTN.ForeColor = System.Drawing.Color.White;
            this.manageItemsBTN.Location = new System.Drawing.Point(763, 265);
            this.manageItemsBTN.Name = "manageItemsBTN";
            this.manageItemsBTN.Size = new System.Drawing.Size(196, 93);
            this.manageItemsBTN.TabIndex = 8;
            this.manageItemsBTN.Text = "INVENTORY REPORT";
            this.manageItemsBTN.UseVisualStyleBackColor = false;
            // 
            // logoDS
            // 
            this.logoDS.Image = global::DSInventory.Properties.Resources.logoStruggle;
            this.logoDS.Location = new System.Drawing.Point(534, 12);
            this.logoDS.Name = "logoDS";
            this.logoDS.Size = new System.Drawing.Size(200, 200);
            this.logoDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDS.TabIndex = 7;
            this.logoDS.TabStop = false;
            // 
            // manageUsersBTN
            // 
            this.manageUsersBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.manageUsersBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersBTN.ForeColor = System.Drawing.Color.White;
            this.manageUsersBTN.Location = new System.Drawing.Point(292, 265);
            this.manageUsersBTN.Name = "manageUsersBTN";
            this.manageUsersBTN.Size = new System.Drawing.Size(208, 93);
            this.manageUsersBTN.TabIndex = 6;
            this.manageUsersBTN.Text = "PENDING TRANSACTIONS";
            this.manageUsersBTN.UseVisualStyleBackColor = false;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transactionReportBTN);
            this.Controls.Add(this.manageItemsBTN);
            this.Controls.Add(this.logoDS);
            this.Controls.Add(this.manageUsersBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button transactionReportBTN;
        private System.Windows.Forms.Button manageItemsBTN;
        private System.Windows.Forms.PictureBox logoDS;
        private System.Windows.Forms.Button manageUsersBTN;
    }
}