using BenchmarkDotNet.Running;

namespace LeetCode.AlgorithmicProblems.Benchmarks
{
    internal class BenchmarkRunner
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher
            .FromAssembly(typeof(BenchmarkRunner).Assembly)
            .Run(args);
        }
    }
}
