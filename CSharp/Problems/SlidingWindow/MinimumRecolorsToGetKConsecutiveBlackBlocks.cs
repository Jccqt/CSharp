using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow
{
    // You are given a 0-indexed string blocks of length n, where blocks[i] is either 'W' or 'B',
    // representing the color of the ith block. The characters 'W' and 'B' denote the colors white and black, respectively.

    // You are also given an integer k, which is the desired number of consecutive black blocks.

    // In one operation, you can recolor a white block such that it becomes a black block.

    // Return the minimum number of operations needed such that there is at least one occurence of k consecutive black blocks.

    // Example 1
    // Input: blocks = "WBBWWBBWBW", k = 7
    // Output: 3

    // Example 2
    // Input: blocks = "WBWBBBW", k = 2
    // Output: 0
    public class MinimumRecolorsToGetKConsecutiveBlackBlocks
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int MinimumRecolors(string blocks, int k)
        {
            int counter = 0;
            int minOperation = 0;

            for (int i = 0; i < k; i++)
            {
                if (blocks[i] == 'W')
                {
                    counter++;
                }
            }

            minOperation = counter;

            for (int i = k; i < blocks.Length; i++)
            {
                if (blocks[i - k] == 'W')
                {
                    counter--;
                }

                if (blocks[i] == 'W')
                {
                    counter++;
                }

                minOperation = Math.Min(minOperation, counter);
            }

            return minOperation;
        }
    }
}
