using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Tests.TestData
{
    public class RomanToIntegerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "VI", 6 };
            yield return new object[] { "XVII", 17 };
            yield return new object[] { "XL", 40 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
