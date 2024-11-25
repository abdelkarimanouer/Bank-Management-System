using System;
using System.Windows.Forms;
using System.Data;
using BankbusinessLayer;
using Bank_System.Global;

namespace Bank_System
{
    public partial class frmClientsList : Form
    {

        public frmClientsList()
        {
            InitializeComponent();
        }



        private void frmClientsList_Load(object sender, EventArgs e)
        {

            DataTable dt = clsClient.GetAllClients();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["AccountNumber"].ToString());

                item.SubItems.Add(row["FirstName"].ToString());
                item.SubItems.Add(row["LastName"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Phone"].ToString());
                item.SubItems.Add(row["Password"].ToString());
                item.SubItems.Add(row["Balance"].ToString());


                lvClientsList.Items.Add(item);

            }


            for (int i = 0; i < lvClientsList.Columns.Count; i++)
            {
                lvClientsList.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            string FirstName = clsCurrentUser.User.FirstName;

            frmMain main = new frmMain(FirstName);
            main.Show();

        }
    }
}
