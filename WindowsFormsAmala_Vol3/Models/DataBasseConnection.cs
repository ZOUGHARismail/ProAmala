using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAmala_Vol3.Models
{
    internal class DataBasseConnection
    {
        public DataBasseConnection() { }
        public static SqlConnection connection = new SqlConnection("server=DESKTOP-NMHS2UI\\SQLEXPRESS;database=amala_Vol3;integrated security=true");
    }
}
