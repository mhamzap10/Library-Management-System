using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Database
    {
        public SqlConnection GetConnection()
        {
            return  new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\hamza\assignment\4th Semester\SDA Lab\LMS\Library Management System\database\library_management_system.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
