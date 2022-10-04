using System;

namespace LeetCode.InterviewProblems.Easy
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1 ];

            }
            return maxProfit;
        }

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("--------------------------Start----------------------");
                Console.WriteLine("enter array size");
                var size = int.Parse(Console.ReadLine());
                var nums = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("enter num:");
                    nums[i] = int.Parse(Console.ReadLine());
                }

                //implemintation
                var maxProfit = MaxProfit(nums);
                Console.WriteLine("Max Profit = " + maxProfit);
            }
        }
    }
}
