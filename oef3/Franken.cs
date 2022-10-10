using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class Franken : USD
    {
        public double f;
        public Franken(double x) : base(x)
        {
            this.f = x * 0.99;

        }

        public override string ToString()
        {
            return f.ToString();
        }
    }
}
