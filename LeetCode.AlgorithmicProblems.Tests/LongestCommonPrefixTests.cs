using LeetCode.AlgorithmicProblems.Tests.TestData;
using LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix;

namespace LeetCode.AlgorithmicProblems.Tests
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [ClassData(typeof(LongestCommonPrefixTestData))]
        public void SolutionA_ShouldExecuteCorrectly(string[] inputStrings, string expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected, problem.Solve(inputStrings));
        }
    }
}
