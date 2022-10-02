using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class TwoSumProblem
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return Array.Empty<int>();
       
            var resultDictionary = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                var firstNumber = numbers[i];
                var secondNumber = target - numbers[i];

                if (resultDictionary.TryGetValue(secondNumber, out int secondIndex))
                {
                    return new int[] { i, secondIndex };
                }
                // why use next line not dictionary.Add()
                //because if element is already in dictionary just update the value (index) not the key (value)
                resultDictionary[firstNumber] = i;
            }
            return Array.Empty<int>();
        }

        public static void Run()
        {
            Console.WriteLine("Enter target:");
            var target = int.Parse(Console.ReadLine());
            Console.WriteLine("array size:");
            var size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array numbers");
            var nums = new int[size];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("num: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            var result = TwoSum(nums, target);
            Console.WriteLine("output: [" + string.Join(',', result) + "]");
        }

        
        //learn ref and out

        //public static bool TryGetValue(int index, out int value)
        //{
        //    var nums = new int[] { 1000, 2, 3, 50,100 };
        //    if(index >= 0 && index < nums.Length)
        //    {
        //        value = nums[index];
        //        return true;
        //    }
        //    value = 0;
        //    return false;
        //}
        //public static bool TryGetValueRef(int index, ref int value)
        //{
        //    var nums = new int[] { 1000, 2, 3, 50, 100 };
        //    if (index >= 0 && index < nums.Length)
        //    {
        //        value = nums[index];
        //        return true;
        //    }
        //    value = 0;
        //    return false;
        //}
    }
}
