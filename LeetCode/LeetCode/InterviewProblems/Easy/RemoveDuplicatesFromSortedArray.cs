using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var insertIndex = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[insertIndex] = nums[i];
                    insertIndex++;
                }
            }
            return insertIndex;
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
                var k = RemoveDuplicates(nums);
                Console.WriteLine("k = " + k);
            }
        }
    }
}
