using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class Problems0
    {
        public static int RomanToInt(string s)
        {
            var map = new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 },
                { "IV", 4 },
                { "X", 10 },
                { "IX", 9 },
                { "L", 50 },
                { "XL", 40 },
                { "C", 100 },
                { "XC", 90 },
                { "D", 500 },
                { "CD", 400 },
                { "M", 1000 },
                { "CM", 900 }
            };

            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //sum += map[s[i]];
                // if special case
                if (i < s.Length - 1 && map.ContainsKey(s.Substring(i, 2)))
                {
                    sum += map[s.Substring(i, 2)];
                    i++;
                }
                else
                    sum += map[s.Substring(i, 1)];
            }
            return sum;
        }
    }
}
