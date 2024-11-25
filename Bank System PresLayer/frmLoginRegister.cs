using BankbusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmLoginRegister : Form
    {
        public frmLoginRegister()
        {
            InitializeComponent();
        }

        private void frmLoginRegister_Load(object sender, EventArgs e)
        {
            DataTable dt = clsUser.GetLoginsRegisters();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["Date"].ToString());

                item.SubItems.Add(row["UserName"].ToString());
                item.SubItems.Add(row["Password"].ToString());
                item.SubItems.Add(row["Permissions"].ToString());


                lvLoginRegister.Items.Add(item);

            }


            for (int i = 0; i < lvLoginRegister.Columns.Count; i++)
            {
                lvLoginRegister.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
    }
}
