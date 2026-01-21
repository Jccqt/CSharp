using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

    // Return any array that satisfies this condition.

    // Example 1
    // Input: nums = [3,1,2,4]
    // Output: [4,2,1,3]

    // Example 2
    // Input: nums = [0]
    // Output: [0]
    public class SortArrayByParity
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int[] SortByParity(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (IsEven(nums[left]))
                {
                    left++;
                    continue;
                }

                if (!IsEven(nums[right]))
                {
                    right--;
                    continue;
                }

                int holder = nums[left];
                nums[left] = nums[right];
                nums[right] = holder;

                left++;
                right--;
            }

            return nums;
        }

        public bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
