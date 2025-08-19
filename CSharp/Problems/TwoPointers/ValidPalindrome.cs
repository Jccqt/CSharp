using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{

    // Problem: A phrase is a palindrome if, after converting all uppercase letters into lowercase letters 
    // and removing all non-alphanumeric characters, it reads the same forward and backward.
    // Alphanumeric characters include letters and numbers.

    // Given a string s, return true if it is a palindrome, or false otherwise.

    // Example 1:
    // Input: s = "A man, a plan, a canal: Panama"
    // Output: true
    // Explanation: "amanplanacanalpanama" is a palindrome.

    // Example 2:
    // Input: s = "race a car"
    // Output: false
    // Explanation: "raceacar" is not a palindrome.

    // Example 3:
    // Input: s = " "
    // Output: true
    // Explanation: s in an empty string "" after removing non-alphanumeric characters.
    // Since an empty string reads the same forward and backward, it is a palindrome.
    public class ValidPalindrome
    {
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        public bool IsPalindrome(string s)
        {
            string word = "";

            foreach(char c in s.ToCharArray())
            {
                if (Char.IsLetterOrDigit(c))
                {
                    word += c.ToString().ToLower();
                }
            }

            string reversed = new string(word.Reverse().ToArray());

            if (word.Equals(reversed))
            {
                return true;
            }

            return false;
        }
    }
}
