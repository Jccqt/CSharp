using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow.VariableSized
{
    // You are given two strings s and t of the same length and an integer maxCost.

    // You want to change s to t. Changing ith character of s to ith character of t costs |s[i] - t[i]| (i.e., the absolute difference between the ASCII values of the characters).

    // Return the maximum length of a substring of s that can be changed to the same as the corresponding substring of t
    // with a cost less than or equal to maxCost.
    // If there is no substring from s that can be changed to its corresponding substring from t, return 0.

    // Example 1
    // Input: s = "abcd", t = "bcdf", maxCost = 3
    // Output: 3

    // Example 2
    // Input: s = "abcd", t = "cdef", maxCost = 3
    // Output: 1

    // Example 3
    // Input: s = "abcd", t = "acde", maxCost = 0
    // Output: 0
    public class GetEqualSubstringsWithinBudget
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int EqualSubstring(string s, string t, int maxCost)
        {
            int longest = 0;
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                maxCost -= Math.Abs(s[right] - t[right]);

                while (maxCost < 0)
                {
                    maxCost += Math.Abs(s[left] - t[left]);
                    left++;
                }

                longest = Math.Max(longest, right - left + 1);
            }

            return longest;
        }
    }
}
