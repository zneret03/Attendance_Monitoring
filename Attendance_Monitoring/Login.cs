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
    public partial class Login : Form
    {
        int moveStart;
        int moveStartX;
        int moveStartY;
        Controller.UserController user = new Controller.UserController();

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
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Login_Load(object sender, EventArgs e)
        {

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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveStart == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveStartX, MousePosition.Y - moveStartY);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String[] empty = new String[]{
                txtUsername.Text.ToString(),
                txtPassword.Text.ToString()
            };

            foreach (String emp in empty)
            {
                if (String.IsNullOrEmpty(emp))
                {
                    MessageBox.Show("Please Fill the Empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    user.userCred(txtUsername.Text, txtPassword.Text, this);
                    break;
                }
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void showPassword_OnChange(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                txtPassword.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
