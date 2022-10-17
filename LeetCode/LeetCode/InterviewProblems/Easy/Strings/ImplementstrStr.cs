using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy.Strings
{
    public class ImplementstrStr
    {
        public static int StrStr(string haystack, string needle)
        {

            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length <= haystack.Length)
                    if (haystack.Substring(i, needle.Length) == needle)
                        return i;

            }
            return -1;
        }
        public static int StrStrOptimized(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle) || string.IsNullOrEmpty(haystack))
                return -1;
            return haystack.IndexOf(needle);
           
        }
    }
}
