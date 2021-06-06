using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var circle1 = new Circle();//default constructer call
            var circle2 = new Circle('s', 25);//parameterized constuctor call
            var circle3 = new Circle(circle2);//copied constructor call

            //prints area and parameter for object 2 of class
            Console.WriteLine(String.Format("The ara of circle \"{0}\" is {1}.", circle2.name, circle2.CalculateArea()));
            Console.WriteLine(String.Format("The perimeter of circle \"{0}\" is {1}.", circle2.name, circle2.CalculatePerimeter()));

            //create whitespace in ouput
            Console.WriteLine(" ");

            var square1 = new Square();
            var square2 = new Square('a', 10);
            var square3 = new Square(square2);

            Console.WriteLine(String.Format("The ara of square \"{0}\" is {1}.", square2.name, square2.CalculateArea()));
            Console.WriteLine(String.Format("The perimeter of square \"{0}\" is {1}.", square2.name, square2.CalculatePerimeter()));

            //create whitespace in ouput
            Console.WriteLine(" ");

            var rectangle1 = new Rectangle();
            var rectangle2 = new Rectangle('z', 10, 20);
            var rectangle3 = new Rectangle(rectangle2);

            Console.WriteLine(String.Format("The ara of square \"{0}\" is {1}.", rectangle2.name, rectangle2.CalculateArea()));
            Console.WriteLine(String.Format("The perimeter of square \"{0}\" is {1}.", rectangle2.name, rectangle2.CalculatePerimeter()));

            //create whitespace in ouput
            Console.WriteLine(" ");

            var ellipse1 = new Ellipse();
            var ellipse2 = new Ellipse('x', 20, 10);
            var ellipse3 = new Ellipse(ellipse2);

            Console.WriteLine(String.Format("The ara of ellipse \"{0}\" is {1}.", ellipse2.name, ellipse2.CalculateArea()));
            Console.WriteLine(String.Format("The perimeter of ellipse \"{0}\" is {1}.", ellipse2.name, ellipse2.CalculatePerimeter()));

            //create whitespace in ouput
            Console.WriteLine(" ");

            var pentagon1 = new Pentagon();
            var pentagon2 = new Pentagon('p', 10);
            var pentagon3 = new Pentagon(pentagon2);

            Console.WriteLine(String.Format("The ara of pentagon \"{0}\" is {1}.", pentagon2.name, pentagon2.CalculateArea()));
            Console.WriteLine(String.Format("The perimeter of pentagon \"{0}\" is {1}.", pentagon2.name, pentagon2.CalculatePerimeter()));

            //create whitespace in ouput
            Console.WriteLine(" ");
           
        }
    }
}
