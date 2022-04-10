using System;

namespace Figury
{
    public class Rectangle : Shape, IFigure
    {
        public Rectangle(Point[] points, string colour) : base(points, colour)
        {
            // this.points = points;
            // this.colour = colour;
            Console.WriteLine("Rectangle constructor");
        }

        public override void Display()
        {
            Console.WriteLine($"This is a rectangle of colour {colour} and has a point at {points[0].x}, {points[0].y} and {points[1].x}, {points[1].y}");
        }

        public void CalculateArea()
        {
            Console.WriteLine("This is the area");
        }
    }
}