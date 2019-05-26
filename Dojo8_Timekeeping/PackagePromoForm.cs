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
    public partial class PackagePromoForm : Form
    {
        DataTable dataTable;
        int totalRec;
        
        public static string tabSelected;
        public static string packageID;
        public static string promoCode;

        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        public PackagePromoForm()
        {
            InitializeComponent();

            updownYear.Minimum = Convert.ToInt32(DateTime.Now.AddYears(-10).Year.ToString());
            updownYear.Maximum = Convert.ToInt32(DateTime.Now.Year.ToString());

            updownMonth.Minimum = 0;
            updownMonth.Maximum = 12;
        }

        private void PackagePromoForm_Load(object sender, EventArgs e)
        {
            string staffType = LoginForm.staffType;

            if (staffType == "Admin")
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
            }

            btnSavePackage.Enabled = false;
            btnCancelPackage.Enabled = false;

            btnSavePromo.Enabled = false;
            btnCancelPromo.Enabled = false;

            cboCustType1.Items.Add("Student");
            cboCustType1.Items.Add("Regular");
            cboCustType1.Items.Add("All");
            cboCustType1.Text = ("All");

            cboCustType2.Items.Add("Student");
            cboCustType2.Items.Add("Regular");
            cboCustType2.Items.Add("All");
            cboCustType2.Text = ("All");

            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("All");
            cboGender.Text = ("All");

            txtPackage.Enabled = false;
            txtRate.Enabled = false;
            cboAvail1.Enabled = false;
            txtHours.Enabled = false;

            txtPromoCode.Enabled = false;
            txtPromo.Enabled = false;
            txtDiscount.Enabled = false;
            cboAvail2.Enabled = false;
            dateTimeStart.Enabled = false;
            dateTimeEnd.Enabled = false;

            tabSelected = "Packages";

            dateTimeStart.Format = DateTimePickerFormat.Short;
            dateTimeEnd.Format = DateTimePickerFormat.Short;

            updownYear.Value = 2016;
            updownMonth.Value = 0;

            FillControlsPackages();
        }

        private void FillControlsPackages()
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT * FROM tblPackage";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtPackages");
            dataTable = ds.Tables["dtPackages"];

            totalRec = dataTable.Rows.Count;

            dataGridView.DataSource = dataTable;
            this.dataGridView.Columns[0].Visible = false;
        }

        private void FillControlsPromos()
        {
            DataSet ds = new DataSet();
            string commandString;

            if (chkboxExpired.Checked)
                commandString = "SELECT * FROM tblPromo";
            else
                commandString = "SELECT * FROM tblPromo WHERE Valid = 'VALID'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtPromo");
            dataTable = ds.Tables["dtPromo"];

            totalRec = dataTable.Rows.Count;

            dataGridView.DataSource = dataTable;

            this.dataGridView.Columns[0].Visible = false;
        }

        private void FillControlsReports()
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT * FROM tblOrder";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtReports");
            dataTable = ds.Tables["dtReports"];

            totalRec = dataTable.Rows.Count;

            dataGridView.DataSource = dataTable;
            this.dataGridView.Columns[0].Visible = false;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            DateTime dtStart;
            DateTime dtEnd;

            try
            {
                var cell = ((DataGridView)sender)[col, row];

                if (cell != null)
                {
                    DataGridViewRow rows = cell.OwningRow;

                    if (tabSelected == "Packages")
                    {
                        packageID = rows.Cells["PackageID"].Value.ToString();
                        txtPackage.Text = rows.Cells["PackageName"].Value.ToString();
                        txtRate.Text = rows.Cells["Rate"].Value.ToString();
                        cboAvail1.Text = rows.Cells["Avail"].Value.ToString();
                        txtHours.Text = rows.Cells["NoOfHours"].Value.ToString();
                    }
                    else if(tabSelected == "Promos")
                    {
                        promoCode = rows.Cells["PromoCode"].Value.ToString();
                        txtPromoCode.Text = rows.Cells["PromoCode"].Value.ToString();
                        txtPromo.Text = rows.Cells["PromoName"].Value.ToString();
                        txtDiscount.Text = rows.Cells["Discount"].Value.ToString();
                        cboAvail2.Text = rows.Cells["Avail"].Value.ToString();

                        //the datetime ples
                        dtStart = DateTime.Parse(rows.Cells["DateStart"].Value.ToString());
                        dtEnd = DateTime.Parse(rows.Cells["DateEnd"].Value.ToString());

                        string strStart = dtStart.ToShortDateString();
                        string strEnd = dtEnd.ToShortDateString();

                        dateTimeStart.Value = DateTime.ParseExact(strStart, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dateTimeEnd.Value = DateTime.ParseExact(strEnd, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                if (tabSelected == "Packages")
                {
                    txtPackage.Text = "";
                    txtRate.Text = "";
                    cboAvail1.Text = "";
                    txtHours.Text = "";
                    
                    txtPackage.Enabled = false;
                    txtRate.Enabled = false;
                    cboAvail1.Enabled = false;
                    txtHours.Enabled = false;

                    btnCancelPackage.Enabled = false;
                    btnSavePackage.Enabled = false;
                }
                else if(tabSelected == "Promos")
                {
                    txtPromoCode.Text = "";
                    txtPromo.Text = "";
                    txtDiscount.Text = "";
                    cboAvail2.Text = "";
                    dateTimeStart.Text = "";
                    dateTimeEnd.Text = "";

                    txtPromoCode.Enabled = false;
                    txtPromo.Enabled = false;
                    txtDiscount.Enabled = false;
                    cboAvail2.Enabled = false;
                    dateTimeStart.Enabled = false;
                    dateTimeEnd.Enabled = false;

                    btnCancelPromo.Enabled = false;
                    btnSavePromo.Enabled = false;
                }
            }
        }

        private void tabControl1_SelectedIndexChange(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    tabSelected = "Packages";
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    FillControlsPackages();
                    break;
                case 1:
                    tabSelected = "Promos";
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    FillControlsPromos();
                    break;
                case 2:
                    tabSelected = "Reports";
                    btnEdit.Visible = false;
                    btnAdd.Visible = false;
                    FillControlsReports();
                    break;
            }
        }

        private void btnSortCust_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string commandString;

            if (cboCustType1.Text == "All")
                FillControlsPackages();
            else
            {
                commandString = "SELECT * FROM tblPackage WHERE Avail = '" + cboCustType1.Text + "'";

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

                dataAdapter.Fill(ds, "dtPackages");
                dataTable = ds.Tables["dtPackages"];

                totalRec = dataTable.Rows.Count;

                dataGridView.DataSource = dataTable;

                this.dataGridView.Columns[0].Visible = false;
            }
        }
        
        private void btnSortPromo_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string commandString;

            if (cboCustType2.Text != "All" && cboGender.Text != "Both")
            {
                commandString = "SELECT * FROM tblPromo WHERE Avail LIKE '%" + cboCustType2.Text + "%' AND Valid = 'VALID'";

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

                dataAdapter.Fill(ds, "dtPromos");
                dataTable = ds.Tables["dtPromos"];

                totalRec = dataTable.Rows.Count;

                dataGridView.DataSource = dataTable;

                this.dataGridView.Columns[6].Visible = false;
            }
            else if (cboCustType2.Text != "" && cboGender.Text != "")
            {
                commandString = "SELECT * FROM tblPromo WHERE Avail LIKE '" + cboCustType2.Text + "," + cboGender.Text + "' AND Valid = 'VALID'";

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

                dataAdapter.Fill(ds, "dtPromos");
                dataTable = ds.Tables["dtPromos"];

                totalRec = dataTable.Rows.Count;

                dataGridView.DataSource = dataTable;

                this.dataGridView.Columns[6].Visible = false;
            }
            else if(cboCustType2.Text == "All")
            {
                FillControlsPromos();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tabSelected == "Packages")
            {
                if (txtPackage.Text == "" || txtPackage.Text == "" || cboAvail1.Text == "" || txtHours.Text == "")
                    MessageBox.Show("Select a Package to Edit", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    btnSavePackage.Enabled = true;
                    btnCancelPackage.Enabled = true;

                    txtPackage.Enabled = true;
                    txtRate.Enabled = true;
                    cboAvail1.Enabled = true;
                    txtHours.Enabled = true;
                }
            }
            else if(tabSelected == "Promos")
            {
                if (txtPromoCode.Text == "" || txtPromo.Text == "" || txtDiscount.Text == "" || cboAvail2.Text == "" || cboGender.Text == "")
                    MessageBox.Show("Select a Promo to Edit", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    btnSavePromo.Enabled = true;
                    btnCancelPromo.Enabled = true;

                    txtPromoCode.Enabled = true;
                    txtPromo.Enabled = true;
                    txtDiscount.Enabled = true;
                    cboAvail2.Enabled = true;
                    dateTimeStart.Enabled = true;
                    dateTimeEnd.Enabled = true;
                }
            }
        }

        private void btnCancelPackage_Click(object sender, EventArgs e)
        {
            btnSavePackage.Enabled = false;
            btnCancelPackage.Enabled = false;

            txtPackage.Enabled = false;
            txtRate.Enabled = false;
            cboAvail1.Enabled = false;
            txtHours.Enabled = false;
        }

        private void btnCancelPromo_Click(object sender, EventArgs e)
        {
            btnSavePromo.Enabled = false;
            btnCancelPromo.Enabled = false;

            txtPromoCode.Enabled = false;
            txtPromo.Enabled = false;
            txtDiscount.Enabled = false;
            cboAvail2.Enabled = false;
            dateTimeStart.Enabled = false;
            dateTimeEnd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPackagePromo addPackagePromo = new AddPackagePromo();
            addPackagePromo.ShowDialog();
        }

        private void chkboxExpired_CheckedChanged(object sender, EventArgs e)
        {
            FillControlsPromos();
        }

        private void btnSavePromo_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string updateString = "UPDATE tblPromo SET PromoCode = '" + txtPromoCode.Text + "', PromoName = '" + txtPromo.Text + "', Avail = '" + cboAvail2.Text + "', DateStart = '" + dateTimeStart.Value.ToShortDateString() + "', DateEnd = '" + dateTimeEnd.Value.ToShortDateString() + "' WHERE PromoCode = '" + promoCode + "'";
            
            var confirmResult = MessageBox.Show("Are you sure you want to edit?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            conn.Open();
            if (confirmResult == DialogResult.Yes)
            {
                OleDbDataAdapter updateAdapter = new OleDbDataAdapter();
                updateAdapter.UpdateCommand = conn.CreateCommand();
                updateAdapter.UpdateCommand.CommandText = updateString;
                updateAdapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Promo Info Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnSavePromo.Enabled = false;
            btnCancelPromo.Enabled = false;

            txtPromoCode.Enabled = false;
            txtPromo.Enabled = false;
            txtDiscount.Enabled = false;
            cboAvail2.Enabled = false;
            dateTimeStart.Enabled = false;
            dateTimeEnd.Enabled = false;
        }

        private void btnGenerate1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string commandString = "SELECT * FROM tblOrder WHERE OrderDate LIKE '" + dateTimeDaily.Value.ToShortDateString() + "%' ORDER BY OrderID DESC";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtReports");
            dataTable = ds.Tables["dtReports"];

            totalRec = dataTable.Rows.Count;

            dataGridView.DataSource = dataTable;
            this.dataGridView.Columns[0].Visible = false;
        }

        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string commandString;

            if (updownMonth.Value == 0)
                commandString = "SELECT * FROM tblOrder WHERE OrderDate BETWEEN #01/01/" + updownYear.Value + "# AND #31/12/" + updownYear.Value + "# ORDER BY OrderDate DESC, OrderID ASC";
            else
            {
                if(updownMonth.Value < 10)
                    commandString = "SELECT * FROM tblOrder WHERE OrderDate LIKE '%/0" + updownMonth.Value.ToString() + "/" + updownYear.Value.ToString() + "' ORDER BY OrderID DESC";
                else
                    commandString = "SELECT * FROM tblOrder WHERE OrderDate LIKE '%/" + updownMonth.Value.ToString() + "/" + updownYear.Value.ToString() + "' ORDER BY OrderID DESC";
            }   
            
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString, conn);

            dataAdapter.Fill(ds, "dtReports");
            dataTable = ds.Tables["dtReports"];

            totalRec = dataTable.Rows.Count;

            dataGridView.DataSource = dataTable;
            this.dataGridView.Columns[0].Visible = false;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillControlsReports();
        }

        private void btnSavePackage_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string updateString = "UPDATE tblPackage SET PackageName = '" + txtPackage.Text + "', Rate = " + txtRate.Text + ", Avail = '" + cboAvail1.Text + "', NoOfHours = " + txtHours.Text + " WHERE PackageID = " + packageID;
            
            var confirmResult = MessageBox.Show("Are you sure you want to edit?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            conn.Open();
            if (confirmResult == DialogResult.Yes)
            {
                OleDbDataAdapter updateAdapter = new OleDbDataAdapter();
                updateAdapter.UpdateCommand = conn.CreateCommand();
                updateAdapter.UpdateCommand.CommandText = updateString;
                updateAdapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Package Info Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnSavePackage.Enabled = false;
            btnCancelPackage.Enabled = false;

            txtPackage.Enabled = false;
            txtRate.Enabled = false;
            cboAvail1.Enabled = false;
            txtHours.Enabled = false;
        }
    }
}
