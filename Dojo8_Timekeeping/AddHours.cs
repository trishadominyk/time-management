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
    public partial class AddHours : Form
    {
        public static string updateString = "";

        string customerType;
        string customerID;

        string packageID;
        string purchasedHours;
        double amtTotal;

        bool promoValid = false;
        string strDiscount;

        DataTable dataTable;
        int totalRec;

        string expirationDate = DateTime.Now.AddDays(7).ToShortDateString();

        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        public AddHours(string custID)
        {
            InitializeComponent();

            this.MinimumSize = new Size(299, 374);
            this.MaximumSize = new Size(299, 374);
            
            customerID = custID;
        }

        private void AddHours_Load(object sender, EventArgs e)
        {
            //search custID and customerType
            searchCustomer();

            DataSet ds = new DataSet();

            string commandString = "SELECT PackageID, PackageName, Rate, NoOfHours FROM tblPackage WHERE Avail LIKE '" + customerType + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtPackages");
            dataTable = ds.Tables["dtPackages"];

            totalRec = dataTable.Rows.Count;

            dataGridView.DataSource = dataTable;
            this.dataGridView.Columns[0].Visible = false;

            //default values
            packageID = dataTable.Rows[0]["PackageID"].ToString();

            lblPackage.Text = dataTable.Rows[0]["PackageName"].ToString();
            lblRate.Text = dataTable.Rows[0]["Rate"].ToString();
            lblHours.Text = dataTable.Rows[0]["NoOfHours"].ToString();
            lblValid.Text = "";
        }

        private void searchCustomer()
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT CustomerType FROM tblCustomer WHERE CustomerId = " + Convert.ToInt32(customerID);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtCustomers");
            dataTable = ds.Tables["dtCustomers"];

            totalRec = dataTable.Rows.Count;

            customerType = dataTable.Rows[0]["CustomerType"].ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            try
            {
                var cell = ((DataGridView)sender)[col, row];

                if (cell != null)
                {
                    DataGridViewRow rows = cell.OwningRow;

                    packageID = rows.Cells["PackageID"].Value.ToString();
                    purchasedHours = rows.Cells["NoOfHours"].Value.ToString();
                    amtTotal = Convert.ToDouble(rows.Cells["Rate"].Value.ToString());

                    lblPackage.Text = rows.Cells["PackageName"].Value.ToString();
                    lblRate.Text = rows.Cells["Rate"].Value.ToString();
                    lblHours.Text = rows.Cells["NoOfHours"].Value.ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                lblPackage.Text = "";
                lblRate.Text = "";
                lblHours.Text = "";
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (lblPackage.Text == "" || lblRate.Text == "" || lblHours.Text == "")
                MessageBox.Show("Select a Package!", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //UPDATE TBLCUSTOMER
                DataSet ds = new DataSet();

                updateString = "UPDATE tblCustomer SET HoursRemain = HoursRemain + " + Convert.ToDouble(purchasedHours) + ", TimeRemain = TimeRemain + " + Convert.ToInt32(purchasedHours)*3600 + ", DateExpire = '" + DateTime.Parse(expirationDate) + "' WHERE CustomerID = " + Convert.ToInt32(customerID);

                OleDbDataAdapter updateAdapter = new OleDbDataAdapter();

                var confirmResult = MessageBox.Show("Are you sure you want to purchase hours?", "Confirm Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    conn.Open();

                    updateAdapter.UpdateCommand = conn.CreateCommand();
                    updateAdapter.UpdateCommand.CommandText = updateString;
                    updateAdapter.UpdateCommand.ExecuteNonQuery();

                    MessageBox.Show(Convert.ToString(purchasedHours) + " Hours Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn.Close();

                    updateOrder();
                }
            }

            this.Close();
        }

        private void txtPromoCode_TextChanged(object sender, EventArgs e)
        {
            if (txtPromoCode.Text != "")
            {
                DataSet ds = new DataSet();

                string searchString = "SELECT * FROM tblPromo WHERE PromoCode = '" + txtPromoCode.Text + "'";
                OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

                searchAdapter.Fill(ds, "dtResultPromo");
                dataTable = ds.Tables["dtResultPromo"];

                totalRec = dataTable.Rows.Count;

                if (totalRec > 0)
                {
                    if (dataTable.Rows[0]["Valid"].ToString() == "EXPIRED")
                        lblValid.Text = "Promo Expired. Sorry.";
                    else
                    {
                        lblValid.Text = "Promo Valid! " + dataTable.Rows[0]["Discount"].ToString() + "% Discounted.";
                        promoValid = true;

                        strDiscount = dataTable.Rows[0]["Discount"].ToString();
                    }
                }
                else
                    lblValid.Text = "Promo Code Invalid!";
            }
        }

        private void updateOrder()
        {
            //INSERT SQL TBLORDER
            string dateNow = DateTime.Now.ToShortDateString();

            OleDbDataAdapter addAdapter = new OleDbDataAdapter();

            if (promoValid)
                txtPromoCode.Text = "";
            else
            {
                double discount = Convert.ToDouble(strDiscount) % 100;
                amtTotal = amtTotal - (amtTotal * discount);
            }
            
            string addSql = "INSERT INTO tblOrder(OrderDate, StaffID, CustomerID, PackageID, PromoCode, Total, DateExpire) VALUES('" + DateTime.Parse(dateNow) + "', '" + LoginForm.staffID + "', " + Convert.ToInt32(customerID) + ", '" + packageID + "', '" + txtPromoCode.Text + "', " + amtTotal + ", '" + DateTime.Parse(expirationDate) + "')";
            
            conn.Open();

            addAdapter.InsertCommand = new OleDbCommand(addSql, conn);
            addAdapter.InsertCommand.ExecuteNonQuery();

            conn.Close();
        }
    }
}
