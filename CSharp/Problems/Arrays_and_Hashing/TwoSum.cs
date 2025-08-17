using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Problem: Given an array of integers nums and an integer target, return any indices
    // of the two nums such that they add up to target.
    //
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //
    // You can return the answer in any order.
    
    // Example 1: 
    // Input: nums = [2,7,11,15], target = 9
    // Output: [0,1]
    // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    // Example 2:
    // Input: nums = [3,2,4], target = 6
    // Output: [1,2]

    // Example 3:
    // Input: nums = [3,3], target = 6
    // Output: [0,1]
    public class TwoSum
    {
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        public int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dictionary.ContainsKey(complement))
                {
                    return new int[] { dictionary[complement], i };
                }

                dictionary[nums[i]] = i;
            }

            throw new ArgumentException("No match found!");
        }
    }
}
