using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square
    {
        public char name; //holds character as name for object
        public double los; //holds length of side of object

        //Default constructor
        public Square()
        {
            Console.WriteLine("A square has been created!");
        }

        //parameterized constructor
        public Square(char name, double los)
        {
            Console.WriteLine(String.Format("Square \"{0}\" with a Length of Side of {1}, has been created!", name, los));
            this.name = name;
            this.los = los;
        }

        //copy construtor
        public Square(Square s)
        {
            name = s.name;
            los = s.los;

            Console.WriteLine(String.Format("A copy of square \"{0}\" has been created!", name));
        }

        //calculates area of object
        public double CalculateArea()
        {
            return Math.Pow(los, 2);
        }

        //calculates perimeter of object
        public double CalculatePerimeter()
        {
            return 4 * los;
        }
    }
}
