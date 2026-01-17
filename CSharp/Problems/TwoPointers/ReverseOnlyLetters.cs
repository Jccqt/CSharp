using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Given a string s, reverse the string according to the following rules:
    // * All the characters that are not English letters remain in the same position.
    // * All the English letters (lowercase or uppercase) should be reversed.

    // Return s after revising it.

    // Example 1
    // Input: s = "ab-cd"
    // Output: "dc-ba"

    // Example 2
    // Input: s = "a-bC-dEf-ghIj"
    // Output: "j-Ih-gfE-dCba"

    // Example 3
    // Input: s = "Test1ng-Leet=code-Q!"
    // Output: "Qedo1ct-eeLg=ntse-T!"
    public class ReverseOnlyLetters
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public string ReversesOnlyLetters(string s)
        {
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                while (!char.IsLetter(chars[left]) && left < right) left++;
                while (!char.IsLetter(chars[right]) && left < right) right--;

                char holder = chars[left];
                chars[left] = chars[right];
                chars[right] = holder;
                left++;
                right--;
            }

            return new string(chars);
        }
    }
}
