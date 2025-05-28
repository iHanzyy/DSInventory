namespace DSInventory
{
    partial class AdminManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageUsers));
            this.addUserBTN = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.editUserBTN = new System.Windows.Forms.Button();
            this.deleteUserBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.backBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserBTN
            // 
            this.addUserBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addUserBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBTN.ForeColor = System.Drawing.Color.White;
            this.addUserBTN.Location = new System.Drawing.Point(1475, 834);
            this.addUserBTN.Name = "addUserBTN";
            this.addUserBTN.Size = new System.Drawing.Size(212, 59);
            this.addUserBTN.TabIndex = 1;
            this.addUserBTN.Text = "ADD NEW USER";
            this.addUserBTN.UseVisualStyleBackColor = false;
            this.addUserBTN.Click += new System.EventHandler(this.addUserBTN_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(1311, 197);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(391, 41);
            this.searchTB.TabIndex = 3;
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(1490, 261);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(212, 59);
            this.searchBTN.TabIndex = 4;
            this.searchBTN.Text = "SEARCH";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 442);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(697, 862);
            this.usernameTB.Multiline = true;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(247, 41);
            this.usernameTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(692, 834);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1034, 965);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Full Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fullNameTB
            // 
            this.fullNameTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTB.Location = new System.Drawing.Point(1039, 993);
            this.fullNameTB.Multiline = true;
            this.fullNameTB.Name = "fullNameTB";
            this.fullNameTB.Size = new System.Drawing.Size(247, 41);
            this.fullNameTB.TabIndex = 8;
            this.fullNameTB.TextChanged += new System.EventHandler(this.fullNameTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(692, 965);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(697, 993);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(247, 41);
            this.passwordTB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1034, 834);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Role";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // roleCB
            // 
            this.roleCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCB.FormattingEnabled = true;
            this.roleCB.IntegralHeight = false;
            this.roleCB.ItemHeight = 25;
            this.roleCB.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "STAFF GUDANG"});
            this.roleCB.Location = new System.Drawing.Point(1039, 870);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(247, 33);
            this.roleCB.TabIndex = 14;
            this.roleCB.SelectedIndexChanged += new System.EventHandler(this.roleCB_SelectedIndexChanged);
            // 
            // editUserBTN
            // 
            this.editUserBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editUserBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserBTN.ForeColor = System.Drawing.Color.White;
            this.editUserBTN.Location = new System.Drawing.Point(1475, 910);
            this.editUserBTN.Name = "editUserBTN";
            this.editUserBTN.Size = new System.Drawing.Size(212, 59);
            this.editUserBTN.TabIndex = 15;
            this.editUserBTN.Text = "EDIT USER";
            this.editUserBTN.UseVisualStyleBackColor = false;
            this.editUserBTN.Click += new System.EventHandler(this.editUserBTN_Click);
            // 
            // deleteUserBTN
            // 
            this.deleteUserBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUserBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBTN.ForeColor = System.Drawing.Color.White;
            this.deleteUserBTN.Location = new System.Drawing.Point(1475, 990);
            this.deleteUserBTN.Name = "deleteUserBTN";
            this.deleteUserBTN.Size = new System.Drawing.Size(212, 59);
            this.deleteUserBTN.TabIndex = 16;
            this.deleteUserBTN.Text = "DELETE USER";
            this.deleteUserBTN.UseVisualStyleBackColor = false;
            this.deleteUserBTN.Click += new System.EventHandler(this.deleteUserBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(327, 824);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID";
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(332, 852);
            this.idTB.Multiline = true;
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(130, 41);
            this.idTB.TabIndex = 17;
            this.idTB.TextChanged += new System.EventHandler(this.idTB_TextChanged);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Green;
            this.backBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.White;
            this.backBTN.Location = new System.Drawing.Point(1694, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(196, 79);
            this.backBTN.TabIndex = 19;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DSInventory.Properties.Resources.userlist;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(686, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 258);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DSInventory.Properties.Resources.logoStruggle1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(311, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 340);
            this.panel2.TabIndex = 21;
            // 
            // AdminManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1902, 1175);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.deleteUserBTN);
            this.Controls.Add(this.editUserBTN);
            this.Controls.Add(this.roleCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.addUserBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManageUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserBTN;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.Button editUserBTN;
        private System.Windows.Forms.Button deleteUserBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}