using LeetCode.AlgorithmicProblems.Tests.TestData;
using LeetCode.AlgorithmicProblems.Problems.RomanToInteger;

namespace LeetCode.AlgorithmicProblems.Tests
{
    public class RomanToIntegerTests
    {
        [Theory]
        [ClassData(typeof(RomanToIntegerTestData))]
        public void SolutionA_ShouldExecuteCorrectly(string romanNumber, int expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected, problem.Solve(romanNumber));
        }
    }
}
