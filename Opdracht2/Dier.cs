using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    internal class Dier
    {
        public int Gewicht
        { 
            get; 
            set;
        }

        protected Dier(int gewicht)
        {
            this.Gewicht = gewicht;
        }

        public string Zegt(string geluid)
        {
            return geluid;
        }

        public override string ToString()
        {
            return "geluid" + Gewicht;
        }

    }
}
