using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // You are given an integer array nums and an integer k.

    // In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

    // Return the maximum number of operations you can perform on the array.

    // Example 1
    // Input: nums = [1,2,3,4], k = 5
    // Output: 2

    // Example 2
    // Input: nums = [3,1,3,4,3], k = 6
    // Output: 1
    public class MaxNumberOfK_SumPairs
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums.Length - 1;
            int operations = 0;

            while (left < right)
            {
                int currentSum = nums[left] + nums[right];

                if (currentSum == k)
                {
                    operations++;
                    left++;
                    right--;
                }
                else if (currentSum < k)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return operations;
        }
    }
}
