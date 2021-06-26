using Dashboard.model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
   "User Id=MODEL;Password=1234;";
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

        public void selectid(string id)
        {

                string query = "select count(*) FROM member_T where mem_id='" + id + "'";

                cmd.Connection = conn;
                cmd.CommandText = query;

                int result = Convert.ToInt32(cmd.ExecuteNonQuery());


                if (result == 1)
                {
                    Console.WriteLine("성공");
                }
                else
                {
                    Console.WriteLine("실패");
                }
          

        }
        public void loginid()
        {
            
            string query= "select mem_id,mem_password from member_t where mem_id = 'rhkrdnud22'and mem_password = 'rhkr1218'";

            cmd.Connection = conn;
            cmd.CommandText = query;
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                
                Form1 f1 = new Form1();
                f1.Show();
                
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 틀립니다");
            }
           

          
            

            

        }
    }
}
