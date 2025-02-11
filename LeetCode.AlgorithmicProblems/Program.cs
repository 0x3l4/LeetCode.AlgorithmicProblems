using LeetCode.AlgorithmicProblems.Services;

namespace LeetCode.AlgorithmicProblems
{
    internal class Program
    {
        public static void Main()
        {
            var problem = Problems.ValidParantheses.ProblemFactory.GetProblemSolver("A");
            var runner = new ProblemRunner<string, bool>(problem);

            runner.Run("[(){()}]]");
        }
    }
}