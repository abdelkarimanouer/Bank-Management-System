using Bank_System.Global;
using BankbusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;


namespace Bank_System.Transaction
{
    public partial class frmTransferLog : Form
    {
        public frmTransferLog()
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

        private void frmTransferLog_Load(object sender, EventArgs e)
        {

            DataTable dt = clsClient.GetListsTransferLog();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["Date"].ToString());

                item.SubItems.Add(row["SenderAccountNumber"].ToString());
                item.SubItems.Add(row["ReceiverAccountNumber"].ToString());
                item.SubItems.Add(row["Amount"].ToString());
                item.SubItems.Add(row["SenderBalance"].ToString());
                item.SubItems.Add(row["ReceiverBalance"].ToString());
                item.SubItems.Add(row["UserName"].ToString());


                lvTransferLogs.Items.Add(item);

            }


            for (int i = 0; i < lvTransferLogs.Columns.Count; i++)
            {
                lvTransferLogs.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
    }
}
