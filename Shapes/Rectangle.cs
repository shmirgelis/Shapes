using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        double side1 = 4;
        double side2 = 5;
        public override void Area()
        {
            Console.WriteLine($" Rectangle area is {side1 * side2}");
        }

        public override void Perimeter()
        {
            Console.WriteLine($" Rectangle perimeter is {2 * (side1 + side2)}");
        }
    }
}

