using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given an array nums of n integers where nums[i] is in the range [1,n],
    // return an array of all integers in the range [1,n] that do not appear in nums.

    // Example 1
    // Input: nums = [4,3,2,7,8,2,3,1]
    // Output: [5,6]

    // Example 2
    // Input: nums = [1,1]
    // Output: [2]
    public class FindAllNumbersDisappearedInAnArray
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int[] count = new int[nums.Length + 1];
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] == 0) result.Add(i);
            }

            return result;
        }
    }
}
