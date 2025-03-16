using LeetCode.AlgorithmicProblems.DataStructures;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using LeetCode.AlgorithmicProblems.Services;
using System.Globalization;
using System.Net;

namespace LeetCode.AlgorithmicProblems
{
    internal class Program
    {
        public static void Main()
        {
            //var problem = Problems.TwoSum.ProblemFactory.GetProblemSolver("B");
            //var runner = new ProblemRunner<TwoSumInput, TwoSumOutput>(problem);

            //runner.Run(new TwoSumInput() { Numbers = [3, 3], Target = 6 });
            
            DataStructures.Lists.LinkedList<int> listA = new([0, 1, 2, 3, 4]);
            DataStructures.Lists.LinkedList<int> listB = new([3, 15, 7, 2, 14]);

            var mergeTwoSortedListsInput = new MergeTwoSortedListsInput() { ListA = listA.Find(0), ListB = listB.Find(3) };

            Console.WriteLine(mergeTwoSortedListsInput);
        }
    }
}