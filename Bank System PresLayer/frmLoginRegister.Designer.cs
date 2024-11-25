namespace Bank_System
{
    partial class frmLoginRegister
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
            this.lvLoginRegister = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Permissions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbSection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLoginRegister
            // 
            this.lvLoginRegister.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvLoginRegister.AutoArrange = false;
            this.lvLoginRegister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.User,
            this.Password,
            this.Permissions});
            this.lvLoginRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvLoginRegister.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLoginRegister.FullRowSelect = true;
            this.lvLoginRegister.GridLines = true;
            this.lvLoginRegister.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLoginRegister.HideSelection = false;
            this.lvLoginRegister.Location = new System.Drawing.Point(0, -1);
            this.lvLoginRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvLoginRegister.Name = "lvLoginRegister";
            this.lvLoginRegister.Size = new System.Drawing.Size(718, 410);
            this.lvLoginRegister.TabIndex = 18;
            this.lvLoginRegister.UseCompatibleStateImageBehavior = false;
            this.lvLoginRegister.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 200;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 140;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 140;
            // 
            // Permissions
            // 
            this.Permissions.Text = "Permissions";
            this.Permissions.Width = 140;
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.lbAbout.ForeColor = System.Drawing.Color.Black;
            this.lbAbout.Location = new System.Drawing.Point(12, 31);
            this.lbAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(261, 19);
            this.lbAbout.TabIndex = 26;
            this.lbAbout.Text = "Here You Can See all Login History...";
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
            this.lbSection.Size = new System.Drawing.Size(275, 32);
            this.lbSection.TabIndex = 25;
            this.lbSection.Text = "Login Register Section";
            this.lbSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 409);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbSection);
            this.Controls.Add(this.lvLoginRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginRegister";
            this.Load += new System.EventHandler(this.frmLoginRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLoginRegister;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Permissions;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbSection;
    }
}