﻿using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using LeetCode.AlgorithmicProblems.Problems.TwoSum;

namespace LeetCode.AlgorithmicProblems.Tests.TestCases
{
    public class TwoSumTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("TwoSum", "A")]
        public void SolutionA_ShouldReturnCorrectResult(TwoSumInput input, TwoSumOutput expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected.Indicies, problem.Solve(input).Indicies);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            var loader = new TwoSumDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return new object[] { item.Input!, item.Expected! };
            }
        }
    }
}
