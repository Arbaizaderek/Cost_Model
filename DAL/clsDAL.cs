using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsDAL
    {
        public static SqlConnection db = null;
        public void OpenConnection()
        {
            db = new SqlConnection(@"Data Source=DESKTOP-6PRTJ4F\PROJECT;Initial Catalog=PaniDB;Integrated Security=True");
            db.Open();
        }
        public void CloseConnection()
        {
            db = new SqlConnection(@"Data Source=DESKTOP-6PRTJ4F\PROJECT;Initial Catalog=PaniDB;Integrated Security=True");
            db.Close();
        }
    }
}
