using Xunit;
using console_app_tests;

namespace console_app_tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void ReturnFalseGivenValueOf2()
        {
            var result = _primeService.IsPrime(2);

            Assert.False(result, "2 should not be prime");
        }
        
        [Fact]
        public void ReturnFalseGivenValueOf4()
        {
            var result = _primeService.IsPrime(4);

            Assert.False(result, "4 should not be prime");
        }

        [Fact]
        public void ReturnTrueGivenValueOf3()
        {
            var result = _primeService.IsPrime(3);

            Assert.True(result, "3 should be prime");
        }
    }
}