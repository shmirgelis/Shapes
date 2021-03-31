using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>()
            {
             new Square(),
             new Circle(),
             new Rectangle()
            };

            foreach(Shape geometricShape in shapeList)
            {
                Calculate(geometricShape);
            }

        }

        private static void Calculate(Shape shape)
        {
            shape.Area();
            shape.Perimeter();
            Console.WriteLine();

        }
    }


}
