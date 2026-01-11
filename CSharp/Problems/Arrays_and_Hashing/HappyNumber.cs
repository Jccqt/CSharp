using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    public class HappyNumber
    {
        // Write an algorithm to determine if a number n is happy.

        // A happy number is a number defined by the following process:
        
        // * Starting with any positive integer, replaced the number by the sum of the squares of its digits.
        // * Repeat the process until the number equals 1 (where it will stay), or it loops endlessly
        //   in a cycle which does not include 1.
        // * Those numbers for which this process ends in 1 are happy.

        // Return true if n is a happy number, and false if not.

        // Example 1
        // Input: n = 19
        // Output: true

        // Example 2
        // Input: n = 2
        // Output: false
        public bool IsHappy(int num)
        {
            // Time complexity: O(log N)
            // Space complexity: O(1)
            var seen = new HashSet<int>();

            while (num != 1 && !seen.Contains(num))
            {
                seen.Add(num);
                int sum = 0;
                while (num != 0)
                {
                    int digit = num % 10;
                    sum = sum + (digit * digit);
                    num /= 10;
                }

                num = sum;
            }

            return num == 1;
        }
    }
}
