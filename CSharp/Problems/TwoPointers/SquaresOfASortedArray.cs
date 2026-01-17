using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Given an integer array nums sorted in non-decreasing order, return an array 
    // of the squares of each number sorted in non-decreasing order.

    // Example 1
    // Input: nums = [-4,-1,0,3,10]
    // Output: [0,1,9,16,100]

    // Example 2
    // Input: nums = [-7,-3,2,3,11]
    // Output: [4,9,9,49,121]
    public class SquaresOfASortedArray
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public int[] SortedSquares(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int[] result = new int[nums.Length];
            int index = nums.Length - 1;

            while (left <= right)
            {
                int leftSquare = nums[left] * nums[left];
                int rightSquare = nums[right] * nums[right];

                if (leftSquare > rightSquare)
                {
                    result[index] = leftSquare;
                    left++;
                    index--;
                }
                else
                {
                    result[index] = rightSquare;
                    right--;
                    index--;
                }
            }

            return result;
        }
    }
}
