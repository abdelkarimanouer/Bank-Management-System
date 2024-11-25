using System;
using System.Windows.Forms;

namespace Bank_System.User
{
    public partial class frmPermissions : Form
    {
        private enum enPermissions 
        {
            enClientsList = 1, enAddClient = 2, enDeleteClient = 4, enFindClient = 8, enUpdateClient = 16,
            enUsersList = 32, enAddUser = 64, enDeleteUser = 128, enFindUser = 256, enUpdateUser = 512,
            enDeposite = 1024, enWithraw = 2048, enTotalBalances = 4096, enTransfer = 8192, enTransferLog = 16384, 
        };

        public frmPermissions()
        {
            InitializeComponent();
        }

        private void rbClientSection_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClientSection.Checked)
            {
                pnlClient.Enabled = true;
            }

        }

        private void rbUserSection_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUserSection.Checked)
            {
                pnlUser.Enabled = true;
            }
        }

        private void rbTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTransaction.Checked)
            {
                pnlTransaction.Enabled = true;
            }

        }

        private void rbFullAccess_CheckedChanged(object sender, EventArgs e)
        {

            // Enable Rbuttons
            rbClientSection.Checked = true;
            rbUserSection.Checked = true;
            rbTransaction.Checked = true;

            // Enable CheckBoxs of Client
            chbAddClient.Checked = true;
            chbDeleteClient.Checked = true;
            chbClientsList.Checked = true;
            chbFindClient.Checked = true;
            chbUpdateClient.Checked = true;

            // Enable Checkboxs of User
            chbUsersList.Checked = true;
            chbAddUser.Checked = true;
            chbDeleteUser.Checked = true;
            chbFindUser.Checked = true;
            chbUpdateUser.Checked = true;

            // Enable checkboxs of Transaction
            chbDeposit.Checked = true;
            chbWithraw.Checked = true;
            chbTransfer.Checked = true;
            chbTransferLog.Checked = true;
            chbTotalBalances.Checked = true;

        }

        private void PermissionsOfClient()
        {
            //permissions of Client
            if (chbClientsList.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enClientsList);
            }

            if (chbAddClient.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enAddClient);
            }

            if (chbDeleteClient.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enDeleteClient);
            }

            if (chbFindClient.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enFindClient);
            }

            if (chbUpdateClient.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enUpdateClient);
            }

        }

        private void PermissionsOfUser()
        {
            // Permissions of User
            if (chbUsersList.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enUsersList);
            }

            if (chbAddUser.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enAddUser);
            }

            if (chbDeleteUser.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enDeleteUser);
            }

            if (chbFindUser.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enFindUser);
            }

            if (chbUpdateUser.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enUpdateUser);
            }
        }

        private void Transaction()
        {
            //Permissions of transaction
            if (chbDeposit.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enDeposite);
            }

            if (chbWithraw.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enWithraw);
            }

            if (chbTotalBalances.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enTotalBalances);
            }

            if (chbTransfer.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enTransfer);
            }

            if (chbTransferLog.Checked)
            {
                frmAddUser.Permission += ((int)enPermissions.enTransferLog);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this Permissions?", "Confirmed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (rbFullAccess.Checked)
                {
                    frmAddUser.Permission = -1;
                }
                else
                {
                    PermissionsOfClient();
                    PermissionsOfUser();
                    Transaction();
                }

            }

            this.Close();
        }
    }
}
