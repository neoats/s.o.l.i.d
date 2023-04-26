using openClose.shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = openClose.shapes.Rectangle;

namespace openClose
{
    public class Shaper
    {
        public void ShapeCalculator(shapeBase sbase, params double[] measurements)
        {
            if (sbase is Circle)
            {
                Circle circle = new Circle();
                circle.Radius = measurements[0];

                double area = circle.CalculateArea();
                double perimeter = circle.CalculatePerimeter();

                PrintResult("Çemberin", area, perimeter);
            }
            else if (sbase is Triangle)
            {
                Triangle triangle = new Triangle();
                triangle.Tbase = measurements[0];
                triangle.Height = measurements[1];
                triangle.Side1 = measurements[2];
                triangle.Side2 = measurements[3];


                double area = triangle.CalculateArea();
                double perimeter = triangle.CalculatePerimeter();

                PrintResult("Üçgenin", area, perimeter);
            }

            else if (sbase is Rectangle)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Height = measurements[0];
                rectangle.Width = measurements[1];
                double area = rectangle.CalculateArea();
                double perimeter = rectangle.CalculatePerimeter();

                PrintResult("Dikdörtgenin", area, perimeter);
            }
            else if (sbase is Square)
            {
                Square square = new Square();
                square.side = measurements[0];
                double area = square.CalculateArea();
                double perimeter = square.CalculatePerimeter();

                PrintResult("Kare'nin", area, perimeter);
            }
            else if (sbase is Pentagon)
            {
                Pentagon pentagon = new Pentagon();
                pentagon.Side = measurements[0];
                pentagon.Height = measurements[1];

                double area = pentagon.CalculateArea();
                double perimeter = pentagon.CalculatePerimeter();

                PrintResult("Beşgenin", area, perimeter);
            }

        }
        private void PrintResult(string shapeName, double area, double perimeter)
        {   //dryed
            Console.WriteLine($"{shapeName} alanı: {area}");
            Console.WriteLine($"{shapeName} çevresi: {perimeter}");
        }

    }

}
