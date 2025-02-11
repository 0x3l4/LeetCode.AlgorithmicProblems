using LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix;

namespace LeetCode.AlgorithmicProblems.Tests.TestCases
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("LongestCommonPrefix", "A")]
        public void SolutionA_ShouldReturnCorrectResult(string[] words, string expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected, problem.Solve(words));
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
