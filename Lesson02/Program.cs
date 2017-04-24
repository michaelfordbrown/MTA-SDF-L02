using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Rectangle
    {
        public event EventHandler Changed;
        private double length;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                Changed(this, EventArgs.Empty);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Changed += new EventHandler(r_Changed);
            r.Length = 10;
        }

        static void r_Changed(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            Console.WriteLine("Value Changed: Length {0}", r.Length);
        }
    }
}
