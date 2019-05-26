namespace Dojo8_Timekeeping
{
    partial class PackagePromoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboAvail1 = new System.Windows.Forms.ComboBox();
            this.btnCancelPackage = new System.Windows.Forms.Button();
            this.btnSavePackage = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSortCust = new System.Windows.Forms.Button();
            this.cboCustType1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPromos = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboAvail2 = new System.Windows.Forms.ComboBox();
            this.btnCancelPromo = new System.Windows.Forms.Button();
            this.btnSavePromo = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.txtPromoCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkboxExpired = new System.Windows.Forms.CheckBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSortPromo = new System.Windows.Forms.Button();
            this.cboCustType2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimeDaily = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.updownYear = new System.Windows.Forms.NumericUpDown();
            this.updownMonth = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPackages.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPromos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "PACKAGES / PROMOS";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.Crimson;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(578, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(657, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.splitContainer1.Location = new System.Drawing.Point(12, 84);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(720, 364);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPackages);
            this.tabControl1.Controls.Add(this.tabPromos);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 364);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChange);
            // 
            // tabPackages
            // 
            this.tabPackages.BackColor = System.Drawing.Color.White;
            this.tabPackages.Controls.Add(this.button3);
            this.tabPackages.Controls.Add(this.groupBox2);
            this.tabPackages.Controls.Add(this.groupBox1);
            this.tabPackages.Location = new System.Drawing.Point(4, 25);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPackages.Size = new System.Drawing.Size(234, 335);
            this.tabPackages.TabIndex = 0;
            this.tabPackages.Text = "Packages";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(6, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Purchase Hours";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboAvail1);
            this.groupBox2.Controls.Add(this.btnCancelPackage);
            this.groupBox2.Controls.Add(this.btnSavePackage);
            this.groupBox2.Controls.Add(this.txtHours);
            this.groupBox2.Controls.Add(this.txtRate);
            this.groupBox2.Controls.Add(this.txtPackage);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 183);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Package Info";
            // 
            // cboAvail1
            // 
            this.cboAvail1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAvail1.FormattingEnabled = true;
            this.cboAvail1.Location = new System.Drawing.Point(84, 80);
            this.cboAvail1.Name = "cboAvail1";
            this.cboAvail1.Size = new System.Drawing.Size(130, 24);
            this.cboAvail1.TabIndex = 19;
            // 
            // btnCancelPackage
            // 
            this.btnCancelPackage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelPackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelPackage.ForeColor = System.Drawing.Color.Black;
            this.btnCancelPackage.Location = new System.Drawing.Point(9, 144);
            this.btnCancelPackage.Name = "btnCancelPackage";
            this.btnCancelPackage.Size = new System.Drawing.Size(76, 23);
            this.btnCancelPackage.TabIndex = 18;
            this.btnCancelPackage.Text = "Cancel";
            this.btnCancelPackage.UseVisualStyleBackColor = false;
            this.btnCancelPackage.Click += new System.EventHandler(this.btnCancelPackage_Click);
            // 
            // btnSavePackage
            // 
            this.btnSavePackage.BackColor = System.Drawing.Color.Crimson;
            this.btnSavePackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePackage.ForeColor = System.Drawing.Color.White;
            this.btnSavePackage.Location = new System.Drawing.Point(91, 144);
            this.btnSavePackage.Name = "btnSavePackage";
            this.btnSavePackage.Size = new System.Drawing.Size(123, 23);
            this.btnSavePackage.TabIndex = 17;
            this.btnSavePackage.Text = "Save";
            this.btnSavePackage.UseVisualStyleBackColor = false;
            this.btnSavePackage.Click += new System.EventHandler(this.btnSavePackage_Click);
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(84, 106);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(130, 21);
            this.txtHours.TabIndex = 16;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(84, 54);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(130, 21);
            this.txtRate.TabIndex = 14;
            // 
            // txtPackage
            // 
            this.txtPackage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackage.Location = new System.Drawing.Point(84, 28);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(130, 21);
            this.txtPackage.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. of Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Avail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Package:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSortCust);
            this.groupBox1.Controls.Add(this.cboCustType1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // btnSortCust
            // 
            this.btnSortCust.Location = new System.Drawing.Point(139, 59);
            this.btnSortCust.Name = "btnSortCust";
            this.btnSortCust.Size = new System.Drawing.Size(75, 23);
            this.btnSortCust.TabIndex = 2;
            this.btnSortCust.Text = "Sort";
            this.btnSortCust.UseVisualStyleBackColor = true;
            this.btnSortCust.Click += new System.EventHandler(this.btnSortCust_Click);
            // 
            // cboCustType1
            // 
            this.cboCustType1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustType1.FormattingEnabled = true;
            this.cboCustType1.Location = new System.Drawing.Point(93, 32);
            this.cboCustType1.Name = "cboCustType1";
            this.cboCustType1.Size = new System.Drawing.Size(121, 24);
            this.cboCustType1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Customer Type:";
            // 
            // tabPromos
            // 
            this.tabPromos.Controls.Add(this.groupBox3);
            this.tabPromos.Controls.Add(this.groupBox4);
            this.tabPromos.Location = new System.Drawing.Point(4, 25);
            this.tabPromos.Name = "tabPromos";
            this.tabPromos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPromos.Size = new System.Drawing.Size(234, 335);
            this.tabPromos.TabIndex = 1;
            this.tabPromos.Text = "Promos";
            this.tabPromos.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimeEnd);
            this.groupBox3.Controls.Add(this.dateTimeStart);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cboAvail2);
            this.groupBox3.Controls.Add(this.btnCancelPromo);
            this.groupBox3.Controls.Add(this.btnSavePromo);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.txtPromo);
            this.groupBox3.Controls.Add(this.txtPromoCode);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(6, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 215);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Promo Info";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEnd.Location = new System.Drawing.Point(82, 152);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(132, 21);
            this.dateTimeEnd.TabIndex = 23;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(82, 126);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(132, 21);
            this.dateTimeStart.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Date End:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Date Start:";
            // 
            // cboAvail2
            // 
            this.cboAvail2.FormattingEnabled = true;
            this.cboAvail2.Location = new System.Drawing.Point(82, 93);
            this.cboAvail2.Name = "cboAvail2";
            this.cboAvail2.Size = new System.Drawing.Size(132, 24);
            this.cboAvail2.TabIndex = 3;
            // 
            // btnCancelPromo
            // 
            this.btnCancelPromo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelPromo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelPromo.ForeColor = System.Drawing.Color.Black;
            this.btnCancelPromo.Location = new System.Drawing.Point(10, 186);
            this.btnCancelPromo.Name = "btnCancelPromo";
            this.btnCancelPromo.Size = new System.Drawing.Size(76, 23);
            this.btnCancelPromo.TabIndex = 18;
            this.btnCancelPromo.Text = "Cancel";
            this.btnCancelPromo.UseVisualStyleBackColor = false;
            this.btnCancelPromo.Click += new System.EventHandler(this.btnCancelPromo_Click);
            // 
            // btnSavePromo
            // 
            this.btnSavePromo.BackColor = System.Drawing.Color.Crimson;
            this.btnSavePromo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePromo.ForeColor = System.Drawing.Color.White;
            this.btnSavePromo.Location = new System.Drawing.Point(92, 186);
            this.btnSavePromo.Name = "btnSavePromo";
            this.btnSavePromo.Size = new System.Drawing.Size(123, 23);
            this.btnSavePromo.TabIndex = 17;
            this.btnSavePromo.Text = "Save";
            this.btnSavePromo.UseVisualStyleBackColor = false;
            this.btnSavePromo.Click += new System.EventHandler(this.btnSavePromo_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(82, 67);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(132, 21);
            this.txtDiscount.TabIndex = 15;
            // 
            // txtPromo
            // 
            this.txtPromo.Location = new System.Drawing.Point(82, 41);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(132, 21);
            this.txtPromo.TabIndex = 14;
            // 
            // txtPromoCode
            // 
            this.txtPromoCode.Location = new System.Drawing.Point(82, 15);
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.Size = new System.Drawing.Size(132, 21);
            this.txtPromoCode.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Avail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Discount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Promo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Promo Code:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkboxExpired);
            this.groupBox4.Controls.Add(this.cboGender);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnSortPromo);
            this.groupBox4.Controls.Add(this.cboCustType2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 111);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sort";
            // 
            // chkboxExpired
            // 
            this.chkboxExpired.AutoSize = true;
            this.chkboxExpired.Location = new System.Drawing.Point(10, 82);
            this.chkboxExpired.Name = "chkboxExpired";
            this.chkboxExpired.Size = new System.Drawing.Size(100, 20);
            this.chkboxExpired.TabIndex = 5;
            this.chkboxExpired.Text = "Show Expired";
            this.chkboxExpired.UseVisualStyleBackColor = true;
            this.chkboxExpired.CheckedChanged += new System.EventHandler(this.chkboxExpired_CheckedChanged);
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(94, 50);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(121, 24);
            this.cboGender.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Gender:";
            // 
            // btnSortPromo
            // 
            this.btnSortPromo.Location = new System.Drawing.Point(140, 79);
            this.btnSortPromo.Name = "btnSortPromo";
            this.btnSortPromo.Size = new System.Drawing.Size(75, 23);
            this.btnSortPromo.TabIndex = 2;
            this.btnSortPromo.Text = "Sort";
            this.btnSortPromo.UseVisualStyleBackColor = true;
            this.btnSortPromo.Click += new System.EventHandler(this.btnSortPromo_Click);
            // 
            // cboCustType2
            // 
            this.cboCustType2.FormattingEnabled = true;
            this.cboCustType2.Location = new System.Drawing.Point(93, 19);
            this.cboCustType2.Name = "cboCustType2";
            this.cboCustType2.Size = new System.Drawing.Size(121, 24);
            this.cboCustType2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Customer Type:";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnShowAll);
            this.tabReports.Controls.Add(this.groupBox6);
            this.tabReports.Controls.Add(this.groupBox5);
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(234, 335);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Crimson;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(154, 12);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimeDaily);
            this.groupBox6.Controls.Add(this.btnGenerate1);
            this.groupBox6.Location = new System.Drawing.Point(3, 41);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(226, 100);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Daily";
            // 
            // dateTimeDaily
            // 
            this.dateTimeDaily.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDaily.Location = new System.Drawing.Point(37, 34);
            this.dateTimeDaily.Name = "dateTimeDaily";
            this.dateTimeDaily.Size = new System.Drawing.Size(152, 21);
            this.dateTimeDaily.TabIndex = 8;
            // 
            // btnGenerate1
            // 
            this.btnGenerate1.BackColor = System.Drawing.Color.Black;
            this.btnGenerate1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate1.ForeColor = System.Drawing.Color.White;
            this.btnGenerate1.Location = new System.Drawing.Point(114, 61);
            this.btnGenerate1.Name = "btnGenerate1";
            this.btnGenerate1.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate1.TabIndex = 7;
            this.btnGenerate1.Text = "Generate";
            this.btnGenerate1.UseVisualStyleBackColor = false;
            this.btnGenerate1.Click += new System.EventHandler(this.btnGenerate1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.updownYear);
            this.groupBox5.Controls.Add(this.updownMonth);
            this.groupBox5.Controls.Add(this.btnGenerate2);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(3, 147);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 122);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date";
            // 
            // updownYear
            // 
            this.updownYear.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownYear.Location = new System.Drawing.Point(86, 56);
            this.updownYear.Name = "updownYear";
            this.updownYear.Size = new System.Drawing.Size(103, 21);
            this.updownYear.TabIndex = 26;
            // 
            // updownMonth
            // 
            this.updownMonth.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownMonth.Location = new System.Drawing.Point(86, 29);
            this.updownMonth.Name = "updownMonth";
            this.updownMonth.Size = new System.Drawing.Size(103, 21);
            this.updownMonth.TabIndex = 25;
            // 
            // btnGenerate2
            // 
            this.btnGenerate2.BackColor = System.Drawing.Color.Black;
            this.btnGenerate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate2.ForeColor = System.Drawing.Color.White;
            this.btnGenerate2.Location = new System.Drawing.Point(114, 83);
            this.btnGenerate2.Name = "btnGenerate2";
            this.btnGenerate2.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate2.TabIndex = 6;
            this.btnGenerate2.Text = "Generate";
            this.btnGenerate2.UseVisualStyleBackColor = false;
            this.btnGenerate2.Click += new System.EventHandler(this.btnGenerate2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Month";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Year";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 22);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(472, 342);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // PackagePromoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(744, 460);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PackagePromoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packages & Promos";
            this.Load += new System.EventHandler(this.PackagePromoForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPackages.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPromos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.TabPage tabPromos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCustType1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSortCust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Button btnCancelPackage;
        private System.Windows.Forms.Button btnSavePackage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelPromo;
        private System.Windows.Forms.Button btnSavePromo;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.TextBox txtPromoCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSortPromo;
        private System.Windows.Forms.ComboBox cboCustType2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboAvail2;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboAvail1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.CheckBox chkboxExpired;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGenerate2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimeDaily;
        private System.Windows.Forms.Button btnGenerate1;
        private System.Windows.Forms.NumericUpDown updownMonth;
        private System.Windows.Forms.NumericUpDown updownYear;
        private System.Windows.Forms.Button btnShowAll;
    }
}