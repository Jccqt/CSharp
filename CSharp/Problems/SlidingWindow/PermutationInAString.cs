using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow
{
    // Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.

    // In other words, return true if one of s1's permutations in the substring of s2.

    // Example 1
    // Input: s1 = "ab", s2 = "eidbaooo"
    // Output: true

    // Example 2
    // Input: s1 = "ab", s2 = "eidboaoo"
    // Output: false;
    public class PermutationInAString
    {
        // Time complexity: O(l2)
        // Space complexity: O(1)
        public bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length) return false;

            int[] freq = new int[26];
            int[] window = new int[26];
            int length = s1.Length;

            for (int i = 0; i < length; i++)
            {
                freq[s1[i] - 'a']++;
                window[s2[i] - 'a']++;
            }

            if (ArraysMatch(freq, window)) return true;

            for (int i = length; i < s2.Length; i++)
            {
                window[s2[i - length] - 'a']--;
                window[s2[i] - 'a']++;

                if (ArraysMatch(freq, window)) return true;
            }

            return false;
        }

        public bool ArraysMatch(int[] array1, int[] array2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (array1[i] != array2[i]) return false;
            }

            return true;
        }
    }
}
