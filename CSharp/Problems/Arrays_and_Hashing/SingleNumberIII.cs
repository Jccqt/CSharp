using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given an integer array nums, in which exactly two elements appear only once
    // and all the other elements appear exactly twice. Find the two elements that
    // appear only once. You can return the answer in any order.

    // You must write an algorithm that runs in linear runtime complexity and uses only constant extra space.

    // Example 1
    // Input: nums = [1,2,1,3,2,5]
    // Output: [3,5]

    // Example 2
    // Input: nums = [-1,0]
    // Output: [-1,0]

    // Example 3
    // Input: nums = [0,1]
    // Output: [0,1]
    public class SingleNumberIII
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public int[] SingleNumber(int[] nums)
        {
            var freq = new Dictionary<int, int>();
            var res = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!freq.ContainsKey(nums[i])) freq[nums[i]] = 0;

                freq[nums[i]]++;
            }

            foreach (var count in freq)
            {
                if (count.Value == 1) res.Add(count.Key);
            }

            return res.ToArray();
        }
    }
}
