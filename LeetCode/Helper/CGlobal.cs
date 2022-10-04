using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Helper
{
    public static class CGlobal
    {
        //take int array form user
        public static int[] InputArray()
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
    }
}
