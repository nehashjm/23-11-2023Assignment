using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Circle
    {
        public double Area(double radius)
        {
            double result = 3.142 * radius*radius;
            return result;
        }
    }
}
