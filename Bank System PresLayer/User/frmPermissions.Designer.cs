namespace Bank_System.User
{
    partial class frmPermissions
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
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.rbClientSection = new System.Windows.Forms.RadioButton();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.chbUpdateClient = new System.Windows.Forms.CheckBox();
            this.chbFindClient = new System.Windows.Forms.CheckBox();
            this.chbDeleteClient = new System.Windows.Forms.CheckBox();
            this.chbAddClient = new System.Windows.Forms.CheckBox();
            this.chbClientsList = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.chbUpdateUser = new System.Windows.Forms.CheckBox();
            this.chbFindUser = new System.Windows.Forms.CheckBox();
            this.chbDeleteUser = new System.Windows.Forms.CheckBox();
            this.chbAddUser = new System.Windows.Forms.CheckBox();
            this.chbUsersList = new System.Windows.Forms.CheckBox();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.chbTransferLog = new System.Windows.Forms.CheckBox();
            this.chbTransfer = new System.Windows.Forms.CheckBox();
            this.chbTotalBalances = new System.Windows.Forms.CheckBox();
            this.chbWithraw = new System.Windows.Forms.CheckBox();
            this.chbDeposit = new System.Windows.Forms.CheckBox();
            this.rbUserSection = new System.Windows.Forms.RadioButton();
            this.rbTransaction = new System.Windows.Forms.RadioButton();
            this.rbFullAccess = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlClient.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlTransaction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 10;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(9, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(901, 56);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbClientSection
            // 
            this.rbClientSection.AutoSize = true;
            this.rbClientSection.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rbClientSection.Location = new System.Drawing.Point(26, 8);
            this.rbClientSection.Name = "rbClientSection";
            this.rbClientSection.Size = new System.Drawing.Size(174, 28);
            this.rbClientSection.TabIndex = 31;
            this.rbClientSection.Text = "Client Section";
            this.rbClientSection.UseVisualStyleBackColor = true;
            this.rbClientSection.CheckedChanged += new System.EventHandler(this.rbClientSection_CheckedChanged);
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.SystemColors.Control;
            this.pnlClient.Controls.Add(this.chbUpdateClient);
            this.pnlClient.Controls.Add(this.chbFindClient);
            this.pnlClient.Controls.Add(this.chbDeleteClient);
            this.pnlClient.Controls.Add(this.chbAddClient);
            this.pnlClient.Controls.Add(this.chbClientsList);
            this.pnlClient.Controls.Add(this.panel4);
            this.pnlClient.Enabled = false;
            this.pnlClient.Location = new System.Drawing.Point(6, 42);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(278, 259);
            this.pnlClient.TabIndex = 32;
            // 
            // chbUpdateClient
            // 
            this.chbUpdateClient.AutoSize = true;
            this.chbUpdateClient.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUpdateClient.Location = new System.Drawing.Point(20, 219);
            this.chbUpdateClient.Name = "chbUpdateClient";
            this.chbUpdateClient.Size = new System.Drawing.Size(173, 28);
            this.chbUpdateClient.TabIndex = 4;
            this.chbUpdateClient.Text = "Update Client";
            this.chbUpdateClient.UseVisualStyleBackColor = true;
            // 
            // chbFindClient
            // 
            this.chbFindClient.AutoSize = true;
            this.chbFindClient.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFindClient.Location = new System.Drawing.Point(20, 169);
            this.chbFindClient.Name = "chbFindClient";
            this.chbFindClient.Size = new System.Drawing.Size(144, 28);
            this.chbFindClient.TabIndex = 3;
            this.chbFindClient.Text = "Find Client";
            this.chbFindClient.UseVisualStyleBackColor = true;
            // 
            // chbDeleteClient
            // 
            this.chbDeleteClient.AutoSize = true;
            this.chbDeleteClient.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDeleteClient.Location = new System.Drawing.Point(20, 119);
            this.chbDeleteClient.Name = "chbDeleteClient";
            this.chbDeleteClient.Size = new System.Drawing.Size(165, 28);
            this.chbDeleteClient.TabIndex = 2;
            this.chbDeleteClient.Text = "Delete Client";
            this.chbDeleteClient.UseVisualStyleBackColor = true;
            // 
            // chbAddClient
            // 
            this.chbAddClient.AutoSize = true;
            this.chbAddClient.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAddClient.Location = new System.Drawing.Point(20, 69);
            this.chbAddClient.Name = "chbAddClient";
            this.chbAddClient.Size = new System.Drawing.Size(191, 28);
            this.chbAddClient.TabIndex = 1;
            this.chbAddClient.Text = "Add New Client";
            this.chbAddClient.UseVisualStyleBackColor = true;
            // 
            // chbClientsList
            // 
            this.chbClientsList.AutoSize = true;
            this.chbClientsList.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbClientsList.Location = new System.Drawing.Point(20, 19);
            this.chbClientsList.Name = "chbClientsList";
            this.chbClientsList.Size = new System.Drawing.Size(145, 28);
            this.chbClientsList.TabIndex = 0;
            this.chbClientsList.Text = "Clients List";
            this.chbClientsList.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 59);
            this.panel4.TabIndex = 10;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUser.Controls.Add(this.chbUpdateUser);
            this.pnlUser.Controls.Add(this.chbFindUser);
            this.pnlUser.Controls.Add(this.chbDeleteUser);
            this.pnlUser.Controls.Add(this.chbAddUser);
            this.pnlUser.Controls.Add(this.chbUsersList);
            this.pnlUser.Enabled = false;
            this.pnlUser.Location = new System.Drawing.Point(17, 42);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(278, 259);
            this.pnlUser.TabIndex = 33;
            // 
            // chbUpdateUser
            // 
            this.chbUpdateUser.AutoSize = true;
            this.chbUpdateUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUpdateUser.Location = new System.Drawing.Point(18, 219);
            this.chbUpdateUser.Name = "chbUpdateUser";
            this.chbUpdateUser.Size = new System.Drawing.Size(161, 28);
            this.chbUpdateUser.TabIndex = 9;
            this.chbUpdateUser.Text = "Update User";
            this.chbUpdateUser.UseVisualStyleBackColor = true;
            // 
            // chbFindUser
            // 
            this.chbFindUser.AutoSize = true;
            this.chbFindUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFindUser.Location = new System.Drawing.Point(18, 169);
            this.chbFindUser.Name = "chbFindUser";
            this.chbFindUser.Size = new System.Drawing.Size(132, 28);
            this.chbFindUser.TabIndex = 8;
            this.chbFindUser.Text = "Find User";
            this.chbFindUser.UseVisualStyleBackColor = true;
            // 
            // chbDeleteUser
            // 
            this.chbDeleteUser.AutoSize = true;
            this.chbDeleteUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDeleteUser.Location = new System.Drawing.Point(18, 119);
            this.chbDeleteUser.Name = "chbDeleteUser";
            this.chbDeleteUser.Size = new System.Drawing.Size(153, 28);
            this.chbDeleteUser.TabIndex = 7;
            this.chbDeleteUser.Text = "Delete User";
            this.chbDeleteUser.UseVisualStyleBackColor = true;
            // 
            // chbAddUser
            // 
            this.chbAddUser.AutoSize = true;
            this.chbAddUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAddUser.Location = new System.Drawing.Point(18, 69);
            this.chbAddUser.Name = "chbAddUser";
            this.chbAddUser.Size = new System.Drawing.Size(179, 28);
            this.chbAddUser.TabIndex = 6;
            this.chbAddUser.Text = "Add New User";
            this.chbAddUser.UseVisualStyleBackColor = true;
            // 
            // chbUsersList
            // 
            this.chbUsersList.AutoSize = true;
            this.chbUsersList.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUsersList.Location = new System.Drawing.Point(18, 19);
            this.chbUsersList.Name = "chbUsersList";
            this.chbUsersList.Size = new System.Drawing.Size(133, 28);
            this.chbUsersList.TabIndex = 5;
            this.chbUsersList.Text = "Users List";
            this.chbUsersList.UseVisualStyleBackColor = true;
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTransaction.Controls.Add(this.chbTransferLog);
            this.pnlTransaction.Controls.Add(this.chbTransfer);
            this.pnlTransaction.Controls.Add(this.chbTotalBalances);
            this.pnlTransaction.Controls.Add(this.chbWithraw);
            this.pnlTransaction.Controls.Add(this.chbDeposit);
            this.pnlTransaction.Enabled = false;
            this.pnlTransaction.Location = new System.Drawing.Point(15, 42);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(278, 259);
            this.pnlTransaction.TabIndex = 33;
            // 
            // chbTransferLog
            // 
            this.chbTransferLog.AutoSize = true;
            this.chbTransferLog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTransferLog.Location = new System.Drawing.Point(14, 219);
            this.chbTransferLog.Name = "chbTransferLog";
            this.chbTransferLog.Size = new System.Drawing.Size(163, 28);
            this.chbTransferLog.TabIndex = 9;
            this.chbTransferLog.Text = "Transfer Log";
            this.chbTransferLog.UseVisualStyleBackColor = true;
            // 
            // chbTransfer
            // 
            this.chbTransfer.AutoSize = true;
            this.chbTransfer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTransfer.Location = new System.Drawing.Point(14, 169);
            this.chbTransfer.Name = "chbTransfer";
            this.chbTransfer.Size = new System.Drawing.Size(121, 28);
            this.chbTransfer.TabIndex = 8;
            this.chbTransfer.Text = "Transfer";
            this.chbTransfer.UseVisualStyleBackColor = true;
            // 
            // chbTotalBalances
            // 
            this.chbTotalBalances.AutoSize = true;
            this.chbTotalBalances.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTotalBalances.Location = new System.Drawing.Point(14, 119);
            this.chbTotalBalances.Name = "chbTotalBalances";
            this.chbTotalBalances.Size = new System.Drawing.Size(182, 28);
            this.chbTotalBalances.TabIndex = 7;
            this.chbTotalBalances.Text = "Total Balances";
            this.chbTotalBalances.UseVisualStyleBackColor = true;
            // 
            // chbWithraw
            // 
            this.chbWithraw.AutoSize = true;
            this.chbWithraw.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbWithraw.Location = new System.Drawing.Point(14, 69);
            this.chbWithraw.Name = "chbWithraw";
            this.chbWithraw.Size = new System.Drawing.Size(123, 28);
            this.chbWithraw.TabIndex = 6;
            this.chbWithraw.Text = "Withraw";
            this.chbWithraw.UseVisualStyleBackColor = true;
            // 
            // chbDeposit
            // 
            this.chbDeposit.AutoSize = true;
            this.chbDeposit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDeposit.Location = new System.Drawing.Point(14, 19);
            this.chbDeposit.Name = "chbDeposit";
            this.chbDeposit.Size = new System.Drawing.Size(112, 28);
            this.chbDeposit.TabIndex = 5;
            this.chbDeposit.Text = "Deposit";
            this.chbDeposit.UseVisualStyleBackColor = true;
            // 
            // rbUserSection
            // 
            this.rbUserSection.AutoSize = true;
            this.rbUserSection.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rbUserSection.Location = new System.Drawing.Point(34, 8);
            this.rbUserSection.Name = "rbUserSection";
            this.rbUserSection.Size = new System.Drawing.Size(162, 28);
            this.rbUserSection.TabIndex = 32;
            this.rbUserSection.Text = "User Section";
            this.rbUserSection.UseVisualStyleBackColor = true;
            this.rbUserSection.CheckedChanged += new System.EventHandler(this.rbUserSection_CheckedChanged);
            // 
            // rbTransaction
            // 
            this.rbTransaction.AutoSize = true;
            this.rbTransaction.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rbTransaction.Location = new System.Drawing.Point(29, 8);
            this.rbTransaction.Name = "rbTransaction";
            this.rbTransaction.Size = new System.Drawing.Size(234, 28);
            this.rbTransaction.TabIndex = 33;
            this.rbTransaction.Text = "Transaction Section";
            this.rbTransaction.UseVisualStyleBackColor = true;
            this.rbTransaction.CheckedChanged += new System.EventHandler(this.rbTransaction_CheckedChanged);
            // 
            // rbFullAccess
            // 
            this.rbFullAccess.AutoSize = true;
            this.rbFullAccess.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rbFullAccess.ForeColor = System.Drawing.SystemColors.Control;
            this.rbFullAccess.Location = new System.Drawing.Point(6, 11);
            this.rbFullAccess.Name = "rbFullAccess";
            this.rbFullAccess.Size = new System.Drawing.Size(146, 28);
            this.rbFullAccess.TabIndex = 35;
            this.rbFullAccess.TabStop = true;
            this.rbFullAccess.Text = "Full Access";
            this.rbFullAccess.UseVisualStyleBackColor = true;
            this.rbFullAccess.CheckedChanged += new System.EventHandler(this.rbFullAccess_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUserSection);
            this.panel1.Controls.Add(this.pnlUser);
            this.panel1.Location = new System.Drawing.Point(313, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 312);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlTransaction);
            this.panel2.Controls.Add(this.rbTransaction);
            this.panel2.Location = new System.Drawing.Point(617, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 312);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlClient);
            this.panel3.Controls.Add(this.rbClientSection);
            this.panel3.Location = new System.Drawing.Point(9, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 312);
            this.panel3.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 39);
            this.label1.TabIndex = 38;
            this.label1.Text = "Set Permissions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Controls.Add(this.rbFullAccess);
            this.panel6.Location = new System.Drawing.Point(9, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(906, 48);
            this.panel6.TabIndex = 39;
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPermissions";
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.RadioButton rbClientSection;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.RadioButton rbUserSection;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.RadioButton rbTransaction;
        private System.Windows.Forms.CheckBox chbUpdateClient;
        private System.Windows.Forms.CheckBox chbFindClient;
        private System.Windows.Forms.CheckBox chbDeleteClient;
        private System.Windows.Forms.CheckBox chbAddClient;
        private System.Windows.Forms.CheckBox chbClientsList;
        private System.Windows.Forms.CheckBox chbUpdateUser;
        private System.Windows.Forms.CheckBox chbFindUser;
        private System.Windows.Forms.CheckBox chbDeleteUser;
        private System.Windows.Forms.CheckBox chbAddUser;
        private System.Windows.Forms.CheckBox chbUsersList;
        private System.Windows.Forms.CheckBox chbTransferLog;
        private System.Windows.Forms.CheckBox chbTransfer;
        private System.Windows.Forms.CheckBox chbTotalBalances;
        private System.Windows.Forms.CheckBox chbWithraw;
        private System.Windows.Forms.CheckBox chbDeposit;
        private System.Windows.Forms.RadioButton rbFullAccess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
    }
}