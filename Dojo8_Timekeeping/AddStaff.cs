using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Dojo8_Timekeeping
{
    public partial class AddStaff : Form
    {
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        public AddStaff()
        {
            InitializeComponent();

            this.MinimumSize = new Size(223, 458);
            this.MaximumSize = new Size(223, 458);
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            cboStaffType.Items.Add("Admin");
            cboStaffType.Items.Add("Cashier");

            lblStaffID.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLName.Text == "" || cboStaffType.Text == "")
                MessageBox.Show("Must fill in REQUIRED fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                OleDbDataAdapter addAdapter = new OleDbDataAdapter();
                string addSql = "INSERT INTO tblStaff(StaffID, FName, LName, StaffType, Password) VALUES('" + CreateStaffID() + "', '" + txtFName.Text + "', '" + txtLName.Text + "', '" + cboStaffType.Text + "', '" + txtPassword.Text + "')";

                var confirmResult = MessageBox.Show("Confirm Staff?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    conn.Open();

                    addAdapter.InsertCommand = new OleDbCommand(addSql, conn);
                    addAdapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Staff Added!");

                    conn.Close();
                }
            }
        }

        private string CreateStaffID()
        {
            string strID;
            string searchString;

            int totalNo;

            DataTable dataTable;
            DataSet ds = new DataSet();

            if (cboStaffType.Text == "Admin")
            {
                searchString = "SELECT * FROM tblStaff WHERE StaffID LIKE '%ADM%'";
                strID = "ADM";
            }
            else
            {
                searchString = "SELECT * FROM tblStaff WHERE StaffID LIKE '%STF%'";
                strID = "STF";
            }

            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtResult");
            dataTable = ds.Tables["dtResult"];

            totalNo = dataTable.Rows.Count;

            strID = (totalNo < 10 ? strID + "0" + Convert.ToString(totalNo + 1) : strID + Convert.ToString(totalNo + 1));

            return strID;
        }

        private void cboStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStaffID.Text = CreateStaffID();
        }
    }
}
