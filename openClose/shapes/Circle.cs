using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClose.shapes
{

        public class Circle : shapeBase
        {
            public double Radius { get; set; } 
            
            public override double CalculatePerimeter()
            {
              return Math.PI * Radius * 2;
            }
            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

           
        }
}
