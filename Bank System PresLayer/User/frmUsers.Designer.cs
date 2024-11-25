namespace Bank_System.User
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.pnlUserControls = new System.Windows.Forms.Panel();
            this.btnUsersList = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbSection = new System.Windows.Forms.Label();
            this.pnlUserControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserControls
            // 
            this.pnlUserControls.BackColor = System.Drawing.Color.White;
            this.pnlUserControls.Controls.Add(this.btnUsersList);
            this.pnlUserControls.Controls.Add(this.btnUpdateUser);
            this.pnlUserControls.Controls.Add(this.btnFindUser);
            this.pnlUserControls.Controls.Add(this.btnAddUser);
            this.pnlUserControls.Controls.Add(this.btnDeleteUser);
            this.pnlUserControls.Location = new System.Drawing.Point(2, 59);
            this.pnlUserControls.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlUserControls.Name = "pnlUserControls";
            this.pnlUserControls.Size = new System.Drawing.Size(715, 409);
            this.pnlUserControls.TabIndex = 22;
            // 
            // btnUsersList
            // 
            this.btnUsersList.BackColor = System.Drawing.Color.Transparent;
            this.btnUsersList.BorderColor = System.Drawing.Color.White;
            this.btnUsersList.BorderRadius = 10;
            this.btnUsersList.CheckedState.Parent = this.btnUsersList;
            this.btnUsersList.CustomImages.Parent = this.btnUsersList;
            this.btnUsersList.Enabled = false;
            this.btnUsersList.FillColor = System.Drawing.SystemColors.Control;
            this.btnUsersList.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsersList.ForeColor = System.Drawing.Color.Black;
            this.btnUsersList.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUsersList.HoverState.Parent = this.btnUsersList;
            this.btnUsersList.Image = ((System.Drawing.Image)(resources.GetObject("btnUsersList.Image")));
            this.btnUsersList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsersList.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUsersList.Location = new System.Drawing.Point(8, 11);
            this.btnUsersList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUsersList.Name = "btnUsersList";
            this.btnUsersList.ShadowDecoration.Parent = this.btnUsersList;
            this.btnUsersList.Size = new System.Drawing.Size(700, 71);
            this.btnUsersList.TabIndex = 12;
            this.btnUsersList.Text = "Users List";
            this.btnUsersList.Click += new System.EventHandler(this.btnUsersList_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.BorderColor = System.Drawing.Color.White;
            this.btnUpdateUser.BorderRadius = 10;
            this.btnUpdateUser.CheckedState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.CustomImages.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Enabled = false;
            this.btnUpdateUser.FillColor = System.Drawing.SystemColors.Control;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.HoverState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.Image")));
            this.btnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateUser.Location = new System.Drawing.Point(8, 328);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.ShadowDecoration.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Size = new System.Drawing.Size(700, 71);
            this.btnUpdateUser.TabIndex = 16;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.Transparent;
            this.btnFindUser.BorderColor = System.Drawing.Color.White;
            this.btnFindUser.BorderRadius = 10;
            this.btnFindUser.CheckedState.Parent = this.btnFindUser;
            this.btnFindUser.CustomImages.Parent = this.btnFindUser;
            this.btnFindUser.Enabled = false;
            this.btnFindUser.FillColor = System.Drawing.SystemColors.Control;
            this.btnFindUser.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnFindUser.ForeColor = System.Drawing.Color.Black;
            this.btnFindUser.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnFindUser.HoverState.Parent = this.btnFindUser;
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnFindUser.Location = new System.Drawing.Point(8, 248);
            this.btnFindUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.ShadowDecoration.Parent = this.btnFindUser;
            this.btnFindUser.Size = new System.Drawing.Size(700, 71);
            this.btnFindUser.TabIndex = 15;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BorderColor = System.Drawing.Color.White;
            this.btnAddUser.BorderRadius = 10;
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.Enabled = false;
            this.btnAddUser.FillColor = System.Drawing.SystemColors.Control;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddUser.Location = new System.Drawing.Point(8, 90);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(700, 71);
            this.btnAddUser.TabIndex = 13;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.BorderColor = System.Drawing.Color.White;
            this.btnDeleteUser.BorderRadius = 10;
            this.btnDeleteUser.CheckedState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.CustomImages.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.FillColor = System.Drawing.SystemColors.Control;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.HoverState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDeleteUser.Location = new System.Drawing.Point(6, 169);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.ShadowDecoration.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Size = new System.Drawing.Size(700, 71);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.lbAbout.ForeColor = System.Drawing.Color.Black;
            this.lbAbout.Location = new System.Drawing.Point(12, 31);
            this.lbAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(382, 19);
            this.lbAbout.TabIndex = 24;
            this.lbAbout.Text = "Here You Can Dealing The User With Many Features...";
            this.lbAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSection
            // 
            this.lbSection.AutoSize = true;
            this.lbSection.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.lbSection.ForeColor = System.Drawing.Color.Black;
            this.lbSection.Location = new System.Drawing.Point(9, -1);
            this.lbSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSection.Name = "lbSection";
            this.lbSection.Size = new System.Drawing.Size(172, 32);
            this.lbSection.TabIndex = 23;
            this.lbSection.Text = "Users Section";
            this.lbSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 467);
            this.Controls.Add(this.pnlUserControls);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.pnlUserControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUsersList;
        private System.Windows.Forms.Panel pnlUserControls;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private Guna.UI2.WinForms.Guna2Button btnFindUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbSection;
    }
}