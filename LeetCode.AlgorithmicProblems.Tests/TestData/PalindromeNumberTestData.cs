using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Tests.TestData
{
    public class PalindromeNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { int.MinValue, false };
            yield return new object[] { -2087667802, false };
            yield return new object[] { -121, false };
            yield return new object[] { -10, false };
            yield return new object[] { 0, true };
            yield return new object[] { 10, false };
            yield return new object[] { 121, true };
            yield return new object[] { 123, false };
            yield return new object[] { 12321, true };
            yield return new object[] { 4554, true };
            yield return new object[] { 2022, false };
            yield return new object[] { 2087667802, true };
            yield return new object[] { int.MaxValue, false };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
