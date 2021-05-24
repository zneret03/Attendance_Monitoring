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
    class EmployeeModel : Connection.ConnectionQuery
    {
        MySqlCommand command;
        MySqlConnection connection;
        MySqlDataReader reader;
        MySqlDataAdapter sda;
        DataTable dt;
        DateTime now = DateTime.Now;
        Random math = new Random();

        protected MySqlDataReader display(String query)
        {
            connection = new MySqlConnection(this.connectionQuery());
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();

            return reader;
        }

        protected object count(String query)
        {
            connection = new MySqlConnection(this.connectionQuery());
            connection.Open();
            object count;

            using (command = new MySqlCommand(query, connection))
            {
                count = command.ExecuteScalar();
            }

            return count;
        }

        //Get all employee username
        protected void loadEmployeeUsername(ComboBox comboName)
        {
            try
            {
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();

                command = new MySqlCommand("SELECT DISTINCT * FROM users WHERE usertype = 'employee'", connection);
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboName.Items.Add(reader.GetString("username"));
                    }
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Check if username is exist 

        protected void isUsernameExist(String userId, String username, String password, String usertype)
        {
            try
            {
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();

                command = new MySqlCommand("SELECT username FROM users WHERE username = @username", connection);
                command.Parameters.AddWithValue("@username", username);

                sda = new MySqlDataAdapter();
                dt = new DataTable();
                command.ExecuteNonQuery();
                sda.SelectCommand = command;
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    String Username = dt.Rows[0][0].ToString();

                    if (Username == username)
                    {
                        MessageBox.Show("This username already exist try create another one", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //MessageBox.Show(status + " " + date + " " + username, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //insertAttendance(idValue, time, status, date);
                        modifyUser(userId, username, password, usertype);
                    }

                }
                else
                {
                    modifyUser(userId, username, password, usertype);
                    //insertAttendance(idValue, time, status, date);
                }


                command.Dispose();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void modifyUser(String userId, String username, String password, String usertype)
        {
            try
            {
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();
                using (command = new MySqlCommand("UPDATE users SET username = @username, password = @password, usertype = @usertype, date_updated = @date_updated WHERE user_id = @user_id", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@usertype", usertype);
                    command.Parameters.AddWithValue("@date_updated", now);
                    command.Parameters.AddWithValue("@user_id", userId);


                    bool result = (int)command.ExecuteNonQuery() > 0;

                    if (result == true)
                    {
                        MessageBox.Show("Updated Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                command.Dispose();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        protected void omitEmployee(String IdValue, AddEmployee suspend)
        {
            try
            {
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();
                DialogResult result = MessageBox.Show("Do you really want to delete this data?", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    command = new MySqlCommand("DELETE FROM users WHERE user_id = @user_id", connection);
                    command.Parameters.AddWithValue("@user_id", IdValue);

                    bool checkResult = (int)command.ExecuteNonQuery() > 0;

                    if (checkResult == true)
                    {
                        MessageBox.Show("Deleted Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        suspend.Hide();
                    }
                }

                command.Dispose();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void omitUser(String IdValue, ModifyUserMaintenance suspend)
        {
            try
            {
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();
                DialogResult result = MessageBox.Show("Do you really want to delete this data?", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    command = new MySqlCommand("DELETE FROM users WHERE user_id = @user_id", connection);
                    command.Parameters.AddWithValue("@user_id", IdValue);

                    bool checkResult = (int)command.ExecuteNonQuery() > 0;

                    if (checkResult == true)
                    {
                        MessageBox.Show("Deleted Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        suspend.Hide();
                    }
                }

                command.Dispose();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void modifyEmployee(String idValue, TextBox[] text, String gender)
        {
            try
            {
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();
                using (command = new MySqlCommand("UPDATE users SET firstname = @firstname, middlename = @middlename, lastname = @lastname, address = @address, age = @age, gender = @gender, date_updated = @date_updated WHERE user_id = @user_id", connection))
                {
                    command.Parameters.AddWithValue("@firstname", text[0].Text);
                    command.Parameters.AddWithValue("@middlename", text[1].Text);
                    command.Parameters.AddWithValue("@lastname", text[2].Text);
                    command.Parameters.AddWithValue("@address", text[3].Text);
                    command.Parameters.AddWithValue("@age", text[4].Text);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@user_id", idValue);
                    command.Parameters.AddWithValue("@date_updated", now);

                    bool checkResult = (int)command.ExecuteNonQuery() > 0;

                    if (checkResult == true)
                    {
                        MessageBox.Show("Sucessfully Updated", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                command.Dispose();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Avoid multiple time-in
        protected void isErrorTimeIn(String idValue, String time, String status, String date, String username)
        {
            try
            {
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();
                command = new MySqlCommand("SELECT status, date, username FROM attendance INNER JOIN users ON users.user_id = attendance.user_id WHERE status = @status AND date = @date AND username = @username", connection);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@username", username.ToLower());

                sda = new MySqlDataAdapter();
                dt = new DataTable();
                command.ExecuteNonQuery();
                sda.SelectCommand = command;
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    String Status = dt.Rows[0][0].ToString();
                    String Date = dt.Rows[0][1].ToString();
                    String DataUsername = dt.Rows[0][2].ToString();

                    if (Status == "Time-in" && Date == date && DataUsername == username.ToLower())
                    {
                        MessageBox.Show("You've already Time-in", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //MessageBox.Show(status + " " + date + " " + username, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        insertAttendance(idValue, time, status, date);
                    }
                   
                }
                else
                {
                    insertAttendance(idValue, time, status, date);
                }

                command.Dispose();
                connection.Close();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Avoid multiple time-out
        protected void isErrorTimeOut(String idValue, String time, String status, String date, String username)
        {
            try
            {
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();
                command = new MySqlCommand("SELECT status, date, username FROM attendance INNER JOIN users ON users.user_id = attendance.user_id WHERE status = @status AND date = @date AND username = @username", connection);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@username", username.ToLower());

                sda = new MySqlDataAdapter();
                dt = new DataTable();
                command.ExecuteNonQuery();
                sda.SelectCommand = command;
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    String Time = dt.Rows[0][0].ToString();
                    String Date = dt.Rows[0][1].ToString();
                    String DataUsername = dt.Rows[0][2].ToString();

                    if (Time == "Time-out" && Date == date && DataUsername == username.ToLower())
                    {
                        MessageBox.Show("You've already Time-out", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        insertAttendance(idValue, time, status, date);
                    }

                }
                else
                {
                    insertAttendance(idValue, time, status, date);
                }

                command.Dispose();
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        protected void insertAttendance(String idValue, String time, String status, String date)
        {
            try
            {
                int rand = math.Next(1, 1000);
                String id = "attendance-00" + rand.ToString();
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();
                using (command = new MySqlCommand("INSERT INTO attendance (attendance_id, user_id, time, status, date) VALUES (@attendance_id, @user_id, @time, @status, @date)", connection))
                {
                    command.Parameters.AddWithValue("@attendance_id", id);
                    command.Parameters.AddWithValue("@user_id", idValue);
                    command.Parameters.AddWithValue("@time", time);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@date", date);

                    bool result = (int)command.ExecuteNonQuery() > 0;

                    if (result == true)
                    {
                        MessageBox.Show("Successfully Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected void insertEmployee(TextBox[] text, String gender, AddEmployee suspend)
        {
            try
            {
                int rand = math.Next(1, 1000);
                String id = "Emp-00" + rand.ToString();
                connection = new MySqlConnection(this.connectionQuery());
                connection.Open();

                command = new MySqlCommand("INSERT INTO users (user_id, firstname, middlename, lastname, address, age, gender, date_created) " +
                    " VALUES  (@user_id, @firstname, @middlename, @lastname, @address, @age, @gender, @date_created)", connection);

                command.Parameters.AddWithValue("@user_id", id);
                command.Parameters.AddWithValue("@firstname", text[0].Text);
                command.Parameters.AddWithValue("@middlename", text[1].Text);
                command.Parameters.AddWithValue("@lastname", text[2].Text);
                command.Parameters.AddWithValue("@address", text[3].Text);
                command.Parameters.AddWithValue("@age", text[4].Text);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@date_created", now);

                bool result = (int)command.ExecuteNonQuery() > 0;

                if (result == true)
                {
                    MessageBox.Show("Successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    suspend.Hide();
                }

                foreach (TextBox reset in text)
                {
                    reset.Clear();
                }

                command.Dispose();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
