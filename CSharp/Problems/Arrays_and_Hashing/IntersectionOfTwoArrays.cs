using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given two integers arrays nums1 and nums2, return an array of their intersection. 
    // Each element in the result must be unique and you may return the result in any order.

    // Example 1
    // Input: nums1 = [1,2,2,1], nums2 = [2,2]
    // Output: [2]

    // Example 2
    // Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
    // Output: [9,4]
    public class IntersectionOfTwoArrays
    {
        // Time complexity: O(N + M)
        // Space complexity: O(N)
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var res = new List<int>();
            var freq = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!freq.ContainsKey(nums1[i])) freq[nums1[i]] = 1;
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (freq.ContainsKey(nums2[i]) && freq[nums2[i]] == 1)
                {
                    res.Add(nums2[i]);
                    freq[nums2[i]] = 0;
                }
            }

            return res.ToArray();
        }
    }
}
