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

namespace Bank_System.User
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void PrintInfoUser()
        {
            clsUser user = clsUser.FindUserByUserName(txtUserName.Text);

            if (user != null)
            {
                txtUserName.Text = user.UserName;
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtPassword.Text = user.Password;
                txtPhone.Text = user.Phone;
                txtPermissions.Text =  user.Permissions.ToString();

                btnSearch_Delete.Text = "Delete";
                btnClear.Visible = true;

            }
            else
            {
                MessageBox.Show($"user with UserName {txtUserName.Text} not found!", "No User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
        private void DeleteUser()
        {
            if (clsUser.DeleteUser(txtUserName.Text))
            {
                MessageBox.Show("User Delete Successefully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faild", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Delete_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToLower() == "admin")
            {
                MessageBox.Show("You can not delete Admin please try another username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSearch_Delete.Text == "Search")
            {
                PrintInfoUser();
            }

            else
            {
                if (MessageBox.Show("Do you want to delete this user?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteUser();
                }
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
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPermissions.Clear();

            btnSearch_Delete.Text = "Search";
            btnClear.Visible = false;
        }
    }
}
