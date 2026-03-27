namespace FunctionalProgramming.Tests;
using Shouldly;

public class Add10Test
{
    [Test]
    public void AddTen_ReturnsInputPlusTen()
    {
        int input = 5;
        int expected = 15;
        int result = Exercises001.AddTen(input);
        result.ShouldBe(expected);
    }
}
