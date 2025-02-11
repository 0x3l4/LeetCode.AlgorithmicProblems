using LeetCode.AlgorithmicProblems.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class ValidParanthesesDataLoader : DataLoader<TestData<string, bool>>
    {
        public ValidParanthesesDataLoader()
        {
            _fileName = "valid_parantheses_data.json";
        }
    }
}
