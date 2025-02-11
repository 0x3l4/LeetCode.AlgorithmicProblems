using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Problems.RomanToInteger;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;

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
        public int SolutionA(string romanNumber) => _solutionA.Solve(romanNumber);

        public IEnumerable<string?> GetTestData()
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
