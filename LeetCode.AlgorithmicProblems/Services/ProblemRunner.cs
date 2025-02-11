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
            string? formattedInput = FormatData(input);
            TOutput result = _problem.Solve(input);
            string? formattedResult = FormatData(result);

            Console.WriteLine($"Running {_problem.ProblemName}");
            Console.WriteLine($"Input: {formattedInput}");
            Console.WriteLine($"Result: {formattedResult}");
        }

        private static string? FormatData<T>(T data)
        {
            return data switch
            {
                null => "null",
                Array array when array.Rank == 1 => $"[{string.Join(", ", array.Cast<object>())}]",
                Array array => FormatMultiDimensionalArray(array),
                _ => data.ToString()
            };
        }

        private static string FormatMultiDimensionalArray(Array array)
        {
            var elements = new List<string>();

            foreach (var item in array)
            {
                elements.Add(item?.ToString() ?? "null");
            }

            string dimensions = string.Join("][", Enumerable.Range(0, array.Rank)
                .Select(d => array.GetLength(d).ToString()));

            return $"[{dimensions}] Elements: [{string.Join(", ", elements)}]";
        }

    }
}
