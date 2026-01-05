using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    public class MajorityElement
    {

        // Given an array nums of size n, return the majority element.

        // The majority element is the element that appears more than [n / 2] times.
        // You may assume that the majority element always exists in the array.

        // Example 1
        // Input: nums = [3,2,3]
        // Output: 3

        // Example 2
        // Input: nums = [2,2,1,1,1,2,2]
        // Output: 2

        public int GetMajorityElement(int[] nums)
        {
            // Time Complexity: O(n)
            // Space Complexity: O(n)
            var numsDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsDictionary.TryAdd(nums[i], 1))
                {
                    numsDictionary[nums[i]] = numsDictionary[nums[i]] + 1;
                }
            }

            return numsDictionary.MaxBy(kvp => kvp.Value).Key;
        }
    }
}
