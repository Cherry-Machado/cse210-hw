using System.Reflection.Metadata;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    //Here is the override.
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}