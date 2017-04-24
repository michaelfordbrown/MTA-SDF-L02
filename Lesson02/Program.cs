using System;
using System.Collections.Generic;

namespace Lesson02
{
    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Polygon");
        }
    }

    class Rectangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing: Rectangle");
        }
    }
    class Triangle : Polygon
    {
        public override void Draw()
        {
            base.Draw();
            {
                Console.WriteLine("Drawing: Triangle");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle());
            polygons.Add(new Triangle());

            foreach (Polygon p in polygons)
            {
                p.Draw();
            }
        }

    }
}
