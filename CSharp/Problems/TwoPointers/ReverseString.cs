using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // Write a function that reverses a string.
    // The input string is given as an array of characters s.

    // You must do this by modifying the input array in-place with O(1) extra memory.

    // Example 1
    // Input: s = ["h","e","l","l","o"]
    // Output: ["o","l","l","e","h"]

    // Example 2
    // Input: s = ["H","a","n","n","a","h"]
    // Output: ["h","a","n","n","a","H"]
    public class ReverseString
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public void ReverseStringArray(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char holder = s[left];
                s[left] = s[right];
                s[right] = holder;

                left++;
                right--;
            }
        }
    }
}
