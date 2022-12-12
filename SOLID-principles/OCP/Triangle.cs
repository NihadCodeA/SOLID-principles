using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Triangle : Shape
    {
        public int Height { get; set; }
        public int Side { get; set; }
        public int Hypotenuse { get; set; }

        public override double Area()
        {
            return this.Height * this.Side / 2;
        }

        public override double Perimetr()
        {
            return this.Side * 2 + this.Hypotenuse;
        }
    }
}
