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
    public partial class ModifyUserMaintenance : Form
    {
        int moveStart;
        int moveStartX;
        int moveStartY;

        Controller.Employee employee = new Controller.Employee();

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

        UserMaintenance maintenance;
        public ModifyUserMaintenance(UserMaintenance maintain)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            maintenance = maintain;
        }

        private void ModifyUserMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employee.updateUser(idValue.Text, txtUsername.Text.ToLower(), txtPassword.Text, comboUsertype.Text);
            maintenance.readData();
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moveStart = 0;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkDelete_OnChange(object sender, EventArgs e)
        {
            if (checkDelete.Checked == true)
            {
                employee.deleteUser(idValue.Text, this);
                maintenance.readData();
            }
        }
    }
}
