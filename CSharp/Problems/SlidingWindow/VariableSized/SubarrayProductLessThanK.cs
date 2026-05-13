using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow.VariableSized
{
    // Given an array of integers nums and an integer k, return the number of contigous
    // subarrays where the product of all the elements in the subarray is strictly less than k.

    // Example 1
    // Input: nums = [10,5,2,6], k = 100
    // Output: 8

    // Example 2
    // Input: nums = [1,2,3], k = 0
    // Output: 0
    public class SubarrayProductLessThanK
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1) return 0;
            int count = 0;
            int left = 0;
            int product = 1;

            for (int right = 0; right < nums.Length; right++)
            {
                product *= nums[right];

                while (product >= k)
                {
                    product /= nums[left];
                    left++;
                }

                count += (right - left + 1);
            }

            return count;
        }
    }
}
