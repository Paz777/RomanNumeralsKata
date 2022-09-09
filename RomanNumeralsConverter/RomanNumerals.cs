using System;
using System.Collections.Generic;

namespace RomanNumeralsConverter
{
    public class RomanNumerals
    {
        private Dictionary<char, int> romanNumbersMap = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public RomanNumerals()
        {
        }

        public int ConvertToNumber(string romanNumeral)
        {
            int result = 0;
            for (int index = romanNumeral.Length - 1, last = 0; index >= 0; index--)
            {
                int current = romanNumbersMap[romanNumeral.ToCharArray()[index]];
                result += (current < last ? -current : current);
                last = current;
            }
            return result;
        }
    }
}

