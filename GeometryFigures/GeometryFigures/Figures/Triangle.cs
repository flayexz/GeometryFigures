namespace GeometryFigures.Figures;

public class Triangle : Figure
{
    public readonly double A;
    public readonly double B;
    public readonly double C;

    private double[] AscendingSides => new[] { A, B, C }.OrderBy(x => x).ToArray();

    private static bool IsTriangleValid(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    public bool IsRight()
    {
        return Math.Abs(AscendingSides[2] * AscendingSides[2] - AscendingSides[1] * AscendingSides[1] -
                        AscendingSides[0] * AscendingSides[0]) < 0.001;
    }

    public Triangle(double a, double b, double c)
    {
        if (!IsTriangleValid(a, b, c))
            throw new ArgumentException("invalid triangle side or sides");
        A = a;
        B = b;
        C = c;
    }

    private double GetSquareBySides()
    {
        var semiPerimeter = (A + B + C) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
    }
    
    public override double GetSquare()
    {
        return GetSquareBySides();
    }
}