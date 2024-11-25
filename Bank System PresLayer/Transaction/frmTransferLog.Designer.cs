namespace Bank_System.Transaction
{
    partial class frmTransferLog
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
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lvTransferLogs = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccFBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccTBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.White;
            this.btnBack.BorderRadius = 10;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(11, 350);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(156, 47);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvTransferLogs
            // 
            this.lvTransferLogs.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvTransferLogs.AutoArrange = false;
            this.lvTransferLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.AccFrom,
            this.AccTo,
            this.Amount,
            this.AccFBalance,
            this.AccTBalance,
            this.User});
            this.lvTransferLogs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTransferLogs.FullRowSelect = true;
            this.lvTransferLogs.GridLines = true;
            this.lvTransferLogs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTransferLogs.HideSelection = false;
            this.lvTransferLogs.Location = new System.Drawing.Point(1, 1);
            this.lvTransferLogs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvTransferLogs.Name = "lvTransferLogs";
            this.lvTransferLogs.Size = new System.Drawing.Size(716, 293);
            this.lvTransferLogs.TabIndex = 17;
            this.lvTransferLogs.UseCompatibleStateImageBehavior = false;
            this.lvTransferLogs.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // AccFrom
            // 
            this.AccFrom.Text = "Acc.From";
            // 
            // AccTo
            // 
            this.AccTo.Text = "Acc.To";
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // AccFBalance
            // 
            this.AccFBalance.Text = "Acc.F.Balance";
            // 
            // AccTBalance
            // 
            this.AccTBalance.Text = "Acc.T.Balance";
            // 
            // User
            // 
            this.User.Text = "User";
            // 
            // frmTransferLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 409);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvTransferLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransferLog";
            this.Load += new System.EventHandler(this.frmTransferLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.ListView lvTransferLogs;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader AccFrom;
        private System.Windows.Forms.ColumnHeader AccTo;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader AccFBalance;
        private System.Windows.Forms.ColumnHeader AccTBalance;
        private System.Windows.Forms.ColumnHeader User;
    }
}