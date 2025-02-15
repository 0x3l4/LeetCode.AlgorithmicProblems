using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.TwoSum
{
    public static class ProblemFactory
    {
        public static IProblem<TwoSumInput, TwoSumOutput> GetProblemSolver(string type)
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
