namespace Bank_System.Transaction
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.pnlTransactionControls = new System.Windows.Forms.Panel();
            this.btnTranLog = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnTotatBalances = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeposite = new Guna.UI2.WinForms.Guna2Button();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbSection = new System.Windows.Forms.Label();
            this.pnlTransactionControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTransactionControls
            // 
            this.pnlTransactionControls.BackColor = System.Drawing.Color.White;
            this.pnlTransactionControls.Controls.Add(this.btnTranLog);
            this.pnlTransactionControls.Controls.Add(this.btnTransfer);
            this.pnlTransactionControls.Controls.Add(this.btnWithraw);
            this.pnlTransactionControls.Controls.Add(this.btnTotatBalances);
            this.pnlTransactionControls.Controls.Add(this.btnDeposite);
            this.pnlTransactionControls.Location = new System.Drawing.Point(-1, 60);
            this.pnlTransactionControls.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlTransactionControls.Name = "pnlTransactionControls";
            this.pnlTransactionControls.Size = new System.Drawing.Size(718, 409);
            this.pnlTransactionControls.TabIndex = 20;
            // 
            // btnTranLog
            // 
            this.btnTranLog.BackColor = System.Drawing.Color.Transparent;
            this.btnTranLog.BorderColor = System.Drawing.Color.White;
            this.btnTranLog.BorderRadius = 10;
            this.btnTranLog.CheckedState.Parent = this.btnTranLog;
            this.btnTranLog.CustomImages.Parent = this.btnTranLog;
            this.btnTranLog.Enabled = false;
            this.btnTranLog.FillColor = System.Drawing.SystemColors.Control;
            this.btnTranLog.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnTranLog.ForeColor = System.Drawing.Color.Black;
            this.btnTranLog.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnTranLog.HoverState.Parent = this.btnTranLog;
            this.btnTranLog.Image = ((System.Drawing.Image)(resources.GetObject("btnTranLog.Image")));
            this.btnTranLog.ImageOffset = new System.Drawing.Point(25, -60);
            this.btnTranLog.ImageSize = new System.Drawing.Size(70, 70);
            this.btnTranLog.Location = new System.Drawing.Point(570, 3);
            this.btnTranLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTranLog.Name = "btnTranLog";
            this.btnTranLog.ShadowDecoration.Parent = this.btnTranLog;
            this.btnTranLog.Size = new System.Drawing.Size(137, 403);
            this.btnTranLog.TabIndex = 17;
            this.btnTranLog.Text = "Transfer Log";
            this.btnTranLog.TextOffset = new System.Drawing.Point(-17, 0);
            this.btnTranLog.Click += new System.EventHandler(this.btnTranLog_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BorderColor = System.Drawing.Color.White;
            this.btnTransfer.BorderRadius = 10;
            this.btnTransfer.CheckedState.Parent = this.btnTransfer;
            this.btnTransfer.CustomImages.Parent = this.btnTransfer;
            this.btnTransfer.Enabled = false;
            this.btnTransfer.FillColor = System.Drawing.SystemColors.Control;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.HoverState.Parent = this.btnTransfer;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageOffset = new System.Drawing.Point(18, -60);
            this.btnTransfer.ImageSize = new System.Drawing.Size(70, 70);
            this.btnTransfer.Location = new System.Drawing.Point(428, 3);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.ShadowDecoration.Parent = this.btnTransfer;
            this.btnTransfer.Size = new System.Drawing.Size(137, 403);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextOffset = new System.Drawing.Point(-17, 0);
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithraw
            // 
            this.btnWithraw.BackColor = System.Drawing.Color.Transparent;
            this.btnWithraw.BorderColor = System.Drawing.Color.White;
            this.btnWithraw.BorderRadius = 10;
            this.btnWithraw.CheckedState.Parent = this.btnWithraw;
            this.btnWithraw.CustomImages.Parent = this.btnWithraw;
            this.btnWithraw.Enabled = false;
            this.btnWithraw.FillColor = System.Drawing.SystemColors.Control;
            this.btnWithraw.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnWithraw.ForeColor = System.Drawing.Color.Black;
            this.btnWithraw.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnWithraw.HoverState.Parent = this.btnWithraw;
            this.btnWithraw.Image = ((System.Drawing.Image)(resources.GetObject("btnWithraw.Image")));
            this.btnWithraw.ImageOffset = new System.Drawing.Point(20, -60);
            this.btnWithraw.ImageSize = new System.Drawing.Size(70, 70);
            this.btnWithraw.Location = new System.Drawing.Point(144, 3);
            this.btnWithraw.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnWithraw.Name = "btnWithraw";
            this.btnWithraw.ShadowDecoration.Parent = this.btnWithraw;
            this.btnWithraw.Size = new System.Drawing.Size(137, 403);
            this.btnWithraw.TabIndex = 15;
            this.btnWithraw.Text = "Withraw";
            this.btnWithraw.TextOffset = new System.Drawing.Point(-17, 0);
            this.btnWithraw.Click += new System.EventHandler(this.btnWithraw_Click);
            // 
            // btnTotatBalances
            // 
            this.btnTotatBalances.BackColor = System.Drawing.Color.Transparent;
            this.btnTotatBalances.BorderColor = System.Drawing.Color.White;
            this.btnTotatBalances.BorderRadius = 10;
            this.btnTotatBalances.CheckedState.Parent = this.btnTotatBalances;
            this.btnTotatBalances.CustomImages.Parent = this.btnTotatBalances;
            this.btnTotatBalances.Enabled = false;
            this.btnTotatBalances.FillColor = System.Drawing.SystemColors.Control;
            this.btnTotatBalances.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnTotatBalances.ForeColor = System.Drawing.Color.Black;
            this.btnTotatBalances.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnTotatBalances.HoverState.Parent = this.btnTotatBalances;
            this.btnTotatBalances.Image = ((System.Drawing.Image)(resources.GetObject("btnTotatBalances.Image")));
            this.btnTotatBalances.ImageOffset = new System.Drawing.Point(0, -29);
            this.btnTotatBalances.ImageSize = new System.Drawing.Size(70, 70);
            this.btnTotatBalances.Location = new System.Drawing.Point(286, 3);
            this.btnTotatBalances.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTotatBalances.Name = "btnTotatBalances";
            this.btnTotatBalances.ShadowDecoration.Parent = this.btnTotatBalances;
            this.btnTotatBalances.Size = new System.Drawing.Size(137, 403);
            this.btnTotatBalances.TabIndex = 14;
            this.btnTotatBalances.Text = "Total Balances";
            this.btnTotatBalances.TextOffset = new System.Drawing.Point(0, -30);
            this.btnTotatBalances.Click += new System.EventHandler(this.btnTotatBalances_Click);
            // 
            // btnDeposite
            // 
            this.btnDeposite.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposite.BorderColor = System.Drawing.Color.White;
            this.btnDeposite.BorderRadius = 10;
            this.btnDeposite.CheckedState.Parent = this.btnDeposite;
            this.btnDeposite.CustomImages.Parent = this.btnDeposite;
            this.btnDeposite.Enabled = false;
            this.btnDeposite.FillColor = System.Drawing.SystemColors.Control;
            this.btnDeposite.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeposite.ForeColor = System.Drawing.Color.Black;
            this.btnDeposite.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDeposite.HoverState.Parent = this.btnDeposite;
            this.btnDeposite.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposite.Image")));
            this.btnDeposite.ImageOffset = new System.Drawing.Point(25, -60);
            this.btnDeposite.ImageSize = new System.Drawing.Size(70, 70);
            this.btnDeposite.Location = new System.Drawing.Point(2, 3);
            this.btnDeposite.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.ShadowDecoration.Parent = this.btnDeposite;
            this.btnDeposite.Size = new System.Drawing.Size(137, 403);
            this.btnDeposite.TabIndex = 13;
            this.btnDeposite.Text = "Deposite";
            this.btnDeposite.TextOffset = new System.Drawing.Point(-17, 0);
            this.btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.lbAbout.ForeColor = System.Drawing.Color.Black;
            this.lbAbout.Location = new System.Drawing.Point(12, 32);
            this.lbAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(412, 19);
            this.lbAbout.TabIndex = 23;
            this.lbAbout.Text = "Here You Can Dealing The Balances With Many Features...";
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
            this.lbSection.Size = new System.Drawing.Size(244, 32);
            this.lbSection.TabIndex = 22;
            this.lbSection.Text = "Transaction Section";
            this.lbSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 467);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbSection);
            this.Controls.Add(this.pnlTransactionControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.pnlTransactionControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTransactionControls;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbSection;
        private Guna.UI2.WinForms.Guna2Button btnDeposite;
        private Guna.UI2.WinForms.Guna2Button btnTranLog;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2Button btnWithraw;
        private Guna.UI2.WinForms.Guna2Button btnTotatBalances;
    }
}