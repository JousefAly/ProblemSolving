using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RunningSumProblem
    {
        public static int[] RunningSum(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0)
                    nums[i] = nums[i] + nums[i - 1];
            }
            return nums;  
        }
    }
}
