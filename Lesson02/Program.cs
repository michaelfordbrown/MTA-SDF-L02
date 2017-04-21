using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Rectangle
    {

        /*  Simplified syntax for auto-implemented properties */
        public double Length { get; set; }
        public double Width { get; set; }
               
        public double GetArea()
        {
            return Length * Width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { Length = 10.0, Width = 20.0 };
            Console.WriteLine("Area of Rectangle: {0}", rect.GetArea());
        }
    }
}
