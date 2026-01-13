using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class ContainsDuplicatellTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ContainsDuplicatell();

            // Act
            var result = solver.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ContainsDuplicatell();

            // Act
            var result = solver.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new ContainsDuplicatell();

            // Act
            var result = solver.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2);

            // Assert
            Assert.False(result);
        }
    }
}
