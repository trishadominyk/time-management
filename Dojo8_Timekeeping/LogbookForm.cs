using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Dojo8_Timekeeping
{
    public partial class LogbookForm : Form
    {
        string logID;
        
        DataTable dataTable;
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        int totalRec;

        public LogbookForm()
        {
            InitializeComponent();

            this.MinimumSize = new Size(632, 389);

            updownYear.Minimum = Convert.ToInt32(DateTime.Now.AddYears(-10).Year.ToString());
            updownYear.Maximum = Convert.ToInt32(DateTime.Now.Year.ToString());

            updownMonth.Minimum = 0;
            updownMonth.Maximum = 12;
        }

        private void LogbookForm_Load(object sender, EventArgs e)
        {
            updownYear.Value = 2016;
            updownMonth.Value = 0;

            HideLabels();
        }

        private void btnGenerateDaily_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT LogID, LoginDate, LoginTime, LogoutTime, tblRecord.CustomerID, tblCustomer.CustomerID, tblCustomer.FName, tblCustomer.LName FROM tblRecord LEFT OUTER JOIN tblCustomer ON tblRecord.CustomerID = tblCustomer.CustomerID WHERE LoginDate LIKE '" + dateTimeDaily.Value.ToShortDateString() + "%'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtRecords");
            dataTable = ds.Tables["dtRecords"];

            totalRec = dataTable.Rows.Count;

            dataGridRecords.DataSource = dataTable;

            this.dataGridRecords.Columns[4].Visible = false;
            this.dataGridRecords.Columns[5].Visible = false;
        }

        private void btnGenerateMY_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string commandString;

            if (updownMonth.Value == 0)
                commandString = "SELECT LogID, LoginDate, LoginTime, LogoutTime, tblRecord.CustomerID, tblCustomer.CustomerID, tblCustomer.FName, tblCustomer.LName FROM tblRecord LEFT OUTER JOIN tblCustomer ON tblRecord.CustomerID = tblCustomer.CustomerID WHERE LoginDate BETWEEN #01/01/" + updownYear.Value + "# AND #31/12/" + updownYear.Value + "# ORDER BY LoginDate DESC, LogID ASC";
            else
            {
                if (updownMonth.Value < 10)
                    commandString = "SELECT LogID, LoginDate, LoginTime, LogoutTime, tblRecord.CustomerID, tblCustomer.CustomerID, tblCustomer.FName, tblCustomer.LName FROM tblRecord LEFT OUTER JOIN tblCustomer ON tblRecord.CustomerID = tblCustomer.CustomerID WHERE LoginDate LIKE '%/0" + updownMonth.Value + "/" + updownYear.Value + "%' ORDER BY LoginDate DESC, LogID ASC";
                else
                    commandString = "SELECT LogID, LoginDate, LoginTime, LogoutTime, tblRecord.CustomerID, tblCustomer.CustomerID, tblCustomer.FName, tblCustomer.LName FROM tblRecord LEFT OUTER JOIN tblCustomer ON tblRecord.CustomerID = tblCustomer.CustomerID WHERE LoginDate LIKE '%/" + updownMonth.Value + "/" + updownYear.Value + "%' ORDER BY LoginDate DESC, LogID ASC";
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtRecords");
            dataTable = ds.Tables["dtRecords"];

            totalRec = dataTable.Rows.Count;

            dataGridRecords.DataSource = dataTable;

            this.dataGridRecords.Columns[4].Visible = false;
            this.dataGridRecords.Columns[5].Visible = false;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT LogID, LoginDate, LoginTime, LogoutTime, tblRecord.CustomerID, tblCustomer.CustomerID, tblCustomer.FName, tblCustomer.LName FROM tblRecord LEFT OUTER JOIN tblCustomer ON tblRecord.CustomerID = tblCustomer.CustomerID WHERE LoginDate LIKE '" + DateTime.Now.ToShortDateString() + "%' ORDER BY LoginDate DESC, LogID ASC";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtRecords");
            dataTable = ds.Tables["dtRecords"];

            totalRec = dataTable.Rows.Count;

            dataGridRecords.DataSource = dataTable;

            this.dataGridRecords.Columns[4].Visible = false;
            this.dataGridRecords.Columns[5].Visible = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT LogID, LoginDate, LoginTime, LogoutTime, tblRecord.CustomerID, tblCustomer.CustomerID, tblCustomer.FName, tblCustomer.LName FROM tblRecord LEFT OUTER JOIN tblCustomer ON tblRecord.CustomerID = tblCustomer.CustomerID ORDER BY LoginDate DESC, LogID ASC";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtRecords");
            dataTable = ds.Tables["dtRecords"];

            totalRec = dataTable.Rows.Count;

            dataGridRecords.DataSource = dataTable;

            this.dataGridRecords.Columns[4].Visible = false;
            this.dataGridRecords.Columns[5].Visible = false;
        }

        private void dataGridRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            try
            {
                 var cell = ((DataGridView)sender)[col, row];

                 if (cell != null)
                 {
                     DataGridViewRow rows = cell.OwningRow;

                     logID = rows.Cells["LogID"].Value.ToString();
                 }
            }
            catch (ArgumentOutOfRangeException)
            {
                HideLabels();
            }

            retrieveDetails();
        }

        private void retrieveDetails()
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT * FROM tblRecordDetails WHERE LogID = '" + logID + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtRecordDetails");
            dataTable = ds.Tables["dtRecordDetails"];

            totalRec = dataTable.Rows.Count;

            if (totalRec > 0)
            {
                lblHoursSpent.Visible = true;
                lblDateExpire.Visible = true;

                lblHoursSpent.Text = dataTable.Rows[0]["HoursSpent"].ToString();
                DateTime expire = DateTime.Parse(dataTable.Rows[0]["DateExpire"].ToString());
                lblDateExpire.Text = expire.ToShortDateString();

                label2.Visible = true;
                label7.Visible = true;
            }
            else
                MessageBox.Show("Customer Currently Timed In.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HideLabels()
        {
            lblHoursSpent.Visible = false;
            lblDateExpire.Visible = false;

            label2.Visible = false;
            label7.Visible = false;
        }
    }
}
