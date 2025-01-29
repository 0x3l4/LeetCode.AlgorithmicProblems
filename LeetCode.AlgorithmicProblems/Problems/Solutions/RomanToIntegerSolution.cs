using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Problems.Solutions
{
    /// <summary>
    /// Given a roman numeral, convert it to an integer.
    /// </summary>
    internal class RomanToIntegerSolution
    {
        public int RomatToInt(string s)
        {
            string romanNumber = s.ToUpper();
            int result = 0;
            int power = 1;

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

            for (int i = 0; i < romanDict.Count; i++)
            {
                Console.WriteLine($"{i}" + romanDict.ElementAt(i));
            }

            var romanKeys = romanDict.Keys.ToList();

            for (int i = 0; i < romanDict.Count; i++)
            {
                Console.WriteLine($"{i}" + romanKeys.ElementAt(i));
            }


            for (int i = 0; i < romanNumber.Length; i++)
            {
                switch (romanNumber[i])
                {
                    case 'I':
                    case 'V':
                    case 'X':
                    case 'L':
                    case 'C':
                    case 'D':
                    case 'M':
                        if (i + 1 < romanNumber.Length)
                        {
                            int indexOfRomanDigit = romanKeys.IndexOf(romanNumber[i]);

                            if (indexOfRomanDigit >= 0 && indexOfRomanDigit + 1 < romanKeys.Count)
                            {
                                if (romanNumber[i + 1] == romanKeys[indexOfRomanDigit + 1])
                                {
                                    result += romanDict.ElementAt(indexOfRomanDigit + 1).Value - romanDict.ElementAt(indexOfRomanDigit).Value;
                                    i++;
                                    break;
                                }
                                else if (indexOfRomanDigit + 2 < romanKeys.Count)
                                {
                                    if (romanNumber[i + 1] == romanKeys[indexOfRomanDigit + 2])
                                    {
                                        result += romanDict.ElementAt(indexOfRomanDigit + 2).Value - romanDict.ElementAt(indexOfRomanDigit).Value;
                                        i++;
                                        break;
                                    }
                                }
                            }
                            
                        }
                        result += romanDict[romanNumber[i]];
                        
                        break;
                    default:
                        break;
                }
            }

            return result;
        }
    }
}
