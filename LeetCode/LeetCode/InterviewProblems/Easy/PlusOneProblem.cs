using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class PlusOneProblem
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == 0 && digits[i] == 9)
                {
                    digits = digits.Append(1).ToArray();
                }
                else if (digits[i] < 9)
                {
                    digits[i]++;
                    break;
                }
            }
            return digits;
        }
        public static void Run()
        {
            while (true)
            {

                Console.WriteLine("-------------start----------");
                var digits = CGlobal.InputIntArray();
                Console.WriteLine("result: [" + string.Join(',', digits) + "]");
            }
        }
    }
}
