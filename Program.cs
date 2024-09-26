// See https://aka.ms/new-console-template for more information

using System;
namespace SystemTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            Console.WriteLine(shape);

            shape = new Shape("red", false);

            Console.WriteLine(shape);

            Console.WriteLine("Hello World"!);
            Rectangle rectangle = new Rectangle();

            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.3, 5.8);

            Console.WriteLine(rectangle);
             Square square = new Square();

                Console.WriteLine(square);

                square = new Square(2.3);

                Console.WriteLine(square);
        }
    }
}
