using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class AreaCalculator
    {
        public double Area(Shape shape)
        {
            return shape.Area();
        }
        public double Perimetr(Shape shape)
        {
            return shape.Perimetr();
        }
    }
}
