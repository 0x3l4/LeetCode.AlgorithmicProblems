
namespace LeetCode.AlgorithmicProblems.Core
{
    public interface IProblem<TInput, TOutput>
    {
        string ProblemName { get; }
        TOutput Solve(TInput input);
    }
}
