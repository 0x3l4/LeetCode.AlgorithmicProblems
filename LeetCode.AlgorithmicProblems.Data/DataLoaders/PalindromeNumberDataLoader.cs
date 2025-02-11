using LeetCode.AlgorithmicProblems.Data.Models;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class PalindromeNumberDataLoader : DataLoader<TestData<int, bool>>
    {
        public PalindromeNumberDataLoader()
        {
            _fileName = "palindrome_number_data.json";
        }
    }
}
