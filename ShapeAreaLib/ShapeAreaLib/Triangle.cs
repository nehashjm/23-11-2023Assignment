﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Triangle
    {
        public double Area(double breadth,double height)
        {
            double result = 0.5 * breadth * height;
            return result;
        }
    }
}
