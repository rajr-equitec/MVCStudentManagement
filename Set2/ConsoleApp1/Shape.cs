using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dimension
    {
        public interface Shape { 
            double Sides();
            double Area(); 
        }
        public class Rectangle : Dimension
        { 
            double length;
            double width;
            public Rectangle(double length, double width) 
            { this.length = length; this.width = width;
            }
            public double Sides() {
                return 4;
            } public double Area() {
                return length * width; } 
        }
        public class Square : Dimension
        {
            double length; public Square(double length)
            { this.length = length; }
            public double Sides() { return 4; }
            public double Area()
            {
                return length
            * length;
            }
        }
        public class Circle : Dimension
        {
            double radius; public Circle(double radius)
            { this.radius = radius; }

            public double Sides()
            {
                return 0;
            }
            public double Area()
            {
                return Math.PI * radius * radius;
            }


        }

    }
}
