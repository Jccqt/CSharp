using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Problem: Given two strings s and t, return true if t is an anagram of s, and false otherwise

    // Example 1:
    // Input s = "anagram", t = "nagaram"
    // Output = true

    // Example 2:
    // Input s = "rat", t = "car"
    // Ouput = false

    // Constraints:
    // 1 <= s.length, t.length <= 5 ^ 10^4
    // s and t consists of lowercase English letters
    public class IsAnagram
    {
        // Time Complexity: O(N)
        // Space Complexity: O(1)
        public bool CheckIsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            int[] char_counts = new int[26];

            for(int i = 0; i < s.Length; i++)
            {
                char_counts[s[i] - 'a']++;
                char_counts[t[i] - 'a']--;
            }

            foreach(int count in char_counts)
            {
                if(count != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
