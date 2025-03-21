﻿using LeetCode.AlgorithmicProblems.Data.Models;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public class ValidParanthesesDataLoader : 
        DataLoader<TestData<ValidParanthesesInput, ValidParanthesesOutput>>
    {
        public ValidParanthesesDataLoader() : base("valid_parantheses_data.json")
        {

        }
    }
}
