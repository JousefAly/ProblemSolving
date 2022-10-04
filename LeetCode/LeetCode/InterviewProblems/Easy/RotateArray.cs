using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class RotateArray
    {
        public static void RotateWithNewArray(int[] nums, int k)
        {
            if (k < 0)
                return;
            var result = new int[nums.Length];
            k = k % nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                var insertIndex = i + k < nums.Length ? i + k : (i + k) - nums.Length;
                result[insertIndex] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = result[i];
            }
        }
        

        public static void Run()
        {
            Console.WriteLine("-------------------start-------------------");
            var nums = CGlobal.InputIntArray();

            Console.WriteLine("Enter k:");
            var k = int.Parse(Console.ReadLine());

            Console.WriteLine("Array before: ");
            Console.WriteLine(string.Join(',', nums));

            RotateWithNewArray(nums, k);
            Console.WriteLine("Array After");
            Console.WriteLine(string.Join(',', nums));
        }
    }
}
