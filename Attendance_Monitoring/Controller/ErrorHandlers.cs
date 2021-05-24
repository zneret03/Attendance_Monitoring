using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Attendance_Monitoring.Controller
{
    class ErrorHandlers
    {
        //Check if number or not for age
        public bool checkNum(String cred)
        {

            bool isNumber = Regex.IsMatch(cred, @"(?:100|[1-9]?[0-9])$");
            if (isNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
