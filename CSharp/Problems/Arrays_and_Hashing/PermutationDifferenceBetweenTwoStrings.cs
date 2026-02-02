using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // You are given two strings s and t such that every character occurs at most once in s and t is permutation of s.

    // The permutation difference between s and t is defined as the sum of the absolute difference 
    // between the index of the occurrence of each character in s and the index of the occurrence of the same character in t.

    // Return the permutation difference between s and t.

    // Example 1
    // Input: s = "abc", t = "bac"
    // Output: 2

    // Example 2
    // Input: s = "abcde", t = "edbac"
    // Output: 12
    public class PermutationDifferenceBetweenTwoStrings
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int FindPermutationDifference(string s, string t)
        {
            int[] freq = new int[26];
            int absDiff = 0;

            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a'] = i;
            }

            for (int i = 0; i < t.Length; i++)
            {
                absDiff += Math.Abs(i - freq[t[i] - 'a']);
            }

            return absDiff;
        }
    }
}
