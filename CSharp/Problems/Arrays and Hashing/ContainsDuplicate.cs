using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    public class ContainsDuplicate
    {
        // Problem: Given an integer array nums, return true if any value appears at least twice in the array,
        // and return false if every element is distinct

        // Example 1: Input nums = [1,2,3,1]
        // Output: true
        // Explanation: The element 1 occurs at the indices 0 and 3

        // Example 2: Input nums = [1,2, 3, 4]
        // Output false
        // Explanation: All elements are distinct
        public bool CheckContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (!set.Add(nums[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
