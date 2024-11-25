namespace Bank_System
{
    partial class frmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            this.pnlClientsControls = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClientsList = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbSection = new System.Windows.Forms.Label();
            this.pnlClientsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientsControls
            // 
            this.pnlClientsControls.BackColor = System.Drawing.Color.White;
            this.pnlClientsControls.Controls.Add(this.pictureBox2);
            this.pnlClientsControls.Controls.Add(this.btnClientsList);
            this.pnlClientsControls.Controls.Add(this.btnUpdateClient);
            this.pnlClientsControls.Controls.Add(this.btnFindClient);
            this.pnlClientsControls.Controls.Add(this.btnAddClient);
            this.pnlClientsControls.Controls.Add(this.btnDeleteClient);
            this.pnlClientsControls.Location = new System.Drawing.Point(2, 60);
            this.pnlClientsControls.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlClientsControls.Name = "pnlClientsControls";
            this.pnlClientsControls.Size = new System.Drawing.Size(715, 409);
            this.pnlClientsControls.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 181);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(698, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnClientsList
            // 
            this.btnClientsList.BackColor = System.Drawing.Color.Transparent;
            this.btnClientsList.BorderColor = System.Drawing.Color.White;
            this.btnClientsList.BorderRadius = 10;
            this.btnClientsList.CheckedState.Parent = this.btnClientsList;
            this.btnClientsList.CustomImages.Parent = this.btnClientsList;
            this.btnClientsList.Enabled = false;
            this.btnClientsList.FillColor = System.Drawing.SystemColors.Control;
            this.btnClientsList.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnClientsList.ForeColor = System.Drawing.Color.Black;
            this.btnClientsList.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnClientsList.HoverState.Parent = this.btnClientsList;
            this.btnClientsList.Image = ((System.Drawing.Image)(resources.GetObject("btnClientsList.Image")));
            this.btnClientsList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientsList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClientsList.Location = new System.Drawing.Point(8, 11);
            this.btnClientsList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClientsList.Name = "btnClientsList";
            this.btnClientsList.ShadowDecoration.Parent = this.btnClientsList;
            this.btnClientsList.Size = new System.Drawing.Size(700, 47);
            this.btnClientsList.TabIndex = 12;
            this.btnClientsList.Text = "Clients List";
            this.btnClientsList.Click += new System.EventHandler(this.btnClientsList_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.BorderColor = System.Drawing.Color.White;
            this.btnUpdateClient.BorderRadius = 10;
            this.btnUpdateClient.CheckedState.Parent = this.btnUpdateClient;
            this.btnUpdateClient.CustomImages.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Enabled = false;
            this.btnUpdateClient.FillColor = System.Drawing.SystemColors.Control;
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateClient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateClient.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateClient.HoverState.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateClient.Image")));
            this.btnUpdateClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateClient.Location = new System.Drawing.Point(8, 115);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.ShadowDecoration.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Size = new System.Drawing.Size(700, 47);
            this.btnUpdateClient.TabIndex = 16;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackColor = System.Drawing.Color.Transparent;
            this.btnFindClient.BorderColor = System.Drawing.Color.White;
            this.btnFindClient.BorderRadius = 10;
            this.btnFindClient.CheckedState.Parent = this.btnFindClient;
            this.btnFindClient.CustomImages.Parent = this.btnFindClient;
            this.btnFindClient.Enabled = false;
            this.btnFindClient.FillColor = System.Drawing.SystemColors.Control;
            this.btnFindClient.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnFindClient.ForeColor = System.Drawing.Color.Black;
            this.btnFindClient.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnFindClient.HoverState.Parent = this.btnFindClient;
            this.btnFindClient.Image = ((System.Drawing.Image)(resources.GetObject("btnFindClient.Image")));
            this.btnFindClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindClient.Location = new System.Drawing.Point(478, 63);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.ShadowDecoration.Parent = this.btnFindClient;
            this.btnFindClient.Size = new System.Drawing.Size(230, 47);
            this.btnFindClient.TabIndex = 15;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClient.BorderColor = System.Drawing.Color.White;
            this.btnAddClient.BorderRadius = 10;
            this.btnAddClient.CheckedState.Parent = this.btnAddClient;
            this.btnAddClient.CustomImages.Parent = this.btnAddClient;
            this.btnAddClient.Enabled = false;
            this.btnAddClient.FillColor = System.Drawing.SystemColors.Control;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddClient.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddClient.HoverState.Parent = this.btnAddClient;
            this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
            this.btnAddClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddClient.Location = new System.Drawing.Point(8, 63);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.ShadowDecoration.Parent = this.btnAddClient;
            this.btnAddClient.Size = new System.Drawing.Size(230, 47);
            this.btnAddClient.TabIndex = 13;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.BorderColor = System.Drawing.Color.White;
            this.btnDeleteClient.BorderRadius = 10;
            this.btnDeleteClient.CheckedState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.CustomImages.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Enabled = false;
            this.btnDeleteClient.FillColor = System.Drawing.SystemColors.Control;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteClient.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteClient.HoverState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Image")));
            this.btnDeleteClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteClient.Location = new System.Drawing.Point(243, 63);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.ShadowDecoration.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Size = new System.Drawing.Size(230, 47);
            this.btnDeleteClient.TabIndex = 14;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.lbAbout.ForeColor = System.Drawing.Color.Black;
            this.lbAbout.Location = new System.Drawing.Point(12, 32);
            this.lbAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(391, 19);
            this.lbAbout.TabIndex = 21;
            this.lbAbout.Text = "Here You Can Dealing The Client With Many Features...";
            this.lbAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSection
            // 
            this.lbSection.AutoSize = true;
            this.lbSection.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.lbSection.ForeColor = System.Drawing.Color.Black;
            this.lbSection.Location = new System.Drawing.Point(9, 0);
            this.lbSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSection.Name = "lbSection";
            this.lbSection.Size = new System.Drawing.Size(186, 32);
            this.lbSection.TabIndex = 20;
            this.lbSection.Text = "Clients Section";
            this.lbSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 467);
            this.Controls.Add(this.pnlClientsControls);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.pnlClientsControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddClient;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClient;
        private Guna.UI2.WinForms.Guna2Button btnFindClient;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClient;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlClientsControls;
        private Guna.UI2.WinForms.Guna2Button btnClientsList;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbSection;
    }
}