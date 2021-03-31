using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        double radius = 5;
        double pi = 3.1416;
        public override void Area()
        {
            Console.WriteLine($" Circle area is {pi*(radius * radius)}");
        }

        public override void Perimeter()
        {
            Console.WriteLine($" Circle perimeter is {2 * pi * radius}");
        }
    }
}
