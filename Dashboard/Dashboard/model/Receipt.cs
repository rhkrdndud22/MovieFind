using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.model
{
    class Receipt
    {
        private Member member;
        private Login login;
        private Genre genre;

        public Receipt(Login login, Member member, Genre genre)
        {
          
            this.login = login;
            this.member = member;
            this.genre = genre;
        }

        internal Member Member { get => member; set => member = value; }
        internal Login Login { get => login; set => login = value; }
        internal Genre Genre { get => genre; set => genre = value; }
    }
}
