
using Bank_System.Global;
using BankbusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System.Transaction
{
    public partial class frmTransfer : Form
    {
        public static frmTransfer TranFormInstance = new frmTransfer();

        public frmTransfer()
        {
            InitializeComponent();
            TranFormInstance = this;
        }

        private bool PrintInfoClientFrom()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtAccountNumberFrom.Text);

            if (client != null)
            {
                txtAccountNumberFrom.Text = client.AccountNumber;
                txtFirstNameFrom.Text = client.FirstName;
                txtLastNameFrom.Text = client.LastName;
                txtEmailFrom.Text = client.Email;
                txtPhoneFrom.Text = client.Phone;
                txtBalanceFrom.Text = client.Balance.ToString();

                return true;

            }
            else
            {
                return false;
            }

        }

        private bool PrintInfoClientTo()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtAccountNumberTo.Text);

            if (client != null)
            {
                txtAccountNumberTo.Text = client.AccountNumber;
                txtFirstNameTo.Text = client.FirstName;
                txtLastNameTo.Text = client.LastName;
                txtEmailTo.Text = client.Email;
                txtPhoneTo.Text = client.Phone;
                txtBalanceTo.Text = client.Balance.ToString();

                return true;

            }
            else
            {
                return false;
            }

        }

        private void PrintInfos()
        {
            if (PrintInfoClientFrom() && PrintInfoClientTo())
            {
                txtTransferBalance.Enabled = true;
                btnClear.Visible = true;
                btnSearch.Tag = "Transfer";
                btnSearch.Text = "Transfer";
            }
            else
            {
                MessageBox.Show("Account Number From Or To is not correct Enter The Accounts Number Correct", "No Client Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Transfer()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtAccountNumberFrom.Text);
            double Amount = double.Parse(txtTransferBalance.Text);

            if (client != null) 
            {
                if (client.Transfer(txtAccountNumberTo.Text, Amount))
                {
                    MessageBox.Show("operation accomplished successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    client.TransferLog(txtAccountNumberTo.Text, Amount, clsCurrentUser.User.UserName);
                }
                else
                {
                    MessageBox.Show("operation Faild", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Info Client From
            txtAccountNumberFrom.Clear();
            txtFirstNameFrom.Clear();
            txtLastNameFrom.Clear();
            txtEmailFrom.Clear();
            txtPhoneFrom.Clear();
            txtBalanceFrom.Clear();

            // Clear Info Client To
            txtAccountNumberTo.Clear();
            txtFirstNameTo.Clear();
            txtLastNameTo.Clear();
            txtEmailTo.Clear();
            txtPhoneTo.Clear();
            txtBalanceTo.Clear();

            // Clear Transfer Balance
            txtTransferBalance.Clear();

            btnSearch.Tag = "Search";
            btnSearch.Text = "Search";
            btnClear.Visible = false;
            txtTransferBalance.Enabled = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            string FirstName = "";
            frmMain main = new frmMain(FirstName);
            main.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Tag.ToString() == "Search")
            {
                PrintInfos();
            }

            else if (btnSearch.Tag.ToString() == "Transfer")
            {
                if (MessageBox.Show($"Do you want to Transfer this Amount From {txtAccountNumberFrom.Text} to {txtAccountNumberTo.Text}?", "Confirmed!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Transfer();
                }
            }
        }
    
    }
}
