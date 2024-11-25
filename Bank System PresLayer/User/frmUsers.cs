using BankbusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank_System.User
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        void LoadForm(object frmSender)
        {
            if (this.pnlUserControls.Controls.Count > 0)
            {
                this.pnlUserControls.Controls.Clear();
            }

            Form myForm = frmSender as Form;
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            this.pnlUserControls.Controls.Add(myForm);
            myForm.Show();


        }


        private void btnUsersList_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Users Section > Users List";
            lbAbout.Text = "Here you can see all Users...";

            LoadForm(new frmUsersList());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Users Section > Add User";
            lbAbout.Text = "Here you can Add a User...";

            LoadForm(new frmAddUser());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Users Section > Delete User";
            lbAbout.Text = "Here you can Delete a User...";

            LoadForm(new frmDeleteUser());
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Users Section > Find User";
            lbAbout.Text = "Here you can Find a User...";

            LoadForm(new frmFindUser());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Users Section > Update User";
            lbAbout.Text = "Here you can Update a User...";

            LoadForm(new frmUpdateUser());
        }

        private void CheckifUserHavePermissionsForUserFeatures()
        {
            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enAddUser))
            {
                btnAddUser.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enDeleteUser))
            {
                btnDeleteUser.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enFindUser))
            {
                btnFindUser.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enUpdateUser))
            {
                btnUpdateUser.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enUsersList))
            {
                btnUsersList.Enabled = true;
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            CheckifUserHavePermissionsForUserFeatures();
        }
    
    }
}
