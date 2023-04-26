namespace openClose.shapes;

public class Triangle : shapeBase
{
    public double Tbase { get; set; }
    public double Height { get; set; }
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public Triangle()
    {
        
    }
   

    public override double CalculateArea()
    {
        return (Tbase * Height)/2;
    }

    public override double CalculatePerimeter()
    {
        return Tbase+Side1+Side2;
    }
}
