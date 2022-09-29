using LeetCode.Problems;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter roman number:");
                Console.WriteLine(Problems0.RomanToInt(Console.ReadLine()));

            }
        }
    }
}
