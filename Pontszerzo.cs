using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA23101907
{
    internal class Pontszerzo
    {
        public int Helyezes { get; set; }
        public int Sportolok { get; set; }
        public string Sportag { get; set; }
        public string Versenyszam { get; set; }
        public int Pont => Helyezes == 1 ? 7 : 7 - Helyezes;
        public Pontszerzo(string s)
        {
            var v = s.Split(' ');
            Helyezes = int.Parse(v[0]);
            Sportolok = int.Parse(v[1]);
            Sportag = v[2];
            Versenyszam = v[3];
        }
    }
}
