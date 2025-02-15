using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
