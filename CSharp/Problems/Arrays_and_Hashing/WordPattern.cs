using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    public class WordPattern
    {
        // Given a pattern and a string s, find if s follows the same pattern.
        
        // Here follow means a full match, such that there is a bijection between a letter in pattern 
        // and a non-empty word in s. Specifically:
        // * Each letter in pattern maps to exactly one unique word in s.
        // * Each unique word in s maps to exactly one letter in pattern.
        // * No two letters map to the same word, and no two words map to the same letter.

        // Example 1
        // Input: pattern = "abba", s = "dog cat cat dog"
        // Output: true

        // Example 2
        // Input: pattern = "abba", s = "dog cat cat fish"
        // Output: false

        // Example 3
        // Input: pattern = "aaaa", s = "dog cat cat dog"
        // Output: false
        public bool IsWordPattern(string pattern, string s)
        {
            // Time complexity: O(n)
            // Space complexity: O(n)
            var dictionary1 = new Dictionary<char, string>();
            var dictionary2 = new Dictionary<string, char>();
            string[] words = s.Split(" ");

            if (pattern.Length != words.Length) return false;

            for (int i = 0; i < words.Length; i++)
            {
                if (!dictionary1.TryAdd(pattern[i], words[i]) && dictionary1[pattern[i]] != words[i])
                {
                    return false;
                }

                if (!dictionary2.TryAdd(words[i], pattern[i]) && dictionary2[words[i]] != pattern[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
