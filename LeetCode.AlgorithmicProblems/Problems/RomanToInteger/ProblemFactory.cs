using LeetCode.AlgorithmicProblems.Core;

namespace LeetCode.AlgorithmicProblems.Problems.RomanToInteger
{
    public static class ProblemFactory
    {
        public static IProblem<string, int> GetProblemSolver(string type)
        {
            return type switch
            {
                "A" => new SolutionA(),
                _ => throw new ArgumentException("Invalid problem type")
            };
        }
    }
}
