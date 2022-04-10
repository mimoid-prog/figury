
using System;

namespace Figury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Point[] RectanglePoints = new Point[] { new Point(2, 3), new Point(5, 9) };
            Rectangle rectangle1 = new Rectangle(RectanglePoints, "red");
            rectangle1.Display();
        }

    }
}

