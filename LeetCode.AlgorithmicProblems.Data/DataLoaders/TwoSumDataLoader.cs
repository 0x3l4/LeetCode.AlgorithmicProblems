using LeetCode.AlgorithmicProblems.Data.Models;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class TwoSumDataLoader : 
        DataLoader<TestData<TwoSumInput, TwoSumOutput>>
    {
        public TwoSumDataLoader() : base("two_sum_data.json")
        {

        }
    }
}
