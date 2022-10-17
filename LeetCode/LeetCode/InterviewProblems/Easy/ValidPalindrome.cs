using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            List<char> alphaNumerics = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                    alphaNumerics.Add(char.ToLower(s[i]));
            }
            for (int i = 0; i < alphaNumerics.Count / 2; i++)
            {
                if (alphaNumerics[i] != alphaNumerics[^(i + 1)])
                    return false;
            }
            return true;
        }

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("----------------start--------------");
                Console.WriteLine("enter string");
                var s = Console.ReadLine();

                Console.WriteLine(IsPalindrome(s));
            }
        }
    }
}
