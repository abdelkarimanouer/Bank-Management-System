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

namespace Bank_System
{
    public partial class frmUpdateClient : Form
    {
        clsClient client;

        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private void PrintInfoClient()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtAccountNumber.Text);
            if (client != null)
            {
                txtAccountNumber.Enabled = false;

                txtFirstName.Text = client.FirstName;
                txtFirstName.Enabled = true;

                txtLastName.Text = client.LastName;
                txtLastName.Enabled = true;

                txtPhone.Text = client.Phone;
                txtPhone.Enabled = true;

                txtEmail.Text = client.Email;
                txtEmail.Enabled = true;

                txtPassword.Text = client.Password;
                txtPassword.Enabled = true;

                txtBalance.Text = client.Balance.ToString();
                txtBalance.Enabled = true;

                btnSearch_Update.Text = "Update";
                btnClear.Visible = true;

            }
            else
            {
                MessageBox.Show($"Client with Account Number {txtAccountNumber.Text} not found!", "No Client Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UpdateClient()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtAccountNumber.Text);

            client.AccountNumber = txtAccountNumber.Text;
            client.FirstName = txtFirstName.Text;
            client.LastName = txtLastName.Text;
            client.Email = txtEmail.Text;
            client.Phone = txtPhone.Text;
            client.Password = txtPassword.Text;
            client.Balance = Convert.ToDouble(txtBalance.Text);


            if (client.Save())
            {
                MessageBox.Show("Client Update Successefully", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Update_Click(object sender, EventArgs e)
        {
            if (btnSearch_Update.Text == "Search")
            {
                PrintInfoClient();
            }
            else
            {
                if (MessageBox.Show("Do you want to Update this client?", "Update Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateClient();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtBalance.Clear();

            btnSearch_Update.Text = "Search";
            btnClear.Visible = false;
            txtAccountNumber.Enabled = true;

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
