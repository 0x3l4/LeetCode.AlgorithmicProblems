using LeetCode.AlgorithmicProblems.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.AlgorithmicProblems.Problems.ValidParantheses;

namespace LeetCode.AlgorithmicProblems.Problems.ValidParantheses
{
    public static class ProblemFactory
    {
        public static IProblem<string, bool> GetProblemSolver(string type)
        {
            return type switch
            {
                "A" => new SolutionA(),
                _ => throw new ArgumentException("Invalid problem type")
            };
        }
    }
}
