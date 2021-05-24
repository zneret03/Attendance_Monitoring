namespace Attendance_Monitoring
{
    partial class Employee_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.Panel();
            this.btnAttendance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.dateNow = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.dailyAttendanceDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimeOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimeIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyAttendanceDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.labelUser);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Controls.Add(this.profile);
            this.sidebar.Controls.Add(this.btnAttendance);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(216, 488);
            this.sidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "      Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 15;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 43D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 455);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(216, 32);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "      Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelUser
            // 
            this.labelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.labelUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.labelUser.Location = new System.Drawing.Point(0, 164);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(216, 18);
            this.labelUser.TabIndex = 12;
            this.labelUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(216, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 445);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "System Employee";
            // 
            // profile
            // 
            this.profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile.BackgroundImage")));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile.Location = new System.Drawing.Point(46, 40);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(116, 112);
            this.profile.TabIndex = 2;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttendance.BorderRadius = 0;
            this.btnAttendance.ButtonText = "      Attendance";
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.DisabledColor = System.Drawing.Color.Gray;
            this.btnAttendance.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAttendance.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Iconimage")));
            this.btnAttendance.Iconimage_right = null;
            this.btnAttendance.Iconimage_right_Selected = null;
            this.btnAttendance.Iconimage_Selected = null;
            this.btnAttendance.IconMarginLeft = 15;
            this.btnAttendance.IconMarginRight = 0;
            this.btnAttendance.IconRightVisible = true;
            this.btnAttendance.IconRightZoom = 0D;
            this.btnAttendance.IconVisible = true;
            this.btnAttendance.IconZoom = 43D;
            this.btnAttendance.IsTab = false;
            this.btnAttendance.Location = new System.Drawing.Point(1, 269);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(5);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnAttendance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnAttendance.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAttendance.selected = false;
            this.btnAttendance.Size = new System.Drawing.Size(214, 32);
            this.btnAttendance.TabIndex = 2;
            this.btnAttendance.Text = "      Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Textcolor = System.Drawing.Color.White;
            this.btnAttendance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "      Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 15;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 43D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 231);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(216, 32);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "      Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.dateNow);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 37);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(231, 14);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "label2";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(965, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 30);
            this.close.TabIndex = 4;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dateNow
            // 
            this.dateNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNow.Location = new System.Drawing.Point(818, 3);
            this.dateNow.Name = "dateNow";
            this.dateNow.Size = new System.Drawing.Size(141, 29);
            this.dateNow.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.Controls.Add(this.dailyAttendanceDataGrid);
            this.EmployeePanel.Controls.Add(this.btnTimeOut);
            this.EmployeePanel.Controls.Add(this.btnTimeIn);
            this.EmployeePanel.Controls.Add(this.panel3);
            this.EmployeePanel.Location = new System.Drawing.Point(217, 37);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(774, 451);
            this.EmployeePanel.TabIndex = 8;
            // 
            // dailyAttendanceDataGrid
            // 
            this.dailyAttendanceDataGrid.AllowUserToAddRows = false;
            this.dailyAttendanceDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dailyAttendanceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dailyAttendanceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyAttendanceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dailyAttendanceDataGrid.Location = new System.Drawing.Point(136, 170);
            this.dailyAttendanceDataGrid.Name = "dailyAttendanceDataGrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dailyAttendanceDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dailyAttendanceDataGrid.Size = new System.Drawing.Size(503, 228);
            this.dailyAttendanceDataGrid.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TIME";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "STATUS";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DATE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnTimeOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimeOut.BorderRadius = 0;
            this.btnTimeOut.ButtonText = "TIME OUT";
            this.btnTimeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimeOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimeOut.Iconimage = null;
            this.btnTimeOut.Iconimage_right = null;
            this.btnTimeOut.Iconimage_right_Selected = null;
            this.btnTimeOut.Iconimage_Selected = null;
            this.btnTimeOut.IconMarginLeft = 0;
            this.btnTimeOut.IconMarginRight = 0;
            this.btnTimeOut.IconRightVisible = true;
            this.btnTimeOut.IconRightZoom = 0D;
            this.btnTimeOut.IconVisible = true;
            this.btnTimeOut.IconZoom = 90D;
            this.btnTimeOut.IsTab = false;
            this.btnTimeOut.Location = new System.Drawing.Point(387, 79);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnTimeOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnTimeOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimeOut.selected = false;
            this.btnTimeOut.Size = new System.Drawing.Size(252, 82);
            this.btnTimeOut.TabIndex = 10;
            this.btnTimeOut.Text = "TIME OUT";
            this.btnTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeOut.Textcolor = System.Drawing.Color.White;
            this.btnTimeOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click_1);
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnTimeIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimeIn.BorderRadius = 0;
            this.btnTimeIn.ButtonText = "TIME IN";
            this.btnTimeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimeIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimeIn.Iconimage = null;
            this.btnTimeIn.Iconimage_right = null;
            this.btnTimeIn.Iconimage_right_Selected = null;
            this.btnTimeIn.Iconimage_Selected = null;
            this.btnTimeIn.IconMarginLeft = 0;
            this.btnTimeIn.IconMarginRight = 0;
            this.btnTimeIn.IconRightVisible = true;
            this.btnTimeIn.IconRightZoom = 0D;
            this.btnTimeIn.IconVisible = true;
            this.btnTimeIn.IconZoom = 90D;
            this.btnTimeIn.IsTab = false;
            this.btnTimeIn.Location = new System.Drawing.Point(136, 79);
            this.btnTimeIn.Margin = new System.Windows.Forms.Padding(6);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnTimeIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnTimeIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimeIn.selected = false;
            this.btnTimeIn.Size = new System.Drawing.Size(252, 82);
            this.btnTimeIn.TabIndex = 9;
            this.btnTimeIn.Text = "TIME IN";
            this.btnTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeIn.Textcolor = System.Drawing.Color.White;
            this.btnTimeIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Date);
            this.panel3.Controls.Add(this.Time);
            this.panel3.Location = new System.Drawing.Point(136, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 53);
            this.panel3.TabIndex = 8;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(57, 10);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(57, 30);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(332, 10);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(58, 30);
            this.Time.TabIndex = 0;
            this.Time.Text = "Time";
            // 
            // Employee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 488);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmployeePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Employee_Dashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EmployeePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dailyAttendanceDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel profile;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAttendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.DataGridView dailyAttendanceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimeOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimeIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        public System.Windows.Forms.DateTimePicker dateNow;
        public System.Windows.Forms.TextBox labelUser;
    }
}