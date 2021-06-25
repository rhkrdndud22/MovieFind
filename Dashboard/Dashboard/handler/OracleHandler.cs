using Dashboard.model;
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
   "User Id=Model;Password=1234;";
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
            catch (OracleException )
            {
                Console.WriteLine("오라클 접속 에러!");
            }
        }

        public void insertDb()
        {
            string id = "rhkrdndud11";
            string password = "rhkr1218";
            string name = "김우영";
            string tel = "01021916995";
            string birth = "19961218";
            string mgenre = "코미디";
            string Hgenre = "공포";

            string query = string.Format("insert into member_t values" +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", id, password, name, tel, birth, mgenre, Hgenre);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }
        public void insertdb(Member member)
        {
            try
            {
                string query = string.Format("insert into member_t values" +
                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", member.Id, member.Pasword, member.Name, member.Tel, member.Birth, member.Lgenre, member.Hgenre);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch(OracleException )
            {
                
            }
        }

        public void selectid(Member member)
        {
            
            
                string query = string.Format("SELECT count(*) FROM member_T WHERE mem_id = '{0}'", member.Id);
                
            
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("성공");
            }
            else if(cmd.ExecuteNonQuery() == 0)
            {
                Console.WriteLine("실패");
            }
           
        }
    }
}
