using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Ellipse
    {
        public char name; //holds character as name for object
        public double semMajAxis; //holds semi major axis
        public double semMinAxis;//holds semi minor axis

        //Default constructor
        public Ellipse()
        {
            Console.WriteLine("An ellipse has been created!");
        }

        //parameterized constructor
        public Ellipse(char name, double semMajAxis, double semMinAxis)
        {
            Console.WriteLine(String.Format("Ellipse \"{0}\" with a Semi Major Axis of {1} and a Semi Minor Axis of {2} has been created!", name, semMajAxis, semMinAxis));
            this.name = name;
            this.semMajAxis = semMajAxis;
            this.semMinAxis = semMinAxis;
        }

        //copy construtor
        public Ellipse(Ellipse s)
        {
            name = s.name;
            semMajAxis = s.semMajAxis;
            semMinAxis = s.semMinAxis;

            Console.WriteLine(String.Format("A copy of ellipse \"{0}\" has been created!", name));
        }

        //calculates area of object
        public double CalculateArea()
        {
            return Math.PI * semMinAxis * semMinAxis;
        }

        //calculates parimeter of object using Ramanujan's formula
        public double CalculatePerimeter()
        {
           var a = semMajAxis;
           var b = semMinAxis;

            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }
    }
}
