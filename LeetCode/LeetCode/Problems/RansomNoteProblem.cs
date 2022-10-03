using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RansomNoteProblem
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var magazineLetters = new Dictionary<char, int>();
           
            foreach (var letter in magazine)
            {
                if (magazineLetters.ContainsKey(letter))
                    magazineLetters[letter]++;
                else
                {
                    magazineLetters[letter] = 1;
                }
            }

            
            foreach (var letter in ransomNote)
            {
                if (magazineLetters.TryGetValue(letter, out int usedNumber))
                {
                    if(usedNumber > 0)
                    {
                        magazineLetters[letter]--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                   
            }
            return true;
        }
        public static void Run()
        {
            var ransomNote = "abba";
            var magazine = "baab";

            Console.WriteLine(CanConstruct(ransomNote, magazine));
        }
    }
}
