using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Attendance_Monitoring
{
    public partial class Employee_Dashboard : Form
    {
        int moveStart;
        int moveStartX;
        int moveStartY;

        Controller.Employee employee = new Controller.Employee();
        EmployeeAttendance attendance;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );
        public Employee_Dashboard(String username)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            labelUser.Text = username.ToUpper();
        }

        public void LoggedUserId()
        {
            MySqlDataReader reader = employee.loggedUserID(labelUser.Text.ToString());
            if (reader.Read())
            {
                labelID.Text = reader["user_id"].ToString();
            }
        }

        public void displayAttendance()
        {
            try
            {
                dailyAttendanceDataGrid.Rows.Clear();
                MySqlDataReader reader = employee.dailyAttendance(labelUser.Text);
                while (reader.Read())
                {
                    dailyAttendanceDataGrid.Rows.Add(
                        reader["time"].ToString(),
                        reader["status"].ToString(),
                        reader["date"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Employee_Dashboard_Load(object sender, EventArgs e)
        {
            dailyAttendanceDataGrid.BorderStyle = BorderStyle.None;
            dailyAttendanceDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dailyAttendanceDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dailyAttendanceDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dailyAttendanceDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dailyAttendanceDataGrid.EnableHeadersVisualStyles = false;
            dailyAttendanceDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dailyAttendanceDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 102, 120);
            dailyAttendanceDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dailyAttendanceDataGrid.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 7, 0, 7);

            dateNow.Hide();
            labelID.Hide();
            LoggedUserId();
            displayAttendance();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveStart == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveStartX, MousePosition.Y - moveStartY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moveStart = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moveStart = 1;
            moveStartX = e.X;
            moveStartY = e.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            attendance = new EmployeeAttendance(this);
            attendance.TopLevel = false;
            EmployeePanel.Controls.Add(attendance);
            attendance.BringToFront();
            attendance.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            attendance = new EmployeeAttendance(this);
            EmployeePanel.Controls.Remove(attendance);
        }

        private void btnTimeIn_Click_1(object sender, EventArgs e)
        {
            String status = "Time-in";
            employee.addAttendanceTimeIn(labelID.Text, Time.Text, status, dateNow.Value.ToString("yyyy/MM/dd"), labelUser.Text);
            displayAttendance();
        }

        private void btnTimeOut_Click_1(object sender, EventArgs e)
        {
            String status = "Time-out";
            employee.addAttendanceTimeOut(labelID.Text, Time.Text, status, dateNow.Value.ToString("yyyy/MM/dd"), labelUser.Text);
            displayAttendance();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
