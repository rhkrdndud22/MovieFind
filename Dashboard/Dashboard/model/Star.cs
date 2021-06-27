using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.model
{
    class Star
    {
        private string mem_id;
        private string movie_id;
        private double point;
        private string evalution;

        public Star(string mem_id, string movie_id, double point, string evalution)
        {
            this.mem_id = mem_id;
            this.movie_id = movie_id;
            this.point = point;
            this.evalution = evalution;
        }

        public string Mem_id { get => mem_id; set => mem_id = value; }
        public string Movie_id { get => movie_id; set => movie_id = value; }
        public double Point { get => point; set => point = value; }
        public string Evalution { get => evalution; set => evalution = value; }
    }
}
