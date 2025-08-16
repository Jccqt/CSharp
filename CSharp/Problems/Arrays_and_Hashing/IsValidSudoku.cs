using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Problem: Determine if a 9 x 9 Sudoku board is valid. Only the filled cells 
    // need to be validated according to the following rules:
    //
    // 1. Each row must contain the digits 1-9 without repitition
    // 2. Each column must contain the digits 1-9 without repitition
    // 3. Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repitition
    //
    // Note:
    // * A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    // * Only the filled calls need to be validated according to the mentioned rule.

    // Example 1:
    // Input: board =
    //  [["8","3",".",".","7",".",".",".","."]
    //  ,["6",".",".","1","9","5",".",".","."]
    //  ,[".","9","8",".",".",".",".","6","."]
    //  ,["8",".",".",".","6",".",".",".","3"]
    //  ,["4",".",".","8",".","3",".",".","1"]
    //  ,["7",".",".",".","2",".",".",".","6"]
    //  ,[".","6",".",".",".",".","2","8","."]
    //  ,[".",".",".","4","1","9",".",".","5"]
    //  ,[".",".",".",".","8",".",".","7","9"]]
    // Output: true

    // Example 2:
    // Input: board = 
    //  [["8","3",".",".","7",".",".",".","."]
    //  ,["6",".",".","1","9","5",".",".","."]
    //  ,[".","9","8",".",".",".",".","6","."]
    //  ,["8",".",".",".","6",".",".",".","3"]
    //  ,["4",".",".","8",".","3",".",".","1"]
    //  ,["7",".",".",".","2",".",".",".","6"]
    //  ,[".","6",".",".",".",".","2","8","."]
    //  ,[".",".",".","4","1","9",".",".","5"]
    //  ,[".",".",".",".","8",".",".","7","9"]]
    // Output: false
    // Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8.
    // Since there are two 8's in the top left 3x3 sub-box, it is invalid.
    public class IsValidSudoku
    {
        // Time Complexity: O(1)
        // Space Complexity: O(1)
        public bool CheckIsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    char current_val = board[i][j];

                    if(current_val != '.')
                    {
                        if(!seen.Add(current_val + " seen at row " + i) || 
                            !seen.Add(current_val + " seen at column " + j) || 
                            !seen.Add(current_val + " seen at sub row " + i/3 + "-" + j / 3))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
