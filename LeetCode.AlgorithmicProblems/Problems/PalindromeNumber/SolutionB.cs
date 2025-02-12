using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Problems.PalindromeNumber
{
    public class SolutionB : IProblem<PalindromeNumberInput, PalindromeNumberOutput>
    {
        public string ProblemName => "Palindrome Number - Solution B";

        public PalindromeNumberOutput Solve(PalindromeNumberInput input)
        {
            if (input.Number < 0)
            {
                return new() { IsPalindrome = false };
            }
            if (input.Number == 0)
            {
                return new() { IsPalindrome = true };
            }

            bool isPalindrome = false;

            int reversedNumber = 0;
            int startX = input.Number;
            int remainderOfNumber;

            while (input.Number > 0 && !isPalindrome)
            {
                remainderOfNumber = input.Number % 10;
                
                try
                {
                    reversedNumber = checked(reversedNumber * 10 + remainderOfNumber);
                }
                catch (OverflowException)
                {
                    return new() { IsPalindrome = false };
                }

                input.Number /= 10;

                if (reversedNumber == startX)
                {
                    isPalindrome = true;
                }
            }

            return new() { IsPalindrome = isPalindrome };
        }
    }
}
