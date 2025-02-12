using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.ValidParantheses
{
    public class SolutionA : IProblem<ValidParanthesesInput, ValidParanthesesOutput>
    {
        public string ProblemName => "Valid parantheses - Solution A";

        public ValidParanthesesOutput Solve(ValidParanthesesInput input)
        {
            Stack<char> parantheses = new Stack<char>();

            for (int i = 0; i < input.Parantheses.Length; i++)
            {
                if (input.Parantheses[i] == '(' || input.Parantheses[i] == '{' || input.Parantheses[i] == '[')
                {
                    parantheses.Push(input.Parantheses[i]);
                }
                else if (parantheses.Count > 0)
                {
                    char paranthesis = parantheses.Pop();

                    if (!(paranthesis == '(' && input.Parantheses[i] == ')' ||
                        paranthesis == '{' && input.Parantheses[i] == '}' ||
                        paranthesis == '[' && input.Parantheses[i] == ']'))
                    {
                        return new() { IsValid = false };
                    }
                }
                else
                {
                    return new() { IsValid = false };
                }
            }

            if (parantheses.Count > 0)
            {
                return new() { IsValid = false };
            }

            return new() { IsValid = true };
        }
    }
}
