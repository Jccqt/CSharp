using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class ContainerWithMostWaterTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ContainerWithMostWater();

            // Act
            var result = solver.MaxArea(new int[] { 1, 9, 6, 2, 5, 4, 8, 3, 7 });

            // Assert
            Assert.Equal(49, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ContainerWithMostWater();

            // Act
            var result = solver.MaxArea(new int[] { 1, 1 });

            // Assert
            Assert.Equal(1, result);
        }
    }
}
