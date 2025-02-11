using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Problems.PalindromeNumber;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;

namespace LeetCode.AlgorithmicProblems.Benchmarks.Benchmarks
{
    [SimpleJob]
    [RPlotExporter, HtmlExporter, CsvExporter]
    [MemoryDiagnoser]
    public class PalindromeNumberBenchmarks
    {
        private readonly SolutionA _solutionA = new();
        private readonly SolutionB _solutionB = new();

        [Benchmark]
        [ArgumentsSource(nameof(GetTestData))]
        public bool SolutionA(int number) => _solutionA.Solve(number);

        [Benchmark]
        [ArgumentsSource(nameof(GetTestData))]
        public bool SolutionB(int number) => _solutionB.Solve(number);

        public IEnumerable<int> GetTestData()
        {
            var loader = new PalindromeNumberDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return item.Input;
            }
        }
    }
}
