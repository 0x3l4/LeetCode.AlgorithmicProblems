using LeetCode.AlgorithmicProblems.Data.Models;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class RomanToIntegerDataLoader : 
        DataLoader<TestData<RomanToIntegerInput, RomanToIntegerOutput>>
    {
        public RomanToIntegerDataLoader() : base("roman_to_integer_data.json")
        {

        }
    }
}
