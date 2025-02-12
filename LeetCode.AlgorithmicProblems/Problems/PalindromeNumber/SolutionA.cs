using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Problems.PalindromeNumber
{
    public class SolutionA : IProblem<PalindromeNumberInput, PalindromeNumberOutput>
    {
        public string ProblemName => "Palindrome Number - Solution A";

        public PalindromeNumberOutput Solve(PalindromeNumberInput input)
        {
            string convertedInput = input.Number.ToString();
            return new() { IsPalindrome = convertedInput == new string(convertedInput.Reverse().ToArray()) };
        }
    }
}
