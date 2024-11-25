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

namespace Bank_System.Client
{
    public partial class frmWithraw : Form
    {


        public frmWithraw()
        {
            InitializeComponent();
        }

        private void PrintInfoClient()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtSearchAccount.Text);

            if (client != null)
            {
                txtAccountNumber.Text = client.AccountNumber;
                txtFirstName.Text = client.FirstName;
                txtLastName.Text = client.LastName;
                txtEmail.Text = client.Email;
                txtPassword.Text = client.Password;
                txtPhone.Text = client.Phone;
                txtBalance.Text = client.Balance.ToString();


                txtWithrawBalance.Enabled = true;
                btnClear.Visible = true;
                btnSearch.Tag = "Withraw";
                btnSearch.Text = "Withraw";
            }
            else
            {
                MessageBox.Show($"Client with Account Number {txtSearchAccount.Text} not found!", "No Client Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Withraw()
        {
            double Amount = double.Parse(txtWithrawBalance.Text);

            clsClient client = clsClient.FindClientByAccountNumber(txtSearchAccount.Text);

            if (client != null)
            {
                if (client.Withraw(Amount))
                {
                    MessageBox.Show("Balanced has been Withraw Successefully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You don't have enough money in your account, \nPlease Check Your balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Tag.ToString() == "Search")
            {
                PrintInfoClient();

            }

            else if (btnSearch.Tag.ToString() == "Withraw")
            {
                if (MessageBox.Show("Do you want to Withraw this Amount?", "Confirmed!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Withraw();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchAccount.Clear();
            txtAccountNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtBalance.Clear();
            txtWithrawBalance.Clear();

            btnSearch.Tag = "Search";
            btnSearch.Text = "Search";
            btnClear.Visible = false;
            txtWithrawBalance.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            string FirstName = clsCurrentUser.User.FirstName;
            frmMain main = new frmMain(FirstName);
            main.Show();
        }
    }
}
