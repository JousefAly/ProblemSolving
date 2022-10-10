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
        public static int[] PlusOne(int[] digits)
        {            
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == 0 && digits[i] == 9)
                {
                    digits = new int[digits.Length + 1];
                    digits[0] = 1;
                    return digits;
                }
                else if (digits[i] < 9)
                {
                    for (int j = digits.Length - 1; j > i ; j--)
                    {
                        digits[j] = 0;
                    }
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
                digits = PlusOne(digits);
                Console.WriteLine("result: [" + string.Join(',', digits) + "]");
            }
        }
    }
}
