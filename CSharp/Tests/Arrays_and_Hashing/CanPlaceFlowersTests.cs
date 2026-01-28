using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
     public class CanPlaceFlowersTests
     {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new CanPlaceFlowers();

            // Act
            var result = solver.CanPlaceFlower(new int[] { 1, 0, 0, 0, 1 }, 1);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new CanPlaceFlowers();

            // Act
            var result = solver.CanPlaceFlower(new int[] { 1, 0, 0, 0, 1 }, 2);

            // Assert
            Assert.False(result);
        }

     }
}
