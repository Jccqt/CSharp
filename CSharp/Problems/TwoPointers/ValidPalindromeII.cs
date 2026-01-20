using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Given a string s, return true if the s can be palindrome after deleting at most one character from it.

    // Example 1
    // Input: s = "aba"
    // Output: true

    // Example 2
    // Input: s = "abca"
    // Output: true

    // Example 3
    // Input: s = "abc"
    // Output: false
    public class ValidPalindromeII
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    if (IsPalindrome(s, left + 1, right))
                    {
                        return true;
                    }
                    else if (IsPalindrome(s, left, right - 1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                left++;
                right--;
            }

            return true;
        }

        public bool IsPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
