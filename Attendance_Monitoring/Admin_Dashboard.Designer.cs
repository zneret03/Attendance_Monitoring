namespace Attendance_Monitoring
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.navigation = new System.Windows.Forms.Panel();
            this.dateNow = new System.Windows.Forms.DateTimePicker();
            this.close = new System.Windows.Forms.Label();
            this.btnEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.profile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnAllAttendance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelUser = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtDailyAttendance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtAllUsers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtTotalAttendance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.Panel();
            this.navigation.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.Controls.Add(this.dateNow);
            this.navigation.Controls.Add(this.close);
            this.navigation.Location = new System.Drawing.Point(-1, 0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(1180, 37);
            this.navigation.TabIndex = 0;
            this.navigation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigation_MouseDown);
            this.navigation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navigation_MouseMove);
            this.navigation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navigation_MouseUp);
            // 
            // dateNow
            // 
            this.dateNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNow.Location = new System.Drawing.Point(987, 3);
            this.dateNow.Name = "dateNow";
            this.dateNow.Size = new System.Drawing.Size(141, 29);
            this.dateNow.TabIndex = 14;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1153, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 30);
            this.close.TabIndex = 2;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.BorderRadius = 0;
            this.btnEmployee.ButtonText = "      Employee";
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Iconimage")));
            this.btnEmployee.Iconimage_right = null;
            this.btnEmployee.Iconimage_right_Selected = null;
            this.btnEmployee.Iconimage_Selected = null;
            this.btnEmployee.IconMarginLeft = 15;
            this.btnEmployee.IconMarginRight = 0;
            this.btnEmployee.IconRightVisible = true;
            this.btnEmployee.IconRightZoom = 0D;
            this.btnEmployee.IconVisible = true;
            this.btnEmployee.IconZoom = 43D;
            this.btnEmployee.IsTab = false;
            this.btnEmployee.Location = new System.Drawing.Point(0, 268);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployee.selected = false;
            this.btnEmployee.Size = new System.Drawing.Size(216, 32);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "      Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Textcolor = System.Drawing.Color.White;
            this.btnEmployee.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
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
            // profile
            // 
            this.profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile.BackgroundImage")));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile.Location = new System.Drawing.Point(50, 40);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(116, 112);
            this.profile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "System Adminitrator";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      User Maintenance";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 15;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 43D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 307);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(214, 32);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "      User Maintenance";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.sidebar.Controls.Add(this.btnAllAttendance);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.bunifuFlatButton2);
            this.sidebar.Controls.Add(this.labelUser);
            this.sidebar.Controls.Add(this.bunifuFlatButton1);
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Controls.Add(this.profile);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.Controls.Add(this.btnEmployee);
            this.sidebar.Location = new System.Drawing.Point(-1, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(216, 599);
            this.sidebar.TabIndex = 1;
            // 
            // btnAllAttendance
            // 
            this.btnAllAttendance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnAllAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnAllAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllAttendance.BorderRadius = 0;
            this.btnAllAttendance.ButtonText = "      All Attendance";
            this.btnAllAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllAttendance.DisabledColor = System.Drawing.Color.Gray;
            this.btnAllAttendance.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAllAttendance.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAllAttendance.Iconimage")));
            this.btnAllAttendance.Iconimage_right = null;
            this.btnAllAttendance.Iconimage_right_Selected = null;
            this.btnAllAttendance.Iconimage_Selected = null;
            this.btnAllAttendance.IconMarginLeft = 15;
            this.btnAllAttendance.IconMarginRight = 0;
            this.btnAllAttendance.IconRightVisible = true;
            this.btnAllAttendance.IconRightZoom = 0D;
            this.btnAllAttendance.IconVisible = true;
            this.btnAllAttendance.IconZoom = 43D;
            this.btnAllAttendance.IsTab = false;
            this.btnAllAttendance.Location = new System.Drawing.Point(0, 380);
            this.btnAllAttendance.Margin = new System.Windows.Forms.Padding(5);
            this.btnAllAttendance.Name = "btnAllAttendance";
            this.btnAllAttendance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnAllAttendance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnAllAttendance.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAllAttendance.selected = false;
            this.btnAllAttendance.Size = new System.Drawing.Size(214, 32);
            this.btnAllAttendance.TabIndex = 16;
            this.btnAllAttendance.Text = "      All Attendance";
            this.btnAllAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllAttendance.Textcolor = System.Drawing.Color.White;
            this.btnAllAttendance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllAttendance.Click += new System.EventHandler(this.btnAllAttendance_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(0, 565);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(216, 32);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "      Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "      Daily attendance";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 15;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 43D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 344);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(214, 32);
            this.bunifuFlatButton2.TabIndex = 14;
            this.bunifuFlatButton2.Text = "      Daily attendance";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // labelUser
            // 
            this.labelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.labelUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.labelUser.Location = new System.Drawing.Point(3, 164);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(210, 18);
            this.labelUser.TabIndex = 13;
            this.labelUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.txtDailyAttendance);
            this.bunifuGradientPanel4.Controls.Add(this.label5);
            this.bunifuGradientPanel4.Controls.Add(this.label6);
            this.bunifuGradientPanel4.Controls.Add(this.panel4);
            this.bunifuGradientPanel4.Controls.Add(this.label7);
            this.bunifuGradientPanel4.Controls.Add(this.panel3);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(163)))), ((int)(((byte)(174)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(163)))), ((int)(((byte)(174)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(256, 20);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(222, 119);
            this.bunifuGradientPanel4.TabIndex = 12;
            // 
            // txtDailyAttendance
            // 
            this.txtDailyAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.txtDailyAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDailyAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyAttendance.ForeColor = System.Drawing.Color.White;
            this.txtDailyAttendance.Location = new System.Drawing.Point(13, 83);
            this.txtDailyAttendance.Name = "txtDailyAttendance";
            this.txtDailyAttendance.Size = new System.Drawing.Size(197, 26);
            this.txtDailyAttendance.TabIndex = 15;
            this.txtDailyAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Attendance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(77, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "List of employee";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(14, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(39, 40);
            this.panel4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(75, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Today Attendance";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(66, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 66);
            this.panel3.TabIndex = 14;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.txtAllUsers);
            this.bunifuGradientPanel3.Controls.Add(this.label8);
            this.bunifuGradientPanel3.Controls.Add(this.panel6);
            this.bunifuGradientPanel3.Controls.Add(this.label9);
            this.bunifuGradientPanel3.Controls.Add(this.label10);
            this.bunifuGradientPanel3.Controls.Add(this.panel5);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(147)))), ((int)(((byte)(160)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(147)))), ((int)(((byte)(160)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(490, 20);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(222, 119);
            this.bunifuGradientPanel3.TabIndex = 13;
            // 
            // txtAllUsers
            // 
            this.txtAllUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(194)))));
            this.txtAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAllUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllUsers.ForeColor = System.Drawing.Color.White;
            this.txtAllUsers.Location = new System.Drawing.Point(15, 85);
            this.txtAllUsers.Name = "txtAllUsers";
            this.txtAllUsers.Size = new System.Drawing.Size(197, 26);
            this.txtAllUsers.TabIndex = 18;
            this.txtAllUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(84, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Users";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(16, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(39, 40);
            this.panel6.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(84, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "List of registered";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(83, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "All Users";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(73, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 66);
            this.panel5.TabIndex = 18;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.txtTotalAttendance);
            this.bunifuGradientPanel2.Controls.Add(this.label11);
            this.bunifuGradientPanel2.Controls.Add(this.label12);
            this.bunifuGradientPanel2.Controls.Add(this.panel8);
            this.bunifuGradientPanel2.Controls.Add(this.label13);
            this.bunifuGradientPanel2.Controls.Add(this.panel7);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(726, 20);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(222, 119);
            this.bunifuGradientPanel2.TabIndex = 11;
            // 
            // txtTotalAttendance
            // 
            this.txtTotalAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.txtTotalAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAttendance.ForeColor = System.Drawing.Color.White;
            this.txtTotalAttendance.Location = new System.Drawing.Point(15, 84);
            this.txtTotalAttendance.Name = "txtTotalAttendance";
            this.txtTotalAttendance.Size = new System.Drawing.Size(197, 26);
            this.txtTotalAttendance.TabIndex = 22;
            this.txtTotalAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(83, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(83, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "List of registered";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(22, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(39, 40);
            this.panel8.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(82, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total Atendance";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(75, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 66);
            this.panel7.TabIndex = 22;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtEmployee);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(20, 20);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(222, 119);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // txtEmployee
            // 
            this.txtEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(179)))), ((int)(((byte)(197)))));
            this.txtEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.ForeColor = System.Drawing.Color.White;
            this.txtEmployee.Location = new System.Drawing.Point(15, 82);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(197, 26);
            this.txtEmployee.TabIndex = 14;
            this.txtEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "List of registered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(70, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 66);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 40);
            this.panel1.TabIndex = 3;
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.bunifuGradientPanel1);
            this.dashboard.Controls.Add(this.bunifuGradientPanel4);
            this.dashboard.Controls.Add(this.bunifuGradientPanel2);
            this.dashboard.Controls.Add(this.bunifuGradientPanel3);
            this.dashboard.Location = new System.Drawing.Point(210, 34);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(969, 515);
            this.dashboard.TabIndex = 14;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 597);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigation;
        private System.Windows.Forms.Label close;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private System.Windows.Forms.Panel profile;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel sidebar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox labelUser;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public System.Windows.Forms.DateTimePicker dateNow;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnAllAttendance;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtDailyAttendance;
        private System.Windows.Forms.TextBox txtAllUsers;
        private System.Windows.Forms.TextBox txtTotalAttendance;
        private System.Windows.Forms.Panel dashboard;
    }
}