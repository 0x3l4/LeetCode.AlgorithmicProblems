using LeetCode.AlgorithmicProblems.Data.Models;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class LongestCommonPrefixDataLoader : 
        DataLoader<TestData<LongestCommonPrefixInput, LongestCommonPrefixOutput>>
    {
        public LongestCommonPrefixDataLoader() : base("longest_common_prefix_data.json")
        {
           
        }
    }
}
