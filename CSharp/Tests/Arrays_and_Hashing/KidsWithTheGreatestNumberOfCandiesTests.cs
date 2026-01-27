using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class KidsWithTheGreatestNumberOfCandiesTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new KidsWithTheGreatestNumberOfCandies();

            // Act
            var result = solver.KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);

            // Assert
            Assert.Equal([true, true, true, false, true], result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new KidsWithTheGreatestNumberOfCandies();

            // Act
            var result = solver.KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);

            // Assert
            Assert.Equal([true, false, false, false, false], result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new KidsWithTheGreatestNumberOfCandies();

            // Act
            var result = solver.KidsWithCandies(new int[] { 12, 1, 12 }, 10);

            // Assert
            Assert.Equal([true, false, true], result);
        }
    }
}
