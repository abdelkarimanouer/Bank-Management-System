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
    public partial class frmFindUser : Form
    {
        public frmFindUser()
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

                btnClear.Visible = true;
            }
            else
            {
                MessageBox.Show($"user with UserName {txtUserName.Text} not found!", "No User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PrintInfoUser();
        }
    }
}
