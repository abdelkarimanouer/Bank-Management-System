using Bank_System.Global;
using BankbusinessLayer;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
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

            btnSearch_Delete.Text = "Search";
            btnClear.Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            string FirstName = clsCurrentUser.User.FirstName;
            frmMain main = new frmMain(FirstName);
            main.Show();
        }

        private void PrintInfoClient()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtAccountNumber.Text);

            if (client != null)
            {
                txtAccountNumber.Text = client.AccountNumber;
                txtFirstName.Text = client.FirstName;
                txtLastName.Text = client.LastName;
                txtPhone.Text = client.Phone;
                txtEmail.Text = client.Email;
                txtPassword.Text = client.Password;
                txtBalance.Text = client.Balance.ToString();

                btnSearch_Delete.Text = "Delete";
                btnClear.Visible = true;

            }
            else
            {
                MessageBox.Show($"Client with Account Number {txtAccountNumber.Text} not found!", "No Client Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DeleteClient()
        {
            if (clsClient.DeleteClient(txtAccountNumber.Text))
            {
                MessageBox.Show("Client Delete Successefully", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Client Delete Faild", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Delete_Click(object sender, EventArgs e)
        {
            if (btnSearch_Delete.Text == "Search")
            {
                PrintInfoClient();
            }
            else 
            {
                if (MessageBox.Show("Do you want to delete this client?", "Delete Client", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteClient();
                    
                }
            }

        }
    }
}
