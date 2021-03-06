using Dashboard.model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.handler
{
    class MemberAdapter
    {
        private List<Movie> movieList = new List<Movie>();
        private List<Star> starList = new List<Star>();
        private List<Member> memberList = new List<Member>();
        private OracleHandler ora;

        public MemberAdapter(OracleHandler ora)
        {
            this.ora = ora;
        }
        public void addMember(Member member)
        {
            memberList.Add(member);
        }
        public void addmovie(Movie movie)
        {
            movieList.Add(movie);
        }
     
        public void addstar(Star star)
        {
            starList.Add(star);
        }
        public void addReceiptDb()
        {
            for (int i = 0; i < memberList.Count; i++)
            {
                ora.insertdb(memberList[i]);
            }
            memberList.Clear();

        }
        public void selectdb(string id)
        {
          
                ora.selectid(id);
           

        }
        public void selectdbn(string id)
        {
            ora.selectname(id);
        }
        public void selectstar(string id)
        {
            ora.selectstar(id);
        }
        public void selectgen(string id)
        {
            ora.selectgenre(id);
        }
        public DataTable selectmovie()
        {
             DataTable dt=ora.selectmovie();
            return dt;
        }
        public DataTable selectpoint(string name)
        {
            
            DataTable dt = ora.selectpoint(name);
            return dt;
        }
        public void logindb(string id,string password)
        {
            ora.loginid(id,password);
        }

        public void addmoviedb()
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                ora.insertmovie(movieList[i]);
            }
            movieList.Clear();
        }

        public void addstardb(string name)
        {
            for (int i = 0; i <starList.Count; i++)
            {
                
                ora.insertstarpoint(starList[i],name);
            }
            starList.Clear();
        }
    }
}
