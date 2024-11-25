using System;
using System.Security.Policy;
using System.Windows.Forms;
using Bank_System.Global;
using BankbusinessLayer;

namespace Bank_System.User
{
    public partial class frmAddUser : Form
    {
        public static frmAddUser AddUserForm = new frmAddUser();
        public static int Permission = 0; 

        public frmAddUser()
        {
            InitializeComponent();
            AddUserForm = this;
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
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

        }

        private void AddNewUser()
        {
            clsUser user = new clsUser();

            user.UserName = txtUserName.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtPhone.Text;
            user.Password = txtPassword.Text;
            user.Permissions = Permission;

            if (user.Save())
            {
                MessageBox.Show("User Add Successfully", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faild", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
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

            else
            {
                if (MessageBox.Show("Do you want to add this User?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddNewUser();
                }

            }
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            frmPermissions pr = new frmPermissions();
            pr.Show();
        }
    }
}
