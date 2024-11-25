using Bank_System.Global;
using BankbusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank_System.User
{
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            string FirstName = clsCurrentUser.User.FirstName;

            frmMain main = new frmMain(FirstName);
            main.Show();

        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            DataTable dtUsers = clsUser.GetAllUser();

            foreach (DataRow row in dtUsers.Rows)
            {
                ListViewItem item = new ListViewItem(row["UserName"].ToString());

                item.SubItems.Add(row["FirstName"].ToString());
                item.SubItems.Add(row["LastName"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Phone"].ToString());
                item.SubItems.Add(row["Password"].ToString());
                item.SubItems.Add(row["Permission"].ToString());


                lvUsersList.Items.Add(item);

            }

            for (int i = 0; i < lvUsersList.Columns.Count; i++)
            {
                lvUsersList.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }
    }
}
