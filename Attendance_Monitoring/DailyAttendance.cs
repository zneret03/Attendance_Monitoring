using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Attendance_Monitoring
{
    public partial class DailyAttendance : Form
    {
        int moveStart;
        int moveStartX;
        int moveStartY;

        Controller.Employee employee = new Controller.Employee();
        Admin_Dashboard adminDashboard;
        MySqlDataReader reader;


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
        public DailyAttendance(Admin_Dashboard admin)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            adminDashboard = admin;
        }

        public void dailyAttendance()
        {
            try
            {
                dailyAttendanceDataGrid.Rows.Clear();
                using (reader = employee.fetchDailyAttendance(comboName.Text, adminDashboard.dateNow.Value.ToString("yyyy/MM/dd")))
                {
                    while (reader.Read())
                    {
                        dailyAttendanceDataGrid.Rows.Add(
                            reader["attendance_id"].ToString(),
                            reader["firstname"].ToString(),
                            reader["lastname"].ToString(),
                            reader["username"].ToString(),
                            reader["time"].ToString(),
                            reader["status"].ToString(),
                            reader["date"].ToString()

                        );
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DailyAttendance_Load(object sender, EventArgs e)
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
            employee.fetchEmployeeUsername(comboName);
        }

        private void FilterData_Click(object sender, EventArgs e)
        {
            dailyAttendance();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moveStart = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveStart == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveStartX, MousePosition.Y - moveStartY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moveStart = 1;
            moveStartX = e.X;
            moveStartY = e.Y;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDailyAttendance print = new PrintDailyAttendance(this, adminDashboard.dateNow.Value.ToString("yyyy/MM/dd"));
            print.Show();
        }
    }
}
