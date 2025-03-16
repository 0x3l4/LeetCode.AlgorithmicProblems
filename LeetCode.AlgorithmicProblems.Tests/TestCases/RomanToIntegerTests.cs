using LeetCode.AlgorithmicProblems.Problems.RomanToInteger;

namespace LeetCode.AlgorithmicProblems.Tests.TestCases
{
    public class RomanToIntegerTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("RomanToInteger", "A")]
        public void SolutionA_ShouldReturnCorrectResult(RomanToIntegerInput romanNumber, RomanToIntegerOutput expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected.Number, problem.Solve(romanNumber).Number);
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
