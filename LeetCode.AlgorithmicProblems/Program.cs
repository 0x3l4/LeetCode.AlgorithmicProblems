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
            var problem = Problems.TwoSum.ProblemFactory.GetProblemSolver("A");
            var runner = new ProblemRunner<TwoSumInput, TwoSumOutput>(problem);

            runner.Run(new TwoSumInput() { Numbers = [1, 2, 4, 3], Target = 7 });
        }
    }
}