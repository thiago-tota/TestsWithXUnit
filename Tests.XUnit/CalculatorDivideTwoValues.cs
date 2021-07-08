using System;
using Tests.Core;
using Xunit;

namespace Tests.XUnit
{
    public class CalculatorDivideTwoValues
    {
        private readonly Calculator _calculator;

        public CalculatorDivideTwoValues()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void GivenDivisorIsZeroThenReturnError()
        {
            var capturedException = Assert.Throws<DivideByZeroException>(() => _calculator.DivideTwoValues(10, 0));

            const string expectedExceptionMessage = "Divisor cannot be 0 (zero)";
            Assert.Equal(expectedExceptionMessage, capturedException.Message);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(50.4, 3.9, 12.92)]
        [InlineData(-10, 2, -5)]
        [InlineData(-10, -2, 5)]
        public void GivenDivisorDifferentOfZeroThenReturnResult(decimal dividend, decimal divisor, decimal expectedValue)
        {
            var resultValue = _calculator.DivideTwoValues(dividend, divisor);

            Assert.Equal(expectedValue, Math.Round(resultValue, 2));
        }
    }
}
