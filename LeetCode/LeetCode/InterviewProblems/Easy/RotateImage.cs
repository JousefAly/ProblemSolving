using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewProblems.Easy
{
    public class RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            //get transpose
            //reverse rows
            //this will give us rotated 90 degree matrix

            //transpose
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            //reverse rows
            for (int i = 0; i < matrix.Length; i++)
            {
                var low = 0;
                var high = matrix.Length - 1;
                while (low < high)
                {
                    var temp = matrix[i][low];
                    matrix[i][low] = matrix[i][high];
                    matrix[i][high] = temp;
                    low++;
                    high--;
                }
            }
            

        }
    }
}
