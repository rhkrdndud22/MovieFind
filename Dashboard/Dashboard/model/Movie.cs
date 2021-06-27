using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.model
{
    class Movie
    {
        private string title;
        private string starpoint;
        private string director;
        private string actor;

        public Movie(string title, string starpoint, string director, string actor)
        {
            this.title = title;
            this.starpoint = starpoint;
            this.director = director;
            this.actor = actor;
        }

        public string Title { get => title; set => title = value; }
        public string Starpoint { get => starpoint; set => starpoint = value; }
        public string Director { get => director; set => director = value; }
        public string Actor { get => actor; set => actor = value; }
    }
}
