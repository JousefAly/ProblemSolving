using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy.Strings
{
    public class ReverseString
    {
        public static void Reverse(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                var temp = s[i];
                s[i] = s[^(i + 1)];
                s[^(i + 1)] = temp;
            }
            return;
        }
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("-------------start--------------");
                var arr = CGlobal.InputCharArray();
                Reverse(arr);
                Console.WriteLine(string.Join(',', arr));
            }
        }
    }
}
