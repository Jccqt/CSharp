using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given a binary array nums, return the maximum number of consecutive 1's in the array.

    // Example 1
    // Input: nums = [1,1,0,1,1,1]
    // Output: 3

    // Example 2
    // Input: nums = [1,0,1,1,0,1]
    // Output: 2
    public class MaxConsecutiveOnes
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int counter = 0;
            int maxCounter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    counter++;
                    maxCounter = Math.Max(maxCounter, counter);
                }
                else
                {
                    counter = 0;
                }

            }

            return maxCounter;
        }
    }
}
