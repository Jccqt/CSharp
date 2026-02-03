using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given an integer array nums where every element appears three times except 
    // for one, which appears exactly once. Find the single element and return it.

    // You must implement a solution with a linear runtime complexity and use only constant extra space.

    // Example 1
    // Input: nums = [2,2,3,2]
    // Output: 3

    // Example 2
    // Input: nums = [0,1,0,1,0,1,99]
    // Output: 99
    public class SingleNumberII
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public int SingleNumber(int[] nums)
        {
            var freq = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!freq.ContainsKey(nums[i])) freq[nums[i]] = 0;

                freq[nums[i]]++;
            }

            foreach (var count in freq)
            {
                if (count.Value == 1) return count.Key;
            }

            return 0;
        }
    }
}
