using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix
{
    public static class ProblemFactory
    {
        public static IProblem<LongestCommonPrefixInput, LongestCommonPrefixOutput> GetProblemSolver(string type)
        {
            return type switch
            {
                "A" => new SolutionA(),
                "B" => new SolutionB(),
                _ => throw new ArgumentException("Invalid problem type")
            };
        }
    }
}
