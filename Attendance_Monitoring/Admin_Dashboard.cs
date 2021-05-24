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

namespace Attendance_Monitoring
{
    public partial class Admin_Dashboard : Form
    {
        int moveStart;
        int moveStartX;
        int moveStartY;

        Controller.Employee emp = new Controller.Employee();
        Employee employee = new Employee();
        UserMaintenance userMaintenance = new UserMaintenance();
        AdminAllAttendance allAttendance = new AdminAllAttendance();
        DailyAttendance dailyAttendance;

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
        public Admin_Dashboard(String username)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            labelUser.Text = username.ToUpper();
        }

        private void navigation_MouseUp(object sender, MouseEventArgs e)
        {
            moveStart = 0;
        }

        private void navigation_MouseDown(object sender, MouseEventArgs e)
        {
            moveStart = 1;
            moveStartX = e.X;
            moveStartY = e.Y;
        }

        private void navigation_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveStart == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveStartX, MousePosition.Y - moveStartY);
            }
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            txtEmployee.Text = emp.countAllEmployee().ToString();
            txtAllUsers.Text = emp.countAllUsers().ToString();
            txtTotalAttendance.Text = emp.countAllAttendance().ToString();
            txtDailyAttendance.Text = emp.countDailyAttendance(dateNow.Value.ToString("yyyy/MM/dd")).ToString();
            dateNow.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard.Controls.Remove(employee);
            dashboard.Controls.Remove(userMaintenance);
           // dashboard.Controls.Remove(dailyAttendance);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            employee.TopLevel = false;
            dashboard.Controls.Add(employee);
            employee.BringToFront();
            employee.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            userMaintenance.readData();
            userMaintenance.TopLevel = false;
            dashboard.Controls.Add(userMaintenance);
            userMaintenance.BringToFront();
            userMaintenance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            dailyAttendance = new DailyAttendance(this);
            dailyAttendance.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnAllAttendance_Click(object sender, EventArgs e)
        {
            allAttendance.Show();
        }
    }
}
