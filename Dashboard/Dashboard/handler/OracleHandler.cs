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
                MessageBox.Show("가입 해주셔서 감사합니다");
            }
            catch(OracleException )
            {
                MessageBox.Show("아이디가 중복되어 가입이 불가합니다");
            }
        }

        public void selectid(string id)
        {

                string query = "select mem_id FROM member_T where mem_id='" + id + "'";

                cmd.Connection = conn;
                cmd.CommandText = query;


            OracleDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                MessageBox.Show("중복된 ID입니다");
                }
                else
                {
                MessageBox.Show("사용가능합니다");
                }
          

        }
        public void loginid(string id,string password)
        {
            
            string query= string.Format("select mem_id,mem_password from member_t where mem_id = '{0}'and mem_password = '{1}'",id,password);

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
           
        public void insertmovie(Movie movie)
        {
            string query = string.Format("insert into movie_t values" +
                    "('{0}','{1}','{2}','{3}',", movie.Title, movie.Starpoint, movie.Director, movie.Actor)+"MOVIE_T_SEQ.NEXTVAL)";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
          
            

            

    }
}
