using LeetCode.AlgorithmicProblems.Core;

namespace LeetCode.AlgorithmicProblems.Services
{
    public class ProblemRunner<TInput, TOutput>
    {
        private readonly IProblem<TInput, TOutput> _problem;

        public ProblemRunner(IProblem<TInput, TOutput> problem)
        {
            _problem = problem;
        }

        public void Run(TInput input)
        {
            TOutput result = _problem.Solve(input);

            Console.WriteLine($"Running {_problem.ProblemName}");
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Result: {result}");
        }
    }
}
