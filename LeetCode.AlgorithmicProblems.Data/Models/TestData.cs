
namespace LeetCode.AlgorithmicProblems.Data.Models
{
    public class TestData<TInput, TExpected>
    {
        public TInput? Input { get; set; }
        public TExpected? Expected { get; set; }
    }
}
