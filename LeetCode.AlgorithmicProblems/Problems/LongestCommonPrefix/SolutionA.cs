using LeetCode.AlgorithmicProblems.Core;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix
{
    internal class SolutionA : IProblem<string[], string>
    {
        public string ProblemName => "Longest common prefix - Solution A";

        public string Solve(string[] input)
        {
            if (input == null || input?.Length == 0)
            {
                return "";
            }

            StringBuilder longestPrefix = new StringBuilder(input.First());

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j < longestPrefix.Length; j++)
                {
                    if (j < input[i].Length)
                    {
                        if (longestPrefix[j] != input[i][j])
                        {
                            longestPrefix.Remove(j, longestPrefix.Length - j);

                            break;
                        }
                    }
                    else
                    {
                        longestPrefix.Remove(j, longestPrefix.Length - j);

                        break;
                    }
                }

                if (longestPrefix.Equals(""))
                {
                    return "";
                }
            }

            return longestPrefix.ToString();
        }
    }
}
