using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class MoveZeroesProblem
    {
        public static void MoveZeroes(int[] nums)
        {
            var result = new int[nums.Length];
            var zerosCount = 0;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    result[j] = nums[i];
                    j++;
                }
                else
                {
                    zerosCount++;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = result[i];
            }
        }
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("-------------------start-----------------");
                var nums = CGlobal.InputIntArray();
                MoveZeroes(nums);
                Console.WriteLine(string.Join(',', nums));
            }
        }
    }
}
