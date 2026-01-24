using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp.Problems.SlidingWindow
{
    // There is a bookstore owner that has a store open for n minutes. You are given an integer array customers of length n
    // where customers[i] is the number of the customers that enter the store at the start of the ith minute and all those customers leave after the end of that minute.

    // During certain minutes, the bookstore owner is grumpy. You are given a binary array grumpy where grumpy[i] is 1
    //if the bookstore owner is grumpy during the ith minute, and is 0 otherwise.

    // When the bookstore owner is grumpy, the customers entering during that minute are not satisfied. Otherwise, they are satisfied.

    // The bookstore owner knows a secret technique to remain not grumpy for minutes consecutive minutes, but this technique can only be used once.

    // Return the maximum number of customers that can be satisfied throughout the day.

    // Example 1
    // Input: customers = [1,0,1,2,1,1,7,5], grumpy = [0,1,0,1,0,1,0,1], minutes = 3
    // Output: 16

    // Example 2
    // Input: customers = [1], grumpy = [0], minutes = 1
    // Output: 1
    public class GrumpyBookstoreOwner
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
        {
            int baseCount = 0;
            int saveCount = 0;
            int result = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                if (grumpy[i] == 0) baseCount += customers[i];
            }

            for (int i = 0; i < minutes; i++)
            {
                if (grumpy[i] == 1) saveCount += customers[i];
            }

            result = baseCount + saveCount;

            for (int i = minutes; i < customers.Length; i++)
            {
                if (grumpy[i - minutes] == 1) saveCount -= customers[i - minutes];
                if (grumpy[i] == 1) saveCount += customers[i];

                result = Math.Max(result, baseCount + saveCount);
            }

            return result;
        }
    }
}
