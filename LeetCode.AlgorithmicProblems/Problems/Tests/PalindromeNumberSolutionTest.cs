using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ConsoleTables;
using LeetCode.AlgorithmicProblems.Problems.Solutions;

namespace LeetCode.AlgorithmicProblems.Problems.Tests
{
    internal class PalindromeNumberSolutionTest : ITest
    {
        public void Scenario()
        {
            int minNumber = int.MinValue;
            int maxNumber = int.MaxValue;

            Console.WriteLine("Palindrome number solution");
            int choiceOfTest = -1;
            do
            {
                Console.WriteLine("Сhoose a way to initialize the input data");
                Console.WriteLine("1 - Manually");
                Console.WriteLine("2 - Auto");
            } while (int.TryParse(Console.ReadLine(), out choiceOfTest) && !(choiceOfTest == 1 || choiceOfTest == 2));

            ConsoleTable tableOfTests = new ConsoleTable();

            tableOfTests.AddColumn(["Number of test", "Value", "Result"]);

            int numberOfTests = -1;
            PalindromeNumberSolution solution = new PalindromeNumberSolution();
            switch (choiceOfTest)
            {
                case 1:
                    int[] values;
                    string[] inputValues;
                    bool isValidValues = false;

                    do
                    {
                        Console.WriteLine("Write the values separated by a space");

                        inputValues = Console.ReadLine().Trim().Split(' ');

                        values = new int[inputValues.Length];

                        for (int i = 0; i < inputValues.Length; i++)
                        {
                            if (!int.TryParse(inputValues[i], out values[i]))
                            {
                                continue;
                            }
                        }

                        isValidValues = true;

                        for (int i = 0; i < values.Length; i++)
                        {
                            tableOfTests.AddRow(i + 1, values[i], solution.IsPalindrome(values[i]));
                        }
                    } while (!isValidValues);
                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("Write the number of tests");
                    } while (!int.TryParse(Console.ReadLine(), out numberOfTests));

                    Random random = new Random();
                    int randomValue;

                    for (int i = 1; i <= numberOfTests; i++)
                    {
                        randomValue = random.Next(minNumber, maxNumber);
                        tableOfTests.AddRow(i, randomValue, solution.IsPalindrome(randomValue));
                    }
                    break;
            }

            Console.WriteLine(tableOfTests);
        }
    }
}
