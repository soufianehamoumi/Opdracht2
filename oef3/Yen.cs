using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class Yen : USD
    {
        public double y;
        public Yen(double x) : base(x)
        {
            this.y = x * 1.02;

        }

        public override string ToString()
        {
            return y.ToString();
        }
    }
}
