using LeetCode.AlgorithmicProblems.Services;

namespace LeetCode.AlgorithmicProblems
{
    internal class Program
    {
        public static void Main()
        {
            var problem = Problems.RomanToInteger.ProblemFactory.GetProblemSolver("A");
            var runner = new ProblemRunner<string, int>(problem);

            runner.Run("DM");
        }
    }
}