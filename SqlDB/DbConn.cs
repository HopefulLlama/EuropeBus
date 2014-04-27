using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlDb
{
    public class DbConn
    {
        private static DbConn instance = new DbConn();
        SqlConnection conn;

        public SqlConnection Conn
        {
          get { return conn; }
          set { }
        }

        private DbConn()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "data source=SQL-SERVER;" +
                "initial catalog=lj048;" +
                "Integrated Security=SSPI;";
        }

        public static DbConn getInstance()
        {
            return instance;
        }

        public void open()
        {
            conn.Open();
        }

        public void close()
        {
            conn.Close();
        }
    }
}
