using LeetCode.AlgorithmicProblems.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.MergeTwoSortedLists
{
    public class SolutionA : IProblem<(LinkedListNode<int>, LinkedListNode<int>), LinkedListNode<int>>
    {
        public string ProblemName => "Merge Two Sorted Lists - Solution A";

        public LinkedListNode<int> Solve((LinkedListNode<int>, LinkedListNode<int>) input)
        {
            LinkedListNode<int> node = new(default);

            return node;
        }
    }
}
