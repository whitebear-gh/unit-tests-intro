using Xunit;
using console_app_tests;
using Moq;

namespace console_app_tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            var mock = new Mock<IDatabaseConnection>();
            mock.Setup(x=>x.CanCalculate()).Returns(true);
            _primeService = new PrimeService(mock.Object);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(9)]
        public void ReturnFalseGivenValueNotPrime(int val)
        {
            var result = _primeService.IsPrime(val);

            Assert.False(result, $"{val} should not be prime");
        }

        [Fact]
        public void ReturnTrueGivenValueOf3()
        {
            var result = _primeService.IsPrime(3);

            Assert.True(result, "3 should be prime");
        }

    }
}