using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Models.Input
{
    public class TwoSumInput
    {
        public int[] Numbers { get; set; }
        public int Target { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            foreach (int number in Numbers)
            {
                output.Append($"{number}, ");
            }

            return $"Numbers: [{output.ToString().Substring(0, output.Length - 2)}]\nTarget: {Target}";
        }
    }
}
