using Bank_System.Global;
using BankbusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmAddClient : Form
    {

        public frmAddClient()
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            string FirstName = clsCurrentUser.User.FirstName ;
            frmMain main = new frmMain(FirstName);
            main.Show();
        }

        private void AddNewClient()
        {
            clsClient client = new clsClient();

            client.AccountNumber = txtAccountNumber.Text;
            client.FirstName = txtFirstName.Text;
            client.LastName = txtLastName.Text;
            client.Phone = txtPhone.Text;
            client.Email = txtEmail.Text;
            client.Password = txtPassword.Text;
            client.Balance = Convert.ToDouble( txtBalance.Text );

            if (client.Save())
            {
                MessageBox.Show("Client Added Successfully");
            }
            else
            {
                MessageBox.Show("Faild");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                txtAccountNumber.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                txtPhone.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtBalance.Text))
            {
                txtBalance.Focus();
            }

            else
            {


                if (MessageBox.Show("Do you want to add this Client?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddNewClient();   
                }

            }

        }
    }
}
