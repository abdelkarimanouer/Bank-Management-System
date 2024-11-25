using Bank_System.Global;
using Bank_System.Properties;
using Bank_System.Transaction;
using Bank_System.User;
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
    public partial class frmMain : Form
    {     
        public string _FirstName;

        public frmMain(string FirstName )
        {
            InitializeComponent();
            this._FirstName = FirstName;
        }

        void LoadForm(object frmSender)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.Clear() ;
            }

            Form myForm = frmSender as Form;
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(myForm);
            myForm.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbWelcom.Text = "Welcom Back, " + _FirstName;
            lbDate.Text = DateTime.Now.ToString("F");

            LoadForm(new frmClients());

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            LoadForm(new frmClients());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUsers() );
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsCurrentUser.User = new clsUser();

            this.Close();

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            LoadForm(new frmTransaction());
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            LoadForm(new frmLoginRegister());
        }
    }
}
