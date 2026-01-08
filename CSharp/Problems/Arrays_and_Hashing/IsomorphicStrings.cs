using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    public class IsomorphicStrings
    {
        // Given two strings s and t, determine if they are isomorphic.

        // Two strings s and t are isomorphic if the characters in s can be replaced to get t.

        // All occurences of a character must be replaced with another character while preserving 
        // the order of characters. No two characters may map to the same character, but a character 
        // may map to itself.

        // Example 1
        // Input: s = "egg", t = "add"
        // Output: true

        // Example 2
        // Input: s = "foo", t = "bar"
        // Output: false

        // Example 3
        // Input: s = "paper", t = "title"
        // Output: true
        public bool IsIsomorphic(string s, string t)
        {
            // Time complexity: O(n)
            // Space complexity: O(1)
            if (s.Length != t.Length) return false;

            var dictionary1 = new Dictionary<char, char>();
            var dictionary2 = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary1.TryAdd(s[i], t[i]) && dictionary1[s[i]] != t[i])
                {
                    return false;
                }

                if (!dictionary2.TryAdd(t[i], s[i]) && dictionary2[t[i]] != s[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
