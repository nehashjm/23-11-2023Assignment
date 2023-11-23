
using ShapeAreaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Square square = new Square();
            Console.WriteLine("Choose the following 1.Rectangle \t 2.Square\t 3.Circle\t 4.Triangle");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("Eneter length");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter breadth");
                double breadth = double.Parse(Console.ReadLine());
                Console.WriteLine("area of rectangle is " +rect.Area(length,breadth));
            }
            else if(choice ==2)
            {
                Console.WriteLine("Enter side");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("Area of square" + square.Area(side));

            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter radius");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Area of circle" + circle.Area(radius));

            }
            else if(choice == 4)
            {
                Console.WriteLine("Enter base");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("enter height");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Area of Triangle" + triangle.Area(width,height));

            }
            Console.ReadKey();
        }
    }
}
