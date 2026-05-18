using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow.VariableSized
{
    // Given an unsorted array of integers nums, return the length of the longest continuous increasing subsequence (i.e. subarray).
    // The subsequence must be strictly increasing.

    // A continuous increasing subsequence is defined by two indices l and r (l < r) such that is 
    // [nums[l], nums[l + 1], ..., nums[r - 1], nums[r]] and for each l <= i < r, nums[i] < nums[i + 1].

    // Example 1
    // Input: nums = [1,3,5,4,7]
    // Output: 3

    // Example 2
    // Input: nums = [2,2,2,2,2]
    // Output: 1
    public class LongestContinuousIncreasingSubsequence
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int longest = 1;
            int left = 0;

            for (int right = 1; right < nums.Length; right++)
            {
                if (nums[right - 1] >= nums[right])
                {
                    left = right;
                }

                longest = Math.Max(longest, right - left + 1);
            }

            return longest;
        }
    }
}
