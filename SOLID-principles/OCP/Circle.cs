using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public override double Area()
        {
            return Math.Pow(this.Radius,2) * Math.PI;
        }

        public override double Perimetr()
        {
            return this.Radius * Math.PI;
        }
    }
}
