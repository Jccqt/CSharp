using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.TwoPointers;
using Xunit;

namespace CSharp.Tests.TwoPointers
{
    public class MergeSortedArrayTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MergeSortedArray();
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3;
            int n = 3;

            // Act
            solver.Merge(nums1, m, nums2, n);

            // Assert
            Assert.Equal(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MergeSortedArray();
            int[] nums1 = { 1 };
            int[] nums2 = { };
            int m = 1;
            int n = 0;

            // Act
            solver.Merge(nums1, m, nums2, n);

            // Assert
            Assert.Equal(new int[] { 1 }, nums1);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new MergeSortedArray();
            int[] nums1 = { 0 };
            int[] nums2 = { 1 };
            int m = 0;
            int n = 1;

            // Act
            solver.Merge(nums1, m, nums2, n);

            // Assert
            Assert.Equal(new int[] { 1 }, nums1);
        }
    }
}
