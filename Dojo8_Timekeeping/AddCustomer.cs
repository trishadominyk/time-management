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
    public partial class AddCustomer : Form
    {
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        public AddCustomer()
        {
            InitializeComponent();

            this.MaximumSize = new Size(223, 493);
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            cboCustType.Items.Add("Student");
            cboCustType.Items.Add("Regular");

            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLName.Text == "" || cboCustType.Text == "" || cboGender.Text == "")
                MessageBox.Show("Must fill in REQUIRED fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                OleDbDataAdapter addAdapter = new OleDbDataAdapter();
                string addSql = "INSERT INTO tblCustomer(FName, LName, Gender, ContactNum, EmailAdd, CustomerType, HoursRemain, TimeRemain) VALUES('" + txtFName.Text + "', '" + txtLName.Text + "', '" + cboGender.Text + "', '" + txtContactNum.Text + "', '" + txtEmail.Text + "', '" + cboCustType.Text + "', 0, 0)";

                var confirmResult = MessageBox.Show("Confirm Customer?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    conn.Open();

                    addAdapter.InsertCommand = new OleDbCommand(addSql, conn);
                    addAdapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Customer Added!");

                    conn.Close();

                    CustomersForm custForm = new CustomersForm();
                    custForm.Refresh();
                    
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to Close? Unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
                this.Close();
        }
    }
}
