using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.AlgorithmicProblems.Problems.ValidParantheses;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

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
        public ValidParanthesesOutput SolutionA(ValidParanthesesInput parantheses) => _solutionA.Solve(parantheses);

        public IEnumerable<ValidParanthesesInput> GetTestData()
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
