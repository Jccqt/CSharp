using CSharp.Problems.SlidingWindow.VariableSized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.SlidingWindow.VariableSized
{
    public class MaxConsecutiveOnes3Tests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MaxConsecutiveOnes3();

            // Act
            var result = solver.LongestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MaxConsecutiveOnes3();

            // Act
            var result = solver.LongestOnes([0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 3);

            // Assert
            Assert.Equal(10, result);
        }
    }
}
