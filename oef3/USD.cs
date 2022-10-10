using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class USD
    {

        public double x { get; set; }

        public USD(double x)
        {
            this.x = x;
        }

        public USD()
        {
            this.x = x;
        }

        public override string ToString()
        {
            return x.ToString();
        }
    }
}
