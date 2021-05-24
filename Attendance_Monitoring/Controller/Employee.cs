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

namespace Attendance_Monitoring.Controller
{
    class Employee : Model.EmployeeModel
    {
        //Admin side all attendance 

        public MySqlDataReader fetchAllAttendance()
        {
            String query = "SELECT attendance_id, username, time, status, date FROM attendance INNER JOIN users ON users.user_id = attendance.user_id";
            return this.display(query);
        }

        public MySqlDataReader searchAllAttendance(String search)
        {
            String query = "SELECT attendance_id, username, time, status, date FROM attendance INNER JOIN users ON users.user_id = attendance.user_id WHERE username LIKE '%" + search + "%' OR attendance_id LIKE '%" + search + "%'";
            return this.display(query);
        }

        //Admin side
        public MySqlDataReader fetchDailyAttendance(String username, String dateNow)
        {
            String query = "SELECT attendance_id, firstname, lastname, username, time, status, date FROM attendance INNER JOIN users ON users.user_id = attendance.user_id WHERE username = '" + username + "' AND date = '" + dateNow + "'";
            return this.display(query);
        }

        public object countAttendance(String username)
        {
            String query = "SELECT COUNT(*) FROM attendance INNER JOIN users ON users.user_id = attendance.user_id WHERE username = '" + username + "'";
            return this.count(query);
        }

        public object countAllEmployee()
        {
            String query = "SELECT COUNT(*) FROM users WHERE usertype = 'employee'";
            return this.count(query);
        }

        public object countAllUsers()
        {
            String query = "SELECT COUNT(*) FROM users";
            return this.count(query);
        }

        public object countAllAttendance()
        {
            String query = "SELECT COUNT(*) FROM attendance";
            return this.count(query);
        }

        public object countDailyAttendance(String date)
        {
            String query = "SELECT COUNT(*) FROM attendance WHERE date = '" + date + "'";
            return this.count(query);
        }

        public MySqlDataReader loadEmployeeAttendance(String FromDate, String toDate, String username)
        {
            String query = "SELECT attendance_id, username, time, status, date FROM attendance INNER JOIN users ON users.user_id = attendance.user_id WHERE date BETWEEN '" + FromDate + "' AND '" + toDate + "' AND username = '" + username + "'";
            return this.display(query);
        }
        public MySqlDataReader readUserMaintenance()
        {
            String query = "SELECT user_id, username, password, firstname, middlename, lastname, usertype, date_created, date_updated FROM users";
            return this.display(query);
        }
        public MySqlDataReader readData()
        {
            String query = "SELECT  user_id, firstname, middlename, lastname, address, age, gender, date_created, date_updated FROM users";
            return this.display(query);
        }

        public MySqlDataReader loggedUserID(String username)
        {
            String query = "SELECT user_id FROM users WHERE username = '" + username + "'";
            return this.display(query);
        }

        public MySqlDataReader searchData(String search)
        {
            String query = "SELECT user_id, firstname, middlename, lastname, address, age, gender, date_created, date_updated FROM users WHERE firstname LIKE '%" + search + "%' OR user_id LIKE '%" + search + "%' ";
            return this.display(query);
        }

        public MySqlDataReader searchUserMaintenance(String search)
        {
            String query = "SELECT user_id, username, password, firstname, middlename, lastname, usertype, date_created, date_updated FROM users WHERE username LIKE '%" + search + "%' OR user_id LIKE '%" + search + "%' ";
            return this.display(query);
        }

        public MySqlDataReader EmployeeAttendance()
        {
            String query = "SELECT attendance_id, username, time, status, date FROM attendance INNER JOIN users ON users.user_id = attendance.user_id";
            return this.display(query);
        }

        public MySqlDataReader dailyAttendance(String username)
        {
            String query = "SELECT time, status, date FROM attendance INNER JOIN users ON users.user_id = attendance.user_id WHERE username = '" + username + "'";
            return this.display(query);
        }

        public void addEmployee(TextBox[] text, String gender, AddEmployee suspend)
        {
            foreach (TextBox txt in text)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Please fill all empty fields, try again", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    this.insertEmployee(text, gender, suspend);
                    break;
                }
            }
        }

        public void fetchEmployeeUsername(ComboBox comboName)
        {
            this.loadEmployeeUsername(comboName);
        }

        public void addAttendanceTimeIn(String idValue, String time, String status, String date, String username)
        {
            this.isErrorTimeIn(idValue, time, status, date, username);
        }

        public void addAttendanceTimeOut(String idValue, String time, String status, String date, String username)
        {
            this.isErrorTimeOut(idValue, time, status, date, username);
        }

        public void deleteEmployee(String IdValue, AddEmployee suspend)
        {
            this.omitEmployee(IdValue, suspend);
        }

        public void deleteUser(String IdValue, ModifyUserMaintenance suspend)
        {
            this.omitUser(IdValue, suspend);
        }

        public void updateEmployee(String idValue, TextBox[] text, String gender)
        {
            this.modifyEmployee(idValue, text, gender);
        }

        public void updateUser(String idValue, String username, String password, String usertype)
        {
            this.isUsernameExist(idValue, username, password, usertype);
        }
    }
}
