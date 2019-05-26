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
    public partial class CustomersForm : Form
    {
        DataTable dataTable;
        int totalRec;

        public static string custID;
        public static string custType;

        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);
        
        public CustomersForm()
        {
            InitializeComponent();

            //this.MaximumSize = new Size(981, 462);
            this.MinimumSize = new Size(591, 465);
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtFName.Enabled = false;
            txtLName.Enabled = false;

            cboGender.Enabled = false;
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

            txtContactNum.Enabled = false;
            txtEmail.Enabled = false;

            cboCustType.Enabled = false;
            cboCustType.Items.Add("Student");
            cboCustType.Items.Add("Regular");

            lblHours.Text = "";

            //load data grid
            FillControls();
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
                    custType = rows.Cells["CustomerType"].Value.ToString();

                    txtFName.Text = rows.Cells["FName"].Value.ToString();
                    txtLName.Text = rows.Cells["LName"].Value.ToString();
                    cboGender.Text = rows.Cells["Gender"].Value.ToString();
                    txtContactNum.Text = rows.Cells["ContactNum"].Value.ToString();
                    txtEmail.Text = rows.Cells["EmailAdd"].Value.ToString();
                    cboCustType.Text = rows.Cells["CustomerType"].Value.ToString();
                    lblHours.Text = rows.Cells["HoursRemain"].Value.ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                txtFName.Text = "";
                txtLName.Text = "";
                cboGender.Text = "";
                txtContactNum.Text = "";
                txtEmail.Text = "";
                cboCustType.Text = "";
                lblHours.Text = "";

                txtFName.Enabled = false;
                txtLName.Enabled = false;
                txtContactNum.Enabled = false;
                txtEmail.Enabled = false;
                cboCustType.Enabled = false;

                btnCancel.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addCust = new AddCustomer();
            addCust.ShowDialog();
            FillControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string updateString = "UPDATE tblCustomer SET FName = '" + txtFName.Text + "', LName = '" + txtLName.Text + "', Gender = '" + cboGender.Text + "', ContactNum = '" + txtContactNum.Text + "', EmailAdd = '" + txtEmail.Text + "', CustomerType = '" + cboCustType.Text + "' WHERE CustomerID = " + Convert.ToInt32(custID);
            
            var confirmResult = MessageBox.Show("Are you sure you want to edit?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            conn.Open();
            if (confirmResult == DialogResult.Yes)
            {
                OleDbDataAdapter updateAdapter = new OleDbDataAdapter();
                updateAdapter.UpdateCommand = conn.CreateCommand();
                updateAdapter.UpdateCommand.CommandText = updateString;
                updateAdapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Customer Info Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnCancel.Enabled = false;
                btnSave.Enabled = false;

                txtFName.Enabled = false;
                txtLName.Enabled = false;

                cboGender.Enabled = false;

                txtContactNum.Enabled = false;
                txtEmail.Enabled = false;

                cboCustType.Enabled = false;
            }
            conn.Close();

            FillControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != "" || txtLName.Text != "" || txtContactNum.Text != "" || txtEmail.Text != "" || cboCustType.Text != "")
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;

                txtFName.Enabled = true;
                txtLName.Enabled = true;
                cboGender.Enabled = true;
                txtContactNum.Enabled = true;
                txtEmail.Enabled = true;
                cboCustType.Enabled = true;
            }
            else
                MessageBox.Show("Select a Customer to Edit", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != "" || txtLName.Text != "" || cboGender.Text != "" || txtContactNum.Text != "" || txtEmail.Text != "" || cboCustType.Text != "")
            {
                OleDbDataAdapter delAdapter = new OleDbDataAdapter();
                string delSql = "DELETE FROM tblCustomer WHERE CustomerID = " + Convert.ToInt32(custID);

                var confirmResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                conn.Open();
                if (confirmResult == DialogResult.Yes)
                {

                    delAdapter.DeleteCommand = new OleDbCommand(delSql, conn);
                    delAdapter.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Deleted!");

                    txtFName.Text = "";
                    txtLName.Text = "";
                    cboGender.Text = "";
                    txtContactNum.Text = "";
                    txtEmail.Text = "";
                    cboCustType.Text = "";
                }
                conn.Close();

                FillControls();
            }
            else
                MessageBox.Show("Select a Customer to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string searchString = "SELECT * FROM tblCustomer WHERE FName LIKE '%" + txtSearchVal.Text + "%' OR LName LIKE '%" + txtSearchVal.Text + "%'";
            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtResult");
            dataTable = ds.Tables["dtResult"];

            totalRec = dataTable.Rows.Count;

            dataGridCustomer.DataSource = dataTable;
        }

        private void FillControls()
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT * FROM tblCustomer ORDER BY LName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtCustomers");
            dataTable = ds.Tables["dtCustomers"];

            totalRec = dataTable.Rows.Count;

            dataGridCustomer.DataSource = dataTable;
            this.dataGridCustomer.Columns[0].Visible = false;
            this.dataGridCustomer.Columns[8].Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;

            txtFName.Enabled = false;
            txtLName.Enabled = false;

            cboGender.Enabled = false;

            txtContactNum.Enabled = false;
            txtEmail.Enabled = false;

            cboCustType.Enabled = false;
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            if (lblHours.Text != "")
            {
                AddHours addHours = new AddHours(custID);
                addHours.ShowDialog();
            }
            else
                MessageBox.Show("Select a Customer", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillControls();
        }
    }
}
