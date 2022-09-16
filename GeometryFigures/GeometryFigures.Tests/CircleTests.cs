using System;
using GeometryFigures.Figures;
using Xunit;

namespace GeometryFigures.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1,Math.PI)]
    [InlineData(2,12.566370614359)]
    [InlineData(12302131231233,4.7545627515663755e+26)]
    public void GetCircleSquare_IntegerRadius(double radius, double expected)
    {
        var circle = new Circle(radius);
        TestHelper.CheckSquare(circle, expected);
    }
    

    [Theory]
    [InlineData(0.99,3.079074959783356)]
    [InlineData(1.25,4.908738521234052)]
    [InlineData(12313.12312313,476306290.27280056)]
    public void GetCircleSquare_FractionalRadius(double radius, double expected)
    {
        var circle = new Circle(radius);
        TestHelper.CheckSquare(circle, expected);
    }
    
    [Fact]
    public void LessThanZeroRadius_InvalidArgumentExceptionThrow()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    
    [Fact]
    public void ZeroRadius_InvalidArgumentExceptionThrow()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
}