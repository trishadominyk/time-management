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
    public partial class LoginForm : Form
    {
        public static string staffID;
        public static string staffType;
        
        DataTable dataTable;
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        public LoginForm()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
            this.MaximumSize = new Size(591, 472);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtStaffID.Text = "";
            txtPassword.Text = "";
        }

        private void loginConfirm()
        {
            DataSet ds = new DataSet();

            string userID = txtStaffID.Text.ToUpper();
            string userPassword = txtPassword.Text;
            
            if (userID == "" || userPassword == "")
                MessageBox.Show("Must fill in ALL fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string searchString = "SELECT * FROM tblStaff WHERE StaffID = '" + userID + "' AND Password = '" + userPassword + "'";

                OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

                searchAdapter.Fill(ds, "dtResult");
                dataTable = ds.Tables["dtResult"];

                int search_totalRec = dataTable.Rows.Count;

                if (search_totalRec > 0)
                {
                    staffID = userID;
                    staffType = dataTable.Rows[0]["StaffType"].ToString();

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
                else
                    MessageBox.Show("Invalid ID/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginConfirm();
        }
    }
}
