using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow
{
    // Given two strings s and p, return an array of all the start indices of p's anagrams in s.
    // You may return the answer in any order.

    // Example 1
    // Input: s = "cbaebabacd", p = "abc"
    // Output: [0,6]

    // Example 2
    // Input: s = "abab", p = "ab"
    // Output: [0,1,2]
    public class FindAllAnagramsInAString
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();

            if (s.Length < p.Length) return result;

            int[] freq = new int[26];
            int[] window = new int[26];

            for (int i = 0; i < p.Length; i++)
            {
                freq[p[i] - 'a']++;
                window[s[i] - 'a']++;
            }

            if (ArraysMatch(freq, window)) result.Add(0);

            for (int i = p.Length; i < s.Length; i++)
            {
                window[s[i - p.Length] - 'a']--;
                window[s[i] - 'a']++;

                if (ArraysMatch(freq, window)) result.Add(i - p.Length + 1);
            }

            return result;
        }

        private bool ArraysMatch(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
    }
}
