using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Given an integer array nums, move all 0's to the end of it while 
    // maintaining the relative order of the non-zero elements.

    // Note that you must do this in-place without making a copy of the array.

    // Example 1
    // Input: nums = [0,1,0,3,12]
    // Output: [1,3,12,0,0]

    // Example 2
    // Input: nums = [0]
    // Output: [0]
    public class MoveZeroes
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public void MovingZeroes(int[] nums)
        {
            if (nums.Length <= 1) return;
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    int holder = nums[left];
                    nums[left] = nums[right];
                    nums[right] = holder;
                    left++;
                }
            }
        }
    }
}
