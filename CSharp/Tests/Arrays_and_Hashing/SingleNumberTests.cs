using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class SingleNumberTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new SingleNumber();

            // Act
            var result = solver.SingleNum([2, 2, 1]);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new SingleNumber();

            // Act
            var result = solver.SingleNum([4, 1, 2, 1, 2]);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new SingleNumber();

            // Act
            var result = solver.SingleNum([1]);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
