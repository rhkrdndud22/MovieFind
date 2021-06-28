using Dashboard.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.handler
{
    class MemberAdapter
    {
        private List<Member> memberList = new List<Member>();
        private List<Movie> movieList = new List<Movie>();
        private List<Star> starList = new List<Star>();
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
        public void selecctgen(string id)
        {
            ora.selectgenre(id);
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

        public void addstardb()
        {
            for (int i = 0; i <starList.Count; i++)
            {
                ora.insertstarpoint(starList[i]);
            }
            starList.Clear();
        }
    }
}
