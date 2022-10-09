using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class ArrayOfIntersection
    {
        //public static int[] Intersect(int[] nums1, int[] nums2)
        //{
        //    nums1.OrderBy(x => x);
        //    nums2.OrderBy(x => x);
        //    var small = new int[0];
        //    var big = new int[0];

        //    if (nums1.Length > nums2.Length)
        //    {
        //        small = nums2;
        //        big = nums1;
        //    }
        //    else
        //    {
        //        small = nums1;
        //        big = nums2;
        //    }

        //    var intersectionList = new List<int>();
        //    for (int i = 0; i < small.Length; i++)
        //    {
        //        //check number of occurences if not the same then this is not an intersection
        //        var firstIntersectionIndex = GetFirstNumberIndex(small[i], big);
        //        var counter = 0;
        //        if (firstIntersectionIndex >= 0)
        //        {
        //            var skip = false;
        //            while (firstIntersectionIndex + counter + 1 < big.Length && big[firstIntersectionIndex + counter] == big[firstIntersectionIndex + counter + 1])
        //            {
        //                if (i + counter + 1 >= small.Length || small[i + counter] != small[i + counter + 1])
        //                {
        //                    skip = true;
        //                    break;
        //                }

        //                counter++;
        //            }
        //            if (skip)
        //                continue;
        //            //if reached here same elements exist
        //            intersectionList.Add(small[i]);
        //        }
        //        //start next checking at the next different element
        //        i += counter;
        //    }
        //    return intersectionList.ToArray();

        //}
        public static int[] Intersect(int[] nums1, int[] nums2)
        {

            if (nums1 is null || nums1.Length == 0 || nums2 is null || nums2.Length == 0)
                return Array.Empty<int>();

            int[] arrayOccurences;
            int[] arrayToCompare;

            if (nums1.Length < nums2.Length)
            {
                arrayOccurences = nums1;
                arrayToCompare = nums2;
            }
            else
            {
                arrayToCompare = nums1;
                arrayOccurences = nums2;
            }
            var dictOccurences = new Dictionary<int, int>();
            for (int i = 0; i < arrayOccurences.Length; i++)
            {
                if (dictOccurences.ContainsKey(arrayOccurences[i]))
                {
                    dictOccurences[arrayOccurences[i]]++;
                }
                else
                {
                    dictOccurences.Add(arrayOccurences[i], 1);
                }

            }
            var resultList = new List<int>();
            for (int i = 0; i < arrayToCompare.Length; i++)
            {
                if (dictOccurences.TryGetValue(arrayToCompare[i], out int occurences))
                {
                    if (occurences > 0)
                    {
                        dictOccurences[arrayToCompare[i]]--;
                        resultList.Add(arrayToCompare[i]);
                    }
                    else
                    {
                        dictOccurences.Remove(arrayToCompare[i]);                        
                    }
                }

            }
            return resultList.ToArray();


        }

        //should use binary search
        private static int GetFirstNumberIndex(int number, int[] arr)
        {
            var index = Array.BinarySearch(arr, number);
            if (index >= 0)
            {
                while (index != 0 && arr[index] == arr[index - 1])
                {
                    index--;
                }
            }
            return index;

        }
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("-------------Start-----------");
                Console.WriteLine("Enter nums1");
                var nums1 = CGlobal.InputIntArray();

                Console.WriteLine("Enter nums2");
                var nums2 = CGlobal.InputIntArray();

                var result = Intersect(nums1, nums2);
                Console.WriteLine("result: [" + string.Join(',', result) + "]");


            }
        }
    }
}
