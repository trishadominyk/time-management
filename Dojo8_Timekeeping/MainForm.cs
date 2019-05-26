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
    public partial class MainForm : Form
    {
        string logID;
        string custID;
        string custName;
        string hoursRemain;
        string timeIn;
        string expirationDate;

        Timer t = new Timer();

        DataTable dataTable;
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        int totalRec;

        public MainForm()
        {
            InitializeComponent();

            this.MinimumSize = new Size(888, 645);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //clock
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);

            //load user/staff
            DataSet ds = new DataSet();

            string staffName = LoginForm.staffID;
            string strName = "";
            string searchString = "SELECT * FROM tblStaff WHERE StaffID = '" + staffName + "'";

            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtResult");
            dataTable = ds.Tables["dtResult"];

            int search_totalRec = dataTable.Rows.Count;
            
            strName = dataTable.Rows[0]["FName"].ToString() + " " + dataTable.Rows[0]["LName"].ToString();
            lblStaffName.Text = strName;

            //Admin Buttons
            if (dataTable.Rows[0]["StaffType"].ToString() == "Admin")
            {
                btnAddPackagePromo.Enabled = true;
                btnStaff.Visible = true;
            }
            else
            {
                btnAddPackagePromo.Visible = false;
                btnStaff.Visible = false;
            }

            //load tblRecord and default cell selected
            loadTable();

            if (totalRec > 0)
            {
                selectDefaultCustomer();
                ContinueSubtract();
            }
            else
            {
                btnAddHours.Visible = false;
                btnTimeOut.Visible = false;

                lblName.Text = "Time In Customer\nto Begin";
                lblTimeRemain.Text = "00:00:00";
            }

            t.Start();
        }

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("hh:mm:ss tt");

            lblClock.Text = time;

            timerTimeRemain();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }

        //CUSTOMERS
        private void btnManageCust_Click(object sender, EventArgs e)
        {
            CustomersForm custForm = new CustomersForm();
            custForm.ShowDialog();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            AddCustomer addCust = new AddCustomer();
            addCust.ShowDialog();
        }

        //PACKAGE & PROMOS
        private void btnAddPackagePromo_Click(object sender, EventArgs e)
        {
            AddPackagePromo addPackagePromo = new AddPackagePromo();
            addPackagePromo.ShowDialog();
        }
        
        private void btnViewPackagePromo_Click(object sender, EventArgs e)
        {
            PackagePromoForm packagePromoForm = new PackagePromoForm();
            packagePromoForm.ShowDialog();
        }

        //TIME IN & TIME OUT
        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            TimeInCustomer timeInCust = new TimeInCustomer();
            timeInCust.ShowDialog();

            loadTable();

            if (totalRec > 0)
            {
                btnAddHours.Visible = true;
                btnTimeOut.Visible = true;

                selectDefaultCustomer();
            }
            else
            {
                btnAddHours.Visible = false;
                btnTimeOut.Visible = false;

                lblName.Text = "Time In Customer\nto Begin";
                lblTimeRemain.Text = "00:00:00";
            }
        }
        
        private void btnLogbook_Click(object sender, EventArgs e)
        {
            LogbookForm logbookForm = new LogbookForm();
            logbookForm.ShowDialog();

            loadTable();

            if (totalRec > 0)
                selectDefaultCustomer();
            else
            {
                btnAddHours.Visible = false;
                btnTimeOut.Visible = false;

                lblName.Text = "Time In Customer\nto Begin";
                lblTimeRemain.Text = "00:00:00";
            }
        }

        private void loadTable()
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT LogID, LoginDate, LoginTime, TimeExpire, LogoutTime, TimeRemain, tblRecord.CustomerID, tblCustomer.CustomerID, tblCustomer.FName, tblCustomer.LName, tblCustomer.HoursRemain, tblCustomer.DateExpire FROM tblRecord LEFT OUTER JOIN tblCustomer ON tblRecord.CustomerID = tblCustomer.CustomerID WHERE LogoutTime IS NULL ORDER BY LoginTime";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtRecords");
            dataTable = ds.Tables["dtRecords"];

            totalRec = dataTable.Rows.Count;

            dataGridLog.DataSource = dataTable;
            
            this.dataGridLog.Columns[0].Visible = false;
            this.dataGridLog.Columns[4].Visible = false;
            this.dataGridLog.Columns[5].Visible = false;
            this.dataGridLog.Columns[6].Visible = false;
            this.dataGridLog.Columns[7].Visible = false;
            this.dataGridLog.Columns[10].Visible = false;
            this.dataGridLog.Columns[11].Visible = false;
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            if (custID == "")
                MessageBox.Show("Select a Customer", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                AddHours addHours = new AddHours(custID);
                addHours.ShowDialog();

                if (AddHours.updateString != "")
                {
                    string updateString = AddHours.updateString;

                    DataSet ds = new DataSet();

                    OleDbDataAdapter updateAdapter = new OleDbDataAdapter();

                    conn.Open();

                    updateAdapter.UpdateCommand = conn.CreateCommand();
                    updateAdapter.UpdateCommand.CommandText = updateString;
                    updateAdapter.UpdateCommand.ExecuteNonQuery();

                    conn.Close();
                }

                loadTable();

                if (totalRec > 0)
                    selectDefaultCustomer();
            }
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            if (custID == "")
                MessageBox.Show("Select a customer", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //update tblRecord
                DataSet ds = new DataSet();

                string updateString = "UPDATE tblRecord SET LogoutTime = '" + DateTime.Now.ToShortTimeString() + "' WHERE LogID = '" + logID + "'";

                OleDbDataAdapter updateAdapter = new OleDbDataAdapter();

                var confirmResult = MessageBox.Show("Time out " + custName + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    conn.Open();

                    updateAdapter.UpdateCommand = conn.CreateCommand();
                    updateAdapter.UpdateCommand.CommandText = updateString;
                    updateAdapter.UpdateCommand.ExecuteNonQuery();

                    conn.Close();

                    //insert tblRecordDetails
                    insertRecordDetails();
                }
            }

            loadTable();

            if (totalRec > 0)
            {
                btnAddHours.Visible = true;
                btnTimeOut.Visible = true;

                selectDefaultCustomer();
            }
            else
            {
                btnAddHours.Visible = false;
                btnTimeOut.Visible = false;

                lblName.Text = "Time In Customer\nto Begin";
                lblTimeRemain.Text = "00:00:00";
            }
        }

        private void timerTimeRemain()
        {
            string timeRemain;

            for (int i = 0; i < totalRec; i++)
            {
                    int customerID = Convert.ToInt32(dataTable.Rows[i]["tblCustomer.CustomerID"].ToString());
                    logID = dataTable.Rows[i]["LogID"].ToString();
                    int time = Convert.ToInt32(dataTable.Rows[i]["TimeRemain"].ToString());

                    timeRemain = ((time / 3600) >= 10 ? (time / 3600).ToString() : "0" + (time / 3600).ToString()) + ":" + (((time % 3600) / 60) >= 10 ? ((time % 3600) / 60).ToString() : "0" + ((time % 3600) / 60).ToString()) + ":" + ((time % 60) >= 10 ? (time % 60).ToString() : "0" + (time % 60).ToString());

                    //update
                    DataSet ds = new DataSet();

                    time = time - 1;

                    string updateString = "UPDATE tblRecord SET TimeExpire = '" + timeRemain + "' WHERE LogID = '" + logID + "'";
                    
                    TimeSpan hoursSpan = TimeSpan.FromSeconds(time);
                    string strRemain = hoursSpan.ToString(@"hh\.mm");
                    string updateStringCust = "UPDATE tblCustomer SET TimeRemain = " + time + ", HoursRemain = " + Convert.ToDouble(strRemain) + " WHERE CustomerID = " + customerID;

                    OleDbDataAdapter updateAdapter = new OleDbDataAdapter();

                    //update tblrecord
                    conn.Open();

                    updateAdapter.UpdateCommand = conn.CreateCommand();
                    updateAdapter.UpdateCommand.CommandText = updateString;
                    updateAdapter.UpdateCommand.ExecuteNonQuery();

                    conn.Close();

                    //update tblcustomer
                    conn.Open();

                    updateAdapter.UpdateCommand = conn.CreateCommand();
                    updateAdapter.UpdateCommand.CommandText = updateStringCust;
                    updateAdapter.UpdateCommand.ExecuteNonQuery();

                    conn.Close();

                //update lbltimeremain in right panel
                if (dataTable.Rows[i]["tblCustomer.CustomerID"].ToString() == custID)
                    lblTimeRemain.Text = dataTable.Rows[i]["TimeExpire"].ToString();

                //change row color when 15 mins left
                if (Convert.ToInt32(dataTable.Rows[i]["TimeRemain"].ToString()) <= 900)
                {
                    dataGridLog.Rows[i].DefaultCellStyle.BackColor = Color.Crimson;
                    dataGridLog.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    lblTimeRemain.ForeColor = Color.Crimson;
                }
            }

            //refresh table
            loadTable();
        }

        private void dataGridLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            try
            {
                var cell = ((DataGridView)sender)[col, row];

                if(cell != null)
                {
                    DataGridViewRow rows = cell.OwningRow;

                    custID = rows.Cells["tblCustomer.CustomerID"].Value.ToString();
                    custName = rows.Cells["FName"].Value.ToString() + " " + rows.Cells["LName"].Value.ToString();
                    timeIn = rows.Cells["LoginTime"].Value.ToString();
                    hoursRemain = rows.Cells["HoursRemain"].Value.ToString();
                    expirationDate = rows.Cells["DateExpire"].Value.ToString();

                    lblName.Text = custName;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                custID = "";

                lblName.Text = "";
                lblTimeRemain.Text = "";
            }
        }

        private void insertRecordDetails()
        {
            OleDbDataAdapter addAdapter = new OleDbDataAdapter();

            string logOut = DateTime.Now.ToShortTimeString();

            TimeSpan hoursSpent = DateTime.Parse(logOut).Subtract(DateTime.Parse(timeIn));

            string addSql = "INSERT INTO tblRecordDetails(LogID, HoursSpent, HoursRemain, DateExpire) VALUES('" + logID + "', '" + hoursSpent.ToString(@"hh\.mm") + "', " + Convert.ToDouble(hoursRemain) + ", '" + DateTime.Parse(expirationDate) + "')";

            conn.Open();

            addAdapter.InsertCommand = new OleDbCommand(addSql, conn);
            addAdapter.InsertCommand.ExecuteNonQuery();

            conn.Close();
        }

        private void selectDefaultCustomer()
        {
            logID = dataGridLog.Rows[0].Cells["LogID"].Value.ToString();
            custID = dataGridLog.Rows[0].Cells["tblCustomer.CustomerID"].Value.ToString();
            custName = dataGridLog.Rows[0].Cells["FName"].Value.ToString() + " " + dataGridLog.Rows[0].Cells["LName"].Value.ToString();
            timeIn = dataGridLog.Rows[0].Cells["LoginTime"].Value.ToString();
            expirationDate = dataGridLog.Rows[0].Cells["DateExpire"].Value.ToString();

            lblName.Text = custName;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ManageStaff manageStaff = new ManageStaff();
            manageStaff.ShowDialog();
        }

        private void ContinueSubtract()
        {
            string timeRemain;

            for (int i = 0; i < totalRec; i++)
            {
                if (dataTable.Rows[i]["LogoutTime"].ToString() == "")
                {
                    int customerID = Convert.ToInt32(dataTable.Rows[i]["tblCustomer.CustomerID"].ToString());
                    logID = dataTable.Rows[i]["LogID"].ToString();
                    int time = Convert.ToInt32(dataTable.Rows[i]["TimeRemain"].ToString());

                    string timeNow = DateTime.Now.ToShortTimeString();

                    //update
                    DataSet ds = new DataSet();

                    string logInTime = dataTable.Rows[i]["LoginTime"].ToString();
                    //TimeSpan logIn = DateTime.Parse(timeNow).Subtract(DateTime.Parse(logInTime));
                    TimeSpan logIn = Convert.ToDateTime(timeNow) - Convert.ToDateTime(logInTime);

                    time = time - logIn.Seconds;

                    timeRemain = ((time / 3600) >= 10 ? (time / 3600).ToString() : "0" + (time / 3600).ToString()) + ":" + (((time % 3600) / 60) >= 10 ? ((time % 3600) / 60).ToString() : "0" + ((time % 3600) / 60).ToString()) + ":" + ((time % 60) >= 10 ? (time % 60).ToString() : "0" + (time % 60).ToString());

                    string updateString = "UPDATE tblRecord SET TimeExpire = '" + timeRemain + "' WHERE LogID = '" + logID + "'";

                    TimeSpan hoursSpan = TimeSpan.FromSeconds(time);
                    string strRemain = hoursSpan.ToString(@"hh\.mm");
                    string updateStringCust = "UPDATE tblCustomer SET TimeRemain = " + time + ", HoursRemain = " + Convert.ToDouble(strRemain) + " WHERE CustomerID = " + customerID;

                    OleDbDataAdapter updateAdapter = new OleDbDataAdapter();

                    //update tblrecord
                    conn.Open();

                    updateAdapter.UpdateCommand = conn.CreateCommand();
                    updateAdapter.UpdateCommand.CommandText = updateString;
                    updateAdapter.UpdateCommand.ExecuteNonQuery();

                    conn.Close();

                    //update tblcustomer
                    conn.Open();

                    updateAdapter.UpdateCommand = conn.CreateCommand();
                    updateAdapter.UpdateCommand.CommandText = updateStringCust;
                    updateAdapter.UpdateCommand.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }
    }
}
