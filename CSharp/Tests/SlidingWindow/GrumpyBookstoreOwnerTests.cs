using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.SlidingWindow;

namespace CSharp.Tests.SlidingWindow
{
    public class GrumpyBookstoreOwnerTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new GrumpyBookstoreOwner();

            // Act
            var result = solver.MaxSatisfied(new int[] { 1, 0, 1, 2, 1, 1, 7, 5 }, new int[] { 0, 1, 0, 1, 0, 1, 0, 1 }, 3);

            // Assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new GrumpyBookstoreOwner();

            // Act
            var result = solver.MaxSatisfied(new int[] { 1 }, new int[] { 0 }, 1);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
