using System;

namespace Lesson02
{
    struct Point
    {
        public double X, Y;
    }


    class Rectangle
    {
        private double length;
        private double width;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;
            Point p2 = p1;
            p2.X = 100;
            Console.WriteLine("p1.X = {0}", p1.X);

            Rectangle rect1 = new Rectangle { Length = 10.0, Width = 20.0 };

            Rectangle rect2 = rect1;

            rect2.Length = 100.0;
            Console.WriteLine("rect1.Length = {0}", rect1.Length);
        }

    }
}
