using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class ValidSudoku
    {
        public static bool getResult(char[][] board)
        {
            var seen = new HashSet<string>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char currentVal = board[i][j];
                    if (currentVal != '.')
                    {
                        if (!seen.Add(currentVal + "found in row" + i) ||
                        !seen.Add(currentVal + "found in column" + j) ||
                        !seen.Add(currentVal + "found in box" + i / 3 + "-" + j / 3))
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
