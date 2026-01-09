using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    public class FindTheDifferenceOfTwoArrays
    {
        // Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:
        // * answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
        // * answer[1] is a list of all distinct integers in nums2 which are not present in nums1.

        // Note that the integers in the lists may be returned in any order.

        // Example 1
        // Input: nums1 = [1,2,3], nums2 = [2,4,6]
        // Output: [[1,3], [4,6]]

        // Example 2
        // Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
        // Output: [[3],[]]
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            // Time complexity: O(N + M)
            // Space complexity: O(N + M)
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);

            var result1 = new List<int>();
            var result2 = new List<int>();

            foreach (var num in set1)
            {
                if (!set2.Contains(num))
                {
                    result1.Add(num);
                }
            }

            foreach (var num in set2)
            {
                if (!set1.Contains(num))
                {
                    result2.Add(num);
                }
            }

            return new List<IList<int>> { result1, result2 };
        }
    }
}
