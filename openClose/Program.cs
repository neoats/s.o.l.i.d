using openClose.shapes;

namespace openClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Shaper shaper = new Shaper();
            Triangle triangle = new Triangle();
            shaper.ShapeCalculator(triangle,3,4,5,4);

            #region triangle
            //Triangle triangle = new Triangle { Side1 = 3, Side2 = 4, Height = 5, Tbase = 4 };
            //double area = triangle.CalculateArea();
            //double perimeter = triangle.CalculatePerimeter();

            //Console.WriteLine("Area of Triangle " + area);
            //Console.WriteLine("Perimeter of Triangle " + perimeter);
            #endregion


        }
    }
}