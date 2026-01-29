using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given the array nums, for each nums[i] find out how many numbers in the array 
    // are smaller than it. That is, for each nums[i] you have to count the number
    // of valid j's such that j != i and nums[j] < nums[i].

    // Return the answer in an array.

    // Example 1
    // Input: nums = [8,1,2,2,3]
    // Output: [4,0,1,1,2]

    // Example 2
    // Input: nums = [6,5,4,8]
    // Output: [2,1,0,3]

    // Example 3
    // Input: nums = [7,7,7,7]
    // Output: [0,0,0,0]
    public class HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        // Time complexity: O(N + K)
        // Space complexity: O(K)
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] count = new int[101];
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }

            int runningSum = 0;
            for (int i = 0; i < count.Length; i++)
            {
                int currentFreq = count[i];
                count[i] = runningSum;
                runningSum += currentFreq;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = count[nums[i]];
            }

            return result;
        }
    }
}
