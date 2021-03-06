using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle
    {
        public char name; //holds character as name for object
        public double width; //holds width of object
        public double height; //holds height of object

        //Default constructor
        public Rectangle()
        {
            Console.WriteLine("A rectangle has been created!");
        }

        //parameterized constructor
        public Rectangle(char name, double width, double height)
        {
            Console.WriteLine(String.Format("Rectangle \"{0}\" with a width of {1} and a height of {2} has been created!", name, width, height));
            this.name = name;
            this.width = width;
            this.height = height;
        }

        //copy construtor
        public Rectangle(Rectangle s)
        {
            name = s.name;
            width = s.width;
            height = s.height;

            Console.WriteLine(String.Format("A copy of square \"{0}\" has been created!", name));
        }

        //caculates area of object
        public double CalculateArea()
        {
            return width * height;
        }

        //calcuates parameter of object
        public double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
    }
}
