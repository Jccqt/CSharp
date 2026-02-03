using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class SingleNumberIITests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new SingleNumberII();

            // Act
            var result = solver.SingleNumber([2, 2, 3, 2]);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new SingleNumberII();

            // Act
            var result = solver.SingleNumber([0, 1, 0, 1, 0, 1, 99]);

            // Assert
            Assert.Equal(99, result);
        }
    }
}
