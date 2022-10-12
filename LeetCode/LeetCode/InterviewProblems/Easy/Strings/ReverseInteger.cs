using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy.Strings
{
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            var xString = x.ToString();
            var chars = new List<char>();
            for (int i = 0; i < xString.Length; i++)
            {
                chars.Add(xString[i]);
            }

            if (chars[^1] == '0')
            {
                // remove suffix 0's
                var i = chars.Count - 1;
                while (chars[i] == '0' && i > 0)
                {
                    chars.RemoveAt(i);
                    i--;
                }
            }
            bool negative = chars[0] == '-';
            if (!negative)
            {
                for (int i = 0; i < chars.Count / 2; i++)
                {
                    var temp = chars[i];
                    chars[i] = chars[^(i + 1)];
                    chars[^(i + 1)] = temp;
                }
            }
            else
            {
                chars.RemoveAt(0);
                for (int i = 0; i < chars.Count / 2; i++)
                {
                    var temp = chars[i];
                    chars[i] = chars[^(i + 1)];
                    chars[^(i + 1)] = temp;
                }
                chars.Insert(0, '-');
            }
            try
            {
                int num = int.Parse(new string(chars.ToArray()));
                return num;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        public static int ReverseOptimized(int x)
        {
            var xString = x.ToString();
            var str = new string(xString.Trim('-').Reverse().ToArray());
            bool succeed = int.TryParse(str, out int value);
            return succeed ? xString[0] == '-' ? -1 * value : value : 0;
        }

        //run
        public static void Run()
            {
                while (true)
                {
                    Console.WriteLine("-----------------start----------------");
                    Console.WriteLine("enter number");
                    var num = int.Parse(Console.ReadLine());
                    Console.WriteLine("result: " + ReverseOptimized(num));
                }
            }
        }
    }
