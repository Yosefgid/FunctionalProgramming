namespace FunctionalProgramming.Tests;
using Shouldly;

public class CheckValidEmailTest
{
    [Test]
    public void CheckValidEmail_ReturnsifValid_When_EmailValid()
    {
        string email = "MarkPiler@northcoders.co.uk";
        string result = Exercises001.CheckValidEmail(email);

        result.ShouldBe(Exercises001.ifValid);


    }

    [Test]
    public void CheckValidEmail_ReturnsifnotValidMessage_When_EmailInvalid()
    {
        string email = "yos@northcoders.co.uk";
        string result = Exercises001.CheckValidEmail(email);
        result.ShouldBe(Exercises001.ifValid);
        //This is an Red becuase we wanted it to fail making sure we do not get any false positive

    }
}