using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given an integer array nums of length n, you want to create an array ans of length 2n where 
    // ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

    // Specifically, ans is the concatenation of two nums arrays.

    // Return the array ans.

    // Example 1
    // Input: nums = [1,2,1]
    // Output: [1,2,1,1,2,1]

    // Example 2
    // Input: nums = [1,3,2,1]
    // Output: [1,3,2,1,1,3,2,1]
    public class ConcatenationOfArray
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i];
            }

            return ans;
        }
    }
}
