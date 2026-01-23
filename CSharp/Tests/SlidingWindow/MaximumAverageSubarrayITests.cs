using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.SlidingWindow;

namespace CSharp.Tests.SlidingWindow
{
    public class MaximumAverageSubarrayITests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MaximumAverageSubarrayI();

            // Act
            var result = solver.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);

            // Assert
            Assert.Equal(12.75, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MaximumAverageSubarrayI();

            // Act
            var result = solver.FindMaxAverage(new int[] { 5 }, 1);

            // Assert
            Assert.Equal(5.0, result);
        }

    }
}
