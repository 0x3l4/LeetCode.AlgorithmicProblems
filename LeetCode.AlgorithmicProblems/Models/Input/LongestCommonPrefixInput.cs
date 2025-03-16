using System.Text;

namespace LeetCode.AlgorithmicProblems.Models.Input
{
    public class LongestCommonPrefixInput
    {
        public string[] Words { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            foreach (string word in Words) 
            { 
                output.Append($"{word}, ");
            }

            return $"Words: [{output.ToString().Substring(0, output.Length - 2)}]";
        }
    }
}
