using System;
using GeometryFigures.Figures;
using Xunit;

namespace GeometryFigures.Tests;

public static class TestHelper
{
    private const double Delta = 1e-4;
    public static void CheckSquare(Figure figure, double expected)
    {
        var square = figure.GetSquare();
        var areEqual = Math.Abs(square - expected) < Delta;
        Assert.True(areEqual, $"expected square: {expected} but was: {square}");
    }
}