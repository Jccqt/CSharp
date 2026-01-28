using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // You have a set of integers s, which originally contains all the numbers from 1 to n.
    // Unfortunately, due to some error, one of the numbers in s got duplicated to another number
    // in the set, which results in repitition of one number and loss of another number.

    // You are given an integer array nums representing the data status of this set after the error.

    // Find the number that occurs twice and the number that is missing and return them in the form of an array.

    // Example 1
    // Input: nums = [1,2,2,4]
    // Output: [2,3]

    // Example 2
    // Input: nums = [1,1]
    // Output: [1,2]
    public class SetMismatch
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public int[] FindErrorNums(int[] nums)
        {
            int duplicate = 0;
            int missing = 0;
            int[] count = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] == 2) duplicate = i;
                if (count[i] == 0) missing = i;
            }

            return new int[] { duplicate, missing };
        }
    }
}
