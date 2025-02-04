using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Problems.PalindromeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix;

namespace LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix
{
    public static class ProblemFactory
    {
        public static IProblem<string[], string> GetProblemSolver(string type)
        {
            return type switch
            {
                "A" => new SolutionA(),
                _ => throw new ArgumentException("Invalid problem type")
            };
        }
    }
}
