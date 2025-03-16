using LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix;

namespace LeetCode.AlgorithmicProblems.Tests.TestCases
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("LongestCommonPrefix", "A")]
        public void SolutionA_ShouldReturnCorrectResult(LongestCommonPrefixInput input, LongestCommonPrefixOutput expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected.Prefix, problem.Solve(input).Prefix);
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("LongestCommonPrefix", "B")]
        public void SolutionB_ShouldReturnCorrectResult(LongestCommonPrefixInput input, LongestCommonPrefixOutput expected)
        {
            var problem = ProblemFactory.GetProblemSolver("B");
            Assert.Equal(expected.Prefix, problem.Solve(input).Prefix);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            var loader = new LongestCommonPrefixDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return new object[] { item.Input!, item.Expected! };
            }
        }
    }
}
