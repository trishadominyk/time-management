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
    public partial class ManageStaff : Form
    {
        string staffID, staffPassword;
        string fname, lname, type;
        
        DataTable dataTable;
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        int totalRec;

        public ManageStaff()
        {
            InitializeComponent();

            this.MinimumSize = new Size(549, 334);
            this.MaximumSize = new Size(549, 334);
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            cboType.Items.Add("Admin");
            cboType.Items.Add("Cashier");
            
            LoadTable();
            LoadDefault();
            DisableFields();
            FillControls();

            btnChange.Enabled = false;
        }

        private void LoadTable()
        {
            DataSet ds = new DataSet();

            string searchString = "SELECT * FROM tblStaff";

            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtStaff");
            dataTable = ds.Tables["dtStaff"];

            totalRec = dataTable.Rows.Count;

            dataGridStaff.DataSource = dataTable;
            
            this.dataGridStaff.Columns[4].Visible = false;

            FillControls();
        }

        private void FillControls()
        {
            txtFName.Text = fname;
            txtLName.Text = lname;
            cboType.Text = type;
        }

        private void dataGridStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            try
            {
                var cell = ((DataGridView)sender)[col, row];

                if (cell != null)
                {
                    DataGridViewRow rows = cell.OwningRow;

                    staffID = rows.Cells["StaffID"].Value.ToString();
                    staffPassword = rows.Cells["Password"].Value.ToString();

                    fname = rows.Cells["FName"].Value.ToString();
                    lname = rows.Cells["LName"].Value.ToString();
                    type = rows.Cells["StaffType"].Value.ToString();

                    FillControls();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                LoadDefault();
            }
        }

        private void LoadDefault()
        {
            if (totalRec > 0)
            {
                staffID = dataGridStaff.Rows[0].Cells["StaffID"].Value.ToString();
                staffPassword = dataGridStaff.Rows[0].Cells["Password"].Value.ToString();

                fname = dataGridStaff.Rows[0].Cells["FName"].Value.ToString();
                lname = dataGridStaff.Rows[0].Cells["LName"].Value.ToString();
                type = dataGridStaff.Rows[0].Cells["StaffType"].Value.ToString();
            }
            else
            {
                staffID = "";
                staffPassword = "";

                fname = "";
                lname = "";
                type = "";
            }
        }

        private void DisableFields()
        {
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            cboType.Enabled = false;
            txtPassword.Enabled = false;
            txtNewPassword.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            cboType.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFName.Text == "" || txtLName.Text == "" || cboType.Text == "")
                MessageBox.Show("Fill ALL required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                OleDbDataAdapter addAdapter = new OleDbDataAdapter();

                string addSql = "INSERT INTO tblStaff(FName, LName, StaffType) VALUES('" + txtFName.Text + "', '" + txtLName.Text + "', '" + cboType.Text + "')";

                var confirmResult = MessageBox.Show("Are you sure you want to overwrite?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    conn.Open();

                    addAdapter.InsertCommand = new OleDbCommand(addSql, conn);
                    addAdapter.InsertCommand.ExecuteNonQuery();

                    conn.Close();
                }

                LoadTable();
                DisableFields();
            }
        }

        private void ConfirmPassword()
        {
            DataSet ds = new DataSet();

            string searchString = "SELECT * FROM tblStaff WHERE StaffID = '" + staffID + "' AND Password = '" + txtPassword.Text + "'";

            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtResult");
            dataTable = ds.Tables["dtResult"];
            
            totalRec = dataTable.Rows.Count;

            if (totalRec > 0)
            {
                btnChange.Enabled = true;
                txtNewPassword.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
                txtNewPassword.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ConfirmPassword();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string updateString = "UPDATE tblStaff SET Password = '" + txtNewPassword.Text + "' WHERE StaffID = '" + staffID + "'";

            conn.Open();

            OleDbDataAdapter updateAdapter = new OleDbDataAdapter();
            updateAdapter.UpdateCommand = conn.CreateCommand();
            updateAdapter.UpdateCommand.CommandText = updateString;
            updateAdapter.UpdateCommand.ExecuteNonQuery();

            MessageBox.Show("Password changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();

            txtNewPassword.Enabled = false;
            btnChange.Enabled = false;
            txtPassword.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.ShowDialog();

            LoadTable();
            LoadDefault();
            DisableFields();
            FillControls();
        }
    }
}
