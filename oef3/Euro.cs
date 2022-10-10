using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class Euro : USD
    {
        public double e;
        public Euro(double x) :base(x)
        {
            this.e = x * 1.02;

        }

        public override string ToString()
        {
            return e.ToString();
        }
    }
}
