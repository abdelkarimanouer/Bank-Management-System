using BankbusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }

        void LoadForm(object frmSender)
        {
            if (this.pnlClientsControls.Controls.Count > 0)
            {
                this.pnlClientsControls.Controls.Clear();
            }

            Form myForm = frmSender as Form;
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            this.pnlClientsControls.Controls.Add(myForm);
            myForm.Show();


        }

        private void btnClientsList_Click(object sender, EventArgs e)
        {
                lbSection.Text = "Clients Section > Client List";
                lbAbout.Text = "Here you can see all Clients...";

                LoadForm(new frmClientsList());
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
                lbSection.Text = "Clients Section > Add Client";
                lbAbout.Text = "Here you can add a new client...";

                LoadForm(new frmAddClient());


        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
                lbSection.Text = "Clients Section > Delete Client";
                lbAbout.Text = "Here you can Delete a client...";

                LoadForm(new frmDeleteClient());


        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Clients Section > Find Client";
            lbAbout.Text = "Here you can Find a client...";

            LoadForm(new frmFindClient());
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            lbSection.Text = "Clients Section > Update Client";
            lbAbout.Text = "Here you can Update a client...";

            LoadForm(new frmUpdateClient());
        }

        private void CheckifUserHavePermissionsForClient()
        {
            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enAddClient))
            {
                btnAddClient.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enDeleteClient))
            {
                btnDeleteClient.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enFindClient))
            {
                btnFindClient.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enUpdateClient))
            {
                btnUpdateClient.Enabled = true;
            }

            if (clsUser.CheckAccessPermission(clsUser.enPermissions.enClientsList))
            {
                btnClientsList.Enabled = true;
            }
        }

        private void frmClients_Load(object sender, EventArgs e)
        {

            CheckifUserHavePermissionsForClient();

        }
    }
}
