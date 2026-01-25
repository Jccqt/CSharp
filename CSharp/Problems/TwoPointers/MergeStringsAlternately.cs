using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, 
    // starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

    // Return the merged string.

    // Example 1
    // Input: word1 = "abc", word2 = "pqr"
    // Output: "apbqcr"

    // Example 2
    // Input: word1 = "ab", word2 = "pqrs"
    // Output: "apbqrs"

    // Example 3
    // Input: word1 = "abcd", word2 = "pq"
    // Output: "apbqcd"
    public class MergeStringsAlternately
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public string MergeAlternately(string word1, string word2)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            int n = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < n; i++)
            {
                if (i < word1.Length) result.Append(word1[i]);
                if (i < word2.Length) result.Append(word2[i]);
            }

            return result.ToString();
        }
    }
}
