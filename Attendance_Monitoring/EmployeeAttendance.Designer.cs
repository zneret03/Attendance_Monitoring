namespace Attendance_Monitoring
{
    partial class EmployeeAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dailyAttendanceDataGrid = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dailyAttendanceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyAttendanceDataGrid
            // 
            this.dailyAttendanceDataGrid.AllowUserToAddRows = false;
            this.dailyAttendanceDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dailyAttendanceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dailyAttendanceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyAttendanceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dailyAttendanceDataGrid.Location = new System.Drawing.Point(12, 60);
            this.dailyAttendanceDataGrid.Name = "dailyAttendanceDataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dailyAttendanceDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dailyAttendanceDataGrid.Size = new System.Drawing.Size(734, 340);
            this.dailyAttendanceDataGrid.TabIndex = 8;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "#";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "USERNAME";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "From :";
            // 
            // FromDate
            // 
            this.FromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.Location = new System.Drawing.Point(277, 19);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(141, 29);
            this.FromDate.TabIndex = 11;
            // 
            // ToDate
            // 
            this.ToDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.Location = new System.Drawing.Point(472, 20);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(141, 29);
            this.ToDate.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "To :";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEmployee.BorderRadius = 3;
            this.btnAddEmployee.ButtonText = "Load";
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Iconimage = null;
            this.btnAddEmployee.Iconimage_right = null;
            this.btnAddEmployee.Iconimage_right_Selected = null;
            this.btnAddEmployee.Iconimage_Selected = null;
            this.btnAddEmployee.IconMarginLeft = 10;
            this.btnAddEmployee.IconMarginRight = 0;
            this.btnAddEmployee.IconRightVisible = true;
            this.btnAddEmployee.IconRightZoom = 0D;
            this.btnAddEmployee.IconVisible = true;
            this.btnAddEmployee.IconZoom = 40D;
            this.btnAddEmployee.IsTab = false;
            this.btnAddEmployee.Location = new System.Drawing.Point(633, 19);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.btnAddEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnAddEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddEmployee.selected = false;
            this.btnAddEmployee.Size = new System.Drawing.Size(103, 32);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Load";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddEmployee.Textcolor = System.Drawing.Color.White;
            this.btnAddEmployee.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // EmployeeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 412);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dailyAttendanceDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeAttendance";
            this.Text = "EmployeeAttendance";
            this.Load += new System.EventHandler(this.EmployeeAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyAttendanceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dailyAttendanceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddEmployee;
    }
}