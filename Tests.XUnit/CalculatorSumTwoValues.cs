using System;
using Xunit;
using Tests.Core;

namespace Tests.XUnit
{
    public class CalculatorSumTwoValues
    {
        [Fact]
        public void TwoValuesSumResult()
        {
            var calculator = new Calculator();
            var result = calculator.SumTwoValues(3, 5);

            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(-10, 50, 40)]
        [InlineData(-20, -30, -50)]
        public void TwoValuesSumResultInLineData(int valueA, int valueB, int valueExpected)
        {
            var calculator = new Calculator();
            var result = calculator.SumTwoValues(valueA, valueB);

            Assert.Equal(valueExpected, result);
        }


        [Theory]
        [ClassData(typeof(SumTwoValuesTestData))]
        public void TwoValuesSumResultClassData(int valueA, int valueB, int valueExpected)
        {
            var calculator = new Calculator();
            var result = calculator.SumTwoValues(valueA, valueB);

            Assert.Equal(valueExpected, result);
        }

        [Theory]
        [MemberData(nameof(GeneralTestData.GetSumTwoValuesData), MemberType = typeof(GeneralTestData))]
        public void TwoValuesSumResultMemberData(int valueA, int valueB, int valueExpected)
        {
            var calculator = new Calculator();
            var result = calculator.SumTwoValues(valueA, valueB);

            Assert.Equal(valueExpected, result);
        }
    }
}
