using LeetCode.AlgorithmicProblems.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.AlgorithmicProblems.Problems.MergeTwoSortedLists;

namespace LeetCode.AlgorithmicProblems.Problems.MergeTwoSortedLists
{
    public static class ProblemFactory
    {
        public static IProblem<(LinkedListNode<int>, LinkedListNode<int>), LinkedListNode<int>> GetProblemSolver(string type)
        {
            return type switch
            {
                "A" => new SolutionA(),
                _ => throw new ArgumentException("Invalid problem type")
            };
        }
    }
}
