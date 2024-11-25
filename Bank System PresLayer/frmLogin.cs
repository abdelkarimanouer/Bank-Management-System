using Bank_System.Global;
using Bank_System.Properties;
using BankbusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();

        }

        private void CheckIfAnytxtboxIsEmpty()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Please Enter UserName First!");
            }

            if (string.IsNullOrEmpty(txtPassowrd.Text))
            {
                txtPassowrd.Focus();
                errorProvider1.SetError(txtPassowrd, "Please Enter Password First!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckIfAnytxtboxIsEmpty();

            clsUser user = clsUser.FindUserByUserNameAndPassword(txtUsername.Text, txtPassowrd.Text);

            if (user != null)
            {
                clsCurrentUser.User = user;
                clsUser._PermissionsToCheck = user.Permissions;

                user.SaveLoginsRegisters();
                frmMain main = new frmMain(user.FirstName);
                main.Show();
            }
            else
            {
                MessageBox.Show("UserName Or Password Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            if (pbShowPassword.Tag.ToString() == "Hide")
            {
                pbShowPassword.Tag = "Show";
                pbShowPassword.Image = Resources.ShowEye;
                txtPassowrd.PasswordChar = '\0';
            }

            else if (pbShowPassword.Tag.ToString() == "Show")
            {
                pbShowPassword.Tag = "Hide";
                pbShowPassword.Image = Resources.eye_slash_visible_hide_hidden_show_icon_145987;
                txtPassowrd.PasswordChar = '*';
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    
    }
}
