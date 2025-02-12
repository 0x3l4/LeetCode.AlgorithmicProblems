using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.AlgorithmicProblems.Problems.TwoSum;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Benchmarks.Benchmarks
{
    [SimpleJob]
    [RPlotExporter, HtmlExporter, CsvExporter]
    [MemoryDiagnoser]
    public class TwoSumBenchmarks
    {
        private readonly SolutionA _solutionA = new();

        [Benchmark]
        [ArgumentsSource(nameof(GetTestData))]
        public TwoSumOutput SolutionA(TwoSumInput input) => _solutionA.Solve(input);

        public IEnumerable<TwoSumInput> GetTestData()
        {
            var loader = new TwoSumDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return item.Input;
            }
        }
    }
}
