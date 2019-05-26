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
    public partial class TimeInCustomer : Form
    {
        Timer t = new Timer();
        
        string custID = "";
        string custName = "";
        double hoursRemain;

        string dateNow = DateTime.Now.ToString("dd/MM/yyyy");
        string timeNow = DateTime.Now.ToShortTimeString();
        string dateNowID = DateTime.Now.ToString("MMdd");
        
        DataTable dataTable;
        int totalRec;

        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        public TimeInCustomer()
        {
            InitializeComponent();

            this.MaximumSize = new Size(424, 263);
        }
        
        private void TimeInCustomer_Load(object sender, EventArgs e)
        {
            //check customer records first
            checkTblRecord();

            if (totalRec > 0)
            {
                DataSet ds = new DataSet();

                string commandString = "SELECT CustomerID, FName, LName, Gender, CustomerType, HoursRemain FROM tblCustomer WHERE CustomerID <> " + getTimeinCustomers() + " AND DateExpire >= #" + DateTime.Now.ToShortDateString() + "# ORDER BY LName ASC";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

                dataAdapter.Fill(ds, "dtCustomers");
                dataTable = ds.Tables["dtCustomers"];

                totalRec = dataTable.Rows.Count;
            }
            else
            {
                DataSet ds = new DataSet();

                string commandString = "SELECT CustomerID, FName, LName, Gender, CustomerType, HoursRemain FROM tblCustomer WHERE DateExpire >= #" + DateTime.Now.ToShortDateString() + "# ORDER BY LName ASC";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

                dataAdapter.Fill(ds, "dtCustomers");
                dataTable = ds.Tables["dtCustomers"];

                totalRec = dataTable.Rows.Count;
            }

            dataGridCustomer.DataSource = dataTable;
            this.dataGridCustomer.Columns[0].Visible = false;

            //default select
            if (totalRec > 0)
            {
                custID = dataGridCustomer.Rows[0].Cells["CustomerID"].ToString();
                hoursRemain = Convert.ToDouble(dataGridCustomer.Rows[0].Cells["HoursRemain"].Value);
                custName = dataGridCustomer.Rows[0].Cells["FName"].ToString() + " " + dataGridCustomer.Rows[0].Cells["LName"].ToString();
            }
        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            if (custID == "")
                MessageBox.Show("Select a Customer", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (hoursRemain <= 0.00)
                    MessageBox.Show("Cannot Time In, 0 Hours Remaining", "Invalid Hours", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    OleDbDataAdapter addAdapter = new OleDbDataAdapter();

                    string addSql = "INSERT INTO tblRecord(LogID, LoginDate, LoginTime, TimeExpire, CustomerID, StaffID) VALUES('" + (countLogRecord() < 10 ? "L0" + Convert.ToString(countLogRecord()) : "L" + Convert.ToString(countLogRecord())) + "-" + dateNowID + "', '" + DateTime.Parse(dateNow) + "', '" + timeNow + "', '" + computeTimeExpire() + "', " + Convert.ToInt32(custID) + ", '" + LoginForm.staffID + "')";

                    var confirmResult = MessageBox.Show("Time in " + custName + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        conn.Open();

                        addAdapter.InsertCommand = new OleDbCommand(addSql, conn);
                        addAdapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Customer Timed In!");

                        conn.Close();

                        this.Close(); 
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string searchString = "SELECT * FROM tblCustomer WHERE FName LIKE '%" + txtSearchVal.Text + "%' OR LName LIKE '%" + txtSearchVal.Text + "%' WHERE CustomerID <> " + getTimeinCustomers() + " AND DateExpire >= #" + DateTime.Now.ToShortDateString() + "#";
            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtResult");
            dataTable = ds.Tables["dtResult"];

            totalRec = dataTable.Rows.Count;

            dataGridCustomer.DataSource = dataTable;
        }

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            try
            {
                var cell = ((DataGridView)sender)[col, row];

                if (cell != null)
                {
                    DataGridViewRow rows = cell.OwningRow;

                    custID = rows.Cells["CustomerID"].Value.ToString();
                    custName = rows.Cells["FName"].Value.ToString() + " " + rows.Cells["LName"].Value.ToString();
                    hoursRemain = Convert.ToDouble(rows.Cells["HoursRemain"].Value.ToString());
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                custID = "";
                custName = "";
            }
        }

        private int countLogRecord()
        {
            int totalRecord;
            string searchString;

            DataTable dataTable;
            DataSet ds = new DataSet();

            searchString = "SELECT * FROM tblRecord WHERE LogID LIKE '%" + dateNowID + "%'";

            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtResult");
            dataTable = ds.Tables["dtResult"];

            totalRecord = dataTable.Rows.Count;

            return totalRecord + 1;
        }

        private string computeTimeExpire()
        {
            double hours = hoursRemain;
            TimeSpan ts = TimeSpan.FromHours(hours);
            string timeExpire = ts.ToString(@"hh\:mm\:ss");

            return timeExpire;
        }

        private void checkTblRecord()
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT * FROM tblRecord WHERE LogoutTime IS NULL";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtCustomers");
            dataTable = ds.Tables["dtCustomers"];

            totalRec = dataTable.Rows.Count;
        }

        private string getTimeinCustomers()
        {
            string timedInCustomers = "";
            
            DataSet ds = new DataSet();

            string searchString = "SELECT CustomerID FROM tblRecord WHERE LogoutTime IS NULL";

            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtResult");
            dataTable = ds.Tables["dtResult"];

            totalRec = dataTable.Rows.Count;

            for (int i = 0; i < totalRec; i++)
            {
                if(i == 0)
                    timedInCustomers = timedInCustomers + dataTable.Rows[i]["CustomerID"].ToString();
                else
                    timedInCustomers = timedInCustomers + " AND CustomerID <> " + dataTable.Rows[i]["CustomerID"].ToString();
            }

            return timedInCustomers;
        }
    }
}
