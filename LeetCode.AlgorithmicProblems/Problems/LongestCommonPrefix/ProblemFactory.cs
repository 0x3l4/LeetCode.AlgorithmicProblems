using LeetCode.AlgorithmicProblems.Core;

namespace LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix
{
    public static class ProblemFactory
    {
        public static IProblem<string[], string> GetProblemSolver(string type)
        {
            return type switch
            {
                "A" => new SolutionA(),
                _ => throw new ArgumentException("Invalid problem type")
            };
        }
    }
}
