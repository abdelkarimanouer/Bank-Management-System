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
    public partial class frmFindClient : Form
    {
        public frmFindClient()
        {
            InitializeComponent();
        }

        private void PrintInfoClient()
        {
            clsClient client = clsClient.FindClientByAccountNumber(txtAccountNumber.Text);

            if (client != null)
            {
                txtFirstName.Text = client.FirstName;
                txtLastName.Text = client.LastName;
                txtPhone.Text = client.Phone;
                txtEmail.Text = client.Email;
                txtPassword.Text = client.Password;
                txtBalance.Text = client.Balance.ToString();

                btnClear.Visible = true;

            }
            else
            {
                MessageBox.Show($"Client with Account Number {txtAccountNumber.Text} not found!", "No Client Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            string FirstName = clsCurrentUser.User.FirstName;
            frmMain main = new frmMain(FirstName);
            main.Show();
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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PrintInfoClient();
        }
    }
}
