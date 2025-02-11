using LeetCode.AlgorithmicProblems.Core;
using System.Text;

namespace LeetCode.AlgorithmicProblems.Problems.LongestCommonPrefix
{
    public class SolutionA : IProblem<string[], string>
    {
        public string ProblemName => "Longest common prefix - Solution A";

        public string Solve(string[] words)
        {
            if (words == null || words?.Length == 0)
            {
                return "";
            }

            StringBuilder longestPrefix = new StringBuilder(words!.First());

            for (int i = 1; i < words!.Length; i++)
            {
                for (int j = 0; j < longestPrefix.Length; j++)
                {
                    if (j < words[i].Length)
                    {
                        if (longestPrefix[j] != words[i][j])
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
