using Dashboard.model;
using Dashboard.UI;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Dashboard.handler
{
    class OracleHandler
    {


        
        public static string movie_id;
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
            
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
               
            }
            catch (OracleException )
            {
               
            }
        }

        
        
        public void insertdb(Member member)
        {
            try
            {
                string query = string.Format("insert into member_t values" +
                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", member.Id, member.Pasword, 
                    member.Name, member.Tel, member.Birth, member.Lgenre, member.Hgenre);
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
        public void selectname(string id)
        {
            string query = "select mem_name from member_t where mem_id='" + id + "'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            Info.na=cmd.ExecuteScalar().ToString();
            Form1.u= cmd.ExecuteScalar().ToString();

        }
        public void selectgenre(string id)
        {
           
            string query = "select mem_mgenre from member_t where mem_id='" + id + "'";
            cmd.Connection = conn;
            cmd.CommandText = query;

          
            Info.gen = cmd.ExecuteScalar().ToString();
        }

        public void selectstar(string id)
        {
            string query = "select avg(starpoint) from starpoint_t where mem_id='" + id + "'";
            cmd.Connection = conn;
            cmd.CommandText = query;

            Info.sp = cmd.ExecuteScalar().ToString();
        }
        public DataTable selectmovie()
        {  
           
            string query = "select movie_title as 영화제목 ,count(movie_title) as 찾은수 from movie_T Group By movie_title order by 찾은수 desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            OracleDataAdapter ada = new OracleDataAdapter();
            ada.SelectCommand = new OracleCommand(query,conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
            

        }

        public DataTable selectpoint(string id)
        {
            string query =
                "SELECT MOVIE_T.MOVIE_TITLE,Starpoint_T.Starpoint,Starpoint_t.evolation AS FROM MOVIE_T INNER JOIN STARPOINT_T ON MOVIE_T.MOVIE_ID = STARPOINT_t.MOVIE_ID WHERE starpoint_t.mem_ID ='" + id + "'";

            cmd.Connection = conn;
            cmd.CommandText = query;
            OracleDataAdapter ada = new OracleDataAdapter();
            ada.SelectCommand = new OracleCommand(query, conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
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

        public void insertstarpoint(Star star,string id)
        {
            
             string query = string.Format("SELECT movie_id FROM movie_T where movie_title ='{0}'"+
                 "INTERSECT SELECT movie_id FROM starpoint_t where mem_id = '{1}'",movie_id,id);
                cmd.Connection = conn;
                cmd.CommandText = query;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("이미 별점을 등록한 영화입니다");
                }
                else
                {
                    string query1 = string.Format("insert into starpoint_t values(STARPOINT_T_SEQ.NEXTVAL," + "'{0}'," 
                        + "(select movie_id from movie_t  where movie_title ='{1}' and rownum=1)," + " {2},'{3}')",
                        star.Mem_id, movie_id, star.Point, star.Evalution);
                    cmd.Connection = conn;
                    cmd.CommandText = query1;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("별점이 등록되었습니다");
                }
            
          
        }
          
            

            

    }
}
