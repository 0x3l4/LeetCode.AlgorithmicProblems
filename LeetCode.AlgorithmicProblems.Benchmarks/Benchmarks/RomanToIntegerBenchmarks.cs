using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Problems.RomanToInteger;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Benchmarks.Benchmarks
{
    [SimpleJob]
    [RPlotExporter, HtmlExporter, CsvExporter]
    [MemoryDiagnoser]
    public class RomanToIntegerBenchmarks
    {
        private readonly SolutionA _solutionA = new();

        [Benchmark]
        [ArgumentsSource(nameof(GetTestData))]
        public RomanToIntegerOutput SolutionA(RomanToIntegerInput input) => _solutionA.Solve(input);

        public IEnumerable<RomanToIntegerInput> GetTestData()
        {
            var loader = new RomanToIntegerDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return item.Input;
            }
        }
    }
}
