using LeetCode.AlgorithmicProblems.Data.Models;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class RomanToIntegerDataLoader : DataLoader<TestData<string, int>>
    {
        public RomanToIntegerDataLoader()
        {
            _fileName = "roman_to_integer_data.json";
        }
    }
}
