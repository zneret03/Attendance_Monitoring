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
    public partial class Employee : Form
    {
        Controller.Employee employee = new Controller.Employee();
        public Employee()
        {
            InitializeComponent();
        }

        public void displayRecords()
        {
            try
            {
                dataGridView1.Rows.Clear();
                MySqlDataReader reader = employee.readData();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["user_id"].ToString(),
                        reader["firstname"].ToString(),
                        reader["middlename"].ToString(),
                        reader["lastname"].ToString(),
                        reader["address"].ToString(),
                        reader["age"].ToString(),
                        reader["gender"].ToString(),
                        reader["date_created"].ToString(),
                        reader["date_updated"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchEmployee()
        {
            try
            {
                dataGridView1.Rows.Clear();
                MySqlDataReader reader = employee.searchData(txtSearch.text.ToString());
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["user_id"].ToString(),
                        reader["firstname"].ToString(),
                        reader["middlename"].ToString(),
                        reader["lastname"].ToString(),
                        reader["address"].ToString(),
                        reader["age"].ToString(),
                        reader["gender"].ToString(),
                        reader["date_created"].ToString(),
                        reader["date_updated"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 102, 120);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 7, 0, 7);
            displayRecords();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(this);
            addEmployee.Show();
            addEmployee.checkDelete.Visible = false;
            addEmployee.label12.Hide();
            addEmployee.btnUpdate.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dataGridView1.Columns[e.ColumnIndex].Name;
            DataGridViewRow dt = this.dataGridView1.Rows[e.RowIndex];
            AddEmployee addEmployee = new AddEmployee(this);
            if (colName == "fetch")
            {
                addEmployee.idValue.Text = dt.Cells[0].Value.ToString();
                addEmployee.txtFirstname.Text = dt.Cells[1].Value.ToString();
                addEmployee.txtMiddlename.Text = dt.Cells[2].Value.ToString();
                addEmployee.txtLastname.Text = dt.Cells[3].Value.ToString();
                addEmployee.txtAddress.Text = dt.Cells[4].Value.ToString();
                addEmployee.txtAge.Text = dt.Cells[5].Value.ToString();
                addEmployee.comboGender.Text = dt.Cells[6].Value.ToString();

                addEmployee.btnAddEmployee.Enabled = false;
                addEmployee.btnUpdate.Enabled = true;
                addEmployee.Show();
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            searchEmployee();
        }
    }
}
