using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClose.shapes
{
    internal class Square : shapeBase
    {
        public double side { get; set; }
        public override double CalculateArea()
        {
            return side * side;
        }

        public override double CalculatePerimeter()
        {
            return side * 4;
        }
    }
}
