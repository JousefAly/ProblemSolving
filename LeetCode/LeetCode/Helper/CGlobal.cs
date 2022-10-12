using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helper
{
    public static class CGlobal
    {
        //take int array form user
        public static int[] InputIntArray()
        {
            Console.WriteLine("enter array size");
            var size = int.Parse(Console.ReadLine());
            var nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter num:");
                nums[i] = int.Parse(Console.ReadLine());
            }
            return nums;
        }

        public static char[] InputCharArray()
        {
            Console.WriteLine("enter string");
            var input = Console.ReadLine();
            
            return input.ToCharArray();
        }
    }
}
