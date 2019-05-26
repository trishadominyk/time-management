namespace Dojo8_Timekeeping
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTimeIn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageCust = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewPackagePromo = new System.Windows.Forms.Button();
            this.btnAddPackagePromo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogbook = new System.Windows.Forms.Button();
            this.dataGridLog = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddHours = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Adobe Gothic Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(316, 52);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(402, 80);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00 AM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome,";
            // 
            // lblStaffName
            // 
            this.lblStaffName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.White;
            this.lblStaffName.Location = new System.Drawing.Point(143, 169);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(40, 15);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "label2";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Autoradiographic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(791, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Dojo8_Timekeeping.Properties.Resources.logo2_nobg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(159, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 122);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimeIn.BackColor = System.Drawing.Color.Crimson;
            this.btnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeIn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeIn.ForeColor = System.Drawing.Color.White;
            this.btnTimeIn.Location = new System.Drawing.Point(583, 187);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Size = new System.Drawing.Size(193, 44);
            this.btnTimeIn.TabIndex = 28;
            this.btnTimeIn.Text = "Time In";
            this.btnTimeIn.UseVisualStyleBackColor = false;
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.btnManageCust);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAddCust);
            this.panel2.Location = new System.Drawing.Point(83, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 47);
            this.panel2.TabIndex = 17;
            // 
            // btnManageCust
            // 
            this.btnManageCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCust.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCust.ForeColor = System.Drawing.Color.Crimson;
            this.btnManageCust.Location = new System.Drawing.Point(358, 9);
            this.btnManageCust.Name = "btnManageCust";
            this.btnManageCust.Size = new System.Drawing.Size(105, 29);
            this.btnManageCust.TabIndex = 12;
            this.btnManageCust.Text = "Manage";
            this.btnManageCust.UseVisualStyleBackColor = false;
            this.btnManageCust.Click += new System.EventHandler(this.btnManageCust_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer";
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddCust.Location = new System.Drawing.Point(247, 9);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(105, 29);
            this.btnAddCust.TabIndex = 11;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnViewPackagePromo);
            this.panel3.Controls.Add(this.btnAddPackagePromo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(83, 514);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 47);
            this.panel3.TabIndex = 18;
            // 
            // btnViewPackagePromo
            // 
            this.btnViewPackagePromo.BackColor = System.Drawing.Color.Black;
            this.btnViewPackagePromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPackagePromo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPackagePromo.ForeColor = System.Drawing.Color.White;
            this.btnViewPackagePromo.Location = new System.Drawing.Point(358, 9);
            this.btnViewPackagePromo.Name = "btnViewPackagePromo";
            this.btnViewPackagePromo.Size = new System.Drawing.Size(105, 29);
            this.btnViewPackagePromo.TabIndex = 17;
            this.btnViewPackagePromo.Text = "View";
            this.btnViewPackagePromo.UseVisualStyleBackColor = false;
            this.btnViewPackagePromo.Click += new System.EventHandler(this.btnViewPackagePromo_Click);
            // 
            // btnAddPackagePromo
            // 
            this.btnAddPackagePromo.BackColor = System.Drawing.Color.Black;
            this.btnAddPackagePromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackagePromo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackagePromo.ForeColor = System.Drawing.Color.White;
            this.btnAddPackagePromo.Location = new System.Drawing.Point(247, 9);
            this.btnAddPackagePromo.Name = "btnAddPackagePromo";
            this.btnAddPackagePromo.Size = new System.Drawing.Size(105, 29);
            this.btnAddPackagePromo.TabIndex = 16;
            this.btnAddPackagePromo.Text = "Add";
            this.btnAddPackagePromo.UseVisualStyleBackColor = false;
            this.btnAddPackagePromo.Click += new System.EventHandler(this.btnAddPackagePromo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Packages / Promos";
            // 
            // btnLogbook
            // 
            this.btnLogbook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogbook.BackColor = System.Drawing.Color.Crimson;
            this.btnLogbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogbook.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogbook.ForeColor = System.Drawing.Color.White;
            this.btnLogbook.Location = new System.Drawing.Point(606, 504);
            this.btnLogbook.Name = "btnLogbook";
            this.btnLogbook.Size = new System.Drawing.Size(145, 57);
            this.btnLogbook.TabIndex = 28;
            this.btnLogbook.Text = "Logbook";
            this.btnLogbook.UseVisualStyleBackColor = false;
            this.btnLogbook.Click += new System.EventHandler(this.btnLogbook_Click);
            // 
            // dataGridLog
            // 
            this.dataGridLog.AllowUserToAddRows = false;
            this.dataGridLog.AllowUserToDeleteRows = false;
            this.dataGridLog.AllowUserToOrderColumns = true;
            this.dataGridLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridLog.Location = new System.Drawing.Point(83, 187);
            this.dataGridLog.MultiSelect = false;
            this.dataGridLog.Name = "dataGridLog";
            this.dataGridLog.ReadOnly = true;
            this.dataGridLog.RowHeadersVisible = false;
            this.dataGridLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridLog.Size = new System.Drawing.Size(494, 268);
            this.dataGridLog.TabIndex = 26;
            this.dataGridLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLog_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnAddHours);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblTimeRemain);
            this.groupBox1.Controls.Add(this.btnTimeOut);
            this.groupBox1.Location = new System.Drawing.Point(582, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 218);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // btnAddHours
            // 
            this.btnAddHours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddHours.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHours.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHours.Location = new System.Drawing.Point(24, 139);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(145, 29);
            this.btnAddHours.TabIndex = 33;
            this.btnAddHours.Text = "Add Hours";
            this.btnAddHours.UseVisualStyleBackColor = false;
            this.btnAddHours.Click += new System.EventHandler(this.btnAddHours_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(20, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 21);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "label2";
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeRemain.Font = new System.Drawing.Font("Adobe Gothic Std B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTimeRemain.ForeColor = System.Drawing.Color.White;
            this.lblTimeRemain.Location = new System.Drawing.Point(15, 41);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(158, 44);
            this.lblTimeRemain.TabIndex = 31;
            this.lblTimeRemain.Text = "00:00:00";
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeOut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeOut.Location = new System.Drawing.Point(24, 174);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(145, 29);
            this.btnTimeOut.TabIndex = 29;
            this.btnTimeOut.Text = "Time Out";
            this.btnTimeOut.UseVisualStyleBackColor = false;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(608, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "View Records";
            // 
            // btnStaff
            // 
            this.btnStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStaff.BackColor = System.Drawing.Color.Crimson;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaff.Font = new System.Drawing.Font("Autoradiographic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Location = new System.Drawing.Point(696, 3);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(89, 23);
            this.btnStaff.TabIndex = 30;
            this.btnStaff.Text = "Manage Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(865, 606);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridLog);
            this.Controls.Add(this.btnTimeIn);
            this.Controls.Add(this.btnLogbook);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dojo 8 TimeKeeping System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnViewPackagePromo;
        private System.Windows.Forms.Button btnAddPackagePromo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimeIn;
        private System.Windows.Forms.Button btnLogbook;
        private System.Windows.Forms.DataGridView dataGridLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStaff;
    }
}