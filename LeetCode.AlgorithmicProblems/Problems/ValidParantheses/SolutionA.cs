using LeetCode.AlgorithmicProblems.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.ValidParantheses
{
    public class SolutionA : IProblem<string, bool>
    {
        public string ProblemName => "Valid parantheses - Solution A";

        public bool Solve(string input)
        {
            Stack<char> parantheses = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    parantheses.Push(input[i]);
                }
                else if (parantheses.Count > 0)
                {
                    char paranthesis = parantheses.Pop();

                    if (!(paranthesis == '(' && input[i] == ')' ||
                        paranthesis == '{' && input[i] == '}' ||
                        paranthesis == '[' && input[i] == ']'))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (parantheses.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
