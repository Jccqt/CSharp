using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow.VariableSized
{
    // Given an array of positive integers nums and a positive integer target, return the minimal 
    // length of a subarray whose sum is greater than or equal to target.
    // If there is no such subarray, return 0 instead.

    // Example 1
    // Input: target = 7, nums = [2,3,1,2,4,3]
    // Output: 2

    // Example 2
    // Input: target 4, nums = [1,4,4]
    // Output: 1

    // Example 3
    // Input: target = 11, nums = [1,1,1,1,1,1,1,1]
    // Output: 0
    public class MinimumSizeSubarraySum
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public int MinSubArrayLen(int target, int[] nums)
        {
            int length = int.MaxValue;
            int left = 0;
            int sum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (target <= sum)
                {
                    sum -= nums[left];
                    length = Math.Min(length, right - left + 1);
                    left++;
                }
            }

            if (length == int.MaxValue) length = 0;

            return length;
        }
    }
}
