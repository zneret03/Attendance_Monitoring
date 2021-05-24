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
    public partial class UserMaintenance : Form
    {
        Controller.Employee employee = new Controller.Employee();
        public UserMaintenance()
        {
            InitializeComponent();
        }

        public void readData()
        {
            try
            {
                dataGridView1.Rows.Clear();
                MySqlDataReader reader = employee.readUserMaintenance();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["user_id"].ToString(),
                        reader["username"].ToString(),
                        reader["password"].ToString(),
                        reader["firstname"].ToString(),
                        reader["middlename"].ToString(),
                        reader["lastname"].ToString(),
                        reader["usertype"].ToString(),
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

        private void UserMaintenance_Load(object sender, EventArgs e)
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
            readData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dataGridView1.Columns[e.ColumnIndex].Name;
            DataGridViewRow dt = this.dataGridView1.Rows[e.RowIndex];
            ModifyUserMaintenance modify = new ModifyUserMaintenance(this);

            if (colName == "fetch")
            {
                modify.idValue.Text = dt.Cells[0].Value.ToString();
                modify.txtUsername.Text = dt.Cells[1].Value.ToString();
                modify.txtPassword.Text = dt.Cells[2].Value.ToString();
                modify.comboUsertype.Text = dt.Cells[6].Value.ToString();

                modify.idValue.Hide();
                modify.Show();
            }
        }

        public void searchEmployee()
        {
            try
            {
                dataGridView1.Rows.Clear();
                MySqlDataReader reader = employee.searchUserMaintenance(txtSearch.text.ToString());
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["user_id"].ToString(),
                        reader["username"].ToString(),
                        reader["password"].ToString(),
                        reader["firstname"].ToString(),
                        reader["middlename"].ToString(),
                        reader["lastname"].ToString(),
                        reader["usertype"].ToString(),
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


        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            searchEmployee();
        }

    }
}
