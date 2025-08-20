using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Problem: Given an unsorted array of integers nums, return the length of the longest 
    // consecutive elements sequence.
    // You must write an algorithm that runs in O(n) time.

    // Example 1
    // Input: nums = [100,4,200,1,3,2]
    // Output: 4
    // Explanation: The longest consecutive elements sequence is [1,2,3,4]. Therefore its length is 4.

    // Example 2
    // Input: nums = [0,3,7,2,5,8,4,6,0,1]
    // Output: 9

    // Example 3
    // Input: nums = [1,0,1,2]
    // Output: 3
    public class LongestConsecutiveSequence
    {
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            int longest = 0;

            foreach(int num in nums)
            {
                set.Add(num);
            }

            foreach(int num in set)
            {
                if(!set.Contains(num - 1))
                {
                    int longer = 1;

                    while(set.Contains(num + longer))
                    {
                        longer++;
                    }

                    longest = Math.Max(longest, longer);
                }
            }

            return longest;
        }
    }
}
