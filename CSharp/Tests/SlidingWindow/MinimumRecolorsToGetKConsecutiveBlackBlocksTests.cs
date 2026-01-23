using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.SlidingWindow;

namespace CSharp.Tests.SlidingWindow
{
    public class MinimumRecolorsToGetKConsecutiveBlackBlocksTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MinimumRecolorsToGetKConsecutiveBlackBlocks();

            // Act
            var result = solver.MinimumRecolors("WBBWWBBWBW", 7);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MinimumRecolorsToGetKConsecutiveBlackBlocks();

            // Act
            var result = solver.MinimumRecolors("WBWBBBW", 2);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
