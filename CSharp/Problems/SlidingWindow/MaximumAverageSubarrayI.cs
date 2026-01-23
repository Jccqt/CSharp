using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow
{
    // You are given an integer array nums consisting of n elements, and an integer k.

    // Find a contiguous subarray whose length is equal to k that has the maximum average 
    // value and return this value. Any answer with a calculation error less than 10^-5 will be accepted.

    // Example 1
    // Input: nums = [1,12,-5,-6,50,3], k = 4
    // Output: 12.7500

    // Example 2
    // Input: nums = [5], k = 1
    // Output: 5.0
    public class MaximumAverageSubarrayI
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public double FindMaxAverage(int[] nums, int k)
        {
            double currentSum = 0;

            for (int i = 0; i < k; i++)
            {
                currentSum += nums[i];
            }

            double maxSum = currentSum;

            for (int i = k; i < nums.Length; i++)
            {
                currentSum = (nums[i] - nums[i - k]) + currentSum;

                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum / k;
        }
    }
}
