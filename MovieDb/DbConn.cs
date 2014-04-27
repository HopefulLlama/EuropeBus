using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace MovieDb
{
    public class DbConn
    {
        private static DbConn instance = new DbConn();
        private OleDbConnection conn;

        public OleDbConnection Conn
        {
            get { return conn; }
        }

        private DbConn()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\databases\lj048\MovieDB.mdb");
        }

        public static DbConn getInstance()
        {
            if (instance == null)
            {
                instance = new DbConn();
            }
            return instance;
        }
    }
}