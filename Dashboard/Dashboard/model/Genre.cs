using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.model
{
    class Genre
    {
        private string mgenre;
        private string hgenre;

        public Genre(string mgenre, string hgenre)
        {
            this.mgenre = mgenre;
            this.hgenre = hgenre;
        }

        public string Mgenre { get => mgenre; set => mgenre = value; }
        public string Hgenre { get => hgenre; set => hgenre = value; }
    }
}
