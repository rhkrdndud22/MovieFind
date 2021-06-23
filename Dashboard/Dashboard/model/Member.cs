using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.model
{
    class Member
    {
        private string id;
        private string pasword;
        private string name;
        private string tel;
        private string birth;
        private string lgenre;
        private string hgenre;

        public Member(string id, string pasword, string name, string tel, string birth, string lgenre, string hgenre)
        {
            this.id = id;
            this.pasword = pasword;
            this.name = name;
            this.tel = tel;
            this.birth = birth;
            this.lgenre = lgenre;
            this.hgenre = hgenre;
        }

        public string Id { get => id; set => id = value; }
        public string Pasword { get => pasword; set => pasword = value; }
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Lgenre { get => lgenre; set => lgenre = value; }
        public string Hgenre { get => hgenre; set => hgenre = value; }
    }
}
