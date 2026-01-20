using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    
    // A subsequence of a string is a new string that is formed from the original string 
    // by deleting some (can be none) of the characters without disturbing the relative
    // positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

    // Example 1 
    // Input: s = "abc", t = "ahbgdc"
    // Output: true
    
    // Example 2
    // Input: s = "axc", t = "ahbgdc"
    // Output: false
    public class IsSubsequence
    {
        // Time complexity: O(T)
        // Space complexity: O(1)
        public bool Subsequence(string s, string t)
        {
            if (s.Length <= 0) return true;
            if (t.Length <= 0) return false;
            int sp = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (s[sp] == t[i])
                {
                    sp++;
                    if (sp == s.Length)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
