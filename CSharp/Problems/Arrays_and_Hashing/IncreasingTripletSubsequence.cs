using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given an integer array nums, return true if there exists a triple
    // of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k].
    // If no such indices exists, return false.

    // Example 1
    // Input: nums = [1,2,3,4,5]
    // Output: true

    // Example 2
    // Input: nums = [5,4,3,2,1]
    // Output: false

    // Example 3
    // Input: nums = [2,1,5,0,4,6]
    // Output: true
    public class IncreasingTripletSubsequence
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3) return false;
            int first = int.MaxValue;
            int second = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= first)
                {
                    first = nums[i];
                }
                else if (nums[i] <= second)
                {
                    second = nums[i];
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
