using LeetCode.AlgorithmicProblems.Core;

namespace LeetCode.AlgorithmicProblems.Problems.PalindromeNumber
{
    public static class ProblemFactory
    {
        public static IProblem<int, bool> GetProblemSolver(string type)
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
