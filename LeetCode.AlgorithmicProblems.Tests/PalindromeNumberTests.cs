using LeetCode.AlgorithmicProblems.Problems.PalindromeNumber;
using LeetCode.AlgorithmicProblems.Tests.TestData;
using Xunit;

namespace LeetCode.AlgorithmicProblems.Tests
{
    public class PalindromeNumberTests
    {
        [Theory]
        [ClassData(typeof(PalindromeNumberTestData))]
        public void SolutionA_ShouldExecuteCorrectly(int number, bool expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected, problem.Solve(number));
        }

        [Theory]
        [ClassData(typeof(PalindromeNumberTestData))]
        public void SolutionB_ShouldExecuteCorrectly(int number, bool expected)
        {
            var problem = ProblemFactory.GetProblemSolver("B");
            Assert.Equal(expected, problem.Solve(number));
        }
    }
}
