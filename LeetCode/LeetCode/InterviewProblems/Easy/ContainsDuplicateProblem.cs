using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class ContainsDuplicateProblem
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            nums = nums.OrderBy(x => x).ToArray();
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                    return true;
            }
            return false;
        }
        public static void Run()
        {
            while (true)
            {


                Console.WriteLine("--------------start---------------");
                var nums = CGlobal.InputIntArray();
                Console.WriteLine(ContainsDuplicate(nums));
            }
        }

    }
}
