using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using LeetCode.AlgorithmicProblems.Problems.PalindromeNumber;

namespace LeetCode.AlgorithmicProblems.Tests.TestCases
{
    public class PalindromeNumberTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("PalindromeNumber", "A")]
        public void SolutionA_ShouldReturnCorrectResult(PalindromeNumberInput number, PalindromeNumberOutput expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected.IsPalindrome, problem.Solve(number).IsPalindrome);
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("PalindromeNumber", "B")]
        public void SolutionB_ShouldReturnCorrectResult(PalindromeNumberInput number, PalindromeNumberOutput expected)
        {
            var problem = ProblemFactory.GetProblemSolver("B");
            Assert.Equal(expected.IsPalindrome, problem.Solve(number).IsPalindrome);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            var loader = new PalindromeNumberDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return new object[] { item.Input!, item.Expected! };
            }
        }
    }
}
