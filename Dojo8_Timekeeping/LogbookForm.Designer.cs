namespace Dojo8_Timekeeping
{
    partial class LogbookForm
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
            this.dataGridRecords = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateDaily = new System.Windows.Forms.Button();
            this.dateTimeDaily = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updownMonth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateMY = new System.Windows.Forms.Button();
            this.updownYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoursSpent = new System.Windows.Forms.Label();
            this.lblDateExpire = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRecords
            // 
            this.dataGridRecords.AllowUserToAddRows = false;
            this.dataGridRecords.AllowUserToDeleteRows = false;
            this.dataGridRecords.AllowUserToOrderColumns = true;
            this.dataGridRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecords.Location = new System.Drawing.Point(181, 41);
            this.dataGridRecords.MultiSelect = false;
            this.dataGridRecords.Name = "dataGridRecords";
            this.dataGridRecords.ReadOnly = true;
            this.dataGridRecords.RowHeadersVisible = false;
            this.dataGridRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRecords.Size = new System.Drawing.Size(423, 278);
            this.dataGridRecords.TabIndex = 0;
            this.dataGridRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecords_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 58);
            this.label3.TabIndex = 11;
            this.label3.Text = "Logbook";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnGenerateDaily);
            this.groupBox1.Controls.Add(this.dateTimeDaily);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily";
            // 
            // btnGenerateDaily
            // 
            this.btnGenerateDaily.BackColor = System.Drawing.Color.Black;
            this.btnGenerateDaily.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateDaily.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDaily.Location = new System.Drawing.Point(73, 64);
            this.btnGenerateDaily.Name = "btnGenerateDaily";
            this.btnGenerateDaily.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateDaily.TabIndex = 3;
            this.btnGenerateDaily.Text = "Generate";
            this.btnGenerateDaily.UseVisualStyleBackColor = false;
            this.btnGenerateDaily.Click += new System.EventHandler(this.btnGenerateDaily_Click);
            // 
            // dateTimeDaily
            // 
            this.dateTimeDaily.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDaily.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDaily.Location = new System.Drawing.Point(10, 28);
            this.dateTimeDaily.Name = "dateTimeDaily";
            this.dateTimeDaily.Size = new System.Drawing.Size(138, 21);
            this.dateTimeDaily.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.updownMonth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnGenerateMY);
            this.groupBox2.Controls.Add(this.updownYear);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 153);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly / Yearly";
            // 
            // updownMonth
            // 
            this.updownMonth.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownMonth.Location = new System.Drawing.Point(45, 35);
            this.updownMonth.Name = "updownMonth";
            this.updownMonth.Size = new System.Drawing.Size(103, 21);
            this.updownMonth.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "MM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "YYYY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGenerateMY
            // 
            this.btnGenerateMY.BackColor = System.Drawing.Color.Crimson;
            this.btnGenerateMY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateMY.Location = new System.Drawing.Point(73, 113);
            this.btnGenerateMY.Name = "btnGenerateMY";
            this.btnGenerateMY.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateMY.TabIndex = 2;
            this.btnGenerateMY.Text = "Generate";
            this.btnGenerateMY.UseVisualStyleBackColor = false;
            this.btnGenerateMY.Click += new System.EventHandler(this.btnGenerateMY_Click);
            // 
            // updownYear
            // 
            this.updownYear.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownYear.Location = new System.Drawing.Point(45, 64);
            this.updownYear.Name = "updownYear";
            this.updownYear.Size = new System.Drawing.Size(103, 21);
            this.updownYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(178, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hours Spent";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHoursSpent
            // 
            this.lblHoursSpent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoursSpent.AutoSize = true;
            this.lblHoursSpent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursSpent.ForeColor = System.Drawing.Color.White;
            this.lblHoursSpent.Location = new System.Drawing.Point(256, 322);
            this.lblHoursSpent.Name = "lblHoursSpent";
            this.lblHoursSpent.Size = new System.Drawing.Size(35, 16);
            this.lblHoursSpent.TabIndex = 16;
            this.lblHoursSpent.Text = "00.00";
            this.lblHoursSpent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateExpire
            // 
            this.lblDateExpire.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateExpire.AutoSize = true;
            this.lblDateExpire.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExpire.ForeColor = System.Drawing.Color.White;
            this.lblDateExpire.Location = new System.Drawing.Point(538, 322);
            this.lblDateExpire.Name = "lblDateExpire";
            this.lblDateExpire.Size = new System.Drawing.Size(66, 16);
            this.lblDateExpire.TabIndex = 20;
            this.lblDateExpire.Text = "01/01/2016";
            this.lblDateExpire.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(464, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Date Expire";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnToday
            // 
            this.btnToday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToday.BackColor = System.Drawing.Color.White;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToday.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.Crimson;
            this.btnToday.Location = new System.Drawing.Point(525, 12);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(79, 23);
            this.btnToday.TabIndex = 4;
            this.btnToday.Text = "Show Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAll.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Crimson;
            this.btnAll.Location = new System.Drawing.Point(440, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(79, 23);
            this.btnAll.TabIndex = 21;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // LogbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(616, 350);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.lblDateExpire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHoursSpent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridRecords);
            this.Name = "LogbookForm";
            this.Text = "Logbook";
            this.Load += new System.EventHandler(this.LogbookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeDaily;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerateMY;
        private System.Windows.Forms.NumericUpDown updownYear;
        private System.Windows.Forms.Button btnGenerateDaily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHoursSpent;
        private System.Windows.Forms.Label lblDateExpire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updownMonth;
        private System.Windows.Forms.Label label4;
    }
}