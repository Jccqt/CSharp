using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow
{
    // Given an array of integers arr and two integers k and threshold, return the 
    // number of sub-arrays of size k and average greater than or equal to threshold.

    // Example 1
    // Input: arr = [2,2,2,2,5,5,5,8], k = 3, threshold = 4
    // Output: 3

    // Example 2
    // Input: arr = [11,13,17,23,29,31,7,5,2,3], k = 3, threshold = 5
    // Output: 6
    public class NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            int maxCount = 0;
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += arr[i];
            }

            if (sum >= k * threshold) maxCount++;

            for (int i = k; i < arr.Length; i++)
            {
                sum -= arr[i - k];
                sum += arr[i];

                if (sum >= k * threshold) maxCount++;
            }

            return maxCount;
        }
    }
}
