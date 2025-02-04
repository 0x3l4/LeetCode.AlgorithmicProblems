using LeetCode.AlgorithmicProblems.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
