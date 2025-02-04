using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Services;
using System.Runtime.CompilerServices;
using LeetCode.AlgorithmicProblems.Problems;

namespace LeetCode.AlgorithmicProblems
{
    internal class Program
    {
        public static void Main()
        {
            var problem = Problems.PalindromeNumber.ProblemFactory.GetProblemSolver("A");
            var runner = new ProblemRunner<int, bool>(problem);

            runner.Run(2087667802);
            //Console.WriteLine("2087667802".Reverse().ToArray());

        }
    }
}