using System.Collections.Generic;

namespace Tests.XUnit
{
    public static class GeneralTestData
    {
        public static IEnumerable<object[]> GetSumTwoValuesData()
        {
            return new List<object[]>
            {
                new object[] { 5, 5, 10 },
                new object[] { -10, 40, 30 },
                new object[] { -20, -30, -50 },
                new object[] { 100, -20, 80 }
            };
        }
    }
}
