using CSharp.Problems.SlidingWindow.VariableSized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.SlidingWindow.VariableSized
{
    public class LongestContinuousIncreasingSubsequenceTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new LongestContinuousIncreasingSubsequence();

            // Act
            var result = solver.FindLengthOfLCIS([1, 3, 5, 4, 7]);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new LongestContinuousIncreasingSubsequence();

            // Act
            var result = solver.FindLengthOfLCIS([2, 2, 2, 2, 2]);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
