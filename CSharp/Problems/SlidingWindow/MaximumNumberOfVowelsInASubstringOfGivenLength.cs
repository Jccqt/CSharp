using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow
{
    // Given a string s and an integer k, return the number of vowel letters in any substring of s with length k.

    // Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

    // Example 1
    // Input: s = "abciiidef", k = 3
    // Output: 3

    // Example 2
    // Input: s = "aeiou", k = 2
    // Output: 2

    // Example 3
    // Input: s = "leetcode", k = 3
    // Output: 2
    public class MaximumNumberOfVowelsInASubstringOfGivenLength
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int MaxVowels(string s, int k)
        {
            int counter = 0;
            int maxCount = 0;

            for (int i = 0; i < k; i++)
            {
                if (IsVowel(s[i])) counter++;
            }

            maxCount = counter;

            for (int i = k; i < s.Length; i++)
            {
                if (IsVowel(s[i - k])) counter--;
                if (IsVowel(s[i])) counter++;

                maxCount = Math.Max(maxCount, counter);
            }

            return maxCount;
        }

        public bool IsVowel(char c)
        {
            switch (c)
            {
                case 'a': return true;
                case 'e': return true;
                case 'i': return true;
                case 'o': return true;
                case 'u': return true;
            }

            return false;
        }
    }
}
