using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class SingleNumberProblem
    {
        //brute force
        // we may make a dictionary of <int, dictionary<int,bool>>
        // this will result in O(n) without parallel loop
        public static int SingleNumber(int[] nums)
        {
            
            var resultDictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!resultDictionary.ContainsKey(nums[i]))
                    resultDictionary[nums[i]] = 1;
                else
                {
                    resultDictionary[nums[i]]++;
                }
            }
            foreach (var item in resultDictionary)
            {
                if (item.Value == 1)
                    return item.Key;
            }
            return 0;
            
        }
        
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("------------------Start-----------------");
                var nums = CGlobal.InputIntArray();
                Console.WriteLine(SingleNumber(nums));
            }
        }
    }
}
