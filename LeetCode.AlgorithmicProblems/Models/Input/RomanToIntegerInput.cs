using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Models.Input
{
    public class RomanToIntegerInput
    {
        public string RomanNumber { get; set; }

        public override string ToString()
        {
            return $"RomanNumber: {RomanNumber}";
        }
    }
}
