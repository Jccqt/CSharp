using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    public class RansomNote
    {
        // Given two strings ransomNote and magazine, return true if ransomNote can be constructed 
        // by using the letters from magazine and false otherwise.

        // Each letter in magazine can only be used once in ransomNote.

        // Example 1
        // Input: ransomNote = "a", magazine = "b"
        // Output: false
        
        // Example 2
        // Input: ransomNote = "aa", magazine = "ab"
        // Output: false

        // Example 3
        // Input: ransomNote = "aa", magazine = "aab"
        // Output: true
        public bool CanConstruct(string ransomNote, string magazine)
        {
            // Time Complexity: O(n)
            // Space Complexity: O(1)
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (!dictionary.TryAdd(magazine[i], 1))
                {
                    dictionary[magazine[i]]++;
                }
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (dictionary.ContainsKey(ransomNote[i]) && dictionary[ransomNote[i]] > 0)
                {
                    dictionary[ransomNote[i]]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
