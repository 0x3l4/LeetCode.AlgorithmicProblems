using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Problems.PalindromeNumber
{
    public static class ProblemFactory
    {
        public static IProblem<PalindromeNumberInput, PalindromeNumberOutput> GetProblemSolver(string type)
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
