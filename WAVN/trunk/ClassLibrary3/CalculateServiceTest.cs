using NUnit.Framework;

namespace WAVN.Services.Tests
{
    public class CalculateServiceTest
    {
        [TestFixture]
        public class CalculatorTest
        {
            [Test]
            public void Shoul_Calculate_When_Pass_Null()
            {
                var instance = new CalculateService();

                int expectedResult = instance.Calculate(null);
                Assert.That(expectedResult, Is.EqualTo(0));
            }

            [Test]
            public void Shoul_Calculate_When_Pass_String_Comma_Separated()
            {
                var instance = new CalculateService();

                int expectedResult = instance.Calculate("1,2,3,4");
                Assert.That(expectedResult, Is.EqualTo(10));
            }
        }
    }
}
