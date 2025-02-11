using LeetCode.AlgorithmicProblems.Problems.RomanToInteger;

namespace LeetCode.AlgorithmicProblems.Tests.TestCases
{
    public class RomanToIntegerTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("RomanToInteger", "B")]
        public void SolutionA_ShouldReturnCorrectResult(string romanNumber, int expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected, problem.Solve(romanNumber));
        }

        public static IEnumerable<object[]> GetTestData()
        {
            var loader = new RomanToIntegerDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return new object[] { item.Input!, item.Expected! };
            }
        }
    }
}
