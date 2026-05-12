using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow.VariableSized
{
    // Given a string s, find the length of the longest substring without duplicate characters.

    // Example 1
    // Input: s = "abcabcbb"
    // Output: 3

    // Example 2
    // Input: s = "bbbbb"
    // Output: 1

    // Example 3
    // Input: s = "pwwkew"
    // Output: 3
    public class LongestSubstringWithoutRepeatingCharacters
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int LengthOfLongestSubstring(string s)
        {
            int[] freq = new int[128];
            int length = 0;
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                freq[s[right]]++;

                while (freq[s[right]] > 1)
                {
                    freq[s[left]]--;
                    left++;
                }

                length = Math.Max(length, right - left + 1);
            }

            return length;
        }
    }
}
