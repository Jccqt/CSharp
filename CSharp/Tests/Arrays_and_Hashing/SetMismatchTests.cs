using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class SetMismatchTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new SetMismatch();

            // Act
            var result = solver.FindErrorNums(new int[] { 1, 2, 2, 4 });

            // Assert
            Assert.Equal(new int[] { 2, 3 }, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new SetMismatch();

            // Act
            var result = solver.FindErrorNums(new int[] { 1, 1 });

            // Assert
            Assert.Equal(new int[] { 1, 2 }, result);
        }
    }
}
