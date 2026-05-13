using CSharp.Problems.SlidingWindow.VariableSized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.SlidingWindow.VariableSized
{
    public class SubarrayProductLessThanKTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new SubarrayProductLessThanK();

            // Act
            var result = solver.NumSubarrayProductLessThanK([10, 5, 2, 6], 100);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new SubarrayProductLessThanK();

            // Act
            var result = solver.NumSubarrayProductLessThanK([1, 2, 3], 0);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
