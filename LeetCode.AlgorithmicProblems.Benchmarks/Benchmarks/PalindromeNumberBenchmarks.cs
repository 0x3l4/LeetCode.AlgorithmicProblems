﻿using BenchmarkDotNet.Attributes;
using LeetCode.AlgorithmicProblems.Problems.PalindromeNumber;
using LeetCode.AlgorithmicProblems.Data.DataLoaders;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

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
        public PalindromeNumberOutput SolutionA(PalindromeNumberInput input) => _solutionA.Solve(input);

        [Benchmark]
        [ArgumentsSource(nameof(GetTestData))]
        public PalindromeNumberOutput SolutionB(PalindromeNumberInput input) => _solutionB.Solve(input);

        public IEnumerable<PalindromeNumberInput> GetTestData()
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
