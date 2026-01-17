using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class SquaresOfASortedArrayTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new SquaresOfASortedArray();

            // Act
            var result = solver.SortedSquares(new int[] { -4, -1, 0, 3, 10 });

            // Assert
            Assert.Equal(new int[] { 0, 1, 9, 16, 100 }, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new SquaresOfASortedArray();

            // Act
            var result = solver.SortedSquares(new int[] { -7, -3, 2, 3, 11 });

            // Assert
            Assert.Equal(new int[] { 4, 9, 9, 49, 121 }, result);
        }
    }
}
