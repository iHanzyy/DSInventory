namespace DSInventory
{
    partial class StaffGudangIncomingItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffGudangIncomingItems));
            this.submitTransactionBTN = new System.Windows.Forms.Button();
            this.selectItemBTN = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityBTN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionDateDTP = new System.Windows.Forms.DateTimePicker();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.backToDashboardBTN = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoDS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // submitTransactionBTN
            // 
            this.submitTransactionBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submitTransactionBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTransactionBTN.ForeColor = System.Drawing.Color.White;
            this.submitTransactionBTN.Location = new System.Drawing.Point(1426, 574);
            this.submitTransactionBTN.Name = "submitTransactionBTN";
            this.submitTransactionBTN.Size = new System.Drawing.Size(212, 59);
            this.submitTransactionBTN.TabIndex = 8;
            this.submitTransactionBTN.Text = "SUBMIT TRANSACTION";
            this.submitTransactionBTN.UseVisualStyleBackColor = false;
            this.submitTransactionBTN.Click += new System.EventHandler(this.submitTransactionBTN_Click);
            // 
            // selectItemBTN
            // 
            this.selectItemBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectItemBTN.FormattingEnabled = true;
            this.selectItemBTN.IntegralHeight = false;
            this.selectItemBTN.ItemHeight = 25;
            this.selectItemBTN.Location = new System.Drawing.Point(440, 588);
            this.selectItemBTN.Name = "selectItemBTN";
            this.selectItemBTN.Size = new System.Drawing.Size(247, 33);
            this.selectItemBTN.TabIndex = 16;
            this.selectItemBTN.SelectedIndexChanged += new System.EventHandler(this.selectItemBTN_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(435, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select Item";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(435, 684);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // quantityBTN
            // 
            this.quantityBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBTN.Location = new System.Drawing.Point(440, 717);
            this.quantityBTN.Multiline = true;
            this.quantityBTN.Name = "quantityBTN";
            this.quantityBTN.Size = new System.Drawing.Size(247, 41);
            this.quantityBTN.TabIndex = 23;
            this.quantityBTN.TextChanged += new System.EventHandler(this.quantityBTN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(435, 825);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Transaction Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // transactionDateDTP
            // 
            this.transactionDateDTP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateDTP.Location = new System.Drawing.Point(440, 866);
            this.transactionDateDTP.Name = "transactionDateDTP";
            this.transactionDateDTP.Size = new System.Drawing.Size(265, 32);
            this.transactionDateDTP.TabIndex = 26;
            this.transactionDateDTP.ValueChanged += new System.EventHandler(this.transactionDateDTP_ValueChanged);
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.Color.Red;
            this.cancelBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBTN.ForeColor = System.Drawing.Color.White;
            this.cancelBTN.Location = new System.Drawing.Point(1426, 789);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(212, 59);
            this.cancelBTN.TabIndex = 27;
            this.cancelBTN.Text = "CANCEL";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // backToDashboardBTN
            // 
            this.backToDashboardBTN.BackColor = System.Drawing.Color.Green;
            this.backToDashboardBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToDashboardBTN.ForeColor = System.Drawing.Color.White;
            this.backToDashboardBTN.Location = new System.Drawing.Point(1694, 12);
            this.backToDashboardBTN.Name = "backToDashboardBTN";
            this.backToDashboardBTN.Size = new System.Drawing.Size(196, 79);
            this.backToDashboardBTN.TabIndex = 28;
            this.backToDashboardBTN.Text = "BACK";
            this.backToDashboardBTN.UseVisualStyleBackColor = false;
            this.backToDashboardBTN.Click += new System.EventHandler(this.backToDashboardBTN_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::DSInventory.Properties.Resources.addIncomingItems;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Location = new System.Drawing.Point(1010, 125);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(628, 330);
            this.guna2Panel1.TabIndex = 30;
            // 
            // logoDS
            // 
            this.logoDS.Image = global::DSInventory.Properties.Resources.logoStruggle1;
            this.logoDS.Location = new System.Drawing.Point(440, 6);
            this.logoDS.Name = "logoDS";
            this.logoDS.Size = new System.Drawing.Size(436, 449);
            this.logoDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDS.TabIndex = 29;
            this.logoDS.TabStop = false;
            // 
            // StaffGudangIncomingItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1902, 1175);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.logoDS);
            this.Controls.Add(this.backToDashboardBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.transactionDateDTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityBTN);
            this.Controls.Add(this.selectItemBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitTransactionBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffGudangIncomingItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffGudangIncomingItems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffGudangIncomingItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitTransactionBTN;
        private System.Windows.Forms.ComboBox selectItemBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker transactionDateDTP;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button backToDashboardBTN;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox logoDS;
    }
}