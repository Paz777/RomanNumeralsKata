using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter
{
    public class RomanNumerals
    {
        private Dictionary<char, int> romanNumberMap = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        private Dictionary<int, string> numberRomanMap = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        public RomanNumerals()
        {
        }

        public int ConvertToNumber(string romanNumeral)
        {
            int result = 0;
            for (int index = romanNumeral.Length - 1, last = 0; index >= 0; index--)
            {
                int current = romanNumberMap[romanNumeral.ToCharArray()[index]];
                result += (current < last ? -current : current);
                last = current;
            }
            return result;
        }

        public string ConvertToRomanNumeral(int number)
        {
            var romanNumeral = new StringBuilder();
            foreach (var item in numberRomanMap)
            {
                while (number >= item.Key)
                {
                    romanNumeral.Append(item.Value);
                    number -= item.Key;
                }
            }
            return romanNumeral.ToString();
        }
    }
}

