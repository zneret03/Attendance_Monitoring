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

namespace Attendance_Monitoring
{
    public partial class EmployeeAttendance : Form
    {
        Controller.Employee employee = new Controller.Employee();
        MySqlDataReader reader;
        Employee_Dashboard employeeDash;
        public EmployeeAttendance(Employee_Dashboard emp)
        {
            InitializeComponent();
            employeeDash = emp;
        }

        public void attendance()
        {
            try
            {
                dailyAttendanceDataGrid.Rows.Clear();
                reader = employee.EmployeeAttendance();
                while (reader.Read())
                {
                    dailyAttendanceDataGrid.Rows.Add(
                        reader["attendance_id"].ToString(),
                        reader["username"].ToString(),
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

        public void loadDateAttendance()
        {
            try
            {
                dailyAttendanceDataGrid.Rows.Clear();
                using (MySqlDataReader reader = employee.loadEmployeeAttendance(FromDate.Value.ToString("yyyy/MM/dd"), ToDate.Value.ToString("yyyy/MM/dd"), employeeDash.labelUser.Text.ToLower()))
                {
                    while(reader.Read())
                    {
                        dailyAttendanceDataGrid.Rows.Add(
                            reader["attendance_id"].ToString(),
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

        private void EmployeeAttendance_Load(object sender, EventArgs e)
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
            attendance();
            loadDateAttendance();
            //attendanceCount.Text = employee.countAttendance(employeeDash.labelUser.Text.ToLower()).ToString();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            loadDateAttendance();
        }
    }
}
