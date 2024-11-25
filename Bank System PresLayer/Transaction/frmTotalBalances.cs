using System;
using System.Windows.Forms;
using System.Data;
using BankbusinessLayer;
using Bank_System.Global;


namespace Bank_System.Transaction
{
    public partial class frmTotalBalances : Form
    {
        public frmTotalBalances()
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

        private void frmTotalBalances_Load(object sender, EventArgs e)
        {
            DataTable dtTotalBalances = clsClient.GetAllClients();
            double totalBalance = 0;

            foreach (DataRow row in dtTotalBalances.Rows)
            {
                ListViewItem item = new ListViewItem(row["AccountNumber"].ToString());

                item.SubItems.Add(row["FirstName"].ToString());
                item.SubItems.Add(row["LastName"].ToString());
                item.SubItems.Add(row["Balance"].ToString());

                totalBalance += Convert.ToDouble(row["Balance"]);
                lbTotalBalance.Text = totalBalance.ToString();


                lvTotalBalances.Items.Add(item);

            }


            foreach (ColumnHeader column in lvTotalBalances.Columns)
            {
                column.Width = -2; // -2 = AutoResizeColumn
            }

        }

    }
}
