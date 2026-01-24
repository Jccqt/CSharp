using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.SlidingWindow;

namespace CSharp.Tests.SlidingWindow
{
    public class NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThresholdTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold();

            // Act
            var result = solver.NumOfSubarrays(new int[] { 2, 2, 2, 2, 5, 5, 5, 8 }, 3, 4);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold();

            // Act
            var result = solver.NumOfSubarrays(new int[] { 11, 13, 17, 23, 29, 31, 7, 5, 2, 3 }, 3, 5);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
