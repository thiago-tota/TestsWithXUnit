using System;
using Xunit;
using Tests.Core;

namespace Tests.XUnit
{
    public class CalculatorSumTwoValues
    {
        private readonly Calculator _calculator;

        public CalculatorSumTwoValues()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void GivenTwoValuesThenReturnSumResult()
        {
            var result = _calculator.SumTwoValues(3, 5);

            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(-10, 50, 40)]
        [InlineData(-20, -30, -50)]
        public void GivenTwoValuesThenSumResultUsingInLineData(int valueA, int valueB, int valueExpected)
        {
            var result = _calculator.SumTwoValues(valueA, valueB);

            Assert.Equal(valueExpected, result);
        }


        [Theory]
        [ClassData(typeof(SumTwoValuesTestData))]
        public void GivenTwoValuesThenSumResultUsingClassData(int valueA, int valueB, int valueExpected)
        {
            var result = _calculator.SumTwoValues(valueA, valueB);

            Assert.Equal(valueExpected, result);
        }

        [Theory]
        [MemberData(nameof(GeneralTestData.GetSumTwoValuesData), MemberType = typeof(GeneralTestData))]
        public void GivenTwoValuesThenSumResultUsingMemberData(int valueA, int valueB, int valueExpected)
        {
            var result = _calculator.SumTwoValues(valueA, valueB);

            Assert.Equal(valueExpected, result);
        }
    }
}
