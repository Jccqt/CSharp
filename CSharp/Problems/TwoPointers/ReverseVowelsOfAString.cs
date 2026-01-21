using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Given a string s, reverse only all the vowels in the string and return it.

    // The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

    // Example 1
    // Input: s = "IceCreAm"
    // Output:  "AceCreIm"

    // Example 2
    // Input: s = leetcode
    // Output: "leotcede"
    public class ReverseVowelsOfAString
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public string ReverseVowels(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] chars = s.ToCharArray();

            while (left < right)
            {
                if (!IsVowel(chars[right]))
                {
                    right--;
                    continue;
                }

                if (!IsVowel(chars[left]))
                {
                    left++;
                    continue;
                }

                char holder = chars[left];
                chars[left] = chars[right];
                chars[right] = holder;

                left++;
                right--;
            }

            return new string(chars);
        }

        public bool IsVowel(char c)
        {
            switch (c)
            {
                case 'a': return true;
                case 'A': return true;
                case 'e': return true;
                case 'E': return true;
                case 'i': return true;
                case 'I': return true;
                case 'o': return true;
                case 'O': return true;
                case 'u': return true;
                case 'U': return true;
            }

            return false;
        }

    }
}
