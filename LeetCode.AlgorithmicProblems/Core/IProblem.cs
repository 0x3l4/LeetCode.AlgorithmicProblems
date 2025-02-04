using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Core
{
    public interface IProblem<TInput, TOutput>
    {
        string ProblemName { get; }
        TOutput Solve(TInput input);
    }
}
