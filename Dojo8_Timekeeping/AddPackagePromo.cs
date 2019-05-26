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
    public partial class AddPackagePromo : Form
    {
        string strSelected;
        string promoAvail;
        
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Dojo8_db.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        public AddPackagePromo()
        {
            InitializeComponent();

            this.MaximumSize = new Size(213, 574);
        }

        private void AddPackagePromo_Load(object sender, EventArgs e)
        {
            cboCustType1.Items.Add("Student");
            cboCustType1.Items.Add("Regular");

            cboCustType2.Items.Add("Student");
            cboCustType2.Items.Add("Regular");
            cboCustType2.Items.Add("Both");

            cboGender.Items.Add("Both");
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            
            if (PackagePromoForm.tabSelected == "Packages")
                newPackage();
            else
                newPromo();
        }
        
        private void newPackage()
        {
            strSelected = "Packages";

            this.Text = "New Package";
            lblTitle.Text = "New Package";

            panelPromo.Visible = false;
            panelPackage.Visible = true;
        }

        private void newPromo()
        {
            strSelected = "Promos";

            this.Text = "New Promo";
            lblTitle.Text = "New Promo";

            panelPromo.Visible = true;
            panelPackage.Visible = false;
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            newPackage();
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            newPromo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (strSelected == "Packages")
            {
                if (txtPackage.Text == "" || txtRate.Text == "" || cboCustType1.Text == "" || txtHours.Text == "")
                    MessageBox.Show("Must fill in ALL fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string packageID;
                    
                    if (cboCustType1.Text == "Student")
                        packageID = "SP0" + Convert.ToString(countPackages());
                    else
                        packageID = "RP0" + Convert.ToString(countPackages());

                    OleDbDataAdapter addAdapter = new OleDbDataAdapter();

                    string addSql = "INSERT INTO tblPackage(PackageID, PackageName, Rate, Avail, NoOfHours) VALUES('" + packageID + "', '" + txtPackage.Text + "', " + Convert.ToDouble(txtRate.Text) + ", '" + cboCustType1.Text + "', " + Convert.ToInt32(txtHours.Text) + ")";

                    var confirmResult = MessageBox.Show("Confirm New Package?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        conn.Open();

                        addAdapter.InsertCommand = new OleDbCommand(addSql, conn);
                        addAdapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Package Added!");

                        conn.Close();

                        PackagePromoForm packagePromoForm = new PackagePromoForm();
                        packagePromoForm.Refresh();

                        this.Close();
                    }
                }
            }
            else
            {
                if (txtPromoCode.Text == "" || txtPromoName.Text == "" || txtDiscount.Text == "" || cboCustType2.Text == "" || cboGender.Text == "" || dateTimeStart.Text == "" || dateTimeEnd.Text == "")
                    MessageBox.Show("Must fill in ALL fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String dtStart = dateTimeStart.Value.ToShortDateString();
                    String dtEnd = dateTimeEnd.Value.ToShortDateString();

                    OleDbDataAdapter addAdapter = new OleDbDataAdapter();

                    if (cboCustType2.Text == "Both")
                        promoAvail = "Student, Regular";
                    else
                        promoAvail = cboCustType2.Text;

                    if (cboGender.Text == "Both")
                        promoAvail = promoAvail + ", Both";
                    else
                        promoAvail = promoAvail + ", " + cboGender.Text;
                    
                    string addSql = "INSERT INTO tblPromo(PromoCode, PromoName, DateStart, DateEnd, Discount, Avail) VALUES('" + txtPromoCode.Text + "', '" + txtPromoName.Text + "', '" + DateTime.ParseExact(dtStart, "dd/MM/yyyy", CultureInfo.InvariantCulture) + "', '" + DateTime.ParseExact(dtStart, "dd/MM/yyyy", CultureInfo.InvariantCulture) + "', " + Convert.ToDouble(txtDiscount.Text) + ", '" + promoAvail + "'";

                    var confirmResult = MessageBox.Show("Confirm New Promo?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    conn.Open();
                    if (confirmResult == DialogResult.Yes)
                    {
                        addAdapter.InsertCommand = new OleDbCommand(addSql, conn);
                        addAdapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Promo Added!");

                        conn.Close();

                        PackagePromoForm packagePromoForm = new PackagePromoForm();
                        packagePromoForm.Refresh();

                        this.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to Close? Unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
                this.Close();
        }

        private int countPackages()
        {
            string searchString;
            int totalNo;

            DataTable dataTable;
            DataSet ds = new DataSet();

            if(cboCustType1.Text == "Student")
                searchString = "SELECT * FROM tblPackage WHERE PackageID LIKE '%SP%'";
            else
                searchString = "SELECT * FROM tblPackage WHERE PackageID LIKE '%RP%'";

            OleDbDataAdapter searchAdapter = new OleDbDataAdapter(searchString, conn);

            searchAdapter.Fill(ds, "dtResult");
            dataTable = ds.Tables["dtResult"];

            totalNo = dataTable.Rows.Count;

            return totalNo + 1;
        }
    }
}
