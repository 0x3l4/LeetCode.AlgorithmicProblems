using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix
{
    public class SolutionB : IProblem<LongestCommonPrefixInput, LongestCommonPrefixOutput>
    {
        public string ProblemName => "Longest common prefix - Solution B";

        public LongestCommonPrefixOutput Solve(LongestCommonPrefixInput input)
        {
            string word = input.Words.First();

            int longestPrefixLength = word.Length;

            for (int i = 1; i < input.Words.Length; i++)
            {
                for (int j = 0; j < longestPrefixLength; j++)
                {
                    if (j < input.Words[i].Length)
                    {
                        if (word[j] != input.Words[i][j])
                        {
                            longestPrefixLength = j;

                            break;
                        }
                    }
                    else
                    {
                        longestPrefixLength = j;

                        break;
                    }
                }

                if (longestPrefixLength == 0)
                {
                    return new() { Prefix = "" };
                }
            }

            return new() { Prefix = word.Substring(0, longestPrefixLength) };
        }
    }
}
