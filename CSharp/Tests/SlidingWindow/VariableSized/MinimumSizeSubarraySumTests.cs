using CSharp.Problems.SlidingWindow.VariableSized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.SlidingWindow.VariableSized
{
    public class MinimumSizeSubarraySumTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MinimumSizeSubarraySum();

            // Act
            var result = solver.MinSubArrayLen(7, [2, 3, 1, 2, 4, 3]);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MinimumSizeSubarraySum();

            // Act
            var result = solver.MinSubArrayLen(4, [1, 4, 4]);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new MinimumSizeSubarraySum();

            // Act
            var result = solver.MinSubArrayLen(11, [1, 1, 1, 1, 1, 1, 1, 1]);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
