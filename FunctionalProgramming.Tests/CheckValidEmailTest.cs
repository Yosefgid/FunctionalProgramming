namespace FunctionalProgramming.Tests;
using Shouldly;

public class CheckValidEmailTest
{
//    [Test]
//    public void CheckValidEmail_ReturnsifValid_When_EmailValid()
//    {
//        string email = "MarkPiler@northcoders.co.uk";
//        string result = Exercises001.CheckValidEmail(email);

//        result.ShouldBe(Exercises001.ifValid);


//   

    [TestCase("MarkPiler@northcoders.co.uk")]
    [TestCase("yos@northcoders.co.uk")]
    public void CheckValidEmail_ReturnifValid_WhemEmailsValid(string email)
    {
        string result = Exercises001.CheckValidEmail(email);
        result.ShouldBe(Exercises001.ifValid);
    }


}