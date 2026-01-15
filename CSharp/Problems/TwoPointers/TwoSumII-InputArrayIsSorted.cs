using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Given an 1-indexed array of integers numbers that is already sorted in 
    // non-decreasing order, find two numbers such that they add up to a specific 
    // target number. Let these two numbers numbers[index1] and numbers[index2] 
    // where 1 <= index1 < index2 <= numbers.length.

    // Return the indices of the two numbers, index1 and index2, added by one
    // as an integer array [index1, index2] of length 2.

    // The tests are generated such that there is exactly one solution.
    // You may not use the same element twice.

    // Your solution must use only constant extra space.

    // Example 1
    // Input: numbers = [2,7,11,15], target = 9
    // Output: [1,2]

    // Example 2
    // Input: numbers = [2,3,4], target = 6
    // Output: [1,3]

    // Example 3
    // Input: numbers = [-1,0], target = -1
    // Output: [1,2]
    public class TwoSumII_InputArrayIsSorted
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int sum = 0;

            while (left < right)
            {
                sum = numbers[left] + numbers[right];
                if (sum == target) return new int[] { left + 1, right + 1 };

                if (sum > target) right--;
                if (sum < target) left++;
            }

            return new int[] { };
        }
    }
}
