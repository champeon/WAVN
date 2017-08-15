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
        }
    }
}
