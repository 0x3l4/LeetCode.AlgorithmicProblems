using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using LeetCode.AlgorithmicProblems.Problems.ValidParantheses;

namespace LeetCode.AlgorithmicProblems.Tests.TestCases
{
    public class ValidParanthesesTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        [Trait("ValidParantheses", "A")]
        public void SolutionA_ShouldReturnCorrectResult(ValidParanthesesInput input, ValidParanthesesOutput expected)
        {
            var problem = ProblemFactory.GetProblemSolver("A");
            Assert.Equal(expected.IsValid, problem.Solve(input).IsValid);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            var loader = new ValidParanthesesDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return new object[] { item.Input!, item.Expected! };
            }
        }
    }
}
