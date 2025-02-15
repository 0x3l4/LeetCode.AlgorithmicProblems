using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Problems.TwoSum
{
    public class SolutionB : IProblem<TwoSumInput, TwoSumOutput>
    {
        public string ProblemName => "Two Sum - Solution B";

        public TwoSumOutput Solve(TwoSumInput input)
        {
            HashSet<int> values = [input.Numbers.First()];

            int[] indicies = new int[2];

            for (int i = 1; i < input.Numbers.Length; i++)
            {
                if (values.Contains(input.Target - input.Numbers[i]))
                {
                    indicies[0] = Array.IndexOf(input.Numbers, input.Target - input.Numbers[i]);
                    indicies[1] = i;
                    return new() { Indicies = indicies };
                }

                values.Add(input.Numbers[i]);
            }

            return null;
        }
    }
}
