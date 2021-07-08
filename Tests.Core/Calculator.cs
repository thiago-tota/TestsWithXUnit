using System;

namespace Tests.Core
{
    public class Calculator
    {
        public int SumTwoValues(int valueA, int valueB)
        {
            return valueA + valueB;
        }

        public decimal DivideTwoValues(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Divisor cannot be 0 (zero)");

            return dividend / divisor;
        }
    }
}
