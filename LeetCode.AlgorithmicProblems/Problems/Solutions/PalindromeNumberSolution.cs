using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.Solutions
{
    /// <summary>
    /// Given an integer x, return true if x is a palindrome, and false otherwise.
    /// Level: Easy
    /// </summary>
    internal class PalindromeNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            bool isPalindrome = false;

            int power = 1;
            int reversedNumber = 0;
            x = Math.Abs(x);
            int startX = x;
            int remainderOfNumber;

            //int digits = 0;

            //while (startX > 0)
            //{
            //    startX /= 10;

            //    digits++;
            //}

            while (x > 0 && !isPalindrome)
            {
                remainderOfNumber = x % 10;
                reversedNumber = reversedNumber * 10 + remainderOfNumber;
                x /= 10;

                if (reversedNumber == startX)
                {
                    isPalindrome = true;
                }
            }

            return isPalindrome;
        }
    }
}
