using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Pentagon
    {
        //variables for constructors
        public char name; //holds character as name for object
        public double side; //holds double data type for length of sides of object

        //Default constructor
        public Pentagon()
        {
            Console.WriteLine("A pentagon has been created!");
        }

        //parameterized constructor
        public Pentagon(char name, double side)
        {
            Console.WriteLine(String.Format("Pentagon \"{0}\" with a Length of Side of {1}, has been created!", name, side));
            this.name = name;
            this.side = side;
        }

        //copy contrutor
        public Pentagon(Pentagon s)
        {
            name = s.name;
            side = s.side;

            Console.WriteLine(String.Format("A copy of pentagon \"{0}\" has been created!", name));
        }

        public double CalculateArea()
        {
            return .25 * Math.Sqrt(5* (5 + 2 * Math.Sqrt(5))) * Math.Pow(side, 2);
        }

        public double CalculatePerimeter()
        {
            return 5 * side;
        }
    }
}
