namespace DSInventory
{
    partial class TransactionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalTransactionsTXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.incomingTransactionTXT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.outgoingTransactionTXT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pendingApprovalTXT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backBTN = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.totalTransactionsTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(311, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 184);
            this.panel1.TabIndex = 1;
            // 
            // totalTransactionsTXT
            // 
            this.totalTransactionsTXT.AutoSize = true;
            this.totalTransactionsTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTransactionsTXT.ForeColor = System.Drawing.Color.White;
            this.totalTransactionsTXT.Location = new System.Drawing.Point(111, 97);
            this.totalTransactionsTXT.Name = "totalTransactionsTXT";
            this.totalTransactionsTXT.Size = new System.Drawing.Size(26, 25);
            this.totalTransactionsTXT.TabIndex = 20;
            this.totalTransactionsTXT.Text = "0";
            this.totalTransactionsTXT.Click += new System.EventHandler(this.totalTransactionsTXT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Transactions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.incomingTransactionTXT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(658, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 184);
            this.panel2.TabIndex = 21;
            // 
            // incomingTransactionTXT
            // 
            this.incomingTransactionTXT.AutoSize = true;
            this.incomingTransactionTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingTransactionTXT.ForeColor = System.Drawing.Color.White;
            this.incomingTransactionTXT.Location = new System.Drawing.Point(125, 97);
            this.incomingTransactionTXT.Name = "incomingTransactionTXT";
            this.incomingTransactionTXT.Size = new System.Drawing.Size(26, 25);
            this.incomingTransactionTXT.TabIndex = 20;
            this.incomingTransactionTXT.Text = "0";
            this.incomingTransactionTXT.Click += new System.EventHandler(this.incomingTransactionTXT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Incoming Transactions";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.outgoingTransactionTXT);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1036, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 184);
            this.panel3.TabIndex = 22;
            // 
            // outgoingTransactionTXT
            // 
            this.outgoingTransactionTXT.AutoSize = true;
            this.outgoingTransactionTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outgoingTransactionTXT.ForeColor = System.Drawing.Color.White;
            this.outgoingTransactionTXT.Location = new System.Drawing.Point(123, 97);
            this.outgoingTransactionTXT.Name = "outgoingTransactionTXT";
            this.outgoingTransactionTXT.Size = new System.Drawing.Size(26, 25);
            this.outgoingTransactionTXT.TabIndex = 20;
            this.outgoingTransactionTXT.Text = "0";
            this.outgoingTransactionTXT.Click += new System.EventHandler(this.outgoingTransactionTXT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Outgoing Transactions";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.pendingApprovalTXT);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(1432, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 184);
            this.panel4.TabIndex = 21;
            // 
            // pendingApprovalTXT
            // 
            this.pendingApprovalTXT.AutoSize = true;
            this.pendingApprovalTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingApprovalTXT.ForeColor = System.Drawing.Color.White;
            this.pendingApprovalTXT.Location = new System.Drawing.Point(116, 97);
            this.pendingApprovalTXT.Name = "pendingApprovalTXT";
            this.pendingApprovalTXT.Size = new System.Drawing.Size(26, 25);
            this.pendingApprovalTXT.TabIndex = 20;
            this.pendingApprovalTXT.Text = "0";
            this.pendingApprovalTXT.Click += new System.EventHandler(this.pendingApprovalTXT_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pending Approval";
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(1490, 261);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(212, 59);
            this.searchBTN.TabIndex = 27;
            this.searchBTN.Text = "SEARCH";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(1311, 197);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(391, 41);
            this.searchTB.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 574);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 442);
            this.dataGridView1.TabIndex = 28;
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Green;
            this.backBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.White;
            this.backBTN.Location = new System.Drawing.Point(1694, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(196, 79);
            this.backBTN.TabIndex = 30;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(311, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 340);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::DSInventory.Properties.Resources.transactionList;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(686, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(431, 258);
            this.panel6.TabIndex = 32;
            // 
            // TransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1902, 1175);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalTransactionsTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label incomingTransactionTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label outgoingTransactionTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label pendingApprovalTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}