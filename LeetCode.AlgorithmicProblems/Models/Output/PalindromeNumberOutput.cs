﻿
namespace LeetCode.AlgorithmicProblems.Models.Output
{
    public class PalindromeNumberOutput
    {
        public bool IsPalindrome { get; set; }

        public override string ToString()
        {
            return $"IsPalindrome: {IsPalindrome}";
        }
    }
}
