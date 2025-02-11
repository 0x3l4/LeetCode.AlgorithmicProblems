using LeetCode.AlgorithmicProblems.Data.Models;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class LongestCommonPrefixDataLoader : DataLoader<TestData<string[], string>>
    {
        public LongestCommonPrefixDataLoader()
        {
            _fileName = "longest_common_prefix_data.json";
        }
    }
}
