using System.Text;

namespace LeetCode.AlgorithmicProblems.Models.Output
{
    public class TwoSumOutput
    {
        public int[] Indicies { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            foreach (int index in Indicies)
            {
                output.Append($"{index}, ");
            }

            return $"Indicies: [{output.ToString().Substring(0, output.Length - 2)}]";
        }
    }
}
