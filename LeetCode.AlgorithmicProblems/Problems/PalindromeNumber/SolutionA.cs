using LeetCode.AlgorithmicProblems.Core;

namespace LeetCode.AlgorithmicProblems.Problems.PalindromeNumber
{
    public class SolutionA : IProblem<int, bool>
    {
        public string ProblemName => "Palindrome number - Solution A";

        public bool Solve(int input)
        {
            string convertedInput = input.ToString();
            return convertedInput == new string(convertedInput.Reverse().ToArray());
        }
    }
}
