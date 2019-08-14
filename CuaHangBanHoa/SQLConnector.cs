using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CuaHangBanHoa
{
    class SQLConnector
    {
        private static SqlConnection con;

        public static SqlConnection GetSqlConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLBanHoaConnectionString;
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}
