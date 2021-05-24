using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Monitoring.Controller
{
    class UserController : Model.userModel
    {
        public void userCred(String username, String password, Login suspend)
        {
            userLogin(username, password, suspend);
        }
    }
}
