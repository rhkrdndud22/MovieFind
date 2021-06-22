using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.handler
{
    class OracleHandler
    {
        const string ORADB =
   "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
   "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
   "(PORT=1521)))" +
   "(CONNECT_DATA=(SERVER=DEDICATED)" +
   "(SERVICE_NAME=XE)));" +
   "User Id=SQLDB;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;

        public OracleHandler()
        {
            Console.Write("하이");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 에러!");
            }
        }
    }
}
