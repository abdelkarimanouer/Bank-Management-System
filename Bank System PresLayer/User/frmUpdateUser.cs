using Bank_System.Global;
using BankbusinessLayer;
using System;
using System.Windows.Forms;


namespace Bank_System.User
{
    public partial class frmUpdateUser : Form
    {


        public frmUpdateUser()
        {
            InitializeComponent();

        }

        private void PrintInfoUser()
        {
            clsUser user = clsUser.FindUserByUserName(txtUserName.Text);

            if (user != null)
            {
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtPassword.Text = user.Password;
                txtPhone.Text = user.Phone;
                txtPermissions.Text = user.Permissions.ToString();

                txtUserName.Enabled = false;
                btnSearch_Update.Text = "Update";
                btnClear.Visible = true;

            }
            else
            {
                MessageBox.Show($"user with UserName {txtUserName.Text} not found!", "No User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UpdateUser()
        {
            clsUser user = clsUser.FindUserByUserName(txtUserName.Text);

            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtPhone.Text;
            user.Password = txtPassword.Text;
            user.Permissions = Convert.ToInt32( frmAddUser.Permission );

            if (user.Save())
            {
                MessageBox.Show("User Updated Successefully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faild", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Update_Click(object sender, EventArgs e)
        {

            if (btnSearch_Update.Text == "Search")
            {
                PrintInfoUser();
            }
            else
            {
                if (MessageBox.Show("Do you want to Update this user?", "Update user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateUser();

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPermissions.Clear();

            btnSearch_Update.Text = "Search";
            btnClear.Visible = false;
            txtUserName.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            string FirstName = clsCurrentUser.User.FirstName;

            frmMain main = new frmMain(FirstName);
            main.Show();
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            frmPermissions permissions = new frmPermissions();
            permissions.ShowDialog();
            
            txtPermissions.Text = frmAddUser.Permission.ToString();
        }


    }
}
