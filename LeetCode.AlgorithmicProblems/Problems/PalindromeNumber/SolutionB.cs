using LeetCode.AlgorithmicProblems.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.PalindromeNumber
{
    public class SolutionB : IProblem<int, bool>
    {
        public string ProblemName => "Palindrome number - Solution B";

        public bool Solve(int input)
        {
            if (input < 0)
            {
                return false;
            }
            if (input == 0)
            {
                return true;
            }

            bool isPalindrome = false;

            int reversedNumber = 0;
            int startX = input;
            int remainderOfNumber;

            while (input > 0 && !isPalindrome)
            {
                remainderOfNumber = input % 10;
                
                try
                {
                    reversedNumber = checked(reversedNumber * 10 + remainderOfNumber);
                }
                catch (OverflowException)
                {
                    return false;
                }

                input /= 10;

                if (reversedNumber == startX)
                {
                    isPalindrome = true;
                }
            }

            return isPalindrome;
        }
    }
}
