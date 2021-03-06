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
using Microsoft.Reporting.WinForms;

namespace Attendance_Monitoring
{
    public partial class PrintAllAttendance : Form
    {
        int moveStart;
        int moveStartX;
        int moveStartY;
        Connection.ConnectionQuery query = new Connection.ConnectionQuery();
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
        public PrintAllAttendance()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        public void printAllAttendance()
        {
            try
            {
                ReportDataSource reportViewer;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                MySqlConnection connection = new MySqlConnection(query.connectionQuery());
                MySqlDataAdapter sda = new MySqlDataAdapter();
                DataSet1 data = new DataSet1();
                connection.Open();

                using (sda.SelectCommand = new MySqlCommand("SELECT username, time, status, date FROM attendance INNER JOIN users ON users.user_id = attendance.user_id", connection))
                {
                    sda.Fill(data.Tables["allAttendance"]);
                }

                connection.Close();

                reportViewer = new ReportDataSource("DataSet1", data.Tables["allAttendance"]);
                this.reportViewer1.LocalReport.DataSources.Add(reportViewer);
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintAllAttendance_Load(object sender, EventArgs e)
        {
            printAllAttendance();
            this.reportViewer1.RefreshReport();
        }
    }
}
