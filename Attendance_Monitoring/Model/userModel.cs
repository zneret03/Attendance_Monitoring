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

namespace Attendance_Monitoring.Model
{
    class userModel : Connection.ConnectionQuery
    {
        String conn;
        MySqlConnection connection;
        MySqlDataAdapter sda;
        MySqlCommand command;
        DataTable dt;
        protected void userLogin(String username, String password, Login suspend)
        {
            try
            {
                conn = this.connectionQuery();
                connection = new MySqlConnection(conn);
                connection.Open();

                command = new MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                sda = new MySqlDataAdapter();
                dt = new DataTable();
                command.ExecuteNonQuery();
                sda.SelectCommand = command;
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    String usertype = dt.Rows[0][9].ToString();
                    if (usertype == "admin")
                    {
                        MessageBox.Show("Welcome admin " + username.ToUpper(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin_Dashboard admin = new Admin_Dashboard(username);
                        admin.Show();
                        suspend.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Welcome employee " + username.ToUpper(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Employee_Dashboard employee = new Employee_Dashboard(username);
                        employee.Show();
                        suspend.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Account is not yet registered please register first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
