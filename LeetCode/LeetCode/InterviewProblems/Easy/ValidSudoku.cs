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
            // add each row to hash set then each column to hash set if hashset.count != column.length  || hashset.count != row.length then return false


            //check for rows
            for (int row = 0; row < 9; row++)
            {
                var rowHashSet = new HashSet<char>();
                var numsCount = 0;
                for (int column = 0; column < 9; column++)
                {
                    if (board[row][column] != '.')
                    {
                        numsCount++;
                        rowHashSet.Add(board[row][column]);
                    }
                }
                if (rowHashSet.Count != numsCount || rowHashSet.Count == 0)
                    return false;
            }

            //check for columns
            for (int column = 0; column < 9; column++)
            {
                var columnHashSet = new HashSet<char>();
                var numsCount = 0;
                for (int row = 0; row < 9; row++)
                {
                    if (board[row][column] != '.')
                    {
                        numsCount++;
                        columnHashSet.Add(board[row][column]);
                    }
                }
                if (columnHashSet.Count != numsCount || columnHashSet.Count == 0)
                    return false;
            }

            // check for sub 3 * 3 sub boxes
            //var boxRowStartIndex = 0;
            //for (int i = boxRowStartIndex; i < boxRowStartIndex + 3; i++)
            //{
            //    for (int columnStartIndex = 0; columnStartIndex < 9; columnStartIndex += 3)
            //    {
            //        var boxHashSet = new HashSet<char>();
            //        var numsCount = 0;
            //        for (int j = columnStartIndex; j < columnStartIndex + 3; j++)
            //        {
            //            if (board[i][j] != '.')
            //            {
            //                numsCount++;
            //                boxHashSet.Add(board[i][j]);
            //            }
            //        }
            //        if (numsCount == 0 || numsCount != boxHashSet.Count)
            //            return false;
            //    }


            //    boxRowStartIndex += 3;
            //}            //var boxRowStartIndex = 0;
            //for (int i = boxRowStartIndex; i < boxRowStartIndex + 3; i++)
            //{
            //    for (int columnStartIndex = 0; columnStartIndex < 9; columnStartIndex += 3)
            //    {
            //        var boxHashSet = new HashSet<char>();
            //        var numsCount = 0;
            //        for (int j = columnStartIndex; j < columnStartIndex + 3; j++)
            //        {
            //            if (board[i][j] != '.')
            //            {
            //                numsCount++;
            //                boxHashSet.Add(board[i][j]);
            //            }
            //        }
            //        if (numsCount == 0 || numsCount != boxHashSet.Count)
            //            return false;
            //    }


            //    boxRowStartIndex += 3;
            //}

            //we have 9 boxes (0,1,2)(3,4,5)(6,7,8)
            //foreach box we manipulate 3*3 rows * columns
            for (int box = 0; box < 9; box++)
            {
                if(box < 3)
                {
                    //first 3 rows with all columns box
                    for (int i = 0; i < 3; i++)
                    {
                        
                        for(int j = box; j < box + 3; j++)
                        {

                        }
                    }
                }
                else if(box < 6)
                {
                    // second 3 rows with all columns
                }
                else if(box < 9)
                {
                    //third 3 rows with all columns
                }
            }


            return true;
        }
    }
}
