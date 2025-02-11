using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.AlgorithmicProblems.Problems.ValidParantheses;

namespace LeetCode.AlgorithmicProblems.Benchmarks.Benchmarks
{
    [SimpleJob]
    [RPlotExporter, HtmlExporter, CsvExporter]
    [MemoryDiagnoser]
    public class ValidParanthesesBenchmarks
    {
        private readonly SolutionA _solutionA = new();

        [Benchmark]
        [ArgumentsSource(nameof(GetTestData))]
        public bool SolutionA(string parantheses) => _solutionA.Solve(parantheses);

        public IEnumerable<string?> GetTestData()
        {
            var loader = new ValidParanthesesDataLoader();
            var data = loader.LoadData();

            foreach (var item in data)
            {
                yield return item.Input;
            }
        }
    }
}
