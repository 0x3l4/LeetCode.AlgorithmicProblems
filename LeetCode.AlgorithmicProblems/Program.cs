using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using LeetCode.AlgorithmicProblems.Services;
using System.Globalization;

namespace LeetCode.AlgorithmicProblems
{
    internal class Program
    {
        public static void Main()
        {
            var problem = Problems.TwoSum.ProblemFactory.GetProblemSolver("B");
            var runner = new ProblemRunner<TwoSumInput, TwoSumOutput>(problem);

            runner.Run(new TwoSumInput() { Numbers = [3, 3], Target = 6 });
        }
    }
}