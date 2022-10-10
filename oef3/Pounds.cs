using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class Pounds : USD
    {
        public double p;
        public Pounds(double x) : base(x)
        {
            this.p = x * 0.88;

        }

        public override string ToString()
        {
            return p.ToString();
        }
    }
}
