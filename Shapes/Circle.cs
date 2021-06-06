using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle
    {
        public char name; //holds character as name for object
        public double radius; //holds radius of object

        //Default constructor
        public Circle()
        {
            Console.WriteLine("A circle has been created!");
        }
        
        //parameterized constructor
        public Circle(char name, double radius)
        {
            Console.WriteLine(String.Format("Circle \"{0}\" with the radius of {1}, has been created!", name, radius));
            this.name = name;
            this.radius = radius;
        }

        //copy construtor
        public Circle(Circle s)
        {
            name = s.name;
            radius = s.radius;

            Console.WriteLine(String.Format("A copy of circle \"{0}\" has been created!", name, radius));
        }

        //calculates are of object
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        //calculates perimeter of object
        public double CalculatePerimeter()
        {
            return Math.PI * (radius * 2);
        }

    }
}
