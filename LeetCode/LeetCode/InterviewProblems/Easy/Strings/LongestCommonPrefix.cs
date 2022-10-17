using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy.Strings
{
    public class LongestCommonPrefix
    {
        public static string LongestPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;
            var firstWord = strs[0];
            var prefix = new StringBuilder("");
            for (int i = 0; i < firstWord.Length; i++)
            {
                for (int s = 1; s < strs.Length; s++)
                {

                    if (i >= strs[s].Length || strs[s][i] != firstWord[i])
                        return prefix.ToString();
                }
                prefix.Append(firstWord[i]);
            }
            return prefix.ToString();
        }
    }
}
