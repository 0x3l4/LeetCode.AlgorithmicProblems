using LeetCode.AlgorithmicProblems.Core;
using LeetCode.AlgorithmicProblems.Models.Input;
using LeetCode.AlgorithmicProblems.Models.Output;

namespace LeetCode.AlgorithmicProblems.Problems.RomanToInteger
{
    public class SolutionA : IProblem<RomanToIntegerInput, RomanToIntegerOutput>
    {
        public string ProblemName => "Roman to Integer - Solution A";

        public RomanToIntegerOutput Solve(RomanToIntegerInput input)
        {
            Dictionary<char, int> romanDict = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            var romanKeys = romanDict.Keys.ToList();
            int result = 0;

            for (int i = 0; i < input.RomanNumber.Length; i++)
            {
                switch (input.RomanNumber[i])
                {
                    case 'I':
                    case 'V':
                    case 'X':
                    case 'L':
                    case 'C':
                    case 'D':
                    case 'M':
                        if (i + 1 < input.RomanNumber.Length)
                        {
                            int indexOfRomanDigit = romanKeys.IndexOf(input.RomanNumber[i]);

                            if (indexOfRomanDigit >= 0 && indexOfRomanDigit + 1 < romanKeys.Count)
                            {
                                
                                if (input.RomanNumber[i + 1] == romanKeys[indexOfRomanDigit + 1])
                                {
                                    result += romanDict.ElementAt(indexOfRomanDigit + 1).Value - romanDict.ElementAt(indexOfRomanDigit).Value;
                                    i++;
                                    break;
                                }
                                else if (indexOfRomanDigit + 2 < romanKeys.Count)
                                {
                                    if (input.RomanNumber[i + 1] == romanKeys[indexOfRomanDigit + 2])
                                    {
                                        result += romanDict.ElementAt(indexOfRomanDigit + 2).Value - romanDict.ElementAt(indexOfRomanDigit).Value;
                                        i++;
                                        break;
                                    }
                                }
                            }
                        }
                        result += romanDict[input.RomanNumber[i]];

                        break;
                    default:
                        break;
                }
            }

            return new() { Number = result };
        }
    }
}
