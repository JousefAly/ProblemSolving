using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class TwoSumProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var resultDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var x = target - nums[i];
                if(resultDictionary.TryGetValue(x , out int index))
                {
                    return new int[] { i, index };
                }
                else
                {
                    resultDictionary[nums[i]] = i;
                }
            }
            return Array.Empty<int>();
        }
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("----------start------------");
                var nums = CGlobal.InputIntArray();
                Console.WriteLine("enter target");
                var target = int.Parse(Console.ReadLine());
                var result = TwoSum(nums, target);
                Console.WriteLine("result= [" + string.Join(',', result) + "]");
            }
        }
    }
}
