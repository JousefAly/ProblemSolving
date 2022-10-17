using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict[s[i]] = 0;
                else
                    dict[s[i]]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dict.TryGetValue(t[i], out int frequency))
                {
                    if (frequency > 0)
                        dict[t[i]]--;
                    else
                    {
                        dict.Remove(t[i]);
                    }

                }
                else
                {
                    return false;
                }
            }
            return !dict.Any();
        }
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("----------start-----------");
                Console.WriteLine("enter first string");
                var s = Console.ReadLine();
                Console.WriteLine("enter secondstring");
                var t = Console.ReadLine();
                Console.WriteLine(IsAnagram(s,t));
            }
        }
    }

    
}
