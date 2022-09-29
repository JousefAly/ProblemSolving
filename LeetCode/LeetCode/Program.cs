using LeetCode.Problems;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Console.WriteLine("Enter roman number:");
                //Console.WriteLine(Problems0.RomanToInt(Console.ReadLine()));
                Console.WriteLine("array size:");
                var size = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter array numbers");
                var nums = new int[size];
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("num: ");
                    nums[i] = int.Parse(Console.ReadLine());
                }
                var result = RunningSumProblem.RunningSum(nums);
                Console.WriteLine(string.Join(',', result));

            }
        }
    }
}
