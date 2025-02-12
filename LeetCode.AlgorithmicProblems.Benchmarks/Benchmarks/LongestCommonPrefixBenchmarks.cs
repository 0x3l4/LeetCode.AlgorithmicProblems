using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

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
        public LongestCommonPrefixOutput SolutionA(LongestCommonPrefixInput input) => _solutionA.Solve(input);

        public IEnumerable<LongestCommonPrefixInput> GetTestData()
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
