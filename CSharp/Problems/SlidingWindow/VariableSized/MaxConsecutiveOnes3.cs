using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow.VariableSized
{
    // Given a binary array nums and an integer k, return the maximum number 
    // of consecutive 1's in the array if you can flip at most k 0's.

    // Example 1
    // Input = nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
    // Output: 6

    // Example 2
    // Input: nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
    // Output: 10
    public class MaxConsecutiveOnes3
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int LongestOnes(int[] nums, int k)
        {
            int longest = 0;
            int left = 0;
            int flipCount = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0) flipCount++;

                while (flipCount > k)
                {
                    if (nums[left] == 0) flipCount--;
                    left++;
                }

                longest = Math.Max(longest, right - left + 1);
            }

            return longest;
        }
    }
}
