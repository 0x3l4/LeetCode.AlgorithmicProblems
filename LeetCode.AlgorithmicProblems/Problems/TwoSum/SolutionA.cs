using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LeetCode.AlgorithmicProblems.Problems.TwoSum
{
    public class SolutionA : IProblem<TwoSumInput, TwoSumOutput>
    {
        public string ProblemName => "Two Sum - Solution A";

        public TwoSumOutput Solve(TwoSumInput input)
        {
            for (int i = 0; i < input.Numbers.Length; i++)
            {
                for (int j = i + 1; j < input.Numbers.Length; j++)
                {
                    if (input.Numbers[i] + input.Numbers[j] == input.Target)
                    {
                        return new TwoSumOutput() { Indicies = [i, j] };
                    }
                }
            }

            return null;
        }
    }
}
