using System;

namespace Lesson02
{

    class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }
    }

    class Rectangle : Polygon
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double GetArea()
        {
            return Width * Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine(
                "Width={0}, Length={1}, Area={2}",
                rect.Width, rect.Length, rect.GetArea());
        }

    }
}
