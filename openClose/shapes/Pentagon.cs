namespace openClose.shapes;

public class Pentagon : shapeBase
{
    public double Side { get; set; }
    public double Height { get; set; }


    public override double CalculateArea()
    {
        return 5 * ((Side * Height) / 2);
    }

    public override double CalculatePerimeter()
    {
        return Side * 5;
    }
}