using Bank_System.Client;
using Bank_System.User;
using BankbusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank_System.Transaction
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        void LoadForm(object frmSender)
        {
            if (this.pnlTransactionControls.Controls.Count > 0)
            {
                this.pnlTransactionControls.Controls.Clear();
            }

            Form myForm = frmSender as Form;
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            this.pnlTransactionControls.Controls.Add(myForm);
            myForm.Show();


        }


        private void CheckifUserHavePermissionsForUserFeatures()
        {
            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enTotalBalances))
            {
                btnTotatBalances.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enDeposite))
            {
                btnDeposite.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enWithraw))
            {
                btnWithraw.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enTransfer))
            {
                btnTransfer.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enTransferLog))
            {
                btnTranLog.Enabled = true;
            }
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
           CheckifUserHavePermissionsForUserFeatures();
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Transaction Section > Deposite";
            lbAbout.Text = "Here you can Deposite Money to your Account...";

            LoadForm(new frmDeposite());
        }

        private void btnWithraw_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Transaction Section > Withraw";
            lbAbout.Text = "Here you can Withraw Money From your Account...";

            LoadForm(new frmWithraw());
        }

        private void btnTotatBalances_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Transaction Section > Total Balances";
            lbAbout.Text = "Here you can See Total Balances...";

            LoadForm(new frmTotalBalances());
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Transaction Section > Transfer";
            lbAbout.Text = "Here you can Transfer Money From Account To Another...";

            LoadForm(new frmTransfer());
        }

        private void btnTranLog_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Transaction Section > Transfer Log";
            lbAbout.Text = "Here you can See All Transfers History...";

            LoadForm(new frmTransferLog());
        }
    }
}
