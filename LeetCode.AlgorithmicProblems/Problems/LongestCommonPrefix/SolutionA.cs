﻿using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using System.Text;

namespace LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix
{
    public class SolutionA : IProblem<LongestCommonPrefixInput, LongestCommonPrefixOutput>
    {
        public string ProblemName => "Longest Common Prefix - Solution A";

        public LongestCommonPrefixOutput Solve(LongestCommonPrefixInput input)
        {
            StringBuilder longestPrefix = new StringBuilder(input.Words.First());

            for (int i = 1; i < input.Words.Length; i++)
            {
                for (int j = 0; j < longestPrefix.Length; j++)
                {
                    if (j < input.Words[i].Length)
                    {
                        if (longestPrefix[j] != input.Words[i][j])
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
                    return new() { Prefix = "" };
                }
            }

            return new() { Prefix = longestPrefix.ToString() };
        }
    }
}
