using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Rectangle
    {
        private double length;
        private double width;

        /*  no validation checks */
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
        
        public double GetArea()
        {
            return length * width;
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
