using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Monitoring.Connection
{
    class ConnectionQuery
    {
        public String connectionQuery()
        {
            String connectionString = "datasource=localhost;port=3306;username=root;password=;database=attendance_monitoring";
            return connectionString;
        }
    }
}
