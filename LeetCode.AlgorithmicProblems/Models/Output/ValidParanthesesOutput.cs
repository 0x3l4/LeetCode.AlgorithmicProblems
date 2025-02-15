using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Models.Output
{
    public class ValidParanthesesOutput
    {
        public bool IsValid { get; set; }

        public override string ToString()
        {
            return $"IsValid: {IsValid}";
        }
    }
}
