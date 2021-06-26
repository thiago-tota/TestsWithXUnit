using System.Collections;
using System.Collections.Generic;

namespace Tests.XUnit
{
    public class SumTwoValuesTestData : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 5, 5, 10 };
            yield return new object[] { -10, 40, 30 };
            yield return new object[] { -20, -30, -50 };
            yield return new object[] { 100, -20, 80 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
