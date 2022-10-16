using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy.Strings
{
    public class FirstUniqueCharacterInString
    {
        public static int FirstUniqChar(string s)
        {
            //store frequency in dictionary
            // loop again with the same order if frequency = 0 then return the index
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]]++;
                else
                    dict[s[i]] = 0;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 0)
                    return i;
            }
            return -1;
        }

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("-------------start--------------");
                Console.WriteLine("enter string");
                var st = Console.ReadLine();
                Console.WriteLine(FirstUniqChar(st));
            }
        }
    }
}
