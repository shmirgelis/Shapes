using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        double side = 4;
        public override void Area()
        {
            Console.WriteLine($" Square area is {side * side}");
        }

        public override void Perimeter()
        {
            Console.WriteLine($" Square perimeter is {4 * side}");
        }
    }
}
