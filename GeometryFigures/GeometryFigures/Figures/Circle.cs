namespace GeometryFigures.Figures;

public class Circle : Figure
{
    public readonly double Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("radius can`t be zero or less than zero");
        Radius = radius;
    }

    public override double GetSquare()
    {
        return Math.PI * Radius * Radius;
    }
}