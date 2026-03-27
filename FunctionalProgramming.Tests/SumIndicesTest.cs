namespace FunctionalProgramming.Tests;
using Shouldly;

public class SumIndicesTest
{

    [Test]
    public void SumIndices_ReturnsSumOFIndexA_andIndexE()
    {
        string input1 = "layer";
        string input2 = "more";
        int expected = 4;

        int result = Exercises001.SumIndices(input1, input2);
        result.ShouldBe(expected);


    }
}
