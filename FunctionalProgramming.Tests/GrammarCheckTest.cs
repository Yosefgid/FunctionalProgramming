namespace FunctionalProgramming.Tests;
using Shouldly;

public class GrammarCheckTest
{
 
    [Test]
    public void GrammarCheck_ReturnsTrueIfConditionsIsValid()
    {
        string input = "";
        string input1 = "America!";
        string input2 = "america";
        string input3 = "America";
        bool result = Exercises001.GrammarCheck(input);
        bool result1 = Exercises001.GrammarCheck(input1);
        bool result2 = Exercises001.GrammarCheck(input2);
        bool result3 = Exercises001.GrammarCheck(input3);
        result.ShouldBeFalse();
        result1.ShouldBeTrue();
        result2.ShouldBeFalse();
        result3.ShouldBeFalse();
    }
}
