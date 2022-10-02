using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RichestCustomerProblem
    {
        public static int MaximumWealth(int[][] accounts)
        {
            var max = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                var sum = accounts[i].Sum();
                if (sum > max)
                    max = sum;
            }
            return max;
        }

        public static void Run()
        {
            var accounts = new int[4][] {
                  new int[4]{0, 1, 2, 3} ,
                   new int[4]{4, 5, 6, 7} ,
                   new int[4]{8, 9, 10, 11} ,
                   new int[4]{12, 13, 14, 15}
            };

            Console.WriteLine(MaximumWealth(accounts));
        }

    }
}
