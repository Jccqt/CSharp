using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class SingleNumberIIITests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new SingleNumberIII();

            // Act
            var result = solver.SingleNumber([1, 2, 1, 3, 2, 5]);

            // Assert
            Assert.Equal([3, 5], result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new SingleNumberIII();

            // Act
            var result = solver.SingleNumber([-1, 0]);

            // Assert
            Assert.Equal([-1, 0], result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new SingleNumberIII();

            // Act
            var result = solver.SingleNumber([0, 1]);

            // Assert
            Assert.Equal([0, 1], result);
        }
    }
}
