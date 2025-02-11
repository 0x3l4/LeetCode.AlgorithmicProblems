using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;

namespace LeetCode.AlgorithmicProblems.Benchmarks.Benchmarks
{
    [SimpleJob]
    [RPlotExporter, HtmlExporter, CsvExporter]
    [MemoryDiagnoser]
    public class LongestCommonPrefixBenchmarks
    {
        private readonly SolutionA _solutionA = new();

        [Benchmark]
        [ArgumentsSource(nameof(GetTestData))]
        public string SolutionA(string[] words) => _solutionA.Solve(words);

        public IEnumerable<string[]?> GetTestData()
        {
            var loader = new LongestCommonPrefixDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return item.Input;
            }
        }
    }
}
