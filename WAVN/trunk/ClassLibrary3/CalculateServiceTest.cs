using NUnit.Framework;

namespace WAVN.Services.Tests
{
    public class CalculateServiceTest
    {
        [TestFixture]
        public class CalculatorTest
        {
            [Test]
            public void Should_Calculate_When_Pass_Null()
            {
                var instance = new CalculateService();

                int expectedResult = instance.Calculate(null);
                Assert.That(expectedResult, Is.EqualTo(0));
            }

            [Test]
            public void Should_Calculate_When_Pass_String_Comma_Separated()
            {
                var instance = new CalculateService();
                
                int expectedResult = instance.Calculate("1,2,3,4");
                Assert.That(expectedResult, Is.EqualTo(10));
            }

            [Test]
            public void Should_Calculate_When_Pass_String_Any_Symbol_Separated()
            {
                var instance = new CalculateService();

                int expectedResult = instance.Calculate("1;2,3+4");
                Assert.That(expectedResult, Is.EqualTo(10));
            }

            [Test]
            public void Should_Calculate_More_Then_One_Digit_Format_When_Pass_String_Any_Symbol_Separated()
            {
                var instance = new CalculateService();

                int expectedResult = instance.Calculate("12,34");
                Assert.That(expectedResult, Is.EqualTo(46));
            }
        }
    }
}
