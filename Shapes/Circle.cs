using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle
    {
        //variables for constructors
        public char name; //holds character as name for object
        public double radius; //holds double data type for radius of object

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

        //copy contrutor
        public Circle(Circle s)
        {
            name = s.name;
            radius = s.radius;

            Console.WriteLine(String.Format("A copy of circle \"{0}\" has been created!", name, radius));
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public double CalculatePerimeter()
        {
            return Math.PI * (radius * 2);
        }

    }
}
