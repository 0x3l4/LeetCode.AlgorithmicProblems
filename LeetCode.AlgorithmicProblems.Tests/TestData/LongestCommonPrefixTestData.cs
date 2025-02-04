using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Tests.TestData
{
    public class LongestCommonPrefixTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new string[]{ "pref", "prefx", "pre", "press"}, "pre" };
            yield return new object[] { new string[]{ "pref", "prefx", "pre", "wordpre"}, "" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
