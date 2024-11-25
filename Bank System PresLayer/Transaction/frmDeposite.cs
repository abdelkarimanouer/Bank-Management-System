
using Bank_System.Global;
using BankbusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank_System.Transaction
{
    public partial class frmDeposite : Form
    {

        public frmDeposite()
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


                txtDepositeBalance.Enabled = true;
                btnClear.Visible = true;
                btnSearch.Tag = "Send";
                btnSearch.Text = "Send";
            }
            else
            {
                MessageBox.Show($"Client with Account Number {txtSearchAccount.Text} not found!", "No Client Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Deposite()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtSearchAccount.Text);
            double Amount = double.Parse(txtDepositeBalance.Text);

            if (client != null) 
            {
                if (client.Deposite(Amount))
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Faild");
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Tag.ToString() == "Search")
            {
                PrintInfoClient();
  
            }

            else if(btnSearch.Tag.ToString() == "Send")
            {
                if (MessageBox.Show("Do you want to deposite this Amount?", "Confirmed!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Deposite();

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
            txtDepositeBalance.Clear();

            btnSearch.Text = "Search";
            btnSearch.Tag = "Search";
            btnClear.Visible = false;
            txtDepositeBalance.Enabled = false;
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
