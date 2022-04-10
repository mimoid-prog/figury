using System;

namespace Figury {
    public abstract class Shape {
        public Point[] points;
        public string colour;

        public Shape(Point[] points, string colour) {
            this.points = points;
            this.colour = colour;
        }

        public abstract void Display ();

        // public void AddPoint() {
        //     Console.WriteLine("Add point");
            
        // }
    }
}