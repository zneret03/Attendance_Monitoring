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
    public partial class AddEmployee : Form
    {
        int moveStart;
        int moveStartX;
        int moveStartY;

        Controller.Employee employee = new Controller.Employee();
        Controller.ErrorHandlers errorHandler = new Controller.ErrorHandlers();
        Employee emp;

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
        public AddEmployee(Employee employe)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            emp = employe;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            idValue.Hide();
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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            bool isNumber = errorHandler.checkNum(txtAge.Text);
            TextBox[] text = new TextBox[]
            {
                txtFirstname,
                txtMiddlename,
                txtLastname,
                txtAddress,
                txtAge
            };

            if (isNumber != true)
            {
                MessageBox.Show("Age should be a number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (comboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                employee.addEmployee(text, comboGender.Text, this);
                comboGender.SelectedIndex = -1;
                emp.displayRecords();
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TextBox[] text = new TextBox[]
            {
                txtFirstname,
                txtMiddlename,
                txtLastname,
                txtAddress,
                txtAge
            };

            employee.updateEmployee(idValue.Text, text, comboGender.Text);

            comboGender.SelectedIndex = -1;
            emp.displayRecords();
        }

        private void checkDelete_OnChange(object sender, EventArgs e)
        {
            if (checkDelete.Checked == true)
            {
                employee.deleteEmployee(idValue.Text, this);
                emp.displayRecords();
            }
        }
    }
}
