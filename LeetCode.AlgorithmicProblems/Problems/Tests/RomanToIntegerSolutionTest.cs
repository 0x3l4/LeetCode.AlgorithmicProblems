using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using LeetCode.AlgorithmicProblems.Problems.Solutions;

namespace LeetCode.AlgorithmicProblems.Problems.Tests
{
    internal class RomanToIntegerSolutionTest : ITest
    {
        public void Scenario()
        {
            Console.WriteLine("Roman to integer solution");
            Console.WriteLine("Write the number in Roman numerals");
            string input = Console.ReadLine();

            ConsoleTable tableOfTests = new ConsoleTable();

            tableOfTests.AddColumn(["Number of test", "Value", "Result"]);

            RomanToIntegerSolution solution = new RomanToIntegerSolution();

            int romanInInteger = solution.RomatToInt(input);

            tableOfTests.AddRow(1, input, romanInInteger);

            Console.WriteLine(tableOfTests);

        }
    }
}
