using System;
using GeometryFigures.Figures;
using Xunit;

namespace GeometryFigures.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(10, 10, -5)]
    [InlineData(0, 0, 0)]
    [InlineData(10, 0, 5)]
    [InlineData(-12, 10, 0)]
    [InlineData(1, 2, 3)]
    public void InvalidSides_InvalidArgumentExceptionThrow(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Theory]
    [InlineData(2,3,4,2.904737)]
    [InlineData(43,123,123,2603.7867016136324)]
    public void GetTriangleSquare_IntegerSides(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);
        TestHelper.CheckSquare(triangle, expected);
    }
    
    [Theory]
    [InlineData(1.423,3.11,1.99999,1.09248546)]
    [InlineData(0.9999999,0.8787,0.76123, 0.3226)]
    public void GetTriangleSquare_FractionalSides(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);
        TestHelper.CheckSquare(triangle, expected);
    }

    [Theory]
    [InlineData(5,11.18033,10)]
    [InlineData(3,4,5)]
    public void IsRight_RightTriangle_TrueReturned(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        var isRight = triangle.IsRight();
        Assert.True(isRight);
    }
    
    [Theory]
    [InlineData(10,10,10)]
    [InlineData(5,12.18033,10)]
    [InlineData(4,3,6)]
    public void IsRight_NotRightTriangle_FalseReturned(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        var isRight = triangle.IsRight();
        Assert.False(isRight);
    }
}