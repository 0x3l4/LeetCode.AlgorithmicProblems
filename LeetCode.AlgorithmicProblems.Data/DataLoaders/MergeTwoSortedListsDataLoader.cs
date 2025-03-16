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
    public class MergeTwoSortedListsDataLoader : DataLoader<TestData<MergeTwoSortedListsInput, MergeTwoSortedListsOutput>>
    {
        public MergeTwoSortedListsDataLoader() : base("merge_two_sorted_lists_data.json")
        {
        }
    }
}
