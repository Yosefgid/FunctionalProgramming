namespace FunctionalProgramming.Tests;
using Shouldly;

public class Tests
{
    [Test]
    public void SquareIt_ReturnsSquaredValue()
    {
        int input = 2;
        int expected = 4;
        int result = Exercises001.SquareIt(input);
        result.ShouldBe(expected);
    }
}