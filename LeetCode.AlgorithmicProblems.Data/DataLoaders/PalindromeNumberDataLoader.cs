using LeetCode.AlgorithmicProblems.Data.Models;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class PalindromeNumberDataLoader : 
        DataLoader<TestData<PalindromeNumberInput, PalindromeNumberOutput>>
    {
        public PalindromeNumberDataLoader() : base("palindrome_number_data.json")
        {
            
        }
    }
}
