using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Db {
        static String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TimetableDB.mdf; Integrated Security=True";
        SqlConnection con = new SqlConnection(cs);
        

        //ConfigurationManager.ConnectionStrings["TimetableDBCS"].ConnectionString;
    }
}
