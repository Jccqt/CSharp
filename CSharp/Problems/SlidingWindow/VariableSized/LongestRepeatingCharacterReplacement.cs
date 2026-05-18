using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow.VariableSized
{
    // You are given a string s and an integer k.
    // You can choose any character of the string and change it to any other uppercase English character.
    // You can perform this operation at most k times.

    // Return the length of the longest substring containing the same letter you can get after performing the above operations.

    // Example 1
    // Input: s = "ABAB", k = 2
    // Output: 4

    // Example 2
    // Input: s = "AABABBA", k = 1
    // Output: 4
    public class LongestRepeatingCharacterReplacement
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int CharacterReplacement(string s, int k)
        {
            int longest = 0;
            int left = 0;
            int maxFreq = 0;
            int[] counts = new int[26];

            for (int right = 0; right < s.Length; right++)
            {
                counts[s[right] - 'A']++;

                maxFreq = Math.Max(maxFreq, counts[s[right] - 'A']);

                while ((right - left + 1) - maxFreq > k)
                {
                    counts[s[left] - 'A']--;
                    left++;
                }

                longest = Math.Max(longest, right - left + 1);
            }

            return longest;
        }
    }
}
